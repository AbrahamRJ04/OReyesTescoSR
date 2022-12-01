using System;
using System.Collections.Generic;

namespace DL
{
    public partial class Proyecto
    {
        public int IdProyecto { get; set; }
        public int? IdModalidadResidencias { get; set; }
        public string? NombreIntegranteUno { get; set; }
        public string? NombreIntegranteDos { get; set; }
        public string? MatriculaIntegranteUno { get; set; }
        public string? MatriculaIntegranteDos { get; set; }
        public string? NombreProyecto { get; set; }
        public string? NombreAsesorTesco { get; set; }
        public string? NombreAsesorDependencia { get; set; }
        public int? IdCandidato { get; set; }
        public int? IdEmpresaResidencias { get; set; }

        public virtual DatosPersonalesResidencia? IdCandidatoNavigation { get; set; }
        public virtual EmpresaResidencia? IdEmpresaResidenciasNavigation { get; set; }
        public virtual ModalidadResidencia? IdModalidadResidenciasNavigation { get; set; }
    }
}
