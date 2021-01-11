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
    public partial class frmListadoClases : Form
    {
        public frmListadoClases()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            this.cargarGrid();
        }

        private void cargarGrid()
        {
            this.dataGridViewMateria.DataSource = CapaDatos.MateriaDAO.getAll();
        }

        private void dataGridViewMateria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /*//verificar si se hizo clic en el link eliminar
            if (this.dataGridViewMateria.Columns[e.ColumnIndex].Name == "linkEliminar")
            {
                //MessageBox.Show("Clic eliminar");
                //recupera la cedula de la fila actual 
                int fila = e.RowIndex;
                String CodMateria = dataGridViewMateria["CodMateria", fila].Value.ToString();
                String Materia = dataGridViewMateria["Materia", fila].Value.ToString();
                

                DialogResult dr = MessageBox.Show("Estas segur@ que sedea eliminar el registro de " + Materia + " ? ", "Confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.No)
                {
                    return; //abandonar
                }

                int x = CapaDatos.MateriaDAO.eliminar(CodMateria);
                if (x > 0)
                {
                    this.cargarGrid();
                    MessageBox.Show("Registro borrado con exito");
                }
                else
                    MessageBox.Show("No se pudo eliminar el registro");

            }
            else if (this.dataGridViewMateria.Columns[e.ColumnIndex].Name == "linkActualizar")
            {
                //MessageBox.Show("Clic actualizar");
                int fila = e.RowIndex;
                String CodMateria = dataGridViewMateria["CodMateria", fila].Value.ToString();

                //abrir el formulario
                frmActualizar frm1 = new frmActualizar(CodMateria);
                frm1.ShowDialog();
            }*/
        }

        private void DataGridViewEstuddiante_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridViewMateria_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            //verificar si se hizo clic en el link eliminar
            if (this.dataGridViewMateria.Columns[e.ColumnIndex].Name == "linkEliminar")
            {
                //MessageBox.Show("Clic eliminar");
                //recupera la cedula de la fila actual 
                int fila = e.RowIndex;
                String CodMateria = dataGridViewMateria["CodMateria", fila].Value.ToString();
                String Materia = dataGridViewMateria["Materia", fila].Value.ToString();


                DialogResult dr = MessageBox.Show("Estas segur@ que sedea eliminar el registro de " + Materia + " ? ", "Confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.No)
                {
                    return; //abandonar
                }

                int x = CapaDatos.MateriaDAO.eliminar(CodMateria);
                if (x > 0)
                {
                    this.cargarGrid();
                    MessageBox.Show("Registro borrado con exito");
                }
                else
                    MessageBox.Show("No se pudo eliminar el registro");

            }
            else if (this.dataGridViewMateria.Columns[e.ColumnIndex].Name == "linkActualizar")
            {
                //MessageBox.Show("Clic actualizar");
                int fila = e.RowIndex;
                String CodMateria = dataGridViewMateria["CodMateria", fila].Value.ToString();

                //abrir el formulario
                frmActualizar frm1 = new frmActualizar(CodMateria);
                frm1.ShowDialog();
            }
            this.cargarGrid();
        }
    }
}
