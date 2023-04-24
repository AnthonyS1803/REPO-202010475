namespace Proyecto_38
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
            this.BT_Adicionar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BT_Adicionar
            // 
            this.BT_Adicionar.Location = new System.Drawing.Point(444, 72);
            this.BT_Adicionar.Name = "BT_Adicionar";
            this.BT_Adicionar.Size = new System.Drawing.Size(85, 33);
            this.BT_Adicionar.TabIndex = 0;
            this.BT_Adicionar.Text = "Adiccionar";
            this.BT_Adicionar.UseVisualStyleBackColor = true;
            this.BT_Adicionar.Click += new System.EventHandler(this.BT_Adicionar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 450);
            this.Controls.Add(this.BT_Adicionar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BT_Adicionar;
    }
}

