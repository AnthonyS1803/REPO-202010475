namespace Proyecto_22
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.LB_Fecha = new System.Windows.Forms.Label();
            this.BT_Calcular = new System.Windows.Forms.Button();
            this.TX_Dias = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(121, 137);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // LB_Fecha
            // 
            this.LB_Fecha.AutoSize = true;
            this.LB_Fecha.Location = new System.Drawing.Point(198, 180);
            this.LB_Fecha.Name = "LB_Fecha";
            this.LB_Fecha.Size = new System.Drawing.Size(44, 16);
            this.LB_Fecha.TabIndex = 1;
            this.LB_Fecha.Text = "label1";
            // 
            // BT_Calcular
            // 
            this.BT_Calcular.Location = new System.Drawing.Point(220, 226);
            this.BT_Calcular.Name = "BT_Calcular";
            this.BT_Calcular.Size = new System.Drawing.Size(75, 23);
            this.BT_Calcular.TabIndex = 2;
            this.BT_Calcular.Text = "Calcular";
            this.BT_Calcular.UseVisualStyleBackColor = true;
            this.BT_Calcular.Click += new System.EventHandler(this.BT_Calcular_Click);
            // 
            // TX_Dias
            // 
            this.TX_Dias.Location = new System.Drawing.Point(101, 227);
            this.TX_Dias.Name = "TX_Dias";
            this.TX_Dias.Size = new System.Drawing.Size(100, 22);
            this.TX_Dias.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 450);
            this.Controls.Add(this.TX_Dias);
            this.Controls.Add(this.BT_Calcular);
            this.Controls.Add(this.LB_Fecha);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label LB_Fecha;
        private System.Windows.Forms.Button BT_Calcular;
        private System.Windows.Forms.TextBox TX_Dias;
    }
}

