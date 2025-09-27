namespace FrmCategoria
{
    partial class FrmInsertarClientes
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
            LblTituloCliente = new Label();
            LblNombreCLiente = new Label();
            LblDocumentoId = new Label();
            LblDirección = new Label();
            LblTelefono = new Label();
            LblEmail = new Label();
            TxtNombre = new TextBox();
            TxtDocumento = new TextBox();
            TxTId_Cliente = new TextBox();
            TxtDireccion = new TextBox();
            TxtTelefono = new TextBox();
            TxtEmail = new TextBox();
            SuspendLayout();
            // 
            // BtnCancelar
            // 
            BtnCancelar.BackColor = Color.Red;
            BtnCancelar.FlatStyle = FlatStyle.Popup;
            BtnCancelar.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnCancelar.ForeColor = SystemColors.Control;
            BtnCancelar.Location = new Point(211, 391);
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
            BtnGuardar.Location = new Point(38, 391);
            BtnGuardar.Margin = new Padding(4, 3, 4, 3);
            BtnGuardar.Name = "BtnGuardar";
            BtnGuardar.Size = new Size(138, 35);
            BtnGuardar.TabIndex = 8;
            BtnGuardar.Text = "Guardar";
            BtnGuardar.UseVisualStyleBackColor = false;
            BtnGuardar.Click += BtnGuardar_Click;
            // 
            // LblTituloCliente
            // 
            LblTituloCliente.AutoSize = true;
            LblTituloCliente.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblTituloCliente.ForeColor = Color.White;
            LblTituloCliente.Location = new Point(35, 10);
            LblTituloCliente.Margin = new Padding(4, 0, 4, 0);
            LblTituloCliente.Name = "LblTituloCliente";
            LblTituloCliente.Size = new Size(173, 31);
            LblTituloCliente.TabIndex = 9;
            LblTituloCliente.Text = "Titulo Cliente";
            // 
            // LblNombreCLiente
            // 
            LblNombreCLiente.AutoSize = true;
            LblNombreCLiente.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblNombreCLiente.ForeColor = Color.White;
            LblNombreCLiente.Location = new Point(34, 76);
            LblNombreCLiente.Margin = new Padding(4, 0, 4, 0);
            LblNombreCLiente.Name = "LblNombreCLiente";
            LblNombreCLiente.Size = new Size(115, 19);
            LblNombreCLiente.TabIndex = 10;
            LblNombreCLiente.Text = "Nombre Cliente";
            // 
            // LblDocumentoId
            // 
            LblDocumentoId.AutoSize = true;
            LblDocumentoId.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblDocumentoId.ForeColor = Color.White;
            LblDocumentoId.Location = new Point(34, 136);
            LblDocumentoId.Margin = new Padding(4, 0, 4, 0);
            LblDocumentoId.Name = "LblDocumentoId";
            LblDocumentoId.Size = new Size(103, 19);
            LblDocumentoId.TabIndex = 11;
            LblDocumentoId.Text = "Documento Id";
            // 
            // LblDirección
            // 
            LblDirección.AutoSize = true;
            LblDirección.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblDirección.ForeColor = Color.White;
            LblDirección.Location = new Point(58, 196);
            LblDirección.Margin = new Padding(4, 0, 4, 0);
            LblDirección.Name = "LblDirección";
            LblDirección.Size = new Size(88, 19);
            LblDirección.TabIndex = 12;
            LblDirección.Text = "📍 Dirección";
            // 
            // LblTelefono
            // 
            LblTelefono.AutoSize = true;
            LblTelefono.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblTelefono.ForeColor = Color.White;
            LblTelefono.Location = new Point(58, 256);
            LblTelefono.Margin = new Padding(4, 0, 4, 0);
            LblTelefono.Name = "LblTelefono";
            LblTelefono.Size = new Size(83, 19);
            LblTelefono.TabIndex = 13;
            LblTelefono.Text = "📱 Telefono";
            // 
            // LblEmail
            // 
            LblEmail.AutoSize = true;
            LblEmail.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblEmail.ForeColor = Color.White;
            LblEmail.Location = new Point(58, 316);
            LblEmail.Margin = new Padding(4, 0, 4, 0);
            LblEmail.Name = "LblEmail";
            LblEmail.Size = new Size(68, 19);
            LblEmail.TabIndex = 14;
            LblEmail.Text = "📧 Email";
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
            TxtNombre.TabIndex = 15;
            // 
            // TxtDocumento
            // 
            TxtDocumento.BackColor = Color.MintCream;
            TxtDocumento.BorderStyle = BorderStyle.FixedSingle;
            TxtDocumento.ForeColor = SystemColors.ActiveCaptionText;
            TxtDocumento.Location = new Point(38, 162);
            TxtDocumento.Margin = new Padding(4, 3, 4, 3);
            TxtDocumento.Name = "TxtDocumento";
            TxtDocumento.Size = new Size(310, 23);
            TxtDocumento.TabIndex = 16;
            TxtDocumento.TextChanged += TxtDocumento_TextChanged;
            // 
            // TxTId_Cliente
            // 
            TxTId_Cliente.BackColor = Color.FromArgb(47, 62, 153);
            TxTId_Cliente.BorderStyle = BorderStyle.FixedSingle;
            TxTId_Cliente.ForeColor = Color.FromArgb(47, 62, 153);
            TxTId_Cliente.Location = new Point(351, 65);
            TxTId_Cliente.Margin = new Padding(4, 3, 4, 3);
            TxTId_Cliente.Name = "TxTId_Cliente";
            TxTId_Cliente.Size = new Size(21, 23);
            TxTId_Cliente.TabIndex = 17;
            // 
            // TxtDireccion
            // 
            TxtDireccion.BackColor = Color.MintCream;
            TxtDireccion.BorderStyle = BorderStyle.FixedSingle;
            TxtDireccion.ForeColor = SystemColors.ActiveCaptionText;
            TxtDireccion.Location = new Point(64, 222);
            TxtDireccion.Margin = new Padding(4, 3, 4, 3);
            TxtDireccion.Name = "TxtDireccion";
            TxtDireccion.Size = new Size(284, 23);
            TxtDireccion.TabIndex = 18;
            // 
            // TxtTelefono
            // 
            TxtTelefono.BackColor = Color.MintCream;
            TxtTelefono.BorderStyle = BorderStyle.FixedSingle;
            TxtTelefono.ForeColor = SystemColors.ActiveCaptionText;
            TxtTelefono.Location = new Point(64, 282);
            TxtTelefono.Margin = new Padding(4, 3, 4, 3);
            TxtTelefono.Name = "TxtTelefono";
            TxtTelefono.Size = new Size(284, 23);
            TxtTelefono.TabIndex = 19;
            // 
            // TxtEmail
            // 
            TxtEmail.BackColor = Color.MintCream;
            TxtEmail.BorderStyle = BorderStyle.FixedSingle;
            TxtEmail.ForeColor = SystemColors.ActiveCaptionText;
            TxtEmail.Location = new Point(64, 342);
            TxtEmail.Margin = new Padding(4, 3, 4, 3);
            TxtEmail.Name = "TxtEmail";
            TxtEmail.Size = new Size(284, 23);
            TxtEmail.TabIndex = 20;
            // 
            // FrmInsertarClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(47, 62, 153);
            ClientSize = new Size(385, 438);
            Controls.Add(TxtEmail);
            Controls.Add(TxtTelefono);
            Controls.Add(TxtDireccion);
            Controls.Add(TxTId_Cliente);
            Controls.Add(TxtDocumento);
            Controls.Add(TxtNombre);
            Controls.Add(LblEmail);
            Controls.Add(LblTelefono);
            Controls.Add(LblDirección);
            Controls.Add(LblDocumentoId);
            Controls.Add(LblNombreCLiente);
            Controls.Add(LblTituloCliente);
            Controls.Add(BtnGuardar);
            Controls.Add(BtnCancelar);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "FrmInsertarClientes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmInsertarClientes";
            Load += FrmInsertarClientes_Load;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Label LblTituloCliente;
        private System.Windows.Forms.Label LblNombreCLiente;
        private System.Windows.Forms.Label LblDocumentoId;
        private System.Windows.Forms.Label LblDirección;
        private System.Windows.Forms.Label LblTelefono;
        private System.Windows.Forms.Label LblEmail;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtDocumento;
        private System.Windows.Forms.TextBox TxTId_Cliente;
        private System.Windows.Forms.TextBox TxtDireccion;
        private System.Windows.Forms.TextBox TxtTelefono;
        private System.Windows.Forms.TextBox TxtEmail;
    }
}