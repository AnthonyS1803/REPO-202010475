namespace Proyecto_6
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
            this.BT_Mostrar = new System.Windows.Forms.Button();
            this.LB_Mensaje = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BT_Mostrar
            // 
            this.BT_Mostrar.Location = new System.Drawing.Point(230, 65);
            this.BT_Mostrar.Name = "BT_Mostrar";
            this.BT_Mostrar.Size = new System.Drawing.Size(87, 35);
            this.BT_Mostrar.TabIndex = 0;
            this.BT_Mostrar.Text = "Mostrar";
            this.BT_Mostrar.UseVisualStyleBackColor = true;
            this.BT_Mostrar.Click += new System.EventHandler(this.BT_Mostrar_Click);
            // 
            // LB_Mensaje
            // 
            this.LB_Mensaje.AutoSize = true;
            this.LB_Mensaje.Location = new System.Drawing.Point(60, 74);
            this.LB_Mensaje.Name = "LB_Mensaje";
            this.LB_Mensaje.Size = new System.Drawing.Size(44, 16);
            this.LB_Mensaje.TabIndex = 1;
            this.LB_Mensaje.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 175);
            this.Controls.Add(this.LB_Mensaje);
            this.Controls.Add(this.BT_Mostrar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BT_Mostrar;
        private System.Windows.Forms.Label LB_Mensaje;
    }
}

