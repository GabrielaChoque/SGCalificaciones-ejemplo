using SGCalificaciones.Controlador;
using SGCalificaciones.Data;
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
        CalificacionesController _objCalif = new CalificacionesController();

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

        private void CargarBimestre()
        {
            //BdCalificacionesEntities _entity = new BdCalificacionesEntities();
            //var r = from Bimestre in _entity.Bimestre
            //        where Bimestre.bimestre.Contains("2020")
            //        select new
            //        {
            //            id_bimestre = Bimestre.id_bimestre,
            //            bimestre = Bimestre.bimestre
            //        };
            int xd = _objCalif.promedio(1111111);
            MessageBox.Show(Convert.ToString(xd));


        }
        private void frmCalificacionesGeneral_Load(object sender, EventArgs e)
        {
            Listar(txtBuscar.Text);
        }

        private void iconPictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            int xd , cant = dgvCalificaciones.Rows.Count;
            //MessageBox.Show(Convert.ToString(xd));

            
            int i = 0;
            foreach (DataGridViewRow Fila in dgvCalificaciones.Rows)
            {
                
                xd = Convert.ToInt32(dgvCalificaciones.Rows[i].Cells[0].Value);
                dgvCalificaciones.Rows[i].Cells[9].Value = _objCalif.promedio(xd);
                i++;
            }
        }
    }
}
