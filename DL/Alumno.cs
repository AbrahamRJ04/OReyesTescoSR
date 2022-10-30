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
        public int Edad { get; set; }
        public string? Sexo { get; set; }
        public int IdCarrera { get; set; }
        public string? Curp { get; set; }
        public string? NumeroCreditos { get; set; }
        public string? VidaAcademica { get; set; }
        public decimal Promedio { get; set; }
        public int IdServicioSocial { get; set; }

        //*ESTAS SON PROPIEDADES MANIPULADAS APARTE DE ENTITYUFRAMEWORK*//

        public string NombreCarrera { get; set; }
        public string NombreDependencia { get; set; }
        public int IdTipoDependencia { get; set; }
        public string TipoDeDependencia { get; set; }
        public string NombreDepartamento { get; set; }
        public string Domicilio { get; set; }
        public string Municipio { get; set; }
        public string TelefonoDependencia { get; set; }
        public string ResponsableNombre { get; set; }
        public string CargoResponsable { get; set; }
        public int IdPrograma { get; set; }
        public string NombrePrograma { get; set; }
        public string Actividades { get; set; }
        public int HorasAlDia { get; set; }
        public string Turno { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaTermino { get; set; }
        public int IdTipoServicio { get; set; }
        public string TipoDeServicio { get; set; }
    
        //*ESTAS SON PROPIEDADES MANIPULADAS APARTE DE ENTITYUFRAMEWORK*//

        public virtual Carrera? IdCarreraNavigation { get; set; }
        public virtual ServicioSocial? IdServicioSocialNavigation { get; set; }
    }
}
