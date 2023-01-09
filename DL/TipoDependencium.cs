using System;
using System.Collections.Generic;

namespace DL;

public partial class TipoDependencium
{
    public int IdTipoDependencia { get; set; }

    public string? Nombre { get; set; }

    public virtual ICollection<ServicioSocial> ServicioSocials { get; } = new List<ServicioSocial>();
}
