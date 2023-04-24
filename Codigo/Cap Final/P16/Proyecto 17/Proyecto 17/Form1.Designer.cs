namespace Proyecto_17
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
            this.DUD_Frutas = new System.Windows.Forms.DomainUpDown();
            this.TX_Frutas = new System.Windows.Forms.TextBox();
            this.BT_Agregar = new System.Windows.Forms.Button();
            this.LB_Mensaje = new System.Windows.Forms.Label();
            this.LB_Borrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DUD_Frutas
            // 
            this.DUD_Frutas.Location = new System.Drawing.Point(124, 148);
            this.DUD_Frutas.Name = "DUD_Frutas";
            this.DUD_Frutas.Size = new System.Drawing.Size(120, 22);
            this.DUD_Frutas.TabIndex = 0;
            this.DUD_Frutas.Text = "Frutas";
            this.DUD_Frutas.SelectedItemChanged += new System.EventHandler(this.DUD_Frutas_SelectedItemChanged);
            // 
            // TX_Frutas
            // 
            this.TX_Frutas.Location = new System.Drawing.Point(84, 48);
            this.TX_Frutas.Name = "TX_Frutas";
            this.TX_Frutas.Size = new System.Drawing.Size(100, 22);
            this.TX_Frutas.TabIndex = 1;
            // 
            // BT_Agregar
            // 
            this.BT_Agregar.Location = new System.Drawing.Point(203, 47);
            this.BT_Agregar.Name = "BT_Agregar";
            this.BT_Agregar.Size = new System.Drawing.Size(75, 23);
            this.BT_Agregar.TabIndex = 2;
            this.BT_Agregar.Text = "Agregar";
            this.BT_Agregar.UseVisualStyleBackColor = true;
            this.BT_Agregar.Click += new System.EventHandler(this.BT_Agregar_Click);
            // 
            // LB_Mensaje
            // 
            this.LB_Mensaje.AutoSize = true;
            this.LB_Mensaje.Location = new System.Drawing.Point(121, 106);
            this.LB_Mensaje.Name = "LB_Mensaje";
            this.LB_Mensaje.Size = new System.Drawing.Size(44, 16);
            this.LB_Mensaje.TabIndex = 4;
            this.LB_Mensaje.Text = "label1";
            // 
            // LB_Borrar
            // 
            this.LB_Borrar.Location = new System.Drawing.Point(203, 76);
            this.LB_Borrar.Name = "LB_Borrar";
            this.LB_Borrar.Size = new System.Drawing.Size(75, 23);
            this.LB_Borrar.TabIndex = 5;
            this.LB_Borrar.Text = "Borrar";
            this.LB_Borrar.UseVisualStyleBackColor = true;
            this.LB_Borrar.Click += new System.EventHandler(this.LB_Borrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 384);
            this.Controls.Add(this.LB_Borrar);
            this.Controls.Add(this.LB_Mensaje);
            this.Controls.Add(this.BT_Agregar);
            this.Controls.Add(this.TX_Frutas);
            this.Controls.Add(this.DUD_Frutas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DomainUpDown DUD_Frutas;
        private System.Windows.Forms.TextBox TX_Frutas;
        private System.Windows.Forms.Button BT_Agregar;
        private System.Windows.Forms.Label LB_Mensaje;
        private System.Windows.Forms.Button LB_Borrar;
    }
}

