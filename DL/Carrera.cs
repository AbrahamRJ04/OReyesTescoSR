using System;
using System.Collections.Generic;

namespace DL;

public partial class Carrera
{
    public int IdCarrera { get; set; }

    public string? Nombre { get; set; }

    public virtual ICollection<Alumno> Alumnos { get; } = new List<Alumno>();

    public virtual ICollection<DatosPersonalesResidencia> DatosPersonalesResidencia { get; } = new List<DatosPersonalesResidencia>();
}
