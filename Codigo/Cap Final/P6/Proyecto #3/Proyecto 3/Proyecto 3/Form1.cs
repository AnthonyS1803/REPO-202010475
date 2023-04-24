using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LBL_Resultado.Text = "";
            TXT_A.Text = "0";
            TXT_B.Text = "0";
        }

        private void BTN_Suma_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(TXT_A.Text);
            double b = Convert.ToDouble(TXT_B.Text);

            double r = a + b;

            LBL_Resultado.Text = r.ToString();




        }

        private void BTN_Resta_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(TXT_A.Text);
            double b = Convert.ToDouble(TXT_B.Text);

            double r = a - b;

            LBL_Resultado.Text = r.ToString();
        }

        private void BTN_Division_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(TXT_A.Text);
            double b = Convert.ToDouble(TXT_B.Text);

            double r = a / b;

            LBL_Resultado.Text = r.ToString();
        }

        private void BTN_Mul_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(TXT_A.Text);
            double b = Convert.ToDouble(TXT_B.Text);

            double r = a * b;

            LBL_Resultado.Text = r.ToString();
        }
    }
}
