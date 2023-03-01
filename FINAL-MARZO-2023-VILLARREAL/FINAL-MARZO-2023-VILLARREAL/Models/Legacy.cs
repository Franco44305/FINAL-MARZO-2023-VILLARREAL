using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FINAL_MARZO_2023_VILLARREAL.Models
{
    public class Legacy : Herramienta
    {
        public decimal TamañosDisponibles { get; set; }
        public string Uso { get; set; }


        public Legacy(int codigo, string nombre, bool premiun, bool beta, decimal tamañosDisponibles, string uso):
            base ( codigo,  nombre,  premiun,  beta)
        {
            TamañosDisponibles = tamañosDisponibles;
            Uso = uso;
        }

        public override List<string> ObtenerDescripcion()
        {
            List<string> list = new List<string>() { $"{Codigo} + {Nombre} + {Premiun} + {TamañosDisponibles} + {Uso}" };
            return list;
        }
    }
}
