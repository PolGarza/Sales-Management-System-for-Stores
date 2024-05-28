using System;
using System.Data;
using ENTIDADES_MAD;
using System.Data.SqlClient;

namespace DATOS_MAD
{
    public class DATOS_VENTAS
    {

        public DataTable Listar()
        {
            //con DataReader podremos leer una secuencia de filas en sql

            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection sqlcon = new SqlConnection();

            try
            {
                //no se puede hacer una instancia directa ya que nuestro constructor es privado
                sqlcon = CONEXION_SQL.conectar();
                SqlCommand Comando = new SqlCommand("venta_listar", sqlcon);//1er parametronombre del objeto a la base de datos
                Comando.CommandType = CommandType.StoredProcedure;//Hacer referencia a un procedimiento almacenador de la base de datos
                //sqlcon.Open();//abrimos la conexión
                Resultado = Comando.ExecuteReader();//al ejecutar el resultado de ejecutar ese comenaod se almacenanara en execute reader
                Tabla.Load(Resultado);//Rellenados el Tabla.Load con los valores obtenidos 
                return Tabla;//si todo funciona correctamente retornamos la tabla 

            }
            catch (Exception ex)
            {
                throw ex; //si tenemos alguna excepcion mostraremos esta 
            }
            finally
            {
                //Verificamos si la conexion está habierta si es así se cierra
                if (sqlcon.State == ConnectionState.Open) sqlcon.Close();

            }

        }

        public DataTable Buscar(string valor)
        {

            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection sqlcon = new SqlConnection();

            try
            {

                sqlcon = CONEXION_SQL.conectar();
                SqlCommand Comando = new SqlCommand("venta_buscar", sqlcon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@valor", SqlDbType.VarChar).Value = valor;
                Resultado = Comando.ExecuteReader();
                Tabla.Load(Resultado);
                return Tabla;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (sqlcon.State == ConnectionState.Open) sqlcon.Close();
            }

        }

        public DataTable ConsultaFechas(DateTime FechaInicio, DateTime FechaFin)
        {

            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection sqlcon = new SqlConnection();

            try
            {

                sqlcon = CONEXION_SQL.conectar();
                SqlCommand Comando = new SqlCommand("venta_consulta_fechas", sqlcon);
                Comando.CommandType = CommandType.StoredProcedure;
                //Se agrega el paramtro al comando, lo recibiremos con el nombre valor con sus caracteristicas entonces desde el negocio cuando haga referencia desde el negocio enviará los datos a ese parametro 
                sqlcon.Open();
                Comando.Parameters.Add("@fecha_inicio", SqlDbType.Date).Value = FechaInicio;
                Comando.Parameters.Add("@fecha_fin", SqlDbType.Date).Value = FechaFin;
                Resultado = Comando.ExecuteReader();
                Tabla.Load(Resultado);
                return Tabla;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {

                if (sqlcon.State == ConnectionState.Open) sqlcon.Close();

            }

        }

        public DataTable ListarDetalle(int Id)
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection sqlcon = new SqlConnection();

            try
            {
                sqlcon = CONEXION_SQL.conectar();
                SqlCommand Comando = new SqlCommand("venta_listar_detalle", sqlcon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@idventa", SqlDbType.Int).Value = Id;
                //sqlcon.Open();
                Resultado = Comando.ExecuteReader();
                Tabla.Load(Resultado);
                return Tabla;
            }
            catch (Exception ex)
            {
                return null;
                throw ex;
            }
            finally
            {
                if (sqlcon.State == ConnectionState.Open) sqlcon.Close();
            }
        }

        public string Insertar(Venta objeto)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = CONEXION_SQL.conectar();
                SqlCommand Comando = new SqlCommand("venta_insertar", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@idcajero", SqlDbType.Int).Value = objeto.IdCajero;
              //  Comando.Parameters.Add("@tipo_comprobante", SqlDbType.VarChar).Value = objeto.TipoComprobante;
                Comando.Parameters.Add("@Caja_Num", SqlDbType.VarChar).Value = objeto.CajaNum;
                //Comando.Parameters.Add("@Descuento", SqlDbType.Decimal).Value = objeto.Detalles;
                Comando.Parameters.Add("@total", SqlDbType.Decimal).Value = objeto.Total;
                Comando.Parameters.Add("@detalle", SqlDbType.Structured).Value = objeto.Detalles;
               
                Comando.ExecuteNonQuery();
                Rpta = "OK";
            }
            catch (Exception ex)
            {
                Rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return Rpta;
        }

        public string Anular(int Id)
        {
            string Rpta = "";
            SqlConnection sqlcon = new SqlConnection();
            try
            {
                sqlcon = CONEXION_SQL.conectar();
                SqlCommand Comando = new SqlCommand("venta_anular", sqlcon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@idventa", SqlDbType.Int).Value = Id;
              
                Comando.ExecuteNonQuery();
                Rpta = "OK";
            }
            catch (Exception ex)
            {
                Rpta = ex.Message;
            }
            finally
            {
                if (sqlcon.State == ConnectionState.Open) sqlcon.Close();
            }
            return Rpta;


        }


    }
}
