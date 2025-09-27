namespace Pantallas_Sistema_facturacion
{
    partial class frmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            button1 = new Button();
            folderBrowserDialog1 = new FolderBrowserDialog();
            label1 = new Label();
            pnlPrincipal = new Panel();
            pnlEmpleados = new Panel();
            panelContenedor = new Panel();
            panel1 = new Panel();
            TbpMenu = new MaterialSkin.Controls.MaterialTabControl();
            principal = new TabPage();
            BtnSalir = new Button();
            pictureBox6 = new PictureBox();
            tablas = new TabPage();
            btnCategorias = new Button();
            btnProductos = new Button();
            btnClientes = new Button();
            pictureBox2 = new PictureBox();
            facturacion = new TabPage();
            btnInformes = new Button();
            btnFacturacion = new Button();
            pictureBox5 = new PictureBox();
            seguridad = new TabPage();
            btnSeguridad = new Button();
            btnRoles = new Button();
            btnEmpleados = new Button();
            pictureBox3 = new PictureBox();
            ayuda = new TabPage();
            btnAyuda = new Button();
            btnAcerca = new Button();
            pictureBox4 = new PictureBox();
            TabOpcionesMenu = new MaterialSkin.Controls.MaterialTabSelector();
            pnlPrincipal.SuspendLayout();
            panel1.SuspendLayout();
            TbpMenu.SuspendLayout();
            principal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            tablas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            facturacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            seguridad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ayuda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(247, 173);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(0, 0);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(228, 34);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 2;
            // 
            // pnlPrincipal
            // 
            pnlPrincipal.BackColor = SystemColors.ButtonFace;
            pnlPrincipal.Controls.Add(pnlEmpleados);
            pnlPrincipal.Controls.Add(panelContenedor);
            pnlPrincipal.Controls.Add(panel1);
            pnlPrincipal.Location = new Point(1, 50);
            pnlPrincipal.Margin = new Padding(3, 2, 3, 2);
            pnlPrincipal.Name = "pnlPrincipal";
            pnlPrincipal.Size = new Size(1337, 617);
            pnlPrincipal.TabIndex = 3;
            pnlPrincipal.Paint += pnlPrincipal_Paint;
            // 
            // pnlEmpleados
            // 
            pnlEmpleados.Dock = DockStyle.Fill;
            pnlEmpleados.Location = new Point(156, 0);
            pnlEmpleados.Name = "pnlEmpleados";
            pnlEmpleados.Size = new Size(1181, 617);
            pnlEmpleados.TabIndex = 2;
            pnlEmpleados.Visible = false;
            //pnlEmpleados.Paint += pnlEmpleados_Paint;
            // 
            // panelContenedor
            // 
            panelContenedor.Dock = DockStyle.Fill;
            panelContenedor.Location = new Point(156, 0);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(1181, 617);
            panelContenedor.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(TbpMenu);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(156, 617);
            panel1.TabIndex = 0;
            // 
            // TbpMenu
            // 
            TbpMenu.Controls.Add(principal);
            TbpMenu.Controls.Add(tablas);
            TbpMenu.Controls.Add(facturacion);
            TbpMenu.Controls.Add(seguridad);
            TbpMenu.Controls.Add(ayuda);
            TbpMenu.Depth = 0;
            TbpMenu.Dock = DockStyle.Fill;
            TbpMenu.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TbpMenu.Location = new Point(0, 0);
            TbpMenu.Margin = new Padding(3, 2, 3, 2);
            TbpMenu.MouseState = MaterialSkin.MouseState.HOVER;
            TbpMenu.Multiline = true;
            TbpMenu.Name = "TbpMenu";
            TbpMenu.SelectedIndex = 0;
            TbpMenu.Size = new Size(156, 617);
            TbpMenu.TabIndex = 0;
            // 
            // principal
            // 
            principal.BackColor = Color.CornflowerBlue;
            principal.Controls.Add(BtnSalir);
            principal.Controls.Add(pictureBox6);
            principal.ForeColor = SystemColors.ControlText;
            principal.Location = new Point(4, 64);
            principal.Margin = new Padding(3, 2, 3, 2);
            principal.Name = "principal";
            principal.Padding = new Padding(3, 2, 3, 2);
            principal.Size = new Size(148, 549);
            principal.TabIndex = 0;
            principal.Text = "PRINCIPAL";
            // 
            // BtnSalir
            // 
            BtnSalir.FlatAppearance.BorderSize = 0;
            BtnSalir.FlatAppearance.MouseDownBackColor = Color.Black;
            BtnSalir.FlatStyle = FlatStyle.Flat;
            BtnSalir.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnSalir.ForeColor = SystemColors.ButtonFace;
            BtnSalir.Image = (Image)resources.GetObject("BtnSalir.Image");
            BtnSalir.ImageAlign = ContentAlignment.MiddleLeft;
            BtnSalir.Location = new Point(3, 155);
            BtnSalir.Margin = new Padding(3, 2, 3, 2);
            BtnSalir.Name = "BtnSalir";
            BtnSalir.Size = new Size(138, 52);
            BtnSalir.TabIndex = 1;
            BtnSalir.Text = "Salir";
            BtnSalir.UseVisualStyleBackColor = true;
            BtnSalir.Click += BtnSalir_Click;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(9, 13);
            pictureBox6.Margin = new Padding(3, 2, 3, 2);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(128, 128);
            pictureBox6.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox6.TabIndex = 2;
            pictureBox6.TabStop = false;
            // 
            // tablas
            // 
            tablas.BackColor = Color.CornflowerBlue;
            tablas.Controls.Add(btnCategorias);
            tablas.Controls.Add(btnProductos);
            tablas.Controls.Add(btnClientes);
            tablas.Controls.Add(pictureBox2);
            tablas.Location = new Point(4, 64);
            tablas.Margin = new Padding(3, 2, 3, 2);
            tablas.Name = "tablas";
            tablas.Padding = new Padding(3, 2, 3, 2);
            tablas.Size = new Size(148, 549);
            tablas.TabIndex = 1;
            tablas.Text = "TABLAS";
            // 
            // btnCategorias
            // 
            btnCategorias.FlatAppearance.BorderSize = 0;
            btnCategorias.FlatAppearance.MouseDownBackColor = Color.FromArgb(45, 45, 45);
            btnCategorias.FlatStyle = FlatStyle.Flat;
            btnCategorias.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCategorias.ForeColor = SystemColors.ButtonFace;
            btnCategorias.Image = (Image)resources.GetObject("btnCategorias.Image");
            btnCategorias.ImageAlign = ContentAlignment.MiddleLeft;
            btnCategorias.Location = new Point(3, 297);
            btnCategorias.Margin = new Padding(3, 2, 3, 2);
            btnCategorias.Name = "btnCategorias";
            btnCategorias.Size = new Size(186, 47);
            btnCategorias.TabIndex = 4;
            btnCategorias.Text = "Categorias";
            btnCategorias.UseVisualStyleBackColor = true;
            btnCategorias.Click += btnCategorias_Click;
            // 
            // btnProductos
            // 
            btnProductos.FlatAppearance.BorderSize = 0;
            btnProductos.FlatAppearance.MouseDownBackColor = Color.FromArgb(45, 45, 45);
            btnProductos.FlatStyle = FlatStyle.Flat;
            btnProductos.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProductos.ForeColor = SystemColors.ButtonFace;
            btnProductos.Image = (Image)resources.GetObject("btnProductos.Image");
            btnProductos.ImageAlign = ContentAlignment.MiddleLeft;
            btnProductos.Location = new Point(3, 226);
            btnProductos.Margin = new Padding(3, 2, 3, 2);
            btnProductos.Name = "btnProductos";
            btnProductos.Size = new Size(185, 47);
            btnProductos.TabIndex = 3;
            btnProductos.Text = "Productos";
            btnProductos.UseVisualStyleBackColor = true;
            btnProductos.Click += btnProductos_Click;
            // 
            // btnClientes
            // 
            btnClientes.FlatAppearance.BorderSize = 0;
            btnClientes.FlatAppearance.MouseDownBackColor = Color.FromArgb(45, 45, 45);
            btnClientes.FlatStyle = FlatStyle.Flat;
            btnClientes.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClientes.ForeColor = SystemColors.ButtonFace;
            btnClientes.Image = (Image)resources.GetObject("btnClientes.Image");
            btnClientes.ImageAlign = ContentAlignment.MiddleLeft;
            btnClientes.Location = new Point(3, 155);
            btnClientes.Margin = new Padding(3, 2, 3, 2);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(167, 47);
            btnClientes.TabIndex = 2;
            btnClientes.Text = "Clientes";
            btnClientes.UseVisualStyleBackColor = true;
            btnClientes.Click += btnClientes_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(9, 13);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(128, 128);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // facturacion
            // 
            facturacion.BackColor = Color.CornflowerBlue;
            facturacion.Controls.Add(btnInformes);
            facturacion.Controls.Add(btnFacturacion);
            facturacion.Controls.Add(pictureBox5);
            facturacion.Location = new Point(4, 64);
            facturacion.Margin = new Padding(3, 2, 3, 2);
            facturacion.Name = "facturacion";
            facturacion.Padding = new Padding(3, 2, 3, 2);
            facturacion.Size = new Size(148, 549);
            facturacion.TabIndex = 2;
            facturacion.Text = "FACTURACIÓN";
            // 
            // btnInformes
            // 
            btnInformes.FlatAppearance.BorderSize = 0;
            btnInformes.FlatAppearance.MouseDownBackColor = Color.FromArgb(45, 45, 45);
            btnInformes.FlatStyle = FlatStyle.Flat;
            btnInformes.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInformes.ForeColor = SystemColors.ButtonFace;
            btnInformes.Image = (Image)resources.GetObject("btnInformes.Image");
            btnInformes.ImageAlign = ContentAlignment.MiddleLeft;
            btnInformes.Location = new Point(3, 226);
            btnInformes.Margin = new Padding(3, 2, 3, 2);
            btnInformes.Name = "btnInformes";
            btnInformes.Size = new Size(185, 47);
            btnInformes.TabIndex = 6;
            btnInformes.Text = "Informes";
            btnInformes.UseVisualStyleBackColor = true;
            btnInformes.Click += btnInformes_Click;
            // 
            // btnFacturacion
            // 
            btnFacturacion.FlatAppearance.BorderSize = 0;
            btnFacturacion.FlatAppearance.MouseDownBackColor = Color.FromArgb(45, 45, 45);
            btnFacturacion.FlatStyle = FlatStyle.Flat;
            btnFacturacion.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFacturacion.ForeColor = SystemColors.ButtonFace;
            btnFacturacion.Image = (Image)resources.GetObject("btnFacturacion.Image");
            btnFacturacion.ImageAlign = ContentAlignment.MiddleLeft;
            btnFacturacion.Location = new Point(3, 155);
            btnFacturacion.Margin = new Padding(3, 2, 3, 2);
            btnFacturacion.Name = "btnFacturacion";
            btnFacturacion.Size = new Size(185, 49);
            btnFacturacion.TabIndex = 5;
            btnFacturacion.Text = "Facturas";
            btnFacturacion.UseVisualStyleBackColor = true;
            btnFacturacion.Click += btnFacturacion_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(9, 13);
            pictureBox5.Margin = new Padding(3, 2, 3, 2);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(128, 128);
            pictureBox5.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox5.TabIndex = 1;
            pictureBox5.TabStop = false;
            // 
            // seguridad
            // 
            seguridad.BackColor = Color.CornflowerBlue;
            seguridad.Controls.Add(btnSeguridad);
            seguridad.Controls.Add(btnRoles);
            seguridad.Controls.Add(btnEmpleados);
            seguridad.Controls.Add(pictureBox3);
            seguridad.Location = new Point(4, 64);
            seguridad.Margin = new Padding(3, 2, 3, 2);
            seguridad.Name = "seguridad";
            seguridad.Size = new Size(148, 549);
            seguridad.TabIndex = 3;
            seguridad.Text = "SEGURIDAD";
            seguridad.Click += seguridad_Click;
            // 
            // btnSeguridad
            // 
            btnSeguridad.BackColor = Color.CornflowerBlue;
            btnSeguridad.FlatAppearance.BorderSize = 0;
            btnSeguridad.FlatAppearance.MouseDownBackColor = Color.FromArgb(45, 45, 45);
            btnSeguridad.FlatStyle = FlatStyle.Flat;
            btnSeguridad.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold);
            btnSeguridad.ForeColor = SystemColors.ButtonFace;
            btnSeguridad.Image = (Image)resources.GetObject("btnSeguridad.Image");
            btnSeguridad.ImageAlign = ContentAlignment.MiddleLeft;
            btnSeguridad.Location = new Point(3, 297);
            btnSeguridad.Margin = new Padding(3, 2, 3, 2);
            btnSeguridad.Name = "btnSeguridad";
            btnSeguridad.Size = new Size(176, 40);
            btnSeguridad.TabIndex = 9;
            btnSeguridad.Text = "Seguridad";
            btnSeguridad.UseVisualStyleBackColor = false;
            btnSeguridad.Click += btnSeguridad_Click;
            // 
            // btnRoles
            // 
            btnRoles.BackColor = Color.CornflowerBlue;
            btnRoles.FlatAppearance.BorderSize = 0;
            btnRoles.FlatAppearance.MouseDownBackColor = Color.FromArgb(45, 45, 45);
            btnRoles.FlatStyle = FlatStyle.Flat;
            btnRoles.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold);
            btnRoles.ForeColor = SystemColors.ButtonFace;
            btnRoles.Image = (Image)resources.GetObject("btnRoles.Image");
            btnRoles.ImageAlign = ContentAlignment.MiddleLeft;
            btnRoles.Location = new Point(3, 226);
            btnRoles.Margin = new Padding(3, 2, 3, 2);
            btnRoles.Name = "btnRoles";
            btnRoles.Size = new Size(129, 40);
            btnRoles.TabIndex = 8;
            btnRoles.Text = "Roles";
            btnRoles.UseVisualStyleBackColor = false;
            btnRoles.Click += btnRoles_Click_1;
            // 
            // btnEmpleados
            // 
            btnEmpleados.BackColor = Color.CornflowerBlue;
            btnEmpleados.FlatAppearance.BorderSize = 0;
            btnEmpleados.FlatAppearance.MouseDownBackColor = Color.FromArgb(45, 45, 45);
            btnEmpleados.FlatStyle = FlatStyle.Flat;
            btnEmpleados.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold);
            btnEmpleados.ForeColor = SystemColors.ButtonFace;
            btnEmpleados.Image = (Image)resources.GetObject("btnEmpleados.Image");
            btnEmpleados.ImageAlign = ContentAlignment.MiddleLeft;
            btnEmpleados.Location = new Point(3, 155);
            btnEmpleados.Margin = new Padding(3, 2, 3, 2);
            btnEmpleados.Name = "btnEmpleados";
            btnEmpleados.Size = new Size(176, 40);
            btnEmpleados.TabIndex = 7;
            btnEmpleados.Text = "Empleados";
            btnEmpleados.UseVisualStyleBackColor = false;
            btnEmpleados.Click += btnEmpleados_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(9, 13);
            pictureBox3.Margin = new Padding(3, 2, 3, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(128, 128);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 1;
            pictureBox3.TabStop = false;
            // 
            // ayuda
            // 
            ayuda.BackColor = Color.CornflowerBlue;
            ayuda.Controls.Add(btnAyuda);
            ayuda.Controls.Add(btnAcerca);
            ayuda.Controls.Add(pictureBox4);
            ayuda.Location = new Point(4, 64);
            ayuda.Margin = new Padding(3, 2, 3, 2);
            ayuda.Name = "ayuda";
            ayuda.Size = new Size(148, 549);
            ayuda.TabIndex = 4;
            ayuda.Text = "AYUDA";
            // 
            // btnAyuda
            // 
            btnAyuda.FlatAppearance.BorderSize = 0;
            btnAyuda.FlatAppearance.MouseDownBackColor = Color.FromArgb(45, 45, 45);
            btnAyuda.FlatStyle = FlatStyle.Flat;
            btnAyuda.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAyuda.ForeColor = SystemColors.ButtonFace;
            btnAyuda.Image = (Image)resources.GetObject("btnAyuda.Image");
            btnAyuda.ImageAlign = ContentAlignment.MiddleLeft;
            btnAyuda.Location = new Point(5, 155);
            btnAyuda.Margin = new Padding(3, 2, 3, 2);
            btnAyuda.Name = "btnAyuda";
            btnAyuda.Size = new Size(146, 54);
            btnAyuda.TabIndex = 10;
            btnAyuda.Text = "Ayuda";
            btnAyuda.UseVisualStyleBackColor = true;
            btnAyuda.Click += btnAyuda_Click;
            // 
            // btnAcerca
            // 
            btnAcerca.FlatAppearance.BorderSize = 0;
            btnAcerca.FlatAppearance.MouseDownBackColor = Color.FromArgb(45, 45, 45);
            btnAcerca.FlatStyle = FlatStyle.Flat;
            btnAcerca.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAcerca.ForeColor = SystemColors.ButtonFace;
            btnAcerca.Image = (Image)resources.GetObject("btnAcerca.Image");
            btnAcerca.ImageAlign = ContentAlignment.MiddleLeft;
            btnAcerca.Location = new Point(3, 226);
            btnAcerca.Margin = new Padding(3, 2, 3, 2);
            btnAcerca.Name = "btnAcerca";
            btnAcerca.Size = new Size(175, 63);
            btnAcerca.TabIndex = 11;
            btnAcerca.Text = "Acerca de..";
            btnAcerca.UseVisualStyleBackColor = true;
            btnAcerca.Click += btnAcerca_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(9, 13);
            pictureBox4.Margin = new Padding(3, 2, 3, 2);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(128, 128);
            pictureBox4.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox4.TabIndex = 1;
            pictureBox4.TabStop = false;
            // 
            // TabOpcionesMenu
            // 
            TabOpcionesMenu.BaseTabControl = TbpMenu;
            TabOpcionesMenu.CharacterCasing = MaterialSkin.Controls.MaterialTabSelector.CustomCharacterCasing.Normal;
            TabOpcionesMenu.Depth = 0;
            TabOpcionesMenu.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            TabOpcionesMenu.Location = new Point(247, 19);
            TabOpcionesMenu.Margin = new Padding(3, 2, 3, 2);
            TabOpcionesMenu.MouseState = MaterialSkin.MouseState.HOVER;
            TabOpcionesMenu.Name = "TabOpcionesMenu";
            TabOpcionesMenu.Size = new Size(798, 28);
            TabOpcionesMenu.TabIndex = 4;
            TabOpcionesMenu.Click += TabOpcionesMenu_Click;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(1279, 757);
            Controls.Add(pnlPrincipal);
            Controls.Add(TabOpcionesMenu);
            Controls.Add(label1);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmPrincipal";
            Padding = new Padding(3, 48, 3, 2);
            RightToLeft = RightToLeft.No;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SISTEMA DE FACTURACIÓN";
            Load += frmPrincipal_Load;
            pnlPrincipal.ResumeLayout(false);
            panel1.ResumeLayout(false);
            TbpMenu.ResumeLayout(false);
            principal.ResumeLayout(false);
            principal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            tablas.ResumeLayout(false);
            tablas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            facturacion.ResumeLayout(false);
            facturacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            seguridad.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ayuda.ResumeLayout(false);
            ayuda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private FolderBrowserDialog folderBrowserDialog1;
        private Label label1;
        private Panel pnlPrincipal;
        private Panel panel1;
        private MaterialSkin.Controls.MaterialTabControl TbpMenu;
        private TabPage principal;
        private TabPage tablas;
        private TabPage facturacion;
        private TabPage seguridad;
        private TabPage ayuda;
        private MaterialSkin.Controls.MaterialTabSelector TabOpcionesMenu;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox5;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox6;
        private Button BtnSalir;
        private Button btnClientes;
        private Button btnCategorias;
        private Button btnProductos;
        private Button btnInformes;
        private Button btnFacturacion;
        private Button btnSeguridad;
        private Button btnRoles;
        private Button btnEmpleados;
        private Button btnAcerca;
        private Button btnAyuda;

        // Contenedores
        private Panel panelContenedor; // único
        private Panel pnlEmpleados;    // único
    }
}
