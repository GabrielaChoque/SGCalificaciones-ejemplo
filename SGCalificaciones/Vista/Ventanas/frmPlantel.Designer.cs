
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
            System.Windows.Forms.Label tipo_plantelLabel;
            System.Windows.Forms.Label usuarioLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPlantel));
            this.label1 = new System.Windows.Forms.Label();
            this.plantel_EducativoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ap_maternoTextBox = new System.Windows.Forms.TextBox();
            this.ap_paternoTextBox = new System.Windows.Forms.TextBox();
            this.celularTextBox = new System.Windows.Forms.TextBox();
            this.contraseniaTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.nro_carnetTextBox = new System.Windows.Forms.TextBox();
            this.tipo_plantelTextBox = new System.Windows.Forms.TextBox();
            this.usuarioTextBox = new System.Windows.Forms.TextBox();
            this.plantel_EducativoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.plantel_EducativoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            ap_maternoLabel = new System.Windows.Forms.Label();
            ap_paternoLabel = new System.Windows.Forms.Label();
            celularLabel = new System.Windows.Forms.Label();
            contraseniaLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            nro_carnetLabel = new System.Windows.Forms.Label();
            tipo_plantelLabel = new System.Windows.Forms.Label();
            usuarioLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.plantel_EducativoBindingNavigator)).BeginInit();
            this.plantel_EducativoBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.plantel_EducativoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(170, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // plantel_EducativoBindingNavigator
            // 
            this.plantel_EducativoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.plantel_EducativoBindingNavigator.BindingSource = this.plantel_EducativoBindingSource;
            this.plantel_EducativoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.plantel_EducativoBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.plantel_EducativoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.plantel_EducativoBindingNavigatorSaveItem});
            this.plantel_EducativoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.plantel_EducativoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.plantel_EducativoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.plantel_EducativoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.plantel_EducativoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.plantel_EducativoBindingNavigator.Name = "plantel_EducativoBindingNavigator";
            this.plantel_EducativoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.plantel_EducativoBindingNavigator.Size = new System.Drawing.Size(421, 25);
            this.plantel_EducativoBindingNavigator.TabIndex = 1;
            this.plantel_EducativoBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // ap_maternoLabel
            // 
            ap_maternoLabel.AutoSize = true;
            ap_maternoLabel.Location = new System.Drawing.Point(51, 61);
            ap_maternoLabel.Name = "ap_maternoLabel";
            ap_maternoLabel.Size = new System.Drawing.Size(63, 13);
            ap_maternoLabel.TabIndex = 2;
            ap_maternoLabel.Text = "ap materno:";
            // 
            // ap_maternoTextBox
            // 
            this.ap_maternoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.plantel_EducativoBindingSource, "ap_materno", true));
            this.ap_maternoTextBox.Location = new System.Drawing.Point(122, 58);
            this.ap_maternoTextBox.Name = "ap_maternoTextBox";
            this.ap_maternoTextBox.Size = new System.Drawing.Size(166, 20);
            this.ap_maternoTextBox.TabIndex = 3;
            // 
            // ap_paternoLabel
            // 
            ap_paternoLabel.AutoSize = true;
            ap_paternoLabel.Location = new System.Drawing.Point(51, 87);
            ap_paternoLabel.Name = "ap_paternoLabel";
            ap_paternoLabel.Size = new System.Drawing.Size(61, 13);
            ap_paternoLabel.TabIndex = 4;
            ap_paternoLabel.Text = "ap paterno:";
            // 
            // ap_paternoTextBox
            // 
            this.ap_paternoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.plantel_EducativoBindingSource, "ap_paterno", true));
            this.ap_paternoTextBox.Location = new System.Drawing.Point(122, 84);
            this.ap_paternoTextBox.Name = "ap_paternoTextBox";
            this.ap_paternoTextBox.Size = new System.Drawing.Size(166, 20);
            this.ap_paternoTextBox.TabIndex = 5;
            // 
            // celularLabel
            // 
            celularLabel.AutoSize = true;
            celularLabel.Location = new System.Drawing.Point(51, 113);
            celularLabel.Name = "celularLabel";
            celularLabel.Size = new System.Drawing.Size(41, 13);
            celularLabel.TabIndex = 6;
            celularLabel.Text = "celular:";
            // 
            // celularTextBox
            // 
            this.celularTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.plantel_EducativoBindingSource, "celular", true));
            this.celularTextBox.Location = new System.Drawing.Point(122, 110);
            this.celularTextBox.Name = "celularTextBox";
            this.celularTextBox.Size = new System.Drawing.Size(166, 20);
            this.celularTextBox.TabIndex = 7;
            // 
            // contraseniaLabel
            // 
            contraseniaLabel.AutoSize = true;
            contraseniaLabel.Location = new System.Drawing.Point(51, 139);
            contraseniaLabel.Name = "contraseniaLabel";
            contraseniaLabel.Size = new System.Drawing.Size(65, 13);
            contraseniaLabel.TabIndex = 8;
            contraseniaLabel.Text = "contrasenia:";
            // 
            // contraseniaTextBox
            // 
            this.contraseniaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.plantel_EducativoBindingSource, "contrasenia", true));
            this.contraseniaTextBox.Location = new System.Drawing.Point(122, 136);
            this.contraseniaTextBox.Name = "contraseniaTextBox";
            this.contraseniaTextBox.Size = new System.Drawing.Size(166, 20);
            this.contraseniaTextBox.TabIndex = 9;
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(51, 165);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(45, 13);
            nombreLabel.TabIndex = 10;
            nombreLabel.Text = "nombre:";
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.plantel_EducativoBindingSource, "nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(122, 162);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(166, 20);
            this.nombreTextBox.TabIndex = 11;
            // 
            // nro_carnetLabel
            // 
            nro_carnetLabel.AutoSize = true;
            nro_carnetLabel.Location = new System.Drawing.Point(51, 191);
            nro_carnetLabel.Name = "nro_carnetLabel";
            nro_carnetLabel.Size = new System.Drawing.Size(58, 13);
            nro_carnetLabel.TabIndex = 12;
            nro_carnetLabel.Text = "nro carnet:";
            // 
            // nro_carnetTextBox
            // 
            this.nro_carnetTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.plantel_EducativoBindingSource, "nro_carnet", true));
            this.nro_carnetTextBox.Location = new System.Drawing.Point(122, 188);
            this.nro_carnetTextBox.Name = "nro_carnetTextBox";
            this.nro_carnetTextBox.Size = new System.Drawing.Size(166, 20);
            this.nro_carnetTextBox.TabIndex = 13;
            // 
            // tipo_plantelLabel
            // 
            tipo_plantelLabel.AutoSize = true;
            tipo_plantelLabel.Location = new System.Drawing.Point(51, 217);
            tipo_plantelLabel.Name = "tipo_plantelLabel";
            tipo_plantelLabel.Size = new System.Drawing.Size(61, 13);
            tipo_plantelLabel.TabIndex = 14;
            tipo_plantelLabel.Text = "tipo plantel:";
            // 
            // tipo_plantelTextBox
            // 
            this.tipo_plantelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.plantel_EducativoBindingSource, "tipo_plantel", true));
            this.tipo_plantelTextBox.Location = new System.Drawing.Point(122, 214);
            this.tipo_plantelTextBox.Name = "tipo_plantelTextBox";
            this.tipo_plantelTextBox.Size = new System.Drawing.Size(166, 20);
            this.tipo_plantelTextBox.TabIndex = 15;
            // 
            // usuarioLabel
            // 
            usuarioLabel.AutoSize = true;
            usuarioLabel.Location = new System.Drawing.Point(51, 243);
            usuarioLabel.Name = "usuarioLabel";
            usuarioLabel.Size = new System.Drawing.Size(44, 13);
            usuarioLabel.TabIndex = 16;
            usuarioLabel.Text = "usuario:";
            // 
            // usuarioTextBox
            // 
            this.usuarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.plantel_EducativoBindingSource, "usuario", true));
            this.usuarioTextBox.Location = new System.Drawing.Point(122, 240);
            this.usuarioTextBox.Name = "usuarioTextBox";
            this.usuarioTextBox.Size = new System.Drawing.Size(166, 20);
            this.usuarioTextBox.TabIndex = 17;
            // 
            // plantel_EducativoBindingSource
            // 
            this.plantel_EducativoBindingSource.DataSource = typeof(SGCalificaciones.Data.Plantel_Educativo);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // plantel_EducativoBindingNavigatorSaveItem
            // 
            this.plantel_EducativoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.plantel_EducativoBindingNavigatorSaveItem.Enabled = false;
            this.plantel_EducativoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("plantel_EducativoBindingNavigatorSaveItem.Image")));
            this.plantel_EducativoBindingNavigatorSaveItem.Name = "plantel_EducativoBindingNavigatorSaveItem";
            this.plantel_EducativoBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.plantel_EducativoBindingNavigatorSaveItem.Text = "Guardar datos";
            // 
            // frmPlantel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 327);
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
            this.Controls.Add(tipo_plantelLabel);
            this.Controls.Add(this.tipo_plantelTextBox);
            this.Controls.Add(usuarioLabel);
            this.Controls.Add(this.usuarioTextBox);
            this.Controls.Add(this.plantel_EducativoBindingNavigator);
            this.Controls.Add(this.label1);
            this.Name = "frmPlantel";
            this.Text = "frmPlantel";
            ((System.ComponentModel.ISupportInitialize)(this.plantel_EducativoBindingNavigator)).EndInit();
            this.plantel_EducativoBindingNavigator.ResumeLayout(false);
            this.plantel_EducativoBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.plantel_EducativoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource plantel_EducativoBindingSource;
        private System.Windows.Forms.BindingNavigator plantel_EducativoBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton plantel_EducativoBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox ap_maternoTextBox;
        private System.Windows.Forms.TextBox ap_paternoTextBox;
        private System.Windows.Forms.TextBox celularTextBox;
        private System.Windows.Forms.TextBox contraseniaTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox nro_carnetTextBox;
        private System.Windows.Forms.TextBox tipo_plantelTextBox;
        private System.Windows.Forms.TextBox usuarioTextBox;
    }
}