using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LB_Resultado.Text = "";
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void acercaDeToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Ejemplo para menu");
        }

        private void sumaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(TX_A.Text);

            double b = Convert.ToDouble(TX_B.Text);

            double r = a + b;

            LB_Resultado.Text = r.ToString();


            SLB_Valores.Text = "A = "+a.ToString()+ "B" + b.ToString();
            SBL_Operacion.Text = "Suma";
            SBL_Resultado.Text = "R = " +r.ToString();

        }

        private void restaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(TX_A.Text);

            double b = Convert.ToDouble(TX_B.Text);

            double r = a - b;

            LB_Resultado.Text = r.ToString();

            SLB_Valores.Text = "A = " + a.ToString() + "B" + b.ToString();
            SBL_Operacion.Text = "Resta";
            SBL_Resultado.Text = "R = " + r.ToString();
        }

        private void multiplicacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(TX_A.Text);

            double b = Convert.ToDouble(TX_B.Text);

            double r = a * b;

            LB_Resultado.Text = r.ToString();

            SLB_Valores.Text = "A = " + a.ToString() + "B" + b.ToString();
            SBL_Operacion.Text = "Multiplicacion";
            SBL_Resultado.Text = "R = " + r.ToString();
        }

        private void divisonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(TX_A.Text);

            double b = Convert.ToDouble(TX_B.Text);

            double r = a / b;

            LB_Resultado.Text = r.ToString();

            SLB_Valores.Text = "A = " + a.ToString() + "B" + b.ToString();
            SBL_Operacion.Text = "Division";
            SBL_Resultado.Text = "R = " + r.ToString();
        }

        private void habilitarToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            TX_A.Enabled = habilitarToolStripMenuItem.Checked;
            TX_B.Enabled = habilitarToolStripMenuItem.Checked;

        }

        private void contextMenuStrip2_Opening(object sender, CancelEventArgs e)
        {

        }

        private void borrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TX_A.Text = "0";


        }

        private void aleatorioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Random r = new Random();

            int valor = r.Next(0, 100);

            TX_A.Text = valor.ToString();

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TX_B.Text = "0";
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Random r = new Random();

            int valor = r.Next(0, 100);

            TX_B.Text = valor.ToString();

        }
    }
}
