namespace AppBancoInterfazGrafica
{
    partial class filtro_atenciones_atendidos
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
            dataGridView1 = new DataGridView();
            Columna_nombres = new DataGridViewTextBoxColumn();
            Columna_servicio = new DataGridViewTextBoxColumn();
            Columna_tiempo = new DataGridViewTextBoxColumn();
            Columna_prioridad = new DataGridViewTextBoxColumn();
            Columna_atendido = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
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
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(840, 444);
            dataGridView1.TabIndex = 6;
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
            // filtro_atenciones_atendidos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridView1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "filtro_atenciones_atendidos";
            Size = new Size(840, 444);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Columna_nombres;
        private DataGridViewTextBoxColumn Columna_servicio;
        private DataGridViewTextBoxColumn Columna_tiempo;
        private DataGridViewTextBoxColumn Columna_prioridad;
        private DataGridViewTextBoxColumn Columna_atendido;
    }
}
