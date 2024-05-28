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
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace VENTANAS_MAD
{
    public partial class VENTAS_IMPRIMIR : Form
    {
        public VENTAS_IMPRIMIR()
        {
            InitializeComponent();
        }

        private void Listar_Ventas()
        {
            try
            {
                DATAGV_Listado.DataSource = LOGICA_VISTAS.Listar_Ventas();


            }
            catch (Exception ex)
            {
                //nos dice si hay un error
                MessageBox.Show(ex.Message + ex.StackTrace);

            }
        }

        private void Mensaje_error(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Ventas ", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Mensaje_ok(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Sistema de ventas", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void VENTAS_IMPRIMIR_Load(object sender, EventArgs e)
        {
            this.Listar_Ventas();
        }
    }
}
