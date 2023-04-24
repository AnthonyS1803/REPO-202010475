using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BTNSaludo_Click(object sender, EventArgs e)
        {
            LBLMensaje.Text = "Hola a todos";
        }

        private void BTN_Despedida_Click(object sender, EventArgs e)
        {
            LBLMensaje.Text = "Adios";
            this.Text = "Adios";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LBLMensaje.Text = "";
        }
    }
}
