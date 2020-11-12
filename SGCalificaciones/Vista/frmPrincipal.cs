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
        public frmPrincipal()
        {
            InitializeComponent();
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
            AbrirFormInPanel(new Vista.frmInicio());
        }

        private void btnPlantelDocente_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Vista.Administrativo.frmGestionPlantel());
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            this.Close();
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
            AbrirFormInPanel(new Vista.frmInicio());
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
            this.Close();
        }

    }
}
