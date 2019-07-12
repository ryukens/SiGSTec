using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace proyectoPantalla
{
    public partial class RegistroDeCliente : UserControl
    {
        public RegistroDeCliente()
        {
            InitializeComponent();
            cbSLA.SelectedIndex = 0;

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //bool flagVacios = ValidarCamposVacios();
            //bool flagCedula = VerificaCedula(tbCedula.Text);
            //bool flagRUC = RucPersonaNatural(tbCedula.Text);
            //bool flagCorreo = ComprobarFormatoEmail(tbCorreo.Text);
            //if (flagVacios)
            //{
            //    if (flagCorreo)
            //    {
            //        if (flagCedula || flagRUC)
            //        {
            //            MessageBox.Show("Cliente Registrado Correctamente", "Cliente Registrado");
            //        }
            //    }
            //}


        }


        private void RbPersona_CheckedChanged(object sender, EventArgs e)
        {
            tbCuenta.Text = "N/A";
        }

        private void RbEmpresa_CheckedChanged(object sender, EventArgs e)
        {
            tbCuenta.Enabled = rbEmpresa.Checked;
            tbCuenta.Text = "";
        }

        private void TbCedula_TextChanged(object sender, EventArgs e)
        {

        }

        public bool VerificaCedula(string ced)
        {
            int isNumeric;
            var total = 0;
            const int tamanoLongitudCedula = 10;
            int[] coeficientes = { 2, 1, 2, 1, 2, 1, 2, 1, 2 };
            const int numeroProvincia = 24;
            const int tercerDigito = 6;

            if (int.TryParse(ced, out isNumeric) && ced.Length == tamanoLongitudCedula)
            {
                var provincia = Convert.ToInt32(string.Concat(ced[0], ced[1], string.Empty));
                var digitoTres = Convert.ToInt32(ced[2] + string.Empty);
                if ((provincia > 0 && provincia <= numeroProvincia) && digitoTres < tercerDigito)
                {
                    var digitoVerificadorRecibido = Convert.ToInt32(ced[9] + string.Empty);
                    for (var k = 0; k < coeficientes.Length; k++)
                    {
                        var valor = Convert.ToInt32(coeficientes[k] + string.Empty) * Convert.ToInt32(ced[k] + string.Empty);
                        total = valor >= 10 ? total + (valor - 9) : total + valor;
                    }
                    var digitoVerificadorObtenido = total >= 10 ? (total % 10) != 0 ? 10 - (total % 10) : (total % 10) : total;
                    return digitoVerificadorObtenido == digitoVerificadorRecibido;
                }
                return false;
            }
            return false;
        }

        public bool RucPersonaNatural(string ruc)
        {
            long isNumeric;
            const int tamanoLongitudRuc = 13;
            const string establecimiento = "001";
            if (long.TryParse(ruc, out isNumeric) && ruc.Length.Equals(tamanoLongitudRuc))
            {
                var numeroProvincia = Convert.ToInt32(string.Concat(ruc[0] + string.Empty, ruc[1] + string.Empty));
                var personaNatural = Convert.ToInt32(ruc[2] + string.Empty);
                if ((numeroProvincia >= 1 && numeroProvincia <= 24) && (personaNatural >= 0 && personaNatural < 6))
                {
                    return ruc.Substring(10, 3) == establecimiento && VerificaCedula(ruc.Substring(0, 10));
                }
                return false;
            }
            return false;
        }

        public static bool ComprobarFormatoEmail(string sEmailAComprobar)
        {
            String sFormato;
            sFormato = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(sEmailAComprobar, sFormato))
            {
                if (Regex.Replace(sEmailAComprobar, sFormato, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public bool ValidarCamposVacios()
        {
            bool flag = true;
            List<TextBox> lista = GenerarLista();
            foreach (TextBox text in lista)
            {
                if (text.Text.Equals(""))
                {
                    flag = false;
                    Console.WriteLine(text.Name + " - falg interna: " + flag);
                }
            }
            Console.WriteLine("flag final: " + flag);
            Console.WriteLine("----------------------------------------");
            return flag;
        }



        public List<TextBox> GenerarLista()
        {
            var al = new List<TextBox>();
            al.Add(tbNombre);
            al.Add(tbCuenta);
            al.Add(tbCedula);
            al.Add(tbCorreo);
            al.Add(tbCelular1);
            al.Add(tbTelefono1);
            al.Add(tbNombreCont);
            al.Add(tbDescripcion);
            //int tam = al.Count;
            return al;
        }

        
        private void TbCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                //    MessageBox.Show("Solo se permiten números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void TbCorreo_TextChanged(object sender, EventArgs e)
        {
            if (ComprobarFormatoEmail(tbCorreo.Text))
            {
                errorProvider1.SetError(tbCorreo, null);
            }
            else
            {
                errorProvider1.SetError(tbCorreo, "Ingrese correo electrónico correctamente");
            }
        }

        private void TbCorreo_KeyUp(object sender, KeyEventArgs e)
        {
            bool flag = ComprobarFormatoEmail(tbCorreo.Text);
            if (flag)
            {
                Console.WriteLine("CORREO BUENO");
                tbCorreo.ForeColor = Color.Green;

            }
            else
            {
                tbCorreo.ForeColor = Color.Red;
            }


        }

        private void TbTelf1_TextChanged(object sender, EventArgs e)
        {



        }

        private void TbTelf1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
     //           MessageBox.Show("Solo se permiten números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void TbTelf2_TextChanged(object sender, EventArgs e)
        {

        }

        private void TbTelf2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
   //             MessageBox.Show("Solo se permiten números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void TbCel1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TbCel1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
 //               MessageBox.Show("Solo se permiten números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void TbCel2_TextChanged(object sender, EventArgs e)
        {

        }

        private void TbCel2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
            //    MessageBox.Show("Solo se permiten números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void TbCedula_KeyUp(object sender, KeyEventArgs e)
        {
            if (VerificaCedula(tbCedula.Text) || RucPersonaNatural(tbCedula.Text))
            {
                errorProvider1.SetError(tbCedula, null);
                tbCedula.ForeColor = Color.Green;

            }
            else
            {
                errorProvider1.SetError(tbCedula, "Ingrese cédula o RUC correctamente");
                tbCedula.ForeColor = Color.Red;
            }
        }

        private void Panel10_Paint(object sender, PaintEventArgs e)
        {
                    }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void TbNombreCont_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
