using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using AppVentanillasBanco;

public static class cExportador
{
    //---Metodo para exportar a un archivo txt usando CLista
    public static void ExportarTxtHistorial(CLista historial, string ruta)
    {
        using (var sw = new StreamWriter(ruta, false, Encoding.UTF8))
        {
            ExportarRecursivo(historial, sw);
        }
    }

    // --- método recursivo privado para recorrer CLista
    private static void ExportarRecursivo(CLista lista, StreamWriter sw)
    {
        if (lista == null || lista.EstaVacia())
            return;

        if (lista.Elemento is cAtenciones a)
        {
            sw.WriteLine(
                $"Ticket: {a.GetIdObjeto()}  " +
                $"FechaHora: {a.GetFechayhora()}  " +
                $"DNI: {a.GetDNI()}  " +
                $"Cajero: {a.GetIdCajero()}  " +
                $"Servicio: {a.GetIdServicio()}  " +
                $"Monto: {a.GetMonto()}  " +
                $"Segundos: {a.GetSegundos()}"
            );
        }

        ExportarRecursivo(lista.SubLista, sw);
    }

    // --- exportar transacciones agrupadas por cliente (ej: últimos 2 meses)
    public static void ExportarTxtTransaccionesPorCliente(CLista grupos, string ruta)
    {
        using (var sw = new StreamWriter(ruta, false, Encoding.UTF8))
        {
            ExportarGrupoRecursivo(grupos, sw, "CLIENTE");
        }
    }

    // --- exportar atenciones agrupadas por ventanilla
    public static void ExportarTxtAtencionesPorVentanilla(CLista grupos, string ruta)
    {
        using (var sw = new StreamWriter(ruta, false, Encoding.UTF8))
        {
            ExportarGrupoRecursivo(grupos, sw, "VENTANILLA");
        }
    }

    // --- método genérico para imprimir grupos con subtotales
    private static void ExportarGrupoRecursivo(CLista lista, StreamWriter sw, string tipo)
    {
        if (lista == null || lista.EstaVacia())
            return;

        if (lista.Elemento is GrupoReporte grupo)
        {
            sw.WriteLine($"===== {tipo}: {grupo.Clave} =====");

            // ✅ Reemplazamos el foreach por un for con Iesimo()
            for (int i = 1; i <= grupo.Atenciones.Longitud(); i++)
            {
                var a = grupo.Atenciones.Iesimo(i) as cAtenciones;
                if (a != null)
                {
                    sw.WriteLine(
                        $"  Ticket: {a.GetIdObjeto()}  Fecha: {a.GetFechayhora()}  " +
                        $"Servicio: {a.GetIdServicio()}  Monto: {a.GetMonto()}"
                    );
                }
            }

            sw.WriteLine($"  TOTAL ATENCIONES: {grupo.Atenciones.Longitud()}");
            sw.WriteLine();
        }

        ExportarGrupoRecursivo(lista.SubLista, sw, tipo);
    }

}

// Clase auxiliar para los reportes agrupados
internal class GrupoReporte
{
    public string Clave { get; set; }          // puede ser DNI del cliente o ID de ventanilla
    public CLista Atenciones { get; set; }     // lista recursiva de atenciones

    public GrupoReporte(string clave)
    {
        Clave = clave;
        Atenciones = new CLista();
    }
}
