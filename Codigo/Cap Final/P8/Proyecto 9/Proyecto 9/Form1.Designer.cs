namespace Proyecto_9
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
            this.cc = new System.Windows.Forms.Label();
            this.TX_Nombre = new System.Windows.Forms.TextBox();
            this.LB_Seguro = new System.Windows.Forms.Label();
            this.GB_1 = new System.Windows.Forms.GroupBox();
            this.RB_Basico = new System.Windows.Forms.RadioButton();
            this.RB_TE = new System.Windows.Forms.RadioButton();
            this.RB_Total = new System.Windows.Forms.RadioButton();
            this.GB_Equipamiento = new System.Windows.Forms.GroupBox();
            this.LB_Equipo = new System.Windows.Forms.Label();
            this.CH_Aire = new System.Windows.Forms.CheckBox();
            this.CH_Audio = new System.Windows.Forms.CheckBox();
            this.LB_Costo = new System.Windows.Forms.Label();
            this.TX_Costo = new System.Windows.Forms.TextBox();
            this.BT_Cotizar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.GB_1.SuspendLayout();
            this.GB_Equipamiento.SuspendLayout();
            this.SuspendLayout();
            // 
            // cc
            // 
            this.cc.AutoSize = true;
            this.cc.Location = new System.Drawing.Point(12, 32);
            this.cc.Name = "cc";
            this.cc.Size = new System.Drawing.Size(59, 16);
            this.cc.TabIndex = 0;
            this.cc.Text = "Nombre:";
            // 
            // TX_Nombre
            // 
            this.TX_Nombre.Location = new System.Drawing.Point(77, 32);
            this.TX_Nombre.Name = "TX_Nombre";
            this.TX_Nombre.Size = new System.Drawing.Size(100, 22);
            this.TX_Nombre.TabIndex = 1;
            // 
            // LB_Seguro
            // 
            this.LB_Seguro.AutoSize = true;
            this.LB_Seguro.Location = new System.Drawing.Point(6, 31);
            this.LB_Seguro.Name = "LB_Seguro";
            this.LB_Seguro.Size = new System.Drawing.Size(54, 16);
            this.LB_Seguro.TabIndex = 2;
            this.LB_Seguro.Text = "Seguro:";
            // 
            // GB_1
            // 
            this.GB_1.Controls.Add(this.RB_Total);
            this.GB_1.Controls.Add(this.RB_TE);
            this.GB_1.Controls.Add(this.RB_Basico);
            this.GB_1.Controls.Add(this.LB_Seguro);
            this.GB_1.Location = new System.Drawing.Point(15, 85);
            this.GB_1.Name = "GB_1";
            this.GB_1.Size = new System.Drawing.Size(200, 151);
            this.GB_1.TabIndex = 3;
            this.GB_1.TabStop = false;
            this.GB_1.Text = "Seguro a seleccionar ";
            // 
            // RB_Basico
            // 
            this.RB_Basico.AutoSize = true;
            this.RB_Basico.Location = new System.Drawing.Point(56, 50);
            this.RB_Basico.Name = "RB_Basico";
            this.RB_Basico.Size = new System.Drawing.Size(70, 20);
            this.RB_Basico.TabIndex = 3;
            this.RB_Basico.TabStop = true;
            this.RB_Basico.Text = "Basico";
            this.RB_Basico.UseVisualStyleBackColor = true;
            // 
            // RB_TE
            // 
            this.RB_TE.AutoSize = true;
            this.RB_TE.Location = new System.Drawing.Point(56, 76);
            this.RB_TE.Name = "RB_TE";
            this.RB_TE.Size = new System.Drawing.Size(89, 20);
            this.RB_TE.TabIndex = 4;
            this.RB_TE.TabStop = true;
            this.RB_TE.Text = "A terceros";
            this.RB_TE.UseVisualStyleBackColor = true;
            // 
            // RB_Total
            // 
            this.RB_Total.AutoSize = true;
            this.RB_Total.Location = new System.Drawing.Point(56, 102);
            this.RB_Total.Name = "RB_Total";
            this.RB_Total.Size = new System.Drawing.Size(59, 20);
            this.RB_Total.TabIndex = 5;
            this.RB_Total.TabStop = true;
            this.RB_Total.Text = "Total";
            this.RB_Total.UseVisualStyleBackColor = true;
            // 
            // GB_Equipamiento
            // 
            this.GB_Equipamiento.Controls.Add(this.CH_Audio);
            this.GB_Equipamiento.Controls.Add(this.CH_Aire);
            this.GB_Equipamiento.Controls.Add(this.LB_Equipo);
            this.GB_Equipamiento.Location = new System.Drawing.Point(235, 85);
            this.GB_Equipamiento.Name = "GB_Equipamiento";
            this.GB_Equipamiento.Size = new System.Drawing.Size(211, 151);
            this.GB_Equipamiento.TabIndex = 6;
            this.GB_Equipamiento.TabStop = false;
            this.GB_Equipamiento.Text = "Equipamiento";
            // 
            // LB_Equipo
            // 
            this.LB_Equipo.AutoSize = true;
            this.LB_Equipo.Location = new System.Drawing.Point(6, 30);
            this.LB_Equipo.Name = "LB_Equipo";
            this.LB_Equipo.Size = new System.Drawing.Size(53, 16);
            this.LB_Equipo.TabIndex = 6;
            this.LB_Equipo.Text = "Equipo:";
            // 
            // CH_Aire
            // 
            this.CH_Aire.AutoSize = true;
            this.CH_Aire.Location = new System.Drawing.Point(48, 60);
            this.CH_Aire.Name = "CH_Aire";
            this.CH_Aire.Size = new System.Drawing.Size(146, 20);
            this.CH_Aire.TabIndex = 7;
            this.CH_Aire.Text = "Aire acondicionado";
            this.CH_Aire.UseVisualStyleBackColor = true;
            // 
            // CH_Audio
            // 
            this.CH_Audio.AutoSize = true;
            this.CH_Audio.Location = new System.Drawing.Point(48, 98);
            this.CH_Audio.Name = "CH_Audio";
            this.CH_Audio.Size = new System.Drawing.Size(134, 20);
            this.CH_Audio.TabIndex = 8;
            this.CH_Audio.Text = "Sistema de audio";
            this.CH_Audio.UseVisualStyleBackColor = true;
            // 
            // LB_Costo
            // 
            this.LB_Costo.AutoSize = true;
            this.LB_Costo.Location = new System.Drawing.Point(12, 266);
            this.LB_Costo.Name = "LB_Costo";
            this.LB_Costo.Size = new System.Drawing.Size(45, 16);
            this.LB_Costo.TabIndex = 7;
            this.LB_Costo.Text = "Costo:";
            // 
            // TX_Costo
            // 
            this.TX_Costo.Location = new System.Drawing.Point(63, 263);
            this.TX_Costo.Name = "TX_Costo";
            this.TX_Costo.Size = new System.Drawing.Size(100, 22);
            this.TX_Costo.TabIndex = 8;
            // 
            // BT_Cotizar
            // 
            this.BT_Cotizar.Location = new System.Drawing.Point(206, 263);
            this.BT_Cotizar.Name = "BT_Cotizar";
            this.BT_Cotizar.Size = new System.Drawing.Size(88, 33);
            this.BT_Cotizar.TabIndex = 9;
            this.BT_Cotizar.Text = "Cotizar";
            this.BT_Cotizar.UseVisualStyleBackColor = true;
            this.BT_Cotizar.Click += new System.EventHandler(this.BT_Cotizar_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 319);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(491, 138);
            this.textBox1.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 479);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.BT_Cotizar);
            this.Controls.Add(this.TX_Costo);
            this.Controls.Add(this.LB_Costo);
            this.Controls.Add(this.GB_Equipamiento);
            this.Controls.Add(this.GB_1);
            this.Controls.Add(this.TX_Nombre);
            this.Controls.Add(this.cc);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GB_1.ResumeLayout(false);
            this.GB_1.PerformLayout();
            this.GB_Equipamiento.ResumeLayout(false);
            this.GB_Equipamiento.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label cc;
        private System.Windows.Forms.TextBox TX_Nombre;
        private System.Windows.Forms.Label LB_Seguro;
        private System.Windows.Forms.GroupBox GB_1;
        private System.Windows.Forms.RadioButton RB_Total;
        private System.Windows.Forms.RadioButton RB_TE;
        private System.Windows.Forms.RadioButton RB_Basico;
        private System.Windows.Forms.GroupBox GB_Equipamiento;
        private System.Windows.Forms.CheckBox CH_Audio;
        private System.Windows.Forms.CheckBox CH_Aire;
        private System.Windows.Forms.Label LB_Equipo;
        private System.Windows.Forms.Label LB_Costo;
        private System.Windows.Forms.TextBox TX_Costo;
        private System.Windows.Forms.Button BT_Cotizar;
        private System.Windows.Forms.TextBox textBox1;
    }
}

