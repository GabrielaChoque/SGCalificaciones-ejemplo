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
    public partial class frmPlantel : Form
    {
        PlantelController _objUsuario = new PlantelController();
        private string _cuenta;
        private bool _esNuevo;
        public frmPlantel()
        {
            _esNuevo = true;
            InitializeComponent();
        }
        public frmPlantel(string pCuenta)
        {
            _cuenta = pCuenta;
            _esNuevo = false;
            InitializeComponent();
        }

        private void UserPass()
        {
            usuarioLabel1.Text = nro_carnetTextBox.Text;
            contraseniaLabel1.Text = nro_carnetTextBox.Text;
        }
        private void frmPlantel_Load(object sender, EventArgs e)
        {
            if (_esNuevo)
            {
                plantel_EducativoBindingSource.AddNew();
                label1.Text = "REGISTRAR NUEVO";
            }
            else
            {
                plantel_EducativoBindingSource.DataSource = _objUsuario.BuscarPorPK(Convert.ToInt32(_cuenta));
                label1.Text = "MODIFICAR";
            }
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                var reg = CargarDatos();
                if (_esNuevo)
                {
                    if (_objUsuario.Insertar(reg))
                    {
                        MessageBox.Show("REGISTRO SATISFACTORIAMENTE", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                    else
                    { MessageBox.Show("YA EXISTE UN USUARIO CON CI: '" + "'", "AVISO!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning); }

                }
                else
                {
                    if (_objUsuario.Modificar(reg))
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

        private Plantel_Educativo CargarDatos()
        {
            var reg = (Plantel_Educativo)plantel_EducativoBindingSource.Current;
            return reg;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void nro_carnetTextBox_TextChanged(object sender, EventArgs e)
        {
            UserPass();
        }
    }
}
