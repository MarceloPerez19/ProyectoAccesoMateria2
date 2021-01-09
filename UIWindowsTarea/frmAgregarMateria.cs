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
    public partial class frmAgregarMateria : Form
    {
        public frmAgregarMateria()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(this.txtCodMateria.Text.Length==0) 
            {
                MessageBox.Show("Por favor ingresa el codigo de la materia");
                this.txtCodMateria.Focus();
                return;
            }
            if(this.txtNombre.Text.Length==0)
            {
                MessageBox.Show("Por favor ingresa el nombre");
                this.txtNombre.Focus();
                return;
            }
            if(this.txtNivel.Text.Length==0)
            {
                MessageBox.Show("Por favor ingresa el dato");
                this.txtNivel.Focus();
                return;
            }
            if(this.txtCarrera.Text.Length==0)
            {
                MessageBox.Show("Por favor ingres la carrera");
                this.txtCarrera.Focus();
                return;
            }
            

            CapaDatos.Materia materia = new CapaDatos.Materia();
            materia.CodMateria = this.txtCodMateria.Text;
            materia.NombreMateria = this.txtNombre.Text;
            materia.Nivel = int.Parse(this.txtNivel.Text);
            materia.Carrera = this.txtCarrera.Text;
            materia.FechaCreacion = dtCreacion.Value;


 
            int x = CapaDatos.MateriaDAO.crear(materia);
            if (x > 0)
                MessageBox.Show("Ingreso correctamente datos de carrera");
            else
                MessageBox.Show("Error en la intgegracion de datos");
        }

        private void btnGuardar_Load(object sender, EventArgs e)
        {
            
        }
    }
}
