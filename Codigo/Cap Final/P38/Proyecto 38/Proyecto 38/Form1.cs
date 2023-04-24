using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_38
{
    public partial class Form1 : Form
    {
        private int y = 50;
        private int conteo = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void BT_Adicionar_Click(object sender, EventArgs e)
        {
            Button temp = new Button();

            temp.Height = 23;
            temp.Width = 200;
            temp.Location = new Point(50, y);
            y += 25;
            temp.Name = "BT_Boton" + conteo.ToString();
            temp.Text = "Boton #" + conteo.ToString();
            conteo++;

            temp.Click += new EventHandler(handlerComun_Click);

            Controls.Add(temp);
        }
            private void handlerComun_Click(object sender, EventArgs e)
            {
            Console.Beep(((Button)sender).Location.Y * 10, 100);
            }

        }
    }

