using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TX_A_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void TX_B_TextChanged(object sender, EventArgs e)
            {
             
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TX_A.Text = "0";

            TX_B.Text = "0";

            LB_Resultado.Text = "";
        }

        private void BT_Calcular_Click(object sender, EventArgs e)
        {


            double r = 0.0;

            double a = 0.0;

            double b = 0.0;

            a = Convert.ToDouble(TX_A.Text);

            b = Convert.ToDouble(TX_B.Text);

            if (RB_Suma.Checked == true)

                r = a + b;


            if (RB_Resta.Checked == true)

                r = a - b;


            if (RB_Multi.Checked == true)

                r = a * b;


            if (RB_Div.Checked == true)

                r = a / b;

            LB_Resultado.Text = r.ToString();


        }

        private void gBox_OPeraciones_Enter(object sender, EventArgs e)
        {

        }
    }
}
