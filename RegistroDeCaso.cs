using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace proyectoPantalla
{
    public partial class RegistroDeCaso : UserControl
    {
        SqlConnection conexion = new SqlConnection("Data Source =.; Initial Catalog = sigstec; Integrated Security = True");

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
            SelecciónDeCliente selecciónDeCliente = new SelecciónDeCliente(lClienteSeleccionado);
            selecciónDeCliente.ShowDialog();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            SelecciónDeTécnico selecciónDeTécnico = new SelecciónDeTécnico(lTecnicoSeleccionado);
            selecciónDeTécnico.ShowDialog();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
              SqlConnection conexion = new SqlConnection("Data Source=.;Initial Catalog=SIGSTEC2;Integrated Security=True");

            String consulta1 = "insert into caso(IDUSUARIO, IDTECNICO, IDCLIENTE, NUMERO, FECHA, SLA, INFORME_INICIAL, SECTOR, ESTADO, PARTE_PATH, INFORME_FINAL) values((select IDUSUARIO from USUARIO where username = 'cbVendedor.Text'), @IDTECNICO, @IDCLIENTE, @NUMERO, @FECHA, @SLA, @INFORME_INICIAL, @SECTOR, 'ABIERTO', 'No asignado', 'No Asigando'); ";


            SqlCommand comando1 = new SqlCommand(consulta1, conexion);
            comando1.Parameters.AddWithValue("@IDTECNICO", lTecnicoSeleccionado.Text);
            comando1.Parameters.AddWithValue("@IDCLIENTE", lClienteSeleccionado.Text);
            comando1.Parameters.AddWithValue("@NUMERO", lCaso.Text);
            comando1.Parameters.AddWithValue("@FECHA", lFechaActual.Text);
            comando1.Parameters.AddWithValue("@SLA", cbSLA.Text);
            comando1.Parameters.AddWithValue("@INFORME_INICIAL", tbInformeInicial.Text);
            comando1.Parameters.AddWithValue("@SECTOR", tbSector.Text);

            comando1.ExecuteNonQuery();


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

        private void LClienteSeleccionado_Click(object sender, EventArgs e)
        {
            
        }
    }
}
