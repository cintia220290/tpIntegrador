using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mateAr_wf_PagoyEnvio
{
    class Envio
    {
        private string formaEnvio;
        private string nroSeguimiento;
        private DateTime fechaSalida;
        private DateTime fechaEntrega;
        private string estado;
        private string empresaCorreo;
       

        public string FormaEnvio { get; set; }
        public string NroSeguimiento { get; set; }
        public DateTime FechaSalida { get; set; }
        public DateTime FechaEntrega { get; set; }
        public string Estado { get; set; }
        public string EmpresaCorreo { get; set; }
    }
}
