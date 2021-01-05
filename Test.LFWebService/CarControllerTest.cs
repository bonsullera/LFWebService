using LFWebService.Controllers;
using LFWebService.Interfaces;
using LFWebService.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Web.Http;
using System.Web.Http.Results;

namespace Test.LFWebService
{
    [TestClass]
    public class CarControllerTest
    {
        CarController _sut;
        Mock<ICarRepository> _mockRepository;

        [TestInitialize]
        public void TestInitialize()
        {
            _mockRepository = new Mock<ICarRepository>();
            _sut = new CarController(_mockRepository.Object);

        }

        [TestCleanup]
        public void TestCleanup()
        {
            _mockRepository = null;
            _sut = null;
        }

        [TestMethod]
        public void GetCars_Returns_NotOk()
        {
            // Arrange
            var controller = _sut;

            // Act
            IHttpActionResult actionResult = controller.GetCars(2021);

            // Assert
            Assert.IsInstanceOfType(actionResult, typeof(NotFoundResult));
        }

        [TestMethod]
        public void PostCars_Returns_Ok()
        {
            // Arrange
            var controller = _sut;

            // Act
            IHttpActionResult actionResult = controller.PostCars(3, "Volks", "purple", 2020);

            // Assert
            Assert.IsInstanceOfType(actionResult, typeof(OkResult));
        }

        [TestMethod]
        public void PatchCars_Returns_Ok()
        {
            // Arrange
            var controller = _sut;

            // Act
            IHttpActionResult actionResult = controller.PatchCars(3, "Volks", "purple", 2020);

            // Assert
            Assert.IsInstanceOfType(actionResult, typeof(OkResult));
        }

        [TestMethod]
        public void PatchCars_Returns_NotOk()
        {
            // Arrange
            var controller = _sut;

            // Act
            IHttpActionResult actionResult = controller.PatchCars(5, "Volks", "purple", 2020);

            // Assert
            Assert.IsInstanceOfType(actionResult, typeof(OkResult));
        }
    }
}
