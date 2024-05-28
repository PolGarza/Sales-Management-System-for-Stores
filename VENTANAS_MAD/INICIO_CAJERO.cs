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
    public partial class INICIO_CAJERO : Form
    {
        public INICIO_CAJERO()
        {
            InitializeComponent();
        }

        private void INICIO_CAJERO_Load(object sender, EventArgs e)
        {
            INICIO pantalla1 = new INICIO();
            pantalla1.Show();
            this.Hide();
        }

        private void button1_regresar_Click(object sender, EventArgs e)
        {
            INICIO pantalla1 = new INICIO();
            pantalla1.Show();
            this.Hide();
        }

        private void button1_inresar_admin_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable Tabla = new DataTable();
                Tabla = LOGICA_CAJERO.Login(text_Email.Text.Trim(), text_Clave.Text.Trim());
                if (Tabla.Rows.Count <= 0)
                {
                    MessageBox.Show("El email o la clave es incorrecta", "Acceso al Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (Convert.ToBoolean(Tabla.Rows[0][2]) == false)
                    {
                        MessageBox.Show("Este usuario no esta activo", "Acceso al Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MENU_CAJERO pantalla1 = new MENU_CAJERO();
                        pantalla1.IdCajero = Convert.ToInt32(Tabla.Rows[0][0]);
                        pantalla1.NombreCajero = Convert.ToString(Tabla.Rows[0][1]);
                        pantalla1.EstadoCajero = Convert.ToBoolean(Tabla.Rows[0][2]);
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

        private void provicional_Click(object sender, EventArgs e)
        {
            MENU_CAJERO pantalla1 = new MENU_CAJERO();
            pantalla1.Show();
            this.Hide();
        }
    }
}
