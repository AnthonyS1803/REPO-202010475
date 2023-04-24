using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_16
{
    public partial class Form1 : Form
    {

        private int n = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LB_Informacion.Text = "";
           
        }

        private void BT_Agregar_Click(object sender, EventArgs e)
        {
            //Agregamos nuevo reglon
            int n = DG_Productos.Rows.Add();

            //Colocamos la informacion

            DG_Productos.Rows[n].Cells[0].Value = TX_Codigo.Text;
            DG_Productos.Rows[n].Cells[1].Value = TX_Nombre.Text;
            DG_Productos.Rows[n].Cells[2].Value = TX_Precio.Text;

            // Limpiamos lo TX

            TX_Codigo.Text = "";
            TX_Nombre.Text = "";
            TX_Precio.Text = "";


        }

        private void TX_Codigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void DG_Productos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int n = e.RowIndex;

            if(n!=-1)
            {


                LB_Informacion.Text = (string) DG_Productos.Rows[n].Cells[1].Value;


                    
            }
        }

        private void BT_Borrar_Click(object sender, EventArgs e)
        {

          if (n != -1)
            {

                DG_Productos.Rows.RemoveAt(n);



            }


        }
    }
}
