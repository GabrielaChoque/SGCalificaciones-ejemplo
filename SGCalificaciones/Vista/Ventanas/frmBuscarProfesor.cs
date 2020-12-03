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
    public partial class frmBuscarProfesor : Form
    {
        PlantelController _objPlantel = new PlantelController();
        public frmBuscarProfesor()
        {
            InitializeComponent();
        }
        private void Listar(string pBuscar)
        {
            plantel_EducativoBindingSource.DataSource = _objPlantel.Listar(pBuscar);
        }
        private void frmBuscarProfesor_Load(object sender, EventArgs e)
        {
            Listar(txtBuscar.Text);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
