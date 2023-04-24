namespace Proyecto_18
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.LB_Frutas = new System.Windows.Forms.ListBox();
            this.TX_Frutas = new System.Windows.Forms.TextBox();
            this.BT_Agregar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LB_Frutas
            // 
            this.LB_Frutas.FormattingEnabled = true;
            this.LB_Frutas.ItemHeight = 16;
            this.LB_Frutas.Items.AddRange(new object[] {
            "Pera",
            "Manzana"});
            this.LB_Frutas.Location = new System.Drawing.Point(65, 128);
            this.LB_Frutas.Name = "LB_Frutas";
            this.LB_Frutas.Size = new System.Drawing.Size(120, 84);
            this.LB_Frutas.TabIndex = 0;
            // 
            // TX_Frutas
            // 
            this.TX_Frutas.Location = new System.Drawing.Point(65, 57);
            this.TX_Frutas.Name = "TX_Frutas";
            this.TX_Frutas.Size = new System.Drawing.Size(100, 22);
            this.TX_Frutas.TabIndex = 1;
            // 
            // BT_Agregar
            // 
            this.BT_Agregar.Location = new System.Drawing.Point(186, 51);
            this.BT_Agregar.Name = "BT_Agregar";
            this.BT_Agregar.Size = new System.Drawing.Size(77, 34);
            this.BT_Agregar.TabIndex = 2;
            this.BT_Agregar.Text = "Agregar";
            this.BT_Agregar.UseVisualStyleBackColor = true;
            this.BT_Agregar.Click += new System.EventHandler(this.BT_Agregar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 272);
            this.Controls.Add(this.BT_Agregar);
            this.Controls.Add(this.TX_Frutas);
            this.Controls.Add(this.LB_Frutas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LB_Frutas;
        private System.Windows.Forms.TextBox TX_Frutas;
        private System.Windows.Forms.Button BT_Agregar;
    }
}

