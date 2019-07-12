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
    public partial class CancelaciónDeCaso : UserControl
    {
        public CancelaciónDeCaso()
        {
            InitializeComponent();
            cbBuscar.SelectedIndex = 0;
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea cancelar este caso?", "Cancelar Caso", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MessageBox.Show("Caso Cancelado Correctamente", "Caso Cancelado");
            }
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
