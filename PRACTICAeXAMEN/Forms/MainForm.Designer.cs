namespace PRACTICAeXAMEN
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            menuStrip1 = new MenuStrip();
            archivoToolStripMenuItem = new ToolStripMenuItem();
            guardarToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            pacientesToolStripMenuItem = new ToolStripMenuItem();
            buscarToolStripMenuItem = new ToolStripMenuItem();
            ayudaToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            toolStrip1 = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
            toolStripButton3 = new ToolStripButton();
            splitContainer1 = new SplitContainer();
            flowLayoutPanel1 = new FlowLayoutPanel();
            button1 = new Button();
            button3 = new Button();
            groupBox2 = new GroupBox();
            dateTimePicker1 = new DateTimePicker();
            label10 = new Label();
            txtConsulta = new TextBox();
            label9 = new Label();
            label2 = new Label();
            mtbAltura = new MaskedTextBox();
            mtbPeso = new MaskedTextBox();
            label1 = new Label();
            mtbFecha = new MaskedTextBox();
            rbtFemenino = new RadioButton();
            rbtMasculino = new RadioButton();
            label5 = new Label();
            label6 = new Label();
            txtApellidos = new TextBox();
            label7 = new Label();
            txtNombres = new TextBox();
            label8 = new Label();
            groupBox1 = new GroupBox();
            mtbTelefono = new MaskedTextBox();
            label3 = new Label();
            txtDirección = new TextBox();
            label4 = new Label();
            tabControl1 = new TabControl();
            tabPageRegistro = new TabPage();
            tabPageVerHistorial = new TabPage();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem, pacientesToolStripMenuItem, ayudaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1212, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            archivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { guardarToolStripMenuItem, salirToolStripMenuItem });
            archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            archivoToolStripMenuItem.Size = new Size(60, 20);
            archivoToolStripMenuItem.Text = "Archivo";
            // 
            // guardarToolStripMenuItem
            // 
            guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            guardarToolStripMenuItem.Size = new Size(180, 22);
            guardarToolStripMenuItem.Text = "Guardar";
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(180, 22);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += salir;
            salirToolStripMenuItem.MouseEnter += MostrarEstado;
            // 
            // pacientesToolStripMenuItem
            // 
            pacientesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { buscarToolStripMenuItem });
            pacientesToolStripMenuItem.Name = "pacientesToolStripMenuItem";
            pacientesToolStripMenuItem.Size = new Size(69, 20);
            pacientesToolStripMenuItem.Text = "Pacientes";
            // 
            // buscarToolStripMenuItem
            // 
            buscarToolStripMenuItem.Name = "buscarToolStripMenuItem";
            buscarToolStripMenuItem.Size = new Size(109, 22);
            buscarToolStripMenuItem.Text = "Buscar";
            // 
            // ayudaToolStripMenuItem
            // 
            ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            ayudaToolStripMenuItem.Size = new Size(53, 20);
            ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 499);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1212, 22);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(118, 17);
            toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            toolStripStatusLabel1.Visible = false;
            // 
            // toolStrip1
            // 
            toolStrip1.Dock = DockStyle.Bottom;
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1, toolStripButton2, toolStripButton3 });
            toolStrip1.Location = new Point(0, 474);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1212, 25);
            toolStrip1.TabIndex = 3;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(53, 22);
            toolStripButton1.Text = "Guardar";
            // 
            // toolStripButton2
            // 
            toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton2.Image = (Image)resources.GetObject("toolStripButton2.Image");
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(46, 22);
            toolStripButton2.Text = "Buscar";
            // 
            // toolStripButton3
            // 
            toolStripButton3.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton3.Image = (Image)resources.GetObject("toolStripButton3.Image");
            toolStripButton3.ImageTransparentColor = Color.Magenta;
            toolStripButton3.Name = "toolStripButton3";
            toolStripButton3.Size = new Size(33, 22);
            toolStripButton3.Text = "Salir";
            toolStripButton3.Click += salir;
            toolStripButton3.MouseEnter += MostrarEstado;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 24);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(flowLayoutPanel1);
            splitContainer1.Panel1.Controls.Add(groupBox2);
            splitContainer1.Panel1.Controls.Add(groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(tabControl1);
            splitContainer1.Size = new Size(1212, 450);
            splitContainer1.SplitterDistance = 472;
            splitContainer1.TabIndex = 4;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel1.Controls.Add(button1);
            flowLayoutPanel1.Controls.Add(button3);
            flowLayoutPanel1.Location = new Point(88, 405);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(250, 30);
            flowLayoutPanel1.TabIndex = 12;
            // 
            // button1
            // 
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(117, 23);
            button1.TabIndex = 12;
            button1.Text = "Añadir paciente";
            button1.UseVisualStyleBackColor = true;
            button1.Click += AñadiralRegistro;
            button1.MouseEnter += Mostrarstatus;
            // 
            // button3
            // 
            button3.Location = new Point(126, 3);
            button3.Name = "button3";
            button3.Size = new Size(112, 23);
            button3.TabIndex = 14;
            button3.Text = "Limpiar Campos";
            button3.UseVisualStyleBackColor = true;
            button3.Click += LimpiarCampos;
            button3.MouseEnter += mostrarStatus;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(dateTimePicker1);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(txtConsulta);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(mtbAltura);
            groupBox2.Controls.Add(mtbPeso);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(mtbFecha);
            groupBox2.Controls.Add(rbtFemenino);
            groupBox2.Controls.Add(rbtMasculino);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(txtApellidos);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(txtNombres);
            groupBox2.Controls.Add(label8);
            groupBox2.Location = new Point(24, 16);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(423, 270);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "Detalles Medicos";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(140, 235);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(214, 23);
            dateTimePicker1.TabIndex = 9;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(11, 238);
            label10.Name = "label10";
            label10.Size = new Size(119, 17);
            label10.TabIndex = 20;
            label10.Text = " Fecha de consulta:";
            // 
            // txtConsulta
            // 
            txtConsulta.Location = new Point(140, 206);
            txtConsulta.Name = "txtConsulta";
            txtConsulta.Size = new Size(208, 23);
            txtConsulta.TabIndex = 8;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(11, 209);
            label9.Name = "label9";
            label9.Size = new Size(123, 17);
            label9.TabIndex = 18;
            label9.Text = "Motivo de consulta:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(11, 181);
            label2.Name = "label2";
            label2.Size = new Size(45, 17);
            label2.TabIndex = 17;
            label2.Text = "Altura:";
            // 
            // mtbAltura
            // 
            mtbAltura.Location = new Point(64, 175);
            mtbAltura.Mask = "0.00 mts";
            mtbAltura.Name = "mtbAltura";
            mtbAltura.Size = new Size(80, 23);
            mtbAltura.TabIndex = 7;
            // 
            // mtbPeso
            // 
            mtbPeso.Location = new Point(64, 146);
            mtbPeso.Mask = "000.00 lb";
            mtbPeso.Name = "mtbPeso";
            mtbPeso.Size = new Size(80, 23);
            mtbPeso.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(11, 147);
            label1.Name = "label1";
            label1.Size = new Size(43, 17);
            label1.TabIndex = 14;
            label1.Text = "Peso: ";
            // 
            // mtbFecha
            // 
            mtbFecha.Location = new Point(150, 82);
            mtbFecha.Mask = "00/00/0000";
            mtbFecha.Name = "mtbFecha";
            mtbFecha.Size = new Size(100, 23);
            mtbFecha.TabIndex = 3;
            mtbFecha.ValidatingType = typeof(DateTime);
            // 
            // rbtFemenino
            // 
            rbtFemenino.AutoSize = true;
            rbtFemenino.Location = new Point(150, 121);
            rbtFemenino.Name = "rbtFemenino";
            rbtFemenino.Size = new Size(78, 19);
            rbtFemenino.TabIndex = 5;
            rbtFemenino.TabStop = true;
            rbtFemenino.Text = "Femenino";
            rbtFemenino.UseVisualStyleBackColor = true;
            // 
            // rbtMasculino
            // 
            rbtMasculino.AutoSize = true;
            rbtMasculino.Location = new Point(64, 121);
            rbtMasculino.Name = "rbtMasculino";
            rbtMasculino.Size = new Size(80, 19);
            rbtMasculino.TabIndex = 4;
            rbtMasculino.TabStop = true;
            rbtMasculino.Text = "Masculino";
            rbtMasculino.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(11, 121);
            label5.Name = "label5";
            label5.Size = new Size(43, 17);
            label5.TabIndex = 9;
            label5.Text = "Sexo: ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(11, 88);
            label6.Name = "label6";
            label6.Size = new Size(133, 17);
            label6.TabIndex = 7;
            label6.Text = "Fecha de Nacimiento:";
            // 
            // txtApellidos
            // 
            txtApellidos.Location = new Point(82, 22);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(273, 23);
            txtApellidos.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(11, 24);
            label7.Name = "label7";
            label7.Size = new Size(65, 17);
            label7.TabIndex = 2;
            label7.Text = "Apellidos:";
            // 
            // txtNombres
            // 
            txtNombres.Location = new Point(82, 53);
            txtNombres.Name = "txtNombres";
            txtNombres.Size = new Size(273, 23);
            txtNombres.TabIndex = 2;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(10, 54);
            label8.Name = "label8";
            label8.Size = new Size(66, 17);
            label8.TabIndex = 0;
            label8.Text = "Nombres:";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(mtbTelefono);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtDirección);
            groupBox1.Controls.Add(label4);
            groupBox1.Location = new Point(24, 292);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(423, 97);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Información Contacto";
            // 
            // mtbTelefono
            // 
            mtbTelefono.Location = new Point(82, 59);
            mtbTelefono.Mask = "+999 0000-0000";
            mtbTelefono.Name = "mtbTelefono";
            mtbTelefono.Size = new Size(272, 23);
            mtbTelefono.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(10, 59);
            label3.Name = "label3";
            label3.Size = new Size(65, 17);
            label3.TabIndex = 9;
            label3.Text = "Telefono: ";
            // 
            // txtDirección
            // 
            txtDirección.Location = new Point(82, 22);
            txtDirección.Name = "txtDirección";
            txtDirección.Size = new Size(273, 23);
            txtDirección.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(10, 23);
            label4.Name = "label4";
            label4.Size = new Size(69, 17);
            label4.TabIndex = 7;
            label4.Text = "Dirección: ";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageRegistro);
            tabControl1.Controls.Add(tabPageVerHistorial);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(736, 450);
            tabControl1.TabIndex = 0;
            tabControl1.SelectedIndexChanged += MostrarForm;
            // 
            // tabPageRegistro
            // 
            tabPageRegistro.Location = new Point(4, 24);
            tabPageRegistro.Name = "tabPageRegistro";
            tabPageRegistro.Padding = new Padding(3);
            tabPageRegistro.Size = new Size(728, 422);
            tabPageRegistro.TabIndex = 0;
            tabPageRegistro.Text = "Registro";
            tabPageRegistro.UseVisualStyleBackColor = true;
            // 
            // tabPageVerHistorial
            // 
            tabPageVerHistorial.Location = new Point(4, 24);
            tabPageVerHistorial.Name = "tabPageVerHistorial";
            tabPageVerHistorial.Padding = new Padding(3);
            tabPageVerHistorial.Size = new Size(728, 422);
            tabPageVerHistorial.TabIndex = 1;
            tabPageVerHistorial.Text = "Historial Medico";
            tabPageVerHistorial.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1212, 521);
            Controls.Add(splitContainer1);
            Controls.Add(toolStrip1);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private StatusStrip statusStrip1;
        private ToolStrip toolStrip1;
        private SplitContainer splitContainer1;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem guardarToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem pacientesToolStripMenuItem;
        private ToolStripMenuItem buscarToolStripMenuItem;
        private ToolStripMenuItem ayudaToolStripMenuItem;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton2;
        private ToolStripButton toolStripButton3;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private GroupBox groupBox1;
        private Label label4;
        private GroupBox groupBox2;
        private Label label5;
        private Label label6;
        private TextBox txtApellidos;
        private Label label7;
        private TextBox txtNombres;
        private Label label8;
        private MaskedTextBox mtbTelefono;
        private Label label3;
        private TextBox txtDirección;
        private RadioButton rbtFemenino;
        private RadioButton rbtMasculino;
        private MaskedTextBox mtbFecha;
        private Label label2;
        private MaskedTextBox mtbAltura;
        private MaskedTextBox mtbPeso;
        private Label label1;
        private TextBox txtConsulta;
        private Label label9;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button button1;
        private Button button3;
        private TabControl tabControl1;
        private TabPage tabPageRegistro;
        private TabPage tabPageVerHistorial;
        private DateTimePicker dateTimePicker1;
        private Label label10;
    }
}