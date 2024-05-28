using System;
using System.Data;
using ENTIDADES_MAD;
using System.Data.SqlClient;

namespace DATOS_MAD
{
    public class DATOS_CAJERO
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
                SqlCommand Comando = new SqlCommand("cajero_listar", sqlcon);//1er parametronombre del objeto a la base de datos
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

        public DataTable Buscar(string valor, DateTime fecha_inicial, DateTime fecha_final)
        {

            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection sqlcon = new SqlConnection();

            try
            {

                sqlcon = CONEXION_SQL.conectar();
                SqlCommand Comando = new SqlCommand("cajero_buscar", sqlcon);
                Comando.CommandType = CommandType.StoredProcedure;

                //Se agrega el paramtro al comando, lo recibiremos con el nombre valor con sus caracteristicas entonces desde el negocio cuando haga referencia desde el negocio enviará los datos a ese parametro 
                //sqlcon.Open();
                Comando.Parameters.Add("@valor", SqlDbType.VarChar).Value = valor;
                Comando.Parameters.Add("@fecha_inicial", SqlDbType.DateTime).Value = fecha_inicial;
                Comando.Parameters.Add("@fecha_final", SqlDbType.DateTime).Value = fecha_final;

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

        public DataTable Login(string Email, string Clave)
          {

              SqlDataReader Resultado;
              DataTable Tabla = new DataTable();
              SqlConnection sqlcon = new SqlConnection();

              try
              {

                  sqlcon = CONEXION_SQL.conectar();
                  SqlCommand Comando = new SqlCommand("cajero_login", sqlcon);
                  Comando.CommandType = CommandType.StoredProcedure;
                  //Se agrega el paramtro al comando, lo recibiremos con el nombre valor con sus caracteristicas entonces desde el negocio cuando haga referencia desde el negocio enviará los datos a ese parametro 
                  //sqlcon.Open();
                  Comando.Parameters.Add("@email", SqlDbType.VarChar).Value = Email;
                  Comando.Parameters.Add("@clave", SqlDbType.VarChar).Value = Clave;
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

        public string Existe(string Valor)
        {
            string Rpta = "";
            SqlConnection sqlcon = new SqlConnection();
            try
            {
                //manera de agregar parametros 
                sqlcon = CONEXION_SQL.conectar();
                SqlCommand Comando = new SqlCommand("cajero_existe", sqlcon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@valor", SqlDbType.VarChar).Value = Valor;//parametro de entrada
                SqlParameter Parametro_existe = new SqlParameter();
                Parametro_existe.ParameterName = "@existe";
                Parametro_existe.SqlDbType = SqlDbType.Int;
                Parametro_existe.Direction = ParameterDirection.Output;//parametro de salida
                Comando.Parameters.Add(Parametro_existe);
                //sqlcon.Open();
                Comando.ExecuteNonQuery();
                Rpta = Convert.ToString(Parametro_existe.Value);

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

        public string Insertar(Cajero objeto)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = CONEXION_SQL.conectar();
                SqlCommand Comando = new SqlCommand("cajero_insertar", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = objeto.NombreCajero;
                Comando.Parameters.Add("@CURP", SqlDbType.VarChar).Value = objeto.CURP;
                Comando.Parameters.Add("@Email", SqlDbType.VarChar).Value = objeto.EmailCajero;
                Comando.Parameters.Add("@Clave", SqlDbType.VarChar).Value = objeto.ClaveCajero;
                Comando.Parameters.Add("@FechaNam", SqlDbType.Date).Value = objeto.FechaNam;

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

        public string Actualizar(Cajero objeto)
        {

            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = CONEXION_SQL.conectar();
                SqlCommand Comando = new SqlCommand("cajero_actualizar", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@Id_Cajero", SqlDbType.Int).Value = objeto.IdCajero;
                Comando.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = objeto.NombreCajero;
                Comando.Parameters.Add("@CURP", SqlDbType.VarChar).Value = objeto.CURP;
                Comando.Parameters.Add("@Email", SqlDbType.VarChar).Value = objeto.EmailCajero;
                Comando.Parameters.Add("@Clave", SqlDbType.VarChar).Value = objeto.ClaveCajero;
                Comando.Parameters.Add("@FechaNam", SqlDbType.Date).Value = objeto.FechaNam;


                //SqlCon.Open();
                Rpta = Comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo actualizar el registro";
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
                SqlCommand Comando = new SqlCommand("cajero_eliminar", sqlcon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@Id_Cajero", SqlDbType.Int).Value = Id;
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

        public string Activar(int Id)
        {
            string Rpta = "";
            SqlConnection sqlcon = new SqlConnection();
            try
            {

                sqlcon = CONEXION_SQL.conectar();
                SqlCommand Comando = new SqlCommand("cajero_activar", sqlcon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@Id_Cajero", SqlDbType.Int).Value = Id;
                //sqlcon.Open();
                Rpta = Comando.ExecuteNonQuery() == 1 ? "OK" : "Se pudo desactivar el registro";

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

        public string Desactivar(int Id)
        {
            string Rpta = "";
            SqlConnection sqlcon = new SqlConnection();
            try
            {

                sqlcon = CONEXION_SQL.conectar();
                SqlCommand Comando = new SqlCommand("cajero_desactivar", sqlcon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@Id_Cajero", SqlDbType.Int).Value = Id;
                //sqlcon.Open();
                Rpta = Comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo desactivar el registro";

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
