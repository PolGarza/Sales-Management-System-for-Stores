namespace VENTANAS_MAD.Reportes
{
    partial class ReporteCajero
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
            this.reporte_cajero_imprimirBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reporte_cajero_imprimirTableAdapter = new VENTANAS_MAD.Reportes.DsMADTableAdapters.reporte_cajero_imprimirTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DsMAD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporte_cajero_imprimirBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DtsCajero";
            reportDataSource1.Value = this.reporte_cajero_imprimirBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "VENTANAS_MAD.Reportes.RptCajero.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1282, 560);
            this.reportViewer1.TabIndex = 0;
            // 
            // DsMAD
            // 
            this.DsMAD.DataSetName = "DsMAD";
            this.DsMAD.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reporte_cajero_imprimirBindingSource
            // 
            this.reporte_cajero_imprimirBindingSource.DataMember = "reporte_cajero_imprimir";
            this.reporte_cajero_imprimirBindingSource.DataSource = this.DsMAD;
            // 
            // reporte_cajero_imprimirTableAdapter
            // 
            this.reporte_cajero_imprimirTableAdapter.ClearBeforeFill = true;
            // 
            // ReporteCajero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 560);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReporteCajero";
            this.Text = "Reporte Cajero";
            this.Load += new System.EventHandler(this.ReporteCajero_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DsMAD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporte_cajero_imprimirBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource reporte_cajero_imprimirBindingSource;
        private DsMAD DsMAD;
        private DsMADTableAdapters.reporte_cajero_imprimirTableAdapter reporte_cajero_imprimirTableAdapter;
    }
}