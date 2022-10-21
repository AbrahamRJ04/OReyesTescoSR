using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ML;

namespace BL
{
    public class Alumno
    {
        public static ML.Result GetAll()
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL.AReyesTescoServicioContext context = new DL.AReyesTescoServicioContext())
                {
                    var query = context.Alumnos.FromSqlRaw($"AlumnoGetAll").ToList();
                    result.Objects = new List<object>();
                    if(query != null)
                    {
                        foreach(var item in query)
                        {
                            ML.Alumno alumno = new ML.Alumno();

                            alumno.IdAlumno = item.IdAlumno;
                            alumno.Nombre = item.Nombre;
                            alumno.ApellidoPaterno = item.ApellidoPaterno;
                            alumno.ApellidoMaterno = item.ApellidoMaterno;
                            alumno.CorreoInstitucional = item.CorreoInstitucional;
                            alumno.Telefono = item.Telefono;
                            alumno.Edad = item.Edad;
                            alumno.Sexo = item.Sexo;
                            alumno.Carreras = new ML.Carrera();
                            alumno.Carreras.IdCarrera = item.IdCarrera;
                            alumno.Carreras.Nombre = item.NombreCarrera;
                            alumno.Curp = item.Curp;
                            alumno.NumeroCreditos = item.NumeroCreditos;
                            alumno.VidaAcademica = item.VidaAcademica;
                            alumno.Promedio = item.Promedio;
                            alumno.ServicioSocial = new ML.ServicioSocial();
                            alumno.ServicioSocial.IdServicioSocial = item.IdServicioSocial;
                            alumno.ServicioSocial.NombreDependencia = item.NombreDependencia;
                            alumno.ServicioSocial.Dependencia = new ML.TipoDependencia();
                            alumno.ServicioSocial.Dependencia.IdTipoDependencia = item.IdTipoDependencia;
                            alumno.ServicioSocial.Dependencia.Nombre = item.TipoDeDependencia;
                            alumno.ServicioSocial.NombreDepartamento = item.NombreDepartamento;
                            alumno.ServicioSocial.Domicilio = item.Domicilio;
                            alumno.ServicioSocial.Municipio = item.Municipio;
                            alumno.ServicioSocial.Telefono = item.TelefonoDependencia;
                            alumno.ServicioSocial.ResponsableNombre = item.ResponsableNombre;
                            alumno.ServicioSocial.CargoResponsable = item.CargoResponsable;
                            alumno.ServicioSocial.Programa = new ML.Programa();
                            alumno.ServicioSocial.Programa.IdPrograma = item.IdPrograma;
                            alumno.ServicioSocial.Programa.Nombre = item.NombrePrograma;
                            alumno.ServicioSocial.Actividades = item.Actividades;
                            alumno.ServicioSocial.HorasAlDia = item.HorasAlDia;
                            alumno.ServicioSocial.Turno = item.Turno;
                            alumno.ServicioSocial.FechaInicio = item.FechaInicio.ToString("dd-MM-yyyy");
                            alumno.ServicioSocial.FechaTermino = item.FechaTermino.ToString("dd-MM-yyyy");
                            alumno.ServicioSocial.TipoServicio = new ML.TipoServicio();
                            alumno.ServicioSocial.TipoServicio.IdTipoServicio = item.IdTipoServicio;
                            alumno.ServicioSocial.TipoServicio.Nombre = item.TipoDeServicio;

                            result.Objects.Add(alumno);
                        }
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