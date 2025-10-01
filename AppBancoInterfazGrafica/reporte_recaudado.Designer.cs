namespace AppBancoInterfazGrafica
{
    partial class reporte_recaudado
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
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            rjTextBox1 = new CustomControls.RJControls.RJTextBox();
            rjTextBox2 = new CustomControls.RJControls.RJTextBox();
            Columna_atencion = new DataGridViewTextBoxColumn();
            Columna_servicio = new DataGridViewTextBoxColumn();
            Columna_monto = new DataGridViewTextBoxColumn();
            Columna_fecha = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGridView1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(651, 465);
            panel1.TabIndex = 0;
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
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Columna_atencion, Columna_servicio, Columna_monto, Columna_fecha });
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
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(651, 465);
            dataGridView1.TabIndex = 8;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(75, 57, 94);
            panel2.Controls.Add(rjTextBox2);
            panel2.Controls.Add(rjTextBox1);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 306);
            panel2.Name = "panel2";
            panel2.Size = new Size(651, 159);
            panel2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F);
            label1.ForeColor = Color.LightGray;
            label1.Location = new Point(19, 24);
            label1.Name = "label1";
            label1.Size = new Size(85, 21);
            label1.TabIndex = 0;
            label1.Text = "Resumen:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F);
            label2.ForeColor = Color.LightGray;
            label2.Location = new Point(78, 56);
            label2.Name = "label2";
            label2.Size = new Size(89, 21);
            label2.TabIndex = 1;
            label2.Text = "Depósitos:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F);
            label3.ForeColor = Color.LightGray;
            label3.Location = new Point(78, 89);
            label3.Name = "label3";
            label3.Size = new Size(65, 21);
            label3.TabIndex = 2;
            label3.Text = "Retiros:";
            // 
            // rjTextBox1
            // 
            rjTextBox1.BackColor = Color.FromArgb(75, 57, 94);
            rjTextBox1.BorderColor = Color.MediumOrchid;
            rjTextBox1.BorderFocusColor = Color.HotPink;
            rjTextBox1.BorderRadius = 0;
            rjTextBox1.BorderSize = 2;
            rjTextBox1.Font = new Font("Segoe UI", 9.5F);
            rjTextBox1.ForeColor = Color.DarkGray;
            rjTextBox1.Location = new Point(183, 45);
            rjTextBox1.Multiline = false;
            rjTextBox1.Name = "rjTextBox1";
            rjTextBox1.Padding = new Padding(10, 7, 10, 7);
            rjTextBox1.PasswordChar = false;
            rjTextBox1.PlaceholderColor = Color.DarkGray;
            rjTextBox1.PlaceholderText = "";
            rjTextBox1.ReadOnly = false;
            rjTextBox1.Size = new Size(175, 32);
            rjTextBox1.TabIndex = 3;
            rjTextBox1.Texts = "";
            rjTextBox1.UnderlinedStyle = true;
            // 
            // rjTextBox2
            // 
            rjTextBox2.BackColor = Color.FromArgb(75, 57, 94);
            rjTextBox2.BorderColor = Color.MediumOrchid;
            rjTextBox2.BorderFocusColor = Color.HotPink;
            rjTextBox2.BorderRadius = 0;
            rjTextBox2.BorderSize = 2;
            rjTextBox2.Font = new Font("Segoe UI", 9.5F);
            rjTextBox2.ForeColor = Color.DarkGray;
            rjTextBox2.Location = new Point(183, 78);
            rjTextBox2.Multiline = false;
            rjTextBox2.Name = "rjTextBox2";
            rjTextBox2.Padding = new Padding(10, 7, 10, 7);
            rjTextBox2.PasswordChar = false;
            rjTextBox2.PlaceholderColor = Color.DarkGray;
            rjTextBox2.PlaceholderText = "";
            rjTextBox2.ReadOnly = false;
            rjTextBox2.Size = new Size(175, 32);
            rjTextBox2.TabIndex = 4;
            rjTextBox2.Texts = "";
            rjTextBox2.UnderlinedStyle = true;
            // 
            // Columna_atencion
            // 
            Columna_atencion.HeaderText = "Atención";
            Columna_atencion.Name = "Columna_atencion";
            Columna_atencion.ReadOnly = true;
            // 
            // Columna_servicio
            // 
            Columna_servicio.HeaderText = "Tipo de Servicio";
            Columna_servicio.Name = "Columna_servicio";
            Columna_servicio.ReadOnly = true;
            // 
            // Columna_monto
            // 
            Columna_monto.HeaderText = "Monto de Dinero";
            Columna_monto.Name = "Columna_monto";
            Columna_monto.ReadOnly = true;
            // 
            // Columna_fecha
            // 
            Columna_fecha.HeaderText = "Fecha";
            Columna_fecha.Name = "Columna_fecha";
            Columna_fecha.ReadOnly = true;
            // 
            // reporte_recaudado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "reporte_recaudado";
            Size = new Size(651, 465);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private DataGridView dataGridView1;
        private Label label2;
        private Label label1;
        private CustomControls.RJControls.RJTextBox rjTextBox2;
        private CustomControls.RJControls.RJTextBox rjTextBox1;
        private Label label3;
        private DataGridViewTextBoxColumn Columna_atencion;
        private DataGridViewTextBoxColumn Columna_servicio;
        private DataGridViewTextBoxColumn Columna_monto;
        private DataGridViewTextBoxColumn Columna_fecha;
    }
}
