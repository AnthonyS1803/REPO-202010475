using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_32
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BT_Dibuje_Click(object sender, EventArgs e)
        {
            Graphics g = Graphics.FromHwnd(this.Handle);

            Font fuente = new Font("Times new roman", 35);

            g.DrawString("En metodo", fuente, Brushes.Green, 50, 75);

            g.Dispose();
        }
    }
}
