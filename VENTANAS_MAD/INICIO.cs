using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VENTANAS_MAD
{
    public partial class INICIO : Form
    {
        public INICIO()
        {
            InitializeComponent();
        }

        private void button_admin_Click(object sender, EventArgs e)
        {
            INICIO_ADMINISTRADOR pantalla = new INICIO_ADMINISTRADOR();
            pantalla.Show();
            this.Hide();
        }

        private void button_cajero_Click(object sender, EventArgs e)
        {
            INICIO_CAJERO pantalla = new INICIO_CAJERO();
            pantalla.Show();
            this.Hide();
        }
    }
}
