namespace Proyecto_14
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
            this.CHL_Alimentos = new System.Windows.Forms.CheckedListBox();
            this.TX_NAlimento = new System.Windows.Forms.TextBox();
            this.BT_Agregar = new System.Windows.Forms.Button();
            this.LB_Nombre = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CHL_Alimentos
            // 
            this.CHL_Alimentos.CheckOnClick = true;
            this.CHL_Alimentos.FormattingEnabled = true;
            this.CHL_Alimentos.Items.AddRange(new object[] {
            "Habichuela",
            "Tomate"});
            this.CHL_Alimentos.Location = new System.Drawing.Point(12, 12);
            this.CHL_Alimentos.Name = "CHL_Alimentos";
            this.CHL_Alimentos.Size = new System.Drawing.Size(333, 191);
            this.CHL_Alimentos.TabIndex = 0;
            this.CHL_Alimentos.SelectedIndexChanged += new System.EventHandler(this.CHL_Alimentos_SelectedIndexChanged);
            // 
            // TX_NAlimento
            // 
            this.TX_NAlimento.Location = new System.Drawing.Point(12, 246);
            this.TX_NAlimento.Name = "TX_NAlimento";
            this.TX_NAlimento.Size = new System.Drawing.Size(100, 22);
            this.TX_NAlimento.TabIndex = 1;
            // 
            // BT_Agregar
            // 
            this.BT_Agregar.Location = new System.Drawing.Point(142, 246);
            this.BT_Agregar.Name = "BT_Agregar";
            this.BT_Agregar.Size = new System.Drawing.Size(82, 28);
            this.BT_Agregar.TabIndex = 2;
            this.BT_Agregar.Text = "Agregar";
            this.BT_Agregar.UseVisualStyleBackColor = true;
            this.BT_Agregar.Click += new System.EventHandler(this.BT_Agregar_Click);
            // 
            // LB_Nombre
            // 
            this.LB_Nombre.AutoSize = true;
            this.LB_Nombre.Location = new System.Drawing.Point(12, 215);
            this.LB_Nombre.Name = "LB_Nombre";
            this.LB_Nombre.Size = new System.Drawing.Size(44, 16);
            this.LB_Nombre.TabIndex = 3;
            this.LB_Nombre.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 309);
            this.Controls.Add(this.LB_Nombre);
            this.Controls.Add(this.BT_Agregar);
            this.Controls.Add(this.TX_NAlimento);
            this.Controls.Add(this.CHL_Alimentos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox CHL_Alimentos;
        private System.Windows.Forms.TextBox TX_NAlimento;
        private System.Windows.Forms.Button BT_Agregar;
        private System.Windows.Forms.Label LB_Nombre;
    }
}

