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
    public partial class RegistroDeCaso : UserControl
    {
        public RegistroDeCaso()
        {
            InitializeComponent();
            timer1.Enabled = true;
            
        }

        private void FlowLayoutPanel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FlowLayoutPanel12_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void FlowLayoutPanel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {

        }

        private void Label10_Click(object sender, EventArgs e)
        {

        }

        private void Button3_Click_1(object sender, EventArgs e)
        {
            SelecciónDeCliente selecciónDeCliente = new SelecciónDeCliente();
            selecciónDeCliente.ShowDialog();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            SelecciónDeTécnico selecciónDeTécnico = new SelecciónDeTécnico(lTecnicoSeleccionado);
            selecciónDeTécnico.ShowDialog();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
                      
            MessageBox.Show("Caso Registrado Correctamente", "Caso Registrado");
            
        }

        private void Label11_Click(object sender, EventArgs e)
        {
            
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {

        }

        private void TableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void Timer1_Tick_1(object sender, EventArgs e)
        {
            lFechaActual.Text = DateTime.Now.ToString();
        }

        private void Label12_Click(object sender, EventArgs e)
        {
            
        }
    }
}
