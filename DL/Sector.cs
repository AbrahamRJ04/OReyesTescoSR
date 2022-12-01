using System;
using System.Collections.Generic;

namespace DL
{
    public partial class Sector
    {
        public Sector()
        {
            EmpresaResidencia = new HashSet<EmpresaResidencia>();
        }

        public int IdSector { get; set; }
        public string? Sector1 { get; set; }

        public virtual ICollection<EmpresaResidencia> EmpresaResidencia { get; set; }
    }
}
