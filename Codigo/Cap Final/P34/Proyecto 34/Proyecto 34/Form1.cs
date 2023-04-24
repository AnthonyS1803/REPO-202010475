using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_34
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

            g.DrawArc(Pens.Coral, new Rectangle(50, 50, 100, 100), 45, 100);
            g.DrawLine(Pens.Blue, 125, 25, 150, 200);
            g.DrawRectangle(Pens.Orange, new Rectangle(75, 75, 200, 25));
            Point[] puntos = { new Point(30, 45), new Point(110, 75), new Point(175, 200) };

            g.DrawLines(Pens.Green, puntos);
        }
    }
}
