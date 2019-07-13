using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyectoPantalla
{
    public partial class AsignaciónDeProductos : Form
    {
        public int cont = 0;
        public DisminuciónDeProducto ddp;
        public DataGridView dgvddp;
        public AsignaciónDeProductos(DataGridView dgvdismdeprod)
        {
            InitializeComponent();
            this.dgvddp = dgvdismdeprod;
            cbBuscar.SelectedIndex = 0;
            String consulta = "select codigo, descripcion, cantidad, precio from producto order by codigo; ";
            SqlDataAdapter sda = new SqlDataAdapter(consulta, conexion);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgvAsignar.DataSource = dt;
            dgvAsignar.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvAsignar.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvAsignar.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvAsignar.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvAsignar.Columns[0].HeaderText = "Código";
            dgvAsignar.Columns[1].HeaderText = "Descripción";
            dgvAsignar.Columns[2].HeaderText = "Cantidad";
            dgvAsignar.Columns[3].HeaderText = "Precio";

        }


        SqlConnection conexion = new SqlConnection("Data Source=.;Initial Catalog=SIGSTEC;Integrated Security=True");
        public AsignaciónDeProductos()
        {
            InitializeComponent();
            cbBuscar.SelectedIndex = 0;
            String consulta = "select codigo, descripcion, cantidad, precio from producto order by codigo; ";
            SqlDataAdapter sda = new SqlDataAdapter(consulta, conexion);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgvAsignar.DataSource = dt;
            dgvAsignar.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvAsignar.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvAsignar.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvAsignar.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvAsignar.Columns[0].HeaderText = "Código";
            dgvAsignar.Columns[1].HeaderText = "Descripción";
            dgvAsignar.Columns[2].HeaderText = "Cantidad";
            dgvAsignar.Columns[3].HeaderText = "Precio";

        }

        private void AsignaciónDeProductos_Load(object sender, EventArgs e)
        {

        }

        private void TbBuscar_TextChanged(object sender, EventArgs e)
        {
            if (cbBuscar.SelectedIndex == 0)
            {

                String consulta = "select codigo, descripcion, cantidad, precio from producto where codigo like '%@parametro%' order by codigo; ";
                SqlDataAdapter sda = new SqlDataAdapter(consulta, conexion);
               // sda.SelectCommand.Parameters.Add("")
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dgvAsignar.DataSource = dt;
                dgvAsignar.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dgvAsignar.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvAsignar.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dgvAsignar.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dgvAsignar.Columns[0].HeaderText = "Código";
                dgvAsignar.Columns[1].HeaderText = "Descripción";
                dgvAsignar.Columns[2].HeaderText = "Cantidad";
                dgvAsignar.Columns[3].HeaderText = "Precio";
            }
            else
            {
                String consulta = "select codigo, descripcion, cantidad, precio from producto where descripcion like '%" + tbBuscar.Text + "%' order by codigo; ";
                SqlDataAdapter sda = new SqlDataAdapter(consulta, conexion);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dgvAsignar.DataSource = dt;
                dgvAsignar.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dgvAsignar.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvAsignar.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dgvAsignar.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dgvAsignar.Columns[0].HeaderText = "Código";
                dgvAsignar.Columns[1].HeaderText = "Descripción";
                dgvAsignar.Columns[2].HeaderText = "Cantidad";
                dgvAsignar.Columns[3].HeaderText = "Precio";
            }
        }

        private void BAsignar_Click(object sender, EventArgs e)
        {
            dgvddp.Rows.Add();
            dgvddp.Rows[cont].Cells[0].Value = dgvAsignar.CurrentRow.Cells[0].Value;
            dgvddp.Rows[cont].Cells[1].Value = dgvAsignar.CurrentRow.Cells[1].Value;
            dgvddp.Rows[cont].Cells[2].Value = nudCantidad.Value;
            cont++;
        }
    }
}
