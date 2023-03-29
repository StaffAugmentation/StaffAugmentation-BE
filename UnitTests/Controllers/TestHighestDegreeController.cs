using Microsoft.AspNetCore.Mvc;
using Moq;
using Xunit;
using API.Controllers;
using Business.IServices;
using Core.ViewModel;
using Microsoft.Extensions.Logging;

namespace UnitTests.Controllers
{
    public class TestHighestDegreeController
    {
        private readonly HighestDegreeController _controller;

        public TestHighestDegreeController()
        {
            var loggerFactory = LoggerFactory.Create(builder => { builder.AddConsole(); });
            var logger = loggerFactory.CreateLogger<HighestDegreeController>();
            var mockHighestDegreeService = new Mock<IHighestDegreeService>();
            mockHighestDegreeService.Setup(svc => svc.GetHighestDegree().Result).Returns(new List<HighestDegreeViewModel>
                {
                    new HighestDegreeViewModel { Id = 1, Value = "HighestDegree 1"},
                    new HighestDegreeViewModel { Id = 2, Value = "HighestDegree 2"},
                    new HighestDegreeViewModel { Id = 3, Value = "HighestDegree 3"},
                });
            _controller = new HighestDegreeController(logger, mockHighestDegreeService.Object);
        }

        [Fact]
        public async Task Get_OnReturnsData()
        {
            // Act
            var result = await _controller.GetAll();

            // Assert
            Assert.IsType<ActionResult<List<HighestDegreeViewModel>?>?>(result);
        }

        [Fact]
        public async Task GetHighestDegree_OnReturnsData()
        {
            // Act
            var result = await _controller.GetHighestDegree(100);

            // Assert
            Assert.IsType<ActionResult<HighestDegreeViewModel?>?>(result);
        }

        [Fact]
        public async Task Create_OnReturnsData()
        {
            // Act
            var result = await _controller.CreateHighestDegree(new HighestDegreeViewModel { Id = 4, Value = "HighestDegree 4"});

            // Assert
            Assert.IsType<ActionResult<HighestDegreeViewModel?>>(result);
        }

        [Fact]
        public async Task Update_OnReturnsData()
        {
            // Act
            var result = await _controller.UpdateHighestDegree(new HighestDegreeViewModel { Id = 4, Value = "HighestDegree 4",});

            // Assert
            Assert.IsType<ActionResult<HighestDegreeViewModel?>>(result);
        }

        [Fact]
        public async Task Delete_OnReturnsData()
        {
            // Act
            var result = await _controller.DeleteHighestDegree(4);

            // Assert
            Assert.IsType<ActionResult<List<HighestDegreeViewModel>>>(result);
        }
    }
}