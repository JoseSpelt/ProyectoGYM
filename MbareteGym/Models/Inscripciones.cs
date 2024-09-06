using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MbareteGym.Models
{
    public class Inscripciones
    {
        public int Id { get; set; }
        public int idCliente { get; set; }
        public int idClase { get; set; }

        public DateTime fechaInscripcion { get; set; }
    }
}
