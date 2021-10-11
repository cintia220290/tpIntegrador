using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mateAr_wf_PagoyEnvio
{
    class Usuario
    {
        private string nombreDeUsuario;
        private string nombre;
        private string apellido;
        private Int64 dni;
        private string email;
        private Int64 telefono;
 
        public string NombreDeUsuario { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public Int64 Dni { get; set; }
        public string Email { get; set; }
        public Int64 Telefono { get; set; }
    }
}
