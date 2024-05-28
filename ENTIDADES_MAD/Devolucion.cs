using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDADES_MAD
{
    public class Devolucion
    {
        public int idventaa { get; set; }

        public int ideproc { get; set; }

        public string proc { get; set; }

        public int cant { get; set; }

        public decimal precio { get; set; }

        public decimal importe { get; set; }

        public string uni { get; set; }

        public string tipo { get; set; }
    }
}
