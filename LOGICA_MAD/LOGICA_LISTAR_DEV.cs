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
    public class LOGICA_LISTAR_DEV
    {
        public static DataTable Listar()
        {
            //Nota: La función "Listar" no es estatica por eso se le hace la instancia
            DATOS_LISTA_DEV Datos = new DATOS_LISTA_DEV();
            return Datos.Listar();
        }

        public static DataTable Listar2()
        {
            //Nota: La función "Listar" no es estatica por eso se le hace la instancia
            DATOS_LISTA_DEV Datos = new DATOS_LISTA_DEV();
            return Datos.Listar();
        }



    }
}
