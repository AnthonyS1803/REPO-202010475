using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CB_Alimentos_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = CB_Alimentos.SelectedIndex;

            LB_Indice.Text = indice.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CB_Alimentos.Items.Add("Lechuga");
            CB_Alimentos.Items.Add("Leche");

            LB_Indice.Text = "";
        }

        private void BT_Adicionar_Click(object sender, EventArgs e)
        {
            CB_Alimentos.Items.Add(TB_Agregar.Text);
        }
    }
}
