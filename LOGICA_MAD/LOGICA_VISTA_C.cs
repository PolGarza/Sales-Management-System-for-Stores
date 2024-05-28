using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DATOS_MAD;
using ENTIDADES_MAD;

namespace LOGICA_MAD
{
    public  class LOGICA_VISTA_C
    {
        public static DataTable Listar()
        {
            DATOS_VISTA_CAJERO Datos = new DATOS_VISTA_CAJERO();
            return Datos.Listar();
        }
    }
}
