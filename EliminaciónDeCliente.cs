using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyectoPantalla
{
    public partial class EliminaciónDeCliente : UserControl
    {
        public EliminaciónDeCliente()
        {
            InitializeComponent();
            cbBuscar.SelectedIndex = 0;
        }

        private void EliminarCliente_Load(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click_1(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            
        }

        private void Button2_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea eliminar este cliente?", "Eliminar Cliente", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MessageBox.Show("Cliente Eliminado Correctamente", "Cliente Eliminado");
            }
        }
    }
}
