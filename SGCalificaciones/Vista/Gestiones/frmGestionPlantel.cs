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

namespace SGCalificaciones.Vista.Administrativo
{
    public partial class frmGestionPlantel : Form
    {
        PlantelController _objUsuario = new PlantelController();
        public frmGestionPlantel()
        {
            InitializeComponent();
        }
        private void frmGestionPlantel_Load(object sender, EventArgs e)
        {
            Listar(txtBuscar.Text);
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            frmGestionPlantel AddUsuario = new frmGestionPlantel();
            AddUsuario.ShowDialog();
            Listar(txtBuscar.Text);

        }

        private void Listar(string pBuscar)
        {
            plantel_EducativoBindingSource.DataSource = _objUsuario.Listar(pBuscar);
            //proveedorDataGridView.Columns["imagen"].Visible = false;
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            frmPlantel AddUser = new frmPlantel(nro_carnetLabel1.Text);
            AddUser.ShowDialog();
            _objUsuario = new PlantelController();
            Listar(txtBuscar.Text);
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("¿ESTA SEGURO DE ELIMINAR ESTE REGISTRO?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                _objUsuario.Eliminar(Convert.ToInt32(nro_carnetLabel1.Text));
                _objUsuario = new PlantelController();
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
    }
}

