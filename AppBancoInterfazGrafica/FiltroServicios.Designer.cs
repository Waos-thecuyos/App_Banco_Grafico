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
            ComboBox_servicios = new CustomControls.RJControls.RJComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            panel2 = new Panel();
            bt_editar_servicios = new CustomControls.RJControls.RJButton();
            bt_eliminar_servicios = new CustomControls.RJControls.RJButton();
            bt_agregar_servicios = new CustomControls.RJControls.RJButton();
            panel3 = new Panel();
            panel4 = new Panel();
            tb_Desc_Servicio = new CustomControls.RJControls.RJTextBox();
            tb_IDservicio = new CustomControls.RJControls.RJTextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(38, 39, 59);
            panel1.Controls.Add(ComboBox_servicios);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(840, 62);
            panel1.TabIndex = 0;
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
            ComboBox_servicios.Items.AddRange(new object[] { "Depósitos", "Retiros", "Pago de préstamos / créditos", "Transferencias", "Pago de servicios", "Pago de tributos y tasas", "Pago de tarjetas de crédito", "Consulta", "Envíos y giros", "Apertura de cuentas" });
            ComboBox_servicios.ListBackColor = Color.FromArgb(38, 39, 59);
            ComboBox_servicios.ListTextColor = Color.WhiteSmoke;
            ComboBox_servicios.Location = new Point(212, 11);
            ComboBox_servicios.MinimumSize = new Size(200, 30);
            ComboBox_servicios.Name = "ComboBox_servicios";
            ComboBox_servicios.Padding = new Padding(2);
            ComboBox_servicios.Size = new Size(288, 30);
            ComboBox_servicios.TabIndex = 1;
            ComboBox_servicios.Texts = "Seleccione";
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
            panel2.Controls.Add(bt_editar_servicios);
            panel2.Controls.Add(bt_eliminar_servicios);
            panel2.Controls.Add(bt_agregar_servicios);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(648, 62);
            panel2.Name = "panel2";
            panel2.Size = new Size(192, 465);
            panel2.TabIndex = 3;
            // 
            // bt_editar_servicios
            // 
            bt_editar_servicios.BackColor = Color.FromArgb(38, 39, 59);
            bt_editar_servicios.BackgroundColor = Color.FromArgb(38, 39, 59);
            bt_editar_servicios.BorderColor = Color.PaleVioletRed;
            bt_editar_servicios.BorderRadius = 10;
            bt_editar_servicios.BorderSize = 0;
            bt_editar_servicios.Cursor = Cursors.Hand;
            bt_editar_servicios.FlatAppearance.BorderSize = 0;
            bt_editar_servicios.FlatStyle = FlatStyle.Flat;
            bt_editar_servicios.Font = new Font("Century Gothic", 12F);
            bt_editar_servicios.ForeColor = Color.LightGray;
            bt_editar_servicios.Location = new Point(25, 111);
            bt_editar_servicios.Name = "bt_editar_servicios";
            bt_editar_servicios.Size = new Size(150, 40);
            bt_editar_servicios.TabIndex = 2;
            bt_editar_servicios.Text = "Editar";
            bt_editar_servicios.TextColor = Color.LightGray;
            bt_editar_servicios.UseVisualStyleBackColor = false;
            // 
            // bt_eliminar_servicios
            // 
            bt_eliminar_servicios.BackColor = Color.FromArgb(38, 39, 59);
            bt_eliminar_servicios.BackgroundColor = Color.FromArgb(38, 39, 59);
            bt_eliminar_servicios.BorderColor = Color.PaleVioletRed;
            bt_eliminar_servicios.BorderRadius = 10;
            bt_eliminar_servicios.BorderSize = 0;
            bt_eliminar_servicios.Cursor = Cursors.Hand;
            bt_eliminar_servicios.FlatAppearance.BorderSize = 0;
            bt_eliminar_servicios.FlatStyle = FlatStyle.Flat;
            bt_eliminar_servicios.Font = new Font("Century Gothic", 12F);
            bt_eliminar_servicios.ForeColor = Color.LightGray;
            bt_eliminar_servicios.Location = new Point(25, 65);
            bt_eliminar_servicios.Name = "bt_eliminar_servicios";
            bt_eliminar_servicios.Size = new Size(150, 40);
            bt_eliminar_servicios.TabIndex = 1;
            bt_eliminar_servicios.Text = "Eliminar";
            bt_eliminar_servicios.TextColor = Color.LightGray;
            bt_eliminar_servicios.UseVisualStyleBackColor = false;
            // 
            // bt_agregar_servicios
            // 
            bt_agregar_servicios.BackColor = Color.FromArgb(38, 39, 59);
            bt_agregar_servicios.BackgroundColor = Color.FromArgb(38, 39, 59);
            bt_agregar_servicios.BorderColor = Color.PaleVioletRed;
            bt_agregar_servicios.BorderRadius = 10;
            bt_agregar_servicios.BorderSize = 0;
            bt_agregar_servicios.Cursor = Cursors.Hand;
            bt_agregar_servicios.FlatAppearance.BorderSize = 0;
            bt_agregar_servicios.FlatStyle = FlatStyle.Flat;
            bt_agregar_servicios.Font = new Font("Century Gothic", 12F);
            bt_agregar_servicios.ForeColor = Color.LightGray;
            bt_agregar_servicios.Location = new Point(25, 19);
            bt_agregar_servicios.Name = "bt_agregar_servicios";
            bt_agregar_servicios.Size = new Size(150, 40);
            bt_agregar_servicios.TabIndex = 0;
            bt_agregar_servicios.Text = "Agregar";
            bt_agregar_servicios.TextColor = Color.LightGray;
            bt_agregar_servicios.UseVisualStyleBackColor = false;
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
            panel4.Controls.Add(tb_Desc_Servicio);
            panel4.Controls.Add(tb_IDservicio);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(label3);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 62);
            panel4.Name = "panel4";
            panel4.Size = new Size(648, 94);
            panel4.TabIndex = 5;
            // 
            // tb_Desc_Servicio
            // 
            tb_Desc_Servicio.BackColor = Color.HotPink;
            tb_Desc_Servicio.BorderColor = Color.MediumSlateBlue;
            tb_Desc_Servicio.BorderFocusColor = Color.DarkMagenta;
            tb_Desc_Servicio.BorderRadius = 0;
            tb_Desc_Servicio.BorderSize = 2;
            tb_Desc_Servicio.Font = new Font("Segoe UI", 9.5F);
            tb_Desc_Servicio.ForeColor = Color.White;
            tb_Desc_Servicio.Location = new Point(195, 46);
            tb_Desc_Servicio.Multiline = false;
            tb_Desc_Servicio.Name = "tb_Desc_Servicio";
            tb_Desc_Servicio.Padding = new Padding(10, 7, 10, 7);
            tb_Desc_Servicio.PasswordChar = false;
            tb_Desc_Servicio.PlaceholderColor = Color.Gray;
            tb_Desc_Servicio.PlaceholderText = "";
            tb_Desc_Servicio.ReadOnly = true;
            tb_Desc_Servicio.Size = new Size(385, 32);
            tb_Desc_Servicio.TabIndex = 4;
            tb_Desc_Servicio.Texts = "";
            tb_Desc_Servicio.UnderlinedStyle = true;
            // 
            // tb_IDservicio
            // 
            tb_IDservicio.BackColor = Color.HotPink;
            tb_IDservicio.BorderColor = Color.MediumSlateBlue;
            tb_IDservicio.BorderFocusColor = Color.DarkMagenta;
            tb_IDservicio.BorderRadius = 0;
            tb_IDservicio.BorderSize = 2;
            tb_IDservicio.Font = new Font("Segoe UI", 9.5F);
            tb_IDservicio.ForeColor = Color.White;
            tb_IDservicio.Location = new Point(195, 8);
            tb_IDservicio.Multiline = false;
            tb_IDservicio.Name = "tb_IDservicio";
            tb_IDservicio.Padding = new Padding(10, 7, 10, 7);
            tb_IDservicio.PasswordChar = false;
            tb_IDservicio.PlaceholderColor = Color.Gray;
            tb_IDservicio.PlaceholderText = "";
            tb_IDservicio.ReadOnly = true;
            tb_IDservicio.Size = new Size(385, 32);
            tb_IDservicio.TabIndex = 3;
            tb_IDservicio.Texts = "";
            tb_IDservicio.UnderlinedStyle = true;
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
        private CustomControls.RJControls.RJComboBox ComboBox_servicios;
        private Label label2;
        private Label label3;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private CustomControls.RJControls.RJTextBox tb_Desc_Servicio;
        private CustomControls.RJControls.RJTextBox tb_IDservicio;
        private CustomControls.RJControls.RJButton bt_editar_servicios;
        private CustomControls.RJControls.RJButton bt_eliminar_servicios;
        private CustomControls.RJControls.RJButton bt_agregar_servicios;
    }
}
