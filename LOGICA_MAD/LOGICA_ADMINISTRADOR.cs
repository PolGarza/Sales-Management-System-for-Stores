using DATOS_MAD;
using System.Data;
using ENTIDADES_MAD;

namespace LOGICA_MAD
{
    public class LOGICA_ADMINISTRADOR
    {
        public static DataTable Login(string Usuario, string Clave)
        {
            DATOS_ADMINISTRADOR Datos = new DATOS_ADMINISTRADOR();
            return Datos.Login(Usuario, Clave);
        }
    }
}
