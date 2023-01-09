using System;
using System.Collections.Generic;

namespace DL;

public partial class ModalidadResidencia
{
    public int IdModalidadResidencias { get; set; }

    public string? Modalidad { get; set; }

    public virtual ICollection<Proyecto> Proyectos { get; } = new List<Proyecto>();
}
