using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class ModalidadResidencias
    {
        public static ML.Result GetAll()
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL.AReyesTescoServicioContext context = new DL.AReyesTescoServicioContext())
                {
                    var query = context.ModalidadResidencias.FromSqlRaw("ModalidadResidenciasGetAll").ToList();
                    result.Objects = new List<object>();

                    if (query != null)
                    {
                        foreach (var obj in query)
                        {
                            ML.ModalidadResidencias modalidad = new ML.ModalidadResidencias();

                            modalidad.IdModalidadResidencias = obj.IdModalidadResidencias;
                            modalidad.Modalidad = obj.Modalidad;

                            result.Objects.Add(modalidad);
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
