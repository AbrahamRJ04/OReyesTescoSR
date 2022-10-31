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

            ML.Alumno alumno = new ML.Alumno();
            alumno.Carreras = new ML.Carrera();
            alumno.ServicioSocial = new ML.ServicioSocial();
            alumno.ServicioSocial.Programa = new ML.Programa();
            alumno.ServicioSocial.TipoServicio = new ML.TipoServicio();
            alumno.ServicioSocial.Dependencia = new ML.TipoDependencia();

            //Carga de DropDownList
            ML.Result resultCarrera = BL.Carreras.GetAll();
            ML.Result resultPrograma = BL.Programa.GetAll();
            ML.Result resultServicio = BL.TipoServicio.GetAll();
            ML.Result resultDependencia = BL.TipoDependencia.GetAll();

            if (IdAlumno == null)
            {
                alumno.Carreras.CarrerasList = resultCarrera.Objects;
                alumno.ServicioSocial.Programa.Programas = resultPrograma.Objects;
                alumno.ServicioSocial.TipoServicio.TipoServicios = resultServicio.Objects;
                alumno.ServicioSocial.Dependencia.Dependencias = resultDependencia.Objects;

                return View(alumno);
            }
            else
            {

            }
            return View();
        }

        [HttpPost]
        public IActionResult Form(ML.Alumno alumno)
        {
            ML.Result result = new ML.Result();

            if(alumno.IdAlumno == 0 )
            {
                result = BL.Alumno.Add(alumno);
                if(result.Correct)
                {
                    ViewBag.Mensaje = "Registro correcto";
                }
                else
                {
                    ViewBag.Mensaje = "Ocurrio un error al inserta el registro";
                }
            }
            else
            {
                //AQUI VA EL METODO DE ACTUALIZAR
            }
            return View(alumno);
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
