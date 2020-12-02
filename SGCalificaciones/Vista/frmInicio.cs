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

namespace SGCalificaciones.Vista
{
    public partial class frmInicio : Form
    {
        PlantelController _objUsuario = new PlantelController();

        private int _Ci;
        private bool _esProfesor;
        public frmInicio(int Ci, bool esProfesor)
        {
            InitializeComponent();
            _Ci = Ci;
            _esProfesor = esProfesor;
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmInicio_Load(object sender, EventArgs e)
        {
            if (_esProfesor)
               lblNombrePlantel.Text = "Prof."+Convert.ToString(_objUsuario.nombrePlantel(_Ci));
            else
               lblNombrePlantel.Text = "Admin." + Convert.ToString(_objUsuario.nombrePlantel(_Ci));
        }
    }
}
