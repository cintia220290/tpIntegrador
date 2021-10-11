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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //Se completa para probar
            pedido1.Idpedido = "125389625";
            txtPedido.Text = pedido1.Idpedido;

            pedido1.ImporteTotal = "1550";
            txtMonto.Text = pedido1.ImporteTotal;

            //Eliminar hasta aca cuando este la BD
        }

        Tarjeta tarjeta1 = new Tarjeta();
        Tarjeta tarjeta2 = new Tarjeta();
        Pedido pedido1 = new Pedido();
        Pago pago1 = new Pago();
        Usuario usuario1 = new Usuario();
        Domicilio domicilio1 = new Domicilio();
        Domicilio domicilio2 = new Domicilio();
        Envio envio1 = new Envio();
        PlanPago planPago1 = new PlanPago();

              private void btnConfirmar_Click(object sender, EventArgs e)
        {

            envio1.FormaEnvio = comboFormEnvio.Text;
            envio1.EmpresaCorreo = comboEmpCorreo.Text;
            pago1.FormaPago = comboFormPago.Text;
            tarjeta1.Vto = Convert.ToDateTime(txtVto.Text);
            tarjeta1.CodSeguridad = Convert.ToInt64(txtCodSeguridad.Text);
            planPago1.IdPlan = comboCuotas.Text;
            MessageBox.Show("Los datos fueron cargados correctamente");
        }

        //Se completa para probar
        private void btnBuscarDom_Click(object sender, EventArgs e)
        {
            domicilio2.Nombre = "Enviar a Peñaloza 217-Arroyito-Cba";
            txtDomAgendado.Text = domicilio2.Nombre;
        }

        private void btnBuscarTarj_Click(object sender, EventArgs e)
        {
            tarjeta2.Numero = "Tarjeta Visa finalizada en 4385";
            txtTarjAgendada.Text = tarjeta2.Numero;
        }
        //Eliminar hasta aca cuando este la BD
    }
}
