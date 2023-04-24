using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_22
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime fecha = dateTimePicker1.Value;

            LB_Fecha.Text = fecha.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LB_Fecha.Text = "";
        }

        private void BT_Calcular_Click(object sender, EventArgs e)
        {
            double dias = Convert.ToDouble(TX_Dias.Text);

            dateTimePicker1.Value = DateTime.Today.AddDays(dias);
        }
    }
}
