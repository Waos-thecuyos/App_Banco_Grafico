using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Media3D;

namespace AppBancoInterfazGrafica
{
    public partial class FiltroReportes : UserControl
    {
        public FiltroReportes()
        {
            InitializeComponent();

            reporte_AtencionesServicio filtroDefault = new reporte_AtencionesServicio();
            AplicarFiltros(filtroDefault);

            // Si usas ComboBox: selecciona "Clientes" por defecto
            ComboBox_reportes.SelectedIndex = 0;

        }


        private void AplicarFiltros(UserControl filtro)
        {
            filtro.Dock = DockStyle.Fill;
            panel3.Controls.Clear();
            panel3.Controls.Add(filtro);
            filtro.BringToFront();

        }

        private void bt_ver_reporte_Click(object sender, EventArgs e)
        {
            UserControl filtro = null;

            switch (ComboBox_reportes.SelectedItem.ToString())
            {
                case "Atenciones realizadas por servicio":
                    filtro = new reporte_AtencionesServicio();
                    break;
                case "Atenciones realizadas por cajero":
                    filtro = new reporte_AtencionesCajero();
                    break;
                case "Totales recaudados (Retiros / Depósitos)":
                    filtro = new reporte_recaudado();
                    break;
            }


            if (filtro != null)
                AplicarFiltros(filtro);

        }
    }
}
