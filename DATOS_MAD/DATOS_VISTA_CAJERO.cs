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
   public class DATOS_VISTA_CAJERO
    {
        public DataTable Listar()
        {

            DataTable Tabla = new DataTable();

            SqlConnection sqlcon = new SqlConnection();
            {

                // Creamos el  SqlCommand object.
                sqlcon = CONEXION_SQL.conectar();
                SqlCommand Comando = new SqlCommand("SELECT Id_Cajero, Nombre, CURP, Email, Clave, Fecha_Nam, Fecha_Ingreso, Estado FROM Cajero", sqlcon);
                try
                {
                    // Excutamos el query
                    SqlDataReader Resultado = Comando.ExecuteReader();
                    // Add the columns from the view to the DataTable object.
                    Tabla.Columns.Add("Id_Cajero");
                    Tabla.Columns.Add("Nombre");
                    Tabla.Columns.Add("CURP");
                    Tabla.Columns.Add("Email");
                    Tabla.Columns.Add("Clave");
                    Tabla.Columns.Add("Fecha_Nam");
                    Tabla.Columns.Add("Fecha_Ingreso");
                    Tabla.Columns.Add("Estado");
                    // Rellenar el objeto DataTable con los datos del Servidor SQL..
                    while (Resultado.Read())
                    {
                        // Añade una fila al objeto DataTable.
                        DataRow dataRow = Tabla.NewRow();
                        // Establece los valores de las columnas del objeto DataRow.
                        dataRow["Id_Cajero"] = Resultado["Id_Cajero"];
                        dataRow["Nombre"] = Resultado["Nombre"];
                        dataRow["CURP"] = Resultado["CURP"];
                        dataRow["Email"] = Resultado["Email"];
                        dataRow["Clave"] = Resultado["Clave"];
                        dataRow["Fecha_Nam"] = Resultado["Fecha_Nam"];
                        dataRow["Fecha_Ingreso"] = Resultado["Fecha_Ingreso"];
                        dataRow["Estado"] = Resultado["Estado"];

                        // Añadir el objeto DataRow al objeto DataTable
                        Tabla.Rows.Add(dataRow);
                    }
                    // Cerramos el  SQL DataReader object.
                    return Tabla;
                }
                catch (Exception ex)
                {
                    // Handle the exception.
                    throw ex;
                }

                finally
                {
                    if (sqlcon.State == ConnectionState.Open) sqlcon.Close();
                }
            }
        }
    }
}
