using Microsoft.AspNetCore.Mvc;

namespace PL.Controllers
{
    public class AlumnoController : Controller
    {
        [HttpGet]
        public IActionResult GetAll()
        {
            ML.Result result = BL.Alumno.GetAll();
            if(result.Correct)
            {
                ML.Alumno alumno = new ML.Alumno();
                alumno.Alumnos = result.Objects;
                return View(alumno);
            }
            else
            {
                ViewBag.Mensaje = "Ocurrio un error al realizar la operacion";
            }
            return View();
        }
    }
}
