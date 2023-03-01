using FINAL_MARZO_2023_VILLARREAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FINAL_MARZO_2023_VILLARREAL
{
    public class Logica
    {
        List<Proyecto> Proyectos = new List<Proyecto>();
        List<Usuario> Usuarios = new List<Usuario>();
        List<Herramienta> Herramientas = new List<Herramienta>();

        //Punto 1
        public bool CrearProyectos(int CodigoUsuario, string NombreProyecto, TipoPlantilla Tipo)
        {
            Proyecto proyecto = new Proyecto(CodigoUsuario, NombreProyecto, Tipo, null);//La lista es nula ya que a medida que se vaya utilizando herrammientas se van cargando
            return true;
        }

        //Punto2
        public List<string> DevolverListadoHerramientas(int CodigoUsuario)
        {
            List<string> ListadoHerramientasDisponibles = new List<string>();
            foreach (var user in Usuarios)
            {
                if (user.Codigo == CodigoUsuario)
                {
                    foreach (var item in Herramientas)
                    {
                        if (ValidarHerramientaUsuario(CodigoUsuario, item.Codigo) is true)
                        {
                            ListadoHerramientasDisponibles.Add($"{item.Codigo} + {item.Nombre} + {ValidarHerramientaUsuario(CodigoUsuario, item.Codigo)}");
                        }
                        else
                        {

                            ListadoHerramientasDisponibles.Add($"{item.Codigo} + {item.Nombre} + {ValidarHerramientaUsuario(CodigoUsuario, item.Codigo)} + {"Si desea usar esta herramienta debe ser usuario VIP"}");
                        }
                    }
                    return ListadoHerramientasDisponibles;
                }
            }
            return ListadoHerramientasDisponibles;
        }

        //Punto3
        public (bool,string) CargarHerramientaEnProyecto(int CodigoHerramienta, int CodigoUsuario, int CodigoProyecto)
        {
            foreach (var item in Proyectos)
            {
                if (item.Codigo == CodigoProyecto)
                {
                    if (ValidarHerramientaUsuario(CodigoUsuario, CodigoHerramienta) is true)
                    {
                        item.CodigosHerramientasUtilizadas.Add(CodigoHerramienta);
                        return (true, "Se agrego correctamente la herramienta al historial del proyecto.");
                    }
                }
            }
            return (false, "Herramienta no disponible para el usuario.");
        }



        //ValidacionUsuarioHerramienta
        public bool ValidarHerramientaUsuario(int CodigoUsuario, int CodigoHerramienta)
        {
            foreach(var user in Usuarios)
            {
                if (user.Codigo == CodigoUsuario)
                {
                    foreach(var item in Herramientas)
                    {
                        if (item.Codigo == CodigoHerramienta)
                        {
                            if (user.Vip is true)
                            {
                                return true;
                            }
                            else 
                            {
                                if (item.Premiun is true)
                                {
                                    return false;
                                }
                                else
                                {
                                    return true;
                                }
                            }
                        }
                    }
                    return false;
                }
            }
            return false;
        }
    }
}
