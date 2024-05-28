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
    public static class LOGICA_PRODUCTO
    {
        //serán staticas ya que no se generaran objetos solo se haran referencia a
        public static DataTable Listar()
        {
            //Nota: La función "Listar" no es estatica por eso se le hace la instancia
            DATOS_PRODUCTOS Datos = new DATOS_PRODUCTOS();
            return Datos.Listar();
        }

        public static DataTable Buscar(string valor)
        {
            DATOS_PRODUCTOS Datos = new DATOS_PRODUCTOS();
            return Datos.Buscar(valor);
        }

        public static DataTable BuscarVenta(string valor)
        {
            DATOS_PRODUCTOS Datos = new DATOS_PRODUCTOS();
            return Datos.BuscarVenta(valor);
        }

        public static DataTable BuscarNombre(string valor)
        {
            DATOS_PRODUCTOS Datos = new DATOS_PRODUCTOS();
            return Datos.BuscarNombre(valor);
        }

        public static string Insertar(int Id_dep, string nombre2, string descripcion_product, decimal precio_product,int stock_product, string UM, decimal costo_product, string Dev )
        {


            DATOS_PRODUCTOS Datos = new DATOS_PRODUCTOS();

            string Existe = Datos.Existe(nombre2);
            if (Existe.Equals("1"))
            {
                return "El producto ya existe";
            }
            else
            {
                Producto Obj = new Producto();
                Obj.Id_departamento_1 = Id_dep;

                Obj.Nombre = nombre2;
                Obj.Descripcion = descripcion_product;
                Obj.Precio_prodcuto = precio_product;
                Obj.Unidad = UM;
                Obj.Costo_prodcuto = costo_product;
                Obj.stock = stock_product;
                Obj.Devolucion = Dev;

                return Datos.Insertar(Obj);
            }

        }

        public static string Actualizar(int Id_prod, int Id_dep, string nombre2, string descripcion_product, decimal precio_product, int stock_product, string UM, decimal costo_product, string Dev)
        {
            DATOS_PRODUCTOS Datos = new DATOS_PRODUCTOS();
            Producto Obj = new Producto();

            string Existe = Datos.Existe(Convert.ToString(Id_prod));
            if (Existe.Equals("1"))
            {
                Obj.Id_producto1 = Id_prod;
                Obj.Id_departamento_1 = Id_dep;
                Obj.Nombre = nombre2;
                Obj.Descripcion = descripcion_product;
                Obj.Precio_prodcuto = precio_product;
                Obj.Unidad = UM;
                Obj.Costo_prodcuto = costo_product;
                Obj.stock = stock_product;
                Obj.Devolucion = Dev;

                return Datos.Actualizar(Obj);
            }
            else{

                //Datos.Actualizar(Obj);
           
                return "El artículo ya existe";
            }

        }

        public static string Eliminar(int Id)
        {
            DATOS_PRODUCTOS Datos = new DATOS_PRODUCTOS();
            return Datos.Eliminar(Id);
        }

        public static string Activar(int Id)
        {
            DATOS_PRODUCTOS Datos = new DATOS_PRODUCTOS();
            return Datos.Activar(Id);

        }

        public static string Desactivar(int Id)
        {
            DATOS_PRODUCTOS Datos = new DATOS_PRODUCTOS();
            return Datos.Desactivar(Id);
        }
    }
}
