
namespace SGCalificaciones.Vista.Gestiones
{
    partial class frmGestionarCalificaciones
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
            this.label1 = new System.Windows.Forms.Label();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.cmbBimestre = new System.Windows.Forms.ComboBox();
            this.bimestreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmbEstudiante = new System.Windows.Forms.ComboBox();
            this.txtLenguaje = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSociales = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEFisica = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEMusical = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtArtesPlasticas = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMatematica = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTecnica = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNaturales = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtReligion = new System.Windows.Forms.TextBox();
            this.btnAceptar = new FontAwesome.Sharp.IconButton();
            this.btnFinalizar = new FontAwesome.Sharp.IconButton();
            this.lblCarnet = new System.Windows.Forms.Label();
            this.lblIdBimestre = new System.Windows.Forms.Label();
            this.estudianteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.materiaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.criterioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.calificacionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bimestreBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estudianteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materiaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.criterioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calificacionesBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Regatto", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(321, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 47);
            this.label1.TabIndex = 18;
            this.label1.Text = "CALIFICACIONES";
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.BackColor = System.Drawing.Color.White;
            this.iconPictureBox2.ForeColor = System.Drawing.Color.Crimson;
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.iconPictureBox2.IconColor = System.Drawing.Color.Crimson;
            this.iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox2.Location = new System.Drawing.Point(1025, 19);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(32, 32);
            this.iconPictureBox2.TabIndex = 19;
            this.iconPictureBox2.TabStop = false;
            // 
            // cmbBimestre
            // 
            this.cmbBimestre.BackColor = System.Drawing.Color.SteelBlue;
            this.cmbBimestre.DataSource = this.bimestreBindingSource;
            this.cmbBimestre.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBimestre.ForeColor = System.Drawing.Color.White;
            this.cmbBimestre.FormattingEnabled = true;
            this.cmbBimestre.Location = new System.Drawing.Point(19, 53);
            this.cmbBimestre.Name = "cmbBimestre";
            this.cmbBimestre.Size = new System.Drawing.Size(148, 30);
            this.cmbBimestre.TabIndex = 23;
            this.cmbBimestre.SelectedIndexChanged += new System.EventHandler(this.cmbBimestre_SelectedIndexChanged);
            // 
            // bimestreBindingSource
            // 
            this.bimestreBindingSource.DataSource = typeof(SGCalificaciones.Data.Bimestre);
            // 
            // cmbEstudiante
            // 
            this.cmbEstudiante.BackColor = System.Drawing.Color.SteelBlue;
            this.cmbEstudiante.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEstudiante.ForeColor = System.Drawing.Color.White;
            this.cmbEstudiante.FormattingEnabled = true;
            this.cmbEstudiante.Location = new System.Drawing.Point(230, 53);
            this.cmbEstudiante.Name = "cmbEstudiante";
            this.cmbEstudiante.Size = new System.Drawing.Size(378, 30);
            this.cmbEstudiante.TabIndex = 24;
            // 
            // txtLenguaje
            // 
            this.txtLenguaje.Enabled = false;
            this.txtLenguaje.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLenguaje.Location = new System.Drawing.Point(445, 241);
            this.txtLenguaje.MaxLength = 3;
            this.txtLenguaje.Name = "txtLenguaje";
            this.txtLenguaje.Size = new System.Drawing.Size(100, 26);
            this.txtLenguaje.TabIndex = 26;
            this.txtLenguaje.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtReligion_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Prime Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(74, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(275, 25);
            this.label2.TabIndex = 27;
            this.label2.Text = "COMUNICACION Y LENGUAJES";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Prime Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(74, 274);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 25);
            this.label3.TabIndex = 29;
            this.label3.Text = "CIENCIAS SOCIALES";
            // 
            // txtSociales
            // 
            this.txtSociales.Enabled = false;
            this.txtSociales.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSociales.Location = new System.Drawing.Point(445, 273);
            this.txtSociales.MaxLength = 3;
            this.txtSociales.Name = "txtSociales";
            this.txtSociales.Size = new System.Drawing.Size(100, 26);
            this.txtSociales.TabIndex = 28;
            this.txtSociales.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtReligion_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Prime Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(74, 306);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(284, 25);
            this.label4.TabIndex = 31;
            this.label4.Text = "EDUCACION FISICA Y DEPORTES";
            // 
            // txtEFisica
            // 
            this.txtEFisica.Enabled = false;
            this.txtEFisica.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEFisica.Location = new System.Drawing.Point(445, 305);
            this.txtEFisica.MaxLength = 3;
            this.txtEFisica.Name = "txtEFisica";
            this.txtEFisica.Size = new System.Drawing.Size(100, 26);
            this.txtEFisica.TabIndex = 30;
            this.txtEFisica.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtReligion_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Prime Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(74, 338);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(199, 25);
            this.label5.TabIndex = 33;
            this.label5.Text = "EDUCACION MUSICAL";
            // 
            // txtEMusical
            // 
            this.txtEMusical.Enabled = false;
            this.txtEMusical.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEMusical.Location = new System.Drawing.Point(445, 337);
            this.txtEMusical.MaxLength = 3;
            this.txtEMusical.Name = "txtEMusical";
            this.txtEMusical.Size = new System.Drawing.Size(100, 26);
            this.txtEMusical.TabIndex = 32;
            this.txtEMusical.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtReligion_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Prime Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(74, 370);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(262, 25);
            this.label6.TabIndex = 35;
            this.label6.Text = "ARTES PLASTICAS Y VISUALES";
            // 
            // txtArtesPlasticas
            // 
            this.txtArtesPlasticas.Enabled = false;
            this.txtArtesPlasticas.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArtesPlasticas.Location = new System.Drawing.Point(445, 369);
            this.txtArtesPlasticas.MaxLength = 3;
            this.txtArtesPlasticas.Name = "txtArtesPlasticas";
            this.txtArtesPlasticas.Size = new System.Drawing.Size(100, 26);
            this.txtArtesPlasticas.TabIndex = 34;
            this.txtArtesPlasticas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtReligion_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Prime Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(74, 402);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 25);
            this.label7.TabIndex = 37;
            this.label7.Text = "MATEMATICA";
            // 
            // txtMatematica
            // 
            this.txtMatematica.Enabled = false;
            this.txtMatematica.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatematica.Location = new System.Drawing.Point(445, 401);
            this.txtMatematica.MaxLength = 3;
            this.txtMatematica.Name = "txtMatematica";
            this.txtMatematica.Size = new System.Drawing.Size(100, 26);
            this.txtMatematica.TabIndex = 36;
            this.txtMatematica.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtReligion_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Prime Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(74, 434);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(215, 25);
            this.label8.TabIndex = 39;
            this.label8.Text = "TECNICA TECNOLOGICA";
            // 
            // txtTecnica
            // 
            this.txtTecnica.Enabled = false;
            this.txtTecnica.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTecnica.Location = new System.Drawing.Point(445, 433);
            this.txtTecnica.MaxLength = 3;
            this.txtTecnica.Name = "txtTecnica";
            this.txtTecnica.Size = new System.Drawing.Size(100, 26);
            this.txtTecnica.TabIndex = 38;
            this.txtTecnica.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtReligion_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Prime Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(74, 466);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(198, 25);
            this.label9.TabIndex = 41;
            this.label9.Text = "CIENCIAS NATURALES";
            // 
            // txtNaturales
            // 
            this.txtNaturales.Enabled = false;
            this.txtNaturales.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNaturales.Location = new System.Drawing.Point(445, 465);
            this.txtNaturales.MaxLength = 3;
            this.txtNaturales.Name = "txtNaturales";
            this.txtNaturales.Size = new System.Drawing.Size(100, 26);
            this.txtNaturales.TabIndex = 40;
            this.txtNaturales.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtReligion_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Prime Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(74, 498);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(364, 25);
            this.label10.TabIndex = 43;
            this.label10.Text = "VALORES, ESPIRITUALIDAD Y RELIGIONES";
            // 
            // txtReligion
            // 
            this.txtReligion.Enabled = false;
            this.txtReligion.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReligion.Location = new System.Drawing.Point(445, 497);
            this.txtReligion.MaxLength = 3;
            this.txtReligion.Name = "txtReligion";
            this.txtReligion.Size = new System.Drawing.Size(100, 26);
            this.txtReligion.TabIndex = 42;
            this.txtReligion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtReligion_KeyPress);
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.Color.White;
            this.btnAceptar.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            this.btnAceptar.IconColor = System.Drawing.Color.White;
            this.btnAceptar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAceptar.IconSize = 40;
            this.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAceptar.Location = new System.Drawing.Point(725, 46);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(139, 45);
            this.btnAceptar.TabIndex = 44;
            this.btnAceptar.Text = "ACEPTAR";
            this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.BackColor = System.Drawing.Color.SeaGreen;
            this.btnFinalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinalizar.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizar.ForeColor = System.Drawing.Color.White;
            this.btnFinalizar.IconChar = FontAwesome.Sharp.IconChar.CheckSquare;
            this.btnFinalizar.IconColor = System.Drawing.Color.White;
            this.btnFinalizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFinalizar.IconSize = 40;
            this.btnFinalizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFinalizar.Location = new System.Drawing.Point(619, 578);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(278, 45);
            this.btnFinalizar.TabIndex = 45;
            this.btnFinalizar.Text = "GUARDAR CAMBIOS";
            this.btnFinalizar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFinalizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFinalizar.UseVisualStyleBackColor = false;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // lblCarnet
            // 
            this.lblCarnet.AutoSize = true;
            this.lblCarnet.Location = new System.Drawing.Point(873, 19);
            this.lblCarnet.Name = "lblCarnet";
            this.lblCarnet.Size = new System.Drawing.Size(41, 13);
            this.lblCarnet.TabIndex = 47;
            this.lblCarnet.Text = "label11";
            // 
            // lblIdBimestre
            // 
            this.lblIdBimestre.AutoSize = true;
            this.lblIdBimestre.Location = new System.Drawing.Point(873, 52);
            this.lblIdBimestre.Name = "lblIdBimestre";
            this.lblIdBimestre.Size = new System.Drawing.Size(41, 13);
            this.lblIdBimestre.TabIndex = 48;
            this.lblIdBimestre.Text = "label11";
            // 
            // estudianteBindingSource
            // 
            this.estudianteBindingSource.DataSource = typeof(SGCalificaciones.Data.Estudiante);
            // 
            // materiaBindingSource
            // 
            this.materiaBindingSource.DataSource = typeof(SGCalificaciones.Data.Materia);
            // 
            // criterioBindingSource
            // 
            this.criterioBindingSource.DataSource = typeof(SGCalificaciones.Data.Criterio);
            // 
            // calificacionesBindingSource
            // 
            this.calificacionesBindingSource.DataSource = typeof(SGCalificaciones.Data.Calificaciones);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(15, 26);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(99, 24);
            this.label11.TabIndex = 49;
            this.label11.Text = "BIMESTRE:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(226, 26);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(115, 24);
            this.label12.TabIndex = 50;
            this.label12.Text = "ESTUDIANTE:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.MintCream;
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.cmbBimestre);
            this.groupBox1.Controls.Add(this.cmbEstudiante);
            this.groupBox1.Controls.Add(this.btnAceptar);
            this.groupBox1.Location = new System.Drawing.Point(36, 102);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(878, 100);
            this.groupBox1.TabIndex = 51;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SELECIONE";
            // 
            // frmGestionarCalificaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1078, 669);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblIdBimestre);
            this.Controls.Add(this.lblCarnet);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtReligion);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtNaturales);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtTecnica);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtMatematica);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtArtesPlasticas);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtEMusical);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEFisica);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSociales);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtLenguaje);
            this.Controls.Add(this.iconPictureBox2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGestionarCalificaciones";
            this.Text = "frmGestionarCalificaciones";
            this.TransparencyKey = System.Drawing.Color.White;
            this.Load += new System.EventHandler(this.frmGestionarCalificaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bimestreBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estudianteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materiaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.criterioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calificacionesBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private System.Windows.Forms.ComboBox cmbBimestre;
        private System.Windows.Forms.BindingSource bimestreBindingSource;
        private System.Windows.Forms.ComboBox cmbEstudiante;
        private System.Windows.Forms.BindingSource materiaBindingSource;
        private System.Windows.Forms.BindingSource criterioBindingSource;
        private System.Windows.Forms.BindingSource estudianteBindingSource;
        private System.Windows.Forms.TextBox txtLenguaje;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSociales;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEFisica;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEMusical;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtArtesPlasticas;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMatematica;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTecnica;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNaturales;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtReligion;
        private FontAwesome.Sharp.IconButton btnAceptar;
        private FontAwesome.Sharp.IconButton btnFinalizar;
        private System.Windows.Forms.Label lblCarnet;
        private System.Windows.Forms.BindingSource calificacionesBindingSource;
        private System.Windows.Forms.Label lblIdBimestre;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}