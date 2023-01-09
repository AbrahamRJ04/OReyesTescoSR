using System;
using System.Collections.Generic;

namespace DL;

public partial class Programa
{
    public int IdPrograma { get; set; }

    public string? Nombre { get; set; }

    public virtual ICollection<ServicioSocial> ServicioSocials { get; } = new List<ServicioSocial>();
}
