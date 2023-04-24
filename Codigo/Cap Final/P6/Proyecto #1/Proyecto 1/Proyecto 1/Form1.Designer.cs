namespace Proyecto_1
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
            this.btnSaludo = new System.Windows.Forms.Button();
            this.LBLMensaje = new System.Windows.Forms.Label();
            this.BTN_Despedida = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSaludo
            // 
            this.btnSaludo.Location = new System.Drawing.Point(315, 67);
            this.btnSaludo.Name = "btnSaludo";
            this.btnSaludo.Size = new System.Drawing.Size(114, 47);
            this.btnSaludo.TabIndex = 0;
            this.btnSaludo.Text = "Saludo";
            this.btnSaludo.UseVisualStyleBackColor = true;
            this.btnSaludo.Click += new System.EventHandler(this.BTNSaludo_Click);
            // 
            // LBLMensaje
            // 
            this.LBLMensaje.AutoSize = true;
            this.LBLMensaje.Location = new System.Drawing.Point(79, 113);
            this.LBLMensaje.Name = "LBLMensaje";
            this.LBLMensaje.Size = new System.Drawing.Size(44, 16);
            this.LBLMensaje.TabIndex = 1;
            this.LBLMensaje.Text = "label1";
            // 
            // BTN_Despedida
            // 
            this.BTN_Despedida.Location = new System.Drawing.Point(315, 132);
            this.BTN_Despedida.Name = "BTN_Despedida";
            this.BTN_Despedida.Size = new System.Drawing.Size(114, 47);
            this.BTN_Despedida.TabIndex = 2;
            this.BTN_Despedida.Text = "Despedida";
            this.BTN_Despedida.UseVisualStyleBackColor = true;
            this.BTN_Despedida.Click += new System.EventHandler(this.BTN_Despedida_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 450);
            this.Controls.Add(this.BTN_Despedida);
            this.Controls.Add(this.LBLMensaje);
            this.Controls.Add(this.btnSaludo);
            this.Name = "Form1";
            this.Text = "Programa #1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSaludo;
        private System.Windows.Forms.Label LBLMensaje;
        private System.Windows.Forms.Button BTN_Despedida;
    }
}

