using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo3E
{
    internal class Persona
    {
        public string Dpi { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }


        public int edad()
        {
            
            DateTime hoy = DateTime.Now;

            //int anos = hoy.Year - FechaNacimiento.Year;

            //if (FechaNacimiento.Month > hoy.Month)
            //    anos--;

            TimeSpan intervalo = hoy - FechaNacimiento;

            int anos = (intervalo.Days / 365);


            //calcular la edad
            return (anos);
            
        }

        public void normalizarNombre()
        {
            Nombre = Nombre.Trim();


            //invocar al método ToTitleCase de la clase Cultureinfo            

            Nombre = CultureInfo.InvariantCulture.TextInfo.ToTitleCase(Nombre);
        }


    }
}
