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
    public class LOGICA_VISTAS
    {

        public static DataTable Listar()
        {
           DATOS_VISTAS Datos = new DATOS_VISTAS();
            return Datos.Listar();
        }

        public static DataTable Listar_Ventas()
        {
            DATOS_VISTAS Datos = new DATOS_VISTAS();
            return Datos.Listar_Ventas();
        }
    }
}
