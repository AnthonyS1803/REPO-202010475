namespace proyecto_10
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TB_Mensaje = new System.Windows.Forms.TextBox();
            this.BT_Salir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TB_Mensaje
            // 
            this.TB_Mensaje.Location = new System.Drawing.Point(34, 106);
            this.TB_Mensaje.Name = "TB_Mensaje";
            this.TB_Mensaje.Size = new System.Drawing.Size(100, 22);
            this.TB_Mensaje.TabIndex = 0;
            // 
            // BT_Salir
            // 
            this.BT_Salir.Location = new System.Drawing.Point(296, 106);
            this.BT_Salir.Name = "BT_Salir";
            this.BT_Salir.Size = new System.Drawing.Size(75, 23);
            this.BT_Salir.TabIndex = 1;
            this.BT_Salir.Text = "Salir";
            this.BT_Salir.UseVisualStyleBackColor = true;
            this.BT_Salir.Click += new System.EventHandler(this.BT_Salir_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 254);
            this.Controls.Add(this.BT_Salir);
            this.Controls.Add(this.TB_Mensaje);
            this.Name = "Form2";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TB_Mensaje;
        private System.Windows.Forms.Button BT_Salir;
    }
}