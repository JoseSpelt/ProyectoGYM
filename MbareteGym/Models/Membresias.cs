using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MbareteGym.Models
{
    public class Membresias
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public decimal Costo { get; set; }

        public int Duracion { get; set; }
    }
}
