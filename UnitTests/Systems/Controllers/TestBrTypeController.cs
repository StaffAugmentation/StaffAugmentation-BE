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
using System.ComponentModel.Design;

namespace TestProject.UnitTests.Systems.Controllers
{
    public class TestBrTypeController
    {
        private readonly BrTypeController _controller;

        public TestBrTypeController()
        {
            var loggerFactory = LoggerFactory.Create(builder => { builder.AddConsole(); });
            var logger = loggerFactory.CreateLogger<BrTypeController>();
            var mockBrTypeService = new Mock<IBrTypeService>();
            mockBrTypeService.Setup(svc => svc.GetBrType().Result).Returns(new List<BrTypeViewModel>
                {
                    new BrTypeViewModel { Id = 1, ValueId = "Type 1", IsActive = false },
                    new BrTypeViewModel { Id = 2, ValueId = "Type 2", IsActive = true },
                    new BrTypeViewModel { Id = 3, ValueId = "Type 3", IsActive = false },
                });
            _controller = new BrTypeController(logger, mockBrTypeService.Object);
        }

        [Fact]
        public async Task Get_OnReturnsData()
        {
            // Act
            var result = await _controller.GetAll();

            // Assert
            Assert.IsType<ActionResult<List<BrTypeViewModel>?>?>(result);
        }

        [Fact]
        public async Task GetBrType_OnReturnsData()
        {
            // Act
            var result = await _controller.GetBrType(100);

            // Assert
            Assert.IsType<ActionResult<BrTypeViewModel?>?>(result);
        }

        [Fact]
        public async Task Create_OnReturnsData()
        {
            // Act
            var result = await _controller.CreateBrType(new BrTypeViewModel { Id = 4, ValueId = "Type 4", IsActive = false });

            // Assert
            Assert.IsType<ActionResult<BrTypeViewModel?>>(result);
        }

        [Fact]
        public async Task Update_OnReturnsData()
        {
            // Act
            var result = await _controller.UpdateBrType(new BrTypeViewModel { Id = 4, ValueId = "Type 4", IsActive = false });

            // Assert
            Assert.IsType<ActionResult<BrTypeViewModel?>>(result);
        }

        [Fact]
        public async Task Delete_OnReturnsData()
        {
            // Act
            var result = await _controller.DeleteBrType(4);

            // Assert
            Assert.IsType<ActionResult<List<BrTypeViewModel>>>(result);
        }
    }
}