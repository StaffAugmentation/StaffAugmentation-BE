using Microsoft.AspNetCore.Mvc;
using Moq;
using Xunit;
using API.Controllers;
using Business.IServices;
using Core.ViewModel;
using Microsoft.Extensions.Logging;

namespace UnitTests.Controllers
{
    public class TestRecruitmentRespController
    {
        private readonly RecruitmentRespController _controller;

        public TestRecruitmentRespController()
        {
            var loggerFactory = LoggerFactory.Create(builder => { builder.AddConsole(); });
            var logger = loggerFactory.CreateLogger<RecruitmentRespController>();
            var mockRecruitmentRespService = new Mock<IRecruitmentRespService>();
            mockRecruitmentRespService.Setup(svc => svc.GetRecruitmentResp().Result).Returns(new List<RecruitmentRespViewModel>
                {
                    new RecruitmentRespViewModel { Id = 1, ResponsibleName = "Responsible Name 1", ResponsibleEmail = "Responsible Email 1" },
                    new RecruitmentRespViewModel { Id = 2, ResponsibleName = "Responsible Name 2", ResponsibleEmail = "Responsible Email 2" },
                    new RecruitmentRespViewModel { Id = 3, ResponsibleName = "Responsible Name 3", ResponsibleEmail = "Responsible Email 3" }
                });
            _controller = new RecruitmentRespController(logger, mockRecruitmentRespService.Object);
        }

        [Fact]
        public async Task Get_OnReturnsData()
        {
            // Act
            var result = await _controller.GetAll();

            // Assert
            Assert.IsType<ActionResult<List<RecruitmentRespViewModel>?>?>(result);
        }

        [Fact]
        public async Task GetRecruitmentResp_OnReturnsData()
        {
            // Act
            var result = await _controller.GetRecruitmentResp(100);

            // Assert
            Assert.IsType<ActionResult<RecruitmentRespViewModel?>?>(result);
        }

        [Fact]
        public async Task Create_OnReturnsData()
        {
            // Act
            var result = await _controller.CreateRecruitmentResp(new RecruitmentRespViewModel { Id = 4, ResponsibleName = "Responsible Name 4", ResponsibleEmail = "Responsible Email 4" });

            // Assert
            Assert.IsType<ActionResult<RecruitmentRespViewModel?>>(result);
        }

        [Fact]
        public async Task Update_OnReturnsData()
        {
            // Act
            var result = await _controller.UpdateRecruitmentResp(new RecruitmentRespViewModel { Id = 4, ResponsibleName = "Responsible Name updated 4" });

            // Assert
            Assert.IsType<ActionResult<RecruitmentRespViewModel?>>(result);
        }

        [Fact]
        public async Task Delete_OnReturnsData()
        {
            // Act
            var result = await _controller.DeleteRecruitmentResp(4);

            // Assert
            Assert.IsType<ActionResult<List<RecruitmentRespViewModel>>>(result);
        }
    }
}