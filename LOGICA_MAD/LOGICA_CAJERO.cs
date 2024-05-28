using System;
using System.Data.SqlClient;
using System.Data;
using DATOS_MAD;
using ENTIDADES_MAD;

namespace LOGICA_MAD
{
    public class LOGICA_CAJERO
    {
        //serán staticas ya que no se generaran objetos solo se haran referencia a
        public static DataTable Listar()
        {
            //Nota: La función "Listar" no es estatica por eso se le hace la instancia
            DATOS_CAJERO Datos = new DATOS_CAJERO();
            return Datos.Listar();
        }

        public static DataTable Buscar(string valor, DateTime fecha_inicial, DateTime fecha_final)
        {
            DATOS_CAJERO Datos = new DATOS_CAJERO();
            return Datos.Buscar(valor, fecha_inicial, fecha_final);
        }

         public static DataTable Login(string Email, string Clave)
         {
             DATOS_CAJERO Datos = new DATOS_CAJERO();
             return Datos.Login(Email, Clave);
         }

        public static string Insertar(string nombrec, string curp, string email, string clave, string fechanam)
        {

            DATOS_CAJERO Datos = new DATOS_CAJERO();

            string Existe = Datos.Existe(email);
            if (Existe.Equals("1"))
            {
                return "El Cajero ya existe";
            }
            else
            {
                Cajero objeto = new Cajero();
                objeto.NombreCajero = nombrec;
                objeto.CURP = curp;
                objeto.EmailCajero = email;
                objeto.ClaveCajero = clave;
                objeto.FechaNam = fechanam;
                return Datos.Insertar(objeto);
            }

        }

        public static string Actualizar(int Id, string nombrec, string curp, string emailant, string email, string clave, string fechanam)
        {
            DATOS_CAJERO Datos = new DATOS_CAJERO();
            Cajero objeto = new Cajero();

            if (emailant.Equals(emailant))
            {
                objeto.IdCajero = Id;
                objeto.NombreCajero = nombrec;
                objeto.CURP = curp;
                objeto.EmailCajero = email;
                objeto.ClaveCajero = clave;
                objeto.FechaNam = fechanam;
                return Datos.Actualizar(objeto);
            }
            else
            {
                string Existe = Datos.Existe(email);
                if (Existe.Equals("1"))
                {
                    return "El Cajero ya existe";

                }
                else
                {
                    objeto.IdCajero = Id;
                    objeto.NombreCajero = nombrec;
                    objeto.CURP = curp;
                    objeto.EmailCajero = email;
                    objeto.ClaveCajero = clave;
                    objeto.FechaNam = fechanam;
                    return Datos.Actualizar(objeto);
                }
            }


        }

        public static string Eliminar(int Id)
        {
            DATOS_CAJERO Datos = new DATOS_CAJERO();
            return Datos.Eliminar(Id);
        }

        public static string Activar(int Id)
        {
            DATOS_CAJERO Datos = new DATOS_CAJERO();
            return Datos.Activar(Id);

        }

        public static string Desactivar(int Id)
        {
            DATOS_CAJERO Datos = new DATOS_CAJERO();
            return Datos.Desactivar(Id);
        }
    }
}
