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
    public partial class CONSULTA_VENTAS : Form
    {
        public CONSULTA_VENTAS()
        {
            InitializeComponent();
        }

        private void Listar()
        {
            try
            {
                DATAGV_Listado.DataSource = LOGICA_VENTA.Listar();
                this.Formato_Departamento();
                this.Limpiar();
                label_total_dep.Text = "Total registros: " + Convert.ToString(DATAGV_Listado.Rows.Count);

            }
            catch (Exception ex)
            {
                //nos dice si hay un error
                MessageBox.Show(ex.Message + ex.StackTrace);

            }
        }

        private void Buscar()
        {

            try
            {
                DATAGV_Listado.DataSource = LOGICA_VENTA.Buscar(TB_BUSCAR_DEP.Text);
                this.Formato_Departamento();
                label_total_dep.Text = "Total Ventas: " + Convert.ToString(DATAGV_Listado.Rows.Count);

            }
            catch (Exception ex)
            {
                //nos dice si hay un error
                MessageBox.Show(ex.Message + ex.StackTrace);

            }

        }

        private void Formato_Departamento()
        {
            DATAGV_Listado.Columns[0].Visible = false;
            DATAGV_Listado.Columns[1].Width = 65;
            DATAGV_Listado.Columns[1].HeaderText = "ID";
            DATAGV_Listado.Columns[2].Visible = false;
            DATAGV_Listado.Columns[3].Width = 100;
            DATAGV_Listado.Columns[3].HeaderText = "Cajero";
            DATAGV_Listado.Columns[4].Visible = false;
            DATAGV_Listado.Columns[5].Width = 100;
            DATAGV_Listado.Columns[5].HeaderText = "Numero de Caja";
            DATAGV_Listado.Columns[6].Width = 120;
            DATAGV_Listado.Columns[6].HeaderText = "Fecha de venta";
            DATAGV_Listado.Columns[7].Width = 100;
            DATAGV_Listado.Columns[7].HeaderText = "Descuento";
            DATAGV_Listado.Columns[8].Width = 100;
            DATAGV_Listado.Columns[8].HeaderText = "Total";
            DATAGV_Listado.Columns[9].Width = 65;
            DATAGV_Listado.Columns[9].HeaderText = "Estado";
        }

        private void Limpiar()
        {
            TB_BUSCAR_DEP.Clear();
            //ACtivar/Desactivar/Eliminar
            DATAGV_Listado.Columns[0].Visible = false;
            buttonanular.Visible = false;
            CHECKB_DEP.Checked = false;

        }

        private void CONSULTA_VENTAS_Load(object sender, EventArgs e)
        {
            this.Listar();
        }

        private void button1_buscar_cajero_Click(object sender, EventArgs e)
        {
            this.Buscar();
        }

        private void button1_volver_menu_Click(object sender, EventArgs e)
        {
            MENU_ADMINISTRADOR pantalla = new MENU_ADMINISTRADOR();
            pantalla.Show();
            this.Hide();
        }
    }
}
