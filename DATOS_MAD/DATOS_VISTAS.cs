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
    public class DATOS_VISTAS
    {
        public DataTable Listar()
        {
            
            DataTable Tabla = new DataTable();

            SqlConnection sqlcon = new SqlConnection();
            {



                // Creamos el  SqlCommand object.
                sqlcon = CONEXION_SQL.conectar();
                SqlCommand Comando = new SqlCommand("SELECT Id_Venta, Id_Cajero,  Caja_Num, Fecha, Total, codigo_venta FROM dbo.Ventas_Listado", sqlcon);

              
                try
                {
                    // Excutamos el query
                    SqlDataReader Resultado = Comando.ExecuteReader();
                    // Add the columns from the view to the DataTable object.
                    Tabla.Columns.Add("Id_Venta");
                    Tabla.Columns.Add("Id_Cajero");
                    Tabla.Columns.Add("Caja_Num");
                    Tabla.Columns.Add("Fecha");
                    Tabla.Columns.Add("Total");
              
                    Tabla.Columns.Add("codigo_venta");
                    // Rellenar el objeto DataTable con los datos del Servidor SQL..
                    while (Resultado.Read())
                    {
                        // Añade una fila al objeto DataTable.
                        DataRow dataRow = Tabla.NewRow();
                        // Establece los valores de las columnas del objeto DataRow.
                        dataRow["Id_Venta"] = Resultado["Id_Venta"];
                        dataRow["Id_Cajero"] = Resultado["Id_Cajero"];
                        dataRow["Caja_Num"] = Resultado["Caja_Num"];
                        dataRow["Fecha"] = Resultado["Fecha"];
                     
                        dataRow["Total"] = Resultado["Total"];
                       
                        dataRow["codigo_venta"] = Resultado["codigo_venta"];

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

        public DataTable Listar_Ventas()
        {
            DataTable Tabla = new DataTable();

            SqlConnection sqlcon = new SqlConnection();
            {



                // Creamos el  SqlCommand object.
                sqlcon = CONEXION_SQL.conectar();
                SqlCommand Comando = new SqlCommand("SELECT Nombre, Departamento, Unidades, Precio_Total, Id_Departamento, Devolucion, estado, Unidad_Medida FROM reporte_producto_total", sqlcon);


                try
                {
                    // Excutamos el query
                    SqlDataReader Resultado = Comando.ExecuteReader();
                    // Add the columns from the view to the DataTable object.
                    Tabla.Columns.Add("Nombre");
                    Tabla.Columns.Add("Departamento");
                    Tabla.Columns.Add("Unidades");
                    Tabla.Columns.Add("Precio_Total");
                    Tabla.Columns.Add("Id_Departamento");
                    Tabla.Columns.Add("Devolucion");
                    Tabla.Columns.Add("estado");
                    Tabla.Columns.Add("Unidad_Medida");
                    // Rellenar el objeto DataTable con los datos del Servidor SQL..
                    while (Resultado.Read())
                    {
                        // Añade una fila al objeto DataTable.
                        DataRow dataRow = Tabla.NewRow();
                        // Establece los valores de las columnas del objeto DataRow.
                        dataRow["Nombre_prodcuto"] = Resultado["Nombre_prodcuto"];
                        dataRow["Departamento"] = Resultado["Departamento"];
                        dataRow["Unidades"] = Resultado["Unidades"];
                        dataRow["Precio_Total"] = Resultado["Precio_Total"];
                        dataRow["Id_Departamento"] = Resultado["Id_Departamento"];
                        dataRow["Devolucion"] = Resultado["Devolucion"];
                        dataRow["estado"] = Resultado["estado"];
                        dataRow["Unidad_Medida"] = Resultado["Unidad_Medida"];

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
