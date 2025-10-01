using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppVentanillasBanco
{
    public static class cValidaciones
    {
        //---Método para validar que el string no esté vacío
        public static bool ValidarStringNoVacio(string valor)
        {
            foreach (char c in valor)
            {
                if (c != ' ')
                    return true;
            }
            return false;
        }

        //---Validar entero en rango
        public static bool ValidarEntero(int valor, int min, int max)
        {
            return valor >= min && valor <= max;
        }

        //---Validar flotante en rango
        public static bool ValidarFlotante(float valor, float min, float max)
        {
            return valor >= min && valor <= max;
        }

        //---Validar número de DNI
        public static bool ValidarDNI(string dni)
        {
            if (dni.Length != 8) return false;
            foreach (char c in dni)
            {
                if (!char.IsDigit(c)) return false;
            }
            return true;
        }

        //---Validar CEP o CPM
        public static bool ValidarC(string c)
        {
            if (c.Length != 6) return false;
            foreach (char ch in c)
            {
                if (!char.IsDigit(ch)) return false;
            }
            return true;
        }

        //---Validar email con dominio gmail.com
        public static bool ValidarEmail(string email)
        {
            int pos = email.IndexOf('@');
            if (pos == -1 || pos == email.Length - 1) return false;

            string dominio = email.Substring(pos + 1);
            return dominio == "gmail.com";
        }


        //---Validar fecha en formato dd/mm/yyyy
        public static bool ValidarFecha(string fecha)
        {
            if (fecha.Length != 10) return false;
            if (fecha[2] != '/' || fecha[5] != '/') return false;

            for (int i = 0; i < 10; i++)
            {
                if (i == 2 || i == 5) continue;
                if (!char.IsDigit(fecha[i])) return false;
            }

            int dia = int.Parse(fecha.Substring(0, 2));
            int mes = int.Parse(fecha.Substring(3, 2));
            int anio = int.Parse(fecha.Substring(6, 4));

            if (anio < 2000 || anio > 2026) return false;
            if (mes < 1 || mes > 12) return false;

            int[] diasPorMes = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            bool bisiesto = (anio % 4 == 0 && anio % 100 != 0) || (anio % 400 == 0);
            if (bisiesto && mes == 2) diasPorMes[1] = 29;

            return dia >= 1 && dia <= diasPorMes[mes - 1];
        }

        //---Validar género
        public static bool ValidarGenero(string genero)
        {
            var generosValidos = new List<string>
        {
            "O", "F", "M", "FEMENINO", "MASCULINO", "OTRO"
        };
            string generoUpper = genero.ToUpper();
            return generosValidos.Contains(generoUpper);
        }

        //---Verificar si un string es un número (int o float)
        public static bool EsNumero(string numero)
        {
            if (string.IsNullOrWhiteSpace(numero)) return false;

            int puntos = 0;
            int digitos = 0;

            foreach (char c in numero)
            {
                if (c == '.')
                {
                    puntos++;
                    if (puntos > 1) return false;
                }
                else if (char.IsDigit(c))
                {
                    digitos++;
                }
                else
                {
                    return false;
                }
            }
            return digitos > 0;
        }

        //---Validar solo letras (y espacios si se permite)
        public static bool ValidarSoloLetras(string texto, bool permitirEspacios = true)
        {
            if (string.IsNullOrEmpty(texto)) return false;

            foreach (char c in texto)
            {
                if (permitirEspacios && c == ' ') continue;
                if (!char.IsLetter(c)) return false;
            }
            return true;
        }

        //---Convertir string a mayúsculas
        public static string ConvertirMayusculas(string palabra)
        {
            return palabra.ToUpper();
        }
        // Validar género
        public static bool ValidarSiNo(string respuesta)
        {
            var respuestasValidas = new List<string>
        {
            "S", "N", "SI", "NO"
        };
            string respuestaUpper = respuesta.ToUpper();
            return respuestasValidas.Contains(respuestaUpper);
        }
    }
}
