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
        EstudianteController _objUsuario = new EstudianteController();
        private string _cuenta;
        private bool _esNuevo;
        public frmEstudiante()
        {
            _esNuevo = true;
            InitializeComponent();
        }
        public frmEstudiante(string pCuenta)
        {
            _cuenta = pCuenta;
            _esNuevo = false;
            InitializeComponent();
        }
        private void frmEstudiante_Load(object sender, EventArgs e)
        {
            if (_esNuevo)
            {
                estudianteBindingSource.AddNew();
                label1.Text = "REGISTRAR NUEVO";
            }
            else
            {
                estudianteBindingSource.DataSource = _objUsuario.BuscarPorPK(Convert.ToInt32(_cuenta));
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

        private void Nro_carnetTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar))
                e.Handled = false;
                else if (char.IsControl(e.KeyChar))
                e.Handled = false;
                else if (char.IsSeparator(e.KeyChar)) 
                    e.Handled = false;
                else e.Handled = true;

        }

        private void NombreTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
                e.Handled = false;
            else if (char.IsControl(e.KeyChar))
                e.Handled = false;
            else if (char.IsSeparator(e.KeyChar))
                e.Handled = false;
            else e.Handled = true;
        }

        private void Ap_maternoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
                e.Handled = false;
            else if (char.IsControl(e.KeyChar))
                e.Handled = false;
            else if (char.IsSeparator(e.KeyChar))
                e.Handled = false;
            else e.Handled = true;
        }

        private void Ap_paternoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
                e.Handled = false;
            else if (char.IsControl(e.KeyChar))
                e.Handled = false;
            else if (char.IsSeparator(e.KeyChar))
                e.Handled = false;
            else e.Handled = true;
        }

        private void CelularTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void CelularTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar))
                e.Handled = false;
            else if (char.IsControl(e.KeyChar))
                e.Handled = false;
            else if (char.IsSeparator(e.KeyChar))
                e.Handled = false;
            else e.Handled = true;
        }
    }
}
