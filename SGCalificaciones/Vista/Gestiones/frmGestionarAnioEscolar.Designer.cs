
namespace SGCalificaciones.Vista.Gestiones
{
    partial class frmGestionarAnioEscolar
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label bimestreLabel;
            System.Windows.Forms.Label id_bimestreLabel;
            System.Windows.Forms.Label id_cursoLabel;
            System.Windows.Forms.Label nom_cursoLabel;
            System.Windows.Forms.Label nro_carnetLabel;
            System.Windows.Forms.Label paraleloLabel;
            System.Windows.Forms.Label id_materiaLabel;
            System.Windows.Forms.Label nombre_materiaLabel;
            this.label1 = new System.Windows.Forms.Label();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.cursoDataGridView = new System.Windows.Forms.DataGridView();
            this.bimestreDataGridView = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancelarBim = new FontAwesome.Sharp.IconButton();
            this.btnNuevoBim = new FontAwesome.Sharp.IconButton();
            this.btnGuardarBim = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.bimestreTextBox = new System.Windows.Forms.TextBox();
            this.id_bimestreTextBox = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCancelarCurso = new FontAwesome.Sharp.IconButton();
            this.btnNuevoCurso = new FontAwesome.Sharp.IconButton();
            this.btnGuardarCurso = new FontAwesome.Sharp.IconButton();
            this.btnBuscarProfesor = new FontAwesome.Sharp.IconButton();
            this.id_cursoTextBox = new System.Windows.Forms.TextBox();
            this.nom_cursoTextBox = new System.Windows.Forms.TextBox();
            this.nro_carnetTextBox = new System.Windows.Forms.TextBox();
            this.paraleloTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.materiaDataGridView = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.id_materiaTextBox = new System.Windows.Forms.TextBox();
            this.nombre_materiaTextBox = new System.Windows.Forms.TextBox();
            this.btnCancelarMat = new FontAwesome.Sharp.IconButton();
            this.btnNuevoMat = new FontAwesome.Sharp.IconButton();
            this.btnGuardarMat = new FontAwesome.Sharp.IconButton();
            this.label8 = new System.Windows.Forms.Label();
            this.toolTipMensaje = new System.Windows.Forms.ToolTip(this.components);
            this.btnModificar = new FontAwesome.Sharp.IconButton();
            this.bimestreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cursoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materiaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnEditarCurso = new FontAwesome.Sharp.IconButton();
            this.btnEditarMat = new FontAwesome.Sharp.IconButton();
            bimestreLabel = new System.Windows.Forms.Label();
            id_bimestreLabel = new System.Windows.Forms.Label();
            id_cursoLabel = new System.Windows.Forms.Label();
            nom_cursoLabel = new System.Windows.Forms.Label();
            nro_carnetLabel = new System.Windows.Forms.Label();
            paraleloLabel = new System.Windows.Forms.Label();
            id_materiaLabel = new System.Windows.Forms.Label();
            nombre_materiaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bimestreDataGridView)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.materiaDataGridView)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bimestreBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materiaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bimestreLabel
            // 
            bimestreLabel.AutoSize = true;
            bimestreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            bimestreLabel.ForeColor = System.Drawing.Color.White;
            bimestreLabel.Location = new System.Drawing.Point(108, 149);
            bimestreLabel.Name = "bimestreLabel";
            bimestreLabel.Size = new System.Drawing.Size(105, 24);
            bimestreLabel.TabIndex = 0;
            bimestreLabel.Text = "BIMESTRE";
            // 
            // id_bimestreLabel
            // 
            id_bimestreLabel.AutoSize = true;
            id_bimestreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            id_bimestreLabel.ForeColor = System.Drawing.Color.White;
            id_bimestreLabel.Location = new System.Drawing.Point(29, 120);
            id_bimestreLabel.Name = "id_bimestreLabel";
            id_bimestreLabel.Size = new System.Drawing.Size(184, 24);
            id_bimestreLabel.TabIndex = 2;
            id_bimestreLabel.Text = "CODIGO BIMESTRE";
            // 
            // id_cursoLabel
            // 
            id_cursoLabel.AutoSize = true;
            id_cursoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            id_cursoLabel.ForeColor = System.Drawing.Color.White;
            id_cursoLabel.Location = new System.Drawing.Point(76, 97);
            id_cursoLabel.Name = "id_cursoLabel";
            id_cursoLabel.Size = new System.Drawing.Size(103, 24);
            id_cursoLabel.TabIndex = 6;
            id_cursoLabel.Text = "ID CURSO:";
            // 
            // nom_cursoLabel
            // 
            nom_cursoLabel.AutoSize = true;
            nom_cursoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            nom_cursoLabel.ForeColor = System.Drawing.Color.White;
            nom_cursoLabel.Location = new System.Drawing.Point(97, 125);
            nom_cursoLabel.Name = "nom_cursoLabel";
            nom_cursoLabel.Size = new System.Drawing.Size(81, 24);
            nom_cursoLabel.TabIndex = 8;
            nom_cursoLabel.Text = "CURSO:";
            // 
            // nro_carnetLabel
            // 
            nro_carnetLabel.AutoSize = true;
            nro_carnetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            nro_carnetLabel.ForeColor = System.Drawing.Color.White;
            nro_carnetLabel.Location = new System.Drawing.Point(41, 182);
            nro_carnetLabel.Name = "nro_carnetLabel";
            nro_carnetLabel.Size = new System.Drawing.Size(142, 24);
            nro_carnetLabel.TabIndex = 10;
            nro_carnetLabel.Text = "CI PROFESOR:";
            // 
            // paraleloLabel
            // 
            paraleloLabel.AutoSize = true;
            paraleloLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            paraleloLabel.ForeColor = System.Drawing.Color.White;
            paraleloLabel.Location = new System.Drawing.Point(64, 151);
            paraleloLabel.Name = "paraleloLabel";
            paraleloLabel.Size = new System.Drawing.Size(114, 24);
            paraleloLabel.TabIndex = 12;
            paraleloLabel.Text = "PARALELO:";
            // 
            // id_materiaLabel
            // 
            id_materiaLabel.AutoSize = true;
            id_materiaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            id_materiaLabel.ForeColor = System.Drawing.Color.White;
            id_materiaLabel.Location = new System.Drawing.Point(64, 110);
            id_materiaLabel.Name = "id_materiaLabel";
            id_materiaLabel.Size = new System.Drawing.Size(96, 24);
            id_materiaLabel.TabIndex = 20;
            id_materiaLabel.Text = "id materia:";
            // 
            // nombre_materiaLabel
            // 
            nombre_materiaLabel.AutoSize = true;
            nombre_materiaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            nombre_materiaLabel.ForeColor = System.Drawing.Color.White;
            nombre_materiaLabel.Location = new System.Drawing.Point(63, 141);
            nombre_materiaLabel.Name = "nombre_materiaLabel";
            nombre_materiaLabel.Size = new System.Drawing.Size(147, 24);
            nombre_materiaLabel.TabIndex = 22;
            nombre_materiaLabel.Text = "nombre materia:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Regatto", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(252, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(548, 47);
            this.label1.TabIndex = 1;
            this.label1.Text = "GESTION DEL AÑO ESCOLAR";
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.BackColor = System.Drawing.Color.White;
            this.iconPictureBox2.ForeColor = System.Drawing.Color.Crimson;
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.iconPictureBox2.IconColor = System.Drawing.Color.Crimson;
            this.iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox2.Location = new System.Drawing.Point(1023, 21);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(32, 32);
            this.iconPictureBox2.TabIndex = 11;
            this.iconPictureBox2.TabStop = false;
            this.iconPictureBox2.Click += new System.EventHandler(this.iconPictureBox2_Click);
            // 
            // cursoDataGridView
            // 
            this.cursoDataGridView.AutoGenerateColumns = false;
            this.cursoDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.cursoDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.cursoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cursoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.cursoDataGridView.DataSource = this.cursoBindingSource;
            this.cursoDataGridView.Location = new System.Drawing.Point(15, 32);
            this.cursoDataGridView.Name = "cursoDataGridView";
            this.cursoDataGridView.RowHeadersVisible = false;
            this.cursoDataGridView.Size = new System.Drawing.Size(387, 220);
            this.cursoDataGridView.TabIndex = 12;
            // 
            // bimestreDataGridView
            // 
            this.bimestreDataGridView.AutoGenerateColumns = false;
            this.bimestreDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bimestreDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.bimestreDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bimestreDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3});
            this.bimestreDataGridView.DataSource = this.bimestreBindingSource;
            this.bimestreDataGridView.Location = new System.Drawing.Point(29, 37);
            this.bimestreDataGridView.Name = "bimestreDataGridView";
            this.bimestreDataGridView.RowHeadersVisible = false;
            this.bimestreDataGridView.Size = new System.Drawing.Size(330, 220);
            this.bimestreDataGridView.TabIndex = 13;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(96, 178);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(813, 367);
            this.tabControl1.TabIndex = 15;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.btnNuevoBim);
            this.tabPage1.Controls.Add(this.bimestreDataGridView);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(805, 341);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "BIMESTRES";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.btnCancelarBim);
            this.panel1.Controls.Add(this.btnModificar);
            this.panel1.Controls.Add(this.btnGuardarBim);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(bimestreLabel);
            this.panel1.Controls.Add(this.bimestreTextBox);
            this.panel1.Controls.Add(id_bimestreLabel);
            this.panel1.Controls.Add(this.id_bimestreTextBox);
            this.panel1.Location = new System.Drawing.Point(407, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(396, 343);
            this.panel1.TabIndex = 14;
            // 
            // btnCancelarBim
            // 
            this.btnCancelarBim.BackColor = System.Drawing.Color.Crimson;
            this.btnCancelarBim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarBim.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarBim.ForeColor = System.Drawing.Color.White;
            this.btnCancelarBim.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.btnCancelarBim.IconColor = System.Drawing.Color.White;
            this.btnCancelarBim.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancelarBim.IconSize = 40;
            this.btnCancelarBim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelarBim.Location = new System.Drawing.Point(33, 224);
            this.btnCancelarBim.Name = "btnCancelarBim";
            this.btnCancelarBim.Size = new System.Drawing.Size(141, 54);
            this.btnCancelarBim.TabIndex = 20;
            this.btnCancelarBim.Text = "CANCELAR";
            this.btnCancelarBim.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelarBim.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelarBim.UseVisualStyleBackColor = false;
            this.btnCancelarBim.Visible = false;
            this.btnCancelarBim.Click += new System.EventHandler(this.btnCancelarBim_Click);
            // 
            // btnNuevoBim
            // 
            this.btnNuevoBim.BackColor = System.Drawing.Color.SteelBlue;
            this.btnNuevoBim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoBim.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoBim.ForeColor = System.Drawing.Color.White;
            this.btnNuevoBim.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.btnNuevoBim.IconColor = System.Drawing.Color.White;
            this.btnNuevoBim.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNuevoBim.IconSize = 40;
            this.btnNuevoBim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevoBim.Location = new System.Drawing.Point(29, 271);
            this.btnNuevoBim.Name = "btnNuevoBim";
            this.btnNuevoBim.Size = new System.Drawing.Size(141, 54);
            this.btnNuevoBim.TabIndex = 19;
            this.btnNuevoBim.Text = "NUEVO";
            this.btnNuevoBim.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevoBim.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNuevoBim.UseVisualStyleBackColor = false;
            this.btnNuevoBim.Click += new System.EventHandler(this.btnNuevoBim_Click);
            // 
            // btnGuardarBim
            // 
            this.btnGuardarBim.BackColor = System.Drawing.Color.SeaGreen;
            this.btnGuardarBim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarBim.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarBim.ForeColor = System.Drawing.Color.White;
            this.btnGuardarBim.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnGuardarBim.IconColor = System.Drawing.Color.White;
            this.btnGuardarBim.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuardarBim.IconSize = 40;
            this.btnGuardarBim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarBim.Location = new System.Drawing.Point(219, 224);
            this.btnGuardarBim.Name = "btnGuardarBim";
            this.btnGuardarBim.Size = new System.Drawing.Size(141, 54);
            this.btnGuardarBim.TabIndex = 18;
            this.btnGuardarBim.Text = "GUARDAR";
            this.btnGuardarBim.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarBim.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardarBim.UseVisualStyleBackColor = false;
            this.btnGuardarBim.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(88, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(222, 46);
            this.label2.TabIndex = 4;
            this.label2.Text = "BIMESTRE";
            // 
            // bimestreTextBox
            // 
            this.bimestreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bimestreBindingSource, "bimestre", true));
            this.bimestreTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bimestreTextBox.Location = new System.Drawing.Point(219, 150);
            this.bimestreTextBox.Name = "bimestreTextBox";
            this.bimestreTextBox.Size = new System.Drawing.Size(100, 24);
            this.bimestreTextBox.TabIndex = 1;
            // 
            // id_bimestreTextBox
            // 
            this.id_bimestreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bimestreBindingSource, "id_bimestre", true));
            this.id_bimestreTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_bimestreTextBox.Location = new System.Drawing.Point(219, 120);
            this.id_bimestreTextBox.Name = "id_bimestreTextBox";
            this.id_bimestreTextBox.Size = new System.Drawing.Size(100, 24);
            this.id_bimestreTextBox.TabIndex = 3;
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.btnNuevoCurso);
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Controls.Add(this.cursoDataGridView);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(805, 341);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "CURSOS";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Controls.Add(this.btnCancelarCurso);
            this.panel2.Controls.Add(this.btnGuardarCurso);
            this.panel2.Controls.Add(this.btnBuscarProfesor);
            this.panel2.Controls.Add(id_cursoLabel);
            this.panel2.Controls.Add(this.id_cursoTextBox);
            this.panel2.Controls.Add(nom_cursoLabel);
            this.panel2.Controls.Add(this.nom_cursoTextBox);
            this.panel2.Controls.Add(nro_carnetLabel);
            this.panel2.Controls.Add(this.nro_carnetTextBox);
            this.panel2.Controls.Add(paraleloLabel);
            this.panel2.Controls.Add(this.paraleloTextBox);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.btnEditarCurso);
            this.panel2.Location = new System.Drawing.Point(408, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(394, 338);
            this.panel2.TabIndex = 15;
            // 
            // btnCancelarCurso
            // 
            this.btnCancelarCurso.BackColor = System.Drawing.Color.Crimson;
            this.btnCancelarCurso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarCurso.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarCurso.ForeColor = System.Drawing.Color.White;
            this.btnCancelarCurso.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.btnCancelarCurso.IconColor = System.Drawing.Color.White;
            this.btnCancelarCurso.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancelarCurso.IconSize = 40;
            this.btnCancelarCurso.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelarCurso.Location = new System.Drawing.Point(42, 247);
            this.btnCancelarCurso.Name = "btnCancelarCurso";
            this.btnCancelarCurso.Size = new System.Drawing.Size(141, 54);
            this.btnCancelarCurso.TabIndex = 17;
            this.btnCancelarCurso.Text = "CANCELAR";
            this.btnCancelarCurso.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelarCurso.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelarCurso.UseVisualStyleBackColor = false;
            this.btnCancelarCurso.Visible = false;
            this.btnCancelarCurso.Click += new System.EventHandler(this.btnCancelarCurso_Click);
            // 
            // btnNuevoCurso
            // 
            this.btnNuevoCurso.BackColor = System.Drawing.Color.SteelBlue;
            this.btnNuevoCurso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoCurso.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoCurso.ForeColor = System.Drawing.Color.White;
            this.btnNuevoCurso.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.btnNuevoCurso.IconColor = System.Drawing.Color.White;
            this.btnNuevoCurso.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNuevoCurso.IconSize = 40;
            this.btnNuevoCurso.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevoCurso.Location = new System.Drawing.Point(15, 263);
            this.btnNuevoCurso.Name = "btnNuevoCurso";
            this.btnNuevoCurso.Size = new System.Drawing.Size(141, 54);
            this.btnNuevoCurso.TabIndex = 16;
            this.btnNuevoCurso.Text = "NUEVO";
            this.btnNuevoCurso.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevoCurso.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNuevoCurso.UseVisualStyleBackColor = false;
            this.btnNuevoCurso.Click += new System.EventHandler(this.btnNuevoCurso_Click);
            // 
            // btnGuardarCurso
            // 
            this.btnGuardarCurso.BackColor = System.Drawing.Color.SeaGreen;
            this.btnGuardarCurso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarCurso.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarCurso.ForeColor = System.Drawing.Color.White;
            this.btnGuardarCurso.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnGuardarCurso.IconColor = System.Drawing.Color.White;
            this.btnGuardarCurso.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuardarCurso.IconSize = 40;
            this.btnGuardarCurso.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarCurso.Location = new System.Drawing.Point(221, 247);
            this.btnGuardarCurso.Name = "btnGuardarCurso";
            this.btnGuardarCurso.Size = new System.Drawing.Size(141, 54);
            this.btnGuardarCurso.TabIndex = 15;
            this.btnGuardarCurso.Text = "GUARDAR";
            this.btnGuardarCurso.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarCurso.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardarCurso.UseVisualStyleBackColor = false;
            this.btnGuardarCurso.Visible = false;
            // 
            // btnBuscarProfesor
            // 
            this.btnBuscarProfesor.BackColor = System.Drawing.Color.Orange;
            this.btnBuscarProfesor.Enabled = false;
            this.btnBuscarProfesor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarProfesor.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarProfesor.ForeColor = System.Drawing.Color.White;
            this.btnBuscarProfesor.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnBuscarProfesor.IconColor = System.Drawing.Color.White;
            this.btnBuscarProfesor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscarProfesor.IconSize = 25;
            this.btnBuscarProfesor.Location = new System.Drawing.Point(291, 176);
            this.btnBuscarProfesor.Name = "btnBuscarProfesor";
            this.btnBuscarProfesor.Size = new System.Drawing.Size(38, 32);
            this.btnBuscarProfesor.TabIndex = 14;
            this.btnBuscarProfesor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarProfesor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTipMensaje.SetToolTip(this.btnBuscarProfesor, "Buscar Profesor");
            this.btnBuscarProfesor.UseVisualStyleBackColor = false;
            this.btnBuscarProfesor.Visible = false;
            // 
            // id_cursoTextBox
            // 
            this.id_cursoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cursoBindingSource, "id_curso", true));
            this.id_cursoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.id_cursoTextBox.Location = new System.Drawing.Point(185, 94);
            this.id_cursoTextBox.Name = "id_cursoTextBox";
            this.id_cursoTextBox.Size = new System.Drawing.Size(100, 24);
            this.id_cursoTextBox.TabIndex = 7;
            // 
            // nom_cursoTextBox
            // 
            this.nom_cursoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cursoBindingSource, "nom_curso", true));
            this.nom_cursoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.nom_cursoTextBox.Location = new System.Drawing.Point(185, 122);
            this.nom_cursoTextBox.Name = "nom_cursoTextBox";
            this.nom_cursoTextBox.Size = new System.Drawing.Size(100, 24);
            this.nom_cursoTextBox.TabIndex = 9;
            // 
            // nro_carnetTextBox
            // 
            this.nro_carnetTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cursoBindingSource, "nro_carnet", true));
            this.nro_carnetTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.nro_carnetTextBox.Location = new System.Drawing.Point(185, 179);
            this.nro_carnetTextBox.Name = "nro_carnetTextBox";
            this.nro_carnetTextBox.Size = new System.Drawing.Size(100, 24);
            this.nro_carnetTextBox.TabIndex = 11;
            // 
            // paraleloTextBox
            // 
            this.paraleloTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cursoBindingSource, "paralelo", true));
            this.paraleloTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.paraleloTextBox.Location = new System.Drawing.Point(185, 150);
            this.paraleloTextBox.Name = "paraleloTextBox";
            this.paraleloTextBox.Size = new System.Drawing.Size(100, 24);
            this.paraleloTextBox.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(138, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 46);
            this.label3.TabIndex = 4;
            this.label3.Text = "CURSO";
            // 
            // tabPage3
            // 
            this.tabPage3.AutoScroll = true;
            this.tabPage3.BackColor = System.Drawing.Color.White;
            this.tabPage3.Controls.Add(this.materiaDataGridView);
            this.tabPage3.Controls.Add(this.panel3);
            this.tabPage3.Controls.Add(this.btnNuevoMat);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(805, 341);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "MATERIAS";
            // 
            // materiaDataGridView
            // 
            this.materiaDataGridView.AutoGenerateColumns = false;
            this.materiaDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.materiaDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.materiaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.materiaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.materiaDataGridView.DataSource = this.materiaBindingSource;
            this.materiaDataGridView.Location = new System.Drawing.Point(19, 22);
            this.materiaDataGridView.Name = "materiaDataGridView";
            this.materiaDataGridView.RowHeadersVisible = false;
            this.materiaDataGridView.Size = new System.Drawing.Size(377, 220);
            this.materiaDataGridView.TabIndex = 16;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SteelBlue;
            this.panel3.Controls.Add(id_materiaLabel);
            this.panel3.Controls.Add(this.id_materiaTextBox);
            this.panel3.Controls.Add(nombre_materiaLabel);
            this.panel3.Controls.Add(this.nombre_materiaTextBox);
            this.panel3.Controls.Add(this.btnCancelarMat);
            this.panel3.Controls.Add(this.btnGuardarMat);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.btnEditarMat);
            this.panel3.Location = new System.Drawing.Point(408, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(394, 334);
            this.panel3.TabIndex = 16;
            // 
            // id_materiaTextBox
            // 
            this.id_materiaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.materiaBindingSource, "id_materia", true));
            this.id_materiaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.id_materiaTextBox.Location = new System.Drawing.Point(216, 111);
            this.id_materiaTextBox.Name = "id_materiaTextBox";
            this.id_materiaTextBox.Size = new System.Drawing.Size(100, 24);
            this.id_materiaTextBox.TabIndex = 21;
            // 
            // nombre_materiaTextBox
            // 
            this.nombre_materiaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.materiaBindingSource, "nombre_materia", true));
            this.nombre_materiaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.nombre_materiaTextBox.Location = new System.Drawing.Point(216, 141);
            this.nombre_materiaTextBox.Name = "nombre_materiaTextBox";
            this.nombre_materiaTextBox.Size = new System.Drawing.Size(100, 24);
            this.nombre_materiaTextBox.TabIndex = 23;
            // 
            // btnCancelarMat
            // 
            this.btnCancelarMat.BackColor = System.Drawing.Color.Crimson;
            this.btnCancelarMat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarMat.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarMat.ForeColor = System.Drawing.Color.White;
            this.btnCancelarMat.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.btnCancelarMat.IconColor = System.Drawing.Color.White;
            this.btnCancelarMat.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancelarMat.IconSize = 40;
            this.btnCancelarMat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelarMat.Location = new System.Drawing.Point(53, 243);
            this.btnCancelarMat.Name = "btnCancelarMat";
            this.btnCancelarMat.Size = new System.Drawing.Size(141, 54);
            this.btnCancelarMat.TabIndex = 20;
            this.btnCancelarMat.Text = "CANCELAR";
            this.btnCancelarMat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelarMat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelarMat.UseVisualStyleBackColor = false;
            this.btnCancelarMat.Visible = false;
            this.btnCancelarMat.Click += new System.EventHandler(this.btnCancelarMat_Click);
            // 
            // btnNuevoMat
            // 
            this.btnNuevoMat.BackColor = System.Drawing.Color.SteelBlue;
            this.btnNuevoMat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoMat.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoMat.ForeColor = System.Drawing.Color.White;
            this.btnNuevoMat.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.btnNuevoMat.IconColor = System.Drawing.Color.White;
            this.btnNuevoMat.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNuevoMat.IconSize = 40;
            this.btnNuevoMat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevoMat.Location = new System.Drawing.Point(19, 266);
            this.btnNuevoMat.Name = "btnNuevoMat";
            this.btnNuevoMat.Size = new System.Drawing.Size(141, 54);
            this.btnNuevoMat.TabIndex = 19;
            this.btnNuevoMat.Text = "NUEVO";
            this.btnNuevoMat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevoMat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNuevoMat.UseVisualStyleBackColor = false;
            this.btnNuevoMat.Click += new System.EventHandler(this.btnNuevoMat_Click);
            // 
            // btnGuardarMat
            // 
            this.btnGuardarMat.BackColor = System.Drawing.Color.SeaGreen;
            this.btnGuardarMat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarMat.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarMat.ForeColor = System.Drawing.Color.White;
            this.btnGuardarMat.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnGuardarMat.IconColor = System.Drawing.Color.White;
            this.btnGuardarMat.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuardarMat.IconSize = 40;
            this.btnGuardarMat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarMat.Location = new System.Drawing.Point(218, 243);
            this.btnGuardarMat.Name = "btnGuardarMat";
            this.btnGuardarMat.Size = new System.Drawing.Size(141, 54);
            this.btnGuardarMat.TabIndex = 18;
            this.btnGuardarMat.Text = "GUARDAR";
            this.btnGuardarMat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarMat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardarMat.UseVisualStyleBackColor = false;
            this.btnGuardarMat.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Rockwell", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(93, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(223, 46);
            this.label8.TabIndex = 4;
            this.label8.Text = "MATERIAS";
            // 
            // toolTipMensaje
            // 
            this.toolTipMensaje.AutoPopDelay = 5000;
            this.toolTipMensaje.InitialDelay = 10;
            this.toolTipMensaje.ReshowDelay = 100;
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.DarkOrchid;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.White;
            this.btnModificar.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnModificar.IconColor = System.Drawing.Color.White;
            this.btnModificar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnModificar.IconSize = 40;
            this.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificar.Location = new System.Drawing.Point(33, 224);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(141, 54);
            this.btnModificar.TabIndex = 21;
            this.btnModificar.Text = "EDITAR";
            this.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // bimestreBindingSource
            // 
            this.bimestreBindingSource.DataSource = typeof(SGCalificaciones.Data.Bimestre);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_bimestre";
            this.dataGridViewTextBoxColumn1.FillWeight = 50.76142F;
            this.dataGridViewTextBoxColumn1.HeaderText = "id_bimestre";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "bimestre";
            this.dataGridViewTextBoxColumn3.FillWeight = 149.2386F;
            this.dataGridViewTextBoxColumn3.HeaderText = "bimestre";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // cursoBindingSource
            // 
            this.cursoBindingSource.DataSource = typeof(SGCalificaciones.Data.Curso);
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "id_curso";
            this.dataGridViewTextBoxColumn4.HeaderText = "id_curso";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "nom_curso";
            this.dataGridViewTextBoxColumn5.HeaderText = "nom_curso";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "paralelo";
            this.dataGridViewTextBoxColumn6.HeaderText = "paralelo";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "nro_carnet";
            this.dataGridViewTextBoxColumn7.HeaderText = "nro_carnet";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "id_materia";
            this.dataGridViewTextBoxColumn2.FillWeight = 50.76142F;
            this.dataGridViewTextBoxColumn2.HeaderText = "id_materia";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "nombre_materia";
            this.dataGridViewTextBoxColumn8.FillWeight = 149.2386F;
            this.dataGridViewTextBoxColumn8.HeaderText = "nombre_materia";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Materia_Curso";
            this.dataGridViewTextBoxColumn9.HeaderText = "Materia_Curso";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Visible = false;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Calificaciones";
            this.dataGridViewTextBoxColumn10.HeaderText = "Calificaciones";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Visible = false;
            // 
            // materiaBindingSource
            // 
            this.materiaBindingSource.DataSource = typeof(SGCalificaciones.Data.Materia);
            // 
            // btnEditarCurso
            // 
            this.btnEditarCurso.BackColor = System.Drawing.Color.DarkOrchid;
            this.btnEditarCurso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarCurso.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarCurso.ForeColor = System.Drawing.Color.White;
            this.btnEditarCurso.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnEditarCurso.IconColor = System.Drawing.Color.White;
            this.btnEditarCurso.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditarCurso.IconSize = 40;
            this.btnEditarCurso.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditarCurso.Location = new System.Drawing.Point(42, 247);
            this.btnEditarCurso.Name = "btnEditarCurso";
            this.btnEditarCurso.Size = new System.Drawing.Size(141, 54);
            this.btnEditarCurso.TabIndex = 22;
            this.btnEditarCurso.Text = "EDITAR";
            this.btnEditarCurso.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditarCurso.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditarCurso.UseVisualStyleBackColor = false;
            this.btnEditarCurso.Click += new System.EventHandler(this.btnEditarCurso_Click);
            // 
            // btnEditarMat
            // 
            this.btnEditarMat.BackColor = System.Drawing.Color.DarkOrchid;
            this.btnEditarMat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarMat.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarMat.ForeColor = System.Drawing.Color.White;
            this.btnEditarMat.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnEditarMat.IconColor = System.Drawing.Color.White;
            this.btnEditarMat.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditarMat.IconSize = 40;
            this.btnEditarMat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditarMat.Location = new System.Drawing.Point(53, 243);
            this.btnEditarMat.Name = "btnEditarMat";
            this.btnEditarMat.Size = new System.Drawing.Size(141, 54);
            this.btnEditarMat.TabIndex = 24;
            this.btnEditarMat.Text = "EDITAR";
            this.btnEditarMat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditarMat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditarMat.UseVisualStyleBackColor = false;
            this.btnEditarMat.Click += new System.EventHandler(this.iconButton3_Click);
            // 
            // frmGestionarAnioEscolar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1078, 669);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.iconPictureBox2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGestionarAnioEscolar";
            this.Text = "frmGestionarAnioEscolar";
            this.Load += new System.EventHandler(this.frmGestionarAnioEscolar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bimestreDataGridView)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.materiaDataGridView)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bimestreBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materiaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private System.Windows.Forms.BindingSource bimestreBindingSource;
        //private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.BindingSource cursoBindingSource;
        private System.Windows.Forms.DataGridView cursoDataGridView;
        //private System.Windows.Forms.DataGridViewTextBoxColumn bimestre1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView bimestreDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox bimestreTextBox;
        private System.Windows.Forms.TextBox id_bimestreTextBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox id_cursoTextBox;
        private System.Windows.Forms.TextBox nom_cursoTextBox;
        private System.Windows.Forms.TextBox nro_carnetTextBox;
        private System.Windows.Forms.TextBox paraleloTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private FontAwesome.Sharp.IconButton btnGuardarCurso;
        private FontAwesome.Sharp.IconButton btnBuscarProfesor;
        private System.Windows.Forms.ToolTip toolTipMensaje;
        private System.Windows.Forms.DataGridView materiaDataGridView;
        private System.Windows.Forms.BindingSource materiaBindingSource;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label8;
        private FontAwesome.Sharp.IconButton btnCancelarCurso;
        private FontAwesome.Sharp.IconButton btnNuevoCurso;
        private FontAwesome.Sharp.IconButton btnCancelarBim;
        private FontAwesome.Sharp.IconButton btnNuevoBim;
        private FontAwesome.Sharp.IconButton btnGuardarBim;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.TextBox id_materiaTextBox;
        private System.Windows.Forms.TextBox nombre_materiaTextBox;
        private FontAwesome.Sharp.IconButton btnCancelarMat;
        private FontAwesome.Sharp.IconButton btnNuevoMat;
        private FontAwesome.Sharp.IconButton btnGuardarMat;
        private FontAwesome.Sharp.IconButton btnModificar;
        private FontAwesome.Sharp.IconButton btnEditarCurso;
        private FontAwesome.Sharp.IconButton btnEditarMat;
    }
}