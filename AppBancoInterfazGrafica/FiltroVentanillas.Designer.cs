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
            bt_buscar = new FontAwesome.Sharp.IconButton();
            tb_num_ticket = new CustomControls.RJControls.RJTextBox();
            tb_num_ventanilla = new CustomControls.RJControls.RJTextBox();
            tb_cajero = new CustomControls.RJControls.RJTextBox();
            tb_tipo_servicio = new CustomControls.RJControls.RJTextBox();
            tb_prioridad = new CustomControls.RJControls.RJTextBox();
            tb_recibio_atencion = new CustomControls.RJControls.RJTextBox();
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
            panel1.Controls.Add(bt_buscar);
            panel1.Controls.Add(tb_num_ticket);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(840, 68);
            panel1.TabIndex = 8;
            // 
            // bt_buscar
            // 
            bt_buscar.Cursor = Cursors.Hand;
            bt_buscar.FlatAppearance.BorderColor = Color.HotPink;
            bt_buscar.FlatAppearance.BorderSize = 2;
            bt_buscar.FlatStyle = FlatStyle.Flat;
            bt_buscar.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bt_buscar.ForeColor = Color.HotPink;
            bt_buscar.IconChar = FontAwesome.Sharp.IconChar.Search;
            bt_buscar.IconColor = Color.HotPink;
            bt_buscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            bt_buscar.IconSize = 27;
            bt_buscar.Location = new Point(545, 12);
            bt_buscar.Name = "bt_buscar";
            bt_buscar.Size = new Size(103, 47);
            bt_buscar.TabIndex = 5;
            bt_buscar.Text = "Buscar";
            bt_buscar.TextAlign = ContentAlignment.MiddleLeft;
            bt_buscar.TextImageRelation = TextImageRelation.ImageBeforeText;
            bt_buscar.UseVisualStyleBackColor = true;
            // 
            // tb_num_ticket
            // 
            tb_num_ticket.BackColor = Color.FromArgb(58, 59, 94);
            tb_num_ticket.BorderColor = Color.MediumSlateBlue;
            tb_num_ticket.BorderFocusColor = Color.HotPink;
            tb_num_ticket.BorderRadius = 10;
            tb_num_ticket.BorderSize = 2;
            tb_num_ticket.Font = new Font("Segoe UI", 9.5F);
            tb_num_ticket.ForeColor = Color.LightGray;
            tb_num_ticket.Location = new Point(199, 15);
            tb_num_ticket.Multiline = false;
            tb_num_ticket.Name = "tb_num_ticket";
            tb_num_ticket.Padding = new Padding(10, 7, 10, 7);
            tb_num_ticket.PasswordChar = false;
            tb_num_ticket.PlaceholderColor = Color.DarkGray;
            tb_num_ticket.PlaceholderText = "";
            tb_num_ticket.ReadOnly = false;
            tb_num_ticket.Size = new Size(304, 32);
            tb_num_ticket.TabIndex = 4;
            tb_num_ticket.Texts = "";
            tb_num_ticket.UnderlinedStyle = false;
            // 
            // tb_num_ventanilla
            // 
            tb_num_ventanilla.BackColor = Color.FromArgb(75, 57, 94);
            tb_num_ventanilla.BorderColor = Color.HotPink;
            tb_num_ventanilla.BorderFocusColor = Color.HotPink;
            tb_num_ventanilla.BorderRadius = 0;
            tb_num_ventanilla.BorderSize = 2;
            tb_num_ventanilla.Font = new Font("Century Gothic", 9.75F);
            tb_num_ventanilla.ForeColor = Color.DarkGray;
            tb_num_ventanilla.Location = new Point(219, 14);
            tb_num_ventanilla.Multiline = false;
            tb_num_ventanilla.Name = "tb_num_ventanilla";
            tb_num_ventanilla.Padding = new Padding(10, 7, 10, 7);
            tb_num_ventanilla.PasswordChar = false;
            tb_num_ventanilla.PlaceholderColor = Color.DarkGray;
            tb_num_ventanilla.PlaceholderText = "";
            tb_num_ventanilla.ReadOnly = true;
            tb_num_ventanilla.Size = new Size(163, 32);
            tb_num_ventanilla.TabIndex = 9;
            tb_num_ventanilla.Texts = "";
            tb_num_ventanilla.UnderlinedStyle = true;
            // 
            // tb_cajero
            // 
            tb_cajero.BackColor = Color.FromArgb(75, 57, 94);
            tb_cajero.BorderColor = Color.HotPink;
            tb_cajero.BorderFocusColor = Color.HotPink;
            tb_cajero.BorderRadius = 0;
            tb_cajero.BorderSize = 2;
            tb_cajero.Font = new Font("Century Gothic", 9.75F);
            tb_cajero.ForeColor = Color.DarkGray;
            tb_cajero.Location = new Point(591, 14);
            tb_cajero.Multiline = false;
            tb_cajero.Name = "tb_cajero";
            tb_cajero.Padding = new Padding(10, 7, 10, 7);
            tb_cajero.PasswordChar = false;
            tb_cajero.PlaceholderColor = Color.DarkGray;
            tb_cajero.PlaceholderText = "";
            tb_cajero.ReadOnly = true;
            tb_cajero.Size = new Size(163, 32);
            tb_cajero.TabIndex = 10;
            tb_cajero.Texts = "";
            tb_cajero.UnderlinedStyle = true;
            // 
            // tb_tipo_servicio
            // 
            tb_tipo_servicio.BackColor = Color.FromArgb(75, 57, 94);
            tb_tipo_servicio.BorderColor = Color.HotPink;
            tb_tipo_servicio.BorderFocusColor = Color.HotPink;
            tb_tipo_servicio.BorderRadius = 0;
            tb_tipo_servicio.BorderSize = 2;
            tb_tipo_servicio.Font = new Font("Century Gothic", 9.75F);
            tb_tipo_servicio.ForeColor = Color.DarkGray;
            tb_tipo_servicio.Location = new Point(284, 87);
            tb_tipo_servicio.Multiline = false;
            tb_tipo_servicio.Name = "tb_tipo_servicio";
            tb_tipo_servicio.Padding = new Padding(10, 7, 10, 7);
            tb_tipo_servicio.PasswordChar = false;
            tb_tipo_servicio.PlaceholderColor = Color.DarkGray;
            tb_tipo_servicio.PlaceholderText = "";
            tb_tipo_servicio.ReadOnly = true;
            tb_tipo_servicio.Size = new Size(229, 32);
            tb_tipo_servicio.TabIndex = 11;
            tb_tipo_servicio.Texts = "";
            tb_tipo_servicio.UnderlinedStyle = true;
            // 
            // tb_prioridad
            // 
            tb_prioridad.BackColor = Color.FromArgb(75, 57, 94);
            tb_prioridad.BorderColor = Color.HotPink;
            tb_prioridad.BorderFocusColor = Color.HotPink;
            tb_prioridad.BorderRadius = 0;
            tb_prioridad.BorderSize = 2;
            tb_prioridad.Font = new Font("Century Gothic", 9.75F);
            tb_prioridad.ForeColor = Color.DarkGray;
            tb_prioridad.Location = new Point(284, 125);
            tb_prioridad.Multiline = false;
            tb_prioridad.Name = "tb_prioridad";
            tb_prioridad.Padding = new Padding(10, 7, 10, 7);
            tb_prioridad.PasswordChar = false;
            tb_prioridad.PlaceholderColor = Color.DarkGray;
            tb_prioridad.PlaceholderText = "";
            tb_prioridad.ReadOnly = true;
            tb_prioridad.Size = new Size(229, 32);
            tb_prioridad.TabIndex = 12;
            tb_prioridad.Texts = "";
            tb_prioridad.UnderlinedStyle = true;
            // 
            // tb_recibio_atencion
            // 
            tb_recibio_atencion.BackColor = Color.FromArgb(75, 57, 94);
            tb_recibio_atencion.BorderColor = Color.HotPink;
            tb_recibio_atencion.BorderFocusColor = Color.HotPink;
            tb_recibio_atencion.BorderRadius = 0;
            tb_recibio_atencion.BorderSize = 2;
            tb_recibio_atencion.Font = new Font("Century Gothic", 9.75F);
            tb_recibio_atencion.ForeColor = Color.DarkGray;
            tb_recibio_atencion.Location = new Point(284, 163);
            tb_recibio_atencion.Multiline = false;
            tb_recibio_atencion.Name = "tb_recibio_atencion";
            tb_recibio_atencion.Padding = new Padding(10, 7, 10, 7);
            tb_recibio_atencion.PasswordChar = false;
            tb_recibio_atencion.PlaceholderColor = Color.DarkGray;
            tb_recibio_atencion.PlaceholderText = "";
            tb_recibio_atencion.ReadOnly = true;
            tb_recibio_atencion.Size = new Size(229, 32);
            tb_recibio_atencion.TabIndex = 13;
            tb_recibio_atencion.Texts = "";
            tb_recibio_atencion.UnderlinedStyle = true;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(75, 57, 94);
            panel2.Controls.Add(tb_num_ventanilla);
            panel2.Controls.Add(tb_recibio_atencion);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(tb_prioridad);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(tb_tipo_servicio);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(tb_cajero);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 68);
            panel2.Name = "panel2";
            panel2.Size = new Size(840, 231);
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
        private CustomControls.RJControls.RJTextBox tb_num_ticket;
        private CustomControls.RJControls.RJTextBox tb_num_ventanilla;
        private CustomControls.RJControls.RJTextBox tb_cajero;
        private CustomControls.RJControls.RJTextBox tb_tipo_servicio;
        private CustomControls.RJControls.RJTextBox tb_prioridad;
        private CustomControls.RJControls.RJTextBox tb_recibio_atencion;
        private Panel panel2;
        private FontAwesome.Sharp.IconButton bt_buscar;
    }
}
