using Microsoft.AspNetCore.Mvc;
using Moq;
using Xunit;
using API.Controllers;
using Business.IServices;
using Core.ViewModel;
using Microsoft.Extensions.Logging;

namespace TestProject.UnitTests.Systems.Controllers
{
    public class TestCompanyController
    {
        private readonly CompanyController _controller;

        public TestCompanyController()
        {
            var loggerFactory = LoggerFactory.Create(builder => { builder.AddConsole(); });
            var logger = loggerFactory.CreateLogger<CompanyController>();
            var mockCompanyService = new Mock<ICompanyService>();
            mockCompanyService.Setup(svc => svc.GetCompany().Result).Returns(new List<CompanyViewModel>
                {
                    new CompanyViewModel { IdCompany = 1, CompanyName = "Company 1", IsEveris = false },
                    new CompanyViewModel { IdCompany = 2, CompanyName = "Company 2", IsEveris = true },
                    new CompanyViewModel { IdCompany = 3, CompanyName = "Company 3", IsEveris = false }
                });
            _controller = new CompanyController(logger, mockCompanyService.Object);
        }

        [Fact]
        public async Task Get_OnReturnsData()
        {
            // Act
            var result = await _controller.GetAll();

            // Assert
            Assert.IsType<ActionResult<List<CompanyViewModel>?>?>(result);
        }

        [Fact]
        public async Task GetCompany_OnReturnsData()
        {
            // Act
            var result = await _controller.GetCompany(100);

            // Assert
            Assert.IsType<ActionResult<CompanyViewModel?>?>(result);
        }

        [Fact]
        public async Task Create_OnReturnsData()
        {
            // Act
            var result = await _controller.CreateCompany(new CompanyViewModel { IdCompany = 4, CompanyName = "Company 4" });

            // Assert
            Assert.IsType<ActionResult<CompanyViewModel?>>(result);
        }

        [Fact]
        public async Task Update_OnReturnsData()
        {
            // Act
            var result = await _controller.UpdateCompany(new CompanyViewModel { IdCompany = 4, CompanyName = "Company updated 4" });

            // Assert
            Assert.IsType<ActionResult<CompanyViewModel?>>(result);
        }

        [Fact]
        public async Task Delete_OnReturnsData()
        {
            // Act
            var result = await _controller.DeleteCompany(4);

            // Assert
            Assert.IsType<ActionResult<List<CompanyViewModel>>>(result);
        }
    }
}