using System;
using System.Collections.Generic;

namespace DL
{
    public partial class Alumno
    {
        public int IdAlumno { get; set; }
        public string? Nombre { get; set; }
        public string? ApellidoPaterno { get; set; }
        public string? ApellidoMaterno { get; set; }
        public string? CorreoInstitucional { get; set; }
        public string? Telefono { get; set; }
        public int? Edad { get; set; }
        public string? Sexo { get; set; }
        public int? IdCarrera { get; set; }
        public string? Curp { get; set; }
        public string? NumeroCreditos { get; set; }
        public string? VidaAcademica { get; set; }
        public decimal? Promedio { get; set; }
        public int? IdServicioSocial { get; set; }

        public virtual Carrera? IdCarreraNavigation { get; set; }
        public virtual ServicioSocial? IdServicioSocialNavigation { get; set; }
    }
}
