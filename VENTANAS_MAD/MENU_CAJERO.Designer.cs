namespace VENTANAS_MAD
{
    partial class MENU_CAJERO
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CB_CAJAS = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BUTTOM_BUSCAR_C = new System.Windows.Forms.Button();
            this.TX_NOMBRE_C = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TX_NUM_C = new System.Windows.Forms.TextBox();
            this.TxtSerieComprobante = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtTotal = new System.Windows.Forms.TextBox();
            this.TxtTotalDescuento = new System.Windows.Forms.TextBox();
            this.TxtTotalSubtotal = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DGVDetalle = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.DVG_PRODUCTO = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.BtnBuscarrProducto = new System.Windows.Forms.Button();
            this.TxtCodigo = new System.Windows.Forms.TextBox();
            this.button_insertar = new System.Windows.Forms.Button();
            this.buttonanular = new System.Windows.Forms.Button();
            this.label_total_dep = new System.Windows.Forms.Label();
            this.error_icono = new System.Windows.Forms.ErrorProvider(this.components);
            this.CHECKB_DEP = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaRápidaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vebtasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaVentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Seleccionar_departamento = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Productos = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DVG_PRODUCTO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_icono)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Productos)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.CB_CAJAS);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.BUTTOM_BUSCAR_C);
            this.groupBox1.Controls.Add(this.TX_NOMBRE_C);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.TX_NUM_C);
            this.groupBox1.Controls.Add(this.TxtSerieComprobante);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(5, 6);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(673, 118);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "VENTA DE PRODUCTOS ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(567, 18);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 20);
            this.label3.TabIndex = 45;
            this.label3.Text = "Caja ";
            // 
            // CB_CAJAS
            // 
            this.CB_CAJAS.FormattingEnabled = true;
            this.CB_CAJAS.Items.AddRange(new object[] {
            "Caja 1 ",
            "Caja 2",
            "Caja 3",
            "Caja 4",
            "Caja 5",
            "Caja 6",
            "Caja 7",
            "Caja 8",
            "Caja 9",
            "Caja 10"});
            this.CB_CAJAS.Location = new System.Drawing.Point(521, 39);
            this.CB_CAJAS.Name = "CB_CAJAS";
            this.CB_CAJAS.Size = new System.Drawing.Size(136, 24);
            this.CB_CAJAS.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 95);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 16);
            this.label1.TabIndex = 28;
            this.label1.Text = "Favor de poner el mismo codigo para el mismo cliente";
            // 
            // BUTTOM_BUSCAR_C
            // 
            this.BUTTOM_BUSCAR_C.Location = new System.Drawing.Point(424, 18);
            this.BUTTOM_BUSCAR_C.Margin = new System.Windows.Forms.Padding(2);
            this.BUTTOM_BUSCAR_C.Name = "BUTTOM_BUSCAR_C";
            this.BUTTOM_BUSCAR_C.Size = new System.Drawing.Size(70, 20);
            this.BUTTOM_BUSCAR_C.TabIndex = 10;
            this.BUTTOM_BUSCAR_C.Text = "Buscar";
            this.BUTTOM_BUSCAR_C.UseVisualStyleBackColor = true;
            this.BUTTOM_BUSCAR_C.Click += new System.EventHandler(this.BUTTOM_BUSCAR_C_Click);
            // 
            // TX_NOMBRE_C
            // 
            this.TX_NOMBRE_C.Location = new System.Drawing.Point(191, 18);
            this.TX_NOMBRE_C.Margin = new System.Windows.Forms.Padding(2);
            this.TX_NOMBRE_C.Name = "TX_NOMBRE_C";
            this.TX_NOMBRE_C.Size = new System.Drawing.Size(225, 23);
            this.TX_NOMBRE_C.TabIndex = 10;
            this.TX_NOMBRE_C.TextChanged += new System.EventHandler(this.TX_NOMBRE_C_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(188, 47);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Codigo Producto";
            // 
            // TX_NUM_C
            // 
            this.TX_NUM_C.Location = new System.Drawing.Point(69, 18);
            this.TX_NUM_C.Margin = new System.Windows.Forms.Padding(2);
            this.TX_NUM_C.Name = "TX_NUM_C";
            this.TX_NUM_C.Size = new System.Drawing.Size(106, 23);
            this.TX_NUM_C.TabIndex = 8;
            this.TX_NUM_C.TextChanged += new System.EventHandler(this.TX_NUM_C_TextChanged);
            // 
            // TxtSerieComprobante
            // 
            this.TxtSerieComprobante.Location = new System.Drawing.Point(168, 68);
            this.TxtSerieComprobante.Margin = new System.Windows.Forms.Padding(2);
            this.TxtSerieComprobante.Name = "TxtSerieComprobante";
            this.TxtSerieComprobante.Size = new System.Drawing.Size(145, 23);
            this.TxtSerieComprobante.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 21);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cajero:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(442, 44);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(164, 17);
            this.label12.TabIndex = 26;
            this.label12.Text = "Campos obligatorios (*) ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(588, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(164, 17);
            this.label7.TabIndex = 25;
            this.label7.Text = "Campos obligatorios (*) ";
            // 
            // TxtTotal
            // 
            this.TxtTotal.Enabled = false;
            this.TxtTotal.Location = new System.Drawing.Point(107, 503);
            this.TxtTotal.Margin = new System.Windows.Forms.Padding(2);
            this.TxtTotal.Name = "TxtTotal";
            this.TxtTotal.Size = new System.Drawing.Size(76, 23);
            this.TxtTotal.TabIndex = 9;
            // 
            // TxtTotalDescuento
            // 
            this.TxtTotalDescuento.Enabled = false;
            this.TxtTotalDescuento.Location = new System.Drawing.Point(491, 504);
            this.TxtTotalDescuento.Margin = new System.Windows.Forms.Padding(2);
            this.TxtTotalDescuento.Name = "TxtTotalDescuento";
            this.TxtTotalDescuento.Size = new System.Drawing.Size(104, 23);
            this.TxtTotalDescuento.TabIndex = 8;
            // 
            // TxtTotalSubtotal
            // 
            this.TxtTotalSubtotal.Enabled = false;
            this.TxtTotalSubtotal.Location = new System.Drawing.Point(242, 504);
            this.TxtTotalSubtotal.Margin = new System.Windows.Forms.Padding(2);
            this.TxtTotalSubtotal.Name = "TxtTotalSubtotal";
            this.TxtTotalSubtotal.Size = new System.Drawing.Size(118, 23);
            this.TxtTotalSubtotal.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(71, 507);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 16);
            this.label11.TabIndex = 6;
            this.label11.Text = "Total";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(384, 507);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(126, 16);
            this.label10.TabIndex = 5;
            this.label10.Text = "Total Con Descuento";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(187, 507);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 16);
            this.label9.TabIndex = 4;
            this.label9.Text = "Sub Total";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 44);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 556);
            this.tabControl1.TabIndex = 39;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.TxtTotal);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.TxtTotalDescuento);
            this.tabPage2.Controls.Add(this.TxtTotalSubtotal);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 527);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Vender ";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.DGVDetalle);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.DVG_PRODUCTO);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.BtnBuscarrProducto);
            this.groupBox2.Controls.Add(this.TxtCodigo);
            this.groupBox2.Location = new System.Drawing.Point(5, 130);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(758, 373);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detalle";
            // 
            // DGVDetalle
            // 
            this.DGVDetalle.AllowUserToAddRows = false;
            this.DGVDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVDetalle.Location = new System.Drawing.Point(10, 206);
            this.DGVDetalle.Name = "DGVDetalle";
            this.DGVDetalle.RowTemplate.Height = 24;
            this.DGVDetalle.Size = new System.Drawing.Size(730, 150);
            this.DGVDetalle.TabIndex = 47;
            this.DGVDetalle.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVDetalle_CellContentClick_1);
            this.DGVDetalle.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVDetalle_CellDoubleClick_1);
            this.DGVDetalle.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVDetalle_CellEndEdit_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(447, 177);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(70, 20);
            this.button3.TabIndex = 46;
            this.button3.Text = "Buscar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(96, 7);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(347, 23);
            this.textBox2.TabIndex = 45;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // DVG_PRODUCTO
            // 
            this.DVG_PRODUCTO.AllowUserToAddRows = false;
            this.DVG_PRODUCTO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DVG_PRODUCTO.Location = new System.Drawing.Point(10, 31);
            this.DVG_PRODUCTO.Margin = new System.Windows.Forms.Padding(2);
            this.DVG_PRODUCTO.Name = "DVG_PRODUCTO";
            this.DVG_PRODUCTO.RowTemplate.Height = 24;
            this.DVG_PRODUCTO.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DVG_PRODUCTO.Size = new System.Drawing.Size(730, 142);
            this.DVG_PRODUCTO.TabIndex = 44;
            this.DVG_PRODUCTO.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DVG_PRODUCTO_CellContentClick);
            this.DVG_PRODUCTO.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DVG_PRODUCTO_CellDoubleClick);
            this.DVG_PRODUCTO.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DVG_PRODUCTO_CellEndEdit);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(42, 10);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Producto";
            // 
            // BtnBuscarrProducto
            // 
            this.BtnBuscarrProducto.Location = new System.Drawing.Point(447, 7);
            this.BtnBuscarrProducto.Margin = new System.Windows.Forms.Padding(2);
            this.BtnBuscarrProducto.Name = "BtnBuscarrProducto";
            this.BtnBuscarrProducto.Size = new System.Drawing.Size(70, 20);
            this.BtnBuscarrProducto.TabIndex = 2;
            this.BtnBuscarrProducto.Text = "Buscar";
            this.BtnBuscarrProducto.UseVisualStyleBackColor = true;
            this.BtnBuscarrProducto.Click += new System.EventHandler(this.BtnBuscarrProducto_Click);
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.Location = new System.Drawing.Point(96, 177);
            this.TxtCodigo.Margin = new System.Windows.Forms.Padding(2);
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.Size = new System.Drawing.Size(347, 23);
            this.TxtCodigo.TabIndex = 1;
            this.TxtCodigo.TextChanged += new System.EventHandler(this.TxtCodigo_TextChanged);
            this.TxtCodigo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtCodigo_KeyDown);
            // 
            // button_insertar
            // 
            this.button_insertar.Location = new System.Drawing.Point(258, 618);
            this.button_insertar.Name = "button_insertar";
            this.button_insertar.Size = new System.Drawing.Size(182, 25);
            this.button_insertar.TabIndex = 2;
            this.button_insertar.Text = "Realizar Venta";
            this.button_insertar.UseVisualStyleBackColor = true;
            this.button_insertar.Click += new System.EventHandler(this.button_insertar_Click);
            // 
            // buttonanular
            // 
            this.buttonanular.Location = new System.Drawing.Point(110, 618);
            this.buttonanular.Name = "buttonanular";
            this.buttonanular.Size = new System.Drawing.Size(137, 25);
            this.buttonanular.TabIndex = 42;
            this.buttonanular.Text = "Cancelar compra";
            this.buttonanular.UseVisualStyleBackColor = true;
            this.buttonanular.Click += new System.EventHandler(this.buttonanular_Click);
            // 
            // label_total_dep
            // 
            this.label_total_dep.AutoSize = true;
            this.label_total_dep.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_total_dep.Location = new System.Drawing.Point(576, 628);
            this.label_total_dep.Name = "label_total_dep";
            this.label_total_dep.Size = new System.Drawing.Size(151, 19);
            this.label_total_dep.TabIndex = 40;
            this.label_total_dep.Text = "Productos actuales : ";
            // 
            // error_icono
            // 
            this.error_icono.ContainerControl = this;
            // 
            // CHECKB_DEP
            // 
            this.CHECKB_DEP.AutoSize = true;
            this.CHECKB_DEP.Location = new System.Drawing.Point(26, 621);
            this.CHECKB_DEP.Name = "CHECKB_DEP";
            this.CHECKB_DEP.Size = new System.Drawing.Size(95, 20);
            this.CHECKB_DEP.TabIndex = 41;
            this.CHECKB_DEP.Text = "Seleccionar";
            this.CHECKB_DEP.UseVisualStyleBackColor = true;
            this.CHECKB_DEP.CheckedChanged += new System.EventHandler(this.CHECKB_DEP_CheckedChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.menuStrip1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productosToolStripMenuItem,
            this.vebtasToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1203, 27);
            this.menuStrip1.TabIndex = 43;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultaRápidaToolStripMenuItem});
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(101, 23);
            this.productosToolStripMenuItem.Text = "Productos ";
            // 
            // consultaRápidaToolStripMenuItem
            // 
            this.consultaRápidaToolStripMenuItem.Name = "consultaRápidaToolStripMenuItem";
            this.consultaRápidaToolStripMenuItem.Size = new System.Drawing.Size(206, 26);
            this.consultaRápidaToolStripMenuItem.Text = "Consulta rápida ";
            // 
            // vebtasToolStripMenuItem
            // 
            this.vebtasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultaVentasToolStripMenuItem});
            this.vebtasToolStripMenuItem.Name = "vebtasToolStripMenuItem";
            this.vebtasToolStripMenuItem.Size = new System.Drawing.Size(68, 23);
            this.vebtasToolStripMenuItem.Text = "Ventas";
            // 
            // consultaVentasToolStripMenuItem
            // 
            this.consultaVentasToolStripMenuItem.Name = "consultaVentasToolStripMenuItem";
            this.consultaVentasToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.consultaVentasToolStripMenuItem.Text = "Consulta Ventas";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(62, 23);
            this.salirToolStripMenuItem.Text = "Salir ";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // Seleccionar_departamento
            // 
            this.Seleccionar_departamento.HeaderText = "Seleccionar Departamento";
            this.Seleccionar_departamento.Name = "Seleccionar_departamento";
            this.Seleccionar_departamento.ReadOnly = true;
            // 
            // Productos
            // 
            this.Productos.AllowUserToAddRows = false;
            this.Productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Productos.Location = new System.Drawing.Point(793, 73);
            this.Productos.Margin = new System.Windows.Forms.Padding(2);
            this.Productos.Name = "Productos";
            this.Productos.RowTemplate.Height = 24;
            this.Productos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Productos.Size = new System.Drawing.Size(399, 527);
            this.Productos.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1133, 44);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 20);
            this.button1.TabIndex = 10;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(793, 44);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(336, 23);
            this.textBox1.TabIndex = 10;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1128, 610);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 25);
            this.button2.TabIndex = 8;
            this.button2.Text = "Insertar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 181);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 16);
            this.label4.TabIndex = 48;
            this.label4.Text = "Producto";
            // 
            // MENU_CAJERO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1203, 653);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Productos);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button_insertar);
            this.Controls.Add(this.buttonanular);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label_total_dep);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CHECKB_DEP);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MENU_CAJERO";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MENU_CAJERO";
            this.Load += new System.EventHandler(this.MENU_CAJERO_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DVG_PRODUCTO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_icono)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Productos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TX_NUM_C;
        private System.Windows.Forms.TextBox TxtSerieComprobante;
        private System.Windows.Forms.TextBox TxtTotal;
        private System.Windows.Forms.TextBox TxtTotalDescuento;
        private System.Windows.Forms.TextBox TxtTotalSubtotal;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnBuscarrProducto;
        private System.Windows.Forms.TextBox TxtCodigo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button_insertar;
        private System.Windows.Forms.Button buttonanular;
        private System.Windows.Forms.Label label_total_dep;
        private System.Windows.Forms.ErrorProvider error_icono;
        private System.Windows.Forms.CheckBox CHECKB_DEP;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaRápidaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vebtasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaVentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Seleccionar_departamento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BUTTOM_BUSCAR_C;
        private System.Windows.Forms.TextBox TX_NOMBRE_C;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CB_CAJAS;
        private System.Windows.Forms.DataGridView Productos;
        private System.Windows.Forms.DataGridView DVG_PRODUCTO;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DataGridView DGVDetalle;
        private System.Windows.Forms.Label label4;
    }
}