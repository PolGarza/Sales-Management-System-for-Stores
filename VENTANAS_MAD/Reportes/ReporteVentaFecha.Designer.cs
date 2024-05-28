namespace VENTANAS_MAD.Reportes
{
    partial class ReporteVentaFecha
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DsMAD = new VENTANAS_MAD.Reportes.DsMAD();
            this.Reporte_Venta_FechasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Reporte_Venta_FechasTableAdapter = new VENTANAS_MAD.Reportes.DsMADTableAdapters.Reporte_Venta_FechasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DsMAD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Reporte_Venta_FechasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DtsVentaFecha";
            reportDataSource1.Value = this.Reporte_Venta_FechasBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "VENTANAS_MAD.Reportes.RptVentaFecha.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1144, 607);
            this.reportViewer1.TabIndex = 0;
            // 
            // DsMAD
            // 
            this.DsMAD.DataSetName = "DsMAD";
            this.DsMAD.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Reporte_Venta_FechasBindingSource
            // 
            this.Reporte_Venta_FechasBindingSource.DataMember = "Reporte_Venta_Fechas";
            this.Reporte_Venta_FechasBindingSource.DataSource = this.DsMAD;
            // 
            // Reporte_Venta_FechasTableAdapter
            // 
            this.Reporte_Venta_FechasTableAdapter.ClearBeforeFill = true;
            // 
            // ReporteVentaFecha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 607);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReporteVentaFecha";
            this.Text = "Reporte Venta Fecha";
            this.Load += new System.EventHandler(this.ReporteVentaFecha_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DsMAD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Reporte_Venta_FechasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Reporte_Venta_FechasBindingSource;
        private DsMAD DsMAD;
        private DsMADTableAdapters.Reporte_Venta_FechasTableAdapter Reporte_Venta_FechasTableAdapter;
    }
}