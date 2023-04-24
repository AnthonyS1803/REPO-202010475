using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_33
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            g.DrawEllipse(Pens.Indigo, new Rectangle(50, 50, 50, 50));

            g.DrawEllipse(Pens.Red, new Rectangle(0, 0, 20, 20));

            g.TranslateTransform(100, 100);
        }
    }
}
