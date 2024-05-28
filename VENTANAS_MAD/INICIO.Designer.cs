namespace VENTANAS_MAD
{
    partial class INICIO
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
            this.button_cajero = new System.Windows.Forms.Button();
            this.button_admin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_cajero
            // 
            this.button_cajero.BackColor = System.Drawing.Color.GhostWhite;
            this.button_cajero.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cajero.Location = new System.Drawing.Point(183, 233);
            this.button_cajero.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_cajero.Name = "button_cajero";
            this.button_cajero.Size = new System.Drawing.Size(235, 55);
            this.button_cajero.TabIndex = 8;
            this.button_cajero.Text = "Cajero ";
            this.button_cajero.UseVisualStyleBackColor = false;
            this.button_cajero.Click += new System.EventHandler(this.button_cajero_Click);
            // 
            // button_admin
            // 
            this.button_admin.BackColor = System.Drawing.SystemColors.Control;
            this.button_admin.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_admin.Location = new System.Drawing.Point(183, 142);
            this.button_admin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_admin.Name = "button_admin";
            this.button_admin.Size = new System.Drawing.Size(235, 59);
            this.button_admin.TabIndex = 7;
            this.button_admin.Text = "Administrador ";
            this.button_admin.UseVisualStyleBackColor = false;
            this.button_admin.Click += new System.EventHandler(this.button_admin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(223, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "Elige una opción. ";
            // 
            // INICIO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(600, 331);
            this.Controls.Add(this.button_cajero);
            this.Controls.Add(this.button_admin);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "INICIO";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "INICIO";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_cajero;
        private System.Windows.Forms.Button button_admin;
        private System.Windows.Forms.Label label1;
    }
}