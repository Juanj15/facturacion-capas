namespace FrmCategoria
{
    partial class FrmInsertarProductos
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
            BtnCancelar = new Button();
            BtnGuardar = new Button();
            LblTituloProducto = new Label();
            TxtStock = new TextBox();
            TxtVenta = new TextBox();
            TxtCompra = new TextBox();
            TxTId_Producto = new TextBox();
            TxtReferencia = new TextBox();
            TxtNombre = new TextBox();
            LblStock = new Label();
            LblPrecioVenta = new Label();
            LblPrecioCompra = new Label();
            LblNroReferencia = new Label();
            LblNombreProducto = new Label();
            TxtDetalle = new TextBox();
            LblDetalleProducto = new Label();
            textBox1 = new TextBox();
            LblRutaImagen = new Label();
            ComboxCategoria = new ComboBox();
            LblCategoria = new Label();
            SuspendLayout();
            // 
            // BtnCancelar
            // 
            BtnCancelar.BackColor = Color.Red;
            BtnCancelar.FlatStyle = FlatStyle.Popup;
            BtnCancelar.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnCancelar.ForeColor = SystemColors.Control;
            BtnCancelar.Location = new Point(384, 391);
            BtnCancelar.Margin = new Padding(4, 3, 4, 3);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(138, 35);
            BtnCancelar.TabIndex = 7;
            BtnCancelar.Text = "Cancelar";
            BtnCancelar.UseVisualStyleBackColor = false;
            BtnCancelar.Click += BtnCancelar_Click;
            // 
            // BtnGuardar
            // 
            BtnGuardar.BackColor = Color.Blue;
            BtnGuardar.FlatStyle = FlatStyle.Popup;
            BtnGuardar.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnGuardar.ForeColor = SystemColors.Control;
            BtnGuardar.Location = new Point(212, 391);
            BtnGuardar.Margin = new Padding(4, 3, 4, 3);
            BtnGuardar.Name = "BtnGuardar";
            BtnGuardar.Size = new Size(138, 35);
            BtnGuardar.TabIndex = 8;
            BtnGuardar.Text = "Guardar";
            BtnGuardar.UseVisualStyleBackColor = false;
            BtnGuardar.Click += BtnGuardar_Click;
            // 
            // LblTituloProducto
            // 
            LblTituloProducto.AutoSize = true;
            LblTituloProducto.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblTituloProducto.ForeColor = Color.White;
            LblTituloProducto.Location = new Point(35, 10);
            LblTituloProducto.Margin = new Padding(4, 0, 4, 0);
            LblTituloProducto.Name = "LblTituloProducto";
            LblTituloProducto.Size = new Size(197, 31);
            LblTituloProducto.TabIndex = 9;
            LblTituloProducto.Text = "Titulo Producto";
            
            // 
            // TxtStock
            // 
            TxtStock.BackColor = Color.MintCream;
            TxtStock.BorderStyle = BorderStyle.FixedSingle;
            TxtStock.ForeColor = SystemColors.ActiveCaptionText;
            TxtStock.Location = new Point(64, 342);
            TxtStock.Margin = new Padding(4, 3, 4, 3);
            TxtStock.Name = "TxtStock";
            TxtStock.Size = new Size(284, 23);
            TxtStock.TabIndex = 31;
            // 
            // TxtVenta
            // 
            TxtVenta.BackColor = Color.MintCream;
            TxtVenta.BorderStyle = BorderStyle.FixedSingle;
            TxtVenta.ForeColor = SystemColors.ActiveCaptionText;
            TxtVenta.Location = new Point(64, 282);
            TxtVenta.Margin = new Padding(4, 3, 4, 3);
            TxtVenta.Name = "TxtVenta";
            TxtVenta.Size = new Size(284, 23);
            TxtVenta.TabIndex = 30;
            // 
            // TxtCompra
            // 
            TxtCompra.BackColor = Color.MintCream;
            TxtCompra.BorderStyle = BorderStyle.FixedSingle;
            TxtCompra.ForeColor = SystemColors.ActiveCaptionText;
            TxtCompra.Location = new Point(64, 222);
            TxtCompra.Margin = new Padding(4, 3, 4, 3);
            TxtCompra.Name = "TxtCompra";
            TxtCompra.Size = new Size(284, 23);
            TxtCompra.TabIndex = 29;
            // 
            // TxTId_Producto
            // 
            TxTId_Producto.BackColor = Color.MintCream;
            TxTId_Producto.BorderStyle = BorderStyle.FixedSingle;
            TxTId_Producto.ForeColor = SystemColors.ActiveCaptionText;
            TxTId_Producto.Location = new Point(679, 67);
            TxTId_Producto.Margin = new Padding(4, 3, 4, 3);
            TxTId_Producto.Name = "TxTId_Producto";
            TxTId_Producto.Size = new Size(21, 23);
            TxTId_Producto.TabIndex = 28;
            // 
            // TxtReferencia
            // 
            TxtReferencia.BackColor = Color.MintCream;
            TxtReferencia.BorderStyle = BorderStyle.FixedSingle;
            TxtReferencia.ForeColor = SystemColors.ActiveCaptionText;
            TxtReferencia.Location = new Point(38, 162);
            TxtReferencia.Margin = new Padding(4, 3, 4, 3);
            TxtReferencia.Name = "TxtReferencia";
            TxtReferencia.Size = new Size(310, 23);
            TxtReferencia.TabIndex = 27;
            // 
            // TxtNombre
            // 
            TxtNombre.BackColor = Color.MintCream;
            TxtNombre.BorderStyle = BorderStyle.FixedSingle;
            TxtNombre.ForeColor = SystemColors.ActiveCaptionText;
            TxtNombre.Location = new Point(38, 102);
            TxtNombre.Margin = new Padding(4, 3, 4, 3);
            TxtNombre.Name = "TxtNombre";
            TxtNombre.Size = new Size(310, 23);
            TxtNombre.TabIndex = 26;
            // 
            // LblStock
            // 
            LblStock.AutoSize = true;
            LblStock.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblStock.ForeColor = Color.White;
            LblStock.Location = new Point(58, 316);
            LblStock.Margin = new Padding(4, 0, 4, 0);
            LblStock.Name = "LblStock";
            LblStock.Size = new Size(111, 19);
            LblStock.TabIndex = 25;
            LblStock.Text = "Cantidad Stock";
            // 
            // LblPrecioVenta
            // 
            LblPrecioVenta.AutoSize = true;
            LblPrecioVenta.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblPrecioVenta.ForeColor = Color.White;
            LblPrecioVenta.Location = new Point(58, 256);
            LblPrecioVenta.Margin = new Padding(4, 0, 4, 0);
            LblPrecioVenta.Name = "LblPrecioVenta";
            LblPrecioVenta.Size = new Size(109, 19);
            LblPrecioVenta.TabIndex = 24;
            LblPrecioVenta.Text = "💲 Precio Venta";
            // 
            // LblPrecioCompra
            // 
            LblPrecioCompra.AutoSize = true;
            LblPrecioCompra.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblPrecioCompra.ForeColor = Color.White;
            LblPrecioCompra.Location = new Point(58, 196);
            LblPrecioCompra.Margin = new Padding(4, 0, 4, 0);
            LblPrecioCompra.Name = "LblPrecioCompra";
            LblPrecioCompra.Size = new Size(123, 19);
            LblPrecioCompra.TabIndex = 23;
            LblPrecioCompra.Text = "💲 Precio Compra";
            
            // 
            // LblNroReferencia
            // 
            LblNroReferencia.AutoSize = true;
            LblNroReferencia.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblNroReferencia.ForeColor = Color.White;
            LblNroReferencia.Location = new Point(34, 136);
            LblNroReferencia.Margin = new Padding(4, 0, 4, 0);
            LblNroReferencia.Name = "LblNroReferencia";
            LblNroReferencia.Size = new Size(117, 19);
            LblNroReferencia.TabIndex = 22;
            LblNroReferencia.Text = "Nro. Referencia";
            // 
            // LblNombreProducto
            // 
            LblNombreProducto.AutoSize = true;
            LblNombreProducto.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblNombreProducto.ForeColor = Color.White;
            LblNombreProducto.Location = new Point(34, 76);
            LblNombreProducto.Margin = new Padding(4, 0, 4, 0);
            LblNombreProducto.Name = "LblNombreProducto";
            LblNombreProducto.Size = new Size(126, 19);
            LblNombreProducto.TabIndex = 21;
            LblNombreProducto.Text = "Nombre Producto";
            // 
            // TxtDetalle
            // 
            TxtDetalle.BackColor = Color.MintCream;
            TxtDetalle.BorderStyle = BorderStyle.FixedSingle;
            TxtDetalle.ForeColor = SystemColors.ActiveCaptionText;
            TxtDetalle.Location = new Point(390, 222);
            TxtDetalle.Margin = new Padding(4, 3, 4, 3);
            TxtDetalle.Multiline = true;
            TxtDetalle.Name = "TxtDetalle";
            TxtDetalle.Size = new Size(310, 143);
            TxtDetalle.TabIndex = 33;
            // 
            // LblDetalleProducto
            // 
            LblDetalleProducto.AutoSize = true;
            LblDetalleProducto.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblDetalleProducto.ForeColor = Color.White;
            LblDetalleProducto.Location = new Point(385, 196);
            LblDetalleProducto.Margin = new Padding(4, 0, 4, 0);
            LblDetalleProducto.Name = "LblDetalleProducto";
            LblDetalleProducto.Size = new Size(121, 19);
            LblDetalleProducto.TabIndex = 32;
            LblDetalleProducto.Text = "Detalle Producto";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.MintCream;
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.ForeColor = SystemColors.ActiveCaptionText;
            textBox1.Location = new Point(390, 162);
            textBox1.Margin = new Padding(4, 3, 4, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(310, 23);
            textBox1.TabIndex = 35;
            // 
            // LblRutaImagen
            // 
            LblRutaImagen.AutoSize = true;
            LblRutaImagen.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblRutaImagen.ForeColor = Color.White;
            LblRutaImagen.Location = new Point(385, 137);
            LblRutaImagen.Margin = new Padding(4, 0, 4, 0);
            LblRutaImagen.Name = "LblRutaImagen";
            LblRutaImagen.Size = new Size(96, 19);
            LblRutaImagen.TabIndex = 34;
            LblRutaImagen.Text = "Ruta Imagen";
            // 
            // ComboxCategoria
            // 
            ComboxCategoria.BackColor = Color.MintCream;
            ComboxCategoria.FlatStyle = FlatStyle.Flat;
            ComboxCategoria.ForeColor = SystemColors.ActiveCaptionText;
            ComboxCategoria.FormattingEnabled = true;
            ComboxCategoria.Items.AddRange(new object[] { "Categoria 1", "Categoria 2", "Categoria 3" });
            ComboxCategoria.Location = new Point(391, 102);
            ComboxCategoria.Margin = new Padding(4, 3, 4, 3);
            ComboxCategoria.Name = "ComboxCategoria";
            ComboxCategoria.Size = new Size(310, 23);
            ComboxCategoria.TabIndex = 36;
            // 
            // LblCategoria
            // 
            LblCategoria.AutoSize = true;
            LblCategoria.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblCategoria.ForeColor = Color.White;
            LblCategoria.Location = new Point(385, 76);
            LblCategoria.Margin = new Padding(4, 0, 4, 0);
            LblCategoria.Name = "LblCategoria";
            LblCategoria.Size = new Size(75, 19);
            LblCategoria.TabIndex = 37;
            LblCategoria.Text = "Categoria";
            // 
            // FrmInsertarProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(47, 62, 153);
            ClientSize = new Size(737, 438);
            Controls.Add(LblCategoria);
            Controls.Add(ComboxCategoria);
            Controls.Add(textBox1);
            Controls.Add(LblRutaImagen);
            Controls.Add(TxtDetalle);
            Controls.Add(LblDetalleProducto);
            Controls.Add(TxtStock);
            Controls.Add(TxtVenta);
            Controls.Add(TxtCompra);
            Controls.Add(TxTId_Producto);
            Controls.Add(TxtReferencia);
            Controls.Add(TxtNombre);
            Controls.Add(LblStock);
            Controls.Add(LblPrecioVenta);
            Controls.Add(LblPrecioCompra);
            Controls.Add(LblNroReferencia);
            Controls.Add(LblNombreProducto);
            Controls.Add(LblTituloProducto);
            Controls.Add(BtnGuardar);
            Controls.Add(BtnCancelar);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "FrmInsertarProductos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmInsertarProductos";
            Load += FrmInsertarProductos_Load;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Label LblTituloProducto;
        private System.Windows.Forms.TextBox TxtStock;
        private System.Windows.Forms.TextBox TxtVenta;
        private System.Windows.Forms.TextBox TxtCompra;
        private System.Windows.Forms.TextBox TxTId_Producto;
        private System.Windows.Forms.TextBox TxtReferencia;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label LblStock;
        private System.Windows.Forms.Label LblPrecioVenta;
        private System.Windows.Forms.Label LblPrecioCompra;
        private System.Windows.Forms.Label LblNroReferencia;
        private System.Windows.Forms.Label LblNombreProducto;
        private System.Windows.Forms.TextBox TxtDetalle;
        private System.Windows.Forms.Label LblDetalleProducto;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label LblRutaImagen;
        private System.Windows.Forms.ComboBox ComboxCategoria;
        private System.Windows.Forms.Label LblCategoria;
    }
}