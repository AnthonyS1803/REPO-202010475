using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_20
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BT_Color_Click(object sender, EventArgs e)
        {
           if  (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                LB_Mensaje.ForeColor = colorDialog1.Color;

                LB_Mensaje.Text = TX_Mensaje.Text;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LB_Mensaje.Text = "";
            TX_Mensaje.Text = "Poner mensaje";
        }
    }
}
