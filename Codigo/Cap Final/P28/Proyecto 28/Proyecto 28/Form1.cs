using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_28
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            new DateTime(2017, 2, 23);
            new DateTime(2017, 3, 5);
            DateTime.Today.AddDays(5);
        }

        private void BTN_Fechas_Click(object sender, EventArgs e)
        {
            DateTime inicio = monthCalendar1.SelectionStart;
            DateTime final = monthCalendar1.SelectionEnd;

            LB_Inicio.Text = inicio.ToString();
            LB_Final.Text = final.ToString();

                 
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            LB_Seleccion.Text = monthCalendar1.SelectionRange.ToString ();
        }
    }
}
