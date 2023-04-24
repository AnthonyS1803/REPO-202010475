using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BT_Mostrar_Click(object sender, EventArgs e)
        {
            // MessageBox.Show("Hola a todos");

            // MessageBox.Show("Hola a todos", "Mi messagebox");

            DialogResult r =  MessageBox.Show("Problamos botones", 
                "Diferentes botones", 
                MessageBoxButtons.AbortRetryIgnore,
                MessageBoxIcon.Hand
                );

            if (r == DialogResult.Abort)

                LB_Mensaje.Text = "Omitir";

            if (r == DialogResult.Retry)

                LB_Mensaje.Text = "Reintetar";

            if (r == DialogResult.Ignore)

                LB_Mensaje.Text = "Ignorar";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LB_Mensaje.Text = "";
        }
    }
}
