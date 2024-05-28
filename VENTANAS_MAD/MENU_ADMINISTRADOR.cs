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
    public partial class MENU_ADMINISTRADOR : Form
    {
        private int childFormNumber = 0;

        public int IdAdmin;
        public string NombreAdmin;
        public bool EstadoAdmin;

        public MENU_ADMINISTRADOR()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void departamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DEPARTAMENTO pantalla = new DEPARTAMENTO();
            pantalla.Show();
            this.Hide();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PRODUCTO_ADMINISTRAR pantalla = new PRODUCTO_ADMINISTRAR();
            pantalla.Show();
            this.Hide();
        }

        private void cAJEROSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CAJERO pantalla = new CAJERO();
            pantalla.Show();
            this.Hide();
        }

        private void administarCajeroToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void MENU_ADMINISTRADOR_Load(object sender, EventArgs e)
        {

        }

        private void vENTASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CONSULTA_VENTAS pantalla = new CONSULTA_VENTAS();
            pantalla.Show();
            this.Hide();
        }

        private void vERToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void rEPORTESToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void vENTASToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            VENTAS pantalla = new VENTAS();
            pantalla.Show();
            this.Hide();
        }

        private void sALIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            INICIO pantalla1 = new INICIO();
            pantalla1.Show();
            this.Hide();
        }

        private void dEVOLUCIONESToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DEVOLUCIONES pantalla1 = new DEVOLUCIONES();
            pantalla1.Show();
            this.Hide();
        }

        private void cAJEROSToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CAJEROS pantalla1 = new CAJEROS();
            pantalla1.Show();
            this.Hide();
        }

        private void vENTASToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            VENTAS_IMPRIMIR pantalla1 = new VENTAS_IMPRIMIR();
            pantalla1.Show();
            this.Hide();
        }

        private void vENTASToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Reportes.ReporteCajeroVenta Reporte = new Reportes.ReporteCajeroVenta();
            Reporte.ShowDialog();
        }

        private void iNVENTARIOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reportes.ReporteInventario Reporte = new Reportes.ReporteInventario();
            Reporte.ShowDialog();
        }

        private void fECHASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reportes.ReporteVentaFecha Reporte = new Reportes.ReporteVentaFecha();
            Reporte.ShowDialog();
        }

        private void vENTASToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Reportes.ReporteCajero Reporte = new Reportes.ReporteCajero();
            Reporte.ShowDialog();
        }

        private void tOTALToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reportes.ReporteVentaTotal Reporte = new Reportes.ReporteVentaTotal();
            Reporte.ShowDialog();
        }
    }
}
