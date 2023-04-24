namespace Proyecto_8
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
            this.BT_Enviar = new System.Windows.Forms.Button();
            this.TX_Datos = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BT_Enviar
            // 
            this.BT_Enviar.Location = new System.Drawing.Point(173, 54);
            this.BT_Enviar.Name = "BT_Enviar";
            this.BT_Enviar.Size = new System.Drawing.Size(101, 50);
            this.BT_Enviar.TabIndex = 0;
            this.BT_Enviar.Text = "Enviar";
            this.BT_Enviar.UseVisualStyleBackColor = true;
            this.BT_Enviar.Click += new System.EventHandler(this.BT_Enviar_Click);
            // 
            // TX_Datos
            // 
            this.TX_Datos.Location = new System.Drawing.Point(38, 68);
            this.TX_Datos.Name = "TX_Datos";
            this.TX_Datos.Size = new System.Drawing.Size(100, 22);
            this.TX_Datos.TabIndex = 1;
            // 
            // F_A
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 450);
            this.Controls.Add(this.TX_Datos);
            this.Controls.Add(this.BT_Enviar);
            this.Name = "F_A";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BT_Enviar;
        private System.Windows.Forms.TextBox TX_Datos;
    }
}

