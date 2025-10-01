using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppVentanillasBanco
{
    public class CLista
    {
        //********Atributos**************
        private Object aElemento;
        private CLista aSubLista;
        //********Constructores**************
        public CLista()
        {
            aElemento = null;
            aSubLista = null;
        }

        public CLista(Object pElemento, CLista pSubLista)
        {
            aElemento = pElemento;
            aSubLista = pSubLista;
        }
        // **** Propiedades ******
        public object Elemento { get => aElemento; set => aElemento = value; }
        internal CLista SubLista { get => aSubLista; set => aSubLista = value; }



        // **** Metodos ***
        // **** EstaVacia ***
        public bool EstaVacia()
        {
            return aElemento == null && aSubLista == null;
        }
        // **** Longitud ***
        public int Longitud()
        {
            if (EstaVacia())
                return 0;
            else
                return 1 + aSubLista.Longitud();
        }
        // **** Agregar ***
        public void Agregar(Object pElemento)
        {
            if (EstaVacia())
            {
                Elemento = pElemento;
                SubLista = new CLista();
            }
            else
            {
                SubLista.Agregar(pElemento);
            }

        }
        // **** Agregar ***
        public void Mostrar()
        {
            if (!EstaVacia())
            {
                if (Elemento is cObjeto co)
                {
                    co.Escribir();  
                                    
                }
                else
                {
                    Console.WriteLine(Elemento.ToString());
                }
                SubLista?.Mostrar();
            }
        }

        // **** Eliminar ***
        public void Eliminar(int posicion)
        {
            if (posicion == 1)
            {
                Elemento = SubLista.Elemento;
                SubLista = SubLista.SubLista;
            }
            else
            {
                SubLista.Eliminar(posicion - 1);
            }
        }
        // **** Ubicacion ***
        public int Ubicacion(Object pElemento)
        {
            if (EstaVacia())
            {
                return 0;
            }
            else
            {
                return Elemento.Equals(pElemento) ? 1 : 1 + SubLista.Ubicacion(pElemento);
            }
        }

        // **** Iesimo ***
        public Object Iesimo(int posicion)
        {
            if (posicion == 1)
            {
                return Elemento;
            }
            else
            {
                return SubLista.Iesimo(posicion - 1);
            }
        }
        // **** Iesimo ***
        public void Insertar(int posicion, Object pElemento)
        {
            if (posicion == 1)
            {
                SubLista = new CLista(Elemento, SubLista);
                Elemento = pElemento;
            }
            else
            {
                SubLista.Insertar(posicion - 1, pElemento);
            }
        }
        //---Modulo para verificar si los elementos de la lista esta ordenada
        public bool EstaOrdenada()
        {
            if (EstaVacia() || SubLista.EstaVacia())
                return true;
            if (string.Compare(Elemento.ToString(), SubLista.Elemento.ToString(), StringComparison.OrdinalIgnoreCase) > 0)
                return false; //---El actual es mayor que el siguiente = desordenado

            return SubLista.EstaOrdenada();
        }

        //---Modulo para eliminar las ocurrencias en una lista
        public void EliminarOcurrencias(Object pElemento)
        {
            if (EstaVacia())
                return;

            if (Elemento.Equals(pElemento))
            {
                //---Reemplazando el actual con el siguiente
                if (SubLista != null)
                {
                    Elemento = SubLista.Elemento;
                    SubLista = SubLista.SubLista;
                    EliminarOcurrencias(pElemento);
                }
                else
                {
                    Elemento = null;
                    SubLista = null;
                }
            }
            else
            {
                SubLista?.EliminarOcurrencias(pElemento);
            }
        }
    }
}
