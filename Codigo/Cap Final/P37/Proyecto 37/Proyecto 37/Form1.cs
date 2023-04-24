using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_37
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BT_Uno_Click(object sender, EventArgs e)
        {
            Console.Beep();

            if (((Button)sender).Name == "BT_Uno")
                MessageBox.Show("Es el boton uno");
            if (((Button)sender).Name == "BT_Dos")
                MessageBox.Show("Es el boton Dos");
            if (((Button)sender).Name == "BT_Uno")
            {

                LB_Mensaje.Text = ((Button)sender).Text;
                ((Button)sender).Text = "Oprimido";
            }
                
        }
    }
}
