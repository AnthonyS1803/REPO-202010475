namespace Proyecto_7
{
    partial class F_A
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
            this.BT_Cambio = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BT_Cambio
            // 
            this.BT_Cambio.Location = new System.Drawing.Point(158, 97);
            this.BT_Cambio.Name = "BT_Cambio";
            this.BT_Cambio.Size = new System.Drawing.Size(100, 40);
            this.BT_Cambio.TabIndex = 0;
            this.BT_Cambio.Text = "Abrir";
            this.BT_Cambio.UseVisualStyleBackColor = true;
            this.BT_Cambio.Click += new System.EventHandler(this.BT_Cambio_Click);
            // 
            // F_A
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 450);
            this.Controls.Add(this.BT_Cambio);
            this.Name = "F_A";
            this.Text = "Forma 1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BT_Cambio;
    }
}

