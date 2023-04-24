﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_21
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BT_Operaciones_Click(object sender, EventArgs e)
        {
            DateTime fecha = DateTime.Today;

            string formato = "MM DDD YY D, HH -> MM";

            LB_Fecha.Text = fecha.ToString(formato);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LB_Fecha.Text = "";
        }
    }
}
