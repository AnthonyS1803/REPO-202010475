using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_23
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BT_Procesar_Click(object sender, EventArgs e)
        {
            bool error = false;

             foreach (char caracter in TX_Dato.Text)
            {

                if (char.IsDigit(caracter))
                {

                    error = true;
                    break;
                }
            }

            if (error)
            {

                errorProvider1.SetError(TX_Dato, "No se admiten numeros");
            }

            else

                errorProvider1.Clear();
        }

        private void TX_Dato_TextChanged(object sender, EventArgs e)
        {

            bool error = false;

            foreach (char caracter in TX_Dato.Text)
            {

                if (char.IsDigit(caracter))
                {

                    error = true;
                    break;
                }
            }
            if (error)
            {

                errorProvider1.SetError(TX_Dato, "No se admiten numeros");
            }

            else

                errorProvider1.Clear();
        }
    }
}
