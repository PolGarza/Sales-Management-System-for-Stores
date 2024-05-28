namespace VENTANAS_MAD
{
    partial class VENTAS_IMPRIMIR
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
            this.button_reporte = new System.Windows.Forms.Button();
            this.button1_volver_menu = new System.Windows.Forms.Button();
            this.button1_buscar_cajero = new System.Windows.Forms.Button();
            this.TB_BUSCAR_DEP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.DATAGV_Listado = new System.Windows.Forms.DataGridView();
            this.label_total_dep = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DATAGV_Listado)).BeginInit();
            this.SuspendLayout();
            // 
            // button_reporte
            // 
            this.button_reporte.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_reporte.Location = new System.Drawing.Point(36, 689);
            this.button_reporte.Margin = new System.Windows.Forms.Padding(4);
            this.button_reporte.Name = "button_reporte";
            this.button_reporte.Size = new System.Drawing.Size(200, 28);
            this.button_reporte.TabIndex = 47;
            this.button_reporte.Text = "Imprimir";
            this.button_reporte.UseVisualStyleBackColor = true;
            // 
            // button1_volver_menu
            // 
            this.button1_volver_menu.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1_volver_menu.Location = new System.Drawing.Point(890, 54);
            this.button1_volver_menu.Margin = new System.Windows.Forms.Padding(4);
            this.button1_volver_menu.Name = "button1_volver_menu";
            this.button1_volver_menu.Size = new System.Drawing.Size(117, 28);
            this.button1_volver_menu.TabIndex = 46;
            this.button1_volver_menu.Text = "Volver";
            this.button1_volver_menu.UseVisualStyleBackColor = true;
            // 
            // button1_buscar_cajero
            // 
            this.button1_buscar_cajero.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1_buscar_cajero.Location = new System.Drawing.Point(468, 60);
            this.button1_buscar_cajero.Margin = new System.Windows.Forms.Padding(4);
            this.button1_buscar_cajero.Name = "button1_buscar_cajero";
            this.button1_buscar_cajero.Size = new System.Drawing.Size(117, 28);
            this.button1_buscar_cajero.TabIndex = 45;
            this.button1_buscar_cajero.Text = "Buscar";
            this.button1_buscar_cajero.UseVisualStyleBackColor = true;
            // 
            // TB_BUSCAR_DEP
            // 
            this.TB_BUSCAR_DEP.Location = new System.Drawing.Point(103, 62);
            this.TB_BUSCAR_DEP.Margin = new System.Windows.Forms.Padding(4);
            this.TB_BUSCAR_DEP.Name = "TB_BUSCAR_DEP";
            this.TB_BUSCAR_DEP.Size = new System.Drawing.Size(356, 22);
            this.TB_BUSCAR_DEP.TabIndex = 44;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 64);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 19);
            this.label3.TabIndex = 43;
            this.label3.Text = "Buscar :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 19);
            this.label1.TabIndex = 40;
            this.label1.Text = "Buscar :";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(27, 108);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1017, 560);
            this.tabControl1.TabIndex = 41;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.DATAGV_Listado);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1009, 531);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Ventas";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // DATAGV_Listado
            // 
            this.DATAGV_Listado.AllowUserToAddRows = false;
            this.DATAGV_Listado.AllowUserToDeleteRows = false;
            this.DATAGV_Listado.AllowUserToOrderColumns = true;
            this.DATAGV_Listado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DATAGV_Listado.Location = new System.Drawing.Point(4, 4);
            this.DATAGV_Listado.Margin = new System.Windows.Forms.Padding(4);
            this.DATAGV_Listado.Name = "DATAGV_Listado";
            this.DATAGV_Listado.ReadOnly = true;
            this.DATAGV_Listado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DATAGV_Listado.Size = new System.Drawing.Size(997, 519);
            this.DATAGV_Listado.TabIndex = 1;
            // 
            // label_total_dep
            // 
            this.label_total_dep.AutoSize = true;
            this.label_total_dep.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_total_dep.Location = new System.Drawing.Point(710, 694);
            this.label_total_dep.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_total_dep.Name = "label_total_dep";
            this.label_total_dep.Size = new System.Drawing.Size(184, 19);
            this.label_total_dep.TabIndex = 42;
            this.label_total_dep.Text = "Departamentos actuales : ";
            // 
            // VENTAS_IMPRIMIR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1067, 746);
            this.Controls.Add(this.button_reporte);
            this.Controls.Add(this.button1_volver_menu);
            this.Controls.Add(this.button1_buscar_cajero);
            this.Controls.Add(this.TB_BUSCAR_DEP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label_total_dep);
            this.Name = "VENTAS_IMPRIMIR";
            this.Text = "VENTAS_IMPRIMIR";
            this.Load += new System.EventHandler(this.VENTAS_IMPRIMIR_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DATAGV_Listado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_reporte;
        private System.Windows.Forms.Button button1_volver_menu;
        private System.Windows.Forms.Button button1_buscar_cajero;
        private System.Windows.Forms.TextBox TB_BUSCAR_DEP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView DATAGV_Listado;
        private System.Windows.Forms.Label label_total_dep;
    }
}