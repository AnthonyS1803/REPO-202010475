using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto_10
{
    public partial class Form2 : Form
    {

        private string mensaje;


        public Form2()
        {
            InitializeComponent();
        }

        public string Mensaje
        {    
            
            get {return mensaje; }
            
            
            }
       

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void BT_Salir_Click(object sender, EventArgs e)
        {
            mensaje = TB_Mensaje.Text;

            this.Close();
        }
    }
}
