using System;
using SGCalificaciones.Controlador;
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
    public partial class frmGestionarCalificaciones : Form
    {
        EstudianteController _objEstudiante = new EstudianteController();
        PlantelController _obj_Plantel = new PlantelController();

        private int _Ci;
        public frmGestionarCalificaciones(int ci)
        {
            InitializeComponent();
            _Ci = ci;
        }
        private void Listar()
        {
            int pIdCurso = _obj_Plantel.cursoPlantel(_Ci);
            //estudianteBindingSource.DataSource = _objUsuario.ListarMisEstudiantes("", pIdCurso);
          /// estudianteBindingSource.DataSource = _objEstudiante.ListarParaCalificar(pIdCurso);
        }

        private void frmGestionarCalificaciones_Load(object sender, EventArgs e)
        {
          //  Listar();
        }
    }
}
