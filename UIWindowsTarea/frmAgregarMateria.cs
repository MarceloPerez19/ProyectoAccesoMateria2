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

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
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
