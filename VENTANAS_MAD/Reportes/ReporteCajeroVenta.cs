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
    public partial class ReporteCajeroVenta : Form
    {
        public ReporteCajeroVenta()
        {
            InitializeComponent();
        }

        private void ReporteCajeroVenta_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DsMAD.reporte_venta_total_imprimir' table. You can move, or remove it, as needed.
            this.reporte_venta_total_imprimirTableAdapter.Fill(this.DsMAD.reporte_venta_total_imprimir);

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
