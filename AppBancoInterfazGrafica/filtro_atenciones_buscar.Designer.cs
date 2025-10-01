namespace AppBancoInterfazGrafica
{
    partial class filtro_atenciones_buscar
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
            label1 = new Label();
            bt_buscar = new FontAwesome.Sharp.IconButton();
            tb_num_ticket = new CustomControls.RJControls.RJTextBox();
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            Columna_nombres = new DataGridViewTextBoxColumn();
            Columna_servicio = new DataGridViewTextBoxColumn();
            Columna_tiempo = new DataGridViewTextBoxColumn();
            Columna_prioridad = new DataGridViewTextBoxColumn();
            Columna_atendido = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.MediumSlateBlue;
            label1.Location = new Point(61, 32);
            label1.Name = "label1";
            label1.Size = new Size(226, 21);
            label1.TabIndex = 0;
            label1.Text = "Ingrese el número de ticket:";
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
            bt_buscar.Location = new Point(621, 13);
            bt_buscar.Name = "bt_buscar";
            bt_buscar.Size = new Size(101, 47);
            bt_buscar.TabIndex = 7;
            bt_buscar.Text = "Buscar";
            bt_buscar.TextAlign = ContentAlignment.MiddleLeft;
            bt_buscar.TextImageRelation = TextImageRelation.ImageBeforeText;
            bt_buscar.UseVisualStyleBackColor = true;
            // 
            // tb_num_ticket
            // 
            tb_num_ticket.BackColor = SystemColors.Control;
            tb_num_ticket.BorderColor = Color.MediumSlateBlue;
            tb_num_ticket.BorderFocusColor = Color.HotPink;
            tb_num_ticket.BorderRadius = 10;
            tb_num_ticket.BorderSize = 2;
            tb_num_ticket.Font = new Font("Segoe UI", 9.5F);
            tb_num_ticket.ForeColor = Color.MediumSlateBlue;
            tb_num_ticket.Location = new Point(293, 24);
            tb_num_ticket.Multiline = false;
            tb_num_ticket.Name = "tb_num_ticket";
            tb_num_ticket.Padding = new Padding(10, 7, 10, 7);
            tb_num_ticket.PasswordChar = false;
            tb_num_ticket.PlaceholderColor = Color.MediumPurple;
            tb_num_ticket.PlaceholderText = "";
            tb_num_ticket.ReadOnly = false;
            tb_num_ticket.Size = new Size(304, 32);
            tb_num_ticket.TabIndex = 6;
            tb_num_ticket.Texts = "";
            tb_num_ticket.UnderlinedStyle = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(bt_buscar);
            panel1.Controls.Add(tb_num_ticket);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(840, 81);
            panel1.TabIndex = 8;
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
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Columna_nombres, Columna_servicio, Columna_tiempo, Columna_prioridad, Columna_atendido });
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
            dataGridView1.Location = new Point(0, 81);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(840, 374);
            dataGridView1.TabIndex = 9;
            // 
            // Columna_nombres
            // 
            Columna_nombres.HeaderText = "Nombre";
            Columna_nombres.Name = "Columna_nombres";
            Columna_nombres.ReadOnly = true;
            // 
            // Columna_servicio
            // 
            Columna_servicio.HeaderText = "Tipo de Servicio";
            Columna_servicio.Name = "Columna_servicio";
            Columna_servicio.ReadOnly = true;
            // 
            // Columna_tiempo
            // 
            Columna_tiempo.HeaderText = "Tiempo de Atención";
            Columna_tiempo.Name = "Columna_tiempo";
            Columna_tiempo.ReadOnly = true;
            // 
            // Columna_prioridad
            // 
            Columna_prioridad.HeaderText = "Prioridad";
            Columna_prioridad.Name = "Columna_prioridad";
            Columna_prioridad.ReadOnly = true;
            // 
            // Columna_atendido
            // 
            Columna_atendido.HeaderText = "Estado de atención";
            Columna_atendido.Name = "Columna_atendido";
            Columna_atendido.ReadOnly = true;
            // 
            // filtro_atenciones_buscar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "filtro_atenciones_buscar";
            Size = new Size(840, 455);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private FontAwesome.Sharp.IconButton bt_buscar;
        private CustomControls.RJControls.RJTextBox tb_num_ticket;
        private Panel panel1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Columna_nombres;
        private DataGridViewTextBoxColumn Columna_servicio;
        private DataGridViewTextBoxColumn Columna_tiempo;
        private DataGridViewTextBoxColumn Columna_prioridad;
        private DataGridViewTextBoxColumn Columna_atendido;
    }
}
