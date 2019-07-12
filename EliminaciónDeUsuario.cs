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
    public partial class EliminaciónDeUsuario : UserControl
    {
        public EliminaciónDeUsuario()
        {
            InitializeComponent();
            cbBuscar.SelectedIndex = 0;
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea eliminar este usuario?", "Eliminar Usuario", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MessageBox.Show("Usuario Eliminado Correctamente", "Usuario Eliminado");
            }
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
