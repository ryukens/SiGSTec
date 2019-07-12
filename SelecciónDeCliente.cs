using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyectoPantalla
{
    public partial class SelecciónDeCliente : Form
    {
        public SelecciónDeCliente(Label lClienteSeleccionado)
        {
            InitializeComponent();
            cbBuscar.SelectedIndex = 0;
            TopMost = true;
            this.lClienteSeleccionado = lClienteSeleccionado;
        }

        Label lClienteSeleccionado;

        private void FormBusquedaDeCliente_Load(object sender, EventArgs e)
        {

        }

        private void TableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //dataGridView1.SelectedRows.ToString();
            lClienteSeleccionado.Text = "MAMARREremix";
            this.Dispose();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void DgvSeleccionar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DgvSeleccionar_SelectionChanged(object sender, EventArgs e)
        {
            

        }
    }
}
