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
    public class TestDepartmentController
    {
        private readonly DepartmentController _controller;

        public TestDepartmentController()
        {
            var loggerFactory = LoggerFactory.Create(builder => { builder.AddConsole(); });
            var logger = loggerFactory.CreateLogger<DepartmentController>();
            var mockDepartmentService = new Mock<IDepartmentService>();
                mockDepartmentService.Setup(svc => svc.GetDepartment().Result).Returns(new List<DepartmentViewModel>
                {
                    new DepartmentViewModel { Id = 1, ValueId = "Department 1", IsActive = false },
                    new DepartmentViewModel { Id = 2, ValueId = "Department 2", IsActive = true },
                    new DepartmentViewModel { Id = 3, ValueId = "Department 3", IsActive = false },
                });
            _controller = new DepartmentController(logger, mockDepartmentService.Object);
        }

        [Fact]
        public async Task Get_OnReturnsData()
        {
            // Act
            var result = await _controller.GetAll();

            // Assert
            Assert.IsType<ActionResult<List<DepartmentViewModel>?>?>(result);
        }

        [Fact]
        public async Task GetDepartment_OnReturnsData()
        {
            // Act
            var result = await _controller.GetDepartment(100);

            // Assert
            Assert.IsType<ActionResult<DepartmentViewModel?>?>(result);
        }

        [Fact]
        public async Task Create_OnReturnsData()
        {
            // Act
            var result = await _controller.CreateDepartment(new DepartmentViewModel { Id = 4, ValueId = "Department 4", IsActive = false });

            // Assert
            Assert.IsType<ActionResult<DepartmentViewModel?>>(result);
        }

        [Fact]
        public async Task Update_OnReturnsData()
        {
            // Act
            var result = await _controller.UpdateDepartment(new DepartmentViewModel { Id = 4, ValueId = "Department 4", IsActive = false });

            // Assert
            Assert.IsType<ActionResult<DepartmentViewModel?>>(result);
        }

        [Fact]
        public async Task Delete_OnReturnsData()
        {
            // Act
            var result = await _controller.DeleteDepartment(4);

            // Assert
            Assert.IsType<ActionResult<List<DepartmentViewModel>>>(result);
        }
    }
}