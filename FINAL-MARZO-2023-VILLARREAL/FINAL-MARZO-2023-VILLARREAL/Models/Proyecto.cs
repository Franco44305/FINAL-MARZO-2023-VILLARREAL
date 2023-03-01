using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FINAL_MARZO_2023_VILLARREAL.Models
{
    public class Proyecto
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public TipoPlantilla Tipo { get; set; }
        public List<int> CodigosHerramientasUtilizadas { get; set; }


        public Proyecto(int codigo, string nombre, TipoPlantilla tipo, List<int> codigosHerramientasUtilizadas)
        {
            Codigo = codigo;
            Nombre = nombre;
            Tipo = tipo;
            CodigosHerramientasUtilizadas = codigosHerramientasUtilizadas;
        }
    }
}
