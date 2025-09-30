namespace AppBancoInterfazGrafica
{
    partial class FiltroReportes
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
            panel1 = new Panel();
            ComboBox_reportes = new CustomControls.RJControls.RJComboBox();
            panel2 = new Panel();
            bt_exportar = new FontAwesome.Sharp.IconButton();
            bt_importar = new FontAwesome.Sharp.IconButton();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.LightGray;
            label1.Location = new Point(53, 20);
            label1.Name = "label1";
            label1.Size = new Size(138, 21);
            label1.TabIndex = 0;
            label1.Text = "Tipo de Reporte:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(38, 39, 59);
            panel1.Controls.Add(ComboBox_reportes);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(840, 62);
            panel1.TabIndex = 1;
            // 
            // ComboBox_reportes
            // 
            ComboBox_reportes.BackColor = Color.FromArgb(38, 39, 59);
            ComboBox_reportes.BorderColor = Color.MediumSlateBlue;
            ComboBox_reportes.BorderSize = 2;
            ComboBox_reportes.DropDownStyle = ComboBoxStyle.DropDown;
            ComboBox_reportes.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ComboBox_reportes.ForeColor = Color.Silver;
            ComboBox_reportes.IconColor = Color.MediumSlateBlue;
            ComboBox_reportes.Items.AddRange(new object[] { "Clientes", "Cajeros", "Servicios", "Ventanillas", "Atenciones" });
            ComboBox_reportes.ListBackColor = Color.FromArgb(38, 39, 59);
            ComboBox_reportes.ListTextColor = Color.WhiteSmoke;
            ComboBox_reportes.Location = new Point(212, 11);
            ComboBox_reportes.Margin = new Padding(2);
            ComboBox_reportes.MinimumSize = new Size(200, 30);
            ComboBox_reportes.Name = "ComboBox_reportes";
            ComboBox_reportes.Padding = new Padding(2);
            ComboBox_reportes.Size = new Size(288, 30);
            ComboBox_reportes.TabIndex = 1;
            ComboBox_reportes.Texts = "Seleccione";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(75, 57, 94);
            panel2.Controls.Add(bt_exportar);
            panel2.Controls.Add(bt_importar);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(651, 62);
            panel2.Name = "panel2";
            panel2.Size = new Size(189, 465);
            panel2.TabIndex = 2;
            // 
            // bt_exportar
            // 
            bt_exportar.BackColor = Color.FromArgb(38, 39, 59);
            bt_exportar.Cursor = Cursors.Hand;
            bt_exportar.FlatAppearance.BorderColor = Color.HotPink;
            bt_exportar.FlatStyle = FlatStyle.Flat;
            bt_exportar.Font = new Font("Century Gothic", 11.25F);
            bt_exportar.ForeColor = Color.HotPink;
            bt_exportar.IconChar = FontAwesome.Sharp.IconChar.ArrowRightFromFile;
            bt_exportar.IconColor = Color.HotPink;
            bt_exportar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            bt_exportar.IconSize = 30;
            bt_exportar.Location = new Point(16, 56);
            bt_exportar.Name = "bt_exportar";
            bt_exportar.Size = new Size(159, 44);
            bt_exportar.TabIndex = 1;
            bt_exportar.Text = "Exportar datos";
            bt_exportar.TextAlign = ContentAlignment.MiddleLeft;
            bt_exportar.TextImageRelation = TextImageRelation.ImageBeforeText;
            bt_exportar.UseVisualStyleBackColor = false;
            // 
            // bt_importar
            // 
            bt_importar.BackColor = Color.FromArgb(38, 39, 59);
            bt_importar.Cursor = Cursors.Hand;
            bt_importar.FlatAppearance.BorderColor = Color.HotPink;
            bt_importar.FlatStyle = FlatStyle.Flat;
            bt_importar.Font = new Font("Century Gothic", 11.25F);
            bt_importar.ForeColor = Color.HotPink;
            bt_importar.IconChar = FontAwesome.Sharp.IconChar.ArrowDown;
            bt_importar.IconColor = Color.HotPink;
            bt_importar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            bt_importar.IconSize = 30;
            bt_importar.Location = new Point(16, 6);
            bt_importar.Name = "bt_importar";
            bt_importar.Size = new Size(159, 44);
            bt_importar.TabIndex = 0;
            bt_importar.Text = "Importar datos";
            bt_importar.TextAlign = ContentAlignment.MiddleLeft;
            bt_importar.TextImageRelation = TextImageRelation.ImageBeforeText;
            bt_importar.UseVisualStyleBackColor = false;
            // 
            // FiltroReportes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FiltroReportes";
            Size = new Size(840, 527);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private CustomControls.RJControls.RJComboBox ComboBox_reportes;
        private Panel panel2;
        private FontAwesome.Sharp.IconButton bt_exportar;
        private FontAwesome.Sharp.IconButton bt_importar;
    }
}
