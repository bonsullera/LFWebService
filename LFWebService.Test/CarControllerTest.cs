using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using LFWebService.Controllers;
using Moq;
using LFWebService.Models;
using System.Web.Http.Results;
using System.Web.Http;
using System.Threading.Tasks;

namespace LFWebService.Test
{
    [TestClass]
    public class CarControllerTest
    {
        CarController _sut;

        public void TestInitialize()
        {
            _sut = new CarController();
        }

        [TestCleanup]
        public void TestCleanup()
        {
            _sut = null;
        }

        [TestMethod]
        public void GetCars_SupplyCorrectObject_ReturnExpectedresults()
        { 
        
        }

       

        //[TestMethod]
        //public void GetCars()//_SupplyCorrectObject_ReturnExpectedresults()
        //{
        //    // Arrange
        //    var _mock = new Mock<CarController>();
        //    _mock.Setup(p => p.GetCars(It.IsAny<CarModels>())).Returns(new OkNegotiatedContentResult<Result>(new OkResult(Result), new CarController()));
        //    //.Returns(2020);


        //    // Act
        //    var testObject = new CarController(_mock.Object);
        //    var viewResult = testObject.GetCars(new CarModels()).Result as ViewResult;
        //    var actual = _sut.GetCars();

        //    // Assert
        //    Assert.AreEqual(2020, actual);
        //}

        //[TestMethod]
        //public void GetCars_SupplyCorrectObject_ReturnExpectedresults()
        //{
        //    // if your action returns: NotFound()
        //    IHttpActionResult actionResult = CarController.GetCars(10);
        //    Assert.IsInstanceOfType<NotFoundResult>(actionResult);

        //    // if your action returns: Ok()
        //    actionResult = valuesController.Get(11);
        //    Assert.IsType<OkResult>(actionResult);

        //    // if your action was returning data in the body like: Ok<string>("data: 12")
        //    actionResult = valuesController.Get(12);
        //    OkNegotiatedContentResult<string> conNegResult = Assert.IsType<OkNegotiatedContentResult<string>>(actionResult);
        //    Assert.Equal("data: 12", conNegResult.Content);

        //    // if your action was returning data in the body like: Content<string>(HttpStatusCode.Accepted, "some updated data");
        //    actionResult = valuesController.Get(13);
        //    NegotiatedContentResult<string> negResult = Assert.IsType<NegotiatedContentResult<string>>(actionResult);
        //    Assert.Equal(HttpStatusCode.Accepted, negResult.StatusCode);
        //    Assert.Equal("some updated data", negResult.Content);
        //}
    }
}
