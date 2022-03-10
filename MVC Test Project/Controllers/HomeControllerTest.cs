using Microsoft.AspNetCore.Mvc;
using MVC_Project.Controllers;
using NUnit.Framework;

namespace MVC_Test_Project
{
    public class HomeControllerTest
    {
        
      
        [Test]
        public void Index()
        {
            //Arrange
            HomeController controller = new HomeController(null);

            //Act
            ViewResult result = controller.Index() as ViewResult;

            //Assert
            Assert.IsNotNull(result);   
        }
    }
}