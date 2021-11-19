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
        private string cantCuotas;
        private decimal interes;

        public string IdPlan { get; set; }
        public string CantCuotas { get; set; }
        public decimal Interes { get; set; }
    }
}
