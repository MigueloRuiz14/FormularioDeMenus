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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void aYUDAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ayuda_sobre_celulares AYUDA = new Ayuda_sobre_celulares();

            AYUDA.ShowDialog();
        }

        private void opción1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Opcion1m1 OPCION1M1 = new Opcion1m1();

            OPCION1M1.ShowDialog();
        }

        private void opción2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Opcion2m1 OPCION2M1 = new Opcion2m1();

            OPCION2M1.ShowDialog();
        }

        private void opción3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Opcion3m1 OPCION3M1 = new Opcion3m1();

            OPCION3M1.ShowDialog();
        }

        private void opción4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Opcion4m1 OPCION4M1 = new Opcion4m1();

            OPCION4M1.ShowDialog();
        }

        private void opción1ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Opcion1m2 OPCION1M2 = new Opcion1m2();

            OPCION1M2.ShowDialog();
        }

        private void opción2ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Opcion2m2 OPCION2M2 = new Opcion2m2();

            OPCION2M2.ShowDialog();
        }

        private void opción3ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Opcion3m2 OPCION3M2 = new Opcion3m2();

            OPCION3M2.ShowDialog();
        }

        private void opción4ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Opcion4m2 OPCION4M2 = new Opcion4m2();

            OPCION4M2.ShowDialog();
        }

        private void opción1ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Opcion1m3 OPCION1M3 = new Opcion1m3();

            OPCION1M3.ShowDialog();
        }

        private void opción2ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Opcion2m3 OPCION2M3 = new Opcion2m3();

            OPCION2M3.ShowDialog();
        }

        private void opción3ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Opcion3m3 OPCION3M3 = new Opcion3m3();

            OPCION3M3.ShowDialog();
        }

        private void opción4ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Opcion4m3 OPCION4M3 = new Opcion4m3();

            OPCION4M3.ShowDialog();
        }

        private void opción1ToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Opcion1m4 OPCION1M4 = new Opcion1m4();

            OPCION1M4.ShowDialog();
        }

        private void opción2ToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Opcion2m4 OPCION2M4 = new Opcion2m4();

            OPCION2M4.ShowDialog();
        }

        private void opción3ToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Opcion3m4 OPCION3M4 = new Opcion3m4();

            OPCION3M4.ShowDialog();
        }

        private void opción4ToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Opcion4m4 OPCION4M4 = new Opcion4m4();

            OPCION4M4.ShowDialog();
        }

        private void opción1ToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Opcion1m5 OPCION1M5 = new Opcion1m5();

            OPCION1M5.ShowDialog();
        }

        private void opción2ToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Opcion2m5 OPCION2M5 = new Opcion2m5();

            OPCION2M5.ShowDialog();
        }

        private void opción3ToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Opcion3m5 OPCION3M5 = new Opcion3m5();

            OPCION3M5.ShowDialog();
        }

        private void opción4ToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Opcion4m5 OPCION4M5 = new Opcion4m5();

            OPCION4M5.ShowDialog();
        }

        private void cUADROSDEDIÁLOGOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cuadros_de_dialogo CUADRO = new Cuadros_de_dialogo();

            CUADRO.ShowDialog();
        }

        private void aCERCADEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Telefonos_celulares ACERCADE = new Telefonos_celulares();

            ACERCADE.ShowDialog();
        }
    }
}
