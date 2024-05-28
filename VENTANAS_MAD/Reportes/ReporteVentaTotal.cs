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
    public partial class ReporteVentaTotal : Form
    {
        public ReporteVentaTotal()
        {
            InitializeComponent();
        }

        private void ReporteVentaTotal_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DsMAD.Reporte_Venta_Total' table. You can move, or remove it, as needed.
            this.Reporte_Venta_TotalTableAdapter.Fill(this.DsMAD.Reporte_Venta_Total);

            this.reportViewer1.RefreshReport();
        }
    }
}
