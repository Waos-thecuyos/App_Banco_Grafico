using AppVentanillasBanco;
using FontAwesome.Sharp;

namespace AppBancoInterfazGrafica
{
    public partial class Form1 : Form
    {
        private CLista clientes = new CLista();
        private CLista cajeros = new CLista();
        private CLista servicios = new CLista();
        private CLista atenciones = new CLista();
        private cColaPrioridad cola = new cColaPrioridad();
        private int ultimoTicket = 0;




        // Atributos de personalización
        private IconButton botonSeleccionado;
        private Panel BordeIzquierdo;
        public Form1()
        {
            InitializeComponent();



            this.MinimumSize = new Size(1100, 566);
            

            BordeIzquierdo = new Panel();
            BordeIzquierdo.Size = new Size(2, 50);
            panel3.Controls.Add(BordeIzquierdo);
            ActivarBoton(bt_clientes);
            FiltroClientes fp = new FiltroClientes(clientes, atenciones, cola, ref ultimoTicket);
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

                BordeIzquierdo.BackColor = Color.Pink;
                BordeIzquierdo.Location = new Point(0,botonSeleccionado.Location.Y);
                BordeIzquierdo.Visible = true;
                BordeIzquierdo.BringToFront();
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


        private void bt_clientes_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender);
            FiltroClientes fp = new FiltroClientes(clientes, atenciones, cola, ref ultimoTicket);
            AplicarFiltros(fp);
        }

        private void bt_cajeros_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender);
            FiltroCajeros fp = new FiltroCajeros();
            AplicarFiltros(fp);
        }

        private void bt_servicios_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender);
            FiltroServicios fp = new FiltroServicios();
            AplicarFiltros(fp);
        }

        private void bt_ventanillas_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender);
            FiltroVentanillas fp = new FiltroVentanillas();
            AplicarFiltros(fp);
        }

        private void bt_atenciones_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender);
            FiltroAtenciones fp = new FiltroAtenciones();
            AplicarFiltros(fp);
        }

        private void bt_reportes_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender);
            FiltroReportes fp = new FiltroReportes();
            AplicarFiltros(fp);
        }
    }
}
