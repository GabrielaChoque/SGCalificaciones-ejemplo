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
            int i = 0, notaF;
            foreach (DataGridViewRow Fila in dgvCalificaciones.Rows)
            {
                notaF = Convert.ToInt32(dgvCalificaciones.Rows[i].Cells[0].Value);
                dgvCalificaciones.Rows[i].Cells["NotaFinal"].Value = _objCalif.promedio(notaF);
                if(notaF>=51)
                    dgvCalificaciones.Rows[i].Cells["Estado"].Value = "APROBADO";
                else
                    dgvCalificaciones.Rows[i].Cells["Estado"].Value = "REPROBADO";
                i++;
            }
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

        private void dgvCalificaciones_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && this.dgvCalificaciones.Columns[e.ColumnIndex].Name == "Calif" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                DataGridViewButtonCell celBoton = this.dgvCalificaciones.Rows[e.RowIndex].Cells["Calif"] as DataGridViewButtonCell;
                Icon icoNotas = new Icon(Environment.CurrentDirectory + @"\\notas.ico"); //Recuerden colocar su icono en la carpeta debug de su proyecto
                e.Graphics.DrawIcon(icoNotas, e.CellBounds.Left + 3, e.CellBounds.Top + 3);

                this.dgvCalificaciones.Rows[e.RowIndex].Height = icoNotas.Height + 8;
                this.dgvCalificaciones.Columns[e.ColumnIndex].Width = icoNotas.Width + 8;

                e.Handled = true;
            }
        }
    }
}
