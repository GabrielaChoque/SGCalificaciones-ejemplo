using SGCalificaciones.Data;
using SGCalificaciones.Controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGCalificaciones.Vista.Ventanas
{
    public partial class frmEstudiante : Form
    {
        EstudianteController _objEstudiante = new EstudianteController();
        private string _carnet;
        private bool _esNuevo;
        public frmEstudiante()
        {
            _esNuevo = true;
            InitializeComponent();
        }
        public frmEstudiante(string pCarnet)
        {
            _carnet = pCarnet;
            _esNuevo = false;
            InitializeComponent();
        }

        private void frmEstudiante_Load(object sender, EventArgs e)
        {
            cargarCursos();
            if (_esNuevo)
            {
                estudianteBindingSource.AddNew();
                label1.Text = "REGISTRAR NUEVO";
            }
            else
            {
                estudianteBindingSource.DataSource = _objEstudiante.BuscarPorPK(Convert.ToInt32(_carnet));
                label1.Text = "MODIFICAR";
            }
            
        }

        private void cargarCursos()
        {
            BdCalificacionesEntities _entity = new BdCalificacionesEntities();
            var r = from Curso in _entity.Curso
                    select new
                    {
                        id_curso = Curso.id_curso,
                        Cursos = Curso.nom_curso +" '"+ Curso.paralelo + "'"
                    };

            cmbCursos.ValueMember = "id_curso";
            cmbCursos.DisplayMember = "Cursos";
            cmbCursos.DataSource = r.ToList();
        }
        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                var reg = CargarDatos();
                if (_esNuevo)
                {
                    reg.id_curso = Convert.ToInt32(lblIdCurso.Text);
                    if (_objEstudiante.Insertar(reg))
                    {
                        MessageBox.Show("REGISTRO SATISFACTORIAMENTE", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                    else
                    { MessageBox.Show("YA EXISTE UN USUARIO CON CI: '" + "'", "AVISO!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning); }

                }
                else
                {
                    if (_objEstudiante.Modificar(reg))
                    {
                        MessageBox.Show("MODIFICADO SATISFACTORIAMENTE", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("DEBE INTRODUCIR LOS DATOS CORRECTAMENTE!!", "AVISO!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private Estudiante CargarDatos()
        {
            var reg = (Estudiante)estudianteBindingSource.Current;
            //reg.FechaNac = DateTime.Now;
            return reg;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void nro_carnetTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso
                {
                    e.Handled = false;
                }
                else
                {
                    //el resto de teclas pulsadas se desactivan
                    e.Handled = true;
                }
            }
        }

        private void id_cursoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblIdCurso.Text = Convert.ToString(cmbCursos.SelectedValue);
        }
    }
}
