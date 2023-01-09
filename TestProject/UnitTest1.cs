using Xunit.Sdk;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var IdProyecto = 2;

            ML.Result result = BL.ResidenciasProfesionales.GetById(IdProyecto);

            Assert.IsTrue(result.Correct);
        }
    }
}