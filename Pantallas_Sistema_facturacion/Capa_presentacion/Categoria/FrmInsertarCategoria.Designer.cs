namespace FrmCategoria
{
    partial class FrmInsertarCategoria
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
            LblCategoria = new Label();
            LblDescripciónCategoria = new Label();
            TxtCategoria = new TextBox();
            TxtDescripcion = new TextBox();
            BtnGuardar = new Button();
            BtnCancelar = new Button();
            LblTituloCategoria = new Label();
            TxTId_Categoria = new TextBox();
            SuspendLayout();
            // 
            // LblCategoria
            // 
            LblCategoria.AutoSize = true;
            LblCategoria.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblCategoria.ForeColor = Color.White;
            LblCategoria.Location = new Point(34, 76);
            LblCategoria.Margin = new Padding(4, 0, 4, 0);
            LblCategoria.Name = "LblCategoria";
            LblCategoria.Size = new Size(75, 19);
            LblCategoria.TabIndex = 0;
            LblCategoria.Text = "Categoria";
            
            // 
            // LblDescripciónCategoria
            // 
            LblDescripciónCategoria.AutoSize = true;
            LblDescripciónCategoria.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblDescripciónCategoria.ForeColor = Color.White;
            LblDescripciónCategoria.Location = new Point(34, 136);
            LblDescripciónCategoria.Margin = new Padding(4, 0, 4, 0);
            LblDescripciónCategoria.Name = "LblDescripciónCategoria";
            LblDescripciónCategoria.Size = new Size(88, 19);
            LblDescripciónCategoria.TabIndex = 1;
            LblDescripciónCategoria.Text = "Descripción";
           
            // 
            // TxtCategoria
            // 
            TxtCategoria.BackColor = Color.MintCream;
            TxtCategoria.BorderStyle = BorderStyle.FixedSingle;
            TxtCategoria.ForeColor = SystemColors.ActiveCaptionText;
            TxtCategoria.Location = new Point(37, 102);
            TxtCategoria.Margin = new Padding(4, 3, 4, 3);
            TxtCategoria.Name = "TxtCategoria";
            TxtCategoria.Size = new Size(310, 23);
            TxtCategoria.TabIndex = 3;
            TxtCategoria.TextChanged += TxtCategoria_TextChanged;
            // 
            // TxtDescripcion
            // 
            TxtDescripcion.BackColor = Color.MintCream;
            TxtDescripcion.BorderStyle = BorderStyle.FixedSingle;
            TxtDescripcion.ForeColor = SystemColors.ActiveCaptionText;
            TxtDescripcion.Location = new Point(37, 162);
            TxtDescripcion.Margin = new Padding(4, 3, 4, 3);
            TxtDescripcion.Multiline = true;
            TxtDescripcion.Name = "TxtDescripcion";
            TxtDescripcion.Size = new Size(310, 112);
            TxtDescripcion.TabIndex = 4;
            TxtDescripcion.TextChanged += TxtDescripcion_TextChanged;
            // 
            // BtnGuardar
            // 
            BtnGuardar.BackColor = Color.Blue;
            BtnGuardar.FlatStyle = FlatStyle.Popup;
            BtnGuardar.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnGuardar.ForeColor = SystemColors.Control;
            BtnGuardar.Location = new Point(38, 297);
            BtnGuardar.Margin = new Padding(4, 3, 4, 3);
            BtnGuardar.Name = "BtnGuardar";
            BtnGuardar.Size = new Size(138, 35);
            BtnGuardar.TabIndex = 5;
            BtnGuardar.Text = "Guardar";
            BtnGuardar.UseVisualStyleBackColor = false;
            BtnGuardar.Click += BtnGuardar_Click;
            // 
            // BtnCancelar
            // 
            BtnCancelar.BackColor = Color.Red;
            BtnCancelar.FlatStyle = FlatStyle.Popup;
            BtnCancelar.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnCancelar.ForeColor = SystemColors.Control;
            BtnCancelar.Location = new Point(211, 297);
            BtnCancelar.Margin = new Padding(4, 3, 4, 3);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(138, 35);
            BtnCancelar.TabIndex = 6;
            BtnCancelar.Text = "Cancelar";
            BtnCancelar.UseVisualStyleBackColor = false;
            BtnCancelar.Click += BtnCancelar_Click;
            // 
            // LblTituloCategoria
            // 
            LblTituloCategoria.AutoSize = true;
            LblTituloCategoria.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblTituloCategoria.ForeColor = Color.White;
            LblTituloCategoria.Location = new Point(35, 10);
            LblTituloCategoria.Margin = new Padding(4, 0, 4, 0);
            LblTituloCategoria.Name = "LblTituloCategoria";
            LblTituloCategoria.Size = new Size(206, 31);
            LblTituloCategoria.TabIndex = 7;
            LblTituloCategoria.Text = "Titulo Categoria";
            
            // 
            // TxTId_Categoria
            // 
            TxTId_Categoria.BackColor = Color.MintCream;
            TxTId_Categoria.BorderStyle = BorderStyle.FixedSingle;
            TxTId_Categoria.ForeColor = SystemColors.ActiveCaptionText;
            TxTId_Categoria.Location = new Point(350, 65);
            TxTId_Categoria.Margin = new Padding(4, 3, 4, 3);
            TxTId_Categoria.Name = "TxTId_Categoria";
            TxTId_Categoria.Size = new Size(21, 23);
            TxTId_Categoria.TabIndex = 7;
            TxTId_Categoria.TextChanged += TxTId_Categoria_TextChanged;
            // 
            // FrmInsertarCategoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(47, 62, 153);
            ClientSize = new Size(385, 346);
            Controls.Add(LblTituloCategoria);
            Controls.Add(TxTId_Categoria);
            Controls.Add(BtnCancelar);
            Controls.Add(BtnGuardar);
            Controls.Add(TxtDescripcion);
            Controls.Add(TxtCategoria);
            Controls.Add(LblDescripciónCategoria);
            Controls.Add(LblCategoria);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "FrmInsertarCategoria";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmInsertarCategoria";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblCategoria;
        private System.Windows.Forms.Label LblDescripciónCategoria;
        private System.Windows.Forms.TextBox TxtCategoria;
        private System.Windows.Forms.TextBox TxtDescripcion;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Label LblTituloCategoria;
        private System.Windows.Forms.TextBox TxTId_Categoria;
        //       private System.Windows.Forms.TextBox IdCategoria;
    }
}