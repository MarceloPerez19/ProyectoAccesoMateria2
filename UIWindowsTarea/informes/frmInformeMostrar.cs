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
    public partial class frmInformeMostrar : Form
    {
        private string mCodigo;
        public frmInformeMostrar(string CodMateria)
        {
            InitializeComponent();
            mCodigo = CodMateria;
        }

        private void frmInformeMostrar_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsMateria.DatosMateria' Puede moverla o quitarla según sea necesario.
            this.datosMateriaTableAdapter.Fill(this.dsMateria.DatosMateria);

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
