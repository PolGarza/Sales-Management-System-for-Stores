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
    public partial class ReporteCajero : Form
    {
        public ReporteCajero()
        {
            InitializeComponent();
        }

        private void ReporteCajero_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DsMAD.reporte_cajero_imprimir' table. You can move, or remove it, as needed.
            this.reporte_cajero_imprimirTableAdapter.Fill(this.DsMAD.reporte_cajero_imprimir);

            this.reportViewer1.RefreshReport();
        }
    }
}
