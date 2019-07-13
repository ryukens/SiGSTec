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
        TabControl tabControl;
        TabPage tabInicio;
        public CancelaciónDeCaso(TabControl tabControl, TabPage tabInicio)
        {
            InitializeComponent();
            cbBuscar.SelectedIndex = 0;
            this.tabControl = tabControl;
            this.tabInicio = tabInicio;
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

        private void CbBuscar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            tabControl.SelectTab(tabInicio);
        }
    }
}
