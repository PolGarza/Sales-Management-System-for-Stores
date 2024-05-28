namespace VENTANAS_MAD
{
    partial class DEVOLUCIONES
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
            this.BUTTOM_BUSCAR_C = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.error_icono = new System.Windows.Forms.ErrorProvider(this.components);
            this.button3 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DGV_DEVOLUCION = new System.Windows.Forms.DataGridView();
            this.Seleccionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.CHECKB_DEP = new System.Windows.Forms.CheckBox();
            this.button5_volver = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.error_icono)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_DEVOLUCION)).BeginInit();
            this.SuspendLayout();
            // 
            // BUTTOM_BUSCAR_C
            // 
            this.BUTTOM_BUSCAR_C.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BUTTOM_BUSCAR_C.Location = new System.Drawing.Point(555, 31);
            this.BUTTOM_BUSCAR_C.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BUTTOM_BUSCAR_C.Name = "BUTTOM_BUSCAR_C";
            this.BUTTOM_BUSCAR_C.Size = new System.Drawing.Size(159, 25);
            this.BUTTOM_BUSCAR_C.TabIndex = 13;
            this.BUTTOM_BUSCAR_C.Text = "Codigo";
            this.BUTTOM_BUSCAR_C.UseVisualStyleBackColor = true;
            this.BUTTOM_BUSCAR_C.Click += new System.EventHandler(this.BUTTOM_BUSCAR_C_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(888, 629);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(176, 37);
            this.button2.TabIndex = 16;
            this.button2.Text = "Merma";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // error_icono
            // 
            this.error_icono.ContainerControl = this;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(695, 629);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(171, 37);
            this.button3.TabIndex = 17;
            this.button3.Text = "Cambio";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(359, 635);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(301, 19);
            this.label8.TabIndex = 18;
            this.label8.Text = "Elija el tipo de devolución que se realizará ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(379, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 19);
            this.label1.TabIndex = 20;
            this.label1.Text = "Elija el modo de listar : ";
            // 
            // DGV_DEVOLUCION
            // 
            this.DGV_DEVOLUCION.AllowUserToAddRows = false;
            this.DGV_DEVOLUCION.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_DEVOLUCION.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Seleccionar});
            this.DGV_DEVOLUCION.Location = new System.Drawing.Point(15, 71);
            this.DGV_DEVOLUCION.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DGV_DEVOLUCION.Name = "DGV_DEVOLUCION";
            this.DGV_DEVOLUCION.RowTemplate.Height = 24;
            this.DGV_DEVOLUCION.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_DEVOLUCION.Size = new System.Drawing.Size(1160, 534);
            this.DGV_DEVOLUCION.TabIndex = 21;
            // 
            // Seleccionar
            // 
            this.Seleccionar.HeaderText = "Seleccionar";
            this.Seleccionar.Name = "Seleccionar";
            // 
            // CHECKB_DEP
            // 
            this.CHECKB_DEP.AutoSize = true;
            this.CHECKB_DEP.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CHECKB_DEP.Location = new System.Drawing.Point(36, 641);
            this.CHECKB_DEP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CHECKB_DEP.Name = "CHECKB_DEP";
            this.CHECKB_DEP.Size = new System.Drawing.Size(95, 20);
            this.CHECKB_DEP.TabIndex = 42;
            this.CHECKB_DEP.Text = "Seleccionar";
            this.CHECKB_DEP.UseVisualStyleBackColor = true;
            this.CHECKB_DEP.CheckedChanged += new System.EventHandler(this.CHECKB_DEP_CheckedChanged);
            // 
            // button5_volver
            // 
            this.button5_volver.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5_volver.Location = new System.Drawing.Point(1063, 27);
            this.button5_volver.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button5_volver.Name = "button5_volver";
            this.button5_volver.Size = new System.Drawing.Size(112, 25);
            this.button5_volver.TabIndex = 43;
            this.button5_volver.Text = "Volver";
            this.button5_volver.UseVisualStyleBackColor = true;
            this.button5_volver.Click += new System.EventHandler(this.button5_volver_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(719, 31);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 25);
            this.button1.TabIndex = 44;
            this.button1.Text = "Producto ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DEVOLUCIONES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1189, 679);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button5_volver);
            this.Controls.Add(this.CHECKB_DEP);
            this.Controls.Add(this.DGV_DEVOLUCION);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.BUTTOM_BUSCAR_C);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "DEVOLUCIONES";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DEVOLUCIONES";
            this.Load += new System.EventHandler(this.DEVOLUCIONES_Load);
            ((System.ComponentModel.ISupportInitialize)(this.error_icono)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_DEVOLUCION)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BUTTOM_BUSCAR_C;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ErrorProvider error_icono;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView DGV_DEVOLUCION;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Seleccionar;
        private System.Windows.Forms.CheckBox CHECKB_DEP;
        private System.Windows.Forms.Button button5_volver;
        private System.Windows.Forms.Button button1;
    }
}