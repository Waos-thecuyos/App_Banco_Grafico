using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppVentanillasBanco
{
    internal static class PrioridadHelper
    {
        // Valores menores => mayor prioridad
        // Discapacidad -> 0
        // Con hijos -> 1
        // Mayor de 60 -> 2
        // Normal -> 3
        // Si quieres que "monto" influya, se puede añadir aquí.
        public static int CalcularPrioridad(cCliente cliente, cServicios servicio = null)
        {
            if (cliente == null) return int.MaxValue;

            string dis = cliente.GetDiscapacidad()?.ToLower() ?? "no";
            string hijos = cliente.GetNinos()?.ToLower() ?? "no";
            int edad = cliente.ObtenerEdad();

            if (dis == "si") return 0;
            if (hijos == "si") return 1;
            if (edad >= 60) return 2;

            // opcional: usar monto para reducir prioridad en casos especiales
            // if (int.TryParse(cliente.GetMonto(), out int m) && m > 10000) return 2;

            return 3;
        }

        // Tiempo de atencion (segundos) según reglas:
        // - Personas con ninos: 5s
        // - Mayores de 60: 7s
        // - Con discapacidad: 6s
        // - Clientes normales: 3-5s (aleatorio)
        public static int CalcularSegundosAtencion(cCliente cliente)
        {
            if (cliente == null) return 3;
            if (cliente.GetDiscapacidad()?.ToLower() == "si") return 6;
            if (cliente.GetNinos()?.ToLower() == "si") return 5;
            if (cliente.ObtenerEdad() >= 60) return 7;
            // normal 3 a 5
            Random r = new Random();
            return r.Next(3, 6); // 3,4,5
        }
    }
}
