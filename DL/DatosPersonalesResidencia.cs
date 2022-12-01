using System;
using System.Collections.Generic;

namespace DL
{
    public partial class DatosPersonalesResidencia
    {
        public DatosPersonalesResidencia()
        {
            Proyectos = new HashSet<Proyecto>();
        }

        public int IdCandidato { get; set; }
        public string? NombreCompleto { get; set; }
        public string? Sexo { get; set; }
        public string? Telefono { get; set; }
        public string? CorreoElectronico { get; set; }
        public string? Calle { get; set; }
        public int? NoExt { get; set; }
        public int? NoInt { get; set; }
        public string? Colonia { get; set; }
        public string? Municipio { get; set; }
        public string? Estado { get; set; }
        public string? CodigoPostal { get; set; }
        public int? IdCarrera { get; set; }
        public string? Especialidad { get; set; }
        public string? Matricula { get; set; }
        public int? VidaAcademica { get; set; }
        public int? NoCreditos { get; set; }
        public string? ConstanciaTerminoServicioSocial { get; set; }

        public virtual Carrera? IdCarreraNavigation { get; set; }
        public virtual ICollection<Proyecto> Proyectos { get; set; }
    }
}
