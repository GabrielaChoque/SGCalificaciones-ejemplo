
namespace SGCalificaciones.Vista
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.PanelContenido = new System.Windows.Forms.Panel();
            this.PannelMenu = new System.Windows.Forms.Panel();
            this.Sidebar = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btnCalificaiones = new FontAwesome.Sharp.IconButton();
            this.btnCriterios = new FontAwesome.Sharp.IconButton();
            this.btnMisEstudiantes = new FontAwesome.Sharp.IconButton();
            this.btnSalir = new FontAwesome.Sharp.IconButton();
            this.btnAnioEscolar = new FontAwesome.Sharp.IconButton();
            this.btnEstudiantes = new FontAwesome.Sharp.IconButton();
            this.btnPlantelDocente = new FontAwesome.Sharp.IconButton();
            this.btnInicio = new FontAwesome.Sharp.IconButton();
            this.LineaSidebar = new Bunifu.Framework.UI.BunifuSeparator();
            this.label2 = new System.Windows.Forms.Label();
            this.MenuTop = new System.Windows.Forms.Panel();
            this.Restaurar = new System.Windows.Forms.PictureBox();
            this.Minimizar = new System.Windows.Forms.PictureBox();
            this.Maximizar = new System.Windows.Forms.PictureBox();
            this.Salir = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PtbxMenuSidebar = new System.Windows.Forms.PictureBox();
            this.MoverDashboard = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.PannelMenu.SuspendLayout();
            this.Sidebar.SuspendLayout();
            this.MenuTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Restaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Maximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Salir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PtbxMenuSidebar)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelContenido
            // 
            this.PanelContenido.BackColor = System.Drawing.Color.White;
            this.PanelContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContenido.Location = new System.Drawing.Point(300, 80);
            this.PanelContenido.Name = "PanelContenido";
            this.PanelContenido.Size = new System.Drawing.Size(1070, 669);
            this.PanelContenido.TabIndex = 10;
            // 
            // PannelMenu
            // 
            this.PannelMenu.BackColor = System.Drawing.Color.White;
            this.PannelMenu.Controls.Add(this.Sidebar);
            this.PannelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PannelMenu.Location = new System.Drawing.Point(0, 80);
            this.PannelMenu.Name = "PannelMenu";
            this.PannelMenu.Size = new System.Drawing.Size(300, 669);
            this.PannelMenu.TabIndex = 9;
            // 
            // Sidebar
            // 
            this.Sidebar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Sidebar.BackColor = System.Drawing.Color.SteelBlue;
            this.Sidebar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Sidebar.BackgroundImage")));
            this.Sidebar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Sidebar.Controls.Add(this.btnCalificaiones);
            this.Sidebar.Controls.Add(this.btnCriterios);
            this.Sidebar.Controls.Add(this.btnMisEstudiantes);
            this.Sidebar.Controls.Add(this.btnSalir);
            this.Sidebar.Controls.Add(this.btnAnioEscolar);
            this.Sidebar.Controls.Add(this.btnEstudiantes);
            this.Sidebar.Controls.Add(this.btnPlantelDocente);
            this.Sidebar.Controls.Add(this.btnInicio);
            this.Sidebar.Controls.Add(this.LineaSidebar);
            this.Sidebar.Controls.Add(this.label2);
            this.Sidebar.GradientBottomLeft = System.Drawing.Color.SteelBlue;
            this.Sidebar.GradientBottomRight = System.Drawing.Color.SteelBlue;
            this.Sidebar.GradientTopLeft = System.Drawing.Color.SteelBlue;
            this.Sidebar.GradientTopRight = System.Drawing.Color.Black;
            this.Sidebar.Location = new System.Drawing.Point(16, 24);
            this.Sidebar.Name = "Sidebar";
            this.Sidebar.Quality = 10;
            this.Sidebar.Size = new System.Drawing.Size(270, 672);
            this.Sidebar.TabIndex = 2;
            // 
            // btnCalificaiones
            // 
            this.btnCalificaiones.BackColor = System.Drawing.Color.Transparent;
            this.btnCalificaiones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalificaiones.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalificaiones.ForeColor = System.Drawing.Color.White;
            this.btnCalificaiones.IconChar = FontAwesome.Sharp.IconChar.ClipboardCheck;
            this.btnCalificaiones.IconColor = System.Drawing.Color.White;
            this.btnCalificaiones.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCalificaiones.IconSize = 30;
            this.btnCalificaiones.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalificaiones.Location = new System.Drawing.Point(7, 448);
            this.btnCalificaiones.Name = "btnCalificaiones";
            this.btnCalificaiones.Size = new System.Drawing.Size(252, 51);
            this.btnCalificaiones.TabIndex = 23;
            this.btnCalificaiones.Text = "CALIFICACIONES";
            this.btnCalificaiones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalificaiones.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCalificaiones.UseVisualStyleBackColor = false;
            // 
            // btnCriterios
            // 
            this.btnCriterios.BackColor = System.Drawing.Color.Transparent;
            this.btnCriterios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCriterios.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCriterios.ForeColor = System.Drawing.Color.White;
            this.btnCriterios.IconChar = FontAwesome.Sharp.IconChar.Award;
            this.btnCriterios.IconColor = System.Drawing.Color.White;
            this.btnCriterios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCriterios.IconSize = 30;
            this.btnCriterios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCriterios.Location = new System.Drawing.Point(7, 391);
            this.btnCriterios.Name = "btnCriterios";
            this.btnCriterios.Size = new System.Drawing.Size(252, 51);
            this.btnCriterios.TabIndex = 22;
            this.btnCriterios.Text = "CRITERIOS DE EVALUACION";
            this.btnCriterios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCriterios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCriterios.UseVisualStyleBackColor = false;
            this.btnCriterios.Click += new System.EventHandler(this.btnCriterios_Click);
            // 
            // btnMisEstudiantes
            // 
            this.btnMisEstudiantes.BackColor = System.Drawing.Color.Transparent;
            this.btnMisEstudiantes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMisEstudiantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMisEstudiantes.ForeColor = System.Drawing.Color.White;
            this.btnMisEstudiantes.IconChar = FontAwesome.Sharp.IconChar.UserFriends;
            this.btnMisEstudiantes.IconColor = System.Drawing.Color.White;
            this.btnMisEstudiantes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMisEstudiantes.IconSize = 30;
            this.btnMisEstudiantes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMisEstudiantes.Location = new System.Drawing.Point(7, 334);
            this.btnMisEstudiantes.Name = "btnMisEstudiantes";
            this.btnMisEstudiantes.Size = new System.Drawing.Size(252, 51);
            this.btnMisEstudiantes.TabIndex = 21;
            this.btnMisEstudiantes.Text = "MIS ESTUDIANTES";
            this.btnMisEstudiantes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMisEstudiantes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMisEstudiantes.UseVisualStyleBackColor = false;
            this.btnMisEstudiantes.Click += new System.EventHandler(this.btnMisEstudiantes_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Transparent;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.btnSalir.IconColor = System.Drawing.Color.White;
            this.btnSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSalir.IconSize = 30;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(7, 505);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(252, 51);
            this.btnSalir.TabIndex = 20;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnAnioEscolar
            // 
            this.btnAnioEscolar.BackColor = System.Drawing.Color.Transparent;
            this.btnAnioEscolar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnioEscolar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnioEscolar.ForeColor = System.Drawing.Color.White;
            this.btnAnioEscolar.IconChar = FontAwesome.Sharp.IconChar.BookReader;
            this.btnAnioEscolar.IconColor = System.Drawing.Color.White;
            this.btnAnioEscolar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAnioEscolar.IconSize = 30;
            this.btnAnioEscolar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnioEscolar.Location = new System.Drawing.Point(7, 276);
            this.btnAnioEscolar.Name = "btnAnioEscolar";
            this.btnAnioEscolar.Size = new System.Drawing.Size(252, 51);
            this.btnAnioEscolar.TabIndex = 19;
            this.btnAnioEscolar.Text = "AÑO ESCOLAR";
            this.btnAnioEscolar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnioEscolar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAnioEscolar.UseVisualStyleBackColor = false;
            this.btnAnioEscolar.Click += new System.EventHandler(this.btnAnioEscolar_Click);
            // 
            // btnEstudiantes
            // 
            this.btnEstudiantes.BackColor = System.Drawing.Color.Transparent;
            this.btnEstudiantes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEstudiantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstudiantes.ForeColor = System.Drawing.Color.White;
            this.btnEstudiantes.IconChar = FontAwesome.Sharp.IconChar.UserFriends;
            this.btnEstudiantes.IconColor = System.Drawing.Color.White;
            this.btnEstudiantes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEstudiantes.IconSize = 30;
            this.btnEstudiantes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEstudiantes.Location = new System.Drawing.Point(7, 219);
            this.btnEstudiantes.Name = "btnEstudiantes";
            this.btnEstudiantes.Size = new System.Drawing.Size(252, 51);
            this.btnEstudiantes.TabIndex = 18;
            this.btnEstudiantes.Text = "ESTUDIANTES";
            this.btnEstudiantes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEstudiantes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEstudiantes.UseVisualStyleBackColor = false;
            this.btnEstudiantes.Click += new System.EventHandler(this.btnEstudiantes_Click);
            // 
            // btnPlantelDocente
            // 
            this.btnPlantelDocente.BackColor = System.Drawing.Color.Transparent;
            this.btnPlantelDocente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlantelDocente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlantelDocente.ForeColor = System.Drawing.Color.White;
            this.btnPlantelDocente.IconChar = FontAwesome.Sharp.IconChar.ChalkboardTeacher;
            this.btnPlantelDocente.IconColor = System.Drawing.Color.White;
            this.btnPlantelDocente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPlantelDocente.IconSize = 30;
            this.btnPlantelDocente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPlantelDocente.Location = new System.Drawing.Point(7, 162);
            this.btnPlantelDocente.Name = "btnPlantelDocente";
            this.btnPlantelDocente.Size = new System.Drawing.Size(252, 51);
            this.btnPlantelDocente.TabIndex = 17;
            this.btnPlantelDocente.Text = "PLANTEL ESTUDIANTIL";
            this.btnPlantelDocente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPlantelDocente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPlantelDocente.UseVisualStyleBackColor = false;
            this.btnPlantelDocente.Click += new System.EventHandler(this.btnPlantelDocente_Click);
            // 
            // btnInicio
            // 
            this.btnInicio.BackColor = System.Drawing.Color.Transparent;
            this.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicio.ForeColor = System.Drawing.Color.White;
            this.btnInicio.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.btnInicio.IconColor = System.Drawing.Color.White;
            this.btnInicio.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnInicio.IconSize = 30;
            this.btnInicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInicio.Location = new System.Drawing.Point(7, 104);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(252, 51);
            this.btnInicio.TabIndex = 15;
            this.btnInicio.Text = "INICIO";
            this.btnInicio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInicio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInicio.UseVisualStyleBackColor = false;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // LineaSidebar
            // 
            this.LineaSidebar.BackColor = System.Drawing.Color.Transparent;
            this.LineaSidebar.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.LineaSidebar.LineThickness = 1;
            this.LineaSidebar.Location = new System.Drawing.Point(7, 68);
            this.LineaSidebar.Name = "LineaSidebar";
            this.LineaSidebar.Size = new System.Drawing.Size(252, 1);
            this.LineaSidebar.TabIndex = 7;
            this.LineaSidebar.Transparency = 255;
            this.LineaSidebar.Vertical = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(96, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "MENU";
            // 
            // MenuTop
            // 
            this.MenuTop.BackColor = System.Drawing.Color.SteelBlue;
            this.MenuTop.Controls.Add(this.Restaurar);
            this.MenuTop.Controls.Add(this.Minimizar);
            this.MenuTop.Controls.Add(this.Maximizar);
            this.MenuTop.Controls.Add(this.Salir);
            this.MenuTop.Controls.Add(this.label1);
            this.MenuTop.Controls.Add(this.PtbxMenuSidebar);
            this.MenuTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.MenuTop.Location = new System.Drawing.Point(0, 0);
            this.MenuTop.Name = "MenuTop";
            this.MenuTop.Size = new System.Drawing.Size(1370, 80);
            this.MenuTop.TabIndex = 8;
            // 
            // Restaurar
            // 
            this.Restaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Restaurar.Image = ((System.Drawing.Image)(resources.GetObject("Restaurar.Image")));
            this.Restaurar.Location = new System.Drawing.Point(1281, 24);
            this.Restaurar.Name = "Restaurar";
            this.Restaurar.Size = new System.Drawing.Size(30, 30);
            this.Restaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Restaurar.TabIndex = 5;
            this.Restaurar.TabStop = false;
            this.Restaurar.Visible = false;
            this.Restaurar.Click += new System.EventHandler(this.Restaurar_Click);
            // 
            // Minimizar
            // 
            this.Minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Minimizar.Image = ((System.Drawing.Image)(resources.GetObject("Minimizar.Image")));
            this.Minimizar.Location = new System.Drawing.Point(1245, 24);
            this.Minimizar.Name = "Minimizar";
            this.Minimizar.Size = new System.Drawing.Size(30, 30);
            this.Minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Minimizar.TabIndex = 4;
            this.Minimizar.TabStop = false;
            this.Minimizar.Click += new System.EventHandler(this.Minimizar_Click);
            // 
            // Maximizar
            // 
            this.Maximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Maximizar.Image = ((System.Drawing.Image)(resources.GetObject("Maximizar.Image")));
            this.Maximizar.Location = new System.Drawing.Point(1281, 24);
            this.Maximizar.Name = "Maximizar";
            this.Maximizar.Size = new System.Drawing.Size(30, 30);
            this.Maximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Maximizar.TabIndex = 3;
            this.Maximizar.TabStop = false;
            this.Maximizar.Click += new System.EventHandler(this.Maximizar_Click);
            // 
            // Salir
            // 
            this.Salir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Salir.Image = ((System.Drawing.Image)(resources.GetObject("Salir.Image")));
            this.Salir.Location = new System.Drawing.Point(1317, 24);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(30, 30);
            this.Salir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Salir.TabIndex = 2;
            this.Salir.TabStop = false;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(70, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(529, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "UNIDAD EDUCATIVA \"CARLOS BELTRAN MORALES\"";
            // 
            // PtbxMenuSidebar
            // 
            this.PtbxMenuSidebar.Image = ((System.Drawing.Image)(resources.GetObject("PtbxMenuSidebar.Image")));
            this.PtbxMenuSidebar.Location = new System.Drawing.Point(34, 24);
            this.PtbxMenuSidebar.Name = "PtbxMenuSidebar";
            this.PtbxMenuSidebar.Size = new System.Drawing.Size(30, 30);
            this.PtbxMenuSidebar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PtbxMenuSidebar.TabIndex = 0;
            this.PtbxMenuSidebar.TabStop = false;
            // 
            // MoverDashboard
            // 
            this.MoverDashboard.Fixed = true;
            this.MoverDashboard.Horizontal = true;
            this.MoverDashboard.TargetControl = this.MenuTop;
            this.MoverDashboard.Vertical = true;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.PanelContenido);
            this.Controls.Add(this.PannelMenu);
            this.Controls.Add(this.MenuTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPrincipal";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.PannelMenu.ResumeLayout(false);
            this.Sidebar.ResumeLayout(false);
            this.Sidebar.PerformLayout();
            this.MenuTop.ResumeLayout(false);
            this.MenuTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Restaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Maximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Salir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PtbxMenuSidebar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelContenido;
        private System.Windows.Forms.Panel PannelMenu;
        private Bunifu.Framework.UI.BunifuGradientPanel Sidebar;
        private FontAwesome.Sharp.IconButton btnInicio;
        private Bunifu.Framework.UI.BunifuSeparator LineaSidebar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel MenuTop;
        private System.Windows.Forms.PictureBox Restaurar;
        private System.Windows.Forms.PictureBox Minimizar;
        private System.Windows.Forms.PictureBox Maximizar;
        private System.Windows.Forms.PictureBox Salir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox PtbxMenuSidebar;
        private FontAwesome.Sharp.IconButton btnSalir;
        private FontAwesome.Sharp.IconButton btnAnioEscolar;
        private FontAwesome.Sharp.IconButton btnEstudiantes;
        private FontAwesome.Sharp.IconButton btnPlantelDocente;
        private Bunifu.Framework.UI.BunifuDragControl MoverDashboard;
        private FontAwesome.Sharp.IconButton btnCriterios;
        private FontAwesome.Sharp.IconButton btnMisEstudiantes;
        private FontAwesome.Sharp.IconButton btnCalificaiones;
    }
}