using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppVentanillasBanco
{
    public class cVentanilla : cObjeto
    {
        //---Atributos protegidos
        protected string aIdcajero;
        protected string aDNI;
        protected string aNroticket;
        protected string aPreferencial; // "si"/"no"
        protected string aAtendido; // "si"/"no"
        protected bool aEsPreferencial; // flag interno

        //---Constructores
        public cVentanilla() : base()
        {
            aIdcajero = aDNI = aNroticket = aPreferencial = aAtendido = "";
            aEsPreferencial = false;
        }
        public cVentanilla(string pIdObjeto, string pIdcajero, string pDNI, string pNroticket, string pPreferencial, string pAtendido)
        {
            aIdObjeto = pIdObjeto;
            aIdcajero = pIdcajero;
            aDNI = pDNI;
            aNroticket = pNroticket;
            aPreferencial = pPreferencial;
            aAtendido = pAtendido;
            aEsPreferencial = (pPreferencial?.ToLower() == "si");
        }

        //---Metodos Set y Get
        public void SetIdcajero(string pIdcajero) => aIdcajero = pIdcajero;
        public string GetIdcajero() => aIdcajero;
        public void SetDNI(string pDNI) => aDNI = pDNI;
        public string GetDNI() => aDNI;
        public void SetNroticket(string pNroticket) => aNroticket = pNroticket;
        public string GetNroticket() => aNroticket;
        public void SetPreferencial(string pPreferencial) { aPreferencial = pPreferencial; aEsPreferencial = (pPreferencial?.ToLower() == "si"); }
        public string GetPreferencial() => aPreferencial;
        public void SetAtendido(string pAtendido) => aAtendido = pAtendido;
        public string GetAtendido() => aAtendido;
        public bool EsPreferencial() => aEsPreferencial;

        //---Metodos de proceso
        public void LeerDatosVentanilla()
        {
            do
            {
                Console.Write("Nro de ventanilla: ");
                aIdObjeto = Console.ReadLine();
                if (!cValidaciones.EsNumero(aIdObjeto))
                    Console.WriteLine("El numero de ventanilla debe ser un numero.");
            } while (!cValidaciones.EsNumero(aIdObjeto));
            do
            {
                Console.Write("Id cajero: ");
                aIdcajero = Console.ReadLine();
            } while (!cValidaciones.ValidarStringNoVacio(aIdcajero));
            // Los demás pueden rellenarse al momento de asignar
        }

        public void AsignarCliente(string pDNI, string pNroticket, bool preferencial)
        {
            aDNI = pDNI;
            aNroticket = pNroticket;
            aPreferencial = preferencial ? "si" : "no";
            aAtendido = "no";
        }

        public void Liberar()
        {
            aDNI = "";
            aNroticket = "";
            aPreferencial = "no";
            aAtendido = "no";
        }

        public void MarcarAtendido()
        {
            aAtendido = "si";
        }

        public void MostrarDatosVentanilla()
        {
            Console.WriteLine($"Numero de ventanilla: {aIdObjeto}");
            Console.WriteLine($"ID cajero: {aIdcajero}");
            Console.WriteLine($"DNI cliente: {aDNI}");
            Console.WriteLine($"Nro de ticket: {aNroticket}");
            Console.WriteLine($"Preferencial: {aPreferencial}");
            Console.WriteLine($"Atendido: {aAtendido}");
        }
        public override void Leer()
        {
            Console.WriteLine("\n Datos de ventanilla");
            Console.WriteLine("====================");
            LeerDatosVentanilla();
        }
        public override void Mostrar()
        {
            Console.WriteLine("\n Datos de ventanilla");
            Console.WriteLine("====================");
            MostrarDatosVentanilla();
        }
        public override void Escribir()
        {
            Console.WriteLine($"{aIdObjeto,-6}{aIdcajero,-12}{aDNI,-12}{aNroticket,-8}{aPreferencial,-8}{aAtendido,-8}");
        }
    }
}
