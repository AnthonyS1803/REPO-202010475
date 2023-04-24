using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void BT_Calcular_Click(object sender, EventArgs e)
        {
            int total = 0;

            if (CH_Monitor.Checked == true)
                total = total + 250;

            if (CH_Teclado.Checked == true)
                total = total + 20;

            if (CH_Mouse.Checked == true)
                total = total + 15;

            MessageBox.Show("El total es: " + total.ToString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LBL_Mensaje.Text = "";
        }


        private void CH_Monitor_CheckedChanged(object sender, EventArgs e)
        {
            if (CH_Monitor.Checked == true)

                LBL_Mensaje.Text = "Monitor";

            else

                LBL_Mensaje.Text = "";
        }

        

        private void CH_Mouse_CheckedChanged(object sender, EventArgs e)
        {
            if (CH_Mouse.Checked == true)

                LBL_Mensaje.Text = "Mouse";

            else

                LBL_Mensaje.Text = "";
        }

        private void CH_Teclado_CheckedChanged(object sender, EventArgs e)
        {
            if (CH_Teclado.Checked == true)

                LBL_Mensaje.Text = "Teclado";

            else

                LBL_Mensaje.Text = "";
        }
    }
}
