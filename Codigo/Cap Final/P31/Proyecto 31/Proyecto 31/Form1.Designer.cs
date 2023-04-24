namespace Proyecto_31
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.process1 = new System.Diagnostics.Process();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TX_Mensaje = new System.Windows.Forms.TextBox();
            this.RB_Manzana = new System.Windows.Forms.RadioButton();
            this.RB_Pera = new System.Windows.Forms.RadioButton();
            this.RB_Ciruela = new System.Windows.Forms.RadioButton();
            this.CH_Importado = new System.Windows.Forms.CheckBox();
            this.CH_Organico = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // process1
            // 
            this.process1.StartInfo.Domain = "";
            this.process1.StartInfo.LoadUserProfile = false;
            this.process1.StartInfo.Password = null;
            this.process1.StartInfo.StandardErrorEncoding = null;
            this.process1.StartInfo.StandardOutputEncoding = null;
            this.process1.StartInfo.UserName = "";
            this.process1.SynchronizingObject = this;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RB_Ciruela);
            this.groupBox1.Controls.Add(this.RB_Pera);
            this.groupBox1.Controls.Add(this.RB_Manzana);
            this.groupBox1.Location = new System.Drawing.Point(25, 106);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(223, 124);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // TX_Mensaje
            // 
            this.TX_Mensaje.Location = new System.Drawing.Point(31, 42);
            this.TX_Mensaje.Name = "TX_Mensaje";
            this.TX_Mensaje.Size = new System.Drawing.Size(100, 22);
            this.TX_Mensaje.TabIndex = 0;
            this.TX_Mensaje.TextChanged += new System.EventHandler(this.TX_Mensaje_TextChanged);
            // 
            // RB_Manzana
            // 
            this.RB_Manzana.AutoSize = true;
            this.RB_Manzana.Location = new System.Drawing.Point(6, 21);
            this.RB_Manzana.Name = "RB_Manzana";
            this.RB_Manzana.Size = new System.Drawing.Size(83, 20);
            this.RB_Manzana.TabIndex = 5;
            this.RB_Manzana.TabStop = true;
            this.RB_Manzana.Text = "Manzana";
            this.RB_Manzana.UseVisualStyleBackColor = true;
            this.RB_Manzana.CheckedChanged += new System.EventHandler(this.RB_Manzana_CheckedChanged);
            // 
            // RB_Pera
            // 
            this.RB_Pera.AutoSize = true;
            this.RB_Pera.Location = new System.Drawing.Point(6, 47);
            this.RB_Pera.Name = "RB_Pera";
            this.RB_Pera.Size = new System.Drawing.Size(57, 20);
            this.RB_Pera.TabIndex = 6;
            this.RB_Pera.TabStop = true;
            this.RB_Pera.Text = "Pera";
            this.RB_Pera.UseVisualStyleBackColor = true;
            this.RB_Pera.CheckedChanged += new System.EventHandler(this.RB_Pera_CheckedChanged);
            // 
            // RB_Ciruela
            // 
            this.RB_Ciruela.AutoSize = true;
            this.RB_Ciruela.Location = new System.Drawing.Point(6, 73);
            this.RB_Ciruela.Name = "RB_Ciruela";
            this.RB_Ciruela.Size = new System.Drawing.Size(70, 20);
            this.RB_Ciruela.TabIndex = 7;
            this.RB_Ciruela.TabStop = true;
            this.RB_Ciruela.Text = "Ciruela";
            this.RB_Ciruela.UseVisualStyleBackColor = true;
            this.RB_Ciruela.CheckedChanged += new System.EventHandler(this.RB_Ciruela_CheckedChanged);
            // 
            // CH_Importado
            // 
            this.CH_Importado.AutoSize = true;
            this.CH_Importado.Location = new System.Drawing.Point(280, 128);
            this.CH_Importado.Name = "CH_Importado";
            this.CH_Importado.Size = new System.Drawing.Size(90, 20);
            this.CH_Importado.TabIndex = 8;
            this.CH_Importado.Text = "Importado";
            this.CH_Importado.UseVisualStyleBackColor = true;
            this.CH_Importado.CheckStateChanged += new System.EventHandler(this.CH_Importado_CheckStateChanged);
            // 
            // CH_Organico
            // 
            this.CH_Organico.AutoSize = true;
            this.CH_Organico.Location = new System.Drawing.Point(280, 165);
            this.CH_Organico.Name = "CH_Organico";
            this.CH_Organico.Size = new System.Drawing.Size(84, 20);
            this.CH_Organico.TabIndex = 9;
            this.CH_Organico.Text = "Organico";
            this.CH_Organico.UseVisualStyleBackColor = true;
            this.CH_Organico.CheckStateChanged += new System.EventHandler(this.CH_Organico_CheckStateChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 336);
            this.Controls.Add(this.CH_Importado);
            this.Controls.Add(this.CH_Organico);
            this.Controls.Add(this.TX_Mensaje);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResizeEnd += new System.EventHandler(this.Form1_ResizeEnd);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Diagnostics.Process process1;
        private System.Windows.Forms.CheckBox CH_Importado;
        private System.Windows.Forms.CheckBox CH_Organico;
        private System.Windows.Forms.TextBox TX_Mensaje;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RB_Ciruela;
        private System.Windows.Forms.RadioButton RB_Pera;
        private System.Windows.Forms.RadioButton RB_Manzana;
    }
}

