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
    public partial class VISTA_CAJERO : Form
    {
        public VISTA_CAJERO()
        {
            InitializeComponent();
        }
        private void Buscar()
        {

            try
            {
                DateTime fecha_inicial = Convert.ToDateTime(dateTimeInicio.Text);
                DateTime fecha_final = Convert.ToDateTime(dateTimeFin.Text);

                DgvELEGIR_CAJERO.DataSource = LOGICA_CAJERO.Buscar(TxtBuscar.Text, fecha_inicial, fecha_final);
                this.Formato_Cajero();
                LblTotal.Text = "Total registros: " + Convert.ToString(DgvELEGIR_CAJERO.Rows.Count);

            }
            catch (Exception ex)
            {
                //nos dice si hay un error
                MessageBox.Show(ex.Message + ex.StackTrace);

            }

        }

        private void Formato_Cajero()
        {
            DgvELEGIR_CAJERO.Columns[0].Visible = false;
            DgvELEGIR_CAJERO.Columns[1].Width = 50;
            DgvELEGIR_CAJERO.Columns[1].HeaderText = "ID";
            DgvELEGIR_CAJERO.Columns[2].Width = 170;
            DgvELEGIR_CAJERO.Columns[2].HeaderText = "Nombre";
            DgvELEGIR_CAJERO.Columns[3].Width = 120;
            DgvELEGIR_CAJERO.Columns[4].Width = 120;
            DgvELEGIR_CAJERO.Columns[4].HeaderText = "Email";
            DgvELEGIR_CAJERO.Columns[5].Width = 100;
            DgvELEGIR_CAJERO.Columns[5].HeaderText = "Fecha Nacimiento";
            DgvELEGIR_CAJERO.Columns[6].Width = 100;
            DgvELEGIR_CAJERO.Columns[6].HeaderText = "Fecha Ingreso";
            DgvELEGIR_CAJERO.Columns[7].Width = 50;
            DgvELEGIR_CAJERO.Columns[7].HeaderText = "Estado";
        }



        private void VISTA_CAJERO_Load(object sender, EventArgs e)
        {
            this.Buscar();

        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void ChkSeleccionar_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void DgvListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnBuscar_Click_1(object sender, EventArgs e)
        {
            this.Buscar();
        }

        private void DgvELEGIR_CAJERO_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            VARIABLES.IdCajero = Convert.ToInt32(DgvELEGIR_CAJERO.CurrentRow.Cells["ID"].Value);
            VARIABLES.NombreCajero = Convert.ToString(DgvELEGIR_CAJERO.CurrentRow.Cells["NombreCajero"].Value);
            this.Close();

        }
    }
}
