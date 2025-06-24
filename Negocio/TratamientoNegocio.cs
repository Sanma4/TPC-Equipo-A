using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Dominio;

namespace Negocio
{
    public class TratamientoNegocio
    {


        public List<Tratamiento> ListarTratamientos(string id = "")
        {
            List<Tratamiento> lista = new List<Tratamiento>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("Select id, descripcion, precio, duracion from Tratamiento");
                if (id != "")
                    datos.setearConsulta("Select id, descripcion, precio, duracion from Tratamiento where id = " + id);

                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Tratamiento aux = new Tratamiento();
                    aux.Id = (int)datos.Lector["id"];
                    aux.Descripcion = (string)datos.Lector["descripcion"];
                    aux.Precio = (decimal)datos.Lector["precio"];
                    if (!(datos.Lector["duracion"] is DBNull))
                        aux.DuracionEstimada = (string)datos.Lector["duracion"];
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
        public void Agregar(Tratamiento nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("INSERT INTO Tratamiento VALUES (@descripcion, @precio, @duracionestimada)");
                datos.setearParametro("@descripcion", nuevo.Descripcion);
                datos.setearParametro("@precio", nuevo.Precio);
                datos.setearParametro("@duracionestimada", nuevo.DuracionEstimada);
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

        public void Editar(Tratamiento nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("UPDATE Tratamiento SET descripcion = @descripcion, precio = @precio, duracion = @duracionestimada WHERE id = @id");
                datos.setearParametro("@id", nuevo.Id);
                datos.setearParametro("@descripcion", nuevo.Descripcion);
                datos.setearParametro("@precio", nuevo.Precio);
                datos.setearParametro("@duracionestimada", nuevo.DuracionEstimada);
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
