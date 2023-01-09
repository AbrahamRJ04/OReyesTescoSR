using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class TipoEmpresa
    {
        public static ML.Result GetAll()
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL.AreyesTescoServicioContext context = new DL.AreyesTescoServicioContext())
                {
                    var query = context.TipoEmpresas.FromSqlRaw("TipoEmpresaGetAll").ToList();
                    result.Objects = new List<object>();

                    if(query != null)
                    {
                        foreach (var obj in query)
                        {
                            ML.TipoEmpresa tipoEmpresa = new ML.TipoEmpresa();

                            tipoEmpresa.IdTipoEmpresa = obj.IdTipoEmpresa;
                            tipoEmpresa.TipoDeEmpresa = obj.TipoEmpresa1;

                            result.Objects.Add(tipoEmpresa);
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
                result.Correct = true;
                result.ErrorMessage = ex.Message;
            }
            return result;
        }
    }
}
