namespace VENTANAS_MAD.Reportes
{
    partial class ReporteVentaTotal
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
            this.Reporte_Venta_TotalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Reporte_Venta_TotalTableAdapter = new VENTANAS_MAD.Reportes.DsMADTableAdapters.Reporte_Venta_TotalTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DsMAD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Reporte_Venta_TotalBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DtsVentaTotal";
            reportDataSource1.Value = this.Reporte_Venta_TotalBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "VENTANAS_MAD.Reportes.RptVentaTotal.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1131, 602);
            this.reportViewer1.TabIndex = 0;
            // 
            // DsMAD
            // 
            this.DsMAD.DataSetName = "DsMAD";
            this.DsMAD.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Reporte_Venta_TotalBindingSource
            // 
            this.Reporte_Venta_TotalBindingSource.DataMember = "Reporte_Venta_Total";
            this.Reporte_Venta_TotalBindingSource.DataSource = this.DsMAD;
            // 
            // Reporte_Venta_TotalTableAdapter
            // 
            this.Reporte_Venta_TotalTableAdapter.ClearBeforeFill = true;
            // 
            // ReporteVentaTotal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 602);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReporteVentaTotal";
            this.Text = "Reporte Venta Total";
            this.Load += new System.EventHandler(this.ReporteVentaTotal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DsMAD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Reporte_Venta_TotalBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Reporte_Venta_TotalBindingSource;
        private DsMAD DsMAD;
        private DsMADTableAdapters.Reporte_Venta_TotalTableAdapter Reporte_Venta_TotalTableAdapter;
    }
}