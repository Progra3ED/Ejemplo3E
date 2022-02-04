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
    public partial class Form1 : Form
    {
        Persona persona = new Persona();

        public Form1()
        {
            InitializeComponent();
        }

        
        private void buttonIngresar_Click(object sender, EventArgs e)
        {
                        
            persona.Dpi = textBoxDpi.Text;
            persona.Nombre = textBoxNombre.Text;
            persona.Apellido = textBoxApellido.Text;
            persona.FechaNacimiento = dateTimePickerFechaNacimiento.Value;            
                        
        }

        private void buttonMostrar_Click(object sender, EventArgs e)
        {
            
            labelDpi.Text = persona.Dpi;
            labelNombre.Text = persona.Nombre;
            labelApellido.Text = persona.Apellido;
            labelFechaNacimiento.Text = persona.FechaNacimiento.ToString();
            labelEdad.Text = persona.edad().ToString();
            

        }

        private void buttonCuentas_Click(object sender, EventArgs e)
        {
            FormCuenta formularioCuenta = new FormCuenta();

            formularioCuenta.Show();


        }
    }
}
