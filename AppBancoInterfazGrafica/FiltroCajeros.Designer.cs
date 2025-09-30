namespace AppBancoInterfazGrafica
{
    partial class FiltroCajeros
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
            rjButton1 = new CustomControls.RJControls.RJButton();
            bt_cliente_eliminar = new CustomControls.RJControls.RJButton();
            bt_cliente_agregar = new CustomControls.RJControls.RJButton();
            formulario_clientes = new Panel();
            label7 = new Label();
            label6 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            rjTextBox1 = new CustomControls.RJControls.RJTextBox();
            rjTextBox2 = new CustomControls.RJControls.RJTextBox();
            rjTextBox3 = new CustomControls.RJControls.RJTextBox();
            rjTextBox4 = new CustomControls.RJControls.RJTextBox();
            rjTextBox5 = new CustomControls.RJControls.RJTextBox();
            formulario_clientes.SuspendLayout();
            SuspendLayout();
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
            rjButton1.ForeColor = Color.DarkGray;
            rjButton1.Location = new Point(644, 98);
            rjButton1.Name = "rjButton1";
            rjButton1.Size = new Size(150, 40);
            rjButton1.TabIndex = 7;
            rjButton1.Text = "Editar";
            rjButton1.TextColor = Color.DarkGray;
            rjButton1.UseVisualStyleBackColor = false;
            // 
            // bt_cliente_eliminar
            // 
            bt_cliente_eliminar.BackColor = Color.FromArgb(38, 39, 59);
            bt_cliente_eliminar.BackgroundColor = Color.FromArgb(38, 39, 59);
            bt_cliente_eliminar.BorderColor = Color.PaleVioletRed;
            bt_cliente_eliminar.BorderRadius = 10;
            bt_cliente_eliminar.BorderSize = 0;
            bt_cliente_eliminar.FlatAppearance.BorderSize = 0;
            bt_cliente_eliminar.FlatStyle = FlatStyle.Flat;
            bt_cliente_eliminar.Font = new Font("Century Gothic", 12F);
            bt_cliente_eliminar.ForeColor = Color.DarkGray;
            bt_cliente_eliminar.Location = new Point(644, 52);
            bt_cliente_eliminar.Name = "bt_cliente_eliminar";
            bt_cliente_eliminar.Size = new Size(150, 40);
            bt_cliente_eliminar.TabIndex = 6;
            bt_cliente_eliminar.Text = "Eliminar";
            bt_cliente_eliminar.TextColor = Color.DarkGray;
            bt_cliente_eliminar.UseVisualStyleBackColor = false;
            // 
            // bt_cliente_agregar
            // 
            bt_cliente_agregar.BackColor = Color.FromArgb(38, 39, 59);
            bt_cliente_agregar.BackgroundColor = Color.FromArgb(38, 39, 59);
            bt_cliente_agregar.BorderColor = Color.PaleVioletRed;
            bt_cliente_agregar.BorderRadius = 10;
            bt_cliente_agregar.BorderSize = 0;
            bt_cliente_agregar.FlatAppearance.BorderSize = 0;
            bt_cliente_agregar.FlatStyle = FlatStyle.Flat;
            bt_cliente_agregar.Font = new Font("Century Gothic", 12F);
            bt_cliente_agregar.ForeColor = Color.DarkGray;
            bt_cliente_agregar.Location = new Point(644, 6);
            bt_cliente_agregar.Name = "bt_cliente_agregar";
            bt_cliente_agregar.Size = new Size(150, 40);
            bt_cliente_agregar.TabIndex = 5;
            bt_cliente_agregar.Text = "Agregar";
            bt_cliente_agregar.TextColor = Color.DarkGray;
            bt_cliente_agregar.UseVisualStyleBackColor = false;
            // 
            // formulario_clientes
            // 
            formulario_clientes.BackColor = Color.FromArgb(75, 57, 94);
            formulario_clientes.Controls.Add(rjTextBox5);
            formulario_clientes.Controls.Add(rjButton1);
            formulario_clientes.Controls.Add(label7);
            formulario_clientes.Controls.Add(bt_cliente_agregar);
            formulario_clientes.Controls.Add(bt_cliente_eliminar);
            formulario_clientes.Controls.Add(label1);
            formulario_clientes.Controls.Add(label2);
            formulario_clientes.Controls.Add(label6);
            formulario_clientes.Controls.Add(label3);
            formulario_clientes.Controls.Add(rjTextBox4);
            formulario_clientes.Controls.Add(rjTextBox3);
            formulario_clientes.Controls.Add(rjTextBox2);
            formulario_clientes.Controls.Add(rjTextBox1);
            formulario_clientes.Dock = DockStyle.Top;
            formulario_clientes.Location = new Point(0, 0);
            formulario_clientes.Name = "formulario_clientes";
            formulario_clientes.Size = new Size(840, 215);
            formulario_clientes.TabIndex = 4;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Century Gothic", 12F);
            label7.ForeColor = Color.LightGray;
            label7.Location = new Point(34, 169);
            label7.Name = "label7";
            label7.Size = new Size(80, 21);
            label7.TabIndex = 6;
            label7.Text = "Teléfono:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Century Gothic", 12F);
            label6.ForeColor = Color.LightGray;
            label6.Location = new Point(34, 131);
            label6.Name = "label6";
            label6.Size = new Size(55, 21);
            label6.TabIndex = 5;
            label6.Text = "Email:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Century Gothic", 12F);
            label3.ForeColor = Color.LightGray;
            label3.Location = new Point(34, 93);
            label3.Name = "label3";
            label3.Size = new Size(87, 21);
            label3.TabIndex = 2;
            label3.Text = "Dirección:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Century Gothic", 12F);
            label2.ForeColor = Color.LightGray;
            label2.Location = new Point(34, 55);
            label2.Name = "label2";
            label2.Size = new Size(169, 21);
            label2.TabIndex = 1;
            label2.Text = "Nombres y Apellidos:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Century Gothic", 12F);
            label1.ForeColor = Color.LightGray;
            label1.Location = new Point(34, 17);
            label1.Name = "label1";
            label1.Size = new Size(43, 21);
            label1.TabIndex = 0;
            label1.Text = "DNI:";
            // 
            // rjTextBox1
            // 
            rjTextBox1.BackColor = Color.FromArgb(75, 57, 94);
            rjTextBox1.BorderColor = Color.MediumSlateBlue;
            rjTextBox1.BorderFocusColor = Color.HotPink;
            rjTextBox1.BorderRadius = 10;
            rjTextBox1.BorderSize = 2;
            rjTextBox1.Font = new Font("Segoe UI", 9.5F);
            rjTextBox1.ForeColor = Color.DarkGray;
            rjTextBox1.Location = new Point(238, 6);
            rjTextBox1.Multiline = false;
            rjTextBox1.Name = "rjTextBox1";
            rjTextBox1.Padding = new Padding(10, 7, 10, 7);
            rjTextBox1.PasswordChar = false;
            rjTextBox1.PlaceholderColor = Color.DarkGray;
            rjTextBox1.PlaceholderText = "";
            rjTextBox1.ReadOnly = false;
            rjTextBox1.Size = new Size(309, 32);
            rjTextBox1.TabIndex = 8;
            rjTextBox1.Texts = "";
            rjTextBox1.UnderlinedStyle = false;
            // 
            // rjTextBox2
            // 
            rjTextBox2.BackColor = Color.FromArgb(75, 57, 94);
            rjTextBox2.BorderColor = Color.MediumSlateBlue;
            rjTextBox2.BorderFocusColor = Color.HotPink;
            rjTextBox2.BorderRadius = 10;
            rjTextBox2.BorderSize = 2;
            rjTextBox2.Font = new Font("Segoe UI", 9.5F);
            rjTextBox2.ForeColor = Color.DarkGray;
            rjTextBox2.Location = new Point(238, 44);
            rjTextBox2.Multiline = false;
            rjTextBox2.Name = "rjTextBox2";
            rjTextBox2.Padding = new Padding(10, 7, 10, 7);
            rjTextBox2.PasswordChar = false;
            rjTextBox2.PlaceholderColor = Color.DarkGray;
            rjTextBox2.PlaceholderText = "";
            rjTextBox2.ReadOnly = false;
            rjTextBox2.Size = new Size(309, 32);
            rjTextBox2.TabIndex = 9;
            rjTextBox2.Texts = "";
            rjTextBox2.UnderlinedStyle = false;
            // 
            // rjTextBox3
            // 
            rjTextBox3.BackColor = Color.FromArgb(75, 57, 94);
            rjTextBox3.BorderColor = Color.MediumSlateBlue;
            rjTextBox3.BorderFocusColor = Color.HotPink;
            rjTextBox3.BorderRadius = 10;
            rjTextBox3.BorderSize = 2;
            rjTextBox3.Font = new Font("Segoe UI", 9.5F);
            rjTextBox3.ForeColor = Color.DarkGray;
            rjTextBox3.Location = new Point(238, 82);
            rjTextBox3.Multiline = false;
            rjTextBox3.Name = "rjTextBox3";
            rjTextBox3.Padding = new Padding(10, 7, 10, 7);
            rjTextBox3.PasswordChar = false;
            rjTextBox3.PlaceholderColor = Color.DarkGray;
            rjTextBox3.PlaceholderText = "";
            rjTextBox3.ReadOnly = false;
            rjTextBox3.Size = new Size(309, 32);
            rjTextBox3.TabIndex = 10;
            rjTextBox3.Texts = "";
            rjTextBox3.UnderlinedStyle = false;
            // 
            // rjTextBox4
            // 
            rjTextBox4.BackColor = Color.FromArgb(75, 57, 94);
            rjTextBox4.BorderColor = Color.MediumSlateBlue;
            rjTextBox4.BorderFocusColor = Color.HotPink;
            rjTextBox4.BorderRadius = 10;
            rjTextBox4.BorderSize = 2;
            rjTextBox4.Font = new Font("Segoe UI", 9.5F);
            rjTextBox4.ForeColor = Color.DarkGray;
            rjTextBox4.Location = new Point(238, 120);
            rjTextBox4.Multiline = false;
            rjTextBox4.Name = "rjTextBox4";
            rjTextBox4.Padding = new Padding(10, 7, 10, 7);
            rjTextBox4.PasswordChar = false;
            rjTextBox4.PlaceholderColor = Color.DarkGray;
            rjTextBox4.PlaceholderText = "";
            rjTextBox4.ReadOnly = false;
            rjTextBox4.Size = new Size(309, 32);
            rjTextBox4.TabIndex = 11;
            rjTextBox4.Texts = "";
            rjTextBox4.UnderlinedStyle = false;
            // 
            // rjTextBox5
            // 
            rjTextBox5.BackColor = Color.FromArgb(75, 57, 94);
            rjTextBox5.BorderColor = Color.MediumSlateBlue;
            rjTextBox5.BorderFocusColor = Color.HotPink;
            rjTextBox5.BorderRadius = 10;
            rjTextBox5.BorderSize = 2;
            rjTextBox5.Font = new Font("Segoe UI", 9.5F);
            rjTextBox5.ForeColor = Color.DarkGray;
            rjTextBox5.Location = new Point(238, 158);
            rjTextBox5.Multiline = false;
            rjTextBox5.Name = "rjTextBox5";
            rjTextBox5.Padding = new Padding(10, 7, 10, 7);
            rjTextBox5.PasswordChar = false;
            rjTextBox5.PlaceholderColor = Color.DarkGray;
            rjTextBox5.PlaceholderText = "";
            rjTextBox5.ReadOnly = false;
            rjTextBox5.Size = new Size(309, 32);
            rjTextBox5.TabIndex = 12;
            rjTextBox5.Texts = "";
            rjTextBox5.UnderlinedStyle = false;
            // 
            // FiltroCajeros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(formulario_clientes);
            Name = "FiltroCajeros";
            Size = new Size(840, 527);
            formulario_clientes.ResumeLayout(false);
            formulario_clientes.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private CustomControls.RJControls.RJButton rjButton1;
        private CustomControls.RJControls.RJButton bt_cliente_eliminar;
        private CustomControls.RJControls.RJButton bt_cliente_agregar;
        private Panel formulario_clientes;
        private Label label7;
        private Label label6;
        private Label label3;
        private Label label2;
        private Label label1;
        private CustomControls.RJControls.RJTextBox rjTextBox1;
        private CustomControls.RJControls.RJTextBox rjTextBox5;
        private CustomControls.RJControls.RJTextBox rjTextBox4;
        private CustomControls.RJControls.RJTextBox rjTextBox3;
        private CustomControls.RJControls.RJTextBox rjTextBox2;
    }
}
