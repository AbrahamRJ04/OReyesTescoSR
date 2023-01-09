using System;
using System.Collections.Generic;

namespace DL
{
    public partial class Proyecto
    {
        public int IdProyecto { get; set; }
        public int IdModalidadResidencias { get; set; }
        public string? NombreIntegranteUno { get; set; }
        public string? NombreIntegranteDos { get; set; }
        public string? MatriculaIntegranteUno { get; set; }
        public string? MatriculaIntegranteDos { get; set; }
        public string? NombreProyecto { get; set; }
        public string? NombreAsesorTesco { get; set; }
        public string? NombreAsesorDependencia { get; set; }
        public int IdCandidato { get; set; }
        public int IdEmpresaResidencias { get; set; }
        //*AGREGADAS APARTE*//

        public string Modalidad { get; set; }
        public string? NombreCompleto { get; set; }
        public string? Sexo { get; set; }
        public string? Telefono { get; set; }
        public string? CorreoElectronico { get; set; }
        public string? Calle { get; set; }
        public int NoExt { get; set; }
        public int NoInt { get; set; }
        public string? Colonia { get; set; }
        public string? Municipio { get; set; }
        public string? Estado { get; set; }
        public string? CodigoPostal { get; set; }
        public int IdCarrera { get; set; }
        public string? CarreraDeAlumno { get; set; }
        public string? Especialidad { get; set; }
        public string? Matricula { get; set; }
        public int VidaAcademica { get; set; }
        public int NoCreditos { get; set; }
        public string? ConstanciaTerminoServicioSocial { get; set; }
        public string? NombreDeEmpresa { get; set; }
        public int IdTipoEmpresa { get; set; }
        public string? TipoEmpresa { get; set; }
        public int IdGiro { get; set; }
        public string? Giro { get; set; }
        public int IdSector { get; set; }
        public string? Sector { get; set; }
        public string? TitularEmpresa { get; set; }
        public string? Cargo { get; set; }
        public string? TelefonoDeTitular { get; set; }
        public string? Extencion { get; set; }
        public string? CorreoDelTitular { get; set; }
        public string? CalleEmpresa { get; set; }
        public string? NumeroExtEmpresa { get; set; }
        public string? NumeroIntEmpresa { get; set; }
        public string? ColoniaEmpresa { get; set; }
        public string? MunicipioEmpresa { get; set; }
        public string? EstadoEmpresa { get; set; }
        public string? CodigoPostalEmpresa { get; set; }
        public string? PaginaWeb { get; set; }
        public string? RedSocial { get; set; }

        //*AGREGADAS APARTE*//
        public virtual DatosPersonalesResidencia? IdCandidatoNavigation { get; set; }
        public virtual EmpresaResidencia? IdEmpresaResidenciasNavigation { get; set; }
        public virtual ModalidadResidencia? IdModalidadResidenciasNavigation { get; set; }
    }
}
