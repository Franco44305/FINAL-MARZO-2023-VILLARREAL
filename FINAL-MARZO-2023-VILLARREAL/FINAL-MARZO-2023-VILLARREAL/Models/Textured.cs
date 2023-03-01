using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FINAL_MARZO_2023_VILLARREAL.Models
{
    public class Textured : Herramienta
    {
        public TipoTextura Tipos { get; set; }


        public Textured (int codigo, string nombre, bool premiun, bool beta, TipoTextura tipoTextura):
            base ( codigo,  nombre,  premiun,  beta)
        {
            Tipos = tipoTextura;
        }

        public override List<string> ObtenerDescripcion()
        {
            List<string> list = new List<string>() {$"{Codigo} + {Nombre} + {Premiun} + {Tipos}"};
            return list;
        }
    }
}
