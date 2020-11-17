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
        public frmCalificacionesGeneral()
        {
            InitializeComponent();
        }
        private void Listar(string pBuscar)
        {
            estudianteBindingSource.DataSource = _objUsuario.Listar(pBuscar);
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
