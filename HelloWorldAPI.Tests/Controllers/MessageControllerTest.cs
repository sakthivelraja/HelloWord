using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HelloWorldAPI;
using HelloWorldAPI.Controllers;

namespace HelloWorldAPI.Tests.Controllers
{
    [TestClass]
    public class ValuesControllerTest
    {
        [TestMethod]
        public void Get()
        {
            // Arrange
            MessageController controller = new MessageController();

            // Act
            string result = controller.Get();

            // Assert
            Assert.AreEqual("Hello World", result);
        }

        [TestMethod]
        public void GetById()
        {
            // Arrange
            MessageController controller = new MessageController();

            // Act
            string result = controller.Get();

            // Assert
            Assert.AreEqual("value", result);
        }

    }
}
