using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDADES_MAD
{
    public class Departamento
    {
        //get: perimte obtener valores almacenados 
        //set: permite almacenar
        public int id_Departamento { get; set; }

        public string nombre_Departamento { get; set; }

        public int id_Admin { get; set; }

        public bool estado { get; set; }
    }
}
