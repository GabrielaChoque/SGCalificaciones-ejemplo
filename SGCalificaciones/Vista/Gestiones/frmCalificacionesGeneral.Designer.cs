
namespace SGCalificaciones.Vista.Gestiones
{
    partial class frmCalificacionesGeneral
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvCalificaciones = new System.Windows.Forms.DataGridView();
            this.estudianteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnImprimir = new FontAwesome.Sharp.IconButton();
            this.nombreLabel1 = new System.Windows.Forms.Label();
            this.nro_carnetLabel1 = new System.Windows.Forms.Label();
            this.ap_paternoLabel1 = new System.Windows.Forms.Label();
            this.ap_maternoLabel1 = new System.Windows.Forms.Label();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.nrocarnetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idcursoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appaternoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apmaternoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.celularDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cursoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calificacionesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NotaFinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Calif = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCalificaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estudianteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.iconPictureBox2.TabIndex = 18;
            this.iconPictureBox2.TabStop = false;
            this.iconPictureBox2.Click += new System.EventHandler(this.iconPictureBox2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Regatto", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(316, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(357, 47);
            this.label1.TabIndex = 17;
            this.label1.Text = "MIS ESTUDIANTES";
            // 
            // dgvCalificaciones
            // 
            this.dgvCalificaciones.AllowUserToAddRows = false;
            this.dgvCalificaciones.AllowUserToDeleteRows = false;
            this.dgvCalificaciones.AutoGenerateColumns = false;
            this.dgvCalificaciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCalificaciones.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCalificaciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCalificaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCalificaciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nrocarnetDataGridViewTextBoxColumn,
            this.idcursoDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.appaternoDataGridViewTextBoxColumn,
            this.apmaternoDataGridViewTextBoxColumn,
            this.celularDataGridViewTextBoxColumn,
            this.direccionDataGridViewTextBoxColumn,
            this.cursoDataGridViewTextBoxColumn,
            this.calificacionesDataGridViewTextBoxColumn,
            this.NotaFinal,
            this.Estado,
            this.Calif});
            this.dgvCalificaciones.DataSource = this.estudianteBindingSource;
            this.dgvCalificaciones.GridColor = System.Drawing.Color.SkyBlue;
            this.dgvCalificaciones.Location = new System.Drawing.Point(116, 214);
            this.dgvCalificaciones.Name = "dgvCalificaciones";
            this.dgvCalificaciones.ReadOnly = true;
            this.dgvCalificaciones.RowHeadersVisible = false;
            this.dgvCalificaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvCalificaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCalificaciones.Size = new System.Drawing.Size(793, 274);
            this.dgvCalificaciones.TabIndex = 19;
            this.dgvCalificaciones.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCalificaciones_CellClick);
            this.dgvCalificaciones.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvCalificaciones_CellPainting);
            // 
            // estudianteBindingSource
            // 
            this.estudianteBindingSource.DataSource = typeof(SGCalificaciones.Data.Estudiante);
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.White;
            this.iconPictureBox1.ForeColor = System.Drawing.Color.SteelBlue;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.iconPictureBox1.IconColor = System.Drawing.Color.SteelBlue;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.Location = new System.Drawing.Point(201, 165);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(39, 32);
            this.iconPictureBox1.TabIndex = 21;
            this.iconPictureBox1.TabStop = false;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(246, 167);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(462, 26);
            this.txtBuscar.TabIndex = 20;
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackColor = System.Drawing.Color.SteelBlue;
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimir.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.ForeColor = System.Drawing.Color.White;
            this.btnImprimir.IconChar = FontAwesome.Sharp.IconChar.Print;
            this.btnImprimir.IconColor = System.Drawing.Color.White;
            this.btnImprimir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnImprimir.IconSize = 60;
            this.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImprimir.Location = new System.Drawing.Point(741, 530);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(252, 70);
            this.btnImprimir.TabIndex = 22;
            this.btnImprimir.Text = "IMPRIMIR TODO";
            this.btnImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnImprimir.UseVisualStyleBackColor = false;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // nombreLabel1
            // 
            this.nombreLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.estudianteBindingSource, "nombre", true));
            this.nombreLabel1.Location = new System.Drawing.Point(58, 120);
            this.nombreLabel1.Name = "nombreLabel1";
            this.nombreLabel1.Size = new System.Drawing.Size(100, 14);
            this.nombreLabel1.TabIndex = 23;
            this.nombreLabel1.Text = "label2";
            // 
            // nro_carnetLabel1
            // 
            this.nro_carnetLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.estudianteBindingSource, "nro_carnet", true));
            this.nro_carnetLabel1.Location = new System.Drawing.Point(58, 87);
            this.nro_carnetLabel1.Name = "nro_carnetLabel1";
            this.nro_carnetLabel1.Size = new System.Drawing.Size(100, 23);
            this.nro_carnetLabel1.TabIndex = 24;
            this.nro_carnetLabel1.Text = "label2";
            // 
            // ap_paternoLabel1
            // 
            this.ap_paternoLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.estudianteBindingSource, "ap_paterno", true));
            this.ap_paternoLabel1.Location = new System.Drawing.Point(58, 134);
            this.ap_paternoLabel1.Name = "ap_paternoLabel1";
            this.ap_paternoLabel1.Size = new System.Drawing.Size(100, 23);
            this.ap_paternoLabel1.TabIndex = 25;
            this.ap_paternoLabel1.Text = "label2";
            // 
            // ap_maternoLabel1
            // 
            this.ap_maternoLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.estudianteBindingSource, "ap_materno", true));
            this.ap_maternoLabel1.Location = new System.Drawing.Point(58, 157);
            this.ap_maternoLabel1.Name = "ap_maternoLabel1";
            this.ap_maternoLabel1.Size = new System.Drawing.Size(100, 23);
            this.ap_maternoLabel1.TabIndex = 26;
            this.ap_maternoLabel1.Text = "label2";
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.SeaGreen;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.Color.White;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 40;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(725, 157);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(165, 40);
            this.iconButton1.TabIndex = 27;
            this.iconButton1.Text = "VER NOTAS";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // nrocarnetDataGridViewTextBoxColumn
            // 
            this.nrocarnetDataGridViewTextBoxColumn.DataPropertyName = "nro_carnet";
            this.nrocarnetDataGridViewTextBoxColumn.FillWeight = 91.37056F;
            this.nrocarnetDataGridViewTextBoxColumn.HeaderText = "NRO CARNET";
            this.nrocarnetDataGridViewTextBoxColumn.Name = "nrocarnetDataGridViewTextBoxColumn";
            this.nrocarnetDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idcursoDataGridViewTextBoxColumn
            // 
            this.idcursoDataGridViewTextBoxColumn.DataPropertyName = "id_curso";
            this.idcursoDataGridViewTextBoxColumn.HeaderText = "id_curso";
            this.idcursoDataGridViewTextBoxColumn.Name = "idcursoDataGridViewTextBoxColumn";
            this.idcursoDataGridViewTextBoxColumn.ReadOnly = true;
            this.idcursoDataGridViewTextBoxColumn.Visible = false;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.FillWeight = 101.7259F;
            this.nombreDataGridViewTextBoxColumn.HeaderText = "NOMBRE";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // appaternoDataGridViewTextBoxColumn
            // 
            this.appaternoDataGridViewTextBoxColumn.DataPropertyName = "ap_paterno";
            this.appaternoDataGridViewTextBoxColumn.FillWeight = 101.7259F;
            this.appaternoDataGridViewTextBoxColumn.HeaderText = "APELLIDO PATERNO";
            this.appaternoDataGridViewTextBoxColumn.Name = "appaternoDataGridViewTextBoxColumn";
            this.appaternoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // apmaternoDataGridViewTextBoxColumn
            // 
            this.apmaternoDataGridViewTextBoxColumn.DataPropertyName = "ap_materno";
            this.apmaternoDataGridViewTextBoxColumn.FillWeight = 101.7259F;
            this.apmaternoDataGridViewTextBoxColumn.HeaderText = "APELLIDO MATERNO";
            this.apmaternoDataGridViewTextBoxColumn.Name = "apmaternoDataGridViewTextBoxColumn";
            this.apmaternoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // celularDataGridViewTextBoxColumn
            // 
            this.celularDataGridViewTextBoxColumn.DataPropertyName = "celular";
            this.celularDataGridViewTextBoxColumn.HeaderText = "celular";
            this.celularDataGridViewTextBoxColumn.Name = "celularDataGridViewTextBoxColumn";
            this.celularDataGridViewTextBoxColumn.ReadOnly = true;
            this.celularDataGridViewTextBoxColumn.Visible = false;
            // 
            // direccionDataGridViewTextBoxColumn
            // 
            this.direccionDataGridViewTextBoxColumn.DataPropertyName = "direccion";
            this.direccionDataGridViewTextBoxColumn.HeaderText = "direccion";
            this.direccionDataGridViewTextBoxColumn.Name = "direccionDataGridViewTextBoxColumn";
            this.direccionDataGridViewTextBoxColumn.ReadOnly = true;
            this.direccionDataGridViewTextBoxColumn.Visible = false;
            // 
            // cursoDataGridViewTextBoxColumn
            // 
            this.cursoDataGridViewTextBoxColumn.DataPropertyName = "Curso";
            this.cursoDataGridViewTextBoxColumn.HeaderText = "Curso";
            this.cursoDataGridViewTextBoxColumn.Name = "cursoDataGridViewTextBoxColumn";
            this.cursoDataGridViewTextBoxColumn.ReadOnly = true;
            this.cursoDataGridViewTextBoxColumn.Visible = false;
            // 
            // calificacionesDataGridViewTextBoxColumn
            // 
            this.calificacionesDataGridViewTextBoxColumn.DataPropertyName = "Calificaciones";
            this.calificacionesDataGridViewTextBoxColumn.HeaderText = "Calificaciones";
            this.calificacionesDataGridViewTextBoxColumn.Name = "calificacionesDataGridViewTextBoxColumn";
            this.calificacionesDataGridViewTextBoxColumn.ReadOnly = true;
            this.calificacionesDataGridViewTextBoxColumn.Visible = false;
            // 
            // NotaFinal
            // 
            this.NotaFinal.FillWeight = 101.7259F;
            this.NotaFinal.HeaderText = "NOTA FINAL";
            this.NotaFinal.Name = "NotaFinal";
            this.NotaFinal.ReadOnly = true;
            this.NotaFinal.Visible = false;
            // 
            // Estado
            // 
            this.Estado.FillWeight = 101.7259F;
            this.Estado.HeaderText = "ESTADO";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            this.Estado.Visible = false;
            // 
            // Calif
            // 
            this.Calif.HeaderText = "VER CALIF";
            this.Calif.Name = "Calif";
            this.Calif.ReadOnly = true;
            this.Calif.Visible = false;
            // 
            // frmCalificacionesGeneral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1078, 669);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.ap_maternoLabel1);
            this.Controls.Add(this.ap_paternoLabel1);
            this.Controls.Add(this.nro_carnetLabel1);
            this.Controls.Add(this.nombreLabel1);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.dgvCalificaciones);
            this.Controls.Add(this.iconPictureBox2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCalificacionesGeneral";
            this.Text = "frmCalificacionesGeneral";
            this.Load += new System.EventHandler(this.frmCalificacionesGeneral_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCalificaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estudianteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvCalificaciones;
        private System.Windows.Forms.BindingSource estudianteBindingSource;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.TextBox txtBuscar;
        private FontAwesome.Sharp.IconButton btnImprimir;
        private System.Windows.Forms.Label nombreLabel1;
        private System.Windows.Forms.Label nro_carnetLabel1;
        private System.Windows.Forms.Label ap_paternoLabel1;
        private System.Windows.Forms.Label ap_maternoLabel1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrocarnetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcursoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn appaternoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apmaternoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn celularDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cursoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn calificacionesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NotaFinal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Calif;
    }
}