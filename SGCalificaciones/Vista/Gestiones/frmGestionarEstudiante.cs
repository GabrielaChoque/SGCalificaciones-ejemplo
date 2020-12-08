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
    public partial class frmGestionarEstudiante : Form
    {
        EstudianteController _objUsuario = new EstudianteController();
        public frmGestionarEstudiante()
        {
            InitializeComponent();
        }
        
        private void frmGestionarEstudiante_Load(object sender, EventArgs e)
        {
            Listar(txtBuscar.Text);
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            frmEstudiante AddUsuario = new frmEstudiante();
            AddUsuario.ShowDialog();
            Listar(txtBuscar.Text);
        }

        private void Listar(string pBuscar)
        {
            estudianteBindingSource.DataSource = _objUsuario.Listar(pBuscar);
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            frmEstudiante AddUser = new frmEstudiante(nro_carnetLabel1.Text);
            AddUser.ShowDialog();
            _objUsuario = new EstudianteController();
            Listar(txtBuscar.Text);
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("¿ESTA SEGURO DE ELIMINAR ESTE REGISTRO?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                _objUsuario.Eliminar(Convert.ToInt32(nro_carnetLabel1.Text));
                _objUsuario = new EstudianteController();
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

        private void iconPictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void estudianteDataGridView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && this.estudianteDataGridView.Columns[e.ColumnIndex].Name == "NOTAS" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                DataGridViewButtonCell celBoton = this.estudianteDataGridView.Rows[e.RowIndex].Cells["NOTAS"] as DataGridViewButtonCell;
                Icon icoNotas = new Icon(Environment.CurrentDirectory + @"\\notas.ico"); //Recuerden colocar su icono en la carpeta debug de su proyecto
                e.Graphics.DrawIcon(icoNotas, e.CellBounds.Left + 3, e.CellBounds.Top + 3);

                this.estudianteDataGridView.Rows[e.RowIndex].Height = icoNotas.Height + 8;
                this.estudianteDataGridView.Columns[e.ColumnIndex].Width = icoNotas.Width + 8;

                e.Handled = true;
            }
        }

        private void estudianteDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.estudianteDataGridView.Columns[e.ColumnIndex].Name == "NOTAS")
            {
                MessageBox.Show(nro_carnetLabel1.Text);
            }
        }
    }
}
