namespace Proyecto_28
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
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.BTN_Fechas = new System.Windows.Forms.Button();
            this.LB_Inicio = new System.Windows.Forms.Label();
            this.LB_Final = new System.Windows.Forms.Label();
            this.LB_Seleccion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(18, 4);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // BTN_Fechas
            // 
            this.BTN_Fechas.Location = new System.Drawing.Point(386, 89);
            this.BTN_Fechas.Name = "BTN_Fechas";
            this.BTN_Fechas.Size = new System.Drawing.Size(75, 23);
            this.BTN_Fechas.TabIndex = 1;
            this.BTN_Fechas.Text = "Fechas";
            this.BTN_Fechas.UseVisualStyleBackColor = true;
            this.BTN_Fechas.Click += new System.EventHandler(this.BTN_Fechas_Click);
            // 
            // LB_Inicio
            // 
            this.LB_Inicio.AutoSize = true;
            this.LB_Inicio.Location = new System.Drawing.Point(31, 246);
            this.LB_Inicio.Name = "LB_Inicio";
            this.LB_Inicio.Size = new System.Drawing.Size(44, 16);
            this.LB_Inicio.TabIndex = 2;
            this.LB_Inicio.Text = "label1";
            // 
            // LB_Final
            // 
            this.LB_Final.AutoSize = true;
            this.LB_Final.Location = new System.Drawing.Point(31, 296);
            this.LB_Final.Name = "LB_Final";
            this.LB_Final.Size = new System.Drawing.Size(44, 16);
            this.LB_Final.TabIndex = 3;
            this.LB_Final.Text = "label2";
            // 
            // LB_Seleccion
            // 
            this.LB_Seleccion.AutoSize = true;
            this.LB_Seleccion.Location = new System.Drawing.Point(31, 336);
            this.LB_Seleccion.Name = "LB_Seleccion";
            this.LB_Seleccion.Size = new System.Drawing.Size(44, 16);
            this.LB_Seleccion.TabIndex = 4;
            this.LB_Seleccion.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LB_Seleccion);
            this.Controls.Add(this.LB_Final);
            this.Controls.Add(this.LB_Inicio);
            this.Controls.Add(this.BTN_Fechas);
            this.Controls.Add(this.monthCalendar1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button BTN_Fechas;
        private System.Windows.Forms.Label LB_Inicio;
        private System.Windows.Forms.Label LB_Final;
        private System.Windows.Forms.Label LB_Seleccion;
    }
}

