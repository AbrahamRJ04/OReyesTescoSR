using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML
{
    public class VacantesServicioSocial
    {
        public int IdVacante { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public string Descripcion { get; set; }
        public string Logo { get; set; }

        public List<Object>? Vacantes { get; set; }
    }
}
