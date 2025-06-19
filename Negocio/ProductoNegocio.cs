using Datos;
using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class ProductoNegocio
    {
        public List<Producto> ListarProducto()
        {
            List<Producto> productos = new List<Producto>();

            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("select id,nombre,descripcion,tipo,codigobarras,stock,precio,urlimg,activo from Producto");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Producto producto = new Producto();

                    producto.Id = (int)datos.Lector["id"];
                    producto.Nombre = (string)datos.Lector["nombre"];
                    producto.Descripcion = (string)datos.Lector["descripcion"];
                    producto.Tipo = (Tipo)datos.Lector["tipo"];
                    producto.CodigoBarras = (string)datos.Lector["codigobarras"];
                    producto.Stock = (int)datos.Lector["stock"];
                    producto.Precio = (double)datos.Lector["precio"];
                    producto.UrlImagen = (string)datos.Lector["urlimg"];
                    producto.Activo = (bool)datos.Lector["activo"];

                    productos.Add(producto);
                }
                return productos;
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
