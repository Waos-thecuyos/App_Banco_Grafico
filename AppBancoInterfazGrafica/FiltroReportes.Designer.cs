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
            rjComboBox1 = new CustomControls.RJControls.RJComboBox();
            panel2 = new Panel();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            iconButton1 = new FontAwesome.Sharp.IconButton();
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
            panel1.Controls.Add(rjComboBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(840, 62);
            panel1.TabIndex = 1;
            // 
            // rjComboBox1
            // 
            rjComboBox1.BackColor = Color.FromArgb(38, 39, 59);
            rjComboBox1.BorderColor = Color.MediumSlateBlue;
            rjComboBox1.BorderSize = 2;
            rjComboBox1.DropDownStyle = ComboBoxStyle.DropDown;
            rjComboBox1.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rjComboBox1.ForeColor = Color.Silver;
            rjComboBox1.IconColor = Color.MediumSlateBlue;
            rjComboBox1.Items.AddRange(new object[] { "Clientes", "Cajeros", "Servicios", "Ventanillas", "Atenciones" });
            rjComboBox1.ListBackColor = Color.FromArgb(38, 39, 59);
            rjComboBox1.ListTextColor = Color.WhiteSmoke;
            rjComboBox1.Location = new Point(212, 11);
            rjComboBox1.Margin = new Padding(2);
            rjComboBox1.MinimumSize = new Size(200, 30);
            rjComboBox1.Name = "rjComboBox1";
            rjComboBox1.Padding = new Padding(2);
            rjComboBox1.Size = new Size(288, 30);
            rjComboBox1.TabIndex = 1;
            rjComboBox1.Texts = "Seleccione";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(75, 57, 94);
            panel2.Controls.Add(iconButton2);
            panel2.Controls.Add(iconButton1);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(651, 62);
            panel2.Name = "panel2";
            panel2.Size = new Size(189, 465);
            panel2.TabIndex = 2;
            // 
            // iconButton2
            // 
            iconButton2.BackColor = Color.FromArgb(38, 39, 59);
            iconButton2.FlatAppearance.BorderColor = Color.HotPink;
            iconButton2.FlatStyle = FlatStyle.Flat;
            iconButton2.Font = new Font("Century Gothic", 11.25F);
            iconButton2.ForeColor = Color.HotPink;
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.ArrowRightFromFile;
            iconButton2.IconColor = Color.HotPink;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.IconSize = 30;
            iconButton2.Location = new Point(16, 56);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(159, 44);
            iconButton2.TabIndex = 1;
            iconButton2.Text = "Exportar datos";
            iconButton2.TextAlign = ContentAlignment.MiddleLeft;
            iconButton2.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton2.UseVisualStyleBackColor = false;
            // 
            // iconButton1
            // 
            iconButton1.BackColor = Color.FromArgb(38, 39, 59);
            iconButton1.FlatAppearance.BorderColor = Color.HotPink;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.Font = new Font("Century Gothic", 11.25F);
            iconButton1.ForeColor = Color.HotPink;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.ArrowDown;
            iconButton1.IconColor = Color.HotPink;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 30;
            iconButton1.Location = new Point(16, 6);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(159, 44);
            iconButton1.TabIndex = 0;
            iconButton1.Text = "Importar datos";
            iconButton1.TextAlign = ContentAlignment.MiddleLeft;
            iconButton1.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton1.UseVisualStyleBackColor = false;
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
        private CustomControls.RJControls.RJComboBox rjComboBox1;
        private Panel panel2;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}
