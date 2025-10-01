using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppVentanillasBanco
{
    public class cServicios : cObjeto
    {
        //---Atributos
        protected string aDescripcion;

        //---Constructores
        public cServicios()
        {
            aIdObjeto = aDescripcion = "";
        }
        public cServicios(string pIdobjeto, string pDescripcion)
        {
            aIdObjeto = pIdobjeto;
            aDescripcion = pDescripcion;
        }

        //---Metodos set y get
        public void SetDescripcion(string pDescripcion) { aDescripcion = pDescripcion; }
        public string GetDescripcion() { return aDescripcion; }

        //---Metodos de proceso
        public void LeerDatosServicios()
        {
            do
            {
                Console.Write("Id Servicio: ");
                aIdObjeto = Console.ReadLine();
            } while (!cValidaciones.ValidarStringNoVacio(aIdObjeto));

            do
            {
                Console.Write("Descripcion: ");
                aDescripcion = Console.ReadLine();
            } while (!cValidaciones.ValidarStringNoVacio(aDescripcion));
        }

        public void MostrarDatosServicios()
        {
            Console.WriteLine($"Id servicio: {aIdObjeto}");
            Console.WriteLine($"Descripcion: {aDescripcion}");
        }
        public override void Leer()
        {
            Console.WriteLine("\nDatos de servicio");
            LeerDatosServicios();
        }
        public override void Mostrar()
        {
            Console.WriteLine("\nDatos de servicio");
            MostrarDatosServicios();
        }
        public override void Escribir()
        {
            Console.WriteLine($"{aIdObjeto,-12}{aDescripcion,-20}");
        }
    }
}
