namespace proyecto_10
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
            this.LB_Mensaje = new System.Windows.Forms.Label();
            this.BT_Fm2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LB_Mensaje
            // 
            this.LB_Mensaje.AutoSize = true;
            this.LB_Mensaje.Location = new System.Drawing.Point(24, 149);
            this.LB_Mensaje.Name = "LB_Mensaje";
            this.LB_Mensaje.Size = new System.Drawing.Size(44, 16);
            this.LB_Mensaje.TabIndex = 0;
            this.LB_Mensaje.Text = "label1";
            // 
            // BT_Fm2
            // 
            this.BT_Fm2.Location = new System.Drawing.Point(227, 135);
            this.BT_Fm2.Name = "BT_Fm2";
            this.BT_Fm2.Size = new System.Drawing.Size(110, 44);
            this.BT_Fm2.TabIndex = 1;
            this.BT_Fm2.Text = "Abrir forma 2";
            this.BT_Fm2.UseVisualStyleBackColor = true;
            this.BT_Fm2.Click += new System.EventHandler(this.BT_Fm2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 430);
            this.Controls.Add(this.BT_Fm2);
            this.Controls.Add(this.LB_Mensaje);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LB_Mensaje;
        private System.Windows.Forms.Button BT_Fm2;
    }
}

