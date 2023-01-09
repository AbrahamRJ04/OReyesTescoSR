using Xunit.Sdk;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject
{
    [TestClass]
    public class UnitTest1
    {
        //[TestMethod]
        //public void TestMethod1()
        //{
        //    var IdProyecto = 2;

        //    ML.Result result = BL.ResidenciasProfesionales.GetById(IdProyecto);

        //    Assert.IsTrue(result.Correct);
        //}

        //[TestMethod]
        //public void VacanteGetAll()
        //{
        //    ML.Result result = BL.VacantesServicioSocial.GetAll();

        //    Assert.IsTrue(result.Correct);
        //}

        //[TestMethod]
        //public void VacanteGetById()
        //{
        //    int IdVcante = 1;
        //    ML.Result result = BL.VacantesServicioSocial.GetById(IdVcante);

        //    Assert.IsTrue(result.Correct);
        //}

        //[TestMethod]
        //public void VacanteUpdate()
        //{
        //    ML.VacantesServicioSocial vacante = new ML.VacantesServicioSocial();
        //    vacante.IdVacante = 1;
        //    vacante.Nombre = "y";
        //    vacante.Telefono = "y";
        //    vacante.Direccion = "y";
        //    vacante.Descripcion = "y";
        //    vacante.Logo = "xdd";

        //    ML.Result result = BL.VacantesServicioSocial.Update(vacante);

        //    Assert.IsTrue(result.Correct);
        //}

        [TestMethod]
        public void GetAllProyecto()
        {
           
            int IdVacante = 2;

            ML.Result result = BL.ResidenciasProfesionales.GetById(IdVacante);

            Assert.IsTrue(result.Correct);
        }
    }
}