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
                {
                    datos.setearConsulta("Select id, descripcion, precio, duracion from Tratamiento where id = " + id);
                }

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

        public void Agregar(Peluquero peluquero)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("Insert into Peluqueros values(@nombre, @apellido, @email, @tlf, @sexo, @activo)");
                datos.setearParametro("@nombre", peluquero.Nombre);
                datos.setearParametro("@apellido", peluquero.Apellido);
                datos.setearParametro("@email", peluquero.Email);
                datos.setearParametro("@tlf", peluquero.Telefono);
                datos.setearParametro("@sexo", peluquero.Sexo);
                datos.setearParametro("@activo", peluquero.Activo);
                datos.ejecutarAccion();
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

        public void Editar(Peluquero peluquero)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("Update Peluqueros set Nombre = @nombre, Apellido = @apellido, Email = @email, Telefono = @tlf, Sexo = @sexo, Activo = @activo where Id = @id");
                datos.setearParametro("@nombre", peluquero.Nombre);
                datos.setearParametro("@apellido", peluquero.Apellido);
                datos.setearParametro("@email", peluquero.Email);
                datos.setearParametro("@tlf", peluquero.Telefono);
                datos.setearParametro("@sexo", peluquero.Sexo);
                datos.setearParametro("@activo", peluquero.Activo);
                datos.setearParametro("@Id", peluquero.Id);
                datos.ejecutarAccion();

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
