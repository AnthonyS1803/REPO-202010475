namespace Proyecto_16
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
            this.DG_Productos = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LB_Codigo = new System.Windows.Forms.Label();
            this.TX_Codigo = new System.Windows.Forms.TextBox();
            this.TX_Nombre = new System.Windows.Forms.TextBox();
            this.LB_Nombre = new System.Windows.Forms.Label();
            this.TX_Precio = new System.Windows.Forms.TextBox();
            this.LB_Precio = new System.Windows.Forms.Label();
            this.LB_Informacion = new System.Windows.Forms.Label();
            this.BT_Agregar = new System.Windows.Forms.Button();
            this.BT_Borrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Productos)).BeginInit();
            this.SuspendLayout();
            // 
            // DG_Productos
            // 
            this.DG_Productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_Productos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nombre,
            this.Precio});
            this.DG_Productos.Location = new System.Drawing.Point(12, 230);
            this.DG_Productos.Name = "DG_Productos";
            this.DG_Productos.RowHeadersWidth = 51;
            this.DG_Productos.RowTemplate.Height = 24;
            this.DG_Productos.Size = new System.Drawing.Size(489, 201);
            this.DG_Productos.TabIndex = 0;
            this.DG_Productos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_Productos_CellClick);
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo Producto";
            this.Codigo.MinimumWidth = 6;
            this.Codigo.Name = "Codigo";
            this.Codigo.Width = 125;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre Producto";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 125;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio producto";
            this.Precio.MinimumWidth = 6;
            this.Precio.Name = "Precio";
            this.Precio.Width = 125;
            // 
            // LB_Codigo
            // 
            this.LB_Codigo.AutoSize = true;
            this.LB_Codigo.Location = new System.Drawing.Point(9, 31);
            this.LB_Codigo.Name = "LB_Codigo";
            this.LB_Codigo.Size = new System.Drawing.Size(54, 16);
            this.LB_Codigo.TabIndex = 1;
            this.LB_Codigo.Text = "Codigo:";
            // 
            // TX_Codigo
            // 
            this.TX_Codigo.Location = new System.Drawing.Point(69, 31);
            this.TX_Codigo.Name = "TX_Codigo";
            this.TX_Codigo.Size = new System.Drawing.Size(100, 22);
            this.TX_Codigo.TabIndex = 2;
            this.TX_Codigo.TextChanged += new System.EventHandler(this.TX_Codigo_TextChanged);
            // 
            // TX_Nombre
            // 
            this.TX_Nombre.Location = new System.Drawing.Point(69, 69);
            this.TX_Nombre.Name = "TX_Nombre";
            this.TX_Nombre.Size = new System.Drawing.Size(100, 22);
            this.TX_Nombre.TabIndex = 4;
            // 
            // LB_Nombre
            // 
            this.LB_Nombre.AutoSize = true;
            this.LB_Nombre.Location = new System.Drawing.Point(9, 69);
            this.LB_Nombre.Name = "LB_Nombre";
            this.LB_Nombre.Size = new System.Drawing.Size(59, 16);
            this.LB_Nombre.TabIndex = 3;
            this.LB_Nombre.Text = "Nombre:";
            // 
            // TX_Precio
            // 
            this.TX_Precio.Location = new System.Drawing.Point(69, 105);
            this.TX_Precio.Name = "TX_Precio";
            this.TX_Precio.Size = new System.Drawing.Size(100, 22);
            this.TX_Precio.TabIndex = 6;
            // 
            // LB_Precio
            // 
            this.LB_Precio.AutoSize = true;
            this.LB_Precio.Location = new System.Drawing.Point(9, 108);
            this.LB_Precio.Name = "LB_Precio";
            this.LB_Precio.Size = new System.Drawing.Size(49, 16);
            this.LB_Precio.TabIndex = 5;
            this.LB_Precio.Text = "Precio:";
            // 
            // LB_Informacion
            // 
            this.LB_Informacion.AutoSize = true;
            this.LB_Informacion.Location = new System.Drawing.Point(14, 180);
            this.LB_Informacion.Name = "LB_Informacion";
            this.LB_Informacion.Size = new System.Drawing.Size(76, 16);
            this.LB_Informacion.TabIndex = 7;
            this.LB_Informacion.Text = "Informacion";
            // 
            // BT_Agregar
            // 
            this.BT_Agregar.Location = new System.Drawing.Point(208, 47);
            this.BT_Agregar.Name = "BT_Agregar";
            this.BT_Agregar.Size = new System.Drawing.Size(93, 28);
            this.BT_Agregar.TabIndex = 8;
            this.BT_Agregar.Text = "Agregar";
            this.BT_Agregar.UseVisualStyleBackColor = true;
            this.BT_Agregar.Click += new System.EventHandler(this.BT_Agregar_Click);
            // 
            // BT_Borrar
            // 
            this.BT_Borrar.Location = new System.Drawing.Point(208, 81);
            this.BT_Borrar.Name = "BT_Borrar";
            this.BT_Borrar.Size = new System.Drawing.Size(93, 28);
            this.BT_Borrar.TabIndex = 9;
            this.BT_Borrar.Text = "Borrar";
            this.BT_Borrar.UseVisualStyleBackColor = true;
            this.BT_Borrar.Click += new System.EventHandler(this.BT_Borrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 450);
            this.Controls.Add(this.BT_Borrar);
            this.Controls.Add(this.BT_Agregar);
            this.Controls.Add(this.LB_Informacion);
            this.Controls.Add(this.TX_Precio);
            this.Controls.Add(this.LB_Precio);
            this.Controls.Add(this.TX_Nombre);
            this.Controls.Add(this.LB_Nombre);
            this.Controls.Add(this.TX_Codigo);
            this.Controls.Add(this.LB_Codigo);
            this.Controls.Add(this.DG_Productos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DG_Productos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DG_Productos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.Label LB_Codigo;
        private System.Windows.Forms.TextBox TX_Codigo;
        private System.Windows.Forms.TextBox TX_Nombre;
        private System.Windows.Forms.Label LB_Nombre;
        private System.Windows.Forms.TextBox TX_Precio;
        private System.Windows.Forms.Label LB_Precio;
        private System.Windows.Forms.Label LB_Informacion;
        private System.Windows.Forms.Button BT_Agregar;
        private System.Windows.Forms.Button BT_Borrar;
    }
}

