using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppVentanillasBanco
{
    public class cObjeto
    {
        //---Atributo protegido
        protected string aIdObjeto;

        //---construrctores
        public cObjeto()
        {
            aIdObjeto = "";
        }
        public cObjeto(string pIdObjeto)
        {
            aIdObjeto = pIdObjeto;
        }

        //---Metodos set y get
        public void SetIdObjeto(string pIdObjeto) { aIdObjeto = pIdObjeto; }
        public string GetIdObjeto() { return aIdObjeto; }

        //---Metodos de proceso
        public void LeerDatosObjeto()
        {
            Console.Write("Identificador del objeto: ");
            aIdObjeto = Console.ReadLine();
        }
        public void MostrarDatosObjeto()
        {
            Console.WriteLine($"Identificador del objeto: {aIdObjeto}");
        }
        public virtual void Leer()
        {
            Console.WriteLine("\nDatos del objeto");
            Console.WriteLine("-----------------");
            LeerDatosObjeto();
        }
        public virtual void Mostrar()
        {
            Console.WriteLine("\nDatos del objeto");
            Console.WriteLine("-----------------");
            MostrarDatosObjeto();
        }

        public virtual void Escribir()
        {
            Console.WriteLine($"{aIdObjeto,-12}");
        }
    }
}
