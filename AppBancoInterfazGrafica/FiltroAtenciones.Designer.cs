namespace AppBancoInterfazGrafica
{
    partial class FiltroAtenciones
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
            bt_buscar_atencion = new FontAwesome.Sharp.IconButton();
            bt_pend_atencion = new FontAwesome.Sharp.IconButton();
            bt_atendidos = new FontAwesome.Sharp.IconButton();
            PanelContenedor = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(bt_buscar_atencion);
            panel1.Controls.Add(bt_pend_atencion);
            panel1.Controls.Add(bt_atendidos);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(840, 72);
            panel1.TabIndex = 0;
            // 
            // bt_buscar_atencion
            // 
            bt_buscar_atencion.BackColor = Color.FromArgb(58, 59, 94);
            bt_buscar_atencion.FlatAppearance.BorderSize = 0;
            bt_buscar_atencion.FlatStyle = FlatStyle.Flat;
            bt_buscar_atencion.Font = new Font("Century Gothic", 12F);
            bt_buscar_atencion.ForeColor = Color.LightGray;
            bt_buscar_atencion.IconChar = FontAwesome.Sharp.IconChar.Search;
            bt_buscar_atencion.IconColor = Color.LightGray;
            bt_buscar_atencion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            bt_buscar_atencion.IconSize = 25;
            bt_buscar_atencion.Location = new Point(560, 0);
            bt_buscar_atencion.Name = "bt_buscar_atencion";
            bt_buscar_atencion.Size = new Size(280, 72);
            bt_buscar_atencion.TabIndex = 2;
            bt_buscar_atencion.Text = "Buscar Atención";
            bt_buscar_atencion.TextAlign = ContentAlignment.MiddleLeft;
            bt_buscar_atencion.TextImageRelation = TextImageRelation.ImageBeforeText;
            bt_buscar_atencion.UseVisualStyleBackColor = false;
            bt_buscar_atencion.Click += bt_buscar_atencion_Click;
            // 
            // bt_pend_atencion
            // 
            bt_pend_atencion.BackColor = Color.FromArgb(58, 59, 94);
            bt_pend_atencion.FlatAppearance.BorderSize = 0;
            bt_pend_atencion.FlatStyle = FlatStyle.Flat;
            bt_pend_atencion.Font = new Font("Century Gothic", 12F);
            bt_pend_atencion.ForeColor = Color.LightGray;
            bt_pend_atencion.IconChar = FontAwesome.Sharp.IconChar.X;
            bt_pend_atencion.IconColor = Color.LightGray;
            bt_pend_atencion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            bt_pend_atencion.IconSize = 25;
            bt_pend_atencion.Location = new Point(280, 0);
            bt_pend_atencion.Name = "bt_pend_atencion";
            bt_pend_atencion.Size = new Size(280, 72);
            bt_pend_atencion.TabIndex = 1;
            bt_pend_atencion.Text = "Pendientes de Atención";
            bt_pend_atencion.TextAlign = ContentAlignment.MiddleLeft;
            bt_pend_atencion.TextImageRelation = TextImageRelation.ImageBeforeText;
            bt_pend_atencion.UseVisualStyleBackColor = false;
            bt_pend_atencion.Click += bt_pend_atencion_Click;
            // 
            // bt_atendidos
            // 
            bt_atendidos.BackColor = Color.FromArgb(58, 59, 94);
            bt_atendidos.FlatAppearance.BorderSize = 0;
            bt_atendidos.FlatStyle = FlatStyle.Flat;
            bt_atendidos.Font = new Font("Century Gothic", 12F);
            bt_atendidos.ForeColor = Color.LightGray;
            bt_atendidos.IconChar = FontAwesome.Sharp.IconChar.Check;
            bt_atendidos.IconColor = Color.LightGray;
            bt_atendidos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            bt_atendidos.IconSize = 25;
            bt_atendidos.Location = new Point(0, 0);
            bt_atendidos.Name = "bt_atendidos";
            bt_atendidos.Size = new Size(280, 72);
            bt_atendidos.TabIndex = 0;
            bt_atendidos.Text = "Atendidos";
            bt_atendidos.TextAlign = ContentAlignment.MiddleLeft;
            bt_atendidos.TextImageRelation = TextImageRelation.ImageBeforeText;
            bt_atendidos.UseVisualStyleBackColor = false;
            bt_atendidos.Click += iconButton1_Click;
            // 
            // PanelContenedor
            // 
            PanelContenedor.Cursor = Cursors.Default;
            PanelContenedor.Dock = DockStyle.Fill;
            PanelContenedor.Location = new Point(0, 72);
            PanelContenedor.Margin = new Padding(3, 2, 3, 2);
            PanelContenedor.Name = "PanelContenedor";
            PanelContenedor.Size = new Size(840, 455);
            PanelContenedor.TabIndex = 1;
            // 
            // FiltroAtenciones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(PanelContenedor);
            Controls.Add(panel1);
            Cursor = Cursors.Hand;
            Name = "FiltroAtenciones";
            Size = new Size(840, 527);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private FontAwesome.Sharp.IconButton bt_pend_atencion;
        private FontAwesome.Sharp.IconButton bt_buscar_atencion;
        private FontAwesome.Sharp.IconButton bt_atendidos;
        private Panel PanelContenedor;
    }
}
