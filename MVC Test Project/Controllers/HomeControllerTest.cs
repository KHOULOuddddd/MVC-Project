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


            //Assert
            Assert.IsNull(result);   
        }
    }
}