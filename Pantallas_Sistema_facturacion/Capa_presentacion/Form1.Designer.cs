namespace Pantallas_Sistema_facturacion
{
    partial class Form1
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
            txtNombre = new TextBox();
            txtCorreo = new TextBox();
            txtDireccion = new TextBox();
            txtTelefono = new TextBox();
            txtDocumento = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(337, 27);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 0;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(337, 210);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(100, 23);
            txtCorreo.TabIndex = 1;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(337, 271);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(100, 23);
            txtDireccion.TabIndex = 2;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(337, 149);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(100, 23);
            txtTelefono.TabIndex = 3;
            // 
            // txtDocumento
            // 
            txtDocumento.Location = new Point(337, 88);
            txtDocumento.Name = "txtDocumento";
            txtDocumento.Size = new Size(100, 23);
            txtDocumento.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(362, 351);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 5;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(txtDocumento);
            Controls.Add(txtTelefono);
            Controls.Add(txtDireccion);
            Controls.Add(txtCorreo);
            Controls.Add(txtNombre);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private TextBox txtCorreo;
        private TextBox txtDireccion;
        private TextBox txtTelefono;
        private TextBox txtDocumento;
        private Button button1;
    }
}