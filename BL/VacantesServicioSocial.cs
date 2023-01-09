using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class VacantesServicioSocial
    {
        public static ML.Result GetAll()
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL.AreyesTescoServicioContext context = new DL.AreyesTescoServicioContext())
                {
                    var query = context.VacantesServicioSocials.FromSqlRaw($"VacanteGetAll").ToList();
                    result.Objects = new List<object>();

                    if (query != null)
                    {
                        foreach (var obj in query)
                        {
                            ML.VacantesServicioSocial vacante = new ML.VacantesServicioSocial();

                            vacante.IdVacante = obj.IdVacante;
                            vacante.Nombre = obj.Nombre;
                            vacante.Telefono = obj.Telefono;
                            vacante.Direccion = obj.Direccion;
                            vacante.Descripcion = obj.VacanteDescripcion;
                            vacante.Logo = obj.Logo;

                            result.Objects.Add(vacante);
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

        public static ML.Result GetById(int IdVacante)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL.AreyesTescoServicioContext context = new DL.AreyesTescoServicioContext())
                {
                    var query = context.VacantesServicioSocials.FromSqlRaw($"VacanteGetById {IdVacante}").AsEnumerable().FirstOrDefault();

                    if (query != null)
                    {
                        ML.VacantesServicioSocial vacante = new ML.VacantesServicioSocial();

                        vacante.IdVacante = query.IdVacante;
                        vacante.Nombre = query.Nombre;
                        vacante.Telefono = query.Telefono;
                        vacante.Direccion = query.Direccion;
                        vacante.Descripcion = query.VacanteDescripcion;
                        vacante.Logo = query.Logo;

                        result.Object = vacante;
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

        public static ML.Result Delete(int IdVacante)
        {
            {
                ML.Result result = new ML.Result();
                try
                {
                    using (DL.AreyesTescoServicioContext context = new DL.AreyesTescoServicioContext())
                    {
                        var query = context.Database.ExecuteSqlRaw($"VacanteDelete {IdVacante}");

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
        }

        public static ML.Result Add(ML.VacantesServicioSocial vacante)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL.AreyesTescoServicioContext context = new DL.AreyesTescoServicioContext())
                {
                    var query = context.Database.ExecuteSqlRaw($" VacanteAdd '{vacante.Nombre}','{vacante.Telefono}','{vacante.Direccion}','{vacante.Descripcion}','{vacante.Logo}'");

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

        public static ML.Result Update(ML.VacantesServicioSocial vacante)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL.AreyesTescoServicioContext context = new DL.AreyesTescoServicioContext())
                {
                    var query = context.Database.ExecuteSqlRaw($" VacanteUpdate {vacante.IdVacante}, '{vacante.Nombre}','{vacante.Telefono}','{vacante.Direccion}','{vacante.Descripcion}','{vacante.Logo}'");

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
    }
}
