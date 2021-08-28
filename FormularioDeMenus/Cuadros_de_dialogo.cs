using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormularioDeMenus
{
    public partial class Cuadros_de_dialogo : Form
    {
        public Cuadros_de_dialogo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Probando el botón ACEPTAR", "Ejemplo Mensaje Aceptar usted selecciono la opcion aceptar");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Probando Mensaje con los botones ACEPTAR y CANCELAR", "Ejemplo Mensaje OKCanccel", MessageBoxButtons.OKCancel);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Probando Mensaje con los botones SI, NO y CANCELAR", "Ejemplo Mensaje YesNoCanccel", MessageBoxButtons.YesNoCancel);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Probando Mensaje informativo con boton Aceptar", "Ejemplo Mensaje Exclamation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Probando Mensaje interrogativo", "Ejemplo Mensaje Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Probando Mensaje informativo", "Titulo Ventana", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Cuadros_de_dialogo_Load(object sender, EventArgs e)
        {

        }
    }
}
