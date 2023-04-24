using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_39
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void textBox1_DragDrop(object sender, DragEventArgs e)
        {
            string[] archivos = (string[])e.Data.GetData(DataFormats.FileDrop,false);

            string linea = "";

            label1.Text = archivos[0];

            StreamReader lector = File.OpenText(archivos[0]);

            while ((linea = lector.ReadLine()) != null)
            {

                textBox1.Text += linea + "\r\n";
            }

            

            lector.Close();
        }
    }
}
