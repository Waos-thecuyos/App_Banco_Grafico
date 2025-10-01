namespace AppBancoInterfazGrafica
{
    partial class FiltroClientes
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            formulario_clientes = new Panel();
            ComboBox_servicios = new CustomControls.RJControls.RJComboBox();
            label9 = new Label();
            tb_monto = new CustomControls.RJControls.RJTextBox();
            bt_cliente_agregar = new CustomControls.RJControls.RJButton();
            tb_telefono = new CustomControls.RJControls.RJTextBox();
            tb_email = new CustomControls.RJControls.RJTextBox();
            tb_nacimiento = new CustomControls.RJControls.RJTextBox();
            tb_nombres = new CustomControls.RJControls.RJTextBox();
            tb_dni = new CustomControls.RJControls.RJTextBox();
            CheckBox_discapacidad = new CheckBox();
            CheckBox_ninhos = new CheckBox();
            label3 = new Label();
            label8 = new Label();
            label2 = new Label();
            label7 = new Label();
            label6 = new Label();
            label1 = new Label();
            tabla_clientes = new DataGridView();
            Columna_dni = new DataGridViewTextBoxColumn();
            Columna_nombres = new DataGridViewTextBoxColumn();
            Columna_telefono = new DataGridViewTextBoxColumn();
            Columna_prioridad = new DataGridViewTextBoxColumn();
            Columna_ticket = new DataGridViewTextBoxColumn();
            formulario_clientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tabla_clientes).BeginInit();
            SuspendLayout();
            // 
            // formulario_clientes
            // 
            formulario_clientes.BackColor = Color.FromArgb(75, 57, 94);
            formulario_clientes.Controls.Add(ComboBox_servicios);
            formulario_clientes.Controls.Add(label9);
            formulario_clientes.Controls.Add(tb_monto);
            formulario_clientes.Controls.Add(bt_cliente_agregar);
            formulario_clientes.Controls.Add(tb_telefono);
            formulario_clientes.Controls.Add(tb_email);
            formulario_clientes.Controls.Add(tb_nacimiento);
            formulario_clientes.Controls.Add(tb_nombres);
            formulario_clientes.Controls.Add(tb_dni);
            formulario_clientes.Controls.Add(CheckBox_discapacidad);
            formulario_clientes.Controls.Add(CheckBox_ninhos);
            formulario_clientes.Controls.Add(label3);
            formulario_clientes.Controls.Add(label8);
            formulario_clientes.Controls.Add(label2);
            formulario_clientes.Controls.Add(label7);
            formulario_clientes.Controls.Add(label6);
            formulario_clientes.Controls.Add(label1);
            formulario_clientes.Dock = DockStyle.Top;
            formulario_clientes.Location = new Point(0, 0);
            formulario_clientes.Name = "formulario_clientes";
            formulario_clientes.Size = new Size(840, 334);
            formulario_clientes.TabIndex = 0;
            // 
            // ComboBox_servicios
            // 
            ComboBox_servicios.AutoCompleteMode = AutoCompleteMode.Suggest;
            ComboBox_servicios.AutoCompleteSource = AutoCompleteSource.ListItems;
            ComboBox_servicios.BackColor = Color.FromArgb(38, 39, 59);
            ComboBox_servicios.BorderColor = Color.MediumSlateBlue;
            ComboBox_servicios.BorderSize = 2;
            ComboBox_servicios.DropDownStyle = ComboBoxStyle.DropDown;
            ComboBox_servicios.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ComboBox_servicios.ForeColor = Color.Silver;
            ComboBox_servicios.IconColor = Color.MediumSlateBlue;
            ComboBox_servicios.Items.AddRange(new object[] { "Depósito", "Retiro", "Transferencia", "Pago de servicios", "Cambio de moneda" });
            ComboBox_servicios.ListBackColor = Color.FromArgb(38, 39, 59);
            ComboBox_servicios.ListTextColor = Color.WhiteSmoke;
            ComboBox_servicios.Location = new Point(238, 238);
            ComboBox_servicios.MinimumSize = new Size(200, 30);
            ComboBox_servicios.Name = "ComboBox_servicios";
            ComboBox_servicios.Padding = new Padding(2);
            ComboBox_servicios.Size = new Size(309, 30);
            ComboBox_servicios.TabIndex = 30;
            ComboBox_servicios.Texts = "Seleccione";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.LightGray;
            label9.Location = new Point(30, 247);
            label9.Name = "label9";
            label9.Size = new Size(151, 21);
            label9.TabIndex = 29;
            label9.Text = "Servicio solicitado:";
            // 
            // tb_monto
            // 
            tb_monto.BackColor = Color.FromArgb(75, 57, 94);
            tb_monto.BorderColor = Color.MediumSlateBlue;
            tb_monto.BorderFocusColor = Color.HotPink;
            tb_monto.BorderRadius = 10;
            tb_monto.BorderSize = 2;
            tb_monto.Font = new Font("Arial", 9.5F);
            tb_monto.ForeColor = Color.LightGray;
            tb_monto.Location = new Point(238, 196);
            tb_monto.Multiline = false;
            tb_monto.Name = "tb_monto";
            tb_monto.Padding = new Padding(10, 7, 10, 7);
            tb_monto.PasswordChar = false;
            tb_monto.PlaceholderColor = Color.DarkGray;
            tb_monto.PlaceholderText = "";
            tb_monto.ReadOnly = false;
            tb_monto.Size = new Size(309, 31);
            tb_monto.TabIndex = 28;
            tb_monto.Texts = "";
            tb_monto.UnderlinedStyle = false;
            // 
            // bt_cliente_agregar
            // 
            bt_cliente_agregar.BackColor = Color.FromArgb(38, 39, 59);
            bt_cliente_agregar.BackgroundColor = Color.FromArgb(38, 39, 59);
            bt_cliente_agregar.BorderColor = Color.PaleVioletRed;
            bt_cliente_agregar.BorderRadius = 10;
            bt_cliente_agregar.BorderSize = 0;
            bt_cliente_agregar.Cursor = Cursors.Hand;
            bt_cliente_agregar.FlatAppearance.BorderSize = 0;
            bt_cliente_agregar.FlatStyle = FlatStyle.Flat;
            bt_cliente_agregar.Font = new Font("Century Gothic", 12F);
            bt_cliente_agregar.ForeColor = Color.LightGray;
            bt_cliente_agregar.Location = new Point(601, 16);
            bt_cliente_agregar.Name = "bt_cliente_agregar";
            bt_cliente_agregar.Size = new Size(199, 40);
            bt_cliente_agregar.TabIndex = 1;
            bt_cliente_agregar.Text = "Agregar a la cola";
            bt_cliente_agregar.TextColor = Color.LightGray;
            bt_cliente_agregar.UseVisualStyleBackColor = false;
            bt_cliente_agregar.Click += bt_cliente_agregar_Click;
            // 
            // tb_telefono
            // 
            tb_telefono.BackColor = Color.FromArgb(75, 57, 94);
            tb_telefono.BorderColor = Color.MediumSlateBlue;
            tb_telefono.BorderFocusColor = Color.HotPink;
            tb_telefono.BorderRadius = 10;
            tb_telefono.BorderSize = 2;
            tb_telefono.Font = new Font("Arial", 9.5F);
            tb_telefono.ForeColor = Color.LightGray;
            tb_telefono.Location = new Point(238, 158);
            tb_telefono.Multiline = false;
            tb_telefono.Name = "tb_telefono";
            tb_telefono.Padding = new Padding(10, 7, 10, 7);
            tb_telefono.PasswordChar = false;
            tb_telefono.PlaceholderColor = Color.DarkGray;
            tb_telefono.PlaceholderText = "";
            tb_telefono.ReadOnly = false;
            tb_telefono.Size = new Size(309, 31);
            tb_telefono.TabIndex = 27;
            tb_telefono.Texts = "";
            tb_telefono.UnderlinedStyle = false;
            // 
            // tb_email
            // 
            tb_email.BackColor = Color.FromArgb(75, 57, 94);
            tb_email.BorderColor = Color.MediumSlateBlue;
            tb_email.BorderFocusColor = Color.HotPink;
            tb_email.BorderRadius = 10;
            tb_email.BorderSize = 2;
            tb_email.Font = new Font("Arial", 9.5F);
            tb_email.ForeColor = Color.LightGray;
            tb_email.Location = new Point(238, 120);
            tb_email.Multiline = false;
            tb_email.Name = "tb_email";
            tb_email.Padding = new Padding(10, 7, 10, 7);
            tb_email.PasswordChar = false;
            tb_email.PlaceholderColor = Color.DarkGray;
            tb_email.PlaceholderText = "";
            tb_email.ReadOnly = false;
            tb_email.Size = new Size(309, 31);
            tb_email.TabIndex = 26;
            tb_email.Texts = "";
            tb_email.UnderlinedStyle = false;
            // 
            // tb_nacimiento
            // 
            tb_nacimiento.BackColor = Color.FromArgb(75, 57, 94);
            tb_nacimiento.BorderColor = Color.MediumSlateBlue;
            tb_nacimiento.BorderFocusColor = Color.HotPink;
            tb_nacimiento.BorderRadius = 10;
            tb_nacimiento.BorderSize = 2;
            tb_nacimiento.Font = new Font("Arial", 9.5F);
            tb_nacimiento.ForeColor = Color.LightGray;
            tb_nacimiento.Location = new Point(238, 82);
            tb_nacimiento.Multiline = false;
            tb_nacimiento.Name = "tb_nacimiento";
            tb_nacimiento.Padding = new Padding(10, 7, 10, 7);
            tb_nacimiento.PasswordChar = false;
            tb_nacimiento.PlaceholderColor = Color.DarkGray;
            tb_nacimiento.PlaceholderText = "";
            tb_nacimiento.ReadOnly = false;
            tb_nacimiento.Size = new Size(309, 31);
            tb_nacimiento.TabIndex = 25;
            tb_nacimiento.Texts = "";
            tb_nacimiento.UnderlinedStyle = false;
            // 
            // tb_nombres
            // 
            tb_nombres.BackColor = Color.FromArgb(75, 57, 94);
            tb_nombres.BorderColor = Color.MediumSlateBlue;
            tb_nombres.BorderFocusColor = Color.HotPink;
            tb_nombres.BorderRadius = 10;
            tb_nombres.BorderSize = 2;
            tb_nombres.Font = new Font("Arial", 9.5F);
            tb_nombres.ForeColor = Color.LightGray;
            tb_nombres.Location = new Point(238, 44);
            tb_nombres.Multiline = false;
            tb_nombres.Name = "tb_nombres";
            tb_nombres.Padding = new Padding(10, 7, 10, 7);
            tb_nombres.PasswordChar = false;
            tb_nombres.PlaceholderColor = Color.DarkGray;
            tb_nombres.PlaceholderText = "";
            tb_nombres.ReadOnly = false;
            tb_nombres.Size = new Size(309, 31);
            tb_nombres.TabIndex = 24;
            tb_nombres.Texts = "";
            tb_nombres.UnderlinedStyle = false;
            // 
            // tb_dni
            // 
            tb_dni.BackColor = Color.FromArgb(75, 57, 94);
            tb_dni.BorderColor = Color.MediumSlateBlue;
            tb_dni.BorderFocusColor = Color.HotPink;
            tb_dni.BorderRadius = 10;
            tb_dni.BorderSize = 2;
            tb_dni.Font = new Font("Arial", 9.5F);
            tb_dni.ForeColor = Color.LightGray;
            tb_dni.Location = new Point(238, 6);
            tb_dni.Multiline = false;
            tb_dni.Name = "tb_dni";
            tb_dni.Padding = new Padding(10, 7, 10, 7);
            tb_dni.PasswordChar = false;
            tb_dni.PlaceholderColor = Color.DarkGray;
            tb_dni.PlaceholderText = "";
            tb_dni.ReadOnly = false;
            tb_dni.Size = new Size(309, 31);
            tb_dni.TabIndex = 23;
            tb_dni.Texts = "";
            tb_dni.UnderlinedStyle = false;
            // 
            // CheckBox_discapacidad
            // 
            CheckBox_discapacidad.AutoSize = true;
            CheckBox_discapacidad.Font = new Font("Century Gothic", 12F);
            CheckBox_discapacidad.ForeColor = Color.LightGray;
            CheckBox_discapacidad.Location = new Point(408, 282);
            CheckBox_discapacidad.Name = "CheckBox_discapacidad";
            CheckBox_discapacidad.Size = new Size(139, 25);
            CheckBox_discapacidad.TabIndex = 22;
            CheckBox_discapacidad.Text = "Discapacidad";
            CheckBox_discapacidad.UseVisualStyleBackColor = true;
            // 
            // CheckBox_ninhos
            // 
            CheckBox_ninhos.AutoSize = true;
            CheckBox_ninhos.Font = new Font("Century Gothic", 12F);
            CheckBox_ninhos.ForeColor = Color.LightGray;
            CheckBox_ninhos.Location = new Point(258, 282);
            CheckBox_ninhos.Name = "CheckBox_ninhos";
            CheckBox_ninhos.Size = new Size(70, 25);
            CheckBox_ninhos.TabIndex = 15;
            CheckBox_ninhos.Text = "Niños";
            CheckBox_ninhos.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Century Gothic", 12F);
            label3.ForeColor = Color.LightGray;
            label3.Location = new Point(30, 92);
            label3.Name = "label3";
            label3.Size = new Size(183, 21);
            label3.TabIndex = 2;
            label3.Text = "Fecha de Nacimiento:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Century Gothic", 12F);
            label8.ForeColor = Color.LightGray;
            label8.Location = new Point(30, 206);
            label8.Name = "label8";
            label8.Size = new Size(66, 21);
            label8.TabIndex = 7;
            label8.Text = "Monto:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Century Gothic", 12F);
            label2.ForeColor = Color.LightGray;
            label2.Location = new Point(30, 54);
            label2.Name = "label2";
            label2.Size = new Size(169, 21);
            label2.TabIndex = 1;
            label2.Text = "Nombres y Apellidos:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Century Gothic", 12F);
            label7.ForeColor = Color.LightGray;
            label7.Location = new Point(30, 168);
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
            label6.Location = new Point(30, 130);
            label6.Name = "label6";
            label6.Size = new Size(55, 21);
            label6.TabIndex = 5;
            label6.Text = "Email:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Century Gothic", 12F);
            label1.ForeColor = Color.LightGray;
            label1.Location = new Point(30, 16);
            label1.Name = "label1";
            label1.Size = new Size(43, 21);
            label1.TabIndex = 0;
            label1.Text = "DNI:";
            // 
            // tabla_clientes
            // 
            tabla_clientes.BackgroundColor = Color.White;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(175, 77, 255);
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(175, 77, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            tabla_clientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            tabla_clientes.Columns.AddRange(new DataGridViewColumn[] { Columna_dni, Columna_nombres, Columna_telefono, Columna_prioridad, Columna_ticket });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(253, 202, 251);
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(129, 110, 255);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            tabla_clientes.DefaultCellStyle = dataGridViewCellStyle4;
            tabla_clientes.Dock = DockStyle.Fill;
            tabla_clientes.EnableHeadersVisualStyles = false;
            tabla_clientes.Location = new Point(0, 334);
            tabla_clientes.Name = "tabla_clientes";
            tabla_clientes.Size = new Size(840, 193);
            tabla_clientes.TabIndex = 0;
            // 
            // Columna_dni
            // 
            Columna_dni.HeaderText = "DNI";
            Columna_dni.Name = "Columna_dni";
            Columna_dni.ReadOnly = true;
            // 
            // Columna_nombres
            // 
            Columna_nombres.HeaderText = "Nombre";
            Columna_nombres.Name = "Columna_nombres";
            Columna_nombres.ReadOnly = true;
            // 
            // Columna_telefono
            // 
            Columna_telefono.HeaderText = "Teléfono";
            Columna_telefono.Name = "Columna_telefono";
            Columna_telefono.ReadOnly = true;
            // 
            // Columna_prioridad
            // 
            Columna_prioridad.HeaderText = "Nivel de Prioridad";
            Columna_prioridad.Name = "Columna_prioridad";
            Columna_prioridad.ReadOnly = true;
            Columna_prioridad.Width = 150;
            // 
            // Columna_ticket
            // 
            Columna_ticket.HeaderText = "Número de Ticket";
            Columna_ticket.Name = "Columna_ticket";
            Columna_ticket.ReadOnly = true;
            Columna_ticket.Width = 150;
            // 
            // FiltroClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(tabla_clientes);
            Controls.Add(formulario_clientes);
            Name = "FiltroClientes";
            Size = new Size(840, 527);
            formulario_clientes.ResumeLayout(false);
            formulario_clientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tabla_clientes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel formulario_clientes;
        private CustomControls.RJControls.RJButton bt_cliente_agregar;
        private Label label2;
        private Label label1;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private CheckBox CheckBox_ninhos;
        private CustomControls.RJControls.RJTextBox rjTextBox1;
        private CheckBox CheckBox_discapacidad;
        private CustomControls.RJControls.RJTextBox tb_dni;
        private CustomControls.RJControls.RJTextBox tb_monto;
        private CustomControls.RJControls.RJTextBox tb_telefono;
        private CustomControls.RJControls.RJTextBox tb_email;
        private CustomControls.RJControls.RJTextBox tb_nacimiento;
        private CustomControls.RJControls.RJTextBox tb_nombres;
        private CustomControls.RJControls.RJTextBox rjTextBox6;
        private DataGridView tabla_clientes;
        private DataGridViewTextBoxColumn Columna_dni;
        private DataGridViewTextBoxColumn Columna_nombres;
        private DataGridViewTextBoxColumn Columna_telefono;
        private DataGridViewTextBoxColumn Columna_prioridad;
        private DataGridViewTextBoxColumn Columna_ticket;
        private Label label9;
        private CustomControls.RJControls.RJComboBox ComboBox_servicios;
    }
}
