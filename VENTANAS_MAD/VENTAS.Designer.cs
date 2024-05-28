namespace VENTANAS_MAD
{
    partial class VENTAS
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button1_buscar_cajero = new System.Windows.Forms.Button();
            this.TB_BUSCAR_DEP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.DATAGV_Listado = new System.Windows.Forms.DataGridView();
            this.label_total_dep = new System.Windows.Forms.Label();
            this.error_icono = new System.Windows.Forms.ErrorProvider(this.components);
            this.text_ID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtIdCajero = new System.Windows.Forms.TextBox();
            this.textNombreCajero = new System.Windows.Forms.TextBox();
            this.BtnBuscarCajero = new System.Windows.Forms.Button();
            this.TxtSerieComprobante = new System.Windows.Forms.TextBox();
            this.TxtNumComprobante = new System.Windows.Forms.TextBox();
            this.CboComprobante = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Impuesto = new System.Windows.Forms.Label();
            this.TxtImpuesto = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtCodigo = new System.Windows.Forms.TextBox();
            this.BtnBuscarrProducto = new System.Windows.Forms.Button();
            this.DGVDetalle = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.TxtTotalSubtotal = new System.Windows.Forms.TextBox();
            this.TxtTotalImpuesto = new System.Windows.Forms.TextBox();
            this.TxtTotal = new System.Windows.Forms.TextBox();
            this.button1_volver_menu = new System.Windows.Forms.Button();
            this.button_reporte = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DATAGV_Listado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_icono)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // button1_buscar_cajero
            // 
            this.button1_buscar_cajero.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1_buscar_cajero.Location = new System.Drawing.Point(358, 52);
            this.button1_buscar_cajero.Name = "button1_buscar_cajero";
            this.button1_buscar_cajero.Size = new System.Drawing.Size(88, 23);
            this.button1_buscar_cajero.TabIndex = 37;
            this.button1_buscar_cajero.Text = "Buscar";
            this.button1_buscar_cajero.UseVisualStyleBackColor = true;
            // 
            // TB_BUSCAR_DEP
            // 
            this.TB_BUSCAR_DEP.Location = new System.Drawing.Point(84, 54);
            this.TB_BUSCAR_DEP.Name = "TB_BUSCAR_DEP";
            this.TB_BUSCAR_DEP.Size = new System.Drawing.Size(268, 20);
            this.TB_BUSCAR_DEP.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 15);
            this.label3.TabIndex = 35;
            this.label3.Text = "Buscar :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 15);
            this.label1.TabIndex = 29;
            this.label1.Text = "Buscar :";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(27, 91);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(763, 455);
            this.tabControl1.TabIndex = 30;
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
            this.DATAGV_Listado.Location = new System.Drawing.Point(3, 3);
            this.DATAGV_Listado.Name = "DATAGV_Listado";
            this.DATAGV_Listado.ReadOnly = true;
            this.DATAGV_Listado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DATAGV_Listado.Size = new System.Drawing.Size(748, 422);
            this.DATAGV_Listado.TabIndex = 1;
            // 
            // label_total_dep
            // 
            this.label_total_dep.AutoSize = true;
            this.label_total_dep.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_total_dep.Location = new System.Drawing.Point(539, 567);
            this.label_total_dep.Name = "label_total_dep";
            this.label_total_dep.Size = new System.Drawing.Size(144, 15);
            this.label_total_dep.TabIndex = 31;
            this.label_total_dep.Text = "Departamentos actuales : ";
            // 
            // error_icono
            // 
            this.error_icono.ContainerControl = this;
            // 
            // text_ID
            // 
            this.text_ID.Location = new System.Drawing.Point(538, 19);
            this.text_ID.Name = "text_ID";
            this.text_ID.Size = new System.Drawing.Size(104, 20);
            this.text_ID.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 14);
            this.label2.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 64);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 14);
            this.label4.TabIndex = 3;
            // 
            // TxtIdCajero
            // 
            this.TxtIdCajero.Enabled = false;
            this.TxtIdCajero.Location = new System.Drawing.Point(83, 19);
            this.TxtIdCajero.Margin = new System.Windows.Forms.Padding(2);
            this.TxtIdCajero.Name = "TxtIdCajero";
            this.TxtIdCajero.Size = new System.Drawing.Size(92, 20);
            this.TxtIdCajero.TabIndex = 4;
            // 
            // textNombreCajero
            // 
            this.textNombreCajero.Enabled = false;
            this.textNombreCajero.Location = new System.Drawing.Point(188, 19);
            this.textNombreCajero.Margin = new System.Windows.Forms.Padding(2);
            this.textNombreCajero.Name = "textNombreCajero";
            this.textNombreCajero.Size = new System.Drawing.Size(234, 20);
            this.textNombreCajero.TabIndex = 5;
            // 
            // BtnBuscarCajero
            // 
            this.BtnBuscarCajero.Location = new System.Drawing.Point(424, 18);
            this.BtnBuscarCajero.Margin = new System.Windows.Forms.Padding(2);
            this.BtnBuscarCajero.Name = "BtnBuscarCajero";
            this.BtnBuscarCajero.Size = new System.Drawing.Size(70, 19);
            this.BtnBuscarCajero.TabIndex = 6;
            this.BtnBuscarCajero.Text = "Buscar";
            this.BtnBuscarCajero.UseVisualStyleBackColor = true;
            // 
            // TxtSerieComprobante
            // 
            this.TxtSerieComprobante.Location = new System.Drawing.Point(188, 63);
            this.TxtSerieComprobante.Margin = new System.Windows.Forms.Padding(2);
            this.TxtSerieComprobante.Name = "TxtSerieComprobante";
            this.TxtSerieComprobante.Size = new System.Drawing.Size(112, 20);
            this.TxtSerieComprobante.TabIndex = 7;
            // 
            // TxtNumComprobante
            // 
            this.TxtNumComprobante.Location = new System.Drawing.Point(315, 63);
            this.TxtNumComprobante.Margin = new System.Windows.Forms.Padding(2);
            this.TxtNumComprobante.Name = "TxtNumComprobante";
            this.TxtNumComprobante.Size = new System.Drawing.Size(106, 20);
            this.TxtNumComprobante.TabIndex = 8;
            // 
            // CboComprobante
            // 
            this.CboComprobante.FormattingEnabled = true;
            this.CboComprobante.Items.AddRange(new object[] {
            "FACTURA",
            "BOLETA",
            "TICKET",
            "GUIA"});
            this.CboComprobante.Location = new System.Drawing.Point(83, 62);
            this.CboComprobante.Margin = new System.Windows.Forms.Padding(2);
            this.CboComprobante.Name = "CboComprobante";
            this.CboComprobante.Size = new System.Drawing.Size(92, 21);
            this.CboComprobante.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(188, 44);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 14);
            this.label5.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(315, 44);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 14);
            this.label6.TabIndex = 11;
            // 
            // Impuesto
            // 
            this.Impuesto.AutoSize = true;
            this.Impuesto.Location = new System.Drawing.Point(483, 68);
            this.Impuesto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Impuesto.Name = "Impuesto";
            this.Impuesto.Size = new System.Drawing.Size(50, 14);
            this.Impuesto.TabIndex = 12;
            // 
            // TxtImpuesto
            // 
            this.TxtImpuesto.Location = new System.Drawing.Point(538, 64);
            this.TxtImpuesto.Margin = new System.Windows.Forms.Padding(2);
            this.TxtImpuesto.Name = "TxtImpuesto";
            this.TxtImpuesto.Size = new System.Drawing.Size(76, 20);
            this.TxtImpuesto.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(5, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 15);
            this.label7.TabIndex = 25;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(8, 84);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(128, 15);
            this.label12.TabIndex = 26;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(483, 87);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(128, 15);
            this.label13.TabIndex = 27;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 19);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 14);
            this.label8.TabIndex = 0;
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.Location = new System.Drawing.Point(74, 16);
            this.TxtCodigo.Margin = new System.Windows.Forms.Padding(2);
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.Size = new System.Drawing.Size(347, 20);
            this.TxtCodigo.TabIndex = 1;
            // 
            // BtnBuscarrProducto
            // 
            this.BtnBuscarrProducto.Location = new System.Drawing.Point(424, 16);
            this.BtnBuscarrProducto.Margin = new System.Windows.Forms.Padding(2);
            this.BtnBuscarrProducto.Name = "BtnBuscarrProducto";
            this.BtnBuscarrProducto.Size = new System.Drawing.Size(70, 19);
            this.BtnBuscarrProducto.TabIndex = 2;
            this.BtnBuscarrProducto.Text = "Buscar";
            this.BtnBuscarrProducto.UseVisualStyleBackColor = true;
            // 
            // DGVDetalle
            // 
            this.DGVDetalle.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVDetalle.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVDetalle.DefaultCellStyle = dataGridViewCellStyle2;
            this.DGVDetalle.Location = new System.Drawing.Point(10, 50);
            this.DGVDetalle.Margin = new System.Windows.Forms.Padding(2);
            this.DGVDetalle.Name = "DGVDetalle";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVDetalle.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DGVDetalle.RowTemplate.Height = 24;
            this.DGVDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVDetalle.Size = new System.Drawing.Size(652, 144);
            this.DGVDetalle.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(500, 200);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 14);
            this.label9.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(500, 225);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 14);
            this.label10.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(500, 254);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(30, 14);
            this.label11.TabIndex = 6;
            // 
            // TxtTotalSubtotal
            // 
            this.TxtTotalSubtotal.Enabled = false;
            this.TxtTotalSubtotal.Location = new System.Drawing.Point(586, 197);
            this.TxtTotalSubtotal.Margin = new System.Windows.Forms.Padding(2);
            this.TxtTotalSubtotal.Name = "TxtTotalSubtotal";
            this.TxtTotalSubtotal.Size = new System.Drawing.Size(76, 20);
            this.TxtTotalSubtotal.TabIndex = 7;
            // 
            // TxtTotalImpuesto
            // 
            this.TxtTotalImpuesto.Enabled = false;
            this.TxtTotalImpuesto.Location = new System.Drawing.Point(586, 225);
            this.TxtTotalImpuesto.Margin = new System.Windows.Forms.Padding(2);
            this.TxtTotalImpuesto.Name = "TxtTotalImpuesto";
            this.TxtTotalImpuesto.Size = new System.Drawing.Size(76, 20);
            this.TxtTotalImpuesto.TabIndex = 8;
            // 
            // TxtTotal
            // 
            this.TxtTotal.Enabled = false;
            this.TxtTotal.Location = new System.Drawing.Point(586, 252);
            this.TxtTotal.Margin = new System.Windows.Forms.Padding(2);
            this.TxtTotal.Name = "TxtTotal";
            this.TxtTotal.Size = new System.Drawing.Size(76, 20);
            this.TxtTotal.TabIndex = 9;
            // 
            // button1_volver_menu
            // 
            this.button1_volver_menu.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1_volver_menu.Location = new System.Drawing.Point(674, 47);
            this.button1_volver_menu.Name = "button1_volver_menu";
            this.button1_volver_menu.Size = new System.Drawing.Size(88, 23);
            this.button1_volver_menu.TabIndex = 38;
            this.button1_volver_menu.Text = "Volver";
            this.button1_volver_menu.UseVisualStyleBackColor = true;
            this.button1_volver_menu.Click += new System.EventHandler(this.button1_volver_menu_Click);
            // 
            // button_reporte
            // 
            this.button_reporte.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_reporte.Location = new System.Drawing.Point(34, 563);
            this.button_reporte.Name = "button_reporte";
            this.button_reporte.Size = new System.Drawing.Size(150, 23);
            this.button_reporte.TabIndex = 39;
            this.button_reporte.Text = "Reporte";
            this.button_reporte.UseVisualStyleBackColor = true;
            this.button_reporte.Click += new System.EventHandler(this.button_reporte_Click);
            // 
            // VENTAS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 606);
            this.Controls.Add(this.button_reporte);
            this.Controls.Add(this.button1_volver_menu);
            this.Controls.Add(this.button1_buscar_cajero);
            this.Controls.Add(this.TB_BUSCAR_DEP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label_total_dep);
            this.Name = "VENTAS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VENTAS";
            this.Load += new System.EventHandler(this.VENTAS_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DATAGV_Listado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_icono)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDetalle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1_buscar_cajero;
        private System.Windows.Forms.TextBox TB_BUSCAR_DEP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Label label_total_dep;
        private System.Windows.Forms.ErrorProvider error_icono;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView DATAGV_Listado;
        private System.Windows.Forms.TextBox text_ID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtIdCajero;
        private System.Windows.Forms.TextBox textNombreCajero;
        private System.Windows.Forms.Button BtnBuscarCajero;
        private System.Windows.Forms.TextBox TxtSerieComprobante;
        private System.Windows.Forms.TextBox TxtNumComprobante;
        private System.Windows.Forms.ComboBox CboComprobante;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Impuesto;
        private System.Windows.Forms.TextBox TxtImpuesto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtCodigo;
        private System.Windows.Forms.Button BtnBuscarrProducto;
        private System.Windows.Forms.DataGridView DGVDetalle;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TxtTotalSubtotal;
        private System.Windows.Forms.TextBox TxtTotalImpuesto;
        private System.Windows.Forms.TextBox TxtTotal;
        private System.Windows.Forms.Button button1_volver_menu;
        private System.Windows.Forms.Button button_reporte;
    }
}