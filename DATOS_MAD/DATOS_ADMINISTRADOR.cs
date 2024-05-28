using System;
using System.Data;
using ENTIDADES_MAD;
using System.Data.SqlClient;

namespace DATOS_MAD
{
    public class DATOS_ADMINISTRADOR
    {
        public DataTable Login(string Usuario, string Clave)
        {

            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection sqlcon = new SqlConnection();

            try
            {

                sqlcon = CONEXION_SQL.conectar();
                SqlCommand Comando = new SqlCommand("administrador_login", sqlcon);
                Comando.CommandType = CommandType.StoredProcedure;
                //Se agrega el paramtro al comando, lo recibiremos con el nombre valor con sus caracteristicas entonces desde el negocio cuando haga referencia desde el negocio enviará los datos a ese parametro 
                //sqlcon.Open();
                Comando.Parameters.Add("@usuario", SqlDbType.VarChar).Value = Usuario;
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
    }
}
