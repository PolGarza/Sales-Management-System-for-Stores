namespace VENTANAS_MAD.Reportes
{
    partial class ReporteCajeroVenta
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
            this.reporte_venta_total_imprimirBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DsMAD = new VENTANAS_MAD.Reportes.DsMAD();
            this.reporte_venta_total_imprimirTableAdapter = new VENTANAS_MAD.Reportes.DsMADTableAdapters.reporte_venta_total_imprimirTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.reporte_venta_total_imprimirBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DsMAD)).BeginInit();
            this.SuspendLayout();
            // 
            // reporte_venta_total_imprimirBindingSource
            // 
            this.reporte_venta_total_imprimirBindingSource.DataMember = "reporte_venta_total_imprimir";
            this.reporte_venta_total_imprimirBindingSource.DataSource = this.DsMAD;
            // 
            // DsMAD
            // 
            this.DsMAD.DataSetName = "DsMAD";
            this.DsMAD.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reporte_venta_total_imprimirTableAdapter
            // 
            this.reporte_venta_total_imprimirTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DstVenta";
            reportDataSource1.Value = this.reporte_venta_total_imprimirBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "VENTANAS_MAD.Reportes.RptVentas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1234, 804);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // ReporteCajeroVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 804);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReporteCajeroVenta";
            this.Text = "Reporte Cajero Venta";
            this.Load += new System.EventHandler(this.ReporteCajeroVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reporte_venta_total_imprimirBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DsMAD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource reporte_venta_total_imprimirBindingSource;
        private DsMAD DsMAD;
        private DsMADTableAdapters.reporte_venta_total_imprimirTableAdapter reporte_venta_total_imprimirTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}