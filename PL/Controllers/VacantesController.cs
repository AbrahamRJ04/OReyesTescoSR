using Microsoft.AspNetCore.Mvc;

namespace PL.Controllers
{
    public class VacantesController : Controller
    {
        [HttpGet]
        public IActionResult GetAll()
        {
            ML.VacantesServicioSocial vacante = new ML.VacantesServicioSocial();
            ML.Result result = BL.VacantesServicioSocial.GetAll();

            if(result.Correct)
            {
                vacante.Vacantes = result.Objects;
            }
            return View(vacante);
        }
    }
}
