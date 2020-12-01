using SGCalificaciones.Controlador;
using SGCalificaciones.Vista;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGCalificaciones
{
    public partial class frmLogin : Form
    {
        PlantelController _objUsuario = new PlantelController();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string tipoPlantel=_objUsuario.Autenticar(txtUsuario.Text,txtContrasenia.Text);

            switch (tipoPlantel)
            {
                case "Si":
                    this.Hide();
                    frmPrincipal frm = new frmPrincipal(txtUsuario.Text, txtContrasenia.Text,true);
                    frm.ShowDialog();
                    break;
                case "No":
                    this.Hide();
                    frmPrincipal form = new frmPrincipal(txtUsuario.Text, txtContrasenia.Text, false);
                    form.ShowDialog();
                    break;
                case "":
                    MessageBox.Show("LA CUENTA O CONTRASEÑA SON INCORRECTOS", "NO SE PUDO INICIAR SESION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
            }        
        }

        private void TxtUsuario_OnValueChanged(object sender, EventArgs e)
        {

        }
    }
}
