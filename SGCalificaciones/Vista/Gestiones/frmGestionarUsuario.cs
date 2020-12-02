using SGCalificaciones.Controlador;
using SGCalificaciones.Data;
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
    public partial class frmGestionarUsuario : Form
    {
        PlantelController _obj_Plantel = new PlantelController();

        private string _User;
        private string _Pass;
        public frmGestionarUsuario(string usuario, string contrasenia)
        {
            InitializeComponent();
            _User = usuario;
            _Pass = contrasenia;
        }

        private void frmGestionarUsuario_Load(object sender, EventArgs e)
        {
            plantel_EducativoBindingSource.DataSource = _obj_Plantel.MostrarDatos(_User, _Pass);
            btnCancelar.Visible = false;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            contraseniaTextBox.Enabled = true;
            txtConfirmar.Visible = true;
            lblConfirmar.Visible = true;
            btnCancelar.Visible = true;
            btnGuardar.Visible = true;
            btnCancelar.Location = new Point(241, 486);
            btnGuardar.Enabled = true;

            contraseniaTextBox.UseSystemPasswordChar = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            contraseniaTextBox.Enabled = false;
            txtConfirmar.Visible = false;
            lblConfirmar.Visible = false;
            btnCancelar.Visible = false;
            btnGuardar.Visible = false;
        }
        private Plantel_Educativo CargarDatos()
        {
            var reg = (Plantel_Educativo)plantel_EducativoBindingSource.Current;
            return reg;
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (contraseniaTextBox.Text == txtConfirmar.Text && contraseniaTextBox.Text.Length>=8)
            {
                var reg = CargarDatos();
                _obj_Plantel.Modificar(reg);
                MessageBox.Show("MODIFICADO SATISFACTORIAMENTE", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnCancelar.Visible = false;
                btnGuardar.Visible = false;
                contraseniaTextBox.Enabled = false;
                txtConfirmar.Visible = false;
                lblConfirmar.Visible = false;
                contraseniaTextBox.UseSystemPasswordChar = true;
            }
            else
            {
                MessageBox.Show("INGRESE CORRECTAMENTE LA NUEVA CONTRASEÑA", "AVISO!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void iconPictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
