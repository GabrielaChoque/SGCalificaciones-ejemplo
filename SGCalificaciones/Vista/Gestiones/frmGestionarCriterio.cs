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
    public partial class frmGestionarCriterio : Form
    {
        CriterioController _objUsuario = new CriterioController();
        PlantelController _obj_Plantel = new PlantelController();

        private string _User;
        private string _Pass;
        public frmGestionarCriterio(string usuario, string contrasenia)
        {
            InitializeComponent();
            _User = usuario;
            _Pass = contrasenia;
        }
        private void frmGestionarCriterio_Load(object sender, EventArgs e)
        {
            Listar(txtBuscar.Text);
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            frmCriterio AddUsuario = new frmCriterio();
            AddUsuario.ShowDialog();
            Listar(txtBuscar.Text);
        }

        private void Listar(string pBuscar)
        {
            int pCi = _obj_Plantel.CiPlantel(_User,_Pass);
            criterioBindingSource.DataSource = _objUsuario.Listar(pBuscar, pCi);
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            frmCriterio AddUser = new frmCriterio(id_criterioLabel1.Text);
            AddUser.ShowDialog();
            _objUsuario = new CriterioController();
            Listar(txtBuscar.Text);
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("¿ESTA SEGURO DE ELIMINAR ESTE REGISTRO?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                _objUsuario.Eliminar(Convert.ToInt32(id_criterioLabel1.Text));
                _objUsuario = new CriterioController();
                Listar(txtBuscar.Text);
            }
        }
        private void TxtBusqueda_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                Listar(txtBuscar.Text);
            }
        }

        private void pbxSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
