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
    public class LOGICA_DEVOLUCION
    {
        public static string Insertar(int id, int id_vent, string produ, int canti, decimal precio2, decimal importesito, string uni2, string tipillo)
        {

            DATOS_LISTA_DEV Datos = new DATOS_LISTA_DEV();
            Devolucion Obj = new Devolucion();

            Obj.idventaa = id;
            Obj.ideproc = id_vent;
            Obj.proc = produ;
            Obj.cant = canti;
            Obj.precio = precio2;
            Obj.importe = importesito;
            Obj.uni = uni2;
            Obj.tipo = tipillo;
            return Datos.Insertar(Obj);

        }

        public static string Eliminar(int Id)
        {
            DATOS_LISTA_DEV Datos = new DATOS_LISTA_DEV();
            return Datos.Eliminar(Id);
        }
    }
}
