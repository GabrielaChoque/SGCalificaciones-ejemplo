
namespace SGCalificaciones.Vista.Ventanas
{
    partial class frmImprimirLibreta
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
           // this.bdCalificacionesDataSet1 = new SGCalificaciones.Data.BdCalificacionesDataSet();
            //this.calificacionesTableAdapter1 = new SGCalificaciones.Data.BdCalificacionesDataSetTableAdapters.CalificacionesTableAdapter();
           // ((System.ComponentModel.ISupportInitialize)(this.bdCalificacionesDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SGCalificaciones.Vista.Reportes.ReportCalificaciones.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(121, 91);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(396, 246);
            this.reportViewer1.TabIndex = 0;
            // 
            // bdCalificacionesDataSet1
            // 
            //this.bdCalificacionesDataSet1.DataSetName = "BdCalificacionesDataSet";
            //this.bdCalificacionesDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // calificacionesTableAdapter1
            // 
            //this.calificacionesTableAdapter1.ClearBeforeFill = true;
            // 
            // frmImprimirLibreta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmImprimirLibreta";
            this.Text = "frmImprimirLibreta";
            this.Load += new System.EventHandler(this.frmImprimirLibreta_Load);
            //((System.ComponentModel.ISupportInitialize)(this.bdCalificacionesDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        //private Data.BdCalificacionesDataSet bdCalificacionesDataSet1;
        //private Data.BdCalificacionesDataSetTableAdapters.CalificacionesTableAdapter calificacionesTableAdapter1;
    }
}