
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
            this.label1 = new System.Windows.Forms.Label();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.cursoDataGridView = new System.Windows.Forms.DataGridView();
            this.bimestreDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bimestreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cursoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bimestreDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bimestreBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursoBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.cursoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cursoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.cursoDataGridView.DataSource = this.cursoBindingSource;
            this.cursoDataGridView.Location = new System.Drawing.Point(66, 346);
            this.cursoDataGridView.Name = "cursoDataGridView";
            this.cursoDataGridView.Size = new System.Drawing.Size(670, 220);
            this.cursoDataGridView.TabIndex = 12;
            // 
            // bimestreDataGridView
            // 
            this.bimestreDataGridView.AutoGenerateColumns = false;
            this.bimestreDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bimestreDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3});
            this.bimestreDataGridView.DataSource = this.bimestreBindingSource;
            this.bimestreDataGridView.Location = new System.Drawing.Point(66, 162);
            this.bimestreDataGridView.Name = "bimestreDataGridView";
            this.bimestreDataGridView.Size = new System.Drawing.Size(365, 122);
            this.bimestreDataGridView.TabIndex = 13;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_bimestre";
            this.dataGridViewTextBoxColumn1.HeaderText = "id_bimestre";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "bimestre";
            this.dataGridViewTextBoxColumn3.HeaderText = "bimestre";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // bimestreBindingSource
            // 
            this.bimestreBindingSource.DataSource = typeof(SGCalificaciones.Data.Bimestre);
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
            // frmGestionarAnioEscolar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1078, 669);
            this.Controls.Add(this.bimestreDataGridView);
            this.Controls.Add(this.cursoDataGridView);
            this.Controls.Add(this.iconPictureBox2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGestionarAnioEscolar";
            this.Text = "frmGestionarAnioEscolar";
            this.Load += new System.EventHandler(this.frmGestionarAnioEscolar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bimestreDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bimestreBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursoBindingSource)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}