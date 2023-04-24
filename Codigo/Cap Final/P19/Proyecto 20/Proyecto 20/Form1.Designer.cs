namespace Proyecto_20
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
            this.BT_Color = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.TX_Mensaje = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LB_Mensaje
            // 
            this.LB_Mensaje.AutoSize = true;
            this.LB_Mensaje.Location = new System.Drawing.Point(199, 92);
            this.LB_Mensaje.Name = "LB_Mensaje";
            this.LB_Mensaje.Size = new System.Drawing.Size(44, 16);
            this.LB_Mensaje.TabIndex = 1;
            this.LB_Mensaje.Text = "label1";
            // 
            // BT_Color
            // 
            this.BT_Color.Location = new System.Drawing.Point(182, 138);
            this.BT_Color.Name = "BT_Color";
            this.BT_Color.Size = new System.Drawing.Size(75, 23);
            this.BT_Color.TabIndex = 2;
            this.BT_Color.Text = "Color";
            this.BT_Color.UseVisualStyleBackColor = true;
            this.BT_Color.Click += new System.EventHandler(this.BT_Color_Click);
            // 
            // TX_Mensaje
            // 
            this.TX_Mensaje.Location = new System.Drawing.Point(166, 39);
            this.TX_Mensaje.Multiline = true;
            this.TX_Mensaje.Name = "TX_Mensaje";
            this.TX_Mensaje.Size = new System.Drawing.Size(113, 34);
            this.TX_Mensaje.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 225);
            this.Controls.Add(this.TX_Mensaje);
            this.Controls.Add(this.BT_Color);
            this.Controls.Add(this.LB_Mensaje);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LB_Mensaje;
        private System.Windows.Forms.Button BT_Color;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.TextBox TX_Mensaje;
    }
}

