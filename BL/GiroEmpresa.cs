using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class GiroEmpresa
    {
        public static ML.Result GetAll()
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL.AReyesTescoServicioContext context = new DL.AReyesTescoServicioContext())
                {
                    var query = context.GiroEmpresas.FromSqlRaw("GiroEmpresaGetAll").ToList();
                    result.Objects = new List<object>();

                    if(query != null)
                    {
                        foreach(var obj in query)
                        {
                            ML.GiroEmpresa giroEmpresa = new ML.GiroEmpresa();

                            giroEmpresa.IdGiro = obj.IdGiro;
                            giroEmpresa.Giro = obj.Giro;

                            result.Objects.Add(giroEmpresa);
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
