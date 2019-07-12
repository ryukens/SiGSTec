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
    public partial class GeneraciónDeInforme : UserControl
    {
        public GeneraciónDeInforme()
        {
            InitializeComponent();
        }

        private void TableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            ReporteGenerado reporteGenerado = new ReporteGenerado();
            reporteGenerado.Show();
        }
    }
}
