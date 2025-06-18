using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcio { get; set; }
        public string Tipo { get; set; }
        public string CodigoBarras { get; set; }
        public int Stock { get; set; }
        public double Precio { get; set; }
        public string UrlImagen { get; set; }
        public bool Activo { get; set; }
    }
}
