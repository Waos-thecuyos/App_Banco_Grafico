namespace AppBancoInterfazGrafica
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            PanelContenedor = new Panel();
            panel2 = new Panel();
            bt_clientes = new FontAwesome.Sharp.IconButton();
            bt_cajeros = new FontAwesome.Sharp.IconButton();
            bt_servicios = new FontAwesome.Sharp.IconButton();
            bt_ventanillas = new FontAwesome.Sharp.IconButton();
            bt_atenciones = new FontAwesome.Sharp.IconButton();
            bt_reportes = new FontAwesome.Sharp.IconButton();
            panel3 = new Panel();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // PanelContenedor
            // 
            PanelContenedor.Dock = DockStyle.Right;
            PanelContenedor.Location = new Point(244, 0);
            PanelContenedor.Name = "PanelContenedor";
            PanelContenedor.Size = new Size(840, 527);
            PanelContenedor.TabIndex = 7;
            // 
            // panel2
            // 
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(244, 164);
            panel2.TabIndex = 8;
            // 
            // bt_clientes
            // 
            bt_clientes.BackColor = Color.FromArgb(38, 39, 59);
            bt_clientes.FlatAppearance.BorderSize = 0;
            bt_clientes.FlatStyle = FlatStyle.Flat;
            bt_clientes.Font = new Font("Century Gothic", 14.25F);
            bt_clientes.ForeColor = Color.DarkGray;
            bt_clientes.IconChar = FontAwesome.Sharp.IconChar.Users;
            bt_clientes.IconColor = Color.DarkGray;
            bt_clientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            bt_clientes.IconSize = 30;
            bt_clientes.ImageAlign = ContentAlignment.MiddleLeft;
            bt_clientes.Location = new Point(0, 3);
            bt_clientes.Name = "bt_clientes";
            bt_clientes.Size = new Size(241, 50);
            bt_clientes.TabIndex = 0;
            bt_clientes.Text = "Clientes";
            bt_clientes.TextAlign = ContentAlignment.MiddleLeft;
            bt_clientes.TextImageRelation = TextImageRelation.ImageBeforeText;
            bt_clientes.UseVisualStyleBackColor = false;
            bt_clientes.Click += bt_clientes_Click;
            // 
            // bt_cajeros
            // 
            bt_cajeros.BackColor = Color.FromArgb(38, 39, 59);
            bt_cajeros.FlatAppearance.BorderSize = 0;
            bt_cajeros.FlatStyle = FlatStyle.Flat;
            bt_cajeros.Font = new Font("Century Gothic", 14.25F);
            bt_cajeros.ForeColor = Color.DarkGray;
            bt_cajeros.IconChar = FontAwesome.Sharp.IconChar.UserTie;
            bt_cajeros.IconColor = Color.DarkGray;
            bt_cajeros.IconFont = FontAwesome.Sharp.IconFont.Auto;
            bt_cajeros.IconSize = 30;
            bt_cajeros.ImageAlign = ContentAlignment.MiddleLeft;
            bt_cajeros.Location = new Point(0, 59);
            bt_cajeros.Name = "bt_cajeros";
            bt_cajeros.Size = new Size(241, 50);
            bt_cajeros.TabIndex = 1;
            bt_cajeros.Text = "Cajeros";
            bt_cajeros.TextAlign = ContentAlignment.MiddleLeft;
            bt_cajeros.TextImageRelation = TextImageRelation.ImageBeforeText;
            bt_cajeros.UseVisualStyleBackColor = false;
            bt_cajeros.Click += bt_cajeros_Click;
            // 
            // bt_servicios
            // 
            bt_servicios.BackColor = Color.FromArgb(38, 39, 59);
            bt_servicios.FlatAppearance.BorderSize = 0;
            bt_servicios.FlatStyle = FlatStyle.Flat;
            bt_servicios.Font = new Font("Century Gothic", 14.25F);
            bt_servicios.ForeColor = Color.DarkGray;
            bt_servicios.IconChar = FontAwesome.Sharp.IconChar.FolderOpen;
            bt_servicios.IconColor = Color.DarkGray;
            bt_servicios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            bt_servicios.IconSize = 30;
            bt_servicios.ImageAlign = ContentAlignment.MiddleLeft;
            bt_servicios.Location = new Point(0, 115);
            bt_servicios.Name = "bt_servicios";
            bt_servicios.Size = new Size(241, 50);
            bt_servicios.TabIndex = 2;
            bt_servicios.Text = "Servicios";
            bt_servicios.TextAlign = ContentAlignment.MiddleLeft;
            bt_servicios.TextImageRelation = TextImageRelation.ImageBeforeText;
            bt_servicios.UseVisualStyleBackColor = false;
            bt_servicios.Click += bt_servicios_Click;
            // 
            // bt_ventanillas
            // 
            bt_ventanillas.BackColor = Color.FromArgb(38, 39, 59);
            bt_ventanillas.FlatAppearance.BorderSize = 0;
            bt_ventanillas.FlatStyle = FlatStyle.Flat;
            bt_ventanillas.Font = new Font("Century Gothic", 14.25F);
            bt_ventanillas.ForeColor = Color.DarkGray;
            bt_ventanillas.IconChar = FontAwesome.Sharp.IconChar.Landmark;
            bt_ventanillas.IconColor = Color.DarkGray;
            bt_ventanillas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            bt_ventanillas.IconSize = 30;
            bt_ventanillas.ImageAlign = ContentAlignment.MiddleLeft;
            bt_ventanillas.Location = new Point(0, 162);
            bt_ventanillas.Name = "bt_ventanillas";
            bt_ventanillas.Size = new Size(241, 50);
            bt_ventanillas.TabIndex = 3;
            bt_ventanillas.Text = "Ventanillas";
            bt_ventanillas.TextAlign = ContentAlignment.MiddleLeft;
            bt_ventanillas.TextImageRelation = TextImageRelation.ImageBeforeText;
            bt_ventanillas.UseVisualStyleBackColor = false;
            bt_ventanillas.Click += bt_ventanillas_Click;
            // 
            // bt_atenciones
            // 
            bt_atenciones.BackColor = Color.FromArgb(38, 39, 59);
            bt_atenciones.FlatAppearance.BorderSize = 0;
            bt_atenciones.FlatStyle = FlatStyle.Flat;
            bt_atenciones.Font = new Font("Century Gothic", 14.25F);
            bt_atenciones.ForeColor = Color.DarkGray;
            bt_atenciones.IconChar = FontAwesome.Sharp.IconChar.CommentDots;
            bt_atenciones.IconColor = Color.DarkGray;
            bt_atenciones.IconFont = FontAwesome.Sharp.IconFont.Auto;
            bt_atenciones.IconSize = 30;
            bt_atenciones.ImageAlign = ContentAlignment.MiddleLeft;
            bt_atenciones.Location = new Point(0, 218);
            bt_atenciones.Name = "bt_atenciones";
            bt_atenciones.Size = new Size(241, 50);
            bt_atenciones.TabIndex = 4;
            bt_atenciones.Text = "Atenciones";
            bt_atenciones.TextAlign = ContentAlignment.MiddleLeft;
            bt_atenciones.TextImageRelation = TextImageRelation.ImageBeforeText;
            bt_atenciones.UseVisualStyleBackColor = false;
            bt_atenciones.Click += bt_atenciones_Click;
            // 
            // bt_reportes
            // 
            bt_reportes.BackColor = Color.FromArgb(38, 39, 59);
            bt_reportes.FlatAppearance.BorderSize = 0;
            bt_reportes.FlatStyle = FlatStyle.Flat;
            bt_reportes.Font = new Font("Century Gothic", 14.25F);
            bt_reportes.ForeColor = Color.DarkGray;
            bt_reportes.IconChar = FontAwesome.Sharp.IconChar.File;
            bt_reportes.IconColor = Color.DarkGray;
            bt_reportes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            bt_reportes.IconSize = 30;
            bt_reportes.ImageAlign = ContentAlignment.MiddleLeft;
            bt_reportes.Location = new Point(0, 274);
            bt_reportes.Name = "bt_reportes";
            bt_reportes.Size = new Size(241, 50);
            bt_reportes.TabIndex = 5;
            bt_reportes.Text = "Reportes";
            bt_reportes.TextAlign = ContentAlignment.MiddleLeft;
            bt_reportes.TextImageRelation = TextImageRelation.ImageBeforeText;
            bt_reportes.UseVisualStyleBackColor = false;
            bt_reportes.Click += bt_reportes_Click;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            panel3.BackColor = Color.FromArgb(38, 39, 59);
            panel3.Controls.Add(bt_reportes);
            panel3.Controls.Add(bt_clientes);
            panel3.Controls.Add(bt_atenciones);
            panel3.Controls.Add(bt_cajeros);
            panel3.Controls.Add(bt_ventanillas);
            panel3.Controls.Add(bt_servicios);
            panel3.Location = new Point(0, 154);
            panel3.Name = "panel3";
            panel3.Size = new Size(244, 373);
            panel3.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1084, 527);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(PanelContenedor);
            Name = "Form1";
            Text = "Form1";
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel PanelContenedor;
        private Panel panel2;
        private FontAwesome.Sharp.IconButton bt_clientes;
        private FontAwesome.Sharp.IconButton bt_cajeros;
        private FontAwesome.Sharp.IconButton bt_servicios;
        private FontAwesome.Sharp.IconButton bt_ventanillas;
        private FontAwesome.Sharp.IconButton bt_atenciones;
        private FontAwesome.Sharp.IconButton bt_reportes;
        private Panel panel3;
    }
}
