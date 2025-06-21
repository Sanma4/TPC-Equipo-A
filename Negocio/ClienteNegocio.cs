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
                    cliente.Nombre = (string)datos.Lector["nombre"];
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
    }
}
