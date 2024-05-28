using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VENTANAS_MAD.Reportes
{
    public partial class ReporteInventario : Form
    {
        public ReporteInventario()
        {
            InitializeComponent();
        }

        private void ReporteInventario_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DsMAD.reporte_producto_total_imprimir' table. You can move, or remove it, as needed.
            this.reporte_producto_total_imprimirTableAdapter.Fill(this.DsMAD.reporte_producto_total_imprimir);

            this.reportViewer1.RefreshReport();
        }
    }
}
