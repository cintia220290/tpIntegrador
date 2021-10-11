using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mateAr_wf_PagoyEnvio
{
    public partial class Nuevo_Domicilio : Form
    {
        public Nuevo_Domicilio()
        {
            InitializeComponent();
        }

        Domicilio domicilio1 = new Domicilio();

        private void btnGuardarDom_Click(object sender, EventArgs e)
        {
            domicilio1.Nombre = txtNombreCalle.Text;
            domicilio1.NroCalle = Convert.ToInt64(txtNumCalle.Text);
            domicilio1.Depto = txtDepto.Text;
            domicilio1.CodigoPostal= Convert.ToInt64(txtDepto.Text);
            domicilio1.Localidad = txtLocalidad.Text;
            domicilio1.Barrio = txtBarrio.Text;
            domicilio1.Provincia = txtProvincia.Text;

        }
    }
}
