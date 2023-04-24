namespace Proyecto_13
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
            this.TM_Prueba = new System.Windows.Forms.Timer(this.components);
            this.LB_Valor = new System.Windows.Forms.Label();
            this.BT_Inicio = new System.Windows.Forms.Button();
            this.BT_Detener = new System.Windows.Forms.Button();
            this.TB_Intervalo = new System.Windows.Forms.TrackBar();
            this.LBT_Valor = new System.Windows.Forms.Label();
            this.PB_Trabajo = new System.Windows.Forms.ProgressBar();
            this.BT_Calculo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TB_Intervalo)).BeginInit();
            this.SuspendLayout();
            // 
            // TM_Prueba
            // 
            this.TM_Prueba.Tick += new System.EventHandler(this.TM_Prueba_Tick);
            // 
            // LB_Valor
            // 
            this.LB_Valor.AutoSize = true;
            this.LB_Valor.Location = new System.Drawing.Point(171, 59);
            this.LB_Valor.Name = "LB_Valor";
            this.LB_Valor.Size = new System.Drawing.Size(44, 16);
            this.LB_Valor.TabIndex = 0;
            this.LB_Valor.Text = "label1";
            // 
            // BT_Inicio
            // 
            this.BT_Inicio.Location = new System.Drawing.Point(230, 31);
            this.BT_Inicio.Name = "BT_Inicio";
            this.BT_Inicio.Size = new System.Drawing.Size(75, 23);
            this.BT_Inicio.TabIndex = 1;
            this.BT_Inicio.Text = "Iniciar";
            this.BT_Inicio.UseVisualStyleBackColor = true;
            this.BT_Inicio.Click += new System.EventHandler(this.BT_Inicio_Click);
            // 
            // BT_Detener
            // 
            this.BT_Detener.Location = new System.Drawing.Point(230, 75);
            this.BT_Detener.Name = "BT_Detener";
            this.BT_Detener.Size = new System.Drawing.Size(75, 23);
            this.BT_Detener.TabIndex = 2;
            this.BT_Detener.Text = "Detener";
            this.BT_Detener.UseVisualStyleBackColor = true;
            this.BT_Detener.Click += new System.EventHandler(this.BT_Detener_Click);
            // 
            // TB_Intervalo
            // 
            this.TB_Intervalo.Location = new System.Drawing.Point(45, 152);
            this.TB_Intervalo.Maximum = 1000;
            this.TB_Intervalo.Minimum = 100;
            this.TB_Intervalo.Name = "TB_Intervalo";
            this.TB_Intervalo.Size = new System.Drawing.Size(297, 56);
            this.TB_Intervalo.TabIndex = 3;
            this.TB_Intervalo.Value = 100;
            this.TB_Intervalo.Scroll += new System.EventHandler(this.TB_Intervalo_Scroll);
            // 
            // LBT_Valor
            // 
            this.LBT_Valor.AutoSize = true;
            this.LBT_Valor.Location = new System.Drawing.Point(171, 211);
            this.LBT_Valor.Name = "LBT_Valor";
            this.LBT_Valor.Size = new System.Drawing.Size(44, 16);
            this.LBT_Valor.TabIndex = 4;
            this.LBT_Valor.Text = "label1";
            // 
            // PB_Trabajo
            // 
            this.PB_Trabajo.Location = new System.Drawing.Point(45, 253);
            this.PB_Trabajo.Name = "PB_Trabajo";
            this.PB_Trabajo.Size = new System.Drawing.Size(297, 23);
            this.PB_Trabajo.TabIndex = 5;
            // 
            // BT_Calculo
            // 
            this.BT_Calculo.Location = new System.Drawing.Point(267, 305);
            this.BT_Calculo.Name = "BT_Calculo";
            this.BT_Calculo.Size = new System.Drawing.Size(75, 23);
            this.BT_Calculo.TabIndex = 6;
            this.BT_Calculo.Text = "Calcular";
            this.BT_Calculo.UseVisualStyleBackColor = true;
            this.BT_Calculo.Click += new System.EventHandler(this.BT_Calculo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 352);
            this.Controls.Add(this.BT_Calculo);
            this.Controls.Add(this.PB_Trabajo);
            this.Controls.Add(this.LBT_Valor);
            this.Controls.Add(this.TB_Intervalo);
            this.Controls.Add(this.BT_Detener);
            this.Controls.Add(this.BT_Inicio);
            this.Controls.Add(this.LB_Valor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TB_Intervalo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer TM_Prueba;
        private System.Windows.Forms.Label LB_Valor;
        private System.Windows.Forms.Button BT_Inicio;
        private System.Windows.Forms.Button BT_Detener;
        private System.Windows.Forms.TrackBar TB_Intervalo;
        private System.Windows.Forms.Label LBT_Valor;
        private System.Windows.Forms.ProgressBar PB_Trabajo;
        private System.Windows.Forms.Button BT_Calculo;
    }
}

