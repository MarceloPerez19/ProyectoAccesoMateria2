
namespace UIWindowsTarea.informes
{
    partial class frmInformeMateria
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
            this.datosMateriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsMateria = new UIWindowsTarea.ds.dsMateria();
            this.datosMateriaTableAdapter = new UIWindowsTarea.ds.dsMateriaTableAdapters.DatosMateriaTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.datosMateriaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.datosMateriaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMateria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosMateriaBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // datosMateriaBindingSource
            // 
            this.datosMateriaBindingSource.DataMember = "DatosMateria";
            this.datosMateriaBindingSource.DataSource = this.dsMateria;
            // 
            // dsMateria
            // 
            this.dsMateria.DataSetName = "dsMateria";
            this.dsMateria.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // datosMateriaTableAdapter
            // 
            this.datosMateriaTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.datosMateriaBindingSource1;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "UIWindowsTarea.informes.rptMateria.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // datosMateriaBindingSource1
            // 
            this.datosMateriaBindingSource1.DataMember = "DatosMateria";
            this.datosMateriaBindingSource1.DataSource = this.dsMateria;
            // 
            // frmInformeMateria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmInformeMateria";
            this.Text = "frmInformeMateria";
            this.Load += new System.EventHandler(this.frmInformeMateria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datosMateriaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMateria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosMateriaBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private ds.dsMateria dsMateria;
        private System.Windows.Forms.BindingSource datosMateriaBindingSource;
        private ds.dsMateriaTableAdapters.DatosMateriaTableAdapter datosMateriaTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource datosMateriaBindingSource1;
    }
}