
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.bimestreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.materiaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.criterioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.estudianteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nrocarnetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idcursoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appaternoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apmaternoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.celularDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calificacionesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cursoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bimestreBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materiaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.criterioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estudianteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Regatto", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(306, 70);
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
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.SteelBlue;
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bimestreBindingSource, "bimestre", true));
            this.comboBox1.DataSource = this.bimestreBindingSource;
            this.comboBox1.DisplayMember = "bimestre";
            this.comboBox1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ForeColor = System.Drawing.Color.White;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(52, 157);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(148, 30);
            this.comboBox1.TabIndex = 23;
            this.comboBox1.ValueMember = "id_bimestre";
            // 
            // bimestreBindingSource
            // 
            this.bimestreBindingSource.DataSource = typeof(SGCalificaciones.Data.Bimestre);
            // 
            // comboBox2
            // 
            this.comboBox2.BackColor = System.Drawing.Color.SteelBlue;
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.materiaBindingSource, "nombre_materia", true));
            this.comboBox2.DataSource = this.materiaBindingSource;
            this.comboBox2.DisplayMember = "nombre_materia";
            this.comboBox2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.ForeColor = System.Drawing.Color.White;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(269, 157);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(282, 30);
            this.comboBox2.TabIndex = 24;
            this.comboBox2.ValueMember = "id_materia";
            // 
            // materiaBindingSource
            // 
            this.materiaBindingSource.DataSource = typeof(SGCalificaciones.Data.Materia);
            // 
            // comboBox3
            // 
            this.comboBox3.BackColor = System.Drawing.Color.SteelBlue;
            this.comboBox3.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.criterioBindingSource, "id_criterio", true));
            this.comboBox3.DataSource = this.criterioBindingSource;
            this.comboBox3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox3.ForeColor = System.Drawing.Color.White;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(630, 157);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(282, 30);
            this.comboBox3.TabIndex = 25;
            // 
            // criterioBindingSource
            // 
            this.criterioBindingSource.DataSource = typeof(SGCalificaciones.Data.Criterio);
            // 
            // estudianteBindingSource
            // 
            this.estudianteBindingSource.DataSource = typeof(SGCalificaciones.Data.Estudiante);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nrocarnetDataGridViewTextBoxColumn,
            this.idcursoDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.appaternoDataGridViewTextBoxColumn,
            this.apmaternoDataGridViewTextBoxColumn,
            this.celularDataGridViewTextBoxColumn,
            this.direccionDataGridViewTextBoxColumn,
            this.calificacionesDataGridViewTextBoxColumn,
            this.cursoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.estudianteBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(78, 229);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(815, 191);
            this.dataGridView1.TabIndex = 26;
            // 
            // nrocarnetDataGridViewTextBoxColumn
            // 
            this.nrocarnetDataGridViewTextBoxColumn.DataPropertyName = "nro_carnet";
            this.nrocarnetDataGridViewTextBoxColumn.HeaderText = "NOMBRE COMPLETO";
            this.nrocarnetDataGridViewTextBoxColumn.Name = "nrocarnetDataGridViewTextBoxColumn";
            // 
            // idcursoDataGridViewTextBoxColumn
            // 
            this.idcursoDataGridViewTextBoxColumn.DataPropertyName = "id_curso";
            this.idcursoDataGridViewTextBoxColumn.HeaderText = "id_curso";
            this.idcursoDataGridViewTextBoxColumn.Name = "idcursoDataGridViewTextBoxColumn";
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // appaternoDataGridViewTextBoxColumn
            // 
            this.appaternoDataGridViewTextBoxColumn.DataPropertyName = "ap_paterno";
            this.appaternoDataGridViewTextBoxColumn.HeaderText = "ap_paterno";
            this.appaternoDataGridViewTextBoxColumn.Name = "appaternoDataGridViewTextBoxColumn";
            // 
            // apmaternoDataGridViewTextBoxColumn
            // 
            this.apmaternoDataGridViewTextBoxColumn.DataPropertyName = "ap_materno";
            this.apmaternoDataGridViewTextBoxColumn.HeaderText = "ap_materno";
            this.apmaternoDataGridViewTextBoxColumn.Name = "apmaternoDataGridViewTextBoxColumn";
            // 
            // celularDataGridViewTextBoxColumn
            // 
            this.celularDataGridViewTextBoxColumn.DataPropertyName = "celular";
            this.celularDataGridViewTextBoxColumn.HeaderText = "celular";
            this.celularDataGridViewTextBoxColumn.Name = "celularDataGridViewTextBoxColumn";
            // 
            // direccionDataGridViewTextBoxColumn
            // 
            this.direccionDataGridViewTextBoxColumn.DataPropertyName = "direccion";
            this.direccionDataGridViewTextBoxColumn.HeaderText = "direccion";
            this.direccionDataGridViewTextBoxColumn.Name = "direccionDataGridViewTextBoxColumn";
            // 
            // calificacionesDataGridViewTextBoxColumn
            // 
            this.calificacionesDataGridViewTextBoxColumn.DataPropertyName = "Calificaciones";
            this.calificacionesDataGridViewTextBoxColumn.HeaderText = "Calificaciones";
            this.calificacionesDataGridViewTextBoxColumn.Name = "calificacionesDataGridViewTextBoxColumn";
            // 
            // cursoDataGridViewTextBoxColumn
            // 
            this.cursoDataGridViewTextBoxColumn.DataPropertyName = "Curso";
            this.cursoDataGridViewTextBoxColumn.HeaderText = "Curso";
            this.cursoDataGridViewTextBoxColumn.Name = "cursoDataGridViewTextBoxColumn";
            // 
            // frmGestionarCalificaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1078, 669);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.iconPictureBox2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGestionarCalificaciones";
            this.Text = "frmGestionarCalificaciones";
            this.TransparencyKey = System.Drawing.Color.White;
            this.Load += new System.EventHandler(this.frmGestionarCalificaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bimestreBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materiaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.criterioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estudianteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource bimestreBindingSource;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.BindingSource materiaBindingSource;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.BindingSource criterioBindingSource;
        private System.Windows.Forms.BindingSource estudianteBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrocarnetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcursoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn appaternoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apmaternoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn celularDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn calificacionesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cursoDataGridViewTextBoxColumn;
    }
}