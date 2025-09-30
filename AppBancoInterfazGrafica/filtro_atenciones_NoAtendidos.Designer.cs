namespace AppBancoInterfazGrafica
{
    partial class filtro_atenciones_NoAtendidos
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
            rjButton1 = new CustomControls.RJControls.RJButton();
            ComboBox_ventanilla = new CustomControls.RJControls.RJComboBox();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(rjButton1);
            panel1.Controls.Add(ComboBox_ventanilla);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(840, 62);
            panel1.TabIndex = 0;
            // 
            // rjButton1
            // 
            rjButton1.BackColor = SystemColors.Control;
            rjButton1.BackgroundColor = SystemColors.Control;
            rjButton1.BorderColor = Color.MediumSlateBlue;
            rjButton1.BorderRadius = 20;
            rjButton1.BorderSize = 2;
            rjButton1.Cursor = Cursors.Hand;
            rjButton1.FlatAppearance.BorderSize = 0;
            rjButton1.FlatStyle = FlatStyle.Flat;
            rjButton1.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rjButton1.ForeColor = Color.MediumSlateBlue;
            rjButton1.Location = new Point(594, 11);
            rjButton1.Name = "rjButton1";
            rjButton1.Size = new Size(167, 40);
            rjButton1.TabIndex = 3;
            rjButton1.Text = "Atender";
            rjButton1.TextColor = Color.MediumSlateBlue;
            rjButton1.UseVisualStyleBackColor = false;
            // 
            // ComboBox_ventanilla
            // 
            ComboBox_ventanilla.BackColor = SystemColors.Control;
            ComboBox_ventanilla.BorderColor = Color.MediumSlateBlue;
            ComboBox_ventanilla.BorderSize = 2;
            ComboBox_ventanilla.DropDownStyle = ComboBoxStyle.DropDown;
            ComboBox_ventanilla.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ComboBox_ventanilla.ForeColor = Color.MediumSlateBlue;
            ComboBox_ventanilla.IconColor = Color.MediumSlateBlue;
            ComboBox_ventanilla.Items.AddRange(new object[] { "Ventanilla Preferencial", "Ventanilla N° 1", "Ventanilla N° 2", "Ventanilla N° 3" });
            ComboBox_ventanilla.ListBackColor = Color.LightGray;
            ComboBox_ventanilla.ListTextColor = Color.MediumSlateBlue;
            ComboBox_ventanilla.Location = new Point(262, 16);
            ComboBox_ventanilla.Margin = new Padding(2);
            ComboBox_ventanilla.MinimumSize = new Size(200, 30);
            ComboBox_ventanilla.Name = "ComboBox_ventanilla";
            ComboBox_ventanilla.Padding = new Padding(2);
            ComboBox_ventanilla.Size = new Size(288, 30);
            ComboBox_ventanilla.TabIndex = 2;
            ComboBox_ventanilla.Texts = "Seleccione";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.MediumSlateBlue;
            label1.Location = new Point(132, 25);
            label1.Name = "label1";
            label1.Size = new Size(93, 21);
            label1.TabIndex = 0;
            label1.Text = "Ventanilla:";
            // 
            // filtro_atenciones_NoAtendidos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "filtro_atenciones_NoAtendidos";
            Size = new Size(840, 455);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private CustomControls.RJControls.RJComboBox ComboBox_ventanilla;
        private CustomControls.RJControls.RJButton rjButton1;
    }
}
