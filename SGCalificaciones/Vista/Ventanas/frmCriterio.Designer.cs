
namespace SGCalificaciones.Vista.Ventanas
{
    partial class frmCriterio
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
            System.Windows.Forms.Label desc_criterioLabel;
            System.Windows.Forms.Label fechaLabel;
            System.Windows.Forms.Label id_bimestreLabel;
            System.Windows.Forms.Label id_criterioLabel;
            this.label1 = new System.Windows.Forms.Label();
            this.desc_criterioTextBox = new System.Windows.Forms.TextBox();
            this.fechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.id_bimestreTextBox = new System.Windows.Forms.TextBox();
            this.id_criterioTextBox = new System.Windows.Forms.TextBox();
            this.btnCancelar = new FontAwesome.Sharp.IconButton();
            this.btnAceptar = new FontAwesome.Sharp.IconButton();
            this.criterioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            desc_criterioLabel = new System.Windows.Forms.Label();
            fechaLabel = new System.Windows.Forms.Label();
            id_bimestreLabel = new System.Windows.Forms.Label();
            id_criterioLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.criterioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // desc_criterioLabel
            // 
            desc_criterioLabel.AutoSize = true;
            desc_criterioLabel.Location = new System.Drawing.Point(37, 117);
            desc_criterioLabel.Name = "desc_criterioLabel";
            desc_criterioLabel.Size = new System.Drawing.Size(121, 13);
            desc_criterioLabel.TabIndex = 23;
            desc_criterioLabel.Text = "CRITERIO A EVALUAR";
            // 
            // fechaLabel
            // 
            fechaLabel.AutoSize = true;
            fechaLabel.Location = new System.Drawing.Point(37, 171);
            fechaLabel.Name = "fechaLabel";
            fechaLabel.Size = new System.Drawing.Size(42, 13);
            fechaLabel.TabIndex = 25;
            fechaLabel.Text = "FECHA";
            // 
            // id_bimestreLabel
            // 
            id_bimestreLabel.AutoSize = true;
            id_bimestreLabel.Location = new System.Drawing.Point(37, 144);
            id_bimestreLabel.Name = "id_bimestreLabel";
            id_bimestreLabel.Size = new System.Drawing.Size(62, 13);
            id_bimestreLabel.TabIndex = 27;
            id_bimestreLabel.Text = "BIMESTRE";
            // 
            // id_criterioLabel
            // 
            id_criterioLabel.AutoSize = true;
            id_criterioLabel.Location = new System.Drawing.Point(37, 91);
            id_criterioLabel.Name = "id_criterioLabel";
            id_criterioLabel.Size = new System.Drawing.Size(85, 13);
            id_criterioLabel.TabIndex = 29;
            id_criterioLabel.Text = "NRO CRITERIO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(184, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // desc_criterioTextBox
            // 
            this.desc_criterioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.criterioBindingSource, "desc_criterio", true));
            this.desc_criterioTextBox.Location = new System.Drawing.Point(164, 114);
            this.desc_criterioTextBox.MaxLength = 10;
            this.desc_criterioTextBox.Name = "desc_criterioTextBox";
            this.desc_criterioTextBox.Size = new System.Drawing.Size(200, 20);
            this.desc_criterioTextBox.TabIndex = 1;
            this.desc_criterioTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Desc_criterioTextBox_KeyPress);
            // 
            // fechaDateTimePicker
            // 
            this.fechaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.criterioBindingSource, "fecha", true));
            this.fechaDateTimePicker.Location = new System.Drawing.Point(164, 167);
            this.fechaDateTimePicker.Name = "fechaDateTimePicker";
            this.fechaDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fechaDateTimePicker.TabIndex = 3;
            // 
            // id_bimestreTextBox
            // 
            this.id_bimestreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.criterioBindingSource, "id_bimestre", true));
            this.id_bimestreTextBox.Location = new System.Drawing.Point(164, 141);
            this.id_bimestreTextBox.MaxLength = 7;
            this.id_bimestreTextBox.Name = "id_bimestreTextBox";
            this.id_bimestreTextBox.Size = new System.Drawing.Size(200, 20);
            this.id_bimestreTextBox.TabIndex = 2;
            // 
            // id_criterioTextBox
            // 
            this.id_criterioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.criterioBindingSource, "id_criterio", true));
            this.id_criterioTextBox.Location = new System.Drawing.Point(164, 88);
            this.id_criterioTextBox.MaxLength = 5;
            this.id_criterioTextBox.Name = "id_criterioTextBox";
            this.id_criterioTextBox.Size = new System.Drawing.Size(200, 20);
            this.id_criterioTextBox.TabIndex = 0;
            this.id_criterioTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Id_criterioTextBox_KeyPress);
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
            this.btnCancelar.Location = new System.Drawing.Point(248, 256);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(139, 45);
            this.btnCancelar.TabIndex = 5;
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
            this.btnAceptar.Location = new System.Drawing.Point(34, 256);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(139, 45);
            this.btnAceptar.TabIndex = 4;
            this.btnAceptar.Text = "ACEPTAR";
            this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // criterioBindingSource
            // 
            this.criterioBindingSource.DataSource = typeof(SGCalificaciones.Data.Criterio);
            // 
            // frmCriterio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(421, 324);
            this.Controls.Add(desc_criterioLabel);
            this.Controls.Add(this.desc_criterioTextBox);
            this.Controls.Add(fechaLabel);
            this.Controls.Add(this.fechaDateTimePicker);
            this.Controls.Add(id_bimestreLabel);
            this.Controls.Add(this.id_bimestreTextBox);
            this.Controls.Add(id_criterioLabel);
            this.Controls.Add(this.id_criterioTextBox);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmCriterio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCriterio";
            this.Load += new System.EventHandler(this.frmPlantel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.criterioBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private FontAwesome.Sharp.IconButton btnAceptar;
        private System.Windows.Forms.BindingSource criterioBindingSource;
        private System.Windows.Forms.TextBox desc_criterioTextBox;
        private System.Windows.Forms.DateTimePicker fechaDateTimePicker;
        private System.Windows.Forms.TextBox id_bimestreTextBox;
        private System.Windows.Forms.TextBox id_criterioTextBox;
    }
}