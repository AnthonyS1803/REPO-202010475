namespace Proyecto_7
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
            this.BT_Cerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BT_Cerrar
            // 
            this.BT_Cerrar.Location = new System.Drawing.Point(238, 121);
            this.BT_Cerrar.Name = "BT_Cerrar";
            this.BT_Cerrar.Size = new System.Drawing.Size(94, 42);
            this.BT_Cerrar.TabIndex = 0;
            this.BT_Cerrar.Text = "Cerrar";
            this.BT_Cerrar.UseVisualStyleBackColor = true;
            this.BT_Cerrar.Click += new System.EventHandler(this.BT_Cerrar_Click);
            // 
            // F_B
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 288);
            this.Controls.Add(this.BT_Cerrar);
            this.Name = "F_B";
            this.Text = "Forma_2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BT_Cerrar;
    }
}