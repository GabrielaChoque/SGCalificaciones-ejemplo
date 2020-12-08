namespace SGCalificaciones
{
    partial class Form1
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
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataSetCalificaciones = new SGCalificaciones.DataSetCalificaciones();
            this.CalificacionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CalificacionesTableAdapter = new SGCalificaciones.DataSetCalificacionesTableAdapters.CalificacionesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetCalificaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CalificacionesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // printDialog1
            // 
            this.printDialog1.AllowCurrentPage = true;
            this.printDialog1.AllowSelection = true;
            this.printDialog1.AllowSomePages = true;
            this.printDialog1.PrintToFile = true;
            this.printDialog1.ShowHelp = true;
            this.printDialog1.UseEXDialog = true;
            this.printDialog1.HelpRequest += new System.EventHandler(this.PrintDialog1_HelpRequest);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.CalificacionesBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SGCalificaciones.ReportCalificaciones.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // DataSetCalificaciones
            // 
            this.DataSetCalificaciones.DataSetName = "DataSetCalificaciones";
            this.DataSetCalificaciones.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // CalificacionesBindingSource
            // 
            this.CalificacionesBindingSource.DataMember = "Calificaciones";
            this.CalificacionesBindingSource.DataSource = this.DataSetCalificaciones;
            // 
            // CalificacionesTableAdapter
            // 
            this.CalificacionesTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSetCalificaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CalificacionesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource CalificacionesBindingSource;
        private DataSetCalificaciones DataSetCalificaciones;
        private DataSetCalificacionesTableAdapters.CalificacionesTableAdapter CalificacionesTableAdapter;
    }
}