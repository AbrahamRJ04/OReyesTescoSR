using System;
using System.Collections.Generic;

namespace DL;

public partial class TipoEmpresa
{
    public int IdTipoEmpresa { get; set; }

    public string? TipoEmpresa1 { get; set; }

    public virtual ICollection<EmpresaResidencia> EmpresaResidencia { get; } = new List<EmpresaResidencia>();
}
