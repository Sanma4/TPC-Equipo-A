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
                datos.setearConsulta("Select U.Id, U.ClienteId, U.TratamientoId, U.EstadoId, U.HoraInicio, U.HoraFin, U.Comentario, U.PeluqueroId from Turno U, Cliente C, Tratamiento T, Estado E, Peluquero P Where C.Id = U.ClienteId and T.Id = U.TratamientoId and E.Id = U.EstadoId and P.Id = U.PeluqueroId");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Turno aux = new Turno();
                    aux.Id = (int)datos.Lector["Id"];

                    aux.Cliente = new Cliente();
                    aux.Cliente.Id = (int)datos.Lector["ClienteId"];

                    aux.Tratamiento = new Tratamiento();
                    aux.Tratamiento.Id = (int)datos.Lector["TratamientoId"];

                    aux.Estado = new Estado();
                    aux.Estado.Id = (int)datos.Lector["EstadoId"];
                    aux.HoraInicio = (DateTime)datos.Lector["HoraInicio"];
                    aux.HoraFin = (DateTime)datos.Lector["HoraFin"];
                    aux.Comentario = datos.Lector["Comentario"].ToString();
                    aux.Peluquero = new Peluquero();
                    aux.Peluquero.Id = (int)datos.Lector["PeluqueroId"];
                    lista.Add(aux);
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
