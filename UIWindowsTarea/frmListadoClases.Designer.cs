namespace UIWindowsTarea
{
    partial class frmListadoClases
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.dataGridViewMateria = new System.Windows.Forms.DataGridView();
            this.linkActualizar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.linkEliminar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMateria)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Listado de estudiantes";
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(372, 28);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(75, 23);
            this.btnMostrar.TabIndex = 1;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // dataGridViewMateria
            // 
            this.dataGridViewMateria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMateria.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.linkActualizar,
            this.linkEliminar});
            this.dataGridViewMateria.Location = new System.Drawing.Point(22, 71);
            this.dataGridViewMateria.Name = "dataGridViewMateria";
            this.dataGridViewMateria.Size = new System.Drawing.Size(671, 157);
            this.dataGridViewMateria.TabIndex = 2;
            this.dataGridViewMateria.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMateria_CellContentClick);
            // 
            // linkActualizar
            // 
            this.linkActualizar.HeaderText = "Accion";
            this.linkActualizar.Name = "linkActualizar";
            // 
            // linkEliminar
            // 
            this.linkEliminar.HeaderText = "Accion";
            this.linkEliminar.Name = "linkEliminar";
            // 
            // frmListadoClases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 279);
            this.Controls.Add(this.dataGridViewMateria);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.label1);
            this.Name = "frmListadoClases";
            this.Text = "frmListadoClases";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMateria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.DataGridView dataGridViewMateria;
        private System.Windows.Forms.DataGridViewTextBoxColumn linkActualizar;
        private System.Windows.Forms.DataGridViewTextBoxColumn linkEliminar;
    }
}