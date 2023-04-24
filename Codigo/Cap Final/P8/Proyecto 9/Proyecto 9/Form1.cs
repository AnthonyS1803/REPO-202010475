using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_9
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

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RB_Basico.Checked = true;
        }

        private void BT_Cotizar_Click(object sender, EventArgs e)
        {
            Double costo = 0.0;

            string cotizacion = "";

            costo = Convert.ToDouble(TX_Costo.Text);

            cotizacion = "Cotizacion de auto para " + TX_Nombre;

            if(RB_Basico.Checked==true)
                {

                costo = costo + 500.0;
                cotizacion += "Lleva seguro basico de $500 \r\n";

            }

            if (RB_TE.Checked == true)
            {

                costo += 700.0;
                cotizacion += "Lleva seguro basico de $700 \r\n";
            }

            if (RB_Total.Checked == true)
            {

                costo += 1000.0;
                cotizacion += "Lleva seguro basico de $1000 \r\n";
            }

            

            if(CH_Aire.Checked == true)
            {
                costo += 500.0;
                cotizacion += "Con aire acondiciando de $500";


            }

            if (CH_Audio.Checked == true)
            {
                costo += 700.0;
                cotizacion += "Con sistema de audio de $700";


            }

            cotizacion += "El total a pagar es de " + costo.ToString();

            TX_Costo.Text = cotizacion;
        }
    }
}
