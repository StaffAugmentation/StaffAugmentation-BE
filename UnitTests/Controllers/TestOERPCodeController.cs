using Microsoft.AspNetCore.Mvc;
using Moq;
using Xunit;
using API.Controllers;
using Business.IServices;
using Core.ViewModel;
using Microsoft.Extensions.Logging;

namespace UnitTests.Controllers
{
    public class TestOERPCodeController
    {
        private readonly OERPCodeController _controller;

        public TestOERPCodeController()
        {
            var loggerFactory = LoggerFactory.Create(builder => { builder.AddConsole(); });
            var logger = loggerFactory.CreateLogger<OERPCodeController>();
            var mockOERPCodeService = new Mock<IOERPCodeService>();
            mockOERPCodeService.Setup(svc => svc.GetOERPCode().Result).Returns(new List<OERPCodeViewModel>
                {
                    new OERPCodeViewModel { Id = 1, Value = "OERPCode 1", IsActive = true },
                    new OERPCodeViewModel { Id = 2, Value = "OERPCode 2", IsActive = true },
                    new OERPCodeViewModel { Id = 3, Value = "OERPCode 3", IsActive = false }
                });
            _controller = new OERPCodeController(logger, mockOERPCodeService.Object);
        }

        [Fact]
        public async Task Get_OnReturnsData()
        {
            // Act
            var result = await _controller.GetAll();

            // Assert
            Assert.IsType<ActionResult<List<OERPCodeViewModel>?>?>(result);
        }

        [Fact]
        public async Task GetOERPCode_OnReturnsData()
        {
            // Act
            var result = await _controller.GetOERPCode(100);

            // Assert
            Assert.IsType<ActionResult<OERPCodeViewModel?>?>(result);
        }

        [Fact]
        public async Task Create_OnReturnsData()
        {
            // Act
            var result = await _controller.CreateOERPCode(new OERPCodeViewModel { Id = 4, Value = "OERPCode 4", IsActive = false });

            // Assert
            Assert.IsType<ActionResult<OERPCodeViewModel?>>(result);
        }

        [Fact]
        public async Task Update_OnReturnsData()
        {
            // Act
            var result = await _controller.UpdateOERPCode(new OERPCodeViewModel { Id = 4, Value = "OERPCode 4", IsActive = false });

            // Assert
            Assert.IsType<ActionResult<OERPCodeViewModel?>>(result);
        }

        [Fact]
        public async Task Delete_OnReturnsData()
        {
            // Act
            var result = await _controller.DeleteOERPCode(4);

            // Assert
            Assert.IsType<ActionResult<List<OERPCodeViewModel>>>(result);
        }
    }
}