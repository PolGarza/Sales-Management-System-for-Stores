using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


using System.Data;
using System.Threading.Tasks;

namespace ENTIDADES_MAD
{
    public class Venta
    {
        public int IdVenta { get; set; }

        public int IdCajero { get; set; }

       // public string TipoComprobante { get; set; }

        public string CajaNum { get; set; }

        //public decimal Descuento_V { get; set; }

        public decimal Total { get; set; }

        public string Estado { get; set; }

        public int codigo_v { get; set; }

        public DataTable Detalles { get; set; }
    }
}
