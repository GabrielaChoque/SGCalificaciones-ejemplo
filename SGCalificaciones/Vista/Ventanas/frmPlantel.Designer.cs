
namespace SGCalificaciones.Vista.Ventanas
{
    partial class frmPlantel
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
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label nro_carnetLabel;
            System.Windows.Forms.Label tipo_plantelLabel;
            System.Windows.Forms.Label contraseniaLabel;
            System.Windows.Forms.Label usuarioLabel;
            this.label1 = new System.Windows.Forms.Label();
            this.btnAceptar = new FontAwesome.Sharp.IconButton();
            this.btnCancelar = new FontAwesome.Sharp.IconButton();
            this.nro_carnetTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.celularTextBox = new System.Windows.Forms.TextBox();
            this.ap_paternoTextBox = new System.Windows.Forms.TextBox();
            this.ap_maternoTextBox = new System.Windows.Forms.TextBox();
            this.tipo_plantelComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.plantel_EducativoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ap_maternoLabel = new System.Windows.Forms.Label();
            ap_paternoLabel = new System.Windows.Forms.Label();
            celularLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            nro_carnetLabel = new System.Windows.Forms.Label();
            tipo_plantelLabel = new System.Windows.Forms.Label();
            contraseniaLabel = new System.Windows.Forms.Label();
            usuarioLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.plantel_EducativoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ap_maternoLabel
            // 
            ap_maternoLabel.AutoSize = true;
            ap_maternoLabel.Location = new System.Drawing.Point(45, 114);
            ap_maternoLabel.Name = "ap_maternoLabel";
            ap_maternoLabel.Size = new System.Drawing.Size(117, 13);
            ap_maternoLabel.TabIndex = 2;
            ap_maternoLabel.Text = "APELLIDO PATERNO:";
            // 
            // ap_paternoLabel
            // 
            ap_paternoLabel.AutoSize = true;
            ap_paternoLabel.Location = new System.Drawing.Point(45, 140);
            ap_paternoLabel.Name = "ap_paternoLabel";
            ap_paternoLabel.Size = new System.Drawing.Size(116, 13);
            ap_paternoLabel.TabIndex = 4;
            ap_paternoLabel.Text = "APELLIDO MATERNO";
            // 
            // celularLabel
            // 
            celularLabel.AutoSize = true;
            celularLabel.Location = new System.Drawing.Point(45, 166);
            celularLabel.Name = "celularLabel";
            celularLabel.Size = new System.Drawing.Size(56, 13);
            celularLabel.TabIndex = 6;
            celularLabel.Text = "CELULAR";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(45, 87);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(57, 13);
            nombreLabel.TabIndex = 10;
            nombreLabel.Text = "NOMBRE:";
            // 
            // nro_carnetLabel
            // 
            nro_carnetLabel.AutoSize = true;
            nro_carnetLabel.Location = new System.Drawing.Point(45, 61);
            nro_carnetLabel.Name = "nro_carnetLabel";
            nro_carnetLabel.Size = new System.Drawing.Size(123, 13);
            nro_carnetLabel.TabIndex = 12;
            nro_carnetLabel.Text = "NUMERO DE CARNET:";
            // 
            // tipo_plantelLabel
            // 
            tipo_plantelLabel.AutoSize = true;
            tipo_plantelLabel.Location = new System.Drawing.Point(45, 192);
            tipo_plantelLabel.Name = "tipo_plantelLabel";
            tipo_plantelLabel.Size = new System.Drawing.Size(58, 13);
            tipo_plantelLabel.TabIndex = 17;
            tipo_plantelLabel.Text = "PLANTEL:";
            // 
            // contraseniaLabel
            // 
            contraseniaLabel.AutoSize = true;
            contraseniaLabel.Location = new System.Drawing.Point(49, 51);
            contraseniaLabel.Name = "contraseniaLabel";
            contraseniaLabel.Size = new System.Drawing.Size(84, 13);
            contraseniaLabel.TabIndex = 0;
            contraseniaLabel.Text = "CONTRASEÑA:";
            // 
            // usuarioLabel
            // 
            usuarioLabel.AutoSize = true;
            usuarioLabel.Location = new System.Drawing.Point(72, 26);
            usuarioLabel.Name = "usuarioLabel";
            usuarioLabel.Size = new System.Drawing.Size(59, 13);
            usuarioLabel.TabIndex = 2;
            usuarioLabel.Text = "USUARIO:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(167, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
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
            this.btnAceptar.Location = new System.Drawing.Point(29, 316);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(139, 45);
            this.btnAceptar.TabIndex = 19;
            this.btnAceptar.Text = "ACEPTAR";
            this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
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
            this.btnCancelar.Location = new System.Drawing.Point(243, 316);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(139, 45);
            this.btnCancelar.TabIndex = 20;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // nro_carnetTextBox
            // 
            this.nro_carnetTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.plantel_EducativoBindingSource, "nro_carnet", true));
            this.nro_carnetTextBox.Location = new System.Drawing.Point(169, 58);
            this.nro_carnetTextBox.Name = "nro_carnetTextBox";
            this.nro_carnetTextBox.Size = new System.Drawing.Size(166, 20);
            this.nro_carnetTextBox.TabIndex = 13;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.plantel_EducativoBindingSource, "nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(169, 84);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(166, 20);
            this.nombreTextBox.TabIndex = 11;
            // 
            // celularTextBox
            // 
            this.celularTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.plantel_EducativoBindingSource, "celular", true));
            this.celularTextBox.Location = new System.Drawing.Point(169, 163);
            this.celularTextBox.Name = "celularTextBox";
            this.celularTextBox.Size = new System.Drawing.Size(166, 20);
            this.celularTextBox.TabIndex = 7;
            // 
            // ap_paternoTextBox
            // 
            this.ap_paternoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.plantel_EducativoBindingSource, "ap_paterno", true));
            this.ap_paternoTextBox.Location = new System.Drawing.Point(169, 137);
            this.ap_paternoTextBox.Name = "ap_paternoTextBox";
            this.ap_paternoTextBox.Size = new System.Drawing.Size(166, 20);
            this.ap_paternoTextBox.TabIndex = 5;
            // 
            // ap_maternoTextBox
            // 
            this.ap_maternoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.plantel_EducativoBindingSource, "ap_materno", true));
            this.ap_maternoTextBox.Location = new System.Drawing.Point(169, 111);
            this.ap_maternoTextBox.Name = "ap_maternoTextBox";
            this.ap_maternoTextBox.Size = new System.Drawing.Size(166, 20);
            this.ap_maternoTextBox.TabIndex = 3;
            // 
            // tipo_plantelComboBox
            // 
            this.tipo_plantelComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.plantel_EducativoBindingSource, "tipo_plantel", true));
            this.tipo_plantelComboBox.FormattingEnabled = true;
            this.tipo_plantelComboBox.Items.AddRange(new object[] {
            "Profesor",
            "Administrativo"});
            this.tipo_plantelComboBox.Location = new System.Drawing.Point(169, 189);
            this.tipo_plantelComboBox.Name = "tipo_plantelComboBox";
            this.tipo_plantelComboBox.Size = new System.Drawing.Size(166, 21);
            this.tipo_plantelComboBox.TabIndex = 18;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(usuarioLabel);
            this.groupBox1.Controls.Add(contraseniaLabel);
            this.groupBox1.Location = new System.Drawing.Point(29, 220);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(353, 80);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Inicio de Sesión en el Sistema";
            // 
            // plantel_EducativoBindingSource
            // 
            this.plantel_EducativoBindingSource.DataSource = typeof(SGCalificaciones.Data.Plantel_Educativo);
            // 
            // frmPlantel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(421, 383);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(tipo_plantelLabel);
            this.Controls.Add(this.tipo_plantelComboBox);
            this.Controls.Add(ap_maternoLabel);
            this.Controls.Add(this.ap_maternoTextBox);
            this.Controls.Add(ap_paternoLabel);
            this.Controls.Add(this.ap_paternoTextBox);
            this.Controls.Add(celularLabel);
            this.Controls.Add(this.celularTextBox);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(nro_carnetLabel);
            this.Controls.Add(this.nro_carnetTextBox);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPlantel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPlantel";
            this.Load += new System.EventHandler(this.frmPlantel_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.plantel_EducativoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource plantel_EducativoBindingSource;
        private FontAwesome.Sharp.IconButton btnAceptar;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private System.Windows.Forms.TextBox nro_carnetTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox celularTextBox;
        private System.Windows.Forms.TextBox ap_paternoTextBox;
        private System.Windows.Forms.TextBox ap_maternoTextBox;
        private System.Windows.Forms.ComboBox tipo_plantelComboBox;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}