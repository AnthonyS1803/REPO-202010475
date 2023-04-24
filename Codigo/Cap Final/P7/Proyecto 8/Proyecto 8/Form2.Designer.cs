namespace Proyecto_8
{
    partial class F_B
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
            this.LB_Datos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LB_Datos
            // 
            this.LB_Datos.AutoSize = true;
            this.LB_Datos.Location = new System.Drawing.Point(52, 104);
            this.LB_Datos.Name = "LB_Datos";
            this.LB_Datos.Size = new System.Drawing.Size(44, 16);
            this.LB_Datos.TabIndex = 0;
            this.LB_Datos.Text = "label1";
            // 
            // F_B
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 208);
            this.Controls.Add(this.LB_Datos);
            this.Name = "F_B";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LB_Datos;
    }
}