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
    public partial class frmGestionarAnioEscolar : Form
    {
        BimestreController _objUsuario = new BimestreController();
        //BimestreController _obtBimestre = new BimestreController();

        public frmGestionarAnioEscolar()
        {
            InitializeComponent();
        }

        private void iconPictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    
        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            frmPlantel AddUsuario = new frmPlantel();
            AddUsuario.ShowDialog();
            Listar("");

        }

        private void Listar(string pBuscar)
        {
            bimestreBindingSource.DataSource = _objUsuario.Listar(pBuscar);
        }

        private void frmGestionarAnioEscolar_Load(object sender, EventArgs e)
        {
            Listar("");
        }
    }
}
