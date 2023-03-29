using Microsoft.AspNetCore.Mvc;
using Moq;
using Xunit;
using API.Controllers;
using Business.IServices;
using Core.ViewModel;
using Microsoft.Extensions.Logging;

namespace UnitTests.Controllers
{
    public class TestRecruitmentResponsibleController
    {
        private readonly RecruitmentResponsibleController _controller;

        public TestRecruitmentResponsibleController()
        {
            var loggerFactory = LoggerFactory.Create(builder => { builder.AddConsole(); });
            var logger = loggerFactory.CreateLogger<RecruitmentResponsibleController>();
            var mockRecruitmentResponsibleService = new Mock<IRecruitmentResponsibleService>();
            mockRecruitmentResponsibleService.Setup(svc => svc.GetRecruitmentResponsible().Result).Returns(new List<RecruitmentResponsibleViewModel>
                {
                    new RecruitmentResponsibleViewModel { Id = 1, Name = "Responsible Name 1", Email = "Responsible Email 1" },
                    new RecruitmentResponsibleViewModel { Id = 2, Name = "Responsible Name 2", Email = "Responsible Email 2" },
                    new RecruitmentResponsibleViewModel { Id = 3, Name = "Responsible Name 3", Email = "Responsible Email 3" }
                });
            _controller = new RecruitmentResponsibleController(logger, mockRecruitmentResponsibleService.Object);
        }

        [Fact]
        public async Task Get_OnReturnsData()
        {
            // Act
            var result = await _controller.GetAll();

            // Assert
            Assert.IsType<ActionResult<List<RecruitmentResponsibleViewModel>?>?>(result);
        }

        [Fact]
        public async Task GetRecruitmentResponsible_OnReturnsData()
        {
            // Act
            var result = await _controller.GetRecruitmentResponsible(100);

            // Assert
            Assert.IsType<ActionResult<RecruitmentResponsibleViewModel?>?>(result);
        }

        [Fact]
        public async Task Create_OnReturnsData()
        {
            // Act
            var result = await _controller.CreateRecruitmentResponsible(new RecruitmentResponsibleViewModel { Id = 4, Name = "Responsible Name 4", Email = "Responsible Email 4" });

            // Assert
            Assert.IsType<ActionResult<RecruitmentResponsibleViewModel?>>(result);
        }

        [Fact]
        public async Task Update_OnReturnsData()
        {
            // Act
            var result = await _controller.UpdateRecruitmentResponsible(new RecruitmentResponsibleViewModel { Id = 4, Name = "Responsible Name updated 4" });

            // Assert
            Assert.IsType<ActionResult<RecruitmentResponsibleViewModel?>>(result);
        }

        [Fact]
        public async Task Delete_OnReturnsData()
        {
            // Act
            var result = await _controller.DeleteRecruitmentResponsible(4);

            // Assert
            Assert.IsType<ActionResult<List<RecruitmentResponsibleViewModel>>>(result);
        }
    }
}