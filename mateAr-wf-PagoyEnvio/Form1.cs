using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace mateAr_wf_PagoyEnvio
{
    public partial class Form1 : Form
    {
        public static string UbicacionTXTDatos = @"C:\Users\cmbai\OneDrive\Escritorio\Universidad\MateAR.txt";
        public Form1()
        {
              
            InitializeComponent();
            //Se completa para probar
            pedido1.Idpedido = "125389625";
            txtPedido.Text = pedido1.Idpedido;

            int impTotal = 1500;

            //Eliminar hasta aca cuando este la BD
            string formaEnvios = comboFormEnvio.Text;
            pedido1.ImporteTotal = impTotal;

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
            tarjeta1.Vto = Convert.ToDateTime(txtVto.Text);
            tarjeta1.CodSeguridad = Convert.ToInt64(txtCodSeguridad.Text);
           
            TextWriter BoletosYaVendidos = new StreamWriter(UbicacionTXTDatos);
            BoletosYaVendidos.WriteLine($"NUMERO PEDIDO:{pedido1.Idpedido} MONTO:{pedido1.ImporteTotal} FECHA:{pago1.FechaPago}  FORMA DE ENVIO:{envio1.FormaEnvio} FORMA DE PAGO:{pago1.FormaPago}\n");
            BoletosYaVendidos.Close();
            MessageBox.Show("Confirmacion", "Esta seguro de los datos ingresados?",MessageBoxButtons.YesNoCancel);
        }


        private void btnCambiarDom_Click(object sender, EventArgs e)
        {
            Form ventanaDomicilio = new Nuevo_Domicilio();
            ventanaDomicilio.Show();

        }

        private void btnNvaTarj_Click(object sender, EventArgs e)
        {
            Form ventanaTarjeta = new Nueva_Tarjeta();
            ventanaTarjeta.Show();

        }

        public int CalcularCostoEnvio(int impCompra, string formaEnvio)
        {
            if (formaEnvio == "Envio a Domicilio")
            {
                if (impCompra < 5000)
                {
                    int costoEnvio = 500;
                    return (costoEnvio);
                }
                else
                {
                    int costoEnvio = 0;
                    return (costoEnvio);
                }
            }
            else
            {
                int costoEnvio = 0;
                return (costoEnvio);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string formaEnvios = comboFormEnvio.Text;
            txtCostoEnvio.Text = Convert.ToString(CalcularCostoEnvio(pedido1.importeTotal, formaEnvios));

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string formaEnvios = comboFormEnvio.Text;
            envio1.FormaEnvio = comboFormEnvio.Text;
            envio1.EmpresaCorreo = comboSucursal.Text;
           

            int montoConEnvio = (CalcularCostoEnvio(pedido1.importeTotal, formaEnvios) + pedido1.importeTotal);
            txtMontoConEnvio.Text = Convert.ToString(montoConEnvio);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string formaEnvios = comboFormEnvio.Text;
            planPago1.CantCuotas = comboCuotas.Text;
            string planCuo = planPago1.CantCuotas;

            int impP = pedido1.importeTotal;
            
            pago1.FormaPago = comboFormPago.Text;
            string fPago = pago1.FormaPago;
         

            int montoConEnvio = (CalcularCostoEnvio(impP, formaEnvios) + impP);
            int TotalApagar = ((CalcularCostoEnvio(impP, formaEnvios))+ (MontoEnCuotas(fPago, planCuo, montoConEnvio)));

            txtTotalFinal.Text = Convert.ToString(TotalApagar);
        }

        public int MontoEnCuotas(string modoPago, string cantCuotas, int impCompra)
        {
            if (modoPago == "Tarjeta de Credito")
            {
                if (cantCuotas =="1")
                {
                    int montoPago = impCompra;
                    return (montoPago);

                }
                else if (cantCuotas == "3")
                {
                    int montoPago = impCompra + ((impCompra * 20) / 100);
                    return (montoPago);
                }
                else if (cantCuotas == "6")
                {
                    int montoPago = impCompra + ((impCompra * 30) / 100);
                    return (montoPago);
                }
                else if (cantCuotas == "12")
                {
                    int montoPago  = impCompra + ((impCompra * 40) / 100);
                    return (montoPago);

                }
                else
                {
                    int montoPago  = impCompra;
                    return (montoPago);
                }

            }
            else
            {
                int montoPago  = impCompra;
                 return (montoPago);
            }

        }
    }
}
