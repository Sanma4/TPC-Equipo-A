using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Dominio;

namespace Negocio
{
    public class TurnoNegocio
    {
        public List<Turno> ListarTurnos()
        {
            List<Turno> lista = new List<Turno>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("Select  ");
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
