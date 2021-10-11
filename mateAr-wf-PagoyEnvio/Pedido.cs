using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mateAr_wf_PagoyEnvio
{
    class Pedido
    {

        private string idpedido;
        private string importeTotal;
        private DateTime fecha;

        public string Idpedido { get; set; }
        public string ImporteTotal { get; set; }
        public string Tipo { get; set; }
        public DateTime Fecha { get; set; }
       
    }
}
