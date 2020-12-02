using SGCalificaciones.Controlador;
using SGCalificaciones.Vista.Ventanas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGCalificaciones.Vista.Gestiones
{
    public partial class frmGestionarAnioEscolar : Form
    {
        BimestreController _objBimestre = new BimestreController();
        CursoController _objCurso = new CursoController();
        MateriaController _objMateria = new MateriaController();

        public frmGestionarAnioEscolar()
        {
            InitializeComponent();
        }

        private void iconPictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    
        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            frmPlantel AddUsuario = new frmPlantel();
            AddUsuario.ShowDialog();
            Listar();

        }

        private void VisibilizarBotones(Button btnGuardar, Button btnCancelar, Button btnNuevo, bool esEditar)
        {
            if (esEditar)
            {
                btnCancelar.Visible = true;
                btnGuardar.Visible = true;
                btnNuevo.Visible = false;
            }
            else
            {
                btnCancelar.Visible = false;
                btnGuardar.Visible = false;
                btnNuevo.Visible = true;
                Listar();
            }
            
        }
        private void Listar()
        {
            bimestreBindingSource.DataSource = _objBimestre.Listar("");
            materiaBindingSource.DataSource = _objMateria.Listar("");
            cursoBindingSource.DataSource = _objCurso.Listar("");
        }

        private void frmGestionarAnioEscolar_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void btnNuevoBim_Click(object sender, EventArgs e)
        {
            VisibilizarBotones(btnGuardarBim,btnCancelarBim,btnNuevoBim,true);
            id_bimestreTextBox.Text = "";
            bimestreTextBox.Text = "";

            
        }

        private void btnCancelarBim_Click(object sender, EventArgs e)
        {
            VisibilizarBotones(btnGuardarBim, btnCancelarBim, btnNuevoBim, false);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            VisibilizarBotones(btnGuardarBim, btnCancelarBim, btnNuevoBim, true);
        }

        private void btnNuevoCurso_Click(object sender, EventArgs e)
        {
            VisibilizarBotones(btnGuardarCurso, btnCancelarCurso,btnNuevoCurso, true);
            btnBuscarProfesor.Enabled = true;

            id_cursoTextBox.Text = "";
            nom_cursoTextBox.Text = "";
            paraleloTextBox.Text = "";
            nro_carnetTextBox.Text = "";
        }

        private void btnNuevoMat_Click(object sender, EventArgs e)
        {
            VisibilizarBotones(btnGuardarMat, btnCancelarMat, btnNuevoMat, true);

            id_materiaTextBox.Text = "";
            nombre_materiaTextBox.Text = "";
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            VisibilizarBotones(btnGuardarMat, btnCancelarMat, btnNuevoMat, true);
        }

        private void btnCancelarMat_Click(object sender, EventArgs e)
        {
            VisibilizarBotones(btnGuardarMat, btnCancelarMat,btnNuevoMat,false);
        }

        private void btnCancelarCurso_Click(object sender, EventArgs e)
        {
            VisibilizarBotones(btnGuardarCurso, btnCancelarCurso, btnNuevoCurso, false);
            btnBuscarProfesor.Enabled = false;
        }

        private void btnEditarCurso_Click(object sender, EventArgs e)
        {
            VisibilizarBotones(btnGuardarMat, btnCancelarMat, btnNuevoCurso, true);
            btnBuscarProfesor.Enabled = true;
        }
    }
}
