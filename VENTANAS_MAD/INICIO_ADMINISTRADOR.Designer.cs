namespace VENTANAS_MAD
{
    partial class INICIO_ADMINISTRADOR
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1_inresar_admin = new System.Windows.Forms.Button();
            this.button1_regresar = new System.Windows.Forms.Button();
            this.textCLAVE = new System.Windows.Forms.TextBox();
            this.text_Usuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(464, 47);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(189, 166);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(127, 146);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 23;
            this.label3.Text = "Clave :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(113, 117);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 22;
            this.label2.Text = "Usuario : ";
            // 
            // button1_inresar_admin
            // 
            this.button1_inresar_admin.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1_inresar_admin.Location = new System.Drawing.Point(308, 193);
            this.button1_inresar_admin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1_inresar_admin.Name = "button1_inresar_admin";
            this.button1_inresar_admin.Size = new System.Drawing.Size(115, 28);
            this.button1_inresar_admin.TabIndex = 21;
            this.button1_inresar_admin.Text = "Ingresar ";
            this.button1_inresar_admin.UseVisualStyleBackColor = true;
            this.button1_inresar_admin.Click += new System.EventHandler(this.button1_inresar_admin_Click);
            // 
            // button1_regresar
            // 
            this.button1_regresar.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1_regresar.Location = new System.Drawing.Point(151, 193);
            this.button1_regresar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1_regresar.Name = "button1_regresar";
            this.button1_regresar.Size = new System.Drawing.Size(115, 28);
            this.button1_regresar.TabIndex = 20;
            this.button1_regresar.Text = "Regresar";
            this.button1_regresar.UseVisualStyleBackColor = true;
            this.button1_regresar.Click += new System.EventHandler(this.button1_regresar_Click);
            // 
            // textCLAVE
            // 
            this.textCLAVE.Location = new System.Drawing.Point(191, 146);
            this.textCLAVE.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textCLAVE.Name = "textCLAVE";
            this.textCLAVE.PasswordChar = '*';
            this.textCLAVE.Size = new System.Drawing.Size(219, 22);
            this.textCLAVE.TabIndex = 19;
            // 
            // text_Usuario
            // 
            this.text_Usuario.Location = new System.Drawing.Point(191, 114);
            this.text_Usuario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.text_Usuario.Name = "text_Usuario";
            this.text_Usuario.Size = new System.Drawing.Size(219, 22);
            this.text_Usuario.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(143, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 22);
            this.label1.TabIndex = 17;
            this.label1.Text = "Ingrese o cree una nueva cuenta. ";
            // 
            // INICIO_ADMINISTRADOR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(767, 268);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1_inresar_admin);
            this.Controls.Add(this.button1_regresar);
            this.Controls.Add(this.textCLAVE);
            this.Controls.Add(this.text_Usuario);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "INICIO_ADMINISTRADOR";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "INICIO_ADMINISTRADOR";
            this.Load += new System.EventHandler(this.INICIO_ADMINISTRADOR_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1_inresar_admin;
        private System.Windows.Forms.Button button1_regresar;
        private System.Windows.Forms.TextBox textCLAVE;
        private System.Windows.Forms.TextBox text_Usuario;
        private System.Windows.Forms.Label label1;
    }
}