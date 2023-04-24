using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CHL_Alimentos.Items.Add("Carne");
            CHL_Alimentos.Items.Add("Pescado", true);
            LB_Nombre.Text = "";


        }

        private void BT_Agregar_Click(object sender, EventArgs e)
        {
            CHL_Alimentos.Items.Add(TX_NAlimento.Text);
        }

        private void CHL_Alimentos_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice =  CHL_Alimentos.SelectedIndex;

            if(indice != -1) { 
            
            LB_Nombre.Text = CHL_Alimentos.Items [indice].ToString();
            
            }

            if (CHL_Alimentos.GetItemChecked(3) == true)
                MessageBox.Show("El pescado no es bueno, coje otra cosa");
        }
    }
}
