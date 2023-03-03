using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FINAL_MARZO_2023_VILLARREAL.Models
{
    public class Basic : Herramienta
    {
        public TipoHerramienta Tipo {get; set;}
        public List<PaletaColores> ColoresDisponibles { get; set;}
        public decimal TamañosDisponibles { get; set;}


        public Basic(int codigo, string nombre, bool premiun, bool beta, TipoHerramienta tipo, List<PaletaColores> coloresDisponibles, decimal tamañosDisponibles):
            base ( codigo,  nombre,  premiun,  beta)
        {
            Tipo = tipo;
            ColoresDisponibles = coloresDisponibles;
            TamañosDisponibles = tamañosDisponibles;
        }

        public override List<string> ObtenerDescripcion()
        {
            //CORRECCIÓN: ACÁ Y EN LAS OTRAS SUBCLASES PODRIAS HABER LLAMADO DIRECTAMENTE AL METODO BASE Y A ESO SUMARLE LO PARTICULAR.
            List<string> list = new List<string>() { $"{Codigo} + {Nombre} + {Premiun} + {TamañosDisponibles} + {ColoresDisponibles}" };
            return list;
        }
    }
}
