using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGCalificaciones.Vista.Reportes
{
    public partial class frmLibreta : Form
    {
        public string _carnet;
        public string _nombre;
        public frmLibreta(string pCarnet, string nombre)
        {
            InitializeComponent();
            _carnet = pCarnet;
            _nombre = nombre;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //ReportParameter p = new ReportParameter();
           // p = new ReportParameter("pCi", _carnet);
           // reportViewer1.LocalReport.SetParameters(p);
            ReportParameter[] p = new ReportParameter[2];
            p[0] = new ReportParameter("pCi", _carnet);
            p[1] = new ReportParameter("pNombre", _nombre);
            reportViewer1.LocalReport.SetParameters(p);
            // TODO: esta línea de código carga datos en la tabla 'bdCalificacionesDataSet.TablaCalificaciones1Prueba' Puede moverla o quitarla según sea necesario.
            this.tablaCalificaciones1PruebaTableAdapter.Fill(this.bdCalificacionesDataSet.TablaCalificaciones1Prueba);

            this.reportViewer1.RefreshReport();
        }
    }
}
