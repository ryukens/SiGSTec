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
    public partial class VistaDeDetalles : UserControl
    {
        public VistaDeDetalles()
        {
            InitializeComponent();
            cbBuscar.SelectedIndex = 0;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            GeneraciónDelInforme ordenDeFacturación = new GeneraciónDelInforme();
            ordenDeFacturación.Show();
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
