using System;
using System.Collections.Generic;

namespace DL;

public partial class ServicioSocial
{
    public int IdServicioSocial { get; set; }

    public string? NombreDependencia { get; set; }

    public int? IdTipoDependencia { get; set; }

    public string? NombreDepartamento { get; set; }

    public string? Domicilio { get; set; }

    public string? Municipio { get; set; }

    public string? Telefono { get; set; }

    public string? ResponsableNombre { get; set; }

    public string? CargoResponsable { get; set; }

    public int? IdPrograma { get; set; }

    public string? Actividades { get; set; }

    public int? HorasAlDia { get; set; }

    public string? Turno { get; set; }

    public DateTime? FechaInicio { get; set; }

    public DateTime? FechaTermino { get; set; }

    public int? IdTipoServicio { get; set; }

    public virtual ICollection<Alumno> Alumnos { get; } = new List<Alumno>();

    public virtual Programa? IdProgramaNavigation { get; set; }

    public virtual TipoDependencium? IdTipoDependenciaNavigation { get; set; }

    public virtual TipoServicio? IdTipoServicioNavigation { get; set; }
}
