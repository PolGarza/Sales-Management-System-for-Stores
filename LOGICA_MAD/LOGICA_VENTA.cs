using System;
using System.Data;
using DATOS_MAD;
using ENTIDADES_MAD;

namespace LOGICA_MAD
{
    public class LOGICA_VENTA
    {

        public static DataTable Listar()
        {
            DATOS_VENTAS Datos = new DATOS_VENTAS();
            return Datos.Listar();
        }

        public static DataTable Buscar(string Valor)
        {
            DATOS_VENTAS Datos = new DATOS_VENTAS();
            return Datos.Buscar(Valor);
        }

        public static DataTable ConsultaFechas(DateTime FechaInicio, DateTime FechaFin)
        {
            DATOS_VENTAS Datos = new DATOS_VENTAS();
            return Datos.ConsultaFechas(FechaInicio, FechaFin);
        }

        public static DataTable ListarDetalle(int Id)
        {
            DATOS_VENTAS Datos = new DATOS_VENTAS();
            return Datos.ListarDetalle(Id);
        }

        public static string Insertar(int IdCajero,  string cajitaNum, int NumComprobante, decimal Total, DataTable Detalles)
        {
            DATOS_VENTAS Datos = new DATOS_VENTAS();
            Venta Obj = new Venta();
            Obj.IdCajero = IdCajero;
            Obj.CajaNum = cajitaNum;
            Obj.Total = Total;
            Obj.Detalles = Detalles;
            return Datos.Insertar(Obj);
        }

        public static string Anular(int Id)
        {
            DATOS_VENTAS Datos = new DATOS_VENTAS();
            return Datos.Anular(Id);
        }
    }
}
