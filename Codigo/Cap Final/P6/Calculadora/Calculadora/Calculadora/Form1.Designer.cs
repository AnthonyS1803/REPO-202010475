namespace Calculadora
{
    partial class F_Calculadora
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
            this.TB_1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TB_1
            // 
            this.TB_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_1.Location = new System.Drawing.Point(28, 12);
            this.TB_1.Multiline = true;
            this.TB_1.Name = "TB_1";
            this.TB_1.Size = new System.Drawing.Size(446, 46);
            this.TB_1.TabIndex = 0;
            this.TB_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // F_Calculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 450);
            this.Controls.Add(this.TB_1);
            this.Name = "F_Calculadora";
            this.Text = "Calculadora";
            this.Load += new System.EventHandler(this.F_Calculadora_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TB_1;
    }
}

