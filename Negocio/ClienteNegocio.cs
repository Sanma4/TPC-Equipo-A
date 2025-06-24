using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Dominio;

namespace Negocio
{
    public class ClienteNegocio
    {


        public List<Cliente> ListarClientes(string id = "")
        {
            List<Cliente> lista = new List<Cliente>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("Select id, nombre, apellido, email, telefono, sexo, activo from Cliente");
                if (id != "")
                    datos.setearConsulta("Select id, nombre, apellido, email, telefono, sexo, activo from Cliente where id = " + id);
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Cliente cliente = new Cliente();
                    cliente.Id = (int)datos.Lector["id"];
                    cliente.Nombre = (string)datos.Lector["nombre"];
                    cliente.Apellido = (string)datos.Lector["apellido"];
                    cliente.Email = (string)datos.Lector["email"];
                    if (!((string)datos.Lector["telefono"] is DBNull))
                        cliente.Telefono = (string)datos.Lector["telefono"];

                    cliente.Sexo = (string)datos.Lector["sexo"];
                    cliente.Activo = (bool)datos.Lector["activo"];

                    lista.Add(cliente);
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

        public void Agregar(Cliente cliente)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("Insert into Cliente values(@nombre, @apellido, @email, @tlf, @sexo, @activo)");
                datos.setearParametro("@nombre", cliente.Nombre);
                datos.setearParametro("@apellido", cliente.Apellido);
                datos.setearParametro("@email", cliente.Email);
                datos.setearParametro("@tlf", cliente.Telefono);
                datos.setearParametro("@sexo", cliente.Sexo);
                datos.setearParametro("@activo", cliente.Activo);
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

        public void Editar(Cliente cliente)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("Update Cliente set Nombre = @nombre, Apellido = @apellido, Email = @email, Telefono = @tlf, Sexo = @sexo, Activo = @activo where Id = @id");
                datos.setearParametro("@nombre", cliente.Nombre);
                datos.setearParametro("@apellido", cliente.Apellido);
                datos.setearParametro("@email", cliente.Email);
                datos.setearParametro("@tlf", cliente.Telefono);
                datos.setearParametro("@sexo", cliente.Sexo);
                datos.setearParametro("@activo", cliente.Activo);
                datos.setearParametro("@Id", cliente.Id);
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
