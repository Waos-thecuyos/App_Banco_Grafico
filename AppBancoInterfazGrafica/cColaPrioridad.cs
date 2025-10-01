using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppVentanillasBanco
{
    public class cColaPrioridad
    {
        //--- Atributos
        private object aElemento;
        private cColaPrioridad aSubCola;
        private int aPrioridad;
        private int aCapacidad;   // -1 para ilimitada (preferencial)

        //--- Constructores
        public cColaPrioridad()
        {
            this.aElemento = null;
            this.aSubCola = null;
            this.aPrioridad = int.MaxValue;
            this.aCapacidad = -1;
        }

        public cColaPrioridad(object pElemento, int pPrioridad, int pCapacidad)
        {
            this.aElemento = pElemento;
            this.aPrioridad = pPrioridad;
            this.aCapacidad = pCapacidad;
            this.aSubCola = null;
        }

        //--- Propiedades 
        public object Elemento { get => aElemento; set => aElemento = value; }
        internal cColaPrioridad SubCola { get => aSubCola; set => aSubCola = value; }
        public int Prioridad { get => aPrioridad; set => aPrioridad = value; }
        public int Capacidad { get => aCapacidad; set => aCapacidad = value; }

        //--- Métodos 
        public bool EstaVacia()
        {
            return Elemento == null && SubCola == null;
        }

        public int Tamanio()
        {
            if (EstaVacia()) return 0;
            return 1 + (SubCola == null ? 0 : SubCola.Tamanio());
        }

        public bool EstaLlena()
        {
            if (Capacidad == -1) return false;
            return Tamanio() >= Capacidad;
        }

        
        public void Encolar(object pElemento, int prioridad)
        {
            if (EstaLlena())
            {
                return;
            }

            if (EstaVacia())
            {
                aElemento = pElemento;
                aPrioridad = prioridad;
                aSubCola = new cColaPrioridad();
                aSubCola.Capacidad = this.Capacidad;
            }
            else if (prioridad < this.aPrioridad)
            {
                cColaPrioridad nueva = new cColaPrioridad(this.aElemento, this.aPrioridad, this.Capacidad);
                nueva.aSubCola = this.aSubCola;
                this.aElemento = pElemento;
                this.aPrioridad = prioridad;
                this.aSubCola = nueva;
            }
            else
            {
                aSubCola.Encolar(pElemento, prioridad);
            }
        }

        //---Encolar cCliente calculando prioridad automáticamente
        public void EncolarCliente(cCliente cliente, cServicios servicio = null)
        {
            int pr = PrioridadHelper.CalcularPrioridad(cliente, servicio);
            Encolar(cliente, pr);
        }

        public object Desencolar()
        {
            if (EstaVacia()) return null;

            object atendido = aElemento;
            aElemento = aSubCola.Elemento;
            aPrioridad = aSubCola.Prioridad;
            aSubCola = aSubCola.SubCola;

            return atendido;
        }


        public object Primero()
        {
            if (EstaVacia())
                return null;
            return aElemento;
        }

        public cCliente PrimeroCliente()
        {
            return Primero() as cCliente;
        }

        public void Mostrar()
        {
            if (!EstaVacia())
            {
                Console.WriteLine($"Elemento: {aElemento}, Prioridad: {aPrioridad}");
                if (SubCola != null) SubCola.Mostrar();
            }
        }
    }

}
