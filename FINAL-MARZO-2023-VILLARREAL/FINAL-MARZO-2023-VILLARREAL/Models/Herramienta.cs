using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FINAL_MARZO_2023_VILLARREAL.Models
{
    public class Herramienta
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public bool Premiun { get; set; }
        public bool Beta { get; set; }


        public Herramienta(int codigo, string nombre, bool premiun, bool beta)
        {
            Codigo = codigo;
            Nombre = nombre;
            Premiun = premiun;
            Beta = beta;
        }

        public virtual List<string> ObtenerDescripcion()
        {
            List<string> listDesc = new List<string>();
            return listDesc;
        }
    }
}
