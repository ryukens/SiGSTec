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
    public partial class MuestraDeCliente : UserControl
    {
        public MuestraDeCliente()
        {
            InitializeComponent();
            cbBuscar.SelectedIndex = 0;
        }
    }
}
