using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Turno
    {
        public int Id { get; set; }
        public DateTime Dias { get; set; }
        public DateTime HoraInicio { get; set; }
        public DateTime HoraFin { get; set; }
        public Cliente Cliente  { get; set; }
        public Tratamiento Tratamiento { get; set; }
        public Estado Estado { get; set; }
        public string Comentario { get; set; }
    }
}
