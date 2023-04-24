using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DUD_Frutas.Items.Add("Manzana");
            DUD_Frutas.Items.Add("Pera");
            DUD_Frutas.Items.Add("Fresa");

            LB_Mensaje.Text = "";


        }

        private void BT_Agregar_Click(object sender, EventArgs e)
        {
            DUD_Frutas.Items.Add(TX_Frutas.Text);

            TX_Frutas.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DUD_Frutas_SelectedItemChanged(object sender, EventArgs e)
        {
            string fruta = (string)DUD_Frutas.SelectedItem;

            LB_Mensaje.Text = string.Format("Tu fruta favorita es {0}", fruta);


        }

        private void LB_Borrar_Click(object sender, EventArgs e)
        {
            int indice = DUD_Frutas.SelectedIndex;

            DUD_Frutas.Items.RemoveAt(indice);

            DUD_Frutas.SelectedIndex = 0;
        }
    }
}
