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
    public partial class filtro_atenciones_atendidos : UserControl
    {
        public filtro_atenciones_atendidos()
        {
            InitializeComponent();
            // =============== DataGridView Personalizado ===================
            dataGridView1.MinimumSize = new Size(400, 0);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AllowUserToResizeColumns = false; // Bloquea cambio de ancho de columnas
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;

            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.GridColor = Color.DarkGray; // O el color que quieras
            dataGridView1.BorderStyle = BorderStyle.None;

            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridView1.AdvancedColumnHeadersBorderStyle.Left = DataGridViewAdvancedCellBorderStyle.None;
            dataGridView1.AdvancedColumnHeadersBorderStyle.Right = DataGridViewAdvancedCellBorderStyle.None;
            dataGridView1.AdvancedColumnHeadersBorderStyle.Top = DataGridViewAdvancedCellBorderStyle.None;
            dataGridView1.AdvancedColumnHeadersBorderStyle.Bottom = DataGridViewAdvancedCellBorderStyle.Single;

            dataGridView1.RowHeadersVisible = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false; // opcional, evita seleccionar varias filas a la vez
        }
    }
}
