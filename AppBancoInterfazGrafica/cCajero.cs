using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppVentanillasBanco
{
    public class cCajero : cObjeto
    {
        //---Atributos protegidos
        protected string aNombres;
        protected string aDireccion;
        protected string aEmail;
        protected string aTelefono;

        //---Constructores
        public cCajero() : base()
        {
            aIdObjeto = aNombres = aDireccion = aEmail = aTelefono = "";
        }
        public cCajero(string pIdObjeto, string pNombres, string pDireccion, string pEmail, string pTelefono)
        {
            aIdObjeto = pIdObjeto;
            aNombres = pNombres;
            aDireccion = pDireccion;
            aEmail = pEmail;
            aTelefono = pTelefono;
        }

        //---Metodos set y get
        public void SetNombres(string pNombres) => aNombres = pNombres;
        public string GetNombres() => aNombres;
        public void SetDireccion(string pDireccion) => aDireccion = pDireccion;
        public string GetDireccion() => aDireccion;
        public void SetEmail(string pEmail) => aEmail = pEmail;
        public string GetEmail() => aEmail;
        public void SetTelefono(string pTelefono) => aTelefono = pTelefono;
        public string GetTelefono() => aTelefono;

        //---Metodos de proceso
        public void LeerDatosCajero()
        {
            do
            {
                Console.Write("Id Cajero: ");
                aIdObjeto = Console.ReadLine();
            } while (!cValidaciones.ValidarStringNoVacio(aIdObjeto));

            do
            {
                Console.Write("Nombres: ");
                aNombres = Console.ReadLine();
            } while (!cValidaciones.ValidarStringNoVacio(aNombres));
            do
            {
                Console.Write("Direccion: ");
                aDireccion = Console.ReadLine();
            } while (!cValidaciones.ValidarStringNoVacio(aDireccion));

            do
            {
                Console.Write("Email: ");
                aEmail = Console.ReadLine();
                if (!cValidaciones.ValidarEmail(aEmail))
                    Console.WriteLine("Un Email debe contener @gmail.com, etc.");
            } while (!cValidaciones.ValidarEmail(aEmail));

            do
            {
                Console.Write("Número de Celular: ");
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
        }
        public void MostrarDatosCajero()
        {
            Console.WriteLine($"Id cajero: {aIdObjeto}");
            Console.WriteLine($"Nombres: {aNombres}");
            Console.WriteLine($"Direccion: {aDireccion}");
            Console.WriteLine($"Email: {aEmail}");
            Console.WriteLine($"Telefono: {aTelefono}");
        }
        public override void Leer()
        {
            Console.WriteLine();
            Console.WriteLine("Datos del cajero");
            Console.WriteLine("----------------");
            LeerDatosCajero();
        }
        public override void Mostrar()
        {
            Console.WriteLine();
            Console.WriteLine("Datos del cajero");
            Console.WriteLine("----------------");
            MostrarDatosCajero();
        }
        public override void Escribir()
        {
            Console.WriteLine($"{aIdObjeto,-12}{aNombres,-20}{aDireccion,-20}{aEmail,-20}{aTelefono,10}");
        }
    }
}
