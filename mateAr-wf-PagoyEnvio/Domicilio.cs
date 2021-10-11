using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mateAr_wf_PagoyEnvio
{
    class Domicilio
    {
            private string nombre;
            private int nroCalle;
            private string depto;
            private int codigoPostal;
            private string provincia;
            private string localidad;
            private string barrio;


            public string Nombre { get; set; }
            public Int64 NroCalle { get; set; }
            public string Depto { get; set; }
            public Int64 CodigoPostal { get; set; }
            public string Provincia { get; set; }
            public string Localidad { get; set; }
            public string Barrio { get; set; }

    }
}

