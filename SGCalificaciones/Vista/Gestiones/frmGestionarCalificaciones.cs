using System;
using SGCalificaciones.Controlador;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SGCalificaciones.Data;

namespace SGCalificaciones.Vista.Gestiones
{
    public partial class frmGestionarCalificaciones : Form
    {
        EstudianteController _objEstudiante = new EstudianteController();
        PlantelController _obj_Plantel = new PlantelController();
        BimestreController _objBimetre = new BimestreController();
        CalificacionesController _objCalif = new CalificacionesController();

        private bool _esNuevo;

        private int _Ci;
        public frmGestionarCalificaciones(int ci)
        {
            InitializeComponent();
            _Ci = ci;
        }
        private void Listar()
        {
            int pIdCurso = _obj_Plantel.cursoPlantel(_Ci);
            CargarNombreCompleto();
            CargarBimestre();
            //bimestreBindingSource.DataSource = _objBimetre.Listar("");
        }
        private void CargarNombreCompleto()
        {
            BdCalificacionesEntities _entity = new BdCalificacionesEntities();
            int pIdCurso = _obj_Plantel.cursoPlantel(_Ci);
            var r = from Estudiante in _entity.Estudiante
                    where Estudiante.id_curso==pIdCurso
                    select new
                         {
                             nro_carnet = Estudiante.nro_carnet,
                             NombreCompleto = Estudiante.nombre + " " + Estudiante.ap_paterno
                         };
            
            cmbEstudiante.ValueMember = "nro_carnet";
            cmbEstudiante.DisplayMember = "NombreCompleto";
            cmbEstudiante.DataSource = r.ToList();

           //label11.Text = Convert.ToString(cmbEstudiante.ValueMember);
            //_db.Medicamento.Where(x => x.NomMed.Contains(pBuscar)).ToList();
        }

        private void CargarBimestre()
        {
            int anio = DateTime.Today.Year;
            BdCalificacionesEntities _entity = new BdCalificacionesEntities();
            var r = from Bimestre in _entity.Bimestre
                    where Bimestre.bimestre.Contains(Convert.ToString(anio))
                    select new
                    {
                        id_bimestre = Bimestre.id_bimestre,
                        bimestre = Bimestre.bimestre
                    };

            cmbBimestre.ValueMember = "id_bimestre";
            cmbBimestre.DisplayMember = "bimestre";
            cmbBimestre.DataSource = r.ToList();
        }

        private bool EsNuevo()
        {
            if (txtLenguaje.Text == "0" && txtSociales.Text == "0" && txtEFisica.Text == "0" && txtEMusical.Text == "0" && txtArtesPlasticas.Text == "0" && txtMatematica.Text == "0" && txtTecnica.Text == "0" && txtNaturales.Text == "0" && txtReligion.Text == "0")
            {
                MessageBox.Show("true");
                return true;
            }   
            else
            {
                MessageBox.Show("false");
                return false;
            }   
        }

        private void ResgistraOrModificar()
        {
            int pCi = Convert.ToInt32(lblCarnet.Text), pBim = Convert.ToInt32(lblIdBimestre.Text);
            if (_esNuevo)
            {
                Registrar(txtLenguaje, 1, pCi,pBim);
                Registrar(txtSociales, 2, pCi, pBim);
                Registrar(txtEFisica, 3, pCi, pBim);
                Registrar(txtEMusical, 5, pCi, pBim);
                Registrar(txtArtesPlasticas, 6, pCi, pBim);
                Registrar(txtMatematica, 7, pCi, pBim);
                Registrar(txtTecnica, 8, pCi, pBim);
                Registrar(txtNaturales, 9, pCi, pBim);
                Registrar(txtReligion, 10, pCi, pBim);
                MessageBox.Show("REGISTRO  SATISFACTO", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Modificar(txtLenguaje, 1, pCi, pBim);
                Modificar(txtSociales, 2, pCi, pBim);
                Modificar(txtEFisica, 3, pCi, pBim);
                Modificar(txtEMusical, 5, pCi, pBim);
                Modificar(txtArtesPlasticas, 6, pCi, pBim);
                Modificar(txtMatematica, 7, pCi, pBim);
                Modificar(txtTecnica, 8, pCi, pBim);
                Modificar(txtNaturales, 9, pCi, pBim);
                Modificar(txtReligion, 10, pCi, pBim);
                MessageBox.Show("REGISTRO MODIFICADO SATISFACTORIAMENTE", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        private void frmGestionarCalificaciones_Load(object sender, EventArgs e)
        {
            Listar();
            
        }

        private void Registrar(TextBox txtCalif, int IdMat, int Ci, int IdBim)
        {
            calificacionesBindingSource.AddNew();
            var reg = (Calificaciones)calificacionesBindingSource.Current;
            reg.nro_carnet = Ci;
            reg.id_materia = IdMat;
            reg.id_bimestre = IdBim;
            reg.id_criterio = 1;
            reg.calificacion = Convert.ToInt32(txtCalif.Text);
            _objCalif.Insertar(reg);
        }
        private void Modificar(TextBox txtCalif, int IdMat, int Ci, int IdBim)
        {
           
            int idCalif=_objCalif.IdCalificacion(Ci,IdMat,IdBim);
            calificacionesBindingSource.DataSource = _objCalif.BuscarPorPK(idCalif);
            var reg = (Calificaciones)calificacionesBindingSource.Current;
            reg.nro_carnet = Ci;
            reg.id_materia = IdMat;
            reg.id_bimestre = IdBim;
            reg.id_criterio = 1;
            reg.calificacion = Convert.ToInt32(txtCalif.Text);
            _objCalif.Modificar(reg);
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            ResgistraOrModificar();
            HabilitarTxt(false);
        }

        private void HabilitarTxt(bool  b)
        {
            txtLenguaje.Enabled = b;
            txtSociales.Enabled = b;
            txtEFisica.Enabled = b;
            txtEMusical.Enabled = b;
            txtArtesPlasticas.Enabled = b;
            txtMatematica.Enabled = b;
            txtTecnica.Enabled = b;
            txtNaturales.Enabled = b;
            txtReligion.Enabled = b;
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            HabilitarTxt(true);
            lblCarnet.Text = Convert.ToString(cmbEstudiante.SelectedValue);
            int pCi = Convert.ToInt32(lblCarnet.Text), pBim = Convert.ToInt32(lblIdBimestre.Text);

                txtLenguaje.Text = Convert.ToString(_objCalif.ListarCalif(pCi, 1,pBim));
                txtSociales.Text = Convert.ToString(_objCalif.ListarCalif(pCi, 2, pBim));
                txtEFisica.Text = Convert.ToString(_objCalif.ListarCalif(pCi, 3, pBim));
                txtEMusical.Text = Convert.ToString(_objCalif.ListarCalif(pCi, 5, pBim));
                txtArtesPlasticas.Text = Convert.ToString(_objCalif.ListarCalif(pCi, 6, pBim));
                txtMatematica.Text = Convert.ToString(_objCalif.ListarCalif(pCi, 7, pBim));
                txtTecnica.Text = Convert.ToString(_objCalif.ListarCalif(pCi, 8, pBim));
                txtNaturales.Text = Convert.ToString(_objCalif.ListarCalif(pCi, 9, pBim));
                txtReligion.Text = Convert.ToString(_objCalif.ListarCalif(pCi, 10, pBim));

            _esNuevo = EsNuevo();
        }

        private void cmbBimestre_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblIdBimestre.Text = Convert.ToString(cmbBimestre.SelectedValue);
        }

        void SoloNumeros(KeyPressEventArgs e)
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

        private void txtReligion_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }
    }
}
