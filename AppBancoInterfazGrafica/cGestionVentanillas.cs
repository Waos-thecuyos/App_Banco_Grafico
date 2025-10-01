using System;
using System.Globalization;
using System.IO;
using System.Threading;
using AppVentanillasBanco;

public class cGestionVentanillas
{
    private CLista Ventanillas;
    private CLista Cajeros;
    private CLista Servicios;
    private CLista Historial;
    private CLista atenciones;

    public cColaPrioridad ColaPreferencial { get; private set; }
    public cColaPrioridad ColaNormal { get; private set; }

    private int siguienteTicket = 1;

    public cGestionVentanillas(CLista atenciones)
    {
        this.atenciones = atenciones;
        Ventanillas = new CLista();
        Cajeros = new CLista();
        Servicios = new CLista();
        Historial = new CLista();

        ColaPreferencial = new cColaPrioridad();
        ColaPreferencial.Capacidad = -1; // ilimitada
        ColaNormal = new cColaPrioridad();
        ColaNormal.Capacidad = 1000;
    }

    public void AgregarCajero(cCajero cajero)
    {
        Cajeros.Agregar(cajero);
    }

    public void AgregarVentanilla(cVentanilla ventanilla)
    {
        Ventanillas.Agregar(ventanilla);
    }

    public void AgregarServicio(cServicios servicio)
    {
        Servicios.Agregar(servicio);
    }

    // Genera ticket y encola cliente
    public string GenerarTicketYEncolar(cCliente cliente, cServicios servicio)
    {
        string nroTicket = siguienteTicket.ToString("D4");
        siguienteTicket++;

        int prioridad = PrioridadHelper.CalcularPrioridad(cliente, servicio);

        if (prioridad <= 2)
        {
            ColaPreferencial.Encolar(cliente, prioridad);
            Console.WriteLine($"Encolado (preferencial) DNI {cliente.GetIdObjeto()} ticket {nroTicket} prioridad {prioridad}");
        }
        else
        {
            ColaNormal.Encolar(cliente, prioridad);
            Console.WriteLine($"Encolado (normal) DNI {cliente.GetIdObjeto()} ticket {nroTicket} prioridad {prioridad}");
        }

        return nroTicket;
    }

    // Busca ventanilla libre
    private cVentanilla BuscarVentanillaLibre(bool preferencialOnly = false)
    {
        for (int i = 1; i <= Ventanillas.Longitud(); i++)
        {
            var v = Ventanillas.Iesimo(i) as cVentanilla;
            if (v != null && string.IsNullOrWhiteSpace(v.GetDNI()))
            {
                if (preferencialOnly && !v.EsPreferencial()) continue;
                return v;
            }
        }
        return null;
    }

    // Procesa la siguiente atención
    public bool ProcesarSiguiente()
    {
        cCliente cliente = null;
        bool esPreferencial = false;

        if (!ColaPreferencial.EstaVacia())
        {
            cliente = ColaPreferencial.PrimeroCliente();
            ColaPreferencial.Desencolar();
            esPreferencial = true;
        }
        else if (!ColaNormal.EstaVacia())
        {
            cliente = ColaNormal.PrimeroCliente();
            ColaNormal.Desencolar();
        }

        if (cliente == null) return false;

        cVentanilla vent = esPreferencial
            ? BuscarVentanillaLibre(true) ?? BuscarVentanillaLibre(false)
            : BuscarVentanillaLibre(false);

        if (vent == null)
        {
            Console.WriteLine("No hay ventanillas libres.");
            return false;
        }

        // Simulamos asignar servicio al azar
        cServicios servicio = Servicios.Longitud() > 0 ? (cServicios)Servicios.Iesimo(1) : new cServicios("S000", "Generico");

        int segundos = PrioridadHelper.CalcularSegundosAtencion(cliente);

        var att = new cAtenciones(
            DateTime.Now.ToString("dd/MM/yyyy - HH:mm:ss"),
            cliente.GetIdObjeto(),
            vent.GetIdcajero() ?? "",
            servicio.GetIdObjeto(),
            cliente.GetMonto(),
            segundos.ToString()
        );

        Console.WriteLine($"Atendiendo DNI {cliente.GetIdObjeto()} en ventanilla {vent.GetIdObjeto()} por {segundos} segundos...");
        Thread.Sleep(segundos * 1000);

        vent.MarcarAtendido();
        Historial.Agregar(att);
        atenciones.Agregar(att);

        vent.Liberar();

        Console.WriteLine($"Atención finalizada (DNI {cliente.GetIdObjeto()}) - ticket {att.GetTicket()} registrado.");
        return true;
    }

    public void ProcesarTodo(int maxAtenciones = 1000)
    {
        int atendidos = 0;
        while (atendidos < maxAtenciones)
        {
            if (!ProcesarSiguiente()) break;
            atendidos++;
        }
    }

    // ----------------- Exportar Transacciones por Cliente -----------------
    public void ExportarTransaccionesPorCliente(string ruta)
    {
        if (string.IsNullOrWhiteSpace(ruta)) ruta = "ReporteTransaccionesClientes.txt";

        DateTime hoy = DateTime.Now;
        DateTime hace2Meses = hoy.AddMonths(-2);
        CLista grupos = new CLista();

        string[] formatos = { "dd/MM/yyyy - HH:mm:ss", "dd/MM/yyyy - HH:mm" };

        for (int i = 1; i <= atenciones.Longitud(); i++)
        {
            var a = atenciones.Iesimo(i) as cAtenciones;
            if (a == null) continue;

            string idServ = a.GetIdServicio();
            if (idServ != "S001" && idServ != "S002") continue;

            DateTime fecha;
            if (!DateTime.TryParseExact(a.GetFechayhora(), formatos, CultureInfo.InvariantCulture, DateTimeStyles.None, out fecha))
            {
                if (!DateTime.TryParse(a.GetFechayhora().Split('-')[0].Trim(), out fecha))
                    continue;
            }

            if (fecha < hace2Meses || fecha > hoy) continue;

            string dni = a.GetDNI();
            bool encontrado = false;
            for (int g = 1; g <= grupos.Longitud(); g++)
            {
                var gg = grupos.Iesimo(g) as GrupoTransacciones;
                if (gg != null && gg.DNI == dni)
                {
                    gg.Atenciones.Agregar(a);
                    encontrado = true;
                    break;
                }
            }
            if (!encontrado)
            {
                var nuevo = new GrupoTransacciones(dni);
                nuevo.Atenciones.Agregar(a);
                grupos.Agregar(nuevo);
            }
        }

        using (var sw = new StreamWriter(ruta))
        {
            sw.WriteLine("==== REPORTE DE TRANSACCIONES POR CLIENTE (ULTIMOS 2 MESES) ====");
            if (grupos.EstaVacia())
            {
                sw.WriteLine("No se encontraron transacciones.");
            }
            else
            {
                for (int g = 1; g <= grupos.Longitud(); g++)
                {
                    var gg = grupos.Iesimo(g) as GrupoTransacciones;
                    if (gg == null) continue;

                    sw.WriteLine($"-- Cliente DNI: {gg.DNI} --");
                    for (int k = 1; k <= gg.Atenciones.Longitud(); k++)
                    {
                        var a = gg.Atenciones.Iesimo(k) as cAtenciones;
                        if (a == null) continue;
                        sw.WriteLine($"{a.GetFechayhora()}  |  {a.GetIdServicio()}  |  {a.GetMonto()}  |  {a.GetSegundos()} seg");
                    }
                    sw.WriteLine();
                }
            }
        }

        Console.WriteLine($"Reporte exportado a {ruta}");
    }

    // ----------------- Exportar Atenciones por Ventanilla -----------------
    public void ExportarAtencionesPorVentanilla(string ruta)
    {
        if (string.IsNullOrWhiteSpace(ruta)) ruta = "ReporteAtencionesVentanilla.txt";

        CLista grupos = new CLista();

        for (int i = 1; i <= atenciones.Longitud(); i++)
        {
            var a = atenciones.Iesimo(i) as cAtenciones;
            if (a == null) continue;

            string cajero = a.GetIdCajero() ?? "SIN_CAJERO";
            bool encontrado = false;
            for (int g = 1; g <= grupos.Longitud(); g++)
            {
                var gv = grupos.Iesimo(g) as GrupoVentanilla;
                if (gv != null && gv.CajeroId == cajero)
                {
                    gv.Atenciones.Agregar(a);
                    encontrado = true;
                    break;
                }
            }
            if (!encontrado)
            {
                var nuevo = new GrupoVentanilla(cajero);
                nuevo.Atenciones.Agregar(a);
                grupos.Agregar(nuevo);
            }
        }

        using (var sw = new StreamWriter(ruta))
        {
            sw.WriteLine("==== REPORTE DE ATENCIONES AGRUPADO POR VENTANILLA ====");
            if (grupos.EstaVacia())
            {
                sw.WriteLine("No hay atenciones registradas.");
            }
            else
            {
                for (int g = 1; g <= grupos.Longitud(); g++)
                {
                    var gv = grupos.Iesimo(g) as GrupoVentanilla;
                    if (gv == null) continue;

                    sw.WriteLine($"-- Cajero: {gv.CajeroId} --");
                    for (int k = 1; k <= gv.Atenciones.Longitud(); k++)
                    {
                        var a = gv.Atenciones.Iesimo(k) as cAtenciones;
                        if (a == null) continue;
                        sw.WriteLine($"{a.GetFechayhora()} | {a.GetDNI()} | {a.GetIdServicio()} | {a.GetMonto()} | {a.GetSegundos()} seg");
                    }
                    sw.WriteLine();
                }
            }
        }

        Console.WriteLine($"Reporte exportado a {ruta}");
    }

    // ===== Clases auxiliares para agrupación =====
    private class GrupoTransacciones
    {
        public string DNI;
        public CLista Atenciones = new CLista();
        public GrupoTransacciones(string dni) { DNI = dni; }
    }

    private class GrupoVentanilla
    {
        public string CajeroId;
        public CLista Atenciones = new CLista();
        public GrupoVentanilla(string id) { CajeroId = id; }
    }
}
