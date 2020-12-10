using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace SGCalificaciones.Vista.Ventanas
{
    public partial class frmImprimirLibreta : Form
    {
        public frmImprimirLibreta()
        {
            InitializeComponent();
        }

        private void frmImprimirLibreta_Load(object sender, EventArgs e)
        {

            //this.calificacionesTableAdapter1.Fill(this.bdCalificacionesDataSet1.Calificaciones);
            this.reportViewer1.RefreshReport();
        }
    }
}
