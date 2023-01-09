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

            if (result.Correct)
            {
                vacante.Vacantes = result.Objects;
            }
            return View(vacante);
        }

        [HttpGet]
        public ActionResult Form(int? IdVacante)
        {
            var vacante = new ML.VacantesServicioSocial();

            if (IdVacante != null)
            {
                var result = BL.VacantesServicioSocial.GetById(IdVacante.Value);

                if (result.Correct)
                {
                    vacante = (ML.VacantesServicioSocial)result.Object;
                }
                else
                {
                    return View("Modal");
                }
            }
            return View(vacante);
        }

        [HttpPost]
        public ActionResult Form(ML.VacantesServicioSocial vacante)
        {
            IFormFile image = Request.Form.Files["IFImage"];


            //valido si traigo imagen
            if (image != null)
            {
                //llamar al metodo que convierte a bytes la imagen
                byte[] ImagenBytes = ConvertToBytes(image);
                //convierto a base 64 la imagen y la guardo en mi objeto materia
                vacante.Logo = Convert.ToBase64String(ImagenBytes);
            }

            ML.Result result = new ML.Result();

            if (vacante.IdVacante == 0)
            {
                result = BL.VacantesServicioSocial.Add(vacante);

                if (result.Correct)
                {
                    ViewBag.Mensaje = "Registro exitoso";
                }
                else
                {
                    ViewBag.Mensaje = "Ocurrio un error al insertar el registro" + result.ErrorMessage;
                }
            }
            else
            {

                result = BL.VacantesServicioSocial.Update(vacante);
                if (result.Correct)
                {
                    ViewBag.Mensaje = "Actualización existosa";
                }
                else
                {
                    ViewBag.Mensaje = "Ocurrio un error" + result.ErrorMessage;
                }
            }
            return PartialView("Modal");
        }


        [HttpGet]
        public ActionResult Delete(int IdVacante)
        {
            ML.Result result = new ML.Result();
            result = BL.VacantesServicioSocial.Delete(IdVacante);
            if (result.Correct)
            {
                ViewBag.Mensaje = "El registro se elimino correctamente.";
            }
            else
            {
                ViewBag.Mensaje = "Ocurrio un error al insertar el registro" + result.ErrorMessage;
            }
            return PartialView("Modal");
        }


        public static byte[] ConvertToBytes(IFormFile imagen)
        {

            using var fileStream = imagen.OpenReadStream();

            byte[] bytes = new byte[fileStream.Length];
            fileStream.Read(bytes, 0, (int)fileStream.Length);

            return bytes;
        }
    }
}
