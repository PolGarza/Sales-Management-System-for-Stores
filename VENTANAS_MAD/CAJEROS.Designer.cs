namespace VENTANAS_MAD
{
    partial class CAJEROS
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
            this.DATAGV_Listado = new System.Windows.Forms.DataGridView();
            this.button_reporte = new System.Windows.Forms.Button();
            this.button1_volver_menu = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.DATAGV_Listado)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DATAGV_Listado
            // 
            this.DATAGV_Listado.AllowUserToAddRows = false;
            this.DATAGV_Listado.AllowUserToDeleteRows = false;
            this.DATAGV_Listado.AllowUserToOrderColumns = true;
            this.DATAGV_Listado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DATAGV_Listado.Location = new System.Drawing.Point(0, 2);
            this.DATAGV_Listado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DATAGV_Listado.Name = "DATAGV_Listado";
            this.DATAGV_Listado.ReadOnly = true;
            this.DATAGV_Listado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DATAGV_Listado.Size = new System.Drawing.Size(1003, 539);
            this.DATAGV_Listado.TabIndex = 1;
            // 
            // button_reporte
            // 
            this.button_reporte.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_reporte.Location = new System.Drawing.Point(805, 686);
            this.button_reporte.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_reporte.Name = "button_reporte";
            this.button_reporte.Size = new System.Drawing.Size(200, 28);
            this.button_reporte.TabIndex = 42;
            this.button_reporte.Text = "Reporte";
            this.button_reporte.UseVisualStyleBackColor = true;
            this.button_reporte.Click += new System.EventHandler(this.button_reporte_Click);
            // 
            // button1_volver_menu
            // 
            this.button1_volver_menu.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1_volver_menu.Location = new System.Drawing.Point(888, 42);
            this.button1_volver_menu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1_volver_menu.Name = "button1_volver_menu";
            this.button1_volver_menu.Size = new System.Drawing.Size(117, 28);
            this.button1_volver_menu.TabIndex = 41;
            this.button1_volver_menu.Text = "Volver";
            this.button1_volver_menu.UseVisualStyleBackColor = true;
            this.button1_volver_menu.Click += new System.EventHandler(this.button1_volver_menu_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(25, 78);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1017, 578);
            this.tabControl1.TabIndex = 40;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.DATAGV_Listado);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1009, 549);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Cajeros";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // CAJEROS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1067, 746);
            this.Controls.Add(this.button_reporte);
            this.Controls.Add(this.button1_volver_menu);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CAJEROS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CAJEROS";
            this.Load += new System.EventHandler(this.CAJEROS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DATAGV_Listado)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DATAGV_Listado;
        private System.Windows.Forms.Button button_reporte;
        private System.Windows.Forms.Button button1_volver_menu;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
    }
}