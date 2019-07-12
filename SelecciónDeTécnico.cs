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
    public partial class SelecciónDeTécnico : Form
    {
        public SelecciónDeTécnico(Label lTecnicoSeleccionado)
        {
            InitializeComponent();
            TopMost = true;
            this.lTecnicoSeleccionado = lTecnicoSeleccionado;
        }

        Label lTecnicoSeleccionado;

        private void BusquedaDeTécnico_Load(object sender, EventArgs e)
        {

        }

        private void BSeleccionar_Click(object sender, EventArgs e)
        {
            lTecnicoSeleccionado.Text = "MAMARRE";
            this.Dispose();

        }
    }
}
