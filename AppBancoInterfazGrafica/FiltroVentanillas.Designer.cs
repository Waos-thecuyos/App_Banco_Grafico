namespace AppBancoInterfazGrafica
{
    partial class FiltroVentanillas
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            panel1 = new Panel();
            rjTextBox1 = new CustomControls.RJControls.RJTextBox();
            rjTextBox2 = new CustomControls.RJControls.RJTextBox();
            rjTextBox3 = new CustomControls.RJControls.RJTextBox();
            rjTextBox4 = new CustomControls.RJControls.RJTextBox();
            rjTextBox5 = new CustomControls.RJControls.RJTextBox();
            rjTextBox6 = new CustomControls.RJControls.RJTextBox();
            panel2 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 11.25F);
            label1.ForeColor = Color.LightGray;
            label1.Location = new Point(450, 26);
            label1.Name = "label1";
            label1.Size = new Size(135, 20);
            label1.TabIndex = 0;
            label1.Text = "Cajero asignado:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 11.25F);
            label3.ForeColor = Color.LightGray;
            label3.Location = new Point(42, 26);
            label3.Name = "label3";
            label3.Size = new Size(171, 20);
            label3.TabIndex = 2;
            label3.Text = "Número de ventanilla:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.LightGray;
            label2.Location = new Point(42, 25);
            label2.Name = "label2";
            label2.Size = new Size(151, 21);
            label2.TabIndex = 3;
            label2.Text = "Número de Ticket:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 11.25F);
            label4.ForeColor = Color.LightGray;
            label4.Location = new Point(42, 67);
            label4.Name = "label4";
            label4.Size = new Size(159, 20);
            label4.TabIndex = 4;
            label4.Text = "Detalles del servicio:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 11.25F);
            label5.ForeColor = Color.LightGray;
            label5.Location = new Point(142, 137);
            label5.Name = "label5";
            label5.Size = new Size(78, 20);
            label5.TabIndex = 5;
            label5.Text = "Prioridad:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 11.25F);
            label6.ForeColor = Color.LightGray;
            label6.Location = new Point(142, 99);
            label6.Name = "label6";
            label6.Size = new Size(126, 20);
            label6.TabIndex = 6;
            label6.Text = "Tipo de servicio:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 11.25F);
            label7.ForeColor = Color.LightGray;
            label7.Location = new Point(142, 172);
            label7.Name = "label7";
            label7.Size = new Size(133, 20);
            label7.TabIndex = 7;
            label7.Text = "Atendido (Sí/No):";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(58, 59, 94);
            panel1.Controls.Add(rjTextBox1);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(840, 68);
            panel1.TabIndex = 8;
            // 
            // rjTextBox1
            // 
            rjTextBox1.BackColor = Color.FromArgb(58, 59, 94);
            rjTextBox1.BorderColor = Color.MediumSlateBlue;
            rjTextBox1.BorderFocusColor = Color.HotPink;
            rjTextBox1.BorderRadius = 10;
            rjTextBox1.BorderSize = 2;
            rjTextBox1.Font = new Font("Segoe UI", 9.5F);
            rjTextBox1.ForeColor = Color.LightGray;
            rjTextBox1.Location = new Point(199, 15);
            rjTextBox1.Multiline = false;
            rjTextBox1.Name = "rjTextBox1";
            rjTextBox1.Padding = new Padding(10, 7, 10, 7);
            rjTextBox1.PasswordChar = false;
            rjTextBox1.PlaceholderColor = Color.DarkGray;
            rjTextBox1.PlaceholderText = "";
            rjTextBox1.ReadOnly = false;
            rjTextBox1.Size = new Size(304, 32);
            rjTextBox1.TabIndex = 4;
            rjTextBox1.Texts = "";
            rjTextBox1.UnderlinedStyle = false;
            // 
            // rjTextBox2
            // 
            rjTextBox2.BackColor = Color.FromArgb(75, 57, 94);
            rjTextBox2.BorderColor = Color.HotPink;
            rjTextBox2.BorderFocusColor = Color.HotPink;
            rjTextBox2.BorderRadius = 0;
            rjTextBox2.BorderSize = 2;
            rjTextBox2.Font = new Font("Century Gothic", 9.75F);
            rjTextBox2.ForeColor = Color.DarkGray;
            rjTextBox2.Location = new Point(219, 14);
            rjTextBox2.Multiline = false;
            rjTextBox2.Name = "rjTextBox2";
            rjTextBox2.Padding = new Padding(10, 7, 10, 7);
            rjTextBox2.PasswordChar = false;
            rjTextBox2.PlaceholderColor = Color.DarkGray;
            rjTextBox2.PlaceholderText = "";
            rjTextBox2.ReadOnly = true;
            rjTextBox2.Size = new Size(163, 32);
            rjTextBox2.TabIndex = 9;
            rjTextBox2.Texts = "";
            rjTextBox2.UnderlinedStyle = true;
            // 
            // rjTextBox3
            // 
            rjTextBox3.BackColor = Color.FromArgb(75, 57, 94);
            rjTextBox3.BorderColor = Color.HotPink;
            rjTextBox3.BorderFocusColor = Color.HotPink;
            rjTextBox3.BorderRadius = 0;
            rjTextBox3.BorderSize = 2;
            rjTextBox3.Font = new Font("Century Gothic", 9.75F);
            rjTextBox3.ForeColor = Color.DarkGray;
            rjTextBox3.Location = new Point(591, 14);
            rjTextBox3.Multiline = false;
            rjTextBox3.Name = "rjTextBox3";
            rjTextBox3.Padding = new Padding(10, 7, 10, 7);
            rjTextBox3.PasswordChar = false;
            rjTextBox3.PlaceholderColor = Color.DarkGray;
            rjTextBox3.PlaceholderText = "";
            rjTextBox3.ReadOnly = true;
            rjTextBox3.Size = new Size(163, 32);
            rjTextBox3.TabIndex = 10;
            rjTextBox3.Texts = "";
            rjTextBox3.UnderlinedStyle = true;
            // 
            // rjTextBox4
            // 
            rjTextBox4.BackColor = Color.FromArgb(75, 57, 94);
            rjTextBox4.BorderColor = Color.HotPink;
            rjTextBox4.BorderFocusColor = Color.HotPink;
            rjTextBox4.BorderRadius = 0;
            rjTextBox4.BorderSize = 2;
            rjTextBox4.Font = new Font("Century Gothic", 9.75F);
            rjTextBox4.ForeColor = Color.DarkGray;
            rjTextBox4.Location = new Point(274, 87);
            rjTextBox4.Multiline = false;
            rjTextBox4.Name = "rjTextBox4";
            rjTextBox4.Padding = new Padding(10, 7, 10, 7);
            rjTextBox4.PasswordChar = false;
            rjTextBox4.PlaceholderColor = Color.DarkGray;
            rjTextBox4.PlaceholderText = "";
            rjTextBox4.ReadOnly = true;
            rjTextBox4.Size = new Size(229, 32);
            rjTextBox4.TabIndex = 11;
            rjTextBox4.Texts = "";
            rjTextBox4.UnderlinedStyle = true;
            // 
            // rjTextBox5
            // 
            rjTextBox5.BackColor = Color.FromArgb(75, 57, 94);
            rjTextBox5.BorderColor = Color.HotPink;
            rjTextBox5.BorderFocusColor = Color.HotPink;
            rjTextBox5.BorderRadius = 0;
            rjTextBox5.BorderSize = 2;
            rjTextBox5.Font = new Font("Century Gothic", 9.75F);
            rjTextBox5.ForeColor = Color.DarkGray;
            rjTextBox5.Location = new Point(274, 125);
            rjTextBox5.Multiline = false;
            rjTextBox5.Name = "rjTextBox5";
            rjTextBox5.Padding = new Padding(10, 7, 10, 7);
            rjTextBox5.PasswordChar = false;
            rjTextBox5.PlaceholderColor = Color.DarkGray;
            rjTextBox5.PlaceholderText = "";
            rjTextBox5.ReadOnly = true;
            rjTextBox5.Size = new Size(229, 32);
            rjTextBox5.TabIndex = 12;
            rjTextBox5.Texts = "";
            rjTextBox5.UnderlinedStyle = true;
            // 
            // rjTextBox6
            // 
            rjTextBox6.BackColor = Color.FromArgb(75, 57, 94);
            rjTextBox6.BorderColor = Color.HotPink;
            rjTextBox6.BorderFocusColor = Color.HotPink;
            rjTextBox6.BorderRadius = 0;
            rjTextBox6.BorderSize = 2;
            rjTextBox6.Font = new Font("Century Gothic", 9.75F);
            rjTextBox6.ForeColor = Color.DarkGray;
            rjTextBox6.Location = new Point(274, 163);
            rjTextBox6.Multiline = false;
            rjTextBox6.Name = "rjTextBox6";
            rjTextBox6.Padding = new Padding(10, 7, 10, 7);
            rjTextBox6.PasswordChar = false;
            rjTextBox6.PlaceholderColor = Color.DarkGray;
            rjTextBox6.PlaceholderText = "";
            rjTextBox6.ReadOnly = true;
            rjTextBox6.Size = new Size(229, 32);
            rjTextBox6.TabIndex = 13;
            rjTextBox6.Texts = "";
            rjTextBox6.UnderlinedStyle = true;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(75, 57, 94);
            panel2.Controls.Add(rjTextBox2);
            panel2.Controls.Add(rjTextBox6);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(rjTextBox5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(rjTextBox4);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(rjTextBox3);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 68);
            panel2.Name = "panel2";
            panel2.Size = new Size(840, 238);
            panel2.TabIndex = 14;
            // 
            // FiltroVentanillas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FiltroVentanillas";
            Size = new Size(840, 527);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label3;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Panel panel1;
        private CustomControls.RJControls.RJTextBox rjTextBox1;
        private CustomControls.RJControls.RJTextBox rjTextBox2;
        private CustomControls.RJControls.RJTextBox rjTextBox3;
        private CustomControls.RJControls.RJTextBox rjTextBox4;
        private CustomControls.RJControls.RJTextBox rjTextBox5;
        private CustomControls.RJControls.RJTextBox rjTextBox6;
        private Panel panel2;
    }
}
