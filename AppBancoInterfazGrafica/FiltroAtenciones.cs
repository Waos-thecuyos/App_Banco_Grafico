using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppBancoInterfazGrafica
{
    public partial class FiltroAtenciones : UserControl
    {
        private IconButton botonSeleccionado;
        private Panel BordeInferior;
        public FiltroAtenciones()
        {
            InitializeComponent();
            BordeInferior = new Panel();
            BordeInferior.Size = new Size(280, 4);
            panel1.Controls.Add(BordeInferior);
            ActivarBoton(bt_atendidos);
            filtro_atenciones_atendidos fp = new filtro_atenciones_atendidos();
            AplicarFiltros(fp);
        }

        // **** Control de Pestañas ****
        private void ActivarBoton(Object boton)
        {
            if (boton != null)
            {
                DeshabilitarBoton();
                botonSeleccionado = (IconButton)boton;
                botonSeleccionado.ForeColor = Color.Pink;
                botonSeleccionado.IconColor = Color.Pink;

                BordeInferior.BackColor = Color.Pink;
                BordeInferior.Location = new Point(botonSeleccionado.Location.X, 69);
                BordeInferior.Visible = true;
                BordeInferior.BringToFront();
            }
        }

        private void DeshabilitarBoton()
        {
            if (botonSeleccionado != null)
            {
                botonSeleccionado.ForeColor = Color.DarkGray;
                botonSeleccionado.IconColor = Color.DarkGray;

            }
        }

        private void AplicarFiltros(UserControl filtro)
        {
            filtro.Dock = DockStyle.Fill;
            PanelContenedor.Controls.Clear();
            PanelContenedor.Controls.Add(filtro);
            filtro.BringToFront();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender);
            filtro_atenciones_atendidos fp = new filtro_atenciones_atendidos();
            AplicarFiltros(fp);
        }

        private void bt_pend_atencion_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender);
            filtro_atenciones_NoAtendidos fp = new filtro_atenciones_NoAtendidos();
            AplicarFiltros(fp);
        }

        private void bt_buscar_atencion_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender);
            filtro_atenciones_buscar fp = new filtro_atenciones_buscar();
            AplicarFiltros(fp);
        }
    }
}
