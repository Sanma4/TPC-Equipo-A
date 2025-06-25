using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Dominio;

namespace Negocio
{
    public class PeluqueroNegocio
    {

        public List<Peluquero> ListarPeluqueros(string id = "")
        {
            List<Peluquero> lista = new List<Peluquero>();
            AccesoDatos datos = new AccesoDatos();

            try
            {

                datos.setearConsulta("select id,nombre,apellido,email,telefono,sexo,activo from Peluquero");
                if (id != "")
                    datos.setearConsulta("Select id, descripcion, precio, duracion from Tratamiento where id = " + id);
                
                datos.ejecutarLectura();


                while (datos.Lector.Read())
                {
                    Peluquero peluquero = new Peluquero();
                    peluquero.Id = (int)datos.Lector["id"];
                    peluquero.Nombre = (string)datos.Lector["nombre"];
                    peluquero.Apellido = (string)datos.Lector["apellido"];
                    peluquero.Email = (string)datos.Lector["email"];
                    peluquero.Telefono = (string)datos.Lector["telefono"];
                    peluquero.Sexo = (string)datos.Lector["sexo"];
                    peluquero.Activo = (bool)datos.Lector["activo"];
                    peluquero.Turno = new List<Turno>();
                    peluquero.Horario = new List<Horario>();

                    lista.Add(peluquero);
                }

                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }


    }
}
