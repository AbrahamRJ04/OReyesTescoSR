using System;
using System.Collections.Generic;

namespace DL
{
    public partial class GiroEmpresa
    {
        public GiroEmpresa()
        {
            EmpresaResidencia = new HashSet<EmpresaResidencia>();
        }

        public int IdGiro { get; set; }
        public string? Giro { get; set; }

        public virtual ICollection<EmpresaResidencia> EmpresaResidencia { get; set; }
    }
}
