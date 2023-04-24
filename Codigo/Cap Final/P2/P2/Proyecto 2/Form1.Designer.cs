namespace Proyecto_2
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
            this.LBL_Nombre = new System.Windows.Forms.Label();
            this.TXT_Nombre = new System.Windows.Forms.TextBox();
            this.LBL_Mensaje = new System.Windows.Forms.Label();
            this.BTN_Saludo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LBL_Nombre
            // 
            this.LBL_Nombre.AutoSize = true;
            this.LBL_Nombre.Location = new System.Drawing.Point(28, 37);
            this.LBL_Nombre.Name = "LBL_Nombre";
            this.LBL_Nombre.Size = new System.Drawing.Size(59, 16);
            this.LBL_Nombre.TabIndex = 0;
            this.LBL_Nombre.Text = "Nombre:";
            // 
            // TXT_Nombre
            // 
            this.TXT_Nombre.Location = new System.Drawing.Point(93, 34);
            this.TXT_Nombre.Name = "TXT_Nombre";
            this.TXT_Nombre.Size = new System.Drawing.Size(154, 22);
            this.TXT_Nombre.TabIndex = 1;
            // 
            // LBL_Mensaje
            // 
            this.LBL_Mensaje.AutoSize = true;
            this.LBL_Mensaje.Location = new System.Drawing.Point(28, 79);
            this.LBL_Mensaje.Name = "LBL_Mensaje";
            this.LBL_Mensaje.Size = new System.Drawing.Size(44, 16);
            this.LBL_Mensaje.TabIndex = 2;
            this.LBL_Mensaje.Text = "label1";
            // 
            // BTN_Saludo
            // 
            this.BTN_Saludo.Location = new System.Drawing.Point(273, 30);
            this.BTN_Saludo.Name = "BTN_Saludo";
            this.BTN_Saludo.Size = new System.Drawing.Size(91, 26);
            this.BTN_Saludo.TabIndex = 3;
            this.BTN_Saludo.Text = "Saludo";
            this.BTN_Saludo.UseVisualStyleBackColor = true;
            this.BTN_Saludo.Click += new System.EventHandler(this.BTN_Saludo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 165);
            this.Controls.Add(this.BTN_Saludo);
            this.Controls.Add(this.LBL_Mensaje);
            this.Controls.Add(this.TXT_Nombre);
            this.Controls.Add(this.LBL_Nombre);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBL_Nombre;
        private System.Windows.Forms.TextBox TXT_Nombre;
        private System.Windows.Forms.Label LBL_Mensaje;
        private System.Windows.Forms.Button BTN_Saludo;
    }
}

