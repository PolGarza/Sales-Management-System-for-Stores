namespace VENTANAS_MAD.Reportes
{
    partial class ReporteInventario
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
            this.reporte_producto_total_imprimirBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reporte_producto_total_imprimirTableAdapter = new VENTANAS_MAD.Reportes.DsMADTableAdapters.reporte_producto_total_imprimirTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DsMAD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporte_producto_total_imprimirBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DtsInventario";
            reportDataSource1.Value = this.reporte_producto_total_imprimirBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "VENTANAS_MAD.Reportes.RptInventario.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1047, 579);
            this.reportViewer1.TabIndex = 0;
            // 
            // DsMAD
            // 
            this.DsMAD.DataSetName = "DsMAD";
            this.DsMAD.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reporte_producto_total_imprimirBindingSource
            // 
            this.reporte_producto_total_imprimirBindingSource.DataMember = "reporte_producto_total_imprimir";
            this.reporte_producto_total_imprimirBindingSource.DataSource = this.DsMAD;
            // 
            // reporte_producto_total_imprimirTableAdapter
            // 
            this.reporte_producto_total_imprimirTableAdapter.ClearBeforeFill = true;
            // 
            // ReporteInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 579);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReporteInventario";
            this.Text = "Reporte Inventario";
            this.Load += new System.EventHandler(this.ReporteInventario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DsMAD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporte_producto_total_imprimirBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource reporte_producto_total_imprimirBindingSource;
        private DsMAD DsMAD;
        private DsMADTableAdapters.reporte_producto_total_imprimirTableAdapter reporte_producto_total_imprimirTableAdapter;
    }
}