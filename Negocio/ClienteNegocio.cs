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


        public List<Cliente> ListarClientes()
        {
            List<Cliente> lista = new List<Cliente>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("Select id, nombre, apellido, email, telefono, sexo, activo from Cliente");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Cliente cliente = new Cliente();
                    cliente.Id = (int)datos.Lector["id"];
                    if (!((string)datos.Lector["nombre"] is DBNull))
                        cliente.Nombre = (string)datos.Lector["nombre"];
                    if (!((string)datos.Lector["apellido"] is DBNull))
                        cliente.Apellido = (string)datos.Lector["apellido"];
                    cliente.Email = (string)datos.Lector["email"];
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
    }
}
