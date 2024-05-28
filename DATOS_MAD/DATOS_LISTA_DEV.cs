using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ENTIDADES_MAD;
using System.Data.SqlClient;


namespace DATOS_MAD
{
    public class DATOS_LISTA_DEV
    {
        public DataTable Listar()
        {




            //con DataReader podremos leer una secuencia de filas en sql

            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection sqlcon = new SqlConnection();

            //------------capturador de excepciones(try):--------------- 
            //Registros de nuestra tabla departamento
            //manera de como obtener los registros
            //si se ejecuta de manera correcta el try después se ejecutará finally
            try
            {
                sqlcon = CONEXION_SQL.conectar();
                SqlCommand Comando = new SqlCommand("Devolucion_Ventas_Detalle", sqlcon);//1er parametronombre del objeto a la base de datos
                Comando.CommandType = CommandType.StoredProcedure;//Hacer referencia a un procedimiento almacenador de la base de datos
                //sqlcon.Open();//abrimos la conexión
                Resultado = Comando.ExecuteReader();//al ejecutar el resultado de ejecutar ese comenaod se almacenanara en execute reader
                Tabla.Load(Resultado);//Rellenados el Tabla.Load con los valores obtenidos 
                return Tabla;//si todo funciona correctamente retornamos la tabla 
            }
            catch (Exception ex)
            {
                throw ex; //si tenemos alguna excepcion/error mostraremos esta 
            }
            finally
            {
                //Verificamos si la conexion está habierta si es así se cierra
                if (sqlcon.State == ConnectionState.Open) sqlcon.Close();
            }

        }

        public DataTable Listar2()
        {




            //con DataReader podremos leer una secuencia de filas en sql

            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection sqlcon = new SqlConnection();

            //------------capturador de excepciones(try):--------------- 
            //Registros de nuestra tabla departamento
            //manera de como obtener los registros
            //si se ejecuta de manera correcta el try después se ejecutará finally
            try
            {
                sqlcon = CONEXION_SQL.conectar();
                SqlCommand Comando = new SqlCommand("Devolucion_productos", sqlcon);//1er parametronombre del objeto a la base de datos
                Comando.CommandType = CommandType.StoredProcedure;//Hacer referencia a un procedimiento almacenador de la base de datos
                //sqlcon.Open();//abrimos la conexión
                Resultado = Comando.ExecuteReader();//al ejecutar el resultado de ejecutar ese comenaod se almacenanara en execute reader
                Tabla.Load(Resultado);//Rellenados el Tabla.Load con los valores obtenidos 
                return Tabla;//si todo funciona correctamente retornamos la tabla 
            }
            catch (Exception ex)
            {
                throw ex; //si tenemos alguna excepcion/error mostraremos esta 
            }
            finally
            {
                //Verificamos si la conexion está habierta si es así se cierra
                if (sqlcon.State == ConnectionState.Open) sqlcon.Close();
            }

        }

        public string Insertar(Devolucion objeto)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = CONEXION_SQL.conectar();
                SqlCommand Comando = new SqlCommand("Devolucion_insertar", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@Id_Venta", SqlDbType.Int).Value = objeto.idventaa;
                Comando.Parameters.Add("@Id_Producto", SqlDbType.Int).Value = objeto.ideproc;
                Comando.Parameters.Add("@Producto1", SqlDbType.VarChar).Value = objeto.proc;
                Comando.Parameters.Add("@Cantidad", SqlDbType.Int).Value = objeto.cant;
                Comando.Parameters.Add("@Precio", SqlDbType.Decimal).Value = objeto.precio;
                Comando.Parameters.Add("@Importe", SqlDbType.Decimal).Value = objeto.importe;
                Comando.Parameters.Add("@Unidad_Medida", SqlDbType.VarChar).Value = objeto.uni;
                Comando.Parameters.Add("@Tipo_Dev", SqlDbType.VarChar).Value = objeto.tipo;
                //SqlCon.Open();
                Rpta = Comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo ingresar el registro";
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

        public string Eliminar(int Id)
        {

            string Rpta = "";
            SqlConnection sqlcon = new SqlConnection();
            try
            {

                sqlcon = CONEXION_SQL.conectar();
                SqlCommand Comando = new SqlCommand("Detalle_Venta_Eliminar_1", sqlcon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@IdDetalle_Venta", SqlDbType.Int).Value = Id;
                //sqlcon.Open();
                Rpta = Comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo Eliminar el registro";

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
