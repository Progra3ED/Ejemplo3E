using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo3E
{
    public partial class FormCuenta : Form
    {
        Cuenta cuenta = new Cuenta();

        public FormCuenta()
        {
            InitializeComponent();
        }

        private void buttonIngresar_Click(object sender, EventArgs e)
        {
            cuenta.NumeroCuenta = textBoxNumeroCuenta.Text;
            cuenta.DPI = textBoxDpi.Text;
            cuenta.Saldo = Convert.ToDouble(textBoxSaldo.Text);

        }

        private void buttonMostrar_Click(object sender, EventArgs e)
        {
            labelNumeroCuenta.Text = cuenta.NumeroCuenta;
            labelDpi.Text = cuenta.DPI;
            labelSaldo.Text = cuenta.Saldo.ToString();
        }
    }
}
