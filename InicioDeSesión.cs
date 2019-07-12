using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Windows.Forms;

namespace proyectoPantalla
{
    public partial class InicioDeSesión : Form
    {
        public InicioDeSesión()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            PantallaPrincipal pantallaPrincipal = new PantallaPrincipal(this);
            pantallaPrincipal.Show();
        }

        private void InicioDeSesión_Load(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        

    }
}
