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
    public class TestBrSourceController
    {
        private readonly BrSourceController _controller;

        public TestBrSourceController()
        {
            var loggerFactory = LoggerFactory.Create(builder => { builder.AddConsole(); });
            var logger = loggerFactory.CreateLogger<BrSourceController>();
            var mockBrSourceService = new Mock<IBrSourceService>();
            mockBrSourceService.Setup(svc => svc.GetBrSource().Result).Returns(new List<BrSourceViewModel>
                {
                    new BrSourceViewModel { IdSource= 1, SourceName = "string" },
                    new BrSourceViewModel { IdSource = 2, SourceName = "string" },
                    new BrSourceViewModel { IdSource = 3, SourceName = "string" },
                });
            _controller = new BrSourceController(logger, mockBrSourceService.Object);
        }

        [Fact]
        public async Task Get_OnReturnsData()
        {
            // Act
            var result = await _controller.GetAll();

            // Assert
            Assert.IsType<ActionResult<List<BrSourceViewModel>?>?>(result);
        }

        [Fact]
        public async Task GetBrSource_OnReturnsData()
        {
            // Act
            var result = await _controller.GetBrSource(100);

            // Assert
            Assert.IsType<ActionResult<BrSourceViewModel?>?>(result);
        }

        [Fact]
        public async Task Create_OnReturnsData()
        {
            // Act
            var result = await _controller.CreateBrSource(new BrSourceViewModel { IdSource = 4, SourceName = "string" });

            // Assert
            Assert.IsType<ActionResult<BrSourceViewModel?>>(result);
        }

        [Fact]
        public async Task Update_OnReturnsData()
        {
            // Act
            var result = await _controller.UpdateBrSource(new BrSourceViewModel { IdSource = 4  , SourceName = "string" });

            // Assert
            Assert.IsType<ActionResult<BrSourceViewModel?>>(result);
        }

        [Fact]
        public async Task Delete_OnReturnsData()
        {
            // Act
            var result = await _controller.DeleteBrSource(4);

            // Assert
            Assert.IsType<ActionResult<List<BrSourceViewModel>>>(result);
        }
    }
}