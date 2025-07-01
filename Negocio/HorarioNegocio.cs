using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Dominio;

namespace Negocio
{
    public class HorarioNegocio
    {
        public List<Horario> ListarHorarios(string id = "")
        {
            List<Horario> lista = new List<Horario>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("SELECT id, dia, horaEntrada, horaSalida FROM Horario");
                if (id != "")
                    datos.setearConsulta("SELECT id, dia, horaEntrada, horaSalida FROM Horario where id = " + id);

                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Horario aux = new Horario();
                    aux.Id = (int)datos.Lector["id"];
                    aux.Dia = (string)datos.Lector["dia"];
                    if (!(datos.Lector["horaEntrada"] is DBNull))
                        aux.HoraEntrada = (string)datos.Lector["horaEntrada"];
                    if (!(datos.Lector["horaSalida"] is DBNull))
                        aux.HoraSalida = (string)datos.Lector["horaSalida"];

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

        public void Agregar(Horario horario)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("Insert into Horario(Dia, HoraEntrada, HoraSalida) values(@dia, @horaEntrada, @horaSalida)");
                datos.setearParametro("@dia", horario.Dia);
                datos.setearParametro("@horaEntrada", horario.HoraEntrada);
                datos.setearParametro("@horaSalida", horario.HoraSalida);
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

        public void Modificar(Horario horario)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("Update Horario set Dia = @dia, horaEntrada = @horaEntrada, horaSalida = @horaSalida where id = @id");
                datos.setearParametro("@id", horario.Id);
                datos.setearParametro("@dia", horario.Dia);
                datos.setearParametro("@horaEntrada", horario.HoraEntrada);
                datos.setearParametro("@horaSalida", horario.HoraSalida);
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

        public void Eliminar(int id)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("Delete from Horario where Id = @id");
                datos.setearParametro("@id", id);
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
