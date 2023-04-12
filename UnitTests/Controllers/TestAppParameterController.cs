using Microsoft.AspNetCore.Mvc;
using Moq;
using Xunit;
using API.Controllers;
using Business.IServices;
using Core.ViewModel;
using Microsoft.Extensions.Logging;

namespace UnitTests.Controllers
{
    public class TestAppParameterController
    {
        private readonly AppParameterController _controller;

        public TestAppParameterController()
        {
            var loggerFactory = LoggerFactory.Create(builder => { builder.AddConsole(); });
            var logger = loggerFactory.CreateLogger<AppParameterController>();
            var mockAppParameterService = new Mock<IAppParameterService>();
            mockAppParameterService.Setup(svc => svc.GetAppParameter().Result).Returns(new List<AppParameterViewModel>
                {
                    new AppParameterViewModel { Id = 1, DaysBeforeDeletingFile = 2, SAEmail = "Email 1" },
                    new AppParameterViewModel { Id = 2, DaysBeforeDeletingFile = 5, SAEmail = "Email 2" },
                    new AppParameterViewModel { Id = 3, DaysBeforeDeletingFile = 15, SAEmail = "Email 3" }
                });
            _controller = new AppParameterController(logger, mockAppParameterService.Object);
        }

        [Fact]
        public async Task Get_OnReturnsData()
        {
            // Act
            var result = await _controller.GetAll();

            // Assert
            Assert.IsType<ActionResult<List<AppParameterViewModel>?>?>(result);
        }

        [Fact]
        public async Task GetAppParameter_OnReturnsData()
        {
            // Act
            var result = await _controller.GetAppParameter(100);

            // Assert
            Assert.IsType<ActionResult<AppParameterViewModel?>?>(result);
        }

        [Fact]
        public async Task Create_OnReturnsData()
        {
            // Act
            var result = await _controller.CreateAppParameter(new AppParameterViewModel { Id = 4, DaysBeforeDeletingFile = 20, SAEmail = "Email 4"});

            // Assert
            Assert.IsType<ActionResult<AppParameterViewModel?>>(result);
        }

        [Fact]
        public async Task Update_OnReturnsData()
        {
            // Act
            var result = await _controller.UpdateAppParameter(new AppParameterViewModel { Id = 4, SAEmail = "Email updated 4" });

            // Assert
            Assert.IsType<ActionResult<AppParameterViewModel?>>(result);
        }

        [Fact]
        public async Task Delete_OnReturnsData()
        {
            // Act
            var result = await _controller.DeleteAppParameter(4);

            // Assert
            Assert.IsType<ActionResult<List<AppParameterViewModel>>>(result);
        }
    }
}