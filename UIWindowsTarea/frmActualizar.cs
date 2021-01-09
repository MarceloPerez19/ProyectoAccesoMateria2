using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIWindowsTarea
{
    public partial class frmActualizar : Form
    {
        private String mCodigo;
        public frmActualizar(String CodMateria)
        {
            InitializeComponent();
            this.mCodigo = CodMateria;
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {
            //guardar
            if (this.mCodigo.Length > 0)
            {
                CapaDatos.Materia materia = new CapaDatos.Materia();
                materia.CodMateria = mCodigo;
                materia.NombreMateria = this.txtMateria.Text;
                materia.Carrera = this.txtCarrera.Text;
                materia.Nivel = int.Parse(this.txtNivel.Text);   
                materia.FechaCreacion = dtFecha.Value;

                int x = CapaDatos.MateriaDAO.actualizar(materia);
                if (x > 0)
                    MessageBox.Show("Registro actualizado");
                else
                    MessageBox.Show("No se actualizo el registro");
            }
        }

        private void toolStripTextBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void frmActualizar_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("La cedula es : " + this.mCedula);
            this.txtCodigo.Text = mCodigo;
            CapaDatos.Materia materia = new CapaDatos.Materia();

            materia = CapaDatos.MateriaDAO.getMateria(mCodigo);
            this.txtMateria.Text = materia.NombreMateria;
            this.txtCarrera.Text = materia.Carrera;
            this.txtNivel.Text = materia.Nivel.ToString();
            this.dtFecha.Value = materia.FechaCreacion;
        }
    }
}
