namespace FrmCategoria
{
    partial class FrmProductos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DGProductos = new DataGridView();
            StrCodigo = new DataGridViewTextBoxColumn();
            StrNombre = new DataGridViewTextBoxColumn();
            IdCategoria = new DataGridViewTextBoxColumn();
            NumPrecioVenta = new DataGridViewTextBoxColumn();
            NumStock = new DataGridViewTextBoxColumn();
            BtnEditar = new DataGridViewButtonColumn();
            BtnEliminar = new DataGridViewButtonColumn();
            labelproductos = new Label();
            panel1 = new Panel();
            TxtBuscar = new TextBox();
            panel2 = new Panel();
            BtnNuevoProducto = new Button();
            BtnSalir = new Button();
            ((System.ComponentModel.ISupportInitialize)DGProductos).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // DGProductos
            // 
            DGProductos.BackgroundColor = SystemColors.ButtonFace;
            DGProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGProductos.Columns.AddRange(new DataGridViewColumn[] { StrCodigo, StrNombre, IdCategoria, NumPrecioVenta, NumStock, BtnEditar, BtnEliminar });
            DGProductos.Location = new Point(32, 211);
            DGProductos.Margin = new Padding(5, 4, 5, 4);
            DGProductos.Name = "DGProductos";
            DGProductos.RowHeadersWidth = 51;
            DGProductos.Size = new Size(1175, 575);
            DGProductos.TabIndex = 5;
            DGProductos.CellContentClick += DGProductos_CellContentClick;
            // 
            // StrCodigo
            // 
            StrCodigo.DataPropertyName = "StrCodigo";
            StrCodigo.HeaderText = "ID";
            StrCodigo.MinimumWidth = 6;
            StrCodigo.Name = "StrCodigo";
            StrCodigo.Width = 30;
            // 
            // StrNombre
            // 
            StrNombre.DataPropertyName = "StrNombre";
            StrNombre.HeaderText = "PRODUCTO";
            StrNombre.MinimumWidth = 6;
            StrNombre.Name = "StrNombre";
            StrNombre.Width = 230;
            // 
            // IdCategoria
            // 
            IdCategoria.DataPropertyName = "IdCategoria";
            IdCategoria.HeaderText = "CATEGORIA";
            IdCategoria.MinimumWidth = 6;
            IdCategoria.Name = "IdCategoria";
            IdCategoria.Width = 190;
            // 
            // NumPrecioVenta
            // 
            NumPrecioVenta.DataPropertyName = "NumPrecioVenta";
            NumPrecioVenta.HeaderText = "PRECIO";
            NumPrecioVenta.MinimumWidth = 6;
            NumPrecioVenta.Name = "NumPrecioVenta";
            NumPrecioVenta.Width = 130;
            // 
            // NumStock
            // 
            NumStock.DataPropertyName = "NumStock";
            NumStock.HeaderText = "STOCK";
            NumStock.MinimumWidth = 6;
            NumStock.Name = "NumStock";
            NumStock.Width = 120;
            // 
            // BtnEditar
            // 
            BtnEditar.HeaderText = "EDITAR";
            BtnEditar.MinimumWidth = 6;
            BtnEditar.Name = "BtnEditar";
            BtnEditar.Text = "Editar";
            BtnEditar.UseColumnTextForButtonValue = true;
            BtnEditar.Width = 65;
            // 
            // BtnEliminar
            // 
            BtnEliminar.HeaderText = "ELIMINAR";
            BtnEliminar.MinimumWidth = 6;
            BtnEliminar.Name = "BtnEliminar";
            BtnEliminar.Text = "Eliminar";
            BtnEliminar.UseColumnTextForButtonValue = true;
            BtnEliminar.Width = 65;
            // 
            // labelproductos
            // 
            labelproductos.AutoSize = true;
            labelproductos.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelproductos.ForeColor = Color.White;
            labelproductos.Location = new Point(351, 29);
            labelproductos.Margin = new Padding(5, 0, 5, 0);
            labelproductos.Name = "labelproductos";
            labelproductos.Size = new Size(546, 36);
            labelproductos.TabIndex = 1;
            labelproductos.Text = "ADMINISTRACIÓN DE PRODUCTOS";
            // 
            // panel1
            // 
            panel1.Controls.Add(labelproductos);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(5, 4, 5, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1350, 101);
            panel1.TabIndex = 6;
            // 
            // TxtBuscar
            // 
            TxtBuscar.BackColor = Color.FromArgb(47, 62, 153);
            TxtBuscar.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtBuscar.ForeColor = SystemColors.Window;
            TxtBuscar.Location = new Point(31, 16);
            TxtBuscar.Margin = new Padding(5, 4, 5, 4);
            TxtBuscar.Name = "TxtBuscar";
            TxtBuscar.Size = new Size(718, 34);
            TxtBuscar.TabIndex = 6;
            TxtBuscar.TextChanged += TxtBuscar_TextChanged_1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(47, 62, 153);
            panel2.Controls.Add(BtnNuevoProducto);
            panel2.Controls.Add(BtnSalir);
            panel2.Controls.Add(TxtBuscar);
            panel2.Dock = DockStyle.Top;
            panel2.ForeColor = SystemColors.Info;
            panel2.Location = new Point(0, 101);
            panel2.Margin = new Padding(5, 4, 5, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1350, 73);
            panel2.TabIndex = 7;
            // 
            // BtnNuevoProducto
            // 
            BtnNuevoProducto.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnNuevoProducto.ForeColor = SystemColors.Desktop;
            BtnNuevoProducto.Location = new Point(805, 7);
            BtnNuevoProducto.Margin = new Padding(3, 4, 3, 4);
            BtnNuevoProducto.Name = "BtnNuevoProducto";
            BtnNuevoProducto.Size = new Size(219, 56);
            BtnNuevoProducto.TabIndex = 8;
            BtnNuevoProducto.Text = "Agregar Producto";
            BtnNuevoProducto.UseVisualStyleBackColor = true;
            BtnNuevoProducto.Click += BtnNuevoProducto_Click;
            // 
            // BtnSalir
            // 
            BtnSalir.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnSalir.ForeColor = SystemColors.Desktop;
            BtnSalir.Location = new Point(1079, 7);
            BtnSalir.Margin = new Padding(3, 4, 3, 4);
            BtnSalir.Name = "BtnSalir";
            BtnSalir.Size = new Size(106, 56);
            BtnSalir.TabIndex = 6;
            BtnSalir.Text = "Salir";
            BtnSalir.UseVisualStyleBackColor = true;
            BtnSalir.Click += BtnSalir_Click;
            // 
            // FrmProductos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(63, 81, 181);
            ClientSize = new Size(1350, 823);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(DGProductos);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5, 4, 5, 4);
            Name = "FrmProductos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmProductos";
            Load += FrmProductos_Load;
            ((System.ComponentModel.ISupportInitialize)DGProductos).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.DataGridView DGProductos;
        private System.Windows.Forms.Label labelproductos;
        private System.Windows.Forms.Panel panel1;
        /* private MaterialSkin.Controls.MaterialRaisedButton BtnBuscar;
        private MaterialSkin.Controls.MaterialRaisedButton BtnNuevo;
        private MaterialSkin.Controls.MaterialRaisedButton BtnSalir; */
        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.Panel panel2;
        private Button BtnSalir;
        private Button BtnNuevoProducto;
        private DataGridViewTextBoxColumn StrCodigo;
        private DataGridViewTextBoxColumn StrNombre;
        private DataGridViewTextBoxColumn IdCategoria;
        private DataGridViewTextBoxColumn NumPrecioVenta;
        private DataGridViewTextBoxColumn NumStock;
        private DataGridViewButtonColumn BtnEditar;
        private DataGridViewButtonColumn BtnEliminar;
    }
}