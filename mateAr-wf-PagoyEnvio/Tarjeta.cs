using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mateAr_wf_PagoyEnvio
{
    class Tarjeta
    {
            private string numero;
            private string banco;
            private string tipo;
            private Int64 dniTitular;
            private string nombreTitular;
            private Int64 codSeguridad;
            private DateTime vto;



        public string Numero { get; set; }
            public string Banco { get; set; }
            public string Tipo { get; set; }
            public Int64 DniTitular { get; set; }
            public string NombreTitular { get; set; }
            public Int64 CodSeguridad { get; set; }
            public DateTime Vto { get; set; }

    }
}
