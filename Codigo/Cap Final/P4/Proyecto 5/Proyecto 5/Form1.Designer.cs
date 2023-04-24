namespace Proyecto_5
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
            this.TX_A = new System.Windows.Forms.TextBox();
            this.TX_B = new System.Windows.Forms.TextBox();
            this.BT_Calcular = new System.Windows.Forms.Button();
            this.gBox_OPeraciones = new System.Windows.Forms.GroupBox();
            this.RB_Suma = new System.Windows.Forms.RadioButton();
            this.RB_Resta = new System.Windows.Forms.RadioButton();
            this.RB_Multi = new System.Windows.Forms.RadioButton();
            this.RB_Div = new System.Windows.Forms.RadioButton();
            this.LB_Resultado = new System.Windows.Forms.Label();
            this.gBox_OPeraciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // TX_A
            // 
            this.TX_A.Location = new System.Drawing.Point(12, 34);
            this.TX_A.Name = "TX_A";
            this.TX_A.Size = new System.Drawing.Size(100, 22);
            this.TX_A.TabIndex = 1;
            this.TX_A.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TX_A.TextChanged += new System.EventHandler(this.TX_A_TextChanged);
            // 
            // TX_B
            // 
            this.TX_B.Location = new System.Drawing.Point(12, 89);
            this.TX_B.Name = "TX_B";
            this.TX_B.Size = new System.Drawing.Size(100, 22);
            this.TX_B.TabIndex = 2;
            this.TX_B.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // BT_Calcular
            // 
            this.BT_Calcular.Location = new System.Drawing.Point(187, 54);
            this.BT_Calcular.Name = "BT_Calcular";
            this.BT_Calcular.Size = new System.Drawing.Size(85, 34);
            this.BT_Calcular.TabIndex = 3;
            this.BT_Calcular.Text = "Calcular";
            this.BT_Calcular.UseVisualStyleBackColor = true;
            this.BT_Calcular.Click += new System.EventHandler(this.BT_Calcular_Click);
            // 
            // gBox_OPeraciones
            // 
            this.gBox_OPeraciones.Controls.Add(this.RB_Div);
            this.gBox_OPeraciones.Controls.Add(this.RB_Multi);
            this.gBox_OPeraciones.Controls.Add(this.RB_Resta);
            this.gBox_OPeraciones.Controls.Add(this.RB_Suma);
            this.gBox_OPeraciones.Location = new System.Drawing.Point(12, 194);
            this.gBox_OPeraciones.Name = "gBox_OPeraciones";
            this.gBox_OPeraciones.Size = new System.Drawing.Size(200, 127);
            this.gBox_OPeraciones.TabIndex = 4;
            this.gBox_OPeraciones.TabStop = false;
            this.gBox_OPeraciones.Text = "Operaciones";
            this.gBox_OPeraciones.Enter += new System.EventHandler(this.gBox_OPeraciones_Enter);
            // 
            // RB_Suma
            // 
            this.RB_Suma.AutoSize = true;
            this.RB_Suma.Checked = true;
            this.RB_Suma.Location = new System.Drawing.Point(3, 18);
            this.RB_Suma.Name = "RB_Suma";
            this.RB_Suma.Size = new System.Drawing.Size(63, 20);
            this.RB_Suma.TabIndex = 0;
            this.RB_Suma.TabStop = true;
            this.RB_Suma.Text = "Suma";
            this.RB_Suma.UseVisualStyleBackColor = true;
            // 
            // RB_Resta
            // 
            this.RB_Resta.AutoSize = true;
            this.RB_Resta.Location = new System.Drawing.Point(6, 44);
            this.RB_Resta.Name = "RB_Resta";
            this.RB_Resta.Size = new System.Drawing.Size(64, 20);
            this.RB_Resta.TabIndex = 1;
            this.RB_Resta.Text = "Resta";
            this.RB_Resta.UseVisualStyleBackColor = true;
            // 
            // RB_Multi
            // 
            this.RB_Multi.AutoSize = true;
            this.RB_Multi.Location = new System.Drawing.Point(6, 70);
            this.RB_Multi.Name = "RB_Multi";
            this.RB_Multi.Size = new System.Drawing.Size(109, 20);
            this.RB_Multi.TabIndex = 2;
            this.RB_Multi.Text = "Multiplicacion";
            this.RB_Multi.UseVisualStyleBackColor = true;
            // 
            // RB_Div
            // 
            this.RB_Div.AutoSize = true;
            this.RB_Div.Location = new System.Drawing.Point(6, 96);
            this.RB_Div.Name = "RB_Div";
            this.RB_Div.Size = new System.Drawing.Size(76, 20);
            this.RB_Div.TabIndex = 3;
            this.RB_Div.Text = "Division";
            this.RB_Div.UseVisualStyleBackColor = true;
            // 
            // LB_Resultado
            // 
            this.LB_Resultado.AutoSize = true;
            this.LB_Resultado.Location = new System.Drawing.Point(15, 149);
            this.LB_Resultado.Name = "LB_Resultado";
            this.LB_Resultado.Size = new System.Drawing.Size(44, 16);
            this.LB_Resultado.TabIndex = 5;
            this.LB_Resultado.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 341);
            this.Controls.Add(this.LB_Resultado);
            this.Controls.Add(this.gBox_OPeraciones);
            this.Controls.Add(this.BT_Calcular);
            this.Controls.Add(this.TX_B);
            this.Controls.Add(this.TX_A);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gBox_OPeraciones.ResumeLayout(false);
            this.gBox_OPeraciones.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TX_A;
        private System.Windows.Forms.TextBox TX_B;
        private System.Windows.Forms.Button BT_Calcular;
        private System.Windows.Forms.GroupBox gBox_OPeraciones;
        private System.Windows.Forms.RadioButton RB_Div;
        private System.Windows.Forms.RadioButton RB_Multi;
        private System.Windows.Forms.RadioButton RB_Resta;
        private System.Windows.Forms.RadioButton RB_Suma;
        private System.Windows.Forms.Label LB_Resultado;
    }
}

