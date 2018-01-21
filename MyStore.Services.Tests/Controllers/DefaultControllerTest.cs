using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyStore.Services.Controllers;

namespace MyStore.Services.Tests.Controllers
{
    [TestClass]
    public class DefaultControllerTest
    {
        [TestMethod]
        public void Welcome_Always_ReturnsExpectedMessage()
        {
            // Arrange
            DefaultController controller = new DefaultController();

            // Act
            ViewResult result = controller.Welcome() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("My Store API", result.ViewBag.Title);
        }
    }
}
