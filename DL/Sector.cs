using System;
using System.Collections.Generic;

namespace DL;

public partial class Sector
{
    public int IdSector { get; set; }

    public string? Sector1 { get; set; }

    public virtual ICollection<EmpresaResidencia> EmpresaResidencia { get; } = new List<EmpresaResidencia>();
}
