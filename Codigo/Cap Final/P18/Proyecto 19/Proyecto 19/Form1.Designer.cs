namespace Proyecto_19
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
            this.LV_Alimentos = new System.Windows.Forms.ListView();
            this.TX_Elmento = new System.Windows.Forms.TextBox();
            this.GB_Grupos = new System.Windows.Forms.GroupBox();
            this.RB_Frutas = new System.Windows.Forms.RadioButton();
            this.RB_Carnes = new System.Windows.Forms.RadioButton();
            this.BT_Agregar = new System.Windows.Forms.Button();
            this.GB_Grupos.SuspendLayout();
            this.SuspendLayout();
            // 
            // LV_Alimentos
            // 
            this.LV_Alimentos.HideSelection = false;
            this.LV_Alimentos.Location = new System.Drawing.Point(12, 12);
            this.LV_Alimentos.Name = "LV_Alimentos";
            this.LV_Alimentos.Size = new System.Drawing.Size(398, 223);
            this.LV_Alimentos.TabIndex = 0;
            this.LV_Alimentos.UseCompatibleStateImageBehavior = false;
            // 
            // TX_Elmento
            // 
            this.TX_Elmento.Location = new System.Drawing.Point(-1, 292);
            this.TX_Elmento.Name = "TX_Elmento";
            this.TX_Elmento.Size = new System.Drawing.Size(100, 22);
            this.TX_Elmento.TabIndex = 1;
            // 
            // GB_Grupos
            // 
            this.GB_Grupos.Controls.Add(this.BT_Agregar);
            this.GB_Grupos.Controls.Add(this.RB_Carnes);
            this.GB_Grupos.Controls.Add(this.RB_Frutas);
            this.GB_Grupos.Location = new System.Drawing.Point(167, 292);
            this.GB_Grupos.Name = "GB_Grupos";
            this.GB_Grupos.Size = new System.Drawing.Size(200, 100);
            this.GB_Grupos.TabIndex = 2;
            this.GB_Grupos.TabStop = false;
            this.GB_Grupos.Text = "Grupos";
            // 
            // RB_Frutas
            // 
            this.RB_Frutas.AutoSize = true;
            this.RB_Frutas.Location = new System.Drawing.Point(3, 18);
            this.RB_Frutas.Name = "RB_Frutas";
            this.RB_Frutas.Size = new System.Drawing.Size(65, 20);
            this.RB_Frutas.TabIndex = 0;
            this.RB_Frutas.TabStop = true;
            this.RB_Frutas.Text = "Frutas";
            this.RB_Frutas.UseVisualStyleBackColor = true;
            // 
            // RB_Carnes
            // 
            this.RB_Carnes.AutoSize = true;
            this.RB_Carnes.Location = new System.Drawing.Point(6, 44);
            this.RB_Carnes.Name = "RB_Carnes";
            this.RB_Carnes.Size = new System.Drawing.Size(71, 20);
            this.RB_Carnes.TabIndex = 1;
            this.RB_Carnes.TabStop = true;
            this.RB_Carnes.Text = "Carnes";
            this.RB_Carnes.UseVisualStyleBackColor = true;
            // 
            // BT_Agregar
            // 
            this.BT_Agregar.Location = new System.Drawing.Point(102, 32);
            this.BT_Agregar.Name = "BT_Agregar";
            this.BT_Agregar.Size = new System.Drawing.Size(75, 23);
            this.BT_Agregar.TabIndex = 2;
            this.BT_Agregar.Text = "Agregar";
            this.BT_Agregar.UseVisualStyleBackColor = true;
            this.BT_Agregar.Click += new System.EventHandler(this.BT_Agregar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 411);
            this.Controls.Add(this.GB_Grupos);
            this.Controls.Add(this.TX_Elmento);
            this.Controls.Add(this.LV_Alimentos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GB_Grupos.ResumeLayout(false);
            this.GB_Grupos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView LV_Alimentos;
        private System.Windows.Forms.TextBox TX_Elmento;
        private System.Windows.Forms.GroupBox GB_Grupos;
        private System.Windows.Forms.Button BT_Agregar;
        private System.Windows.Forms.RadioButton RB_Carnes;
        private System.Windows.Forms.RadioButton RB_Frutas;
    }
}

