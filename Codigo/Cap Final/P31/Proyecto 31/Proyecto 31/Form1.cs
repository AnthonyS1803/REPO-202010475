using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_31.Properties;

namespace Proyecto_31
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TX_Mensaje.Text = (string)Settings.Default["Mensaje"];

            CH_Importado.Checked = (bool)Settings.Default["Importado"];
            CH_Organico.Checked = (bool)Settings.Default["Organico"];

            this.Size = (Size)Settings.Default["Tamaño"];

            switch ((int)Settings.Default["Frutas"])
            { 

                case 0:
                    RB_Manzana.Checked = true;
                    RB_Ciruela.Checked = false;
                    RB_Pera.Checked = false;
                    break;

                case 1:
                    RB_Manzana.Checked = false;
                    RB_Ciruela.Checked = true;
                    RB_Pera.Checked = false;
                    break;

                case 2:
                    RB_Manzana.Checked = false;
                    RB_Ciruela.Checked = false;
                    RB_Pera.Checked = true;
                    break;
            }
        }

        private void TX_Mensaje_TextChanged(object sender, EventArgs e)
        {
            Settings.Default["Mensaje"] = TX_Mensaje.Text;
            Settings.Default.Save();
        }

        private void CH_Importado_CheckStateChanged(object sender, EventArgs e)
        {
            Settings.Default["Importado"] = CH_Importado.Checked;
            Settings.Default.Save();
        }

        private void CH_Organico_CheckStateChanged(object sender, EventArgs e)
        {
            Settings.Default["Organico"] = CH_Organico.Checked;
            Settings.Default.Save();    
        }

        private void RB_Manzana_CheckedChanged(object sender, EventArgs e)
        {
            if(RB_Manzana.Checked==true)
            {
                Settings.Default["Frutas"] = 0;
                Settings.Default.Save();

            }
        }

        private void RB_Pera_CheckedChanged(object sender, EventArgs e)
        {
            if (RB_Pera.Checked == true)
            {
                Settings.Default["Frutas"] = 0;
                Settings.Default.Save();

            }
        }

        private void RB_Ciruela_CheckedChanged(object sender, EventArgs e)
        {
            if (RB_Ciruela.Checked == true)
            {
                Settings.Default["Frutas"] = 0;
                Settings.Default.Save();

            }
        }

        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            Settings.Default["Tamaño"] = this.Size;
            Settings.Default.Save();
        }
    }
}
