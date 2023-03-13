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
    public class TestApproverController
    {
        private readonly ApproverController _controller;

        public TestApproverController()
        {
            var loggerFactory = LoggerFactory.Create(builder => { builder.AddConsole(); });
            var logger = loggerFactory.CreateLogger<ApproverController>();
            var mockApproverService = new Mock<IApproverService>();
                mockApproverService.Setup(svc => svc.GetApprover().Result).Returns(new List<ApproverViewModel>
                {
                    new ApproverViewModel { Id = 1, AppFirstName = "First name 1", AppLastName = "Last name 1" },
                    new ApproverViewModel { Id = 2, AppFirstName = "First name 2", AppLastName = "Last name 2" },
                    new ApproverViewModel { Id = 3, AppFirstName = "First name 3", AppLastName = "Last name 3" }
                });
            _controller = new ApproverController(logger, mockApproverService.Object);
        }

        [Fact]
        public async Task Get_OnReturnsData()
        {
            // Act
            var result = await _controller.GetAll();

            // Assert
            Assert.IsType<ActionResult<List<ApproverViewModel>?>?>(result);
        }

        [Fact]
        public async Task GetApprover_OnReturnsData()
        {
            // Act
            var result = await _controller.GetApprover(100);

            // Assert
            Assert.IsType<ActionResult<ApproverViewModel?>?>(result);
        }

        [Fact]
        public async Task Create_OnReturnsData()
        {
            // Act
            var result = await _controller.CreateApprover(new ApproverViewModel { Id = 4, AppFirstName = "First name 4", AppLastName = "Last name 4" });

            // Assert
            Assert.IsType<ActionResult<ApproverViewModel?>>(result);
        }

        [Fact]
        public async Task Update_OnReturnsData()
        {
            // Act
            var result = await _controller.UpdateApprover(new ApproverViewModel { Id = 4, AppFirstName = "First name updated 4" });

            // Assert
            Assert.IsType<ActionResult<ApproverViewModel?>>(result);
        }

        [Fact]
        public async Task Delete_OnReturnsData()
        {
            // Act
            var result = await _controller.DeleteApprover(4);

            // Assert
            Assert.IsType<ActionResult<List<ApproverViewModel>>>(result);
        }
    }
}