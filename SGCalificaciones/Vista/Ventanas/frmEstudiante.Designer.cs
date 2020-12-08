
namespace SGCalificaciones.Vista.Ventanas
{
    partial class frmEstudiante
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
            System.Windows.Forms.Label ap_maternoLabel;
            System.Windows.Forms.Label ap_paternoLabel;
            System.Windows.Forms.Label celularLabel;
            System.Windows.Forms.Label direccionLabel;
            System.Windows.Forms.Label id_cursoLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label nro_carnetLabel;
            this.btnCancelar = new FontAwesome.Sharp.IconButton();
            this.btnAceptar = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.ap_maternoTextBox = new System.Windows.Forms.TextBox();
            this.ap_paternoTextBox = new System.Windows.Forms.TextBox();
            this.celularTextBox = new System.Windows.Forms.TextBox();
            this.direccionTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.nro_carnetTextBox = new System.Windows.Forms.TextBox();
            this.lblIdCurso = new System.Windows.Forms.Label();
            this.estudianteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cursoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bdCalificacionesEntitiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmbCursos = new System.Windows.Forms.ComboBox();
            ap_maternoLabel = new System.Windows.Forms.Label();
            ap_paternoLabel = new System.Windows.Forms.Label();
            celularLabel = new System.Windows.Forms.Label();
            direccionLabel = new System.Windows.Forms.Label();
            id_cursoLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            nro_carnetLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.estudianteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdCalificacionesEntitiesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ap_maternoLabel
            // 
            ap_maternoLabel.AutoSize = true;
            ap_maternoLabel.Location = new System.Drawing.Point(61, 130);
            ap_maternoLabel.Name = "ap_maternoLabel";
            ap_maternoLabel.Size = new System.Drawing.Size(119, 13);
            ap_maternoLabel.TabIndex = 40;
            ap_maternoLabel.Text = "APELLIDO MATERNO:";
            // 
            // ap_paternoLabel
            // 
            ap_paternoLabel.AutoSize = true;
            ap_paternoLabel.Location = new System.Drawing.Point(61, 156);
            ap_paternoLabel.Name = "ap_paternoLabel";
            ap_paternoLabel.Size = new System.Drawing.Size(117, 13);
            ap_paternoLabel.TabIndex = 42;
            ap_paternoLabel.Text = "APELLIDO PATERNO:";
            // 
            // celularLabel
            // 
            celularLabel.AutoSize = true;
            celularLabel.Location = new System.Drawing.Point(61, 182);
            celularLabel.Name = "celularLabel";
            celularLabel.Size = new System.Drawing.Size(59, 13);
            celularLabel.TabIndex = 44;
            celularLabel.Text = "CELULAR:";
            // 
            // direccionLabel
            // 
            direccionLabel.AutoSize = true;
            direccionLabel.Location = new System.Drawing.Point(61, 208);
            direccionLabel.Name = "direccionLabel";
            direccionLabel.Size = new System.Drawing.Size(69, 13);
            direccionLabel.TabIndex = 46;
            direccionLabel.Text = "DIRECCION:";
            // 
            // id_cursoLabel
            // 
            id_cursoLabel.AutoSize = true;
            id_cursoLabel.Location = new System.Drawing.Point(61, 237);
            id_cursoLabel.Name = "id_cursoLabel";
            id_cursoLabel.Size = new System.Drawing.Size(48, 13);
            id_cursoLabel.TabIndex = 48;
            id_cursoLabel.Text = "CURSO:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(61, 104);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(57, 13);
            nombreLabel.TabIndex = 50;
            nombreLabel.Text = "NOMBRE:";
            // 
            // nro_carnetLabel
            // 
            nro_carnetLabel.AutoSize = true;
            nro_carnetLabel.Location = new System.Drawing.Point(61, 78);
            nro_carnetLabel.Name = "nro_carnetLabel";
            nro_carnetLabel.Size = new System.Drawing.Size(123, 13);
            nro_carnetLabel.TabIndex = 52;
            nro_carnetLabel.Text = "NUMERO DE CARNET:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Crimson;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.btnCancelar.IconColor = System.Drawing.Color.White;
            this.btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancelar.IconSize = 40;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(255, 310);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(139, 45);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
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
            this.btnAceptar.Location = new System.Drawing.Point(41, 310);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(139, 45);
            this.btnAceptar.TabIndex = 7;
            this.btnAceptar.Text = "ACEPTAR";
            this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(179, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 22);
            this.label1.TabIndex = 21;
            this.label1.Text = "label1";
            // 
            // ap_maternoTextBox
            // 
            this.ap_maternoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.estudianteBindingSource, "ap_materno", true));
            this.ap_maternoTextBox.Location = new System.Drawing.Point(188, 127);
            this.ap_maternoTextBox.Name = "ap_maternoTextBox";
            this.ap_maternoTextBox.Size = new System.Drawing.Size(163, 20);
            this.ap_maternoTextBox.TabIndex = 2;
            // 
            // ap_paternoTextBox
            // 
            this.ap_paternoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.estudianteBindingSource, "ap_paterno", true));
            this.ap_paternoTextBox.Location = new System.Drawing.Point(188, 153);
            this.ap_paternoTextBox.Name = "ap_paternoTextBox";
            this.ap_paternoTextBox.Size = new System.Drawing.Size(163, 20);
            this.ap_paternoTextBox.TabIndex = 3;
            // 
            // celularTextBox
            // 
            this.celularTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.estudianteBindingSource, "celular", true));
            this.celularTextBox.Location = new System.Drawing.Point(188, 179);
            this.celularTextBox.MaxLength = 8;
            this.celularTextBox.Name = "celularTextBox";
            this.celularTextBox.Size = new System.Drawing.Size(163, 20);
            this.celularTextBox.TabIndex = 4;
            this.celularTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nro_carnetTextBox_KeyPress);
            // 
            // direccionTextBox
            // 
            this.direccionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.estudianteBindingSource, "direccion", true));
            this.direccionTextBox.Location = new System.Drawing.Point(188, 205);
            this.direccionTextBox.Multiline = true;
            this.direccionTextBox.Name = "direccionTextBox";
            this.direccionTextBox.Size = new System.Drawing.Size(163, 20);
            this.direccionTextBox.TabIndex = 5;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.estudianteBindingSource, "nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(188, 101);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(163, 20);
            this.nombreTextBox.TabIndex = 1;
            // 
            // nro_carnetTextBox
            // 
            this.nro_carnetTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.estudianteBindingSource, "nro_carnet", true));
            this.nro_carnetTextBox.Location = new System.Drawing.Point(188, 75);
            this.nro_carnetTextBox.MaxLength = 10;
            this.nro_carnetTextBox.Name = "nro_carnetTextBox";
            this.nro_carnetTextBox.Size = new System.Drawing.Size(163, 20);
            this.nro_carnetTextBox.TabIndex = 0;
            this.nro_carnetTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nro_carnetTextBox_KeyPress);
            // 
            // lblIdCurso
            // 
            this.lblIdCurso.AutoSize = true;
            this.lblIdCurso.Location = new System.Drawing.Point(228, 276);
            this.lblIdCurso.Name = "lblIdCurso";
            this.lblIdCurso.Size = new System.Drawing.Size(35, 13);
            this.lblIdCurso.TabIndex = 53;
            this.lblIdCurso.Text = "label2";
            // 
            // estudianteBindingSource
            // 
            this.estudianteBindingSource.DataSource = typeof(SGCalificaciones.Data.Estudiante);
            // 
            // cursoBindingSource
            // 
            this.cursoBindingSource.DataSource = typeof(SGCalificaciones.Data.Curso);
            // 
            // bdCalificacionesEntitiesBindingSource
            // 
            this.bdCalificacionesEntitiesBindingSource.DataSource = typeof(SGCalificaciones.Data.BdCalificacionesEntities);
            // 
            // cmbCursos
            // 
            this.cmbCursos.FormattingEnabled = true;
            this.cmbCursos.Location = new System.Drawing.Point(188, 234);
            this.cmbCursos.Name = "cmbCursos";
            this.cmbCursos.Size = new System.Drawing.Size(163, 21);
            this.cmbCursos.TabIndex = 54;
            // 
            // frmEstudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(431, 375);
            this.Controls.Add(this.cmbCursos);
            this.Controls.Add(this.lblIdCurso);
            this.Controls.Add(ap_maternoLabel);
            this.Controls.Add(this.ap_maternoTextBox);
            this.Controls.Add(ap_paternoLabel);
            this.Controls.Add(this.ap_paternoTextBox);
            this.Controls.Add(celularLabel);
            this.Controls.Add(this.celularTextBox);
            this.Controls.Add(direccionLabel);
            this.Controls.Add(this.direccionTextBox);
            this.Controls.Add(id_cursoLabel);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(nro_carnetLabel);
            this.Controls.Add(this.nro_carnetTextBox);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEstudiante";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmEstudiante_Load);
            ((System.ComponentModel.ISupportInitialize)(this.estudianteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdCalificacionesEntitiesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnCancelar;
        private FontAwesome.Sharp.IconButton btnAceptar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource estudianteBindingSource;
        private System.Windows.Forms.TextBox ap_maternoTextBox;
        private System.Windows.Forms.TextBox ap_paternoTextBox;
        private System.Windows.Forms.TextBox celularTextBox;
        private System.Windows.Forms.TextBox direccionTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox nro_carnetTextBox;
        private System.Windows.Forms.BindingSource cursoBindingSource;
        private System.Windows.Forms.BindingSource bdCalificacionesEntitiesBindingSource;
        private System.Windows.Forms.Label lblIdCurso;
        private System.Windows.Forms.ComboBox cmbCursos;
    }
}