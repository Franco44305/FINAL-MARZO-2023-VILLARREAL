using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FINAL_MARZO_2023_VILLARREAL.Models
{
    public class Synthetics : Herramienta
    {
        public decimal TamañosDisponibles { get; set; }
        public List<PaletaColores> Colores { get; set; }


        public Synthetics(int codigo, string nombre, bool premiun, bool beta, decimal tamañosDisponibles, List<PaletaColores> colores):
            base ( codigo,  nombre,  premiun,  beta)
        {
            TamañosDisponibles = tamañosDisponibles;
            Colores = colores;
        }

        public override List<string> ObtenerDescripcion()
        {
            List<string> list = new List<string>() { $"{Codigo} + {Nombre} + {Premiun} + {TamañosDisponibles} + {Colores}" };

            return list;
        }
    }
}
