namespace Proyecto_23
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
            this.components = new System.ComponentModel.Container();
            this.TX_Dato = new System.Windows.Forms.TextBox();
            this.BT_Procesar = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // TX_Dato
            // 
            this.TX_Dato.Location = new System.Drawing.Point(79, 45);
            this.TX_Dato.Name = "TX_Dato";
            this.TX_Dato.Size = new System.Drawing.Size(100, 22);
            this.TX_Dato.TabIndex = 0;
            this.TX_Dato.TextChanged += new System.EventHandler(this.TX_Dato_TextChanged);
            // 
            // BT_Procesar
            // 
            this.BT_Procesar.Location = new System.Drawing.Point(205, 44);
            this.BT_Procesar.Name = "BT_Procesar";
            this.BT_Procesar.Size = new System.Drawing.Size(75, 23);
            this.BT_Procesar.TabIndex = 1;
            this.BT_Procesar.Text = "Procesar\r\n";
            this.BT_Procesar.UseVisualStyleBackColor = true;
            this.BT_Procesar.Click += new System.EventHandler(this.BT_Procesar_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 450);
            this.Controls.Add(this.BT_Procesar);
            this.Controls.Add(this.TX_Dato);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TX_Dato;
        private System.Windows.Forms.Button BT_Procesar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

