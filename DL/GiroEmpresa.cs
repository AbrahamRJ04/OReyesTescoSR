using System;
using System.Collections.Generic;

namespace DL;

public partial class GiroEmpresa
{
    public int IdGiro { get; set; }

    public string? Giro { get; set; }

    public virtual ICollection<EmpresaResidencia> EmpresaResidencia { get; } = new List<EmpresaResidencia>();
}
