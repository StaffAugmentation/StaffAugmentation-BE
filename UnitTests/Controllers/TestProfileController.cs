using Microsoft.AspNetCore.Mvc;
using Moq;
using Xunit;
using API.Controllers;
using Business.IServices;
using Core.ViewModel;
using Microsoft.Extensions.Logging;

namespace UnitTests.Controllers
{
    public class TestProfileController
    {
        private readonly ProfileController _controller;

        public TestProfileController()
        {
            var loggerFactory = LoggerFactory.Create(builder => { builder.AddConsole(); });
            var logger = loggerFactory.CreateLogger<ProfileController>();
            var mockProfileService = new Mock<IProfileService>();
            mockProfileService.Setup(svc => svc.GetProfile().Result).Returns(new List<ProfileViewModel>
                {
                    new ProfileViewModel { Id = 1, ValueId = "Profile 1", IsActive = true },
                    new ProfileViewModel { Id = 2, ValueId = "Profile 2", IsActive = true },
                    new ProfileViewModel { Id = 3, ValueId = "Profile 3", IsActive = false }
                });
            _controller = new ProfileController(logger, mockProfileService.Object);
        }

        [Fact]
        public async Task Get_OnReturnsData()
        {
            // Act
            var result = await _controller.GetAll();

            // Assert
            Assert.IsType<ActionResult<List<ProfileViewModel>?>?>(result);
        }

        [Fact]
        public async Task GetProfile_OnReturnsData()
        {
            // Act
            var result = await _controller.GetProfile(100);

            // Assert
            Assert.IsType<ActionResult<ProfileViewModel?>?>(result);
        }

        [Fact]
        public async Task Create_OnReturnsData()
        {
            // Act
            var result = await _controller.CreateProfile(new ProfileViewModel { Id = 4, ValueId = "Profile 4", IsActive = false });

            // Assert
            Assert.IsType<ActionResult<ProfileViewModel?>>(result);
        }

        [Fact]
        public async Task Update_OnReturnsData()
        {
            // Act
            var result = await _controller.UpdateProfile(new ProfileViewModel { Id = 4, ValueId = "Value id updated 4" });

            // Assert
            Assert.IsType<ActionResult<ProfileViewModel?>>(result);
        }

        [Fact]
        public async Task Delete_OnReturnsData()
        {
            // Act
            var result = await _controller.DeleteProfile(4);

            // Assert
            Assert.IsType<ActionResult<List<ProfileViewModel>>>(result);
        }
    }
}