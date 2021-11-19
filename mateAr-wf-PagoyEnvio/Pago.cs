using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mateAr_wf_PagoyEnvio
{
    class Pago
    {
        private int idPago;
        private string formaPago;
        private int montoPago;
        private DateTime fechaPago;



        public int IdPago { get; set; }
        public string FormaPago { get; set; }
        public decimal MontoPago { get; set; }
        public DateTime FechaPago { get; set; }

        

    }
}
