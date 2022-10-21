using System;
using System.Collections.Generic;

namespace DL
{
    public partial class Carrera
    {
        public Carrera()
        {
            Alumnos = new HashSet<Alumno>();
        }

        public int IdCarrera { get; set; }
        public string? Nombre { get; set; }

        public virtual ICollection<Alumno> Alumnos { get; set; }
    }
}
