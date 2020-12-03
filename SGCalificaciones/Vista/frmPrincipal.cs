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

using System.Runtime.InteropServices;

namespace SGCalificaciones.Vista
{
    public partial class frmPrincipal : Form
    {
        PlantelController _objPlantel = new PlantelController();

        private bool _esProfesor;
        private int _Ci;
        public frmPrincipal(int ci, bool EsProfesor)
        {
            InitializeComponent();
            _esProfesor = EsProfesor;
            _Ci = ci;
        }

        private void ControlMenu()
        {
            if (_esProfesor)
            {
                btnPlantelDocente.Visible = false;
                btnEstudiantes.Visible = false;
                btnAnioEscolar.Visible = false;

                btnMisEstudiantes.Location = new Point(7, 162);
                btnCriterios.Location = new Point(7, 219);
                btnCalificaiones.Location = new Point(7, 276);
                btnSalir.Location = new Point(7, 334);
            }
            else
            {
                btnMisEstudiantes.Visible = false;
                btnCriterios.Visible = false;
                btnCalificaiones.Visible = false;
                btnSalir.Location = new Point(7, 334);
            }
        }

        //Abrir un formulario dentro del panel de contenido
        private void AbrirFormInPanel(object Formhijo)
        {
            if (this.PanelContenido.Controls.Count > 0)
                this.PanelContenido.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.PanelContenido.Controls.Add(fh);
            this.PanelContenido.Tag = fh;
            fh.Show();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Vista.frmInicio(_Ci,_esProfesor));
        }

        private void btnPlantelDocente_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Vista.Administrativo.frmGestionPlantel());
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Maximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            Restaurar.Visible = true;
            Maximizar.Visible = false;
        }

        private void Restaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            Restaurar.Visible = false;
            Maximizar.Visible = true;
        }

        private void Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            ControlMenu();
            AbrirFormInPanel(new Vista.frmInicio(_Ci,_esProfesor));
            btnPerfil.Text= "(YO) " + Convert.ToString(_objPlantel.nombrePlantel(_Ci));
        }

        private void btnEstudiantes_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Vista.Gestiones.frmGestionarEstudiante());
        }

        private void btnAnioEscolar_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Vista.Gestiones.frmGestionarAnioEscolar());
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMisEstudiantes_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Vista.Gestiones.frmCalificacionesGeneral(_Ci));
        }

        private void btnCriterios_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Vista.Gestiones.frmGestionarCriterio(_Ci));
        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Vista.Gestiones.frmGestionarUsuario(_Ci));
        }

        private void btnCalificaiones_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Vista.Gestiones.frmGestionarCalificaciones(_Ci));
        }
    }
}
