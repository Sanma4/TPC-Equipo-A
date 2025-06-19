using Datos;
using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class TipoNegocio
    {
            public List<Tipo> ListarTipo()
            {
                List<Tipo> Lista = new List<Tipo>();

                AccesoDatos datos = new AccesoDatos();
                try
                {
                    datos.setearConsulta("select id,descripcion from tipo");
                    datos.ejecutarLectura();

                    while (datos.Lector.Read())
                    {
                        Tipo tipo = new Tipo();

                        tipo.Id = (int)datos.Lector["id"];
                        tipo.Descripcion = (string)datos.Lector["descripcion"];

                        Lista.Add(tipo);
                    }
                    return Lista;
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
