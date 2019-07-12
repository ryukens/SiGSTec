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
    public partial class EliminaciónDeTécnico : UserControl
    {
        public EliminaciónDeTécnico()
        {
            InitializeComponent();
            cbBuscar.SelectedIndex = 0;
        }

        private void TableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea eliminar este técnico?", "Eliminar Técnico", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MessageBox.Show("Técnico Eliminado Correctamente","Técnico Eliminado");
            }
        }

        private void CbBuscar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
