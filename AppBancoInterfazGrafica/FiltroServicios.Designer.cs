namespace AppBancoInterfazGrafica
{
    partial class FiltroServicios
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
            rjComboBox1 = new CustomControls.RJControls.RJComboBox();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(38, 39, 59);
            panel1.Controls.Add(rjComboBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(840, 62);
            panel1.TabIndex = 0;
            // 
            // rjComboBox1
            // 
            rjComboBox1.AutoCompleteMode = AutoCompleteMode.Suggest;
            rjComboBox1.AutoCompleteSource = AutoCompleteSource.ListItems;
            rjComboBox1.BackColor = Color.FromArgb(38, 39, 59);
            rjComboBox1.BorderColor = Color.MediumSlateBlue;
            rjComboBox1.BorderSize = 2;
            rjComboBox1.DropDownStyle = ComboBoxStyle.DropDown;
            rjComboBox1.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rjComboBox1.ForeColor = Color.WhiteSmoke;
            rjComboBox1.IconColor = Color.MediumSlateBlue;
            rjComboBox1.Items.AddRange(new object[] { "Depósitos", "Retiros", "Pago de préstamos / créditos", "Transferencias", "Pago de servicios", "Pago de tributos y tasas", "Pago de tarjetas de crédito", "Consulta", "Envíos y giros", "Apertura de cuentas" });
            rjComboBox1.ListBackColor = Color.FromArgb(40, 28, 51);
            rjComboBox1.ListTextColor = Color.WhiteSmoke;
            rjComboBox1.Location = new Point(210, 11);
            rjComboBox1.MinimumSize = new Size(200, 30);
            rjComboBox1.Name = "rjComboBox1";
            rjComboBox1.Padding = new Padding(2);
            rjComboBox1.Size = new Size(288, 30);
            rjComboBox1.TabIndex = 1;
            rjComboBox1.Texts = "Seleccione";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.LightGray;
            label1.Location = new Point(53, 20);
            label1.Name = "label1";
            label1.Size = new Size(128, 21);
            label1.TabIndex = 0;
            label1.Text = "Tipo de servicio";
            // 
            // FiltroServicios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            Controls.Add(panel1);
            Name = "FiltroServicios";
            Size = new Size(840, 527);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private CustomControls.RJControls.RJComboBox rjComboBox1;
    }
}
