namespace CapaPresentacion
{
    partial class frmEmpleadoLista
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlCliente = new System.Windows.Forms.Panel();
            this.cmbAvala = new System.Windows.Forms.ComboBox();
            this.cmbGeneroCli = new System.Windows.Forms.ComboBox();
            this.txtFechingCli = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtCodigoCli = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtApellidosCli = new System.Windows.Forms.TextBox();
            this.txtEmailCli = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtNombreCli = new System.Windows.Forms.TextBox();
            this.txtLugarCli = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtDireccionCli = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.txtFechanacCli = new System.Windows.Forms.TextBox();
            this.pnlEmpleado = new System.Windows.Forms.Panel();
            this.txtFecnaEmp = new System.Windows.Forms.TextBox();
            this.txtSueldoEmp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCodigoEmp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtApellidosEmp = new System.Windows.Forms.TextBox();
            this.txtFechingEmp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNombresEmp = new System.Windows.Forms.TextBox();
            this.txtEmailEmp = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDireccionEmp = new System.Windows.Forms.TextBox();
            this.txtTelefonoEmp = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtLugarEmp = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlCliente.SuspendLayout();
            this.pnlEmpleado.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Location = new System.Drawing.Point(410, 11);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(159, 31);
            this.button2.TabIndex = 2;
            this.button2.Text = "Mostrar empleados";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Image = global::CapaPresentacion.Properties.Resources.nuevo;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(410, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 31);
            this.button1.TabIndex = 3;
            this.button1.Text = "Mostrar clientes";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView1.ColumnHeadersHeight = 30;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.SteelBlue;
            this.dataGridView1.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.dataGridView1.Location = new System.Drawing.Point(15, 241);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(15);
            this.dataGridView1.MaximumSize = new System.Drawing.Size(1050, 500);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridView1.Size = new System.Drawing.Size(757, 289);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(48)))), ((int)(((byte)(58)))));
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 545);
            this.panel1.TabIndex = 4;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(29, 32);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(161, 31);
            this.button6.TabIndex = 28;
            this.button6.Text = "Empleado";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(29, 70);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(161, 31);
            this.button5.TabIndex = 27;
            this.button5.Text = "Cliente";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(575, 11);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(150, 31);
            this.button4.TabIndex = 26;
            this.button4.Text = "Ingresar Nuevo Cliente";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(575, 11);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(150, 31);
            this.button3.TabIndex = 4;
            this.button3.Text = "Ingresar Nuevo Empleado";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(59)))), ((int)(((byte)(71)))));
            this.panel2.Controls.Add(this.pnlCliente);
            this.panel2.Controls.Add(this.pnlEmpleado);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(220, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(787, 545);
            this.panel2.TabIndex = 5;
            // 
            // pnlCliente
            // 
            this.pnlCliente.Controls.Add(this.btnLimpiar);
            this.pnlCliente.Controls.Add(this.cmbAvala);
            this.pnlCliente.Controls.Add(this.cmbGeneroCli);
            this.pnlCliente.Controls.Add(this.txtFechingCli);
            this.pnlCliente.Controls.Add(this.button4);
            this.pnlCliente.Controls.Add(this.button1);
            this.pnlCliente.Controls.Add(this.label11);
            this.pnlCliente.Controls.Add(this.label12);
            this.pnlCliente.Controls.Add(this.txtCodigoCli);
            this.pnlCliente.Controls.Add(this.label13);
            this.pnlCliente.Controls.Add(this.label14);
            this.pnlCliente.Controls.Add(this.txtApellidosCli);
            this.pnlCliente.Controls.Add(this.txtEmailCli);
            this.pnlCliente.Controls.Add(this.label15);
            this.pnlCliente.Controls.Add(this.label16);
            this.pnlCliente.Controls.Add(this.txtNombreCli);
            this.pnlCliente.Controls.Add(this.txtLugarCli);
            this.pnlCliente.Controls.Add(this.label17);
            this.pnlCliente.Controls.Add(this.label18);
            this.pnlCliente.Controls.Add(this.txtDireccionCli);
            this.pnlCliente.Controls.Add(this.label19);
            this.pnlCliente.Controls.Add(this.label20);
            this.pnlCliente.Controls.Add(this.txtFechanacCli);
            this.pnlCliente.Location = new System.Drawing.Point(15, 239);
            this.pnlCliente.Name = "pnlCliente";
            this.pnlCliente.Size = new System.Drawing.Size(751, 212);
            this.pnlCliente.TabIndex = 25;
            // 
            // cmbAvala
            // 
            this.cmbAvala.FormattingEnabled = true;
            this.cmbAvala.Location = new System.Drawing.Point(468, 167);
            this.cmbAvala.Name = "cmbAvala";
            this.cmbAvala.Size = new System.Drawing.Size(103, 21);
            this.cmbAvala.TabIndex = 27;
            this.cmbAvala.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cmbGeneroCli
            // 
            this.cmbGeneroCli.FormattingEnabled = true;
            this.cmbGeneroCli.Items.AddRange(new object[] {
            "F",
            "M"});
            this.cmbGeneroCli.Location = new System.Drawing.Point(128, 142);
            this.cmbGeneroCli.Name = "cmbGeneroCli";
            this.cmbGeneroCli.Size = new System.Drawing.Size(44, 21);
            this.cmbGeneroCli.TabIndex = 24;
            // 
            // txtFechingCli
            // 
            this.txtFechingCli.Location = new System.Drawing.Point(468, 142);
            this.txtFechingCli.Name = "txtFechingCli";
            this.txtFechingCli.Size = new System.Drawing.Size(221, 20);
            this.txtFechingCli.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(67, 67);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "Código :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(407, 171);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "Avala :";
            // 
            // txtCodigoCli
            // 
            this.txtCodigoCli.Location = new System.Drawing.Point(128, 64);
            this.txtCodigoCli.Name = "txtCodigoCli";
            this.txtCodigoCli.Size = new System.Drawing.Size(221, 20);
            this.txtCodigoCli.TabIndex = 5;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(67, 93);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 13);
            this.label13.TabIndex = 6;
            this.label13.Text = "Apellidos :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(407, 145);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(43, 13);
            this.label14.TabIndex = 20;
            this.label14.Text = "F. Ing. :";
            // 
            // txtApellidosCli
            // 
            this.txtApellidosCli.Location = new System.Drawing.Point(128, 90);
            this.txtApellidosCli.Name = "txtApellidosCli";
            this.txtApellidosCli.Size = new System.Drawing.Size(221, 20);
            this.txtApellidosCli.TabIndex = 7;
            // 
            // txtEmailCli
            // 
            this.txtEmailCli.Location = new System.Drawing.Point(468, 116);
            this.txtEmailCli.Name = "txtEmailCli";
            this.txtEmailCli.Size = new System.Drawing.Size(221, 20);
            this.txtEmailCli.TabIndex = 19;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(67, 119);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(50, 13);
            this.label15.TabIndex = 8;
            this.label15.Text = "Nombre :";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(407, 119);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(38, 13);
            this.label16.TabIndex = 18;
            this.label16.Text = "Email :";
            // 
            // txtNombreCli
            // 
            this.txtNombreCli.Location = new System.Drawing.Point(128, 116);
            this.txtNombreCli.Name = "txtNombreCli";
            this.txtNombreCli.Size = new System.Drawing.Size(221, 20);
            this.txtNombreCli.TabIndex = 9;
            // 
            // txtLugarCli
            // 
            this.txtLugarCli.Location = new System.Drawing.Point(468, 90);
            this.txtLugarCli.Name = "txtLugarCli";
            this.txtLugarCli.Size = new System.Drawing.Size(221, 20);
            this.txtLugarCli.TabIndex = 17;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(67, 145);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(48, 13);
            this.label17.TabIndex = 10;
            this.label17.Text = "Género :";
            this.label17.Click += new System.EventHandler(this.label17_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(407, 93);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(40, 13);
            this.label18.TabIndex = 16;
            this.label18.Text = "Lugar :";
            // 
            // txtDireccionCli
            // 
            this.txtDireccionCli.Location = new System.Drawing.Point(468, 64);
            this.txtDireccionCli.Name = "txtDireccionCli";
            this.txtDireccionCli.Size = new System.Drawing.Size(221, 20);
            this.txtDireccionCli.TabIndex = 15;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(67, 171);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(48, 13);
            this.label19.TabIndex = 12;
            this.label19.Text = "F. Nac. :";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(407, 67);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(58, 13);
            this.label20.TabIndex = 14;
            this.label20.Text = "Dirección :";
            // 
            // txtFechanacCli
            // 
            this.txtFechanacCli.Location = new System.Drawing.Point(128, 168);
            this.txtFechanacCli.Name = "txtFechanacCli";
            this.txtFechanacCli.Size = new System.Drawing.Size(221, 20);
            this.txtFechanacCli.TabIndex = 13;
            // 
            // pnlEmpleado
            // 
            this.pnlEmpleado.Controls.Add(this.button7);
            this.pnlEmpleado.Controls.Add(this.txtFecnaEmp);
            this.pnlEmpleado.Controls.Add(this.txtSueldoEmp);
            this.pnlEmpleado.Controls.Add(this.label1);
            this.pnlEmpleado.Controls.Add(this.button3);
            this.pnlEmpleado.Controls.Add(this.label6);
            this.pnlEmpleado.Controls.Add(this.button2);
            this.pnlEmpleado.Controls.Add(this.txtCodigoEmp);
            this.pnlEmpleado.Controls.Add(this.label2);
            this.pnlEmpleado.Controls.Add(this.label7);
            this.pnlEmpleado.Controls.Add(this.txtApellidosEmp);
            this.pnlEmpleado.Controls.Add(this.txtFechingEmp);
            this.pnlEmpleado.Controls.Add(this.label3);
            this.pnlEmpleado.Controls.Add(this.label8);
            this.pnlEmpleado.Controls.Add(this.txtNombresEmp);
            this.pnlEmpleado.Controls.Add(this.txtEmailEmp);
            this.pnlEmpleado.Controls.Add(this.label4);
            this.pnlEmpleado.Controls.Add(this.label9);
            this.pnlEmpleado.Controls.Add(this.txtDireccionEmp);
            this.pnlEmpleado.Controls.Add(this.txtTelefonoEmp);
            this.pnlEmpleado.Controls.Add(this.label5);
            this.pnlEmpleado.Controls.Add(this.label10);
            this.pnlEmpleado.Controls.Add(this.txtLugarEmp);
            this.pnlEmpleado.Location = new System.Drawing.Point(15, 21);
            this.pnlEmpleado.Name = "pnlEmpleado";
            this.pnlEmpleado.Size = new System.Drawing.Size(751, 212);
            this.pnlEmpleado.TabIndex = 24;
            // 
            // txtFecnaEmp
            // 
            this.txtFecnaEmp.Location = new System.Drawing.Point(468, 142);
            this.txtFecnaEmp.Name = "txtFecnaEmp";
            this.txtFecnaEmp.Size = new System.Drawing.Size(221, 20);
            this.txtFecnaEmp.TabIndex = 21;
            // 
            // txtSueldoEmp
            // 
            this.txtSueldoEmp.Location = new System.Drawing.Point(468, 168);
            this.txtSueldoEmp.Name = "txtSueldoEmp";
            this.txtSueldoEmp.Size = new System.Drawing.Size(221, 20);
            this.txtSueldoEmp.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(67, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Código :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(407, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Sueldo :";
            // 
            // txtCodigoEmp
            // 
            this.txtCodigoEmp.Location = new System.Drawing.Point(128, 64);
            this.txtCodigoEmp.Name = "txtCodigoEmp";
            this.txtCodigoEmp.Size = new System.Drawing.Size(221, 20);
            this.txtCodigoEmp.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(67, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Apellidos :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(407, 145);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "F. Nac. :";
            // 
            // txtApellidosEmp
            // 
            this.txtApellidosEmp.Location = new System.Drawing.Point(128, 90);
            this.txtApellidosEmp.Name = "txtApellidosEmp";
            this.txtApellidosEmp.Size = new System.Drawing.Size(221, 20);
            this.txtApellidosEmp.TabIndex = 7;
            // 
            // txtFechingEmp
            // 
            this.txtFechingEmp.Location = new System.Drawing.Point(468, 116);
            this.txtFechingEmp.Name = "txtFechingEmp";
            this.txtFechingEmp.Size = new System.Drawing.Size(221, 20);
            this.txtFechingEmp.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(67, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Nombres :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(407, 119);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "F. Ing. :";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // txtNombresEmp
            // 
            this.txtNombresEmp.Location = new System.Drawing.Point(128, 116);
            this.txtNombresEmp.Name = "txtNombresEmp";
            this.txtNombresEmp.Size = new System.Drawing.Size(221, 20);
            this.txtNombresEmp.TabIndex = 9;
            // 
            // txtEmailEmp
            // 
            this.txtEmailEmp.Location = new System.Drawing.Point(468, 90);
            this.txtEmailEmp.Name = "txtEmailEmp";
            this.txtEmailEmp.Size = new System.Drawing.Size(221, 20);
            this.txtEmailEmp.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(67, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Dirección :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(407, 93);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Email :";
            // 
            // txtDireccionEmp
            // 
            this.txtDireccionEmp.Location = new System.Drawing.Point(128, 142);
            this.txtDireccionEmp.Name = "txtDireccionEmp";
            this.txtDireccionEmp.Size = new System.Drawing.Size(221, 20);
            this.txtDireccionEmp.TabIndex = 11;
            // 
            // txtTelefonoEmp
            // 
            this.txtTelefonoEmp.Location = new System.Drawing.Point(468, 64);
            this.txtTelefonoEmp.Name = "txtTelefonoEmp";
            this.txtTelefonoEmp.Size = new System.Drawing.Size(221, 20);
            this.txtTelefonoEmp.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(67, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Lugar :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(407, 67);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Telefono :";
            // 
            // txtLugarEmp
            // 
            this.txtLugarEmp.Location = new System.Drawing.Point(128, 168);
            this.txtLugarEmp.Name = "txtLugarEmp";
            this.txtLugarEmp.Size = new System.Drawing.Size(221, 20);
            this.txtLugarEmp.TabIndex = 13;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(15, 11);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 31);
            this.btnLimpiar.TabIndex = 28;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(15, 11);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 31);
            this.button7.TabIndex = 29;
            this.button7.Text = "Limpiar";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // frmEmpleadoLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 545);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmEmpleadoLista";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmEmpleadoLista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.pnlCliente.ResumeLayout(false);
            this.pnlCliente.PerformLayout();
            this.pnlEmpleado.ResumeLayout(false);
            this.pnlEmpleado.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtSueldoEmp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtFecnaEmp;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtFechingEmp;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtEmailEmp;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTelefonoEmp;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtLugarEmp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDireccionEmp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombresEmp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtApellidosEmp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodigoEmp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel pnlCliente;
        private System.Windows.Forms.TextBox txtFechingCli;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtCodigoCli;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtApellidosCli;
        private System.Windows.Forms.TextBox txtEmailCli;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtNombreCli;
        private System.Windows.Forms.TextBox txtLugarCli;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtDireccionCli;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtFechanacCli;
        private System.Windows.Forms.Panel pnlEmpleado;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox cmbGeneroCli;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ComboBox cmbAvala;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button button7;
    }
}

