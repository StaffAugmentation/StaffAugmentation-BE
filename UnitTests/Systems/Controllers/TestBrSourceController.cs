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
                    new BrSourceViewModel { IdSource= "Source 1", SourceName = "Source 1" },
                    new BrSourceViewModel { IdSource = "Source 2", SourceName = "Source 2" },
                    new BrSourceViewModel { IdSource = "Source 3", SourceName = "Source 3" },
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
            var result = await _controller.GetBrSource("Source 1");

            // Assert
            Assert.IsType<ActionResult<BrSourceViewModel?>?>(result);
        }

        [Fact]
        public async Task Create_OnReturnsData()
        {
            // Act
            var result = await _controller.CreateBrSource(new BrSourceViewModel { IdSource = "Source 4", SourceName = "Source 4" });

            // Assert
            Assert.IsType<ActionResult<BrSourceViewModel?>>(result);
        }

        [Fact]
        public async Task Update_OnReturnsData()
        {
            // Act
            var result = await _controller.UpdateBrSource(new BrSourceViewModel { IdSource = "Source 4", SourceName = "Source 4" });

            // Assert
            Assert.IsType<ActionResult<BrSourceViewModel?>>(result);
        }

        [Fact]
        public async Task Delete_OnReturnsData()
        {
            // Act
            var result = await _controller.DeleteBrSource("Source 4");

            // Assert
            Assert.IsType<ActionResult<List<BrSourceViewModel>>>(result);
        }
    }
}