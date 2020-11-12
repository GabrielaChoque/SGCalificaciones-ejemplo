
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
            System.Windows.Forms.Label contraseniaLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label nro_carnetLabel;
            System.Windows.Forms.Label usuarioLabel;
            System.Windows.Forms.Label tipo_plantelLabel;
            this.label1 = new System.Windows.Forms.Label();
            this.contraseniaTextBox = new System.Windows.Forms.TextBox();
            this.plantel_EducativoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuarioTextBox = new System.Windows.Forms.TextBox();
            this.btnAceptar = new FontAwesome.Sharp.IconButton();
            this.btnCancelar = new FontAwesome.Sharp.IconButton();
            this.nro_carnetTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.celularTextBox = new System.Windows.Forms.TextBox();
            this.ap_paternoTextBox = new System.Windows.Forms.TextBox();
            this.ap_maternoTextBox = new System.Windows.Forms.TextBox();
            this.tipo_plantelComboBox = new System.Windows.Forms.ComboBox();
            ap_maternoLabel = new System.Windows.Forms.Label();
            ap_paternoLabel = new System.Windows.Forms.Label();
            celularLabel = new System.Windows.Forms.Label();
            contraseniaLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            nro_carnetLabel = new System.Windows.Forms.Label();
            usuarioLabel = new System.Windows.Forms.Label();
            tipo_plantelLabel = new System.Windows.Forms.Label();
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
            // contraseniaLabel
            // 
            contraseniaLabel.AutoSize = true;
            contraseniaLabel.Location = new System.Drawing.Point(72, 242);
            contraseniaLabel.Name = "contraseniaLabel";
            contraseniaLabel.Size = new System.Drawing.Size(65, 13);
            contraseniaLabel.TabIndex = 8;
            contraseniaLabel.Text = "contrasenia:";
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
            // usuarioLabel
            // 
            usuarioLabel.AutoSize = true;
            usuarioLabel.Location = new System.Drawing.Point(72, 269);
            usuarioLabel.Name = "usuarioLabel";
            usuarioLabel.Size = new System.Drawing.Size(44, 13);
            usuarioLabel.TabIndex = 16;
            usuarioLabel.Text = "usuario:";
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
            // contraseniaTextBox
            // 
            this.contraseniaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.plantel_EducativoBindingSource, "contrasenia", true));
            this.contraseniaTextBox.Location = new System.Drawing.Point(143, 239);
            this.contraseniaTextBox.Name = "contraseniaTextBox";
            this.contraseniaTextBox.Size = new System.Drawing.Size(166, 20);
            this.contraseniaTextBox.TabIndex = 9;
            // 
            // plantel_EducativoBindingSource
            // 
            this.plantel_EducativoBindingSource.DataSource = typeof(SGCalificaciones.Data.Plantel_Educativo);
            // 
            // usuarioTextBox
            // 
            this.usuarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.plantel_EducativoBindingSource, "usuario", true));
            this.usuarioTextBox.Location = new System.Drawing.Point(143, 266);
            this.usuarioTextBox.Name = "usuarioTextBox";
            this.usuarioTextBox.Size = new System.Drawing.Size(166, 20);
            this.usuarioTextBox.TabIndex = 17;
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
            "Docente",
            "Administrativo"});
            this.tipo_plantelComboBox.Location = new System.Drawing.Point(169, 189);
            this.tipo_plantelComboBox.Name = "tipo_plantelComboBox";
            this.tipo_plantelComboBox.Size = new System.Drawing.Size(166, 21);
            this.tipo_plantelComboBox.TabIndex = 18;
            // 
            // frmPlantel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(421, 383);
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
            this.Controls.Add(contraseniaLabel);
            this.Controls.Add(this.contraseniaTextBox);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(nro_carnetLabel);
            this.Controls.Add(this.nro_carnetTextBox);
            this.Controls.Add(usuarioLabel);
            this.Controls.Add(this.usuarioTextBox);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPlantel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPlantel";
            this.Load += new System.EventHandler(this.frmPlantel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.plantel_EducativoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource plantel_EducativoBindingSource;
        private System.Windows.Forms.TextBox contraseniaTextBox;
        private System.Windows.Forms.TextBox usuarioTextBox;
        private FontAwesome.Sharp.IconButton btnAceptar;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private System.Windows.Forms.TextBox nro_carnetTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox celularTextBox;
        private System.Windows.Forms.TextBox ap_paternoTextBox;
        private System.Windows.Forms.TextBox ap_maternoTextBox;
        private System.Windows.Forms.ComboBox tipo_plantelComboBox;
    }
}