namespace VENTANAS_MAD
{
    partial class CAJERO
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
            this.error_icono = new System.Windows.Forms.ErrorProvider(this.components);
            this.dateTime_FechaN = new System.Windows.Forms.DateTimePicker();
            this.dateTime_FechaI = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.text_Email = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.text_Clave = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.text_CURP = new System.Windows.Forms.TextBox();
            this.button_actualizar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button_cancelar = new System.Windows.Forms.Button();
            this.button_insertar = new System.Windows.Forms.Button();
            this.text_ID = new System.Windows.Forms.TextBox();
            this.text_Nombre = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TAB_DEPARTAMENTO = new System.Windows.Forms.TabPage();
            this.DATAGV_CAJERO = new System.Windows.Forms.DataGridView();
            this.Seleccionar_departamento = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button_eliminar = new System.Windows.Forms.Button();
            this.button_desactivar = new System.Windows.Forms.Button();
            this.button_activar = new System.Windows.Forms.Button();
            this.button1_buscar_administrador = new System.Windows.Forms.Button();
            this.TB_BUSCAR_CAJERO = new System.Windows.Forms.TextBox();
            this.label_total_dep = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CHECKB_DEP = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dateTimeFin = new System.Windows.Forms.DateTimePicker();
            this.dateTimeInicio = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.error_icono)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.TAB_DEPARTAMENTO.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DATAGV_CAJERO)).BeginInit();
            this.SuspendLayout();
            // 
            // error_icono
            // 
            this.error_icono.ContainerControl = this;
            // 
            // dateTime_FechaN
            // 
            this.dateTime_FechaN.Location = new System.Drawing.Point(44, 199);
            this.dateTime_FechaN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTime_FechaN.Name = "dateTime_FechaN";
            this.dateTime_FechaN.Size = new System.Drawing.Size(295, 23);
            this.dateTime_FechaN.TabIndex = 17;
            // 
            // dateTime_FechaI
            // 
            this.dateTime_FechaI.Location = new System.Drawing.Point(44, 263);
            this.dateTime_FechaI.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTime_FechaI.Name = "dateTime_FechaI";
            this.dateTime_FechaI.Size = new System.Drawing.Size(295, 23);
            this.dateTime_FechaI.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(41, 236);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Fecha de ingreso : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 180);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Fecha de nacimiento : ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label10.Location = new System.Drawing.Point(17, 162);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(320, 34);
            this.label10.TabIndex = 28;
            this.label10.Text = "Para insetar un usuario la clave es obligatori.a\r\nPara actualizar solo deje el ca" +
    "mpo Clave en blanco.\r\n";
            // 
            // text_Email
            // 
            this.text_Email.Location = new System.Drawing.Point(20, 50);
            this.text_Email.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.text_Email.Name = "text_Email";
            this.text_Email.Size = new System.Drawing.Size(297, 23);
            this.text_Email.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(17, 18);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 17);
            this.label9.TabIndex = 18;
            this.label9.Text = "Email* : ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.text_Email);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.text_Clave);
            this.groupBox1.Location = new System.Drawing.Point(547, 46);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(364, 220);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(17, 94);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Clave * : ";
            // 
            // text_Clave
            // 
            this.text_Clave.Location = new System.Drawing.Point(21, 123);
            this.text_Clave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.text_Clave.Name = "text_Clave";
            this.text_Clave.Size = new System.Drawing.Size(297, 23);
            this.text_Clave.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(37, 25);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 17);
            this.label8.TabIndex = 13;
            this.label8.Text = "ID:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(41, 309);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(164, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Campos obligatorios (*) ";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.dateTime_FechaN);
            this.tabPage2.Controls.Add(this.dateTime_FechaI);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.text_CURP);
            this.tabPage2.Controls.Add(this.button_actualizar);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.button_cancelar);
            this.tabPage2.Controls.Add(this.button_insertar);
            this.tabPage2.Controls.Add(this.text_ID);
            this.tabPage2.Controls.Add(this.text_Nombre);
            this.tabPage2.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Size = new System.Drawing.Size(1011, 349);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Modificar";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(41, 127);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "CURP* : ";
            // 
            // text_CURP
            // 
            this.text_CURP.Location = new System.Drawing.Point(44, 146);
            this.text_CURP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.text_CURP.Name = "text_CURP";
            this.text_CURP.Size = new System.Drawing.Size(297, 23);
            this.text_CURP.TabIndex = 7;
            // 
            // button_actualizar
            // 
            this.button_actualizar.Location = new System.Drawing.Point(411, 298);
            this.button_actualizar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_actualizar.Name = "button_actualizar";
            this.button_actualizar.Size = new System.Drawing.Size(100, 28);
            this.button_actualizar.TabIndex = 6;
            this.button_actualizar.Text = "Actualizar";
            this.button_actualizar.UseVisualStyleBackColor = true;
            this.button_actualizar.Click += new System.EventHandler(this.button_actualizar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 71);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre * : ";
            // 
            // button_cancelar
            // 
            this.button_cancelar.Location = new System.Drawing.Point(517, 298);
            this.button_cancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_cancelar.Name = "button_cancelar";
            this.button_cancelar.Size = new System.Drawing.Size(100, 28);
            this.button_cancelar.TabIndex = 3;
            this.button_cancelar.Text = "Volver";
            this.button_cancelar.UseVisualStyleBackColor = true;
            this.button_cancelar.Click += new System.EventHandler(this.button_cancelar_Click);
            // 
            // button_insertar
            // 
            this.button_insertar.Location = new System.Drawing.Point(411, 298);
            this.button_insertar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_insertar.Name = "button_insertar";
            this.button_insertar.Size = new System.Drawing.Size(100, 28);
            this.button_insertar.TabIndex = 2;
            this.button_insertar.Text = "Insertar";
            this.button_insertar.UseVisualStyleBackColor = true;
            this.button_insertar.Click += new System.EventHandler(this.button_insertar_Click);
            // 
            // text_ID
            // 
            this.text_ID.Location = new System.Drawing.Point(41, 46);
            this.text_ID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.text_ID.Name = "text_ID";
            this.text_ID.Size = new System.Drawing.Size(297, 23);
            this.text_ID.TabIndex = 1;
            this.text_ID.Visible = false;
            // 
            // text_Nombre
            // 
            this.text_Nombre.Location = new System.Drawing.Point(44, 94);
            this.text_Nombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.text_Nombre.Name = "text_Nombre";
            this.text_Nombre.Size = new System.Drawing.Size(297, 23);
            this.text_Nombre.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.TAB_DEPARTAMENTO);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(33, 74);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1019, 378);
            this.tabControl1.TabIndex = 69;
            // 
            // TAB_DEPARTAMENTO
            // 
            this.TAB_DEPARTAMENTO.Controls.Add(this.DATAGV_CAJERO);
            this.TAB_DEPARTAMENTO.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TAB_DEPARTAMENTO.Location = new System.Drawing.Point(4, 25);
            this.TAB_DEPARTAMENTO.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TAB_DEPARTAMENTO.Name = "TAB_DEPARTAMENTO";
            this.TAB_DEPARTAMENTO.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TAB_DEPARTAMENTO.Size = new System.Drawing.Size(1011, 349);
            this.TAB_DEPARTAMENTO.TabIndex = 0;
            this.TAB_DEPARTAMENTO.Text = "Cajeros";
            this.TAB_DEPARTAMENTO.UseVisualStyleBackColor = true;
            // 
            // DATAGV_CAJERO
            // 
            this.DATAGV_CAJERO.AllowUserToAddRows = false;
            this.DATAGV_CAJERO.AllowUserToDeleteRows = false;
            this.DATAGV_CAJERO.AllowUserToOrderColumns = true;
            this.DATAGV_CAJERO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DATAGV_CAJERO.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Seleccionar_departamento});
            this.DATAGV_CAJERO.Location = new System.Drawing.Point(4, 4);
            this.DATAGV_CAJERO.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DATAGV_CAJERO.Name = "DATAGV_CAJERO";
            this.DATAGV_CAJERO.ReadOnly = true;
            this.DATAGV_CAJERO.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DATAGV_CAJERO.Size = new System.Drawing.Size(1005, 395);
            this.DATAGV_CAJERO.TabIndex = 0;
            this.DATAGV_CAJERO.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DATAGV_CAJERO_CellContentClick);
            this.DATAGV_CAJERO.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DATAGV_CAJERO_CellDoubleClick);
            // 
            // Seleccionar_departamento
            // 
            this.Seleccionar_departamento.HeaderText = "Seleccionar Departamento";
            this.Seleccionar_departamento.Name = "Seleccionar_departamento";
            this.Seleccionar_departamento.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(924, 50);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 77;
            this.button1.Text = "Volver";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_eliminar
            // 
            this.button_eliminar.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_eliminar.Location = new System.Drawing.Point(755, 473);
            this.button_eliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_eliminar.Name = "button_eliminar";
            this.button_eliminar.Size = new System.Drawing.Size(100, 28);
            this.button_eliminar.TabIndex = 76;
            this.button_eliminar.Text = "Eliminar";
            this.button_eliminar.UseVisualStyleBackColor = true;
            this.button_eliminar.Click += new System.EventHandler(this.button_eliminar_Click);
            // 
            // button_desactivar
            // 
            this.button_desactivar.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_desactivar.Location = new System.Drawing.Point(599, 473);
            this.button_desactivar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_desactivar.Name = "button_desactivar";
            this.button_desactivar.Size = new System.Drawing.Size(100, 28);
            this.button_desactivar.TabIndex = 75;
            this.button_desactivar.Text = "Desactivar";
            this.button_desactivar.UseVisualStyleBackColor = true;
            this.button_desactivar.Click += new System.EventHandler(this.button_desactivar_Click);
            // 
            // button_activar
            // 
            this.button_activar.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_activar.Location = new System.Drawing.Point(491, 471);
            this.button_activar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_activar.Name = "button_activar";
            this.button_activar.Size = new System.Drawing.Size(100, 28);
            this.button_activar.TabIndex = 74;
            this.button_activar.Text = "Activar";
            this.button_activar.UseVisualStyleBackColor = true;
            this.button_activar.Click += new System.EventHandler(this.button_activar_Click);
            // 
            // button1_buscar_administrador
            // 
            this.button1_buscar_administrador.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1_buscar_administrador.Location = new System.Drawing.Point(798, 47);
            this.button1_buscar_administrador.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1_buscar_administrador.Name = "button1_buscar_administrador";
            this.button1_buscar_administrador.Size = new System.Drawing.Size(117, 28);
            this.button1_buscar_administrador.TabIndex = 72;
            this.button1_buscar_administrador.Text = "Buscar";
            this.button1_buscar_administrador.UseVisualStyleBackColor = true;
            this.button1_buscar_administrador.Click += new System.EventHandler(this.button1_buscar_administrador_Click);
            // 
            // TB_BUSCAR_CAJERO
            // 
            this.TB_BUSCAR_CAJERO.Location = new System.Drawing.Point(115, 22);
            this.TB_BUSCAR_CAJERO.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TB_BUSCAR_CAJERO.Name = "TB_BUSCAR_CAJERO";
            this.TB_BUSCAR_CAJERO.Size = new System.Drawing.Size(356, 22);
            this.TB_BUSCAR_CAJERO.TabIndex = 71;
            // 
            // label_total_dep
            // 
            this.label_total_dep.AutoSize = true;
            this.label_total_dep.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_total_dep.Location = new System.Drawing.Point(232, 476);
            this.label_total_dep.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_total_dep.Name = "label_total_dep";
            this.label_total_dep.Size = new System.Drawing.Size(134, 19);
            this.label_total_dep.TabIndex = 70;
            this.label_total_dep.Text = "Cajeros actuales : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 19);
            this.label1.TabIndex = 68;
            this.label1.Text = "Buscar :";
            // 
            // CHECKB_DEP
            // 
            this.CHECKB_DEP.AutoSize = true;
            this.CHECKB_DEP.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CHECKB_DEP.Location = new System.Drawing.Point(33, 478);
            this.CHECKB_DEP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CHECKB_DEP.Name = "CHECKB_DEP";
            this.CHECKB_DEP.Size = new System.Drawing.Size(95, 20);
            this.CHECKB_DEP.TabIndex = 73;
            this.CHECKB_DEP.Text = "Seleccionar";
            this.CHECKB_DEP.UseVisualStyleBackColor = true;
            this.CHECKB_DEP.CheckedChanged += new System.EventHandler(this.CHECKB_DEP_CheckedChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(452, 54);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(15, 17);
            this.label11.TabIndex = 81;
            this.label11.Text = "y";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(152, 56);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 17);
            this.label12.TabIndex = 80;
            this.label12.Text = "Entre";
            // 
            // dateTimeFin
            // 
            this.dateTimeFin.Location = new System.Drawing.Point(483, 53);
            this.dateTimeFin.Name = "dateTimeFin";
            this.dateTimeFin.Size = new System.Drawing.Size(242, 22);
            this.dateTimeFin.TabIndex = 79;
            // 
            // dateTimeInicio
            // 
            this.dateTimeInicio.Location = new System.Drawing.Point(196, 51);
            this.dateTimeInicio.Name = "dateTimeInicio";
            this.dateTimeInicio.Size = new System.Drawing.Size(242, 22);
            this.dateTimeInicio.TabIndex = 78;
            // 
            // CAJERO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1092, 518);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dateTimeFin);
            this.Controls.Add(this.dateTimeInicio);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_eliminar);
            this.Controls.Add(this.button_desactivar);
            this.Controls.Add(this.button_activar);
            this.Controls.Add(this.button1_buscar_administrador);
            this.Controls.Add(this.TB_BUSCAR_CAJERO);
            this.Controls.Add(this.label_total_dep);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CHECKB_DEP);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CAJERO";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CAJERO";
            this.Load += new System.EventHandler(this.CAJERO_Load);
            ((System.ComponentModel.ISupportInitialize)(this.error_icono)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.TAB_DEPARTAMENTO.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DATAGV_CAJERO)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider error_icono;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage TAB_DEPARTAMENTO;
        private System.Windows.Forms.DataGridView DATAGV_CAJERO;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Seleccionar_departamento;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox text_Email;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox text_Clave;
        private System.Windows.Forms.DateTimePicker dateTime_FechaN;
        private System.Windows.Forms.DateTimePicker dateTime_FechaI;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox text_CURP;
        private System.Windows.Forms.Button button_actualizar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_cancelar;
        private System.Windows.Forms.Button button_insertar;
        private System.Windows.Forms.TextBox text_ID;
        private System.Windows.Forms.TextBox text_Nombre;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_eliminar;
        private System.Windows.Forms.Button button_desactivar;
        private System.Windows.Forms.Button button_activar;
        private System.Windows.Forms.Button button1_buscar_administrador;
        private System.Windows.Forms.TextBox TB_BUSCAR_CAJERO;
        private System.Windows.Forms.Label label_total_dep;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox CHECKB_DEP;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dateTimeFin;
        private System.Windows.Forms.DateTimePicker dateTimeInicio;
    }
}