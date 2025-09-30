namespace AppBancoInterfazGrafica
{
    partial class FiltroServicios
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
            panel1 = new Panel();
            rjComboBox1 = new CustomControls.RJControls.RJComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            rjTextBox1 = new CustomControls.RJControls.RJTextBox();
            rjTextBox2 = new CustomControls.RJControls.RJTextBox();
            rjButton1 = new CustomControls.RJControls.RJButton();
            rjButton2 = new CustomControls.RJControls.RJButton();
            rjButton3 = new CustomControls.RJControls.RJButton();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(38, 39, 59);
            panel1.Controls.Add(rjComboBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(840, 62);
            panel1.TabIndex = 0;
            // 
            // rjComboBox1
            // 
            rjComboBox1.AutoCompleteMode = AutoCompleteMode.Suggest;
            rjComboBox1.AutoCompleteSource = AutoCompleteSource.ListItems;
            rjComboBox1.BackColor = Color.FromArgb(38, 39, 59);
            rjComboBox1.BorderColor = Color.MediumSlateBlue;
            rjComboBox1.BorderSize = 2;
            rjComboBox1.DropDownStyle = ComboBoxStyle.DropDown;
            rjComboBox1.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rjComboBox1.ForeColor = Color.Silver;
            rjComboBox1.IconColor = Color.MediumSlateBlue;
            rjComboBox1.Items.AddRange(new object[] { "Depósitos", "Retiros", "Pago de préstamos / créditos", "Transferencias", "Pago de servicios", "Pago de tributos y tasas", "Pago de tarjetas de crédito", "Consulta", "Envíos y giros", "Apertura de cuentas" });
            rjComboBox1.ListBackColor = Color.FromArgb(40, 28, 51);
            rjComboBox1.ListTextColor = Color.WhiteSmoke;
            rjComboBox1.Location = new Point(212, 11);
            rjComboBox1.MinimumSize = new Size(200, 30);
            rjComboBox1.Name = "rjComboBox1";
            rjComboBox1.Padding = new Padding(2);
            rjComboBox1.Size = new Size(288, 30);
            rjComboBox1.TabIndex = 1;
            rjComboBox1.Texts = "Seleccione";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.LightGray;
            label1.Location = new Point(53, 20);
            label1.Name = "label1";
            label1.Size = new Size(128, 21);
            label1.TabIndex = 0;
            label1.Text = "Tipo de servicio";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(53, 19);
            label2.Name = "label2";
            label2.Size = new Size(119, 21);
            label2.TabIndex = 1;
            label2.Text = "Id del servicio:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(53, 55);
            label3.Name = "label3";
            label3.Size = new Size(104, 21);
            label3.TabIndex = 2;
            label3.Text = "Descripción:";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(75, 57, 94);
            panel2.Controls.Add(rjButton3);
            panel2.Controls.Add(rjButton2);
            panel2.Controls.Add(rjButton1);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(648, 62);
            panel2.Name = "panel2";
            panel2.Size = new Size(192, 465);
            panel2.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 156);
            panel3.Name = "panel3";
            panel3.Size = new Size(648, 371);
            panel3.TabIndex = 4;
            // 
            // panel4
            // 
            panel4.BackColor = Color.HotPink;
            panel4.Controls.Add(rjTextBox2);
            panel4.Controls.Add(rjTextBox1);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(label3);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 62);
            panel4.Name = "panel4";
            panel4.Size = new Size(648, 94);
            panel4.TabIndex = 5;
            // 
            // rjTextBox1
            // 
            rjTextBox1.BackColor = Color.HotPink;
            rjTextBox1.BorderColor = Color.MediumSlateBlue;
            rjTextBox1.BorderFocusColor = Color.DarkMagenta;
            rjTextBox1.BorderRadius = 0;
            rjTextBox1.BorderSize = 2;
            rjTextBox1.Font = new Font("Segoe UI", 9.5F);
            rjTextBox1.ForeColor = Color.White;
            rjTextBox1.Location = new Point(195, 8);
            rjTextBox1.Multiline = false;
            rjTextBox1.Name = "rjTextBox1";
            rjTextBox1.Padding = new Padding(10, 7, 10, 7);
            rjTextBox1.PasswordChar = false;
            rjTextBox1.PlaceholderColor = Color.Gray;
            rjTextBox1.PlaceholderText = "";
            rjTextBox1.ReadOnly = true;
            rjTextBox1.Size = new Size(385, 32);
            rjTextBox1.TabIndex = 3;
            rjTextBox1.Texts = "";
            rjTextBox1.UnderlinedStyle = true;
            // 
            // rjTextBox2
            // 
            rjTextBox2.BackColor = Color.HotPink;
            rjTextBox2.BorderColor = Color.MediumSlateBlue;
            rjTextBox2.BorderFocusColor = Color.DarkMagenta;
            rjTextBox2.BorderRadius = 0;
            rjTextBox2.BorderSize = 2;
            rjTextBox2.Font = new Font("Segoe UI", 9.5F);
            rjTextBox2.ForeColor = Color.White;
            rjTextBox2.Location = new Point(195, 46);
            rjTextBox2.Multiline = false;
            rjTextBox2.Name = "rjTextBox2";
            rjTextBox2.Padding = new Padding(10, 7, 10, 7);
            rjTextBox2.PasswordChar = false;
            rjTextBox2.PlaceholderColor = Color.Gray;
            rjTextBox2.PlaceholderText = "";
            rjTextBox2.ReadOnly = true;
            rjTextBox2.Size = new Size(385, 32);
            rjTextBox2.TabIndex = 4;
            rjTextBox2.Texts = "";
            rjTextBox2.UnderlinedStyle = true;
            // 
            // rjButton1
            // 
            rjButton1.BackColor = Color.FromArgb(38, 39, 59);
            rjButton1.BackgroundColor = Color.FromArgb(38, 39, 59);
            rjButton1.BorderColor = Color.PaleVioletRed;
            rjButton1.BorderRadius = 10;
            rjButton1.BorderSize = 0;
            rjButton1.FlatAppearance.BorderSize = 0;
            rjButton1.FlatStyle = FlatStyle.Flat;
            rjButton1.Font = new Font("Century Gothic", 12F);
            rjButton1.ForeColor = Color.LightGray;
            rjButton1.Location = new Point(25, 19);
            rjButton1.Name = "rjButton1";
            rjButton1.Size = new Size(150, 40);
            rjButton1.TabIndex = 0;
            rjButton1.Text = "Agregar";
            rjButton1.TextColor = Color.LightGray;
            rjButton1.UseVisualStyleBackColor = false;
            // 
            // rjButton2
            // 
            rjButton2.BackColor = Color.FromArgb(38, 39, 59);
            rjButton2.BackgroundColor = Color.FromArgb(38, 39, 59);
            rjButton2.BorderColor = Color.PaleVioletRed;
            rjButton2.BorderRadius = 10;
            rjButton2.BorderSize = 0;
            rjButton2.FlatAppearance.BorderSize = 0;
            rjButton2.FlatStyle = FlatStyle.Flat;
            rjButton2.Font = new Font("Century Gothic", 12F);
            rjButton2.ForeColor = Color.LightGray;
            rjButton2.Location = new Point(25, 65);
            rjButton2.Name = "rjButton2";
            rjButton2.Size = new Size(150, 40);
            rjButton2.TabIndex = 1;
            rjButton2.Text = "Eliminar";
            rjButton2.TextColor = Color.LightGray;
            rjButton2.UseVisualStyleBackColor = false;
            // 
            // rjButton3
            // 
            rjButton3.BackColor = Color.FromArgb(38, 39, 59);
            rjButton3.BackgroundColor = Color.FromArgb(38, 39, 59);
            rjButton3.BorderColor = Color.PaleVioletRed;
            rjButton3.BorderRadius = 10;
            rjButton3.BorderSize = 0;
            rjButton3.FlatAppearance.BorderSize = 0;
            rjButton3.FlatStyle = FlatStyle.Flat;
            rjButton3.Font = new Font("Century Gothic", 12F);
            rjButton3.ForeColor = Color.LightGray;
            rjButton3.Location = new Point(25, 111);
            rjButton3.Name = "rjButton3";
            rjButton3.Size = new Size(150, 40);
            rjButton3.TabIndex = 2;
            rjButton3.Text = "Editar";
            rjButton3.TextColor = Color.LightGray;
            rjButton3.UseVisualStyleBackColor = false;
            // 
            // FiltroServicios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FiltroServicios";
            Size = new Size(840, 527);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private CustomControls.RJControls.RJComboBox rjComboBox1;
        private Label label2;
        private Label label3;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private CustomControls.RJControls.RJTextBox rjTextBox2;
        private CustomControls.RJControls.RJTextBox rjTextBox1;
        private CustomControls.RJControls.RJButton rjButton3;
        private CustomControls.RJControls.RJButton rjButton2;
        private CustomControls.RJControls.RJButton rjButton1;
    }
}
