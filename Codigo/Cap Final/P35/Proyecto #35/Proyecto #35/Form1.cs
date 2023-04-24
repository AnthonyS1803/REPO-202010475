using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto__35
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

            Pen pluma2 = new Pen(Color.Green, 7);

            pluma2.DashStyle = DashStyle.DashDotDot;
            g.DrawLine(pluma2, 50, 70, 200, 70);

            Pen pluma3 = new Pen(Color.Orange, 10);
            float[] guiones = { 1.0f, 1.0f, 2.0f, 1.0f, 3.0f, 1.0f };

            pluma3.DashPattern = guiones;
            g.DrawLine(pluma3, 50, 90, 200, 90);

            

        }
    }
}
