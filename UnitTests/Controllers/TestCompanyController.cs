using Microsoft.AspNetCore.Mvc;
using Moq;
using Xunit;
using API.Controllers;
using Business.IServices;
using Core.ViewModel;
using Microsoft.Extensions.Logging;

namespace UnitTests.Controllers;

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
                new CompanyViewModel { Id = 1, Name = "Company 1", IsEveris = false },
                new CompanyViewModel { Id = 2, Name = "Company 2", IsEveris = true },
                new CompanyViewModel { Id = 3, Name = "Company 3", IsEveris = false }
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
        var result = await _controller.CreateCompany(new CompanyViewModel { Id = 4, Name = "Company 4" });

        // Assert
        Assert.IsType<ActionResult<CompanyViewModel?>>(result);
    }

    [Fact]
    public async Task Update_OnReturnsData()
    {
        // Act
        var result = await _controller.UpdateCompany(new CompanyViewModel { Id = 4, Name = "Company updated 4" });

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