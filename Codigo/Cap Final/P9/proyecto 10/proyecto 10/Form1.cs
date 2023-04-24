using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LB_Mensaje.Text = "";
        }

        private void BT_Fm2_Click(object sender, EventArgs e)
        {
            Form2 miforma2 = new Form2();

            miforma2.ShowDialog();

            LB_Mensaje.Text = miforma2.Mensaje;
        }
    }
}
