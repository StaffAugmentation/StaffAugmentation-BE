using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Moq;
using Xunit;
using API.Controllers;
using Business.IServices;
using Core.ViewModel;
using Microsoft.Extensions.Logging;
using Castle.Core.Logging;

namespace TestProject.UnitTests.Systems.Controllers
{
    public class TestPlaceOfDeliveryController
    {
        private readonly PlaceOfDeliveryController _controller;

        public TestPlaceOfDeliveryController()
        {
            var loggerFactory = LoggerFactory.Create(builder => { builder.AddConsole(); });
            var logger = loggerFactory.CreateLogger<PlaceOfDeliveryController>();
            var mockPlaceOfDeliveryService = new Mock<IPlaceOfDeliveryService>();
            mockPlaceOfDeliveryService.Setup(svc => svc.GetPlaceOfDelivery().Result).Returns(new List<PlaceOfDeliveryViewModel>
                {
                    new PlaceOfDeliveryViewModel { Id = 1, ValueId = "Place Of Delivery 1", IsActive = false },
                    new PlaceOfDeliveryViewModel { Id = 2, ValueId = "Place Of Delivery 2", IsActive = true },
                    new PlaceOfDeliveryViewModel { Id = 3, ValueId = "Place Of Delivery 3", IsActive = false },
                });
            _controller = new PlaceOfDeliveryController(logger, mockPlaceOfDeliveryService.Object);
        }

        [Fact]
        public async Task Get_OnReturnsData()
        {
            // Act
            var result = await _controller.GetAll();

            // Assert
            Assert.IsType<ActionResult<List<PlaceOfDeliveryViewModel>?>?>(result);
        }

        [Fact]
        public async Task GetPlaceOfDelivery_OnReturnsData()
        {
            // Act
            var result = await _controller.GetPlaceOfDelivery(100);

            // Assert
            Assert.IsType<ActionResult<PlaceOfDeliveryViewModel?>?>(result);
        }

        [Fact]
        public async Task Create_OnReturnsData()
        {
            // Act
            var result = await _controller.CreatePlaceOfDelivery(new PlaceOfDeliveryViewModel { Id = 4, ValueId = "Place Of Delivery 4", IsActive = false });

            // Assert
            Assert.IsType<ActionResult<PlaceOfDeliveryViewModel?>>(result);
        }

        [Fact]
        public async Task Update_OnReturnsData()
        {
            // Act
            var result = await _controller.UpdatePlaceOfDelivery(new PlaceOfDeliveryViewModel { Id = 4, ValueId = "Place Of Delivery 4", IsActive = false });

            // Assert
            Assert.IsType<ActionResult<PlaceOfDeliveryViewModel?>>(result);
        }

        [Fact]
        public async Task Delete_OnReturnsData()
        {
            // Act
            var result = await _controller.DeletePlaceOfDelivery(4);

            // Assert
            Assert.IsType<ActionResult<List<PlaceOfDeliveryViewModel>>>(result);
        }
    }
}