using Microsoft.AspNetCore.Mvc;
using Moq;
using Xunit;
using API.Controllers;
using Business.IServices;
using Core.ViewModel;
using Microsoft.Extensions.Logging;

namespace UnitTests.Controllers
{
    public class TestSubContractorController
    {
        private readonly SubContractorController _controller;

        public TestSubContractorController()
        {
            var loggerFactory = LoggerFactory.Create(builder => { builder.AddConsole(); });
            var logger = loggerFactory.CreateLogger<SubContractorController>();
            var mockSubContractorService = new Mock<ISubContractorService>();
            mockSubContractorService.Setup(svc => svc.GetSubContractor().Result).Returns(new List<SubContractorViewModel>
                {
                    new SubContractorViewModel { Id = 1, ValueId = "SubContractor 1", IsOfficial = false },
                    new SubContractorViewModel { Id = 2, ValueId = "SubContractor 2", IsOfficial = true },
                    new SubContractorViewModel { Id = 3, ValueId = "SubContractor 3", IsOfficial = false }
                });
            _controller = new SubContractorController(logger, mockSubContractorService.Object);
        }

        [Fact]
        public async Task Get_OnReturnsData()
        {
            // Act
            var result = await _controller.GetAll();

            // Assert
            Assert.IsType<ActionResult<List<SubContractorViewModel>?>?>(result);
        }

        [Fact]
        public async Task GetSubContractor_OnReturnsData()
        {
            // Act
            var result = await _controller.GetSubContractor(100);

            // Assert
            Assert.IsType<ActionResult<SubContractorViewModel?>?>(result);
        }

        [Fact]
        public async Task Create_OnReturnsData()
        {
            // Act
            var result = await _controller.CreateSubContractor(new SubContractorViewModel { Id = 4, ValueId = "SubContractor 4" });

            // Assert
            Assert.IsType<ActionResult<SubContractorViewModel?>>(result);
        }

        [Fact]
        public async Task Update_OnReturnsData()
        {
            // Act
            var result = await _controller.UpdateSubContractor(new SubContractorViewModel { Id = 4, ValueId = "SubContractor updated 4" });

            // Assert
            Assert.IsType<ActionResult<SubContractorViewModel?>>(result);
        }

        [Fact]
        public async Task Delete_OnReturnsData()
        {
            // Act
            var result = await _controller.DeleteSubContractor(4);

            // Assert
            Assert.IsType<ActionResult<List<SubContractorViewModel>>>(result);
        }
    }
}