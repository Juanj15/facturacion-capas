namespace Pantallas_Sistema_facturacion
{
    partial class frmInformes
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
            ordenar = new Panel();
            btnInforme = new Button();
            btnSalir = new Button();
            informe = new Label();
            fechainicio = new Label();
            label3 = new Label();
            fechafinal = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            btnEnpantalla = new RadioButton();
            btnPdf = new RadioButton();
            btnExcel = new RadioButton();
            panel2 = new Panel();
            ordenar.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDark;
            panel1.Location = new Point(-3, 442);
            panel1.Name = "panel1";
            panel1.Size = new Size(1056, 203);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // ordenar
            // 
            ordenar.BackColor = SystemColors.ButtonFace;
            ordenar.Controls.Add(btnExcel);
            ordenar.Controls.Add(btnPdf);
            ordenar.Controls.Add(btnEnpantalla);
            ordenar.Controls.Add(dateTimePicker2);
            ordenar.Controls.Add(dateTimePicker1);
            ordenar.Controls.Add(comboBox2);
            ordenar.Controls.Add(comboBox1);
            ordenar.Controls.Add(fechafinal);
            ordenar.Controls.Add(label3);
            ordenar.Controls.Add(fechainicio);
            ordenar.Controls.Add(informe);
            ordenar.Controls.Add(btnSalir);
            ordenar.Controls.Add(btnInforme);
            ordenar.Location = new Point(31, 61);
            ordenar.Name = "ordenar";
            ordenar.Size = new Size(965, 357);
            ordenar.TabIndex = 0;
            // 
            // btnInforme
            // 
            btnInforme.BackColor = SystemColors.ButtonFace;
            btnInforme.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInforme.Location = new Point(170, 293);
            btnInforme.Name = "btnInforme";
            btnInforme.Size = new Size(242, 47);
            btnInforme.TabIndex = 0;
            btnInforme.Text = "GENERAR INFORME";
            btnInforme.UseVisualStyleBackColor = false;
            btnInforme.Click += btnInforme_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = SystemColors.ButtonFace;
            btnSalir.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalir.Location = new Point(655, 293);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(127, 47);
            btnSalir.TabIndex = 1;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // informe
            // 
            informe.AutoSize = true;
            informe.BackColor = SystemColors.ButtonFace;
            informe.Font = new Font("Arial", 10.8F, FontStyle.Underline, GraphicsUnit.Point, 0);
            informe.Location = new Point(46, 54);
            informe.Name = "informe";
            informe.Size = new Size(167, 21);
            informe.TabIndex = 2;
            informe.Text = "Seleccione Informe ";
            // 
            // fechainicio
            // 
            fechainicio.AutoSize = true;
            fechainicio.BackColor = SystemColors.ButtonFace;
            fechainicio.Font = new Font("Arial", 10.8F, FontStyle.Underline);
            fechainicio.Location = new Point(46, 153);
            fechainicio.Name = "fechainicio";
            fechainicio.Size = new Size(106, 21);
            fechainicio.TabIndex = 3;
            fechainicio.Text = "Fecha Inicio";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ButtonFace;
            label3.Font = new Font("Arial", 10.8F, FontStyle.Underline);
            label3.Location = new Point(629, 54);
            label3.Name = "label3";
            label3.Size = new Size(107, 21);
            label3.TabIndex = 4;
            label3.Text = "Ordenar por";
            // 
            // fechafinal
            // 
            fechafinal.AutoSize = true;
            fechafinal.BackColor = SystemColors.ButtonFace;
            fechafinal.Font = new Font("Arial", 10.8F, FontStyle.Underline);
            fechafinal.Location = new Point(481, 153);
            fechafinal.Name = "fechafinal";
            fechafinal.Size = new Size(98, 21);
            fechafinal.TabIndex = 5;
            fechafinal.Text = "Fecha final";
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Arial", 10.8F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(245, 49);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(347, 29);
            comboBox1.TabIndex = 6;
            // 
            // comboBox2
            // 
            comboBox2.Font = new Font("Arial", 10.8F);
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(765, 51);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(179, 29);
            comboBox2.TabIndex = 7;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarFont = new Font("Arial", 10.8F);
            dateTimePicker1.Font = new Font("Arial", 10.8F);
            dateTimePicker1.Location = new Point(170, 146);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 28);
            dateTimePicker1.TabIndex = 8;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Font = new Font("Arial", 10.8F);
            dateTimePicker2.Location = new Point(609, 149);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(250, 28);
            dateTimePicker2.TabIndex = 9;
            // 
            // btnEnpantalla
            // 
            btnEnpantalla.AutoSize = true;
            btnEnpantalla.BackColor = SystemColors.ButtonFace;
            btnEnpantalla.Font = new Font("Arial", 9F);
            btnEnpantalla.Location = new Point(170, 235);
            btnEnpantalla.Name = "btnEnpantalla";
            btnEnpantalla.Size = new Size(103, 21);
            btnEnpantalla.TabIndex = 10;
            btnEnpantalla.TabStop = true;
            btnEnpantalla.Text = "En Pantalla";
            btnEnpantalla.UseVisualStyleBackColor = false;
            // 
            // btnPdf
            // 
            btnPdf.AutoSize = true;
            btnPdf.BackColor = SystemColors.ButtonFace;
            btnPdf.Font = new Font("Arial", 9F);
            btnPdf.Location = new Point(429, 235);
            btnPdf.Name = "btnPdf";
            btnPdf.Size = new Size(51, 21);
            btnPdf.TabIndex = 11;
            btnPdf.TabStop = true;
            btnPdf.Text = "Pdf";
            btnPdf.UseVisualStyleBackColor = false;
            // 
            // btnExcel
            // 
            btnExcel.AutoSize = true;
            btnExcel.BackColor = SystemColors.ButtonFace;
            btnExcel.Font = new Font("Arial", 9F);
            btnExcel.Location = new Point(655, 235);
            btnExcel.Name = "btnExcel";
            btnExcel.Size = new Size(65, 21);
            btnExcel.TabIndex = 12;
            btnExcel.TabStop = true;
            btnExcel.Text = "Excel";
            btnExcel.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(63, 81, 181);
            panel2.Location = new Point(-3, 61);
            panel2.Name = "panel2";
            panel2.Size = new Size(1056, 399);
            panel2.TabIndex = 13;
            // 
            // frmInformes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1046, 651);
            Controls.Add(ordenar);
            Controls.Add(panel1);
            Controls.Add(panel2);
            DrawerAutoHide = false;
            Name = "frmInformes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "                                                     GENERADOR DE INFORMES DE FACTURACIÓN";
            ordenar.ResumeLayout(false);
            ordenar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Panel ordenar;
        private RadioButton btnExcel;
        private RadioButton btnPdf;
        private RadioButton btnEnpantalla;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private Label fechafinal;
        private Label label3;
        private Label fechainicio;
        private Label informe;
        private Button btnSalir;
        private Button btnInforme;
        private Panel panel2;
    }
}