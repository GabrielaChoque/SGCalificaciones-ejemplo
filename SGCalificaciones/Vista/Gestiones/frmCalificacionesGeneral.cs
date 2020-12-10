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
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

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

        private void CargarNotaF()
        {
            int i = 0, Carnet;
            foreach (DataGridViewRow Fila in dgvCalificaciones.Rows)
            {
                Carnet = Convert.ToInt32(dgvCalificaciones.Rows[i].Cells[0].Value);
                dgvCalificaciones.Rows[i].Cells["NotaFinal"].Value = _objCalif.promedio(Carnet);
                if (_objCalif.promedio(Carnet) >= 51)
                {
                    dgvCalificaciones.Rows[i].Cells["Estado"].Value = "APROBADO";
                }
                else
                {
                    dgvCalificaciones.Rows[i].Cells["Estado"].Value = "REPROBADO";
                    dgvCalificaciones.Rows[i].DefaultCellStyle.BackColor = System.Drawing.Color.Coral;
                    dgvCalificaciones.Rows[i].DefaultCellStyle.ForeColor = System.Drawing.Color.Red;
                }
                i++;
            }
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
            CargarNotaF();
        }
        private void dgvCalificaciones_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && this.dgvCalificaciones.Columns[e.ColumnIndex].Name == "Calif" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                DataGridViewButtonCell celBoton = this.dgvCalificaciones.Rows[e.RowIndex].Cells["Calif"] as DataGridViewButtonCell;
                System.Drawing.Icon icoNotas = new System.Drawing.Icon(Environment.CurrentDirectory + @"\\notas.ico"); //Recuerden colocar su icono en la carpeta debug de su proyecto
                e.Graphics.DrawIcon(icoNotas, e.CellBounds.Left + 3, e.CellBounds.Top + 3);

                this.dgvCalificaciones.Rows[e.RowIndex].Height = icoNotas.Height + 8;
                this.dgvCalificaciones.Columns[e.ColumnIndex].Width = icoNotas.Width + 8;

                e.Handled = true;
            }
        }

        private void dgvCalificaciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgvCalificaciones.Columns[e.ColumnIndex].Name == "Calif")
            {
                Reportes.frmLibreta frm = new Reportes.frmLibreta(nro_carnetLabel1.Text, nombreLabel1.Text + " " + ap_paternoLabel1.Text + " " + ap_maternoLabel1.Text);
                frm.Show();
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            dgvCalificaciones.Columns["Calif"].Visible = true; 
            dgvCalificaciones.Columns["NotaFinal"].Visible = true;
            dgvCalificaciones.Columns["Estado"].Visible = true;
            CargarNotaF();
        }
    }
}
