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
    public partial class CAJEROS : Form
    {
        public CAJEROS()
        {
            InitializeComponent();
        }

        private void Listar()
        {
            try
            {
                DATAGV_Listado.DataSource = LOGICA_VISTA_C.Listar();


            }
            catch (Exception ex)
            {
                //nos dice si hay un error
                MessageBox.Show(ex.Message + ex.StackTrace);

            }
        }

        private void CAJEROS_Load(object sender, EventArgs e)
        {
            this.Listar();
        }

        private void button1_volver_menu_Click(object sender, EventArgs e)
        {
            MENU_ADMINISTRADOR pantalla = new MENU_ADMINISTRADOR();
            pantalla.Show();
            this.Hide();
        }

        private void PDF()
        {
            try
            {
                var doc = new Document(PageSize.A4.Rotate(), 10, 10, 10, 10);
                // Guarda el reporte en el escritorio de windows (Desktop).         
                string filename = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + @"\ReporteCajero.pdf";
                var file = new FileStream(filename, FileMode.Create, FileAccess.Write, FileShare.ReadWrite);
                PdfWriter.GetInstance(doc, file);
                doc.Open();
                this.ExportarDatosPDF(DATAGV_Listado, doc);
                doc.Close();
                System.Diagnostics.Process.Start(filename);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public float[] GetColumnasSize(DataGridView dg)
        {
            float[] values = new float[dg.ColumnCount];
            for (int i = 0; i < dg.ColumnCount; i++)
            {
                values[i] = (float)dg.Columns[i].Width;
            }
            return values;
        }

        public void ExportarDatosPDF(DataGridView DG, Document document)
        {
            PdfPTable datatable = new PdfPTable(DG.ColumnCount);
            datatable.DefaultCell.Padding = 3;
            float[] headerwidths = GetColumnasSize(DG);
            datatable.SetWidths(headerwidths);
            datatable.WidthPercentage = 100;
            datatable.DefaultCell.BorderWidth = 1;
            datatable.DefaultCell.HorizontalAlignment = Element.ALIGN_LEFT;

            //Paragraph encabezado = new Paragraph("REPORTE DE TARIFAS", new Font(Font.FontFamily.TIMES_ROMAN, 20, Font.BOLD));
            document.Add(new Phrase("REPORTE DE CAJEROS"));

            for (int i = 0; i < DG.ColumnCount; i++)
            {
                datatable.AddCell(DG.Columns[i].HeaderText);
            }
            datatable.HeaderRows = 1;
            datatable.DefaultCell.BorderWidth = 1;

            for (int i = 0; i <= DG.RowCount - 2; i++)
            {
                for (int j = 0; j <= DG.ColumnCount - 1; j++)
                {
                    datatable.AddCell(DG[j, i].Value.ToString());
                }
                datatable.CompleteRow();
            }

            //document.Add(encabezado);
            document.Add(datatable);
        }

        private void button_reporte_Click(object sender, EventArgs e)
        {
            this.PDF();
        }
    }


}
