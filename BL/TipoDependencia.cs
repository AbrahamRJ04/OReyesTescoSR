using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class TipoDependencia
    {
        public static ML.Result GetAll()
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL.AReyesTescoServicioContext contex = new DL.AReyesTescoServicioContext())
                {
                    var query = contex.TipoDependencia.FromSqlRaw($"TipoDependenciaGetAll").ToList();
                    result.Objects = new List<object>();

                    if (query != null)
                    {
                        foreach (var obj in query)
                        {
                            ML.TipoDependencia dependencia = new ML.TipoDependencia();
                            dependencia.IdTipoDependencia = obj.IdTipoDependencia;
                            dependencia.Nombre = obj.Nombre;
                            result.Objects.Add(dependencia);

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
    }
}
