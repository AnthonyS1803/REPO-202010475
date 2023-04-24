namespace Proyecto_3
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
            this.LBL_A = new System.Windows.Forms.Label();
            this.TXT_A = new System.Windows.Forms.TextBox();
            this.LBL_B = new System.Windows.Forms.Label();
            this.TXT_B = new System.Windows.Forms.TextBox();
            this.LBL_Resultado = new System.Windows.Forms.Label();
            this.BTN_Suma = new System.Windows.Forms.Button();
            this.BTN_Resta = new System.Windows.Forms.Button();
            this.BTN_Division = new System.Windows.Forms.Button();
            this.BTN_Mul = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LBL_A
            // 
            this.LBL_A.AutoSize = true;
            this.LBL_A.Location = new System.Drawing.Point(26, 23);
            this.LBL_A.Name = "LBL_A";
            this.LBL_A.Size = new System.Drawing.Size(19, 16);
            this.LBL_A.TabIndex = 0;
            this.LBL_A.Text = "A:";
            // 
            // TXT_A
            // 
            this.TXT_A.Location = new System.Drawing.Point(51, 20);
            this.TXT_A.Name = "TXT_A";
            this.TXT_A.Size = new System.Drawing.Size(100, 22);
            this.TXT_A.TabIndex = 1;
            this.TXT_A.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // LBL_B
            // 
            this.LBL_B.AutoSize = true;
            this.LBL_B.Location = new System.Drawing.Point(26, 66);
            this.LBL_B.Name = "LBL_B";
            this.LBL_B.Size = new System.Drawing.Size(19, 16);
            this.LBL_B.TabIndex = 2;
            this.LBL_B.Text = "B:";
            // 
            // TXT_B
            // 
            this.TXT_B.Location = new System.Drawing.Point(51, 66);
            this.TXT_B.Name = "TXT_B";
            this.TXT_B.Size = new System.Drawing.Size(100, 22);
            this.TXT_B.TabIndex = 3;
            this.TXT_B.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // LBL_Resultado
            // 
            this.LBL_Resultado.AutoSize = true;
            this.LBL_Resultado.Location = new System.Drawing.Point(190, 47);
            this.LBL_Resultado.Name = "LBL_Resultado";
            this.LBL_Resultado.Size = new System.Drawing.Size(69, 16);
            this.LBL_Resultado.TabIndex = 4;
            this.LBL_Resultado.Text = "Resultado";
            this.LBL_Resultado.Click += new System.EventHandler(this.label1_Click);
            // 
            // BTN_Suma
            // 
            this.BTN_Suma.Location = new System.Drawing.Point(29, 113);
            this.BTN_Suma.Name = "BTN_Suma";
            this.BTN_Suma.Size = new System.Drawing.Size(43, 31);
            this.BTN_Suma.TabIndex = 5;
            this.BTN_Suma.Text = "+";
            this.BTN_Suma.UseVisualStyleBackColor = true;
            this.BTN_Suma.Click += new System.EventHandler(this.BTN_Suma_Click);
            // 
            // BTN_Resta
            // 
            this.BTN_Resta.Location = new System.Drawing.Point(92, 113);
            this.BTN_Resta.Name = "BTN_Resta";
            this.BTN_Resta.Size = new System.Drawing.Size(43, 31);
            this.BTN_Resta.TabIndex = 6;
            this.BTN_Resta.Text = "-";
            this.BTN_Resta.UseVisualStyleBackColor = true;
            this.BTN_Resta.Click += new System.EventHandler(this.BTN_Resta_Click);
            // 
            // BTN_Division
            // 
            this.BTN_Division.Location = new System.Drawing.Point(92, 150);
            this.BTN_Division.Name = "BTN_Division";
            this.BTN_Division.Size = new System.Drawing.Size(43, 31);
            this.BTN_Division.TabIndex = 8;
            this.BTN_Division.Text = "÷";
            this.BTN_Division.UseVisualStyleBackColor = true;
            this.BTN_Division.Click += new System.EventHandler(this.BTN_Division_Click);
            // 
            // BTN_Mul
            // 
            this.BTN_Mul.Location = new System.Drawing.Point(29, 150);
            this.BTN_Mul.Name = "BTN_Mul";
            this.BTN_Mul.Size = new System.Drawing.Size(43, 31);
            this.BTN_Mul.TabIndex = 9;
            this.BTN_Mul.Text = "x";
            this.BTN_Mul.UseVisualStyleBackColor = true;
            this.BTN_Mul.Click += new System.EventHandler(this.BTN_Mul_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 238);
            this.Controls.Add(this.BTN_Mul);
            this.Controls.Add(this.BTN_Division);
            this.Controls.Add(this.BTN_Resta);
            this.Controls.Add(this.BTN_Suma);
            this.Controls.Add(this.LBL_Resultado);
            this.Controls.Add(this.TXT_B);
            this.Controls.Add(this.LBL_B);
            this.Controls.Add(this.TXT_A);
            this.Controls.Add(this.LBL_A);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBL_A;
        private System.Windows.Forms.TextBox TXT_A;
        private System.Windows.Forms.Label LBL_B;
        private System.Windows.Forms.TextBox TXT_B;
        private System.Windows.Forms.Label LBL_Resultado;
        private System.Windows.Forms.Button BTN_Suma;
        private System.Windows.Forms.Button BTN_Resta;
        private System.Windows.Forms.Button BTN_Division;
        private System.Windows.Forms.Button BTN_Mul;
    }
}

