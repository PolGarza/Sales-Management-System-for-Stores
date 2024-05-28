using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LOGICA_MAD;

namespace VENTANAS_MAD
{
    public partial class INICIO_ADMINISTRADOR : Form
    {
        public INICIO_ADMINISTRADOR()
        {
            InitializeComponent();
        }

        private void button1_inresar_admin_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable Tabla = new DataTable();
                Tabla = LOGICA_ADMINISTRADOR.Login(text_Usuario.Text.Trim(), textCLAVE.Text.Trim());
                if (Tabla.Rows.Count <= 0)
                {
                    MessageBox.Show("El usuario o la clave es incorrecta", "Acceso al Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (Convert.ToBoolean(Tabla.Rows[0][2]) == false)
                    {
                        MessageBox.Show("Este usuario no esta activo", "Acceso al Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MENU_ADMINISTRADOR pantalla1 = new MENU_ADMINISTRADOR();
                        pantalla1.IdAdmin = Convert.ToInt32(Tabla.Rows[0][0]);
                        pantalla1.NombreAdmin = Convert.ToString(Tabla.Rows[0][1]);
                        pantalla1.EstadoAdmin = Convert.ToBoolean(Tabla.Rows[0][2]);
                        pantalla1.Show();
                        this.Hide();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void INICIO_ADMINISTRADOR_Load(object sender, EventArgs e)
        {

        }

        private void button1_regresar_Click(object sender, EventArgs e)
        {
            INICIO pantalla1 = new INICIO();
            pantalla1.Show();
            this.Hide();
        }
    }
}
