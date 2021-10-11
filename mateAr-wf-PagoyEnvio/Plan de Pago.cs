using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mateAr_wf_PagoyEnvio
{
    class PlanPago
    {
        private string idPlan;
        private int cantCuotas;
        private decimal interes;

        public string IdPlan { get; set; }
        public Int64 CantCuotas { get; set; }
        public decimal Interes { get; set; }
    }
}
