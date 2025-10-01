using AppVentanillasBanco;
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
    public partial class FiltroClientes : UserControl
    {

        private CLista clientes;
        private CLista atenciones;
        private cColaPrioridad cola;
        private int ultimoTicket;

        public FiltroClientes(CLista clientesRef, CLista atencionesRef, cColaPrioridad colaRef, ref int ticketRef)
        {
            InitializeComponent();
            this.clientes = clientesRef;
            this.atenciones = atencionesRef;
            this.cola = colaRef;
            this.ultimoTicket = ticketRef;

            // =============== DataGridView Personalizado ===================
            tabla_clientes.MinimumSize = new Size(400, 0);
            tabla_clientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tabla_clientes.AllowUserToResizeColumns = false; // Bloquea cambio de ancho de columnas
            tabla_clientes.AllowUserToResizeRows = false;
            tabla_clientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            tabla_clientes.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;

            tabla_clientes.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            tabla_clientes.GridColor = Color.DarkGray; // O el color que quieras
            tabla_clientes.BorderStyle = BorderStyle.None;

            tabla_clientes.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            tabla_clientes.AdvancedColumnHeadersBorderStyle.Left = DataGridViewAdvancedCellBorderStyle.None;
            tabla_clientes.AdvancedColumnHeadersBorderStyle.Right = DataGridViewAdvancedCellBorderStyle.None;
            tabla_clientes.AdvancedColumnHeadersBorderStyle.Top = DataGridViewAdvancedCellBorderStyle.None;
            tabla_clientes.AdvancedColumnHeadersBorderStyle.Bottom = DataGridViewAdvancedCellBorderStyle.Single;

            tabla_clientes.RowHeadersVisible = false;
            tabla_clientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tabla_clientes.MultiSelect = false; // opcional, evita seleccionar varias filas a la vez




            foreach (DataGridViewColumn col in tabla_clientes.Columns)
            {
                col.MinimumWidth = 30;
            }
        }

        private void bt_cliente_agregar_Click(object sender, EventArgs e)
        {
            if (!cValidaciones.ValidarDNI(tb_dni.Text) ||
                !cValidaciones.ValidarEmail(tb_email.Text) ||
                !cValidaciones.EsNumero(tb_monto.Text) ||
                !cValidaciones.ValidarFecha(tb_nacimiento.Text) ||
                !cValidaciones.ValidarStringNoVacio(tb_nombres.Text) ||
                !cValidaciones.ValidarStringNoVacio(tb_telefono.Text))
            {
                MessageBox.Show("Hay datos inválidos o vacíos", "Advertencia",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                // Crear objeto cliente
                cCliente nuevoCliente = new cCliente(
                    tb_dni.Text,
                    tb_nombres.Text,
                    tb_nacimiento.Text,
                    CheckBox_discapacidad.Checked ? "si" : "no", 
                    CheckBox_ninhos.Checked ? "si" : "no",       
                    tb_email.Text,
                    tb_telefono.Text,
                    tb_monto.Text
                );
                string fechaHora = DateTime.Now.ToString();
                int ticket = GenerarTicket();

                clientes.Agregar(nuevoCliente);
                var atencion = new cAtenciones(fechaHora, tb_dni.Text, "", "", "", "");
                atencion.Leer();
                atenciones.Agregar(atencion);
                cola.Encolar(atencion, 1);


                MessageBox.Show($"Cliente agregado correctamente, su Nro de Ticket es:{ticket} ", "Éxito",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarTextBox(this);
                CheckBox_discapacidad.Checked = false;
                CheckBox_ninhos.Checked = false;

            }
        }

        private void LimpiarTextBox(Control control)
        {
            foreach (Control c in control.Controls)
            {
                if (c is TextBox)
                    ((TextBox)c).Clear();

                // Si hay contenedores dentro (paneles, groupbox, etc.), se vuelve a llamar recursivamente
                if (c.HasChildren)
                    LimpiarTextBox(c);
            }
        }




        private int GenerarTicket()
        {
            ultimoTicket++;
            return ultimoTicket;
        }

        


    }
}
