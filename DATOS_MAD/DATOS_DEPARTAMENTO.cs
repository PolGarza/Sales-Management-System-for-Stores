using System;
using System.Data;
using ENTIDADES_MAD;
using System.Data.SqlClient;


namespace DATOS_MAD
{
    public class DATOS_DEPARTAMENTO
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
                SqlCommand Comando = new SqlCommand("departamento_listar", sqlcon);//1er parametronombre del objeto a la base de datos
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
       
        public DataTable Buscar(string valor)
        {

            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection sqlcon = new SqlConnection();

            try
            {

                sqlcon = CONEXION_SQL.conectar();
                SqlCommand Comando = new SqlCommand("departamento_buscar", sqlcon);
                Comando.CommandType = CommandType.StoredProcedure;
                //Se agrega el paramtro al comando, lo recibiremos con el nombre valor con sus caracteristicas entonces desde el negocio cuando haga referencia desde el negocio enviará los datos a ese parametro 
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

        public DataTable Seleccionar()
        {
            //con DataReader podremos leer una secuencia de filas en sql

            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection sqlcon = new SqlConnection();
            try
            {
                //no se puede hacer una instancia directa ya que nuestro constructor es privado
                sqlcon = CONEXION_SQL.conectar();
                SqlCommand Comando = new SqlCommand("departamento_seleccionar", sqlcon);//1er parametronombre del objeto a la base de datos
                Comando.CommandType = CommandType.StoredProcedure;//Hacer referencia a un procedimiento almacenador de la base de datos
                
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


        public string Existe(string Valor)
        {
            string Rpta = "";
            SqlConnection sqlcon = new SqlConnection();
            try
            {
                //manera de agregar parametros 
                sqlcon = CONEXION_SQL.conectar();
                SqlCommand Comando = new SqlCommand("Departamento_existe", sqlcon);
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

        public string Insertar(Departamento objeto)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = CONEXION_SQL.conectar();
                SqlCommand Comando = new SqlCommand("departamento_insertar", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@nombre", SqlDbType.VarChar).Value = objeto.nombre_Departamento;
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


        public string Actualizar(Departamento objeto)
        {

            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = CONEXION_SQL.conectar();
                SqlCommand Comando = new SqlCommand("departamento_actualizar", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@Id_Departamento", SqlDbType.Int).Value = objeto.id_Departamento;
                Comando.Parameters.Add("@nombre", SqlDbType.VarChar).Value = objeto.nombre_Departamento;

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
                SqlCommand Comando = new SqlCommand("departamento_eliminar", sqlcon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@Id_Departamento", SqlDbType.Int).Value = Id;
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
                SqlCommand Comando = new SqlCommand("departamento_activar", sqlcon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@Id_Departamento", SqlDbType.Int).Value = Id;
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
                SqlCommand Comando = new SqlCommand("departamento_desactivar", sqlcon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@Id_Departamento", SqlDbType.Int).Value = Id;
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
