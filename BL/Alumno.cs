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
                using (DL.AreyesTescoServicioContext context = new DL.AreyesTescoServicioContext())
                {
                    var query = context.Alumnos.FromSqlRaw($"AlumnoGetAll").ToList();
                    result.Objects = new List<object>();
                    if (query != null)
                    {
                        foreach (var item in query)
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
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
            }
            return result;
        }

        public static ML.Result Delete(ML.Alumno alumno)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL.AreyesTescoServicioContext context = new DL.AreyesTescoServicioContext())
                {
                    var query = context.Database.ExecuteSqlRaw($"AlumnoDelete {alumno.IdAlumno},{alumno.ServicioSocial.IdServicioSocial}");
                    if (query > 0)
                    {
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

        public static ML.Result GetById(int IdAlumno)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL.AreyesTescoServicioContext context = new DL.AreyesTescoServicioContext())
                {
                    var query = context.Alumnos.FromSqlRaw($"AlumnoGetById {IdAlumno}").AsEnumerable().FirstOrDefault();
                    if (query != null)
                    {
                        ML.Alumno alumno = new ML.Alumno();
                        alumno.IdAlumno = query.IdAlumno;
                        alumno.Nombre = query.Nombre;
                        alumno.ApellidoPaterno = query.ApellidoPaterno;
                        alumno.ApellidoMaterno = query.ApellidoMaterno;
                        alumno.CorreoInstitucional = query.CorreoInstitucional;
                        alumno.Telefono = query.Telefono;
                        alumno.Edad = query.Edad;
                        alumno.Sexo = query.Sexo;
                        alumno.Carreras = new ML.Carrera();
                        alumno.Carreras.IdCarrera = query.IdCarrera;
                        alumno.Carreras.Nombre = query.NombreCarrera;
                        alumno.Curp = query.Curp;
                        alumno.NumeroCreditos = query.NumeroCreditos;
                        alumno.VidaAcademica = query.VidaAcademica;
                        alumno.Promedio = query.Promedio;
                        alumno.ServicioSocial = new ML.ServicioSocial();
                        alumno.ServicioSocial.IdServicioSocial = query.IdServicioSocial;
                        alumno.ServicioSocial.NombreDependencia = query.NombreDependencia;
                        alumno.ServicioSocial.Dependencia = new ML.TipoDependencia();
                        alumno.ServicioSocial.Dependencia.IdTipoDependencia = query.IdTipoDependencia;
                        alumno.ServicioSocial.Dependencia.Nombre = query.TipoDeDependencia;
                        alumno.ServicioSocial.NombreDepartamento = query.NombreDepartamento;
                        alumno.ServicioSocial.Domicilio = query.Domicilio;
                        alumno.ServicioSocial.Municipio = query.Municipio;
                        alumno.ServicioSocial.Telefono = query.TelefonoDependencia;
                        alumno.ServicioSocial.ResponsableNombre = query.ResponsableNombre;
                        alumno.ServicioSocial.CargoResponsable = query.CargoResponsable;
                        alumno.ServicioSocial.Programa = new ML.Programa();
                        alumno.ServicioSocial.Programa.IdPrograma = query.IdPrograma;
                        alumno.ServicioSocial.Programa.Nombre = query.NombrePrograma;
                        alumno.ServicioSocial.Actividades = query.Actividades;
                        alumno.ServicioSocial.HorasAlDia = query.HorasAlDia;
                        alumno.ServicioSocial.Turno = query.Turno;
                        alumno.ServicioSocial.FechaInicio = query.FechaInicio.ToString("dd-MM-yyyy");
                        alumno.ServicioSocial.FechaTermino = query.FechaTermino.ToString("dd-MM-yyyy");
                        alumno.ServicioSocial.TipoServicio = new ML.TipoServicio();
                        alumno.ServicioSocial.TipoServicio.IdTipoServicio = query.IdTipoServicio;
                        alumno.ServicioSocial.TipoServicio.Nombre = query.TipoDeServicio;

                        result.Object = alumno;
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

        public static ML.Result Add(ML.Alumno alumno)
        {
            string TelefonoAlumno;
            ML.Result result = new ML.Result();
            try
            {
                TelefonoAlumno = alumno.Telefono;
                using (DL.AreyesTescoServicioContext context = new DL.AreyesTescoServicioContext())
                {
                    var query = context.Database.ExecuteSqlRaw($"AlumnoAdd '{alumno.ServicioSocial.NombreDependencia}',{alumno.ServicioSocial.Dependencia.IdTipoDependencia},'{alumno.ServicioSocial.NombreDepartamento}','{alumno.ServicioSocial.Domicilio}','{alumno.ServicioSocial.Municipio}','{alumno.ServicioSocial.Telefono}','{alumno.ServicioSocial.ResponsableNombre}','{alumno.ServicioSocial.CargoResponsable}',{alumno.ServicioSocial.Programa.IdPrograma},'{alumno.ServicioSocial.Actividades}',{alumno.ServicioSocial.HorasAlDia},'{alumno.ServicioSocial.Turno}','{alumno.ServicioSocial.FechaInicio}','{alumno.ServicioSocial.FechaTermino}',{alumno.ServicioSocial.TipoServicio.IdTipoServicio},'{alumno.Nombre}','{alumno.ApellidoPaterno}','{alumno.ApellidoMaterno}','{alumno.CorreoInstitucional}','{TelefonoAlumno}',{alumno.Edad},'{alumno.Sexo}',{alumno.Carreras.IdCarrera},'{alumno.Curp}','{alumno.NumeroCreditos}','{alumno.VidaAcademica}',{alumno.Promedio}");
                    if (query > 0)
                    {
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

        public static ML.Result Update(ML.Alumno alumno)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL.AreyesTescoServicioContext context = new DL.AreyesTescoServicioContext())
                {
                    var query = context.Database.ExecuteSqlRaw($"AlumnoUpdate {alumno.ServicioSocial.IdServicioSocial},'{alumno.ServicioSocial.NombreDependencia}',{alumno.ServicioSocial.Dependencia.IdTipoDependencia},'{alumno.ServicioSocial.NombreDepartamento}','{alumno.ServicioSocial.Domicilio}','{alumno.ServicioSocial.Municipio}','{alumno.ServicioSocial.Telefono}','{alumno.ServicioSocial.ResponsableNombre}','{alumno.ServicioSocial.CargoResponsable}',{alumno.ServicioSocial.Programa.IdPrograma},'{alumno.ServicioSocial.Actividades}',{alumno.ServicioSocial.HorasAlDia},'{alumno.ServicioSocial.Turno}','{alumno.ServicioSocial.FechaInicio}','{alumno.ServicioSocial.FechaTermino}',{alumno.ServicioSocial.TipoServicio.IdTipoServicio},{alumno.IdAlumno},'{alumno.Nombre}','{alumno.ApellidoPaterno}','{alumno.ApellidoMaterno}','{alumno.CorreoInstitucional}','{alumno.Telefono}',{alumno.Edad},'{alumno.Sexo}',{alumno.Carreras.IdCarrera},'{alumno.Curp}','{alumno.NumeroCreditos}','{alumno.VidaAcademica}',{alumno.Promedio}");
                    if(query > 0)
                    {
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
    }
}