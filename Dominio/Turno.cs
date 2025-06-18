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
        public int PeluqueroId { get; set; }
        public DateTime HoraInicio { get; set; }
        public DateTime HoraFin { get; set; }
        public int ClienteId  { get; set; }
        public int TratamientoId { get; set; }
        public Estado Estado { get; set; }
        public string Comentario { get; set; }
    }
}
