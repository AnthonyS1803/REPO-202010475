using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_13
{
    public partial class Form1 : Form
    {

        private int conteo;

            
        public Form1()
        {
            InitializeComponent();
        }

        private void TM_Prueba_Tick(object sender, EventArgs e)
        {
            conteo++;

            LB_Valor.Text = conteo.ToString();

            if(PB_Trabajo.Value < 100)
            PB_Trabajo.Value++;

            if (PB_Trabajo.Value == 100)
                TM_Prueba.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LB_Valor.Text = "";
            LBT_Valor.Text = "";
        }

        private void BT_Inicio_Click(object sender, EventArgs e)
        {
            TM_Prueba.Enabled = true;

            PB_Trabajo.Value = 0;


        }

        private void BT_Detener_Click(object sender, EventArgs e)
        {
            TM_Prueba.Enabled = false;

            TB_Intervalo.Value = TB_Intervalo.Minimum;
            LBT_Valor.Text = TB_Intervalo.Value.ToString();
            TM_Prueba.Interval = TB_Intervalo.Value;
                
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            TM_Prueba.Enabled = false;
        }

        private void TB_Intervalo_Scroll(object sender, EventArgs e)
        {
            LBT_Valor.Text = TB_Intervalo.Value.ToString();

            TM_Prueba.Interval = TB_Intervalo.Value;
        }

        private void BT_Calculo_Click(object sender, EventArgs e)
        {
            for (int n = 0; n < 100000; n++)
            {



                if (n % 1000 == 0)
                    PB_Trabajo.PerformStep();
            }


        }
    }
}
