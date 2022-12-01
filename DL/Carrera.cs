using System;
using System.Collections.Generic;

namespace DL
{
    public partial class Carrera
    {
        public Carrera()
        {
            Alumnos = new HashSet<Alumno>();
            DatosPersonalesResidencia = new HashSet<DatosPersonalesResidencia>();
        }

        public int IdCarrera { get; set; }
        public string? Nombre { get; set; }

        public virtual ICollection<Alumno> Alumnos { get; set; }
        public virtual ICollection<DatosPersonalesResidencia> DatosPersonalesResidencia { get; set; }
    }
}
