namespace VENTANAS_MAD
{
    partial class CONSULTA_VENTAS
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
            this.button1_volver_menu = new System.Windows.Forms.Button();
            this.button1_buscar_cajero = new System.Windows.Forms.Button();
            this.TB_BUSCAR_DEP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.DATAGV_Listado = new System.Windows.Forms.DataGridView();
            this.Seleccionar_departamento = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.buttonanular = new System.Windows.Forms.Button();
            this.label_total_dep = new System.Windows.Forms.Label();
            this.CHECKB_DEP = new System.Windows.Forms.CheckBox();
            this.error_icono = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DATAGV_Listado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_icono)).BeginInit();
            this.SuspendLayout();
            // 
            // button1_volver_menu
            // 
            this.button1_volver_menu.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1_volver_menu.Location = new System.Drawing.Point(667, 42);
            this.button1_volver_menu.Name = "button1_volver_menu";
            this.button1_volver_menu.Size = new System.Drawing.Size(88, 23);
            this.button1_volver_menu.TabIndex = 47;
            this.button1_volver_menu.Text = "Volver";
            this.button1_volver_menu.UseVisualStyleBackColor = true;
            this.button1_volver_menu.Click += new System.EventHandler(this.button1_volver_menu_Click);
            // 
            // button1_buscar_cajero
            // 
            this.button1_buscar_cajero.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1_buscar_cajero.Location = new System.Drawing.Point(351, 47);
            this.button1_buscar_cajero.Name = "button1_buscar_cajero";
            this.button1_buscar_cajero.Size = new System.Drawing.Size(88, 23);
            this.button1_buscar_cajero.TabIndex = 46;
            this.button1_buscar_cajero.Text = "Buscar";
            this.button1_buscar_cajero.UseVisualStyleBackColor = true;
            this.button1_buscar_cajero.Click += new System.EventHandler(this.button1_buscar_cajero_Click);
            // 
            // TB_BUSCAR_DEP
            // 
            this.TB_BUSCAR_DEP.Location = new System.Drawing.Point(77, 49);
            this.TB_BUSCAR_DEP.Name = "TB_BUSCAR_DEP";
            this.TB_BUSCAR_DEP.Size = new System.Drawing.Size(268, 20);
            this.TB_BUSCAR_DEP.TabIndex = 45;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 15);
            this.label3.TabIndex = 44;
            this.label3.Text = "Buscar :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 15);
            this.label1.TabIndex = 39;
            this.label1.Text = "Buscar :";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(20, 86);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(763, 455);
            this.tabControl1.TabIndex = 40;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.DATAGV_Listado);
            this.tabPage1.Location = new System.Drawing.Point(4, 23);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(755, 428);
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
            this.DATAGV_Listado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Seleccionar_departamento});
            this.DATAGV_Listado.Location = new System.Drawing.Point(3, 3);
            this.DATAGV_Listado.Name = "DATAGV_Listado";
            this.DATAGV_Listado.ReadOnly = true;
            this.DATAGV_Listado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DATAGV_Listado.Size = new System.Drawing.Size(748, 422);
            this.DATAGV_Listado.TabIndex = 1;
            // 
            // Seleccionar_departamento
            // 
            this.Seleccionar_departamento.HeaderText = "Seleccionar Departamento";
            this.Seleccionar_departamento.Name = "Seleccionar_departamento";
            this.Seleccionar_departamento.ReadOnly = true;
            // 
            // buttonanular
            // 
            this.buttonanular.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonanular.Location = new System.Drawing.Point(345, 560);
            this.buttonanular.Name = "buttonanular";
            this.buttonanular.Size = new System.Drawing.Size(75, 23);
            this.buttonanular.TabIndex = 43;
            this.buttonanular.Text = "Anular";
            this.buttonanular.UseVisualStyleBackColor = true;
            // 
            // label_total_dep
            // 
            this.label_total_dep.AutoSize = true;
            this.label_total_dep.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_total_dep.Location = new System.Drawing.Point(532, 562);
            this.label_total_dep.Name = "label_total_dep";
            this.label_total_dep.Size = new System.Drawing.Size(99, 15);
            this.label_total_dep.TabIndex = 41;
            this.label_total_dep.Text = "Ventas actuales : ";
            // 
            // CHECKB_DEP
            // 
            this.CHECKB_DEP.AutoSize = true;
            this.CHECKB_DEP.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CHECKB_DEP.Location = new System.Drawing.Point(19, 563);
            this.CHECKB_DEP.Name = "CHECKB_DEP";
            this.CHECKB_DEP.Size = new System.Drawing.Size(78, 18);
            this.CHECKB_DEP.TabIndex = 42;
            this.CHECKB_DEP.Text = "Seleccionar";
            this.CHECKB_DEP.UseVisualStyleBackColor = true;
            // 
            // error_icono
            // 
            this.error_icono.ContainerControl = this;
            // 
            // CONSULTA_VENTAS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 606);
            this.Controls.Add(this.button1_volver_menu);
            this.Controls.Add(this.button1_buscar_cajero);
            this.Controls.Add(this.TB_BUSCAR_DEP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.buttonanular);
            this.Controls.Add(this.label_total_dep);
            this.Controls.Add(this.CHECKB_DEP);
            this.Name = "CONSULTA_VENTAS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CONSULTA_VENTAS";
            this.Load += new System.EventHandler(this.CONSULTA_VENTAS_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DATAGV_Listado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_icono)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1_volver_menu;
        private System.Windows.Forms.Button button1_buscar_cajero;
        private System.Windows.Forms.TextBox TB_BUSCAR_DEP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView DATAGV_Listado;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Seleccionar_departamento;
        private System.Windows.Forms.Button buttonanular;
        private System.Windows.Forms.Label label_total_dep;
        private System.Windows.Forms.CheckBox CHECKB_DEP;
        private System.Windows.Forms.ErrorProvider error_icono;
    }
}