namespace Pantallas_Sistema_facturacion
{
    partial class frmFacturas
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
            titulofacturas = new MaterialSkin.Controls.MaterialLabel();
            nroFactura = new MaterialSkin.Controls.MaterialLabel();
            panel1 = new Panel();
            comboBox3 = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            eFactura = new Label();
            fRegistro = new Label();
            tIVA = new Label();
            descuento = new Label();
            empleado = new Label();
            cliente = new Label();
            tFactura = new Label();
            nFactura = new Label();
            btnActualizar = new Button();
            panel2 = new Panel();
            btnSalir = new Button();
            label1 = new Label();
            panel3 = new Panel();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // titulofacturas
            // 
            titulofacturas.AutoSize = true;
            titulofacturas.Depth = 0;
            titulofacturas.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            titulofacturas.Location = new Point(278, 57);
            titulofacturas.MouseState = MaterialSkin.MouseState.HOVER;
            titulofacturas.Name = "titulofacturas";
            titulofacturas.Size = new Size(1, 0);
            titulofacturas.TabIndex = 0;
            titulofacturas.Click += materialLabel1_Click;
            // 
            // nroFactura
            // 
            nroFactura.AutoSize = true;
            nroFactura.Depth = 0;
            nroFactura.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            nroFactura.Location = new Point(64, 110);
            nroFactura.MouseState = MaterialSkin.MouseState.HOVER;
            nroFactura.Name = "nroFactura";
            nroFactura.Size = new Size(1, 0);
            nroFactura.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonFace;
            panel1.Controls.Add(comboBox3);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(comboBox2);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(eFactura);
            panel1.Controls.Add(fRegistro);
            panel1.Controls.Add(tIVA);
            panel1.Controls.Add(descuento);
            panel1.Controls.Add(empleado);
            panel1.Controls.Add(cliente);
            panel1.Controls.Add(tFactura);
            panel1.Controls.Add(nFactura);
            panel1.Location = new Point(76, 26);
            panel1.Name = "panel1";
            panel1.Size = new Size(714, 279);
            panel1.TabIndex = 3;
            // 
            // comboBox3
            // 
            comboBox3.Font = new Font("Arial", 10.8F);
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(516, 176);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(131, 29);
            comboBox3.TabIndex = 13;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Arial", 10.8F);
            dateTimePicker1.Location = new Point(517, 57);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(130, 28);
            dateTimePicker1.TabIndex = 12;
            // 
            // comboBox2
            // 
            comboBox2.Font = new Font("Arial", 10.8F);
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(132, 99);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(236, 29);
            comboBox2.TabIndex = 11;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Arial", 10.8F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(132, 60);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(236, 29);
            comboBox1.TabIndex = 10;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Arial", 10.8F);
            textBox1.Location = new Point(132, 23);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 28);
            textBox1.TabIndex = 9;
            // 
            // eFactura
            // 
            eFactura.AutoSize = true;
            eFactura.Font = new Font("Arial", 10.8F, FontStyle.Underline);
            eFactura.Location = new Point(510, 140);
            eFactura.Name = "eFactura";
            eFactura.Size = new Size(137, 21);
            eFactura.TabIndex = 7;
            eFactura.Text = "Estado Factura ";
            // 
            // fRegistro
            // 
            fRegistro.AutoSize = true;
            fRegistro.Font = new Font("Arial", 10.8F, FontStyle.Underline);
            fRegistro.Location = new Point(517, 26);
            fRegistro.Name = "fRegistro";
            fRegistro.Size = new Size(132, 21);
            fRegistro.TabIndex = 6;
            fRegistro.Text = "Fecha Registro";
            // 
            // tIVA
            // 
            tIVA.AutoSize = true;
            tIVA.Font = new Font("Arial", 10.8F, FontStyle.Underline);
            tIVA.Location = new Point(25, 179);
            tIVA.Name = "tIVA";
            tIVA.Size = new Size(79, 21);
            tIVA.TabIndex = 5;
            tIVA.Text = "Total IVA";
            // 
            // descuento
            // 
            descuento.AutoSize = true;
            descuento.Font = new Font("Arial", 10.8F, FontStyle.Underline);
            descuento.Location = new Point(25, 140);
            descuento.Name = "descuento";
            descuento.Size = new Size(87, 21);
            descuento.TabIndex = 4;
            descuento.Text = "Desuento";
            // 
            // empleado
            // 
            empleado.AutoSize = true;
            empleado.Font = new Font("Arial", 10.8F, FontStyle.Underline);
            empleado.Location = new Point(25, 107);
            empleado.Name = "empleado";
            empleado.Size = new Size(90, 21);
            empleado.TabIndex = 3;
            empleado.Text = "Empleado";
            empleado.Click += label4_Click;
            // 
            // cliente
            // 
            cliente.AutoSize = true;
            cliente.Font = new Font("Arial", 10.8F, FontStyle.Underline);
            cliente.Location = new Point(25, 68);
            cliente.Name = "cliente";
            cliente.Size = new Size(66, 21);
            cliente.TabIndex = 2;
            cliente.Text = "Cliente";
            cliente.Click += label3_Click;
            // 
            // tFactura
            // 
            tFactura.AutoSize = true;
            tFactura.Font = new Font("Arial", 10.8F, FontStyle.Underline);
            tFactura.Location = new Point(25, 216);
            tFactura.Name = "tFactura";
            tFactura.Size = new Size(115, 21);
            tFactura.TabIndex = 1;
            tFactura.Text = "Total Factura";
            // 
            // nFactura
            // 
            nFactura.AutoSize = true;
            nFactura.Font = new Font("Arial", 10.8F, FontStyle.Underline);
            nFactura.Location = new Point(25, 30);
            nFactura.Name = "nFactura";
            nFactura.Size = new Size(105, 21);
            nFactura.TabIndex = 0;
            nFactura.Text = "Nro Factura";
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = SystemColors.ButtonFace;
            btnActualizar.Font = new Font("Arial Black", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnActualizar.Location = new Point(828, 229);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(168, 46);
            btnActualizar.TabIndex = 4;
            btnActualizar.Text = "ACTUALIZAR";
            btnActualizar.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonFace;
            panel2.Location = new Point(76, 363);
            panel2.Name = "panel2";
            panel2.Size = new Size(714, 190);
            panel2.TabIndex = 5;
            panel2.Paint += panel2_Paint;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = SystemColors.ButtonFace;
            btnSalir.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalir.Location = new Point(828, 434);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(168, 47);
            btnSalir.TabIndex = 6;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonFace;
            label1.Font = new Font("Arial", 10.8F);
            label1.Location = new Point(76, 326);
            label1.Name = "label1";
            label1.Size = new Size(177, 21);
            label1.TabIndex = 7;
            label1.Text = "DETALLE FACTURA";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(63, 81, 181);
            panel3.Controls.Add(panel2);
            panel3.Controls.Add(btnSalir);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(btnActualizar);
            panel3.Controls.Add(panel1);
            panel3.Location = new Point(-4, 60);
            panel3.Name = "panel3";
            panel3.Size = new Size(1075, 635);
            panel3.TabIndex = 8;
            // 
            // frmFacturas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1067, 692);
            Controls.Add(nroFactura);
            Controls.Add(titulofacturas);
            Controls.Add(panel3);
            Name = "frmFacturas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "                                                ADMINISTRACIÓN FACTURAS";
            Load += frmFacturas_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel titulofacturas;
        private MaterialSkin.Controls.MaterialLabel nroFactura;
        private Panel panel1;
        private Button btnActualizar;
        private Panel panel2;
        private Button btnSalir;
        private Label eFactura;
        private Label fRegistro;
        private Label tIVA;
        private Label descuento;
        private Label empleado;
        private Label cliente;
        private Label tFactura;
        private Label nFactura;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private ComboBox comboBox3;
        private DateTimePicker dateTimePicker1;
        private Label label1;
        private Panel panel3;
    }
}