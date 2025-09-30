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
            iconButton1 = new FontAwesome.Sharp.IconButton();
            PanelContenedor = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(bt_buscar_atencion);
            panel1.Controls.Add(bt_pend_atencion);
            panel1.Controls.Add(iconButton1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(840, 70);
            panel1.TabIndex = 0;
            // 
            // bt_buscar_atencion
            // 
            bt_buscar_atencion.BackColor = Color.FromArgb(58, 59, 94);
            bt_buscar_atencion.FlatAppearance.BorderSize = 0;
            bt_buscar_atencion.FlatStyle = FlatStyle.Flat;
            bt_buscar_atencion.Font = new Font("Century Gothic", 12F);
            bt_buscar_atencion.ForeColor = Color.LightGray;
            bt_buscar_atencion.IconChar = FontAwesome.Sharp.IconChar.None;
            bt_buscar_atencion.IconColor = Color.Black;
            bt_buscar_atencion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            bt_buscar_atencion.Location = new Point(409, 0);
            bt_buscar_atencion.Name = "bt_buscar_atencion";
            bt_buscar_atencion.Size = new Size(197, 67);
            bt_buscar_atencion.TabIndex = 2;
            bt_buscar_atencion.Text = "Buscar Atención";
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
            bt_pend_atencion.IconChar = FontAwesome.Sharp.IconChar.None;
            bt_pend_atencion.IconColor = Color.Black;
            bt_pend_atencion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            bt_pend_atencion.Location = new Point(206, 0);
            bt_pend_atencion.Name = "bt_pend_atencion";
            bt_pend_atencion.Size = new Size(205, 67);
            bt_pend_atencion.TabIndex = 1;
            bt_pend_atencion.Text = "Pendientes de Atención";
            bt_pend_atencion.UseVisualStyleBackColor = false;
            bt_pend_atencion.Click += bt_pend_atencion_Click;
            // 
            // iconButton1
            // 
            iconButton1.BackColor = Color.FromArgb(58, 59, 94);
            iconButton1.FlatAppearance.BorderSize = 0;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.Font = new Font("Century Gothic", 12F);
            iconButton1.ForeColor = Color.LightGray;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.Location = new Point(0, 0);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(211, 67);
            iconButton1.TabIndex = 0;
            iconButton1.Text = "Atendidos";
            iconButton1.UseVisualStyleBackColor = false;
            iconButton1.Click += iconButton1_Click;
            // 
            // PanelContenedor
            // 
            PanelContenedor.Dock = DockStyle.Fill;
            PanelContenedor.Location = new Point(0, 70);
            PanelContenedor.Margin = new Padding(3, 2, 3, 2);
            PanelContenedor.Name = "PanelContenedor";
            PanelContenedor.Size = new Size(840, 457);
            PanelContenedor.TabIndex = 1;
            // 
            // FiltroAtenciones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(PanelContenedor);
            Controls.Add(panel1);
            Name = "FiltroAtenciones";
            Size = new Size(840, 527);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private FontAwesome.Sharp.IconButton bt_pend_atencion;
        private FontAwesome.Sharp.IconButton bt_buscar_atencion;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Panel PanelContenedor;
    }
}
