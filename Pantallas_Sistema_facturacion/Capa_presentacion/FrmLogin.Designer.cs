namespace Pantallas_Sistema_facturacion
{
    partial class FrmLogin
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
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            txtUsuario = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            lblTitulo = new MaterialSkin.Controls.MaterialLabel();
            txtContraseña = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            tbnValidar = new MaterialSkin.Controls.MaterialButton();
            btnCancelar = new MaterialSkin.Controls.MaterialButton();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.CornflowerBlue;
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(219, 242);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.login;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(219, 242);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // txtUsuario
            // 
            txtUsuario.AnimateReadOnly = false;
            txtUsuario.BackgroundImageLayout = ImageLayout.None;
            txtUsuario.CharacterCasing = CharacterCasing.Normal;
            txtUsuario.Depth = 0;
            txtUsuario.HideSelection = true;
            txtUsuario.Hint = "Usuario";
            txtUsuario.Location = new Point(292, 83);
            txtUsuario.Margin = new Padding(3, 2, 3, 2);
            txtUsuario.MaxLength = 32767;
            txtUsuario.MouseState = MaterialSkin.MouseState.OUT;
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PasswordChar = '\0';
            txtUsuario.ReadOnly = false;
            txtUsuario.ScrollBars = ScrollBars.None;
            txtUsuario.SelectedText = "";
            txtUsuario.SelectionLength = 0;
            txtUsuario.SelectionStart = 0;
            txtUsuario.ShortcutsEnabled = true;
            txtUsuario.Size = new Size(246, 28);
            txtUsuario.TabIndex = 3;
            txtUsuario.TabStop = false;
            txtUsuario.TextAlign = HorizontalAlignment.Left;
            txtUsuario.UseSystemPasswordChar = false;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Depth = 0;
            lblTitulo.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblTitulo.ForeColor = SystemColors.ButtonFace;
            lblTitulo.Location = new Point(362, 39);
            lblTitulo.MouseState = MaterialSkin.MouseState.HOVER;
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(96, 19);
            lblTitulo.TabIndex = 5;
            lblTitulo.Text = "Iniciar Sesión";
            // 
            // txtContraseña
            // 
            txtContraseña.AnimateReadOnly = false;
            txtContraseña.BackgroundImageLayout = ImageLayout.None;
            txtContraseña.CharacterCasing = CharacterCasing.Normal;
            txtContraseña.Depth = 0;
            txtContraseña.HideSelection = true;
            txtContraseña.Hint = "Contraseña";
            txtContraseña.Location = new Point(292, 127);
            txtContraseña.Margin = new Padding(3, 2, 3, 2);
            txtContraseña.MaxLength = 32767;
            txtContraseña.MouseState = MaterialSkin.MouseState.OUT;
            txtContraseña.Name = "txtContraseña";
            txtContraseña.PasswordChar = '*';
            txtContraseña.ReadOnly = false;
            txtContraseña.ScrollBars = ScrollBars.None;
            txtContraseña.SelectedText = "";
            txtContraseña.SelectionLength = 0;
            txtContraseña.SelectionStart = 0;
            txtContraseña.ShortcutsEnabled = true;
            txtContraseña.Size = new Size(246, 28);
            txtContraseña.TabIndex = 6;
            txtContraseña.TabStop = false;
            txtContraseña.TextAlign = HorizontalAlignment.Left;
            txtContraseña.UseSystemPasswordChar = false;
            // 
            // tbnValidar
            // 
            tbnValidar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tbnValidar.BackColor = Color.CornflowerBlue;
            tbnValidar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            tbnValidar.Depth = 0;
            tbnValidar.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbnValidar.HighEmphasis = true;
            tbnValidar.Icon = null;
            tbnValidar.Location = new Point(323, 184);
            tbnValidar.Margin = new Padding(4, 4, 4, 4);
            tbnValidar.MouseState = MaterialSkin.MouseState.HOVER;
            tbnValidar.Name = "tbnValidar";
            tbnValidar.NoAccentTextColor = Color.Empty;
            tbnValidar.Size = new Size(91, 36);
            tbnValidar.TabIndex = 7;
            tbnValidar.Text = "Ingresar";
            tbnValidar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            tbnValidar.UseAccentColor = false;
            tbnValidar.UseVisualStyleBackColor = false;
            tbnValidar.Click += tbnValidar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCancelar.BackColor = Color.CornflowerBlue;
            btnCancelar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnCancelar.Depth = 0;
            btnCancelar.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.HighEmphasis = true;
            btnCancelar.Icon = null;
            btnCancelar.Location = new Point(436, 184);
            btnCancelar.Margin = new Padding(4, 4, 4, 4);
            btnCancelar.MouseState = MaterialSkin.MouseState.HOVER;
            btnCancelar.Name = "btnCancelar";
            btnCancelar.NoAccentTextColor = Color.Empty;
            btnCancelar.Size = new Size(96, 36);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "Cancelar";
            btnCancelar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnCancelar.UseAccentColor = false;
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SlateGray;
            ClientSize = new Size(614, 242);
            Controls.Add(btnCancelar);
            Controls.Add(tbnValidar);
            Controls.Add(txtContraseña);
            Controls.Add(lblTitulo);
            Controls.Add(txtUsuario);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmLogin";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 txtUsuario;
        private MaterialSkin.Controls.MaterialLabel lblTitulo;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 txtContraseña;
        private MaterialSkin.Controls.MaterialButton tbnValidar;
        private MaterialSkin.Controls.MaterialButton btnCancelar;
    }
}