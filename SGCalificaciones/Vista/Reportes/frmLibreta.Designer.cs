
namespace SGCalificaciones.Vista.Reportes
{
    partial class frmLibreta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.tablaCalificaciones1PruebaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bdCalificacionesDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bdCalificacionesDataSet = new SGCalificaciones.Data.BdCalificacionesDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tablaCalificaciones1PruebaTableAdapter = new SGCalificaciones.Data.BdCalificacionesDataSetTableAdapters.TablaCalificaciones1PruebaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tablaCalificaciones1PruebaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdCalificacionesDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdCalificacionesDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // tablaCalificaciones1PruebaBindingSource
            // 
            this.tablaCalificaciones1PruebaBindingSource.DataMember = "TablaCalificaciones1Prueba";
            this.tablaCalificaciones1PruebaBindingSource.DataSource = this.bdCalificacionesDataSetBindingSource;
            // 
            // bdCalificacionesDataSetBindingSource
            // 
            this.bdCalificacionesDataSetBindingSource.DataSource = this.bdCalificacionesDataSet;
            this.bdCalificacionesDataSetBindingSource.Position = 0;
            // 
            // bdCalificacionesDataSet
            // 
            this.bdCalificacionesDataSet.DataSetName = "BdCalificacionesDataSet";
            this.bdCalificacionesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.tablaCalificaciones1PruebaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SGCalificaciones.Vista.Reportes.ReportLibreta.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(32, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(808, 453);
            this.reportViewer1.TabIndex = 0;
            // 
            // tablaCalificaciones1PruebaTableAdapter
            // 
            this.tablaCalificaciones1PruebaTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 502);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablaCalificaciones1PruebaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdCalificacionesDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdCalificacionesDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Data.BdCalificacionesDataSet bdCalificacionesDataSet;
        private System.Windows.Forms.BindingSource bdCalificacionesDataSetBindingSource;
        private System.Windows.Forms.BindingSource tablaCalificaciones1PruebaBindingSource;
        private Data.BdCalificacionesDataSetTableAdapters.TablaCalificaciones1PruebaTableAdapter tablaCalificaciones1PruebaTableAdapter;
    }
}