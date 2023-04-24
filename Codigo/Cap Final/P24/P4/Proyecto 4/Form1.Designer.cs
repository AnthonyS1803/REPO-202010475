namespace Proyecto_4
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
            this.LBL_Mensaje = new System.Windows.Forms.Label();
            this.BT_Calcular = new System.Windows.Forms.Button();
            this.CH_Monitor = new System.Windows.Forms.CheckBox();
            this.CH_Mouse = new System.Windows.Forms.CheckBox();
            this.CH_Teclado = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // LBL_Mensaje
            // 
            this.LBL_Mensaje.AutoSize = true;
            this.LBL_Mensaje.Location = new System.Drawing.Point(34, 213);
            this.LBL_Mensaje.Name = "LBL_Mensaje";
            this.LBL_Mensaje.Size = new System.Drawing.Size(44, 16);
            this.LBL_Mensaje.TabIndex = 3;
            this.LBL_Mensaje.Text = "label1";
            // 
            // BT_Calcular
            // 
            this.BT_Calcular.Location = new System.Drawing.Point(12, 144);
            this.BT_Calcular.Name = "BT_Calcular";
            this.BT_Calcular.Size = new System.Drawing.Size(93, 38);
            this.BT_Calcular.TabIndex = 4;
            this.BT_Calcular.Text = "Calcular";
            this.BT_Calcular.UseVisualStyleBackColor = true;
            this.BT_Calcular.Click += new System.EventHandler(this.BT_Calcular_Click);
            // 
            // CH_Monitor
            // 
            this.CH_Monitor.AutoSize = true;
            this.CH_Monitor.Location = new System.Drawing.Point(12, 63);
            this.CH_Monitor.Name = "CH_Monitor";
            this.CH_Monitor.Size = new System.Drawing.Size(104, 20);
            this.CH_Monitor.TabIndex = 5;
            this.CH_Monitor.Text = "Monitor $250";
            this.CH_Monitor.UseVisualStyleBackColor = true;
            this.CH_Monitor.CheckedChanged += new System.EventHandler(this.CH_Monitor_CheckedChanged);
            // 
            // CH_Mouse
            // 
            this.CH_Mouse.AutoSize = true;
            this.CH_Mouse.Location = new System.Drawing.Point(12, 115);
            this.CH_Mouse.Name = "CH_Mouse";
            this.CH_Mouse.Size = new System.Drawing.Size(94, 20);
            this.CH_Mouse.TabIndex = 7;
            this.CH_Mouse.Text = "Mouse $15";
            this.CH_Mouse.UseVisualStyleBackColor = true;
            this.CH_Mouse.CheckedChanged += new System.EventHandler(this.CH_Mouse_CheckedChanged);
            // 
            // CH_Teclado
            // 
            this.CH_Teclado.AutoSize = true;
            this.CH_Teclado.Location = new System.Drawing.Point(12, 89);
            this.CH_Teclado.Name = "CH_Teclado";
            this.CH_Teclado.Size = new System.Drawing.Size(104, 20);
            this.CH_Teclado.TabIndex = 8;
            this.CH_Teclado.Text = "Teclado $20";
            this.CH_Teclado.UseVisualStyleBackColor = true;
            this.CH_Teclado.CheckedChanged += new System.EventHandler(this.CH_Teclado_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 267);
            this.Controls.Add(this.CH_Teclado);
            this.Controls.Add(this.CH_Mouse);
            this.Controls.Add(this.CH_Monitor);
            this.Controls.Add(this.BT_Calcular);
            this.Controls.Add(this.LBL_Mensaje);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LBL_Mensaje;
        private System.Windows.Forms.Button BT_Calcular;
        private System.Windows.Forms.CheckBox CH_Monitor;
        private System.Windows.Forms.CheckBox CH_Mouse;
        private System.Windows.Forms.CheckBox CH_Teclado;
    }
}

