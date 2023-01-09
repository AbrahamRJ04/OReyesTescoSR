using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class ResidenciasProfesionales
    {
        public static ML.Result GetAll()
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL.AreyesTescoServicioContext context = new DL.AreyesTescoServicioContext())
                {
                    var query = context.Proyectos.FromSqlRaw("ResidenciaGetAll").ToList();
                    result.Objects = new List<object>();

                    if (result != null)
                    {
                        foreach (var obj in query)
                        {
                            ML.Proyecto proyecto = new ML.Proyecto();
                            proyecto.ModalidadResidencias = new ML.ModalidadResidencias();
                            proyecto.Candidato = new ML.DatosPersonalesResidencia();
                            proyecto.Candidato.Carrera = new ML.Carrera();
                            proyecto.EmpresaResidencias = new ML.EmpresaResidencias();
                            proyecto.EmpresaResidencias.TipoEmpresa = new ML.TipoEmpresa();
                            proyecto.EmpresaResidencias.Giro = new ML.GiroEmpresa();
                            proyecto.EmpresaResidencias.Sector = new ML.Sector();

                            proyecto.IdProyecto = obj.IdProyecto;
                            proyecto.ModalidadResidencias.IdModalidadResidencias = obj.IdModalidadResidencias;
                            proyecto.ModalidadResidencias.Modalidad = obj.Modalidad;
                            proyecto.NombreIntegranteUno = obj.NombreIntegranteUno;
                            proyecto.NombreIntegranteDos = obj.NombreIntegranteDos;
                            proyecto.MatriculaIntegranteUno = obj.MatriculaIntegranteUno;
                            proyecto.MatriculaIntegranteDos = obj.MatriculaIntegranteDos;
                            proyecto.NombreProyecto = obj.NombreProyecto;
                            proyecto.NombreAsesorTesco = obj.NombreAsesorTesco;
                            proyecto.NombreAsesorDependencia = obj.NombreAsesorDependencia;
                            proyecto.Candidato.IdCandidato = obj.IdCandidato;
                            proyecto.Candidato.NombreCompleto = obj.NombreCompleto;
                            proyecto.Candidato.Sexo = obj.Sexo;
                            proyecto.Candidato.Telefono = obj.Telefono;
                            proyecto.Candidato.CorreoElectronico = obj.CorreoElectronico;
                            proyecto.Candidato.Calle = obj.Calle;
                            proyecto.Candidato.NoExt = obj.NoExt;
                            proyecto.Candidato.NoInt = obj.NoInt;
                            proyecto.Candidato.Colonia = obj.Colonia;
                            proyecto.Candidato.Municipio = obj.Municipio;
                            proyecto.Candidato.Estado = obj.Estado;
                            proyecto.Candidato.CodigoPostal = obj.CodigoPostal;
                            proyecto.Candidato.Carrera.IdCarrera = obj.IdCarrera;
                            proyecto.Candidato.Carrera.Nombre = obj.CarreraDeAlumno;
                            proyecto.Candidato.Especialidad = obj.Especialidad;
                            proyecto.Candidato.Matricula = obj.Matricula;
                            proyecto.Candidato.VidaAcademica = obj.VidaAcademica;
                            proyecto.Candidato.NoCreditos = obj.NoCreditos;
                            proyecto.Candidato.ConstanciaTerminoServicioSocial = obj.ConstanciaTerminoServicioSocial;
                            proyecto.EmpresaResidencias.IdEmpresaResidencias = obj.IdEmpresaResidencias;
                            proyecto.EmpresaResidencias.NombreDeEmpresa = obj.NombreDeEmpresa;
                            proyecto.EmpresaResidencias.TipoEmpresa.IdTipoEmpresa = obj.IdTipoEmpresa;
                            proyecto.EmpresaResidencias.TipoEmpresa.TipoDeEmpresa = obj.TipoEmpresa;
                            proyecto.EmpresaResidencias.Giro.IdGiro = obj.IdGiro;
                            proyecto.EmpresaResidencias.Giro.Giro = obj.Giro;
                            proyecto.EmpresaResidencias.Sector.IdSector = obj.IdSector;
                            proyecto.EmpresaResidencias.Sector.SectorTipo = obj.Sector;
                            proyecto.EmpresaResidencias.NombreTitular = obj.TitularEmpresa;
                            proyecto.EmpresaResidencias.Cargo = obj.Cargo;
                            proyecto.EmpresaResidencias.Telefono = obj.TelefonoDeTitular;
                            proyecto.EmpresaResidencias.Extencion = obj.Extencion;
                            proyecto.EmpresaResidencias.CorreoElectronico = obj.CorreoDelTitular;
                            proyecto.EmpresaResidencias.Calle = obj.CalleEmpresa;
                            proyecto.EmpresaResidencias.NoExt = obj.NumeroExtEmpresa;
                            proyecto.EmpresaResidencias.NoInt = obj.NumeroIntEmpresa;
                            proyecto.EmpresaResidencias.Colonia = obj.ColoniaEmpresa;
                            proyecto.EmpresaResidencias.Municipio = obj.MunicipioEmpresa;
                            proyecto.EmpresaResidencias.Estado = obj.EstadoEmpresa;
                            proyecto.EmpresaResidencias.CodigoPostal = obj.CodigoPostalEmpresa;
                            proyecto.EmpresaResidencias.PaginaWeb = obj.PaginaWeb;
                            proyecto.EmpresaResidencias.RedSocial = obj.RedSocial;

                            result.Objects.Add(proyecto);
                        }
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                    }
                }
            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
            }
            return result;
        }

        public static ML.Result GetById(int IdProyecto)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL.AreyesTescoServicioContext context =  new DL.AreyesTescoServicioContext())
                {
                    var query = context.Proyectos.FromSqlRaw($"ResidenciaGetById {IdProyecto}").AsEnumerable().FirstOrDefault();
                    result.Objects = new List<object>();

                    if(query != null)
                    {
                        ML.Proyecto proyecto = new ML.Proyecto();
                        proyecto.ModalidadResidencias = new ML.ModalidadResidencias();
                        proyecto.Candidato = new ML.DatosPersonalesResidencia();
                        proyecto.Candidato.Carrera = new ML.Carrera();
                        proyecto.EmpresaResidencias = new ML.EmpresaResidencias();
                        proyecto.EmpresaResidencias.TipoEmpresa = new ML.TipoEmpresa();
                        proyecto.EmpresaResidencias.Giro = new ML.GiroEmpresa();
                        proyecto.EmpresaResidencias.Sector = new ML.Sector();

                        proyecto.IdProyecto = query.IdProyecto;
                        proyecto.ModalidadResidencias.IdModalidadResidencias = query.IdModalidadResidencias;
                        proyecto.ModalidadResidencias.Modalidad = query.Modalidad;
                        proyecto.NombreIntegranteUno = query.NombreIntegranteUno;
                        proyecto.NombreIntegranteDos = query.NombreIntegranteDos;
                        proyecto.MatriculaIntegranteUno = query.MatriculaIntegranteUno;
                        proyecto.MatriculaIntegranteDos = query.MatriculaIntegranteDos;
                        proyecto.NombreProyecto = query.NombreProyecto;
                        proyecto.NombreAsesorTesco = query.NombreAsesorTesco;
                        proyecto.NombreAsesorDependencia = query.NombreAsesorDependencia;
                        proyecto.Candidato.IdCandidato = query.IdCandidato;
                        proyecto.Candidato.NombreCompleto = query.NombreCompleto;
                        proyecto.Candidato.Sexo = query.Sexo;
                        proyecto.Candidato.Telefono = query.Telefono;
                        proyecto.Candidato.CorreoElectronico = query.CorreoElectronico;
                        proyecto.Candidato.Calle = query.Calle;
                        proyecto.Candidato.NoExt = query.NoExt;
                        proyecto.Candidato.NoInt = query.NoInt;
                        proyecto.Candidato.Colonia = query.Colonia;
                        proyecto.Candidato.Municipio = query.Municipio;
                        proyecto.Candidato.Estado = query.Estado;
                        proyecto.Candidato.CodigoPostal = query.CodigoPostal;
                        proyecto.Candidato.Carrera.IdCarrera = query.IdCarrera;
                        proyecto.Candidato.Carrera.Nombre = query.CarreraDeAlumno;
                        proyecto.Candidato.Especialidad = query.Especialidad;
                        proyecto.Candidato.Matricula = query.Matricula;
                        proyecto.Candidato.VidaAcademica = query.VidaAcademica;
                        proyecto.Candidato.NoCreditos = query.NoCreditos;
                        proyecto.Candidato.ConstanciaTerminoServicioSocial = query.ConstanciaTerminoServicioSocial;
                        proyecto.EmpresaResidencias.IdEmpresaResidencias = query.IdEmpresaResidencias;
                        proyecto.EmpresaResidencias.NombreDeEmpresa = query.NombreDeEmpresa;
                        proyecto.EmpresaResidencias.TipoEmpresa.IdTipoEmpresa = query.IdTipoEmpresa;
                        proyecto.EmpresaResidencias.TipoEmpresa.TipoDeEmpresa = query.TipoEmpresa;
                        proyecto.EmpresaResidencias.Giro.IdGiro = query.IdGiro;
                        proyecto.EmpresaResidencias.Giro.Giro = query.Giro;
                        proyecto.EmpresaResidencias.Sector.IdSector = query.IdSector;
                        proyecto.EmpresaResidencias.Sector.SectorTipo = query.Sector;
                        proyecto.EmpresaResidencias.NombreTitular = query.TitularEmpresa;
                        proyecto.EmpresaResidencias.Cargo = query.Cargo;
                        proyecto.EmpresaResidencias.Telefono = query.TelefonoDeTitular;
                        proyecto.EmpresaResidencias.Extencion = query.Extencion;
                        proyecto.EmpresaResidencias.CorreoElectronico = query.CorreoDelTitular;
                        proyecto.EmpresaResidencias.Calle = query.CalleEmpresa;
                        proyecto.EmpresaResidencias.NoExt = query.NumeroExtEmpresa;
                        proyecto.EmpresaResidencias.NoInt = query.NumeroIntEmpresa;
                        proyecto.EmpresaResidencias.Colonia = query.ColoniaEmpresa;
                        proyecto.EmpresaResidencias.Municipio = query.MunicipioEmpresa;
                        proyecto.EmpresaResidencias.Estado = query.EstadoEmpresa;
                        proyecto.EmpresaResidencias.CodigoPostal = query.CodigoPostalEmpresa;
                        proyecto.EmpresaResidencias.PaginaWeb = query.PaginaWeb;
                        proyecto.EmpresaResidencias.RedSocial = query.RedSocial;

                        result.Object = proyecto;
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                    }
                }
            }
            catch(Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
            }
            return result;
        }

        

    }
}
