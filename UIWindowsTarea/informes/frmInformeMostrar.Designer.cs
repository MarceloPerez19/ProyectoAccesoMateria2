
namespace UIWindowsTarea.informes
{
    partial class frmInformeMostrar
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dsMateria = new UIWindowsTarea.ds.dsMateria();
            this.datosMateriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.datosMateriaTableAdapter = new UIWindowsTarea.ds.dsMateriaTableAdapters.DatosMateriaTableAdapter();
            this.materiaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.materiaTableAdapter = new UIWindowsTarea.ds.dsMateriaTableAdapters.MateriaTableAdapter();
            this.datosMateriaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dsMateria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosMateriaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materiaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosMateriaBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.datosMateriaBindingSource1;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "UIWindowsTarea.informes.rptInformeMateriaxCodigo.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // dsMateria
            // 
            this.dsMateria.DataSetName = "dsMateria";
            this.dsMateria.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // datosMateriaBindingSource
            // 
            this.datosMateriaBindingSource.DataMember = "DatosMateria";
            this.datosMateriaBindingSource.DataSource = this.dsMateria;
            // 
            // datosMateriaTableAdapter
            // 
            this.datosMateriaTableAdapter.ClearBeforeFill = true;
            // 
            // materiaBindingSource
            // 
            this.materiaBindingSource.DataMember = "Materia";
            this.materiaBindingSource.DataSource = this.dsMateria;
            // 
            // materiaTableAdapter
            // 
            this.materiaTableAdapter.ClearBeforeFill = true;
            // 
            // datosMateriaBindingSource1
            // 
            this.datosMateriaBindingSource1.DataMember = "DatosMateria";
            this.datosMateriaBindingSource1.DataSource = this.dsMateria;
            // 
            // frmInformeMostrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmInformeMostrar";
            this.Text = "frmInformeMostrar";
            this.Load += new System.EventHandler(this.frmInformeMostrar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsMateria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosMateriaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materiaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosMateriaBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private ds.dsMateria dsMateria;
        private System.Windows.Forms.BindingSource datosMateriaBindingSource;
        private ds.dsMateriaTableAdapters.DatosMateriaTableAdapter datosMateriaTableAdapter;
        private System.Windows.Forms.BindingSource materiaBindingSource;
        private ds.dsMateriaTableAdapters.MateriaTableAdapter materiaTableAdapter;
        private System.Windows.Forms.BindingSource datosMateriaBindingSource1;
    }
}