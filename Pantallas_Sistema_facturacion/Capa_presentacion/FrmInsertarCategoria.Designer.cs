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
            LblCategoria.Location = new Point(39, 101);
            LblCategoria.Margin = new Padding(5, 0, 5, 0);
            LblCategoria.Name = "LblCategoria";
            LblCategoria.Size = new Size(94, 23);
            LblCategoria.TabIndex = 0;
            LblCategoria.Text = "Categoria";
            // 
            // LblDescripciónCategoria
            // 
            LblDescripciónCategoria.AutoSize = true;
            LblDescripciónCategoria.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblDescripciónCategoria.ForeColor = Color.White;
            LblDescripciónCategoria.Location = new Point(39, 181);
            LblDescripciónCategoria.Margin = new Padding(5, 0, 5, 0);
            LblDescripciónCategoria.Name = "LblDescripciónCategoria";
            LblDescripciónCategoria.Size = new Size(108, 23);
            LblDescripciónCategoria.TabIndex = 1;
            LblDescripciónCategoria.Text = "Descripción";
            // 
            // TxtCategoria
            // 
            TxtCategoria.BackColor = Color.MintCream;
            TxtCategoria.BorderStyle = BorderStyle.FixedSingle;
            TxtCategoria.ForeColor = SystemColors.ActiveCaptionText;
            TxtCategoria.Location = new Point(42, 136);
            TxtCategoria.Margin = new Padding(5, 4, 5, 4);
            TxtCategoria.Name = "TxtCategoria";
            TxtCategoria.Size = new Size(354, 27);
            TxtCategoria.TabIndex = 3;
            // 
            // TxtDescripcion
            // 
            TxtDescripcion.BackColor = Color.MintCream;
            TxtDescripcion.BorderStyle = BorderStyle.FixedSingle;
            TxtDescripcion.ForeColor = SystemColors.ActiveCaptionText;
            TxtDescripcion.Location = new Point(42, 216);
            TxtDescripcion.Margin = new Padding(5, 4, 5, 4);
            TxtDescripcion.Multiline = true;
            TxtDescripcion.Name = "TxtDescripcion";
            TxtDescripcion.Size = new Size(354, 149);
            TxtDescripcion.TabIndex = 4;
            // 
            // BtnGuardar
            // 
            BtnGuardar.BackColor = Color.Blue;
            BtnGuardar.FlatStyle = FlatStyle.Popup;
            BtnGuardar.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnGuardar.ForeColor = SystemColors.Control;
            BtnGuardar.Location = new Point(43, 396);
            BtnGuardar.Margin = new Padding(5, 4, 5, 4);
            BtnGuardar.Name = "BtnGuardar";
            BtnGuardar.Size = new Size(158, 47);
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
            BtnCancelar.Location = new Point(241, 396);
            BtnCancelar.Margin = new Padding(5, 4, 5, 4);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(158, 47);
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
            LblTituloCategoria.Location = new Point(40, 13);
            LblTituloCategoria.Margin = new Padding(5, 0, 5, 0);
            LblTituloCategoria.Name = "LblTituloCategoria";
            LblTituloCategoria.Size = new Size(258, 39);
            LblTituloCategoria.TabIndex = 7;
            LblTituloCategoria.Text = "Titulo Categoria";
            // 
            // TxTId_Categoria
            // 
            TxTId_Categoria.BackColor = Color.MintCream;
            TxTId_Categoria.BorderStyle = BorderStyle.FixedSingle;
            TxTId_Categoria.ForeColor = SystemColors.ActiveCaptionText;
            TxTId_Categoria.Location = new Point(400, 87);
            TxTId_Categoria.Margin = new Padding(5, 4, 5, 4);
            TxTId_Categoria.Name = "TxTId_Categoria";
            TxTId_Categoria.Size = new Size(24, 27);
            TxTId_Categoria.TabIndex = 7;
            // 
            // FrmInsertarCategoria
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(47, 62, 153);
            ClientSize = new Size(440, 461);
            Controls.Add(LblTituloCategoria);
            Controls.Add(TxTId_Categoria);
            Controls.Add(BtnCancelar);
            Controls.Add(BtnGuardar);
            Controls.Add(TxtDescripcion);
            Controls.Add(TxtCategoria);
            Controls.Add(LblDescripciónCategoria);
            Controls.Add(LblCategoria);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5, 4, 5, 4);
            Name = "FrmInsertarCategoria";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmInsertarCategoria";
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