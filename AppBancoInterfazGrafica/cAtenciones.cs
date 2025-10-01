using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AppVentanillasBanco
{
    public class cAtenciones : cObjeto
    {
        //--- Atributos protegidos
        protected string aFechayhora;
        protected string aDNI;
        protected string aIdCajero;
        protected string aIdServicio;
        protected string aMonto;
        protected string aSegundos;

        //--- Contador estático de tickets
        private static int contadorTickets = 0;

        //--- Constructores
        public cAtenciones() : base()
        {
            contadorTickets++;
            aIdObjeto = contadorTickets.ToString();  // ticket único
            aFechayhora = aDNI = aIdCajero = aIdServicio = aMonto = aSegundos = "";
        }

        public cAtenciones(string pFechayhora, string pDNI, string pIdCajero, string pIdServicio, string pMonto, string pSegundos)
        {
            contadorTickets++;
            aIdObjeto = contadorTickets.ToString();  // ticket único
            aFechayhora = pFechayhora;
            aDNI = pDNI;
            aIdCajero = pIdCajero;
            aIdServicio = pIdServicio;
            aMonto = pMonto;
            aSegundos = pSegundos;
        }

        //--- Métodos Set y Get
        public string GetTicket() => aIdObjeto;
        public void SetIdObjeto(string pIdObjeto) => aIdObjeto = pIdObjeto;
        public void SetDNI(string pDNI) => aDNI = pDNI;
        public string GetDNI() => aDNI;
        public void SetFechayhora(string pFechayhora) => aFechayhora = pFechayhora;
        public string GetFechayhora() => aFechayhora;
        public void SetIdCajero(string pIdCajero) => aIdCajero = pIdCajero;
        public string GetIdCajero() => aIdCajero;
        public void SetIdServicio(string pIdServicio) => aIdServicio = pIdServicio;
        public string GetIdServicio() => aIdServicio;
        public void SetMonto(string pMonto) => aMonto = pMonto;
        public string GetMonto() => aMonto;
        public void SetSegundos(string pSegundos) => aSegundos = pSegundos;
        public string GetSegundos() => aSegundos;

        //--- Métodos de proceso
        public void LeerDatosAtenciones()
        {
            aIdObjeto = (++contadorTickets).ToString(); // genera ticket único automáticamente
            do
            {
                Console.Write("Fecha y hora (dd/mm/aaaa - hh:mm): ");
                aFechayhora = Console.ReadLine();
            } while (!cValidaciones.ValidarStringNoVacio(aFechayhora));

            do
            {
                Console.Write("DNI: ");
                aDNI = Console.ReadLine();
                if (!cValidaciones.ValidarDNI(aDNI))
                    Console.WriteLine("DNI invalido. Debe tener 8 dígitos.");
            } while (!cValidaciones.ValidarDNI(aDNI));

            do
            {
                Console.Write("Id cajero: ");
                aIdCajero = Console.ReadLine();
            } while (!cValidaciones.ValidarStringNoVacio(aIdCajero));

            do
            {
                Console.Write("Id Servicio: ");
                aIdServicio = Console.ReadLine();
            } while (!cValidaciones.ValidarStringNoVacio(aIdServicio));

            do
            {
                Console.Write("Monto: ");
                aMonto = Console.ReadLine();
                if (!cValidaciones.EsNumero(aMonto))
                    Console.WriteLine("El monto debe ser un numero.");
            } while (!cValidaciones.EsNumero(aMonto));

            do
            {
                Console.Write("Segundos: ");
                aSegundos = Console.ReadLine();
                if (!cValidaciones.EsNumero(aSegundos))
                    Console.WriteLine("Los segundos deben ser un numeros.");
            } while (!cValidaciones.EsNumero(aSegundos));
        }

        public void MostrarDatosAtenciones()
        {
            Console.WriteLine($"Nro de ticket: {aIdObjeto}");
            Console.WriteLine($"Fecha y hora: {aFechayhora}");
            Console.WriteLine($"DNI del cliente: {aDNI}");
            Console.WriteLine($"Id cajero: {aIdCajero}");
            Console.WriteLine($"Id servicio: {aIdServicio}");
            Console.WriteLine($"Monto: {aMonto}");
            Console.WriteLine($"Segundos: {aSegundos}");
        }

        public override void Leer()
        {
            Console.WriteLine();
            Console.WriteLine("\nDatos de atenciones");
            Console.WriteLine("===================");
            LeerDatosAtenciones();
        }

        public override void Mostrar()
        {
            Console.WriteLine();
            Console.WriteLine("\nDatos de atenciones");
            Console.WriteLine("===================");
            MostrarDatosAtenciones();
        }

        public override void Escribir()
        {
            Console.WriteLine($"{aIdObjeto,-8}{aFechayhora,-20}{aDNI,-12}{aIdCajero,-10}{aIdServicio,-12}{aMonto,-10}{aSegundos,-8}");
        }
        public static void ExportarATxt(List<cAtenciones> lista, string rutaArchivo)
        {
            using (StreamWriter sw = new StreamWriter(rutaArchivo))
            {
                // Ancho de columnas
                int[] anchos = { 8, 20, 12, 10, 12, 10, 8 };
                string[] headers = { "Ticket", "Fecha y Hora", "DNI", "Cajero", "Servicio", "Monto", "Segundos" };

                // Línea superior
                sw.WriteLine("+" + string.Join("+", Array.ConvertAll(anchos, a => new string('-', a))) + "+");

                // Encabezado centrado
                sw.Write("|");
                for (int i = 0; i < headers.Length; i++)
                {
                    sw.Write(CentrarTexto(headers[i], anchos[i]) + "|");
                }
                sw.WriteLine();

                // Línea separadora
                sw.WriteLine("+" + string.Join("+", Array.ConvertAll(anchos, a => new string('-', a))) + "+");

                // Filas de datos
                foreach (var at in lista)
                {
                    string[] valores = {
                    at.GetTicket(),
                    at.GetFechayhora(),
                    at.GetDNI(),
                    at.GetIdCajero(),
                    at.GetIdServicio(),
                    at.GetMonto(),
                    at.GetSegundos()
                };

                    sw.Write("|");
                    for (int i = 0; i < valores.Length; i++)
                    {
                        sw.Write(CentrarTexto(valores[i], anchos[i]) + "|");
                    }
                    sw.WriteLine();
                }

                // Línea inferior
                sw.WriteLine("+" + string.Join("+", Array.ConvertAll(anchos, a => new string('-', a))) + "+");
            }
        }

        // Función auxiliar para centrar texto en ancho fijo
        private static string CentrarTexto(string texto, int ancho)
        {
            if (texto.Length >= ancho) return texto.Substring(0, ancho);
            int espacios = ancho - texto.Length;
            int izquierda = espacios / 2;
            int derecha = espacios - izquierda;
            return new string(' ', izquierda) + texto + new string(' ', derecha);
        }
    }

}
