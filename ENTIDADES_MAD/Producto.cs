using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDADES_MAD
{
    public class Producto
    {
        public int Id_producto1 { get; set; }

        public int Id_departamento_1 { get; set; }

        public string Nombre { get; set; }

        public string clave { get; set; }

        public decimal Precio_prodcuto { get; set; }

        public decimal Costo_prodcuto { get; set; }

        public string Unidad { get; set; }

        public int stock { get; set; }

        public string Descripcion { get; set; }

        public bool Estado { get; set; }

        public string Devolucion { get; set; }
    }
}
