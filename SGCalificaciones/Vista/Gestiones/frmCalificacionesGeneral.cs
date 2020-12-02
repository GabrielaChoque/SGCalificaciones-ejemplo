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

namespace SGCalificaciones.Vista.Gestiones
{
    public partial class frmCalificacionesGeneral : Form
    {
        EstudianteController _objUsuario = new EstudianteController();
        PlantelController _obj_Plantel = new PlantelController();

        private int _Ci;
        public frmCalificacionesGeneral(int ci)
        {
            InitializeComponent();
            _Ci = ci;
        }
        private void Listar(string pBuscar)
        {
            int pIdCurso = _obj_Plantel.cursoPlantel(_Ci);
            estudianteBindingSource.DataSource = _objUsuario.ListarMisEstudiantes(pBuscar, pIdCurso);
        }

        private void frmCalificacionesGeneral_Load(object sender, EventArgs e)
        {
            Listar(txtBuscar.Text);
        }

        private void iconPictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
