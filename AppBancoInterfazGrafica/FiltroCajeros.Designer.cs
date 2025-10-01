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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            bt_cajero_editar = new CustomControls.RJControls.RJButton();
            bt_cajero_eliminar = new CustomControls.RJControls.RJButton();
            bt_cajero_agregar = new CustomControls.RJControls.RJButton();
            formulario_clientes = new Panel();
            tb_telefono_cajeros = new CustomControls.RJControls.RJTextBox();
            label7 = new Label();
            label1 = new Label();
            label2 = new Label();
            label6 = new Label();
            label3 = new Label();
            tb_email_cajeros = new CustomControls.RJControls.RJTextBox();
            tb_direccion_cajeros = new CustomControls.RJControls.RJTextBox();
            tb_nombres_cajeros = new CustomControls.RJControls.RJTextBox();
            tb_dni_cajeros = new CustomControls.RJControls.RJTextBox();
            dataGridView1 = new DataGridView();
            Columna_DNI = new DataGridViewTextBoxColumn();
            Columna_nombres = new DataGridViewTextBoxColumn();
            Columna_telefono = new DataGridViewTextBoxColumn();
            Columna_ventanilla = new DataGridViewTextBoxColumn();
            formulario_clientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // bt_cajero_editar
            // 
            bt_cajero_editar.BackColor = Color.FromArgb(38, 39, 59);
            bt_cajero_editar.BackgroundColor = Color.FromArgb(38, 39, 59);
            bt_cajero_editar.BorderColor = Color.PaleVioletRed;
            bt_cajero_editar.BorderRadius = 10;
            bt_cajero_editar.BorderSize = 0;
            bt_cajero_editar.Cursor = Cursors.Hand;
            bt_cajero_editar.FlatAppearance.BorderSize = 0;
            bt_cajero_editar.FlatStyle = FlatStyle.Flat;
            bt_cajero_editar.Font = new Font("Century Gothic", 12F);
            bt_cajero_editar.ForeColor = Color.DarkGray;
            bt_cajero_editar.Location = new Point(644, 98);
            bt_cajero_editar.Name = "bt_cajero_editar";
            bt_cajero_editar.Size = new Size(150, 40);
            bt_cajero_editar.TabIndex = 7;
            bt_cajero_editar.Text = "Editar";
            bt_cajero_editar.TextColor = Color.DarkGray;
            bt_cajero_editar.UseVisualStyleBackColor = false;
            // 
            // bt_cajero_eliminar
            // 
            bt_cajero_eliminar.BackColor = Color.FromArgb(38, 39, 59);
            bt_cajero_eliminar.BackgroundColor = Color.FromArgb(38, 39, 59);
            bt_cajero_eliminar.BorderColor = Color.PaleVioletRed;
            bt_cajero_eliminar.BorderRadius = 10;
            bt_cajero_eliminar.BorderSize = 0;
            bt_cajero_eliminar.Cursor = Cursors.Hand;
            bt_cajero_eliminar.FlatAppearance.BorderSize = 0;
            bt_cajero_eliminar.FlatStyle = FlatStyle.Flat;
            bt_cajero_eliminar.Font = new Font("Century Gothic", 12F);
            bt_cajero_eliminar.ForeColor = Color.DarkGray;
            bt_cajero_eliminar.Location = new Point(644, 52);
            bt_cajero_eliminar.Name = "bt_cajero_eliminar";
            bt_cajero_eliminar.Size = new Size(150, 40);
            bt_cajero_eliminar.TabIndex = 6;
            bt_cajero_eliminar.Text = "Eliminar";
            bt_cajero_eliminar.TextColor = Color.DarkGray;
            bt_cajero_eliminar.UseVisualStyleBackColor = false;
            // 
            // bt_cajero_agregar
            // 
            bt_cajero_agregar.BackColor = Color.FromArgb(38, 39, 59);
            bt_cajero_agregar.BackgroundColor = Color.FromArgb(38, 39, 59);
            bt_cajero_agregar.BorderColor = Color.PaleVioletRed;
            bt_cajero_agregar.BorderRadius = 10;
            bt_cajero_agregar.BorderSize = 0;
            bt_cajero_agregar.Cursor = Cursors.Hand;
            bt_cajero_agregar.FlatAppearance.BorderSize = 0;
            bt_cajero_agregar.FlatStyle = FlatStyle.Flat;
            bt_cajero_agregar.Font = new Font("Century Gothic", 12F);
            bt_cajero_agregar.ForeColor = Color.DarkGray;
            bt_cajero_agregar.Location = new Point(644, 6);
            bt_cajero_agregar.Name = "bt_cajero_agregar";
            bt_cajero_agregar.Size = new Size(150, 40);
            bt_cajero_agregar.TabIndex = 5;
            bt_cajero_agregar.Text = "Agregar";
            bt_cajero_agregar.TextColor = Color.DarkGray;
            bt_cajero_agregar.UseVisualStyleBackColor = false;
            // 
            // formulario_clientes
            // 
            formulario_clientes.BackColor = Color.FromArgb(75, 57, 94);
            formulario_clientes.Controls.Add(tb_telefono_cajeros);
            formulario_clientes.Controls.Add(bt_cajero_editar);
            formulario_clientes.Controls.Add(label7);
            formulario_clientes.Controls.Add(bt_cajero_agregar);
            formulario_clientes.Controls.Add(bt_cajero_eliminar);
            formulario_clientes.Controls.Add(label1);
            formulario_clientes.Controls.Add(label2);
            formulario_clientes.Controls.Add(label6);
            formulario_clientes.Controls.Add(label3);
            formulario_clientes.Controls.Add(tb_email_cajeros);
            formulario_clientes.Controls.Add(tb_direccion_cajeros);
            formulario_clientes.Controls.Add(tb_nombres_cajeros);
            formulario_clientes.Controls.Add(tb_dni_cajeros);
            formulario_clientes.Dock = DockStyle.Top;
            formulario_clientes.Location = new Point(0, 0);
            formulario_clientes.Name = "formulario_clientes";
            formulario_clientes.Size = new Size(840, 215);
            formulario_clientes.TabIndex = 4;
            // 
            // tb_telefono_cajeros
            // 
            tb_telefono_cajeros.BackColor = Color.FromArgb(75, 57, 94);
            tb_telefono_cajeros.BorderColor = Color.MediumSlateBlue;
            tb_telefono_cajeros.BorderFocusColor = Color.HotPink;
            tb_telefono_cajeros.BorderRadius = 10;
            tb_telefono_cajeros.BorderSize = 2;
            tb_telefono_cajeros.Font = new Font("Segoe UI", 9.5F);
            tb_telefono_cajeros.ForeColor = Color.DarkGray;
            tb_telefono_cajeros.Location = new Point(238, 158);
            tb_telefono_cajeros.Multiline = false;
            tb_telefono_cajeros.Name = "tb_telefono_cajeros";
            tb_telefono_cajeros.Padding = new Padding(10, 7, 10, 7);
            tb_telefono_cajeros.PasswordChar = false;
            tb_telefono_cajeros.PlaceholderColor = Color.DarkGray;
            tb_telefono_cajeros.PlaceholderText = "";
            tb_telefono_cajeros.ReadOnly = false;
            tb_telefono_cajeros.Size = new Size(309, 32);
            tb_telefono_cajeros.TabIndex = 12;
            tb_telefono_cajeros.Texts = "";
            tb_telefono_cajeros.UnderlinedStyle = false;
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
            // tb_email_cajeros
            // 
            tb_email_cajeros.BackColor = Color.FromArgb(75, 57, 94);
            tb_email_cajeros.BorderColor = Color.MediumSlateBlue;
            tb_email_cajeros.BorderFocusColor = Color.HotPink;
            tb_email_cajeros.BorderRadius = 10;
            tb_email_cajeros.BorderSize = 2;
            tb_email_cajeros.Font = new Font("Segoe UI", 9.5F);
            tb_email_cajeros.ForeColor = Color.DarkGray;
            tb_email_cajeros.Location = new Point(238, 120);
            tb_email_cajeros.Multiline = false;
            tb_email_cajeros.Name = "tb_email_cajeros";
            tb_email_cajeros.Padding = new Padding(10, 7, 10, 7);
            tb_email_cajeros.PasswordChar = false;
            tb_email_cajeros.PlaceholderColor = Color.DarkGray;
            tb_email_cajeros.PlaceholderText = "";
            tb_email_cajeros.ReadOnly = false;
            tb_email_cajeros.Size = new Size(309, 32);
            tb_email_cajeros.TabIndex = 11;
            tb_email_cajeros.Texts = "";
            tb_email_cajeros.UnderlinedStyle = false;
            // 
            // tb_direccion_cajeros
            // 
            tb_direccion_cajeros.BackColor = Color.FromArgb(75, 57, 94);
            tb_direccion_cajeros.BorderColor = Color.MediumSlateBlue;
            tb_direccion_cajeros.BorderFocusColor = Color.HotPink;
            tb_direccion_cajeros.BorderRadius = 10;
            tb_direccion_cajeros.BorderSize = 2;
            tb_direccion_cajeros.Font = new Font("Segoe UI", 9.5F);
            tb_direccion_cajeros.ForeColor = Color.DarkGray;
            tb_direccion_cajeros.Location = new Point(238, 82);
            tb_direccion_cajeros.Multiline = false;
            tb_direccion_cajeros.Name = "tb_direccion_cajeros";
            tb_direccion_cajeros.Padding = new Padding(10, 7, 10, 7);
            tb_direccion_cajeros.PasswordChar = false;
            tb_direccion_cajeros.PlaceholderColor = Color.DarkGray;
            tb_direccion_cajeros.PlaceholderText = "";
            tb_direccion_cajeros.ReadOnly = false;
            tb_direccion_cajeros.Size = new Size(309, 32);
            tb_direccion_cajeros.TabIndex = 10;
            tb_direccion_cajeros.Texts = "";
            tb_direccion_cajeros.UnderlinedStyle = false;
            // 
            // tb_nombres_cajeros
            // 
            tb_nombres_cajeros.BackColor = Color.FromArgb(75, 57, 94);
            tb_nombres_cajeros.BorderColor = Color.MediumSlateBlue;
            tb_nombres_cajeros.BorderFocusColor = Color.HotPink;
            tb_nombres_cajeros.BorderRadius = 10;
            tb_nombres_cajeros.BorderSize = 2;
            tb_nombres_cajeros.Font = new Font("Segoe UI", 9.5F);
            tb_nombres_cajeros.ForeColor = Color.DarkGray;
            tb_nombres_cajeros.Location = new Point(238, 44);
            tb_nombres_cajeros.Multiline = false;
            tb_nombres_cajeros.Name = "tb_nombres_cajeros";
            tb_nombres_cajeros.Padding = new Padding(10, 7, 10, 7);
            tb_nombres_cajeros.PasswordChar = false;
            tb_nombres_cajeros.PlaceholderColor = Color.DarkGray;
            tb_nombres_cajeros.PlaceholderText = "";
            tb_nombres_cajeros.ReadOnly = false;
            tb_nombres_cajeros.Size = new Size(309, 32);
            tb_nombres_cajeros.TabIndex = 9;
            tb_nombres_cajeros.Texts = "";
            tb_nombres_cajeros.UnderlinedStyle = false;
            // 
            // tb_dni_cajeros
            // 
            tb_dni_cajeros.BackColor = Color.FromArgb(75, 57, 94);
            tb_dni_cajeros.BorderColor = Color.MediumSlateBlue;
            tb_dni_cajeros.BorderFocusColor = Color.HotPink;
            tb_dni_cajeros.BorderRadius = 10;
            tb_dni_cajeros.BorderSize = 2;
            tb_dni_cajeros.Font = new Font("Segoe UI", 9.5F);
            tb_dni_cajeros.ForeColor = Color.DarkGray;
            tb_dni_cajeros.Location = new Point(238, 6);
            tb_dni_cajeros.Multiline = false;
            tb_dni_cajeros.Name = "tb_dni_cajeros";
            tb_dni_cajeros.Padding = new Padding(10, 7, 10, 7);
            tb_dni_cajeros.PasswordChar = false;
            tb_dni_cajeros.PlaceholderColor = Color.DarkGray;
            tb_dni_cajeros.PlaceholderText = "";
            tb_dni_cajeros.ReadOnly = false;
            tb_dni_cajeros.Size = new Size(309, 32);
            tb_dni_cajeros.TabIndex = 8;
            tb_dni_cajeros.Texts = "";
            tb_dni_cajeros.UnderlinedStyle = false;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(175, 77, 255);
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(175, 77, 255);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Columna_DNI, Columna_nombres, Columna_telefono, Columna_ventanilla });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(253, 202, 251);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(129, 110, 255);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(0, 215);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(840, 312);
            dataGridView1.TabIndex = 5;
            // 
            // Columna_DNI
            // 
            Columna_DNI.HeaderText = "DNI";
            Columna_DNI.Name = "Columna_DNI";
            Columna_DNI.ReadOnly = true;
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
            // Columna_ventanilla
            // 
            Columna_ventanilla.HeaderText = "Ventanilla Asignada";
            Columna_ventanilla.Name = "Columna_ventanilla";
            Columna_ventanilla.ReadOnly = true;
            // 
            // FiltroCajeros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridView1);
            Controls.Add(formulario_clientes);
            Name = "FiltroCajeros";
            Size = new Size(840, 527);
            formulario_clientes.ResumeLayout(false);
            formulario_clientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private CustomControls.RJControls.RJButton bt_cajero_editar;
        private CustomControls.RJControls.RJButton bt_cajero_eliminar;
        private CustomControls.RJControls.RJButton bt_cajero_agregar;
        private Panel formulario_clientes;
        private Label label7;
        private Label label6;
        private Label label3;
        private Label label2;
        private Label label1;
        private CustomControls.RJControls.RJTextBox tb_dni_cajeros;
        private CustomControls.RJControls.RJTextBox tb_telefono_cajeros;
        private CustomControls.RJControls.RJTextBox tb_email_cajeros;
        private CustomControls.RJControls.RJTextBox tb_direccion_cajeros;
        private CustomControls.RJControls.RJTextBox tb_nombres_cajeros;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Columna_DNI;
        private DataGridViewTextBoxColumn Columna_nombres;
        private DataGridViewTextBoxColumn Columna_telefono;
        private DataGridViewTextBoxColumn Columna_ventanilla;
    }
}
