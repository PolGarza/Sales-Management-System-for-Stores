using System;
using System.Data.SqlClient;
using System.Data;
using DATOS_MAD;
using ENTIDADES_MAD;

namespace LOGICA_MAD
{
    public class LOGICA_DEPARTAMENTO
    {

        //serán staticas ya que no se generaran objetos solo se haran referencia a
        public static DataTable Listar()
        {
            //Nota: La función "Listar" no es estatica por eso se le hace la instancia
            DATOS_DEPARTAMENTO Datos = new DATOS_DEPARTAMENTO();
            return Datos.Listar();
        }

        public static DataTable Buscar(string valor)
        {
            DATOS_DEPARTAMENTO Datos = new DATOS_DEPARTAMENTO();
            return Datos.Buscar(valor);
        }

        public static DataTable Seleccionar()
        {
            //Nota: La función "Listar" no es estatica por eso se le hace la instancia
            DATOS_DEPARTAMENTO Datos = new DATOS_DEPARTAMENTO();
            return Datos.Seleccionar();
        }

        public static string Insertar(string nombre2)
        {

            DATOS_DEPARTAMENTO Datos = new DATOS_DEPARTAMENTO();

            string Existe = Datos.Existe(nombre2);
            if (Existe.Equals("1"))
            {
                return "El departamento ya existe";
            }
            else
            {
                Departamento Obj = new Departamento();
                Obj.nombre_Departamento = nombre2;
                return Datos.Insertar(Obj);
            }

        }

        public static string Actualizar(int Id, string nombre)
        {
            DATOS_DEPARTAMENTO Datos = new DATOS_DEPARTAMENTO();
            string Existe = Datos.Existe(nombre);
            if (Existe.Equals("1"))
            {
                return "Ya existe este departamento";
            }
            else
            {
                Departamento objeto = new Departamento();
                objeto.id_Departamento = Id;
                objeto.nombre_Departamento = nombre;
                return Datos.Actualizar(objeto);
            }


        }

        public static string Eliminar(int Id)
        {
            DATOS_DEPARTAMENTO Datos = new DATOS_DEPARTAMENTO();
            return Datos.Eliminar(Id);
        }

        public static string Activar(int Id)
        {
            DATOS_DEPARTAMENTO Datos = new DATOS_DEPARTAMENTO();
            return Datos.Activar(Id);

        }

        public static string Desactivar(int Id)
        {
            DATOS_DEPARTAMENTO Datos = new DATOS_DEPARTAMENTO();
            return Datos.Desactivar(Id);
        }


    }

  
}
