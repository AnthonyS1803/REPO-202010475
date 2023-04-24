namespace Proyecto_21
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
            this.LB_Fecha = new System.Windows.Forms.Label();
            this.BT_Operaciones = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LB_Fecha
            // 
            this.LB_Fecha.AutoSize = true;
            this.LB_Fecha.Location = new System.Drawing.Point(134, 104);
            this.LB_Fecha.Name = "LB_Fecha";
            this.LB_Fecha.Size = new System.Drawing.Size(68, 16);
            this.LB_Fecha.TabIndex = 0;
            this.LB_Fecha.Text = "LB_Fecha";
            // 
            // BT_Operaciones
            // 
            this.BT_Operaciones.Location = new System.Drawing.Point(117, 168);
            this.BT_Operaciones.Name = "BT_Operaciones";
            this.BT_Operaciones.Size = new System.Drawing.Size(85, 36);
            this.BT_Operaciones.TabIndex = 1;
            this.BT_Operaciones.Text = "Operaciones";
            this.BT_Operaciones.UseVisualStyleBackColor = true;
            this.BT_Operaciones.Click += new System.EventHandler(this.BT_Operaciones_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 268);
            this.Controls.Add(this.BT_Operaciones);
            this.Controls.Add(this.LB_Fecha);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LB_Fecha;
        private System.Windows.Forms.Button BT_Operaciones;
    }
}

