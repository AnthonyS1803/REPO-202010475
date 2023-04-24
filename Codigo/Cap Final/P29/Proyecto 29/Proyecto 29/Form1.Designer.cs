namespace Proyecto_29
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.BT_Abrir = new System.Windows.Forms.Button();
            this.BT_Salvar = new System.Windows.Forms.Button();
            this.LB_Abrir = new System.Windows.Forms.Label();
            this.LB_Salvar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // BT_Abrir
            // 
            this.BT_Abrir.Location = new System.Drawing.Point(51, 24);
            this.BT_Abrir.Name = "BT_Abrir";
            this.BT_Abrir.Size = new System.Drawing.Size(89, 32);
            this.BT_Abrir.TabIndex = 0;
            this.BT_Abrir.Text = "Abrir archivo";
            this.BT_Abrir.UseVisualStyleBackColor = true;
            this.BT_Abrir.Click += new System.EventHandler(this.BT_Abrir_Click);
            // 
            // BT_Salvar
            // 
            this.BT_Salvar.Location = new System.Drawing.Point(240, 24);
            this.BT_Salvar.Name = "BT_Salvar";
            this.BT_Salvar.Size = new System.Drawing.Size(77, 32);
            this.BT_Salvar.TabIndex = 1;
            this.BT_Salvar.Text = "Salvar";
            this.BT_Salvar.UseVisualStyleBackColor = true;
            this.BT_Salvar.Click += new System.EventHandler(this.BT_Salvar_Click);
            // 
            // LB_Abrir
            // 
            this.LB_Abrir.AutoSize = true;
            this.LB_Abrir.Location = new System.Drawing.Point(71, 88);
            this.LB_Abrir.Name = "LB_Abrir";
            this.LB_Abrir.Size = new System.Drawing.Size(44, 16);
            this.LB_Abrir.TabIndex = 2;
            this.LB_Abrir.Text = "label1";
            // 
            // LB_Salvar
            // 
            this.LB_Salvar.AutoSize = true;
            this.LB_Salvar.Location = new System.Drawing.Point(262, 88);
            this.LB_Salvar.Name = "LB_Salvar";
            this.LB_Salvar.Size = new System.Drawing.Size(44, 16);
            this.LB_Salvar.TabIndex = 3;
            this.LB_Salvar.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LB_Salvar);
            this.Controls.Add(this.LB_Abrir);
            this.Controls.Add(this.BT_Salvar);
            this.Controls.Add(this.BT_Abrir);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button BT_Abrir;
        private System.Windows.Forms.Button BT_Salvar;
        private System.Windows.Forms.Label LB_Abrir;
        private System.Windows.Forms.Label LB_Salvar;
    }
}

