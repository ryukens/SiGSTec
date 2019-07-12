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
    public partial class ModificaciónDeTécnico : UserControl
    {
        public ModificaciónDeTécnico()
        {
            InitializeComponent();
            cbBuscar.SelectedIndex = 0;
        }

        private void TableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button2_Click_1(object sender, EventArgs e)
        {
            CambioDeDatosTécnico cambioDeDatosTécnico = new CambioDeDatosTécnico();
            cambioDeDatosTécnico.ShowDialog();
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
