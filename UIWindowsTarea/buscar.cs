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
    public partial class buscar : Form
    {
        public buscar()
        {
            InitializeComponent();
        }

        
        private void cargarComboMateria()
        {
            this.cmbCod.DataSource = CapaDatos.MateriaDAO.getAll();
            this.cmbCod.DisplayMember = "NombreMateria";
            this.cmbCod.ValueMember = "CodMateria";
        }
        private void bntBuscar_Click(object sender, EventArgs e)
        {
            string codigo = this.cmbCod.SelectedValue.ToString();

            CapaDatos.Materia P = new CapaDatos.Materia();
            P = CapaDatos.MateriaDAO.getMateria(codigo);

            //cargar datos en los cuadros de texto
            this.txtCodigo.Text = P.CodMateria;
            this.txtMateria.Text = P.NombreMateria;
            this.txtNivel.Text = P.Nivel.ToString();
            this.txtCarrera.Text = P.Carrera;
            this.dtFecha.Value = Convert.ToDateTime(P.FechaCreacion);
            

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (this.txtCodigo.Text.Length == 0)//si la cedula esta vacia
            {
                MessageBox.Show("No hay materia seleccionada seleccionada");
                return; //abandonar
            }
            CapaDatos.Materia materia = new CapaDatos.Materia();
            materia.CodMateria = this.txtCodigo.Text;
            materia.NombreMateria = this.txtMateria.Text;
            materia.Nivel = int.Parse(this.txtNivel.Text);
            materia.Carrera = this.txtCarrera.Text;
            materia.FechaCreacion = dtFecha.Value;

            int x = CapaDatos.MateriaDAO.actualizar(materia);
            if (x > 0)
            {
                this.cargarComboMateria(); //refresque el cuadro combinado de estudiantes
                MessageBox.Show("Registro actualizado con exito");
            }
            else
                MessageBox.Show("No se pudo actualizar el registro");
        }

        
        

        private void encerar()
        {
            this.txtCodigo.Text = " ";
            this.txtMateria.Text = " ";
            this.txtNivel.Text = " ";
            this.txtCarrera.Text = " ";
        }

        private void buscar_Load_1(object sender, EventArgs e)
        {
            this.cargarComboMateria();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Estas seguro que sedea eliminar este registro?", "Confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.No)
            {
                return; //abandonar
            }
            int x=CapaDatos.MateriaDAO.eliminar(this.txtCodigo.Text);

            if (x > 0)
            {
                this.encerar();
                this.cargarComboMateria();
                MessageBox.Show("Registro eliminado con exito");
            }
            else
            {
                MessageBox.Show("No se puedo borrar el registro");
            }
        }
    }
}

