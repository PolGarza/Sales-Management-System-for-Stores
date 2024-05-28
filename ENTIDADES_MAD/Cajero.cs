using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDADES_MAD
{
    public class Cajero
    {
        //get: perimte obtener valores almacenados 
        //set: permite almacenar
        public int IdCajero { get; set; }

        public string NombreCajero { get; set; }

        public string CURP { get; set; }

        public string EmailCajero { get; set; }

        public string ClaveCajero { get; set; }

        public string FechaNam { get; set; }

        public string FechaIngre { get; set; }

        public bool EstadoCajero { get; set; }
    }
}
