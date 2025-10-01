using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppVentanillasBanco
{
    public class cCliente : cObjeto
    {
        //---Atributos protegidos
        protected string aNombres;
        protected string aFechaNacimiento; // dd/mm/yyyy
        protected string aDiscapacidad; // "si"/"no"
        protected string aNinos; // "si"/"no"
        protected string aEmail;
        protected string aTelefono;
        protected string aMonto;

        //---Constructores
        public cCliente() : base()
        {
            aNombres = aFechaNacimiento = aDiscapacidad = aNinos = aEmail = aTelefono = aMonto = "";
        }
        public cCliente(string pIdObjeto, string pNombres, string pFechaNacimiento, string pDiscapacidad, string pNinos, string pEmail, string pTelefono, string pMonto)
        {
            aIdObjeto = pIdObjeto;
            aNombres = pNombres;
            aFechaNacimiento = pFechaNacimiento;
            aDiscapacidad = pDiscapacidad;
            aNinos = pNinos;
            aEmail = pEmail;
            aTelefono = pTelefono;
            aMonto = pMonto;
        }

        //---Metodos Set y Get
        public void SetNombres(string pNombres) => aNombres = pNombres;
        public string GetNombres() => aNombres;
        public void SetFechaNacimiento(string pFechaNacimiento) => aFechaNacimiento = pFechaNacimiento;
        public string GetFechaNacimiento() => aFechaNacimiento;
        public void SetDiscapacidad(string pDiscapacidad) => aDiscapacidad = pDiscapacidad;
        public string GetDiscapacidad() => aDiscapacidad;
        public void SetNinos(string pNinos) => aNinos = pNinos;
        public string GetNinos() => aNinos;
        public void SetEmail(string pEmail) => aEmail = pEmail;
        public string GetEmail() => aEmail;
        public void SetTelefono(string pTelefono) => aTelefono = pTelefono;
        public string GetTelefono() => aTelefono;
        public void SetMonto(string pMonto) => aMonto = pMonto;
        public string GetMonto() => aMonto;

        //---Metodos de proceso
        public void LeerDatosCliente()
        {
            do
            {
                Console.Write("DNI: ");
                aIdObjeto = Console.ReadLine();
                if (!cValidaciones.ValidarDNI(aIdObjeto))
                    Console.WriteLine("DNI invalido. Debe tener 8 dígitos.");
            } while (!cValidaciones.ValidarDNI(aIdObjeto));

            do
            {
                Console.Write("Fecha de nacimiento (dd/mm/yyyy): ");
                aFechaNacimiento = Console.ReadLine();
                if (!cValidaciones.ValidarFecha(aFechaNacimiento))
                    Console.WriteLine("Fecha no correcta.");
            } while (!cValidaciones.ValidarFecha(aFechaNacimiento));

            do
            {
                Console.Write("Nombres: ");
                string Mnombres = Console.ReadLine();
                aNombres = cValidaciones.ConvertirMayusculas(Mnombres);

                if (!cValidaciones.ValidarStringNoVacio(aNombres))
                    Console.WriteLine("Error: El nombre no puede estar vacío.");
                else if (!cValidaciones.ValidarSoloLetras(aNombres, true))
                    Console.WriteLine("Error: Solo se permiten letras y espacios.");

            } while (!cValidaciones.ValidarStringNoVacio(aNombres) ||
                     !cValidaciones.ValidarSoloLetras(aNombres, true));

            do
            {
                Console.Write("Tiene discapacidad (si/no): ");
                aDiscapacidad = Console.ReadLine();
                if (!cValidaciones.ValidarSiNo(aDiscapacidad))
                    Console.WriteLine("La respuesta debe ser si o no.");
            } while (!cValidaciones.ValidarSiNo(aDiscapacidad));

            do
            {
                Console.Write("Tiene ninos (si/no): ");
                aNinos = Console.ReadLine();
                if (!cValidaciones.ValidarSiNo(aNinos))
                    Console.WriteLine("La respuesta debe ser si o no");
            } while (!cValidaciones.ValidarSiNo(aNinos));

            do
            {
                Console.Write("Email: ");
                aEmail = Console.ReadLine();
                if (!cValidaciones.ValidarEmail(aEmail))
                    Console.WriteLine("Un Email debe contener @gmail.com, etc.");
            } while (!cValidaciones.ValidarEmail(aEmail));

            do
            {
                Console.Write("Numero de telefono: ");
                aTelefono = Console.ReadLine();
                if (!cValidaciones.EsNumero(aTelefono))
                {
                    Console.WriteLine("Error: Solo debe contener números.");
                }
                else if (aTelefono.Length != 9)
                {
                    Console.WriteLine("Error: Debe tener 9 dígitos.");
                }
                else if (!aTelefono.StartsWith("9"))
                {
                    Console.WriteLine("Error: Debe comenzar con 9.");
                }
                else
                {
                    break;
                }
            } while (true);

            do
            {
                Console.Write("Monto: ");
                aMonto = Console.ReadLine();
                if (!cValidaciones.EsNumero(aMonto))
                    Console.WriteLine("El monto debe ser un numero.");
            } while (!cValidaciones.EsNumero(aMonto));
        }

        public void MostrarDatosCliente()
        {
            Console.WriteLine($"DNI: {aIdObjeto}");
            Console.WriteLine($"Nombres: {aNombres}");
            Console.WriteLine($"Fecha de nacimiento: {aFechaNacimiento}");
            Console.WriteLine($"Discapacidad: {aDiscapacidad}");
            Console.WriteLine($"Niños: {aNinos}");
            Console.WriteLine($"Email: {aEmail}");
            Console.WriteLine($"Telefono: {aTelefono}");
            Console.WriteLine($"Monto: {aMonto}");
        }

        public override void Leer()
        {
            Console.WriteLine("\n Datos del cliente");
            Console.WriteLine("==================");
            LeerDatosCliente();
        }
        public override void Mostrar()
        {
            Console.WriteLine("\n Datos del cliente");
            Console.WriteLine("==================");
            MostrarDatosCliente();
        }
        public override void Escribir()
        {
            Console.WriteLine($"{aIdObjeto,-12}{aNombres,-25}{aFechaNacimiento,-12}{aDiscapacidad,-6}{aNinos,-6}{aEmail,-20}{aTelefono,-10}{aMonto,10}");
        }

        // Helper: calcula edad aproximada en años a partir de fecha dd/mm/yyyy
        public int ObtenerEdad()
        {
            if (string.IsNullOrWhiteSpace(aFechaNacimiento)) return 0;
            try
            {
                var parts = aFechaNacimiento.Split('/');
                int d = int.Parse(parts[0]), m = int.Parse(parts[1]), y = int.Parse(parts[2]);
                var fecha = new DateTime(y, m, d);
                var hoy = DateTime.Today;
                int edad = hoy.Year - fecha.Year;
                if (fecha > hoy.AddYears(-edad)) edad--;
                return edad;
            }
            catch
            {
                return 0;
            }
        }
    }
}
