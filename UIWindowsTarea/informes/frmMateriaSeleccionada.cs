using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIWindowsTarea.informes
{
    public partial class frmMateriaSeleccionada : Form
    {
        public frmMateriaSeleccionada()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMateriaSeleccionada_Load(object sender, EventArgs e)
        {
            this.cmbCod.DataSource = CapaDatos.MateriaDAO.getAll();
            this.cmbCod.DisplayMember = "NombreMateria";
            this.cmbCod.ValueMember = "CodMateria";
        }

        private void btnVerInforme_Click(object sender, EventArgs e)
        {
            informes.frmInformeMostrar frm1 = new informes.frmInformeMostrar(this.cmbCod.SelectedValue.ToString());
            frm1.Show();
        }
    }
}
