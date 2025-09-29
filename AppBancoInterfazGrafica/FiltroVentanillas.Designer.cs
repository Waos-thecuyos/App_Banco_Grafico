namespace AppBancoInterfazGrafica
{
    partial class FiltroVentanillas
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
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(94, 166);
            label1.Name = "label1";
            label1.Size = new Size(95, 15);
            label1.TabIndex = 0;
            label1.Text = "Cajero asignado:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(94, 196);
            label3.Name = "label3";
            label3.Size = new Size(124, 15);
            label3.TabIndex = 2;
            label3.Text = "Número de ventanilla:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(94, 86);
            label2.Name = "label2";
            label2.Size = new Size(105, 15);
            label2.TabIndex = 3;
            label2.Text = "Número de Ticket:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(94, 228);
            label4.Name = "label4";
            label4.Size = new Size(113, 15);
            label4.TabIndex = 4;
            label4.Text = "Detalles del servicio:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(144, 264);
            label5.Name = "label5";
            label5.Size = new Size(58, 15);
            label5.TabIndex = 5;
            label5.Text = "Prioridad:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(146, 290);
            label6.Name = "label6";
            label6.Size = new Size(93, 15);
            label6.TabIndex = 6;
            label6.Text = "Tipo de servicio:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(149, 313);
            label7.Name = "label7";
            label7.Size = new Size(100, 15);
            label7.TabIndex = 7;
            label7.Text = "Atendido (Sí/No):";
            // 
            // FiltroVentanillas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "FiltroVentanillas";
            Size = new Size(840, 527);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}
