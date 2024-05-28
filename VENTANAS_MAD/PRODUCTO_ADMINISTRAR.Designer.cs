namespace VENTANAS_MAD
{
    partial class PRODUCTO_ADMINISTRAR
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
            this.button1 = new System.Windows.Forms.Button();
            this.BtnReporte = new System.Windows.Forms.Button();
            this.button_eliminar = new System.Windows.Forms.Button();
            this.button_activar = new System.Windows.Forms.Button();
            this.CHECKB_DEP = new System.Windows.Forms.CheckBox();
            this.button1_buscar_producto = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label_total_dep = new System.Windows.Forms.Label();
            this.button_desactivar = new System.Windows.Forms.Button();
            this.TAB_PRODUCTOS = new System.Windows.Forms.TabControl();
            this.TAB_DEPARTAMENTO = new System.Windows.Forms.TabPage();
            this.DATAGV_PRODUCTO = new System.Windows.Forms.DataGridView();
            this.Seleccionar_departamento = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.CB_Devolución = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.text_Costo = new System.Windows.Forms.TextBox();
            this.CB_UnidadMedida = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.text_descripcion = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.text_stock = new System.Windows.Forms.TextBox();
            this.tex_precio = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.CB_DEPARTAMENTO = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button_actualizar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_cancelar = new System.Windows.Forms.Button();
            this.button_insertar = new System.Windows.Forms.Button();
            this.text_ID = new System.Windows.Forms.TextBox();
            this.text_Nombre = new System.Windows.Forms.TextBox();
            this.TB_BUSCAR_DEP = new System.Windows.Forms.TextBox();
            this.error_icono = new System.Windows.Forms.ErrorProvider(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TAB_PRODUCTOS.SuspendLayout();
            this.TAB_DEPARTAMENTO.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DATAGV_PRODUCTO)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error_icono)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(913, 6);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 49;
            this.button1.Text = "Volver";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnReporte
            // 
            this.BtnReporte.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReporte.Location = new System.Drawing.Point(449, 7);
            this.BtnReporte.Name = "BtnReporte";
            this.BtnReporte.Size = new System.Drawing.Size(75, 23);
            this.BtnReporte.TabIndex = 48;
            this.BtnReporte.Text = "Reporte";
            this.BtnReporte.UseVisualStyleBackColor = true;
            // 
            // button_eliminar
            // 
            this.button_eliminar.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_eliminar.Location = new System.Drawing.Point(289, 481);
            this.button_eliminar.Name = "button_eliminar";
            this.button_eliminar.Size = new System.Drawing.Size(75, 23);
            this.button_eliminar.TabIndex = 47;
            this.button_eliminar.Text = "Eliminar";
            this.button_eliminar.UseVisualStyleBackColor = true;
            this.button_eliminar.Click += new System.EventHandler(this.button_eliminar_Click);
            // 
            // button_activar
            // 
            this.button_activar.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_activar.Location = new System.Drawing.Point(127, 481);
            this.button_activar.Name = "button_activar";
            this.button_activar.Size = new System.Drawing.Size(75, 23);
            this.button_activar.TabIndex = 45;
            this.button_activar.Text = "Activar";
            this.button_activar.UseVisualStyleBackColor = true;
            this.button_activar.Click += new System.EventHandler(this.button_activar_Click);
            // 
            // CHECKB_DEP
            // 
            this.CHECKB_DEP.AutoSize = true;
            this.CHECKB_DEP.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CHECKB_DEP.Location = new System.Drawing.Point(20, 484);
            this.CHECKB_DEP.Name = "CHECKB_DEP";
            this.CHECKB_DEP.Size = new System.Drawing.Size(78, 18);
            this.CHECKB_DEP.TabIndex = 44;
            this.CHECKB_DEP.Text = "Seleccionar";
            this.CHECKB_DEP.UseVisualStyleBackColor = true;
            this.CHECKB_DEP.CheckedChanged += new System.EventHandler(this.CHECKB_DEP_CheckedChanged);
            // 
            // button1_buscar_producto
            // 
            this.button1_buscar_producto.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1_buscar_producto.Location = new System.Drawing.Point(355, 6);
            this.button1_buscar_producto.Name = "button1_buscar_producto";
            this.button1_buscar_producto.Size = new System.Drawing.Size(88, 23);
            this.button1_buscar_producto.TabIndex = 43;
            this.button1_buscar_producto.Text = "Buscar";
            this.button1_buscar_producto.UseVisualStyleBackColor = true;
            this.button1_buscar_producto.Click += new System.EventHandler(this.button1_buscar_producto_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 15);
            this.label1.TabIndex = 39;
            this.label1.Text = "Buscar :";
            // 
            // label_total_dep
            // 
            this.label_total_dep.AutoSize = true;
            this.label_total_dep.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_total_dep.Location = new System.Drawing.Point(839, 484);
            this.label_total_dep.Name = "label_total_dep";
            this.label_total_dep.Size = new System.Drawing.Size(118, 15);
            this.label_total_dep.TabIndex = 41;
            this.label_total_dep.Text = "Productos actuales : ";
            // 
            // button_desactivar
            // 
            this.button_desactivar.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_desactivar.Location = new System.Drawing.Point(208, 481);
            this.button_desactivar.Name = "button_desactivar";
            this.button_desactivar.Size = new System.Drawing.Size(75, 23);
            this.button_desactivar.TabIndex = 46;
            this.button_desactivar.Text = "Desactivar";
            this.button_desactivar.UseVisualStyleBackColor = true;
            this.button_desactivar.Click += new System.EventHandler(this.button_desactivar_Click);
            // 
            // TAB_PRODUCTOS
            // 
            this.TAB_PRODUCTOS.Controls.Add(this.TAB_DEPARTAMENTO);
            this.TAB_PRODUCTOS.Controls.Add(this.tabPage2);
            this.TAB_PRODUCTOS.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TAB_PRODUCTOS.Location = new System.Drawing.Point(20, 50);
            this.TAB_PRODUCTOS.Name = "TAB_PRODUCTOS";
            this.TAB_PRODUCTOS.SelectedIndex = 0;
            this.TAB_PRODUCTOS.Size = new System.Drawing.Size(972, 428);
            this.TAB_PRODUCTOS.TabIndex = 40;
            // 
            // TAB_DEPARTAMENTO
            // 
            this.TAB_DEPARTAMENTO.Controls.Add(this.DATAGV_PRODUCTO);
            this.TAB_DEPARTAMENTO.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TAB_DEPARTAMENTO.Location = new System.Drawing.Point(4, 23);
            this.TAB_DEPARTAMENTO.Name = "TAB_DEPARTAMENTO";
            this.TAB_DEPARTAMENTO.Padding = new System.Windows.Forms.Padding(3);
            this.TAB_DEPARTAMENTO.Size = new System.Drawing.Size(964, 401);
            this.TAB_DEPARTAMENTO.TabIndex = 0;
            this.TAB_DEPARTAMENTO.Text = "Productos";
            this.TAB_DEPARTAMENTO.UseVisualStyleBackColor = true;
            // 
            // DATAGV_PRODUCTO
            // 
            this.DATAGV_PRODUCTO.AllowUserToAddRows = false;
            this.DATAGV_PRODUCTO.AllowUserToDeleteRows = false;
            this.DATAGV_PRODUCTO.AllowUserToOrderColumns = true;
            this.DATAGV_PRODUCTO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DATAGV_PRODUCTO.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Seleccionar_departamento});
            this.DATAGV_PRODUCTO.Location = new System.Drawing.Point(3, 3);
            this.DATAGV_PRODUCTO.Name = "DATAGV_PRODUCTO";
            this.DATAGV_PRODUCTO.ReadOnly = true;
            this.DATAGV_PRODUCTO.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DATAGV_PRODUCTO.Size = new System.Drawing.Size(955, 392);
            this.DATAGV_PRODUCTO.TabIndex = 0;
            this.DATAGV_PRODUCTO.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DATAGV_PRODUCTO_CellContentClick);
            this.DATAGV_PRODUCTO.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DATAGV_PRODUCTO_CellDoubleClick);
            // 
            // Seleccionar_departamento
            // 
            this.Seleccionar_departamento.HeaderText = "Seleccionar ";
            this.Seleccionar_departamento.Name = "Seleccionar_departamento";
            this.Seleccionar_departamento.ReadOnly = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.CB_Devolución);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.text_Costo);
            this.tabPage2.Controls.Add(this.CB_UnidadMedida);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.text_descripcion);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.text_stock);
            this.tabPage2.Controls.Add(this.tex_precio);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.CB_DEPARTAMENTO);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.button_actualizar);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.button_cancelar);
            this.tabPage2.Controls.Add(this.button_insertar);
            this.tabPage2.Controls.Add(this.text_ID);
            this.tabPage2.Controls.Add(this.text_Nombre);
            this.tabPage2.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 23);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(964, 401);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Modificar";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(368, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 15);
            this.label6.TabIndex = 30;
            this.label6.Text = "Unidad de Medida";
            // 
            // CB_Devolución
            // 
            this.CB_Devolución.FormattingEnabled = true;
            this.CB_Devolución.Items.AddRange(new object[] {
            "Si ",
            "No"});
            this.CB_Devolución.Location = new System.Drawing.Point(114, 272);
            this.CB_Devolución.Name = "CB_Devolución";
            this.CB_Devolución.Size = new System.Drawing.Size(94, 22);
            this.CB_Devolución.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 15);
            this.label5.TabIndex = 28;
            this.label5.Text = "Costo Producto*  : ";
            // 
            // text_Costo
            // 
            this.text_Costo.Location = new System.Drawing.Point(114, 147);
            this.text_Costo.Name = "text_Costo";
            this.text_Costo.Size = new System.Drawing.Size(100, 20);
            this.text_Costo.TabIndex = 27;
            // 
            // CB_UnidadMedida
            // 
            this.CB_UnidadMedida.FormattingEnabled = true;
            this.CB_UnidadMedida.Items.AddRange(new object[] {
            "Kg",
            "g",
            "mg",
            "L",
            "mL",
            "No Aplica",
            "Gramos"});
            this.CB_UnidadMedida.Location = new System.Drawing.Point(385, 61);
            this.CB_UnidadMedida.Name = "CB_UnidadMedida";
            this.CB_UnidadMedida.Size = new System.Drawing.Size(89, 22);
            this.CB_UnidadMedida.TabIndex = 26;
            this.CB_UnidadMedida.Tag = "";
            this.CB_UnidadMedida.SelectedIndexChanged += new System.EventHandler(this.CB_UnidadMedida_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(35, 274);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 15);
            this.label10.TabIndex = 25;
            this.label10.Text = "Devolucion : ";
            // 
            // text_descripcion
            // 
            this.text_descripcion.Location = new System.Drawing.Point(114, 244);
            this.text_descripcion.Name = "text_descripcion";
            this.text_descripcion.Size = new System.Drawing.Size(242, 20);
            this.text_descripcion.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(33, 244);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 15);
            this.label9.TabIndex = 22;
            this.label9.Text = "Descripcion : ";
            // 
            // text_stock
            // 
            this.text_stock.Location = new System.Drawing.Point(114, 209);
            this.text_stock.Name = "text_stock";
            this.text_stock.Size = new System.Drawing.Size(100, 20);
            this.text_stock.TabIndex = 21;
            // 
            // tex_precio
            // 
            this.tex_precio.Location = new System.Drawing.Point(114, 174);
            this.tex_precio.Name = "tex_precio";
            this.tex_precio.Size = new System.Drawing.Size(100, 20);
            this.tex_precio.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(60, 211);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 15);
            this.label8.TabIndex = 19;
            this.label8.Text = "Stock* : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 179);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 15);
            this.label7.TabIndex = 18;
            this.label7.Text = "Precio Producto*  : ";
            // 
            // CB_DEPARTAMENTO
            // 
            this.CB_DEPARTAMENTO.FormattingEnabled = true;
            this.CB_DEPARTAMENTO.Location = new System.Drawing.Point(109, 112);
            this.CB_DEPARTAMENTO.Name = "CB_DEPARTAMENTO";
            this.CB_DEPARTAMENTO.Size = new System.Drawing.Size(200, 22);
            this.CB_DEPARTAMENTO.TabIndex = 8;
            this.CB_DEPARTAMENTO.SelectedIndexChanged += new System.EventHandler(this.CB_DEPARTAMENTO_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Departamento : ";
            // 
            // button_actualizar
            // 
            this.button_actualizar.Location = new System.Drawing.Point(6, 372);
            this.button_actualizar.Name = "button_actualizar";
            this.button_actualizar.Size = new System.Drawing.Size(75, 23);
            this.button_actualizar.TabIndex = 6;
            this.button_actualizar.Text = "Actualizar";
            this.button_actualizar.UseVisualStyleBackColor = true;
            this.button_actualizar.Click += new System.EventHandler(this.button_actualizar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(216, 381);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 14);
            this.label3.TabIndex = 5;
            this.label3.Text = "Campos obligatorios (*) ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre Producto* : ";
            // 
            // button_cancelar
            // 
            this.button_cancelar.Location = new System.Drawing.Point(87, 372);
            this.button_cancelar.Name = "button_cancelar";
            this.button_cancelar.Size = new System.Drawing.Size(75, 23);
            this.button_cancelar.TabIndex = 3;
            this.button_cancelar.Text = "Volver";
            this.button_cancelar.UseVisualStyleBackColor = true;
            // 
            // button_insertar
            // 
            this.button_insertar.Location = new System.Drawing.Point(6, 372);
            this.button_insertar.Name = "button_insertar";
            this.button_insertar.Size = new System.Drawing.Size(75, 23);
            this.button_insertar.TabIndex = 2;
            this.button_insertar.Text = "Insertar";
            this.button_insertar.UseVisualStyleBackColor = true;
            this.button_insertar.Click += new System.EventHandler(this.button_insertar_Click);
            // 
            // text_ID
            // 
            this.text_ID.Location = new System.Drawing.Point(240, 25);
            this.text_ID.Name = "text_ID";
            this.text_ID.ReadOnly = true;
            this.text_ID.Size = new System.Drawing.Size(100, 20);
            this.text_ID.TabIndex = 1;
            // 
            // text_Nombre
            // 
            this.text_Nombre.Location = new System.Drawing.Point(126, 63);
            this.text_Nombre.Name = "text_Nombre";
            this.text_Nombre.Size = new System.Drawing.Size(242, 20);
            this.text_Nombre.TabIndex = 0;
            // 
            // TB_BUSCAR_DEP
            // 
            this.TB_BUSCAR_DEP.Location = new System.Drawing.Point(81, 8);
            this.TB_BUSCAR_DEP.Name = "TB_BUSCAR_DEP";
            this.TB_BUSCAR_DEP.Size = new System.Drawing.Size(268, 20);
            this.TB_BUSCAR_DEP.TabIndex = 42;
            // 
            // error_icono
            // 
            this.error_icono.ContainerControl = this;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // PRODUCTO_ADMINISTRAR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1013, 510);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnReporte);
            this.Controls.Add(this.button_eliminar);
            this.Controls.Add(this.button_activar);
            this.Controls.Add(this.CHECKB_DEP);
            this.Controls.Add(this.button1_buscar_producto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_total_dep);
            this.Controls.Add(this.button_desactivar);
            this.Controls.Add(this.TAB_PRODUCTOS);
            this.Controls.Add(this.TB_BUSCAR_DEP);
            this.Name = "PRODUCTO_ADMINISTRAR";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PRODUCTO_ADMINISTRAR";
            this.Load += new System.EventHandler(this.PRODUCTO_ADMINISTRAR_Load);
            this.TAB_PRODUCTOS.ResumeLayout(false);
            this.TAB_DEPARTAMENTO.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DATAGV_PRODUCTO)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error_icono)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BtnReporte;
        private System.Windows.Forms.Button button_eliminar;
        private System.Windows.Forms.Button button_activar;
        private System.Windows.Forms.CheckBox CHECKB_DEP;
        private System.Windows.Forms.Button button1_buscar_producto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_total_dep;
        private System.Windows.Forms.Button button_desactivar;
        private System.Windows.Forms.TabControl TAB_PRODUCTOS;
        private System.Windows.Forms.TabPage TAB_DEPARTAMENTO;
        private System.Windows.Forms.DataGridView DATAGV_PRODUCTO;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox CB_UnidadMedida;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox text_descripcion;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox text_stock;
        private System.Windows.Forms.TextBox tex_precio;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CB_DEPARTAMENTO;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_actualizar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_cancelar;
        private System.Windows.Forms.Button button_insertar;
        private System.Windows.Forms.TextBox text_ID;
        private System.Windows.Forms.TextBox text_Nombre;
        private System.Windows.Forms.TextBox TB_BUSCAR_DEP;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Seleccionar_departamento;
        private System.Windows.Forms.ErrorProvider error_icono;
        private System.Windows.Forms.ComboBox CB_Devolución;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox text_Costo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}