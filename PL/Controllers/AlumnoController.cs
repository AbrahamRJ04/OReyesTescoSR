using Microsoft.AspNetCore.Mvc;

namespace PL.Controllers
{
    public class AlumnoController : Controller
    {
        [HttpGet]
        public IActionResult GetAll()
        {
            ML.Result result = BL.Alumno.GetAll();
            if (result.Correct)
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

        [HttpGet]
        public IActionResult Form(int? IdAlumno)
        {
            ML.Result result = new ML.Result();
            if(IdAlumno != null)
            {

            }
            else
            {

            }
            return View();
        }



        [HttpGet]
        public IActionResult Delete(int IdAlumno)
        {
            ML.Result result = BL.Alumno.GetById(IdAlumno);
            if (result.Correct)
            {
                ML.Alumno alumno = new ML.Alumno();
                alumno = (ML.Alumno)result.Object;
                ML.Result result1 = BL.Alumno.Delete(alumno);
                if (result1.Correct)
                {
                    ViewBag.Mensaje = "Registro eliminado correctamente";
                }
                else
                {
                    ViewBag.Mensaje = "Ocurrio un error al eliminar el registro: " + result1.ErrorMessage;
                }
            }
            else
            {
                ViewBag.Mensaje = "Ocurrio un error al Obtener  el registro";
            }
            return PartialView("Modal");
        }

    }
}
