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
    public partial class Nueva_Tarjeta : Form
    {
        public Nueva_Tarjeta()
        {
            InitializeComponent();
        }
        Tarjeta tarjeta1 = new Tarjeta();

        private void btnGuardarDom_Click(object sender, EventArgs e)
        {
            tarjeta1.Tipo = comboTipoTarj.Text;
            tarjeta1.NombreTitular = txtNomTitular.Text;
            tarjeta1.Numero = txtNumTarj.Text;
            tarjeta1.Banco = txtBanco.Text;
            tarjeta1.DniTitular = Convert.ToInt64(txtDniTitular.Text);
            MessageBox.Show("Los Datos de su tarjeta fueron registrados exitosamente");
        }

        private void bntCancelarDom_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
