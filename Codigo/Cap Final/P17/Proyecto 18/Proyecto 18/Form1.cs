using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_18
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Adicionar  elementos

            LB_Frutas.Items.Add("Aguacate");
            LB_Frutas.Items.Add("Melon");
        }

        private void BT_Agregar_Click(object sender, EventArgs e)
        {
            LB_Frutas.Items.Add(TX_Frutas.Text);

            TX_Frutas.Text = string.Empty;


        }
    }
}
