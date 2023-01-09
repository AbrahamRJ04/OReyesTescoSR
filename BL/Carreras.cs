using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Carreras
    {
        public static ML.Result GetAll()
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL.AreyesTescoServicioContext contex = new DL.AreyesTescoServicioContext())
                {
                    var query = contex.Carreras.FromSqlRaw($"CarreraGetAll").ToList();
                    result.Objects = new List<object>();

                    if(query != null)
                    {
                        foreach(var obj in query)
                        {
                            ML.Carrera carrera = new ML.Carrera();
                            carrera.IdCarrera = obj.IdCarrera;
                            carrera.Nombre = obj.Nombre;
                            result.Objects.Add(carrera);
                            
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
