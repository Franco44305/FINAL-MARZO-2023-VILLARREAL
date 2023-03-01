using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FINAL_MARZO_2023_VILLARREAL.Models
{
    public class Usuario
    {
        public bool Vip { get; set; }
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public string Email { get; set; }
        public DateTime FechaRegistro { get; set; }
        public List<int> CodigosProyectos { get; set; }


        public Usuario(bool vip, int codigo, string nombre, string email, DateTime fechaRegistro, List<int> codigosProyectos) 
        {
            Vip = vip;
            Codigo = codigo;
            Nombre = nombre;
            Email = email;
            FechaRegistro = fechaRegistro;
            CodigosProyectos = codigosProyectos;
        }
    }
}
