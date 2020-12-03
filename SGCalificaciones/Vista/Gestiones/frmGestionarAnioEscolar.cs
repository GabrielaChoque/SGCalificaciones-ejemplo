using SGCalificaciones.Data;
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

        private bool _EsNuevo;

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

        private void VisibilizarBotones(Button btnGuardar, Button btnCancelar, Button btnNuevo, Button btnEliminar,bool esEditar)
        {
            if (esEditar)
            {
                btnCancelar.Visible = true;
                btnGuardar.Visible = true;
                btnNuevo.Visible = false;
                btnEliminar.Visible = false;
            }
            else
            {
                btnCancelar.Visible = false;
                btnGuardar.Visible = false;
                btnNuevo.Visible = true;
                btnEliminar.Visible = true;
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
            VisibilizarBotones(btnGuardarBim, btnCancelarBim, btnNuevoBim,btnEliminarBim, true);
            id_bimestreTextBox.Text = Convert.ToString(bimestreDataGridView.Rows.Count);
            bimestreTextBox.Text = "";

            _EsNuevo = true;
        }

        private void btnCancelarBim_Click(object sender, EventArgs e)
        {
            VisibilizarBotones(btnGuardarBim, btnCancelarBim, btnNuevoBim, btnEliminarBim, false);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            VisibilizarBotones(btnGuardarBim, btnCancelarBim, btnNuevoBim, btnEliminarBim, true);
            _EsNuevo = false;
        }

        private void btnNuevoCurso_Click(object sender, EventArgs e)
        {
            VisibilizarBotones(btnGuardarCurso, btnCancelarCurso,btnNuevoCurso, btnEliminarCurso,true);
            btnBuscarProfesor.Enabled = true;
            _EsNuevo = true;
            id_cursoTextBox.Text = "";
            nom_cursoTextBox.Text = "";
            paraleloTextBox.Text = "";
            nro_carnetTextBox.Text = "";
        }

        private void btnNuevoMat_Click(object sender, EventArgs e)
        {
            VisibilizarBotones(btnGuardarMat, btnCancelarMat, btnNuevoMat,btnEliminarMat, true);

            id_materiaTextBox.Text = Convert.ToString(materiaDataGridView.Rows.Count);
            nombre_materiaTextBox.Text = "";

            _EsNuevo = true;
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            VisibilizarBotones(btnGuardarMat, btnCancelarMat, btnNuevoMat, btnEliminarMat, true);
            _EsNuevo = false;
        }

        private void btnCancelarMat_Click(object sender, EventArgs e)
        {
            VisibilizarBotones(btnGuardarMat, btnCancelarMat,btnNuevoMat, btnEliminarMat, false);
        }

        private void btnCancelarCurso_Click(object sender, EventArgs e)
        {
            VisibilizarBotones(btnGuardarCurso, btnCancelarCurso, btnNuevoCurso, btnEliminarCurso, false);
            btnBuscarProfesor.Enabled = false;
        }

        private void btnEditarCurso_Click(object sender, EventArgs e)
        {
            VisibilizarBotones(btnGuardarCurso, btnCancelarCurso, btnNuevoCurso, btnEliminarCurso, true);
            btnBuscarProfesor.Enabled = true;
            _EsNuevo = false;
        }
        private Bimestre CargarDatosBimestre()
        {
            var reg = (Bimestre)bimestreBindingSource.Current;
            return reg;
        }
        private void btnGuardarBim_Click(object sender, EventArgs e)
        {
            try
            {
                var reg = CargarDatosBimestre();
                if (_EsNuevo && bimestreTextBox.Text!="")
                {
                    if (_objBimestre.Insertar(reg))
                    {
                        MessageBox.Show("INSERCION SATISFACTORIA", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    if (_objBimestre.Modificar(reg))
                    {
                        MessageBox.Show("MODIFICADO SATISFACTORIAMENTE", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                VisibilizarBotones(btnGuardarBim, btnCancelarBim, btnNuevoBim, btnEliminarBim, false);
                Listar();
            }
            catch (Exception)
            {
                MessageBox.Show("DEBE INTRODUCIR LOS DATOS CORRECTAMENTE!!", "AVISO!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEliminarBim_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("¿ESTA SEGURO DE ELIMINAR ESTE BIMESTRE?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                _objBimestre.Eliminar(Convert.ToInt32(id_bimestreTextBox.Text));
                Listar();
            }
        }
        private Materia CargarDatosMateria()
        {
            var reg = (Materia) materiaBindingSource.Current;
            return reg;
        }
        private void btnGuardarMat_Click(object sender, EventArgs e)
        {
            try
            {
                var reg = CargarDatosMateria();
                if (_EsNuevo)
                {
                    if (_objMateria.Insertar(reg))
                    {
                        MessageBox.Show("INSERCION SATISFACTORIA", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    if (_objMateria.Modificar(reg))
                    {
                        MessageBox.Show("MODIFICADO SATISFACTORIAMENTE", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                VisibilizarBotones(btnGuardarMat, btnCancelarMat, btnNuevoMat, btnEliminarMat, false);
                Listar();
            }
            catch (Exception)
            {
                MessageBox.Show("DEBE INTRODUCIR LOS DATOS CORRECTAMENTE!!", "AVISO!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEliminarMat_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("¿ESTA SEGURO DE ELIMINAR ESTA MATERIA?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                _objMateria.Eliminar(Convert.ToInt32(id_materiaTextBox.Text));
                Listar();
            }
        }

        private void btnBuscarProfesor_Click(object sender, EventArgs e)
        {
            frmBuscarProfesor AbrirfrmBP = new frmBuscarProfesor();
            AbrirfrmBP.ShowDialog();
        }

        private Curso CargarDatosCurso()
        {
            var reg = (Curso)cursoBindingSource.Current;
            return reg;
        }

        private void btnGuardarCurso_Click(object sender, EventArgs e)
        {
            try
            {
                var reg = CargarDatosCurso();
                if (_EsNuevo)
                {
                    if (_objCurso.Insertar(reg))
                    {
                        MessageBox.Show("INSERCION SATISFACTORIA", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    if (_objCurso.Modificar(reg))
                    {
                        MessageBox.Show("MODIFICADO SATISFACTORIAMENTE", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                VisibilizarBotones(btnGuardarMat, btnCancelarMat, btnNuevoMat, btnEliminarMat, false);
                Listar();
            }
            catch (Exception)
            {
                MessageBox.Show("DEBE INTRODUCIR LOS DATOS CORRECTAMENTE!!", "AVISO!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEliminarCurso_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("¿ESTA SEGURO DE ELIMINAR ESTe CURSO?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                _objCurso.Eliminar(Convert.ToInt32(id_cursoTextBox.Text));
                Listar();
            }
        }
    }
}
