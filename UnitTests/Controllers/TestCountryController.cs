using Microsoft.AspNetCore.Mvc;
using Moq;
using Xunit;
using API.Controllers;
using Business.IServices;
using Core.ViewModel;
using Microsoft.Extensions.Logging;

namespace UnitTests.Controllers;

public class TestCountryController
{
    private readonly CountryController _controller;

    public TestCountryController()
    {
        var loggerFactory = LoggerFactory.Create(builder => { builder.AddConsole(); });
        var logger = loggerFactory.CreateLogger<CountryController>();
        var mockCountryService = new Mock<ICountryService>();
        mockCountryService.Setup(svc => svc.GetCountry().Result).Returns(new List<CountryViewModel>
            {
                new CountryViewModel { Id = "Id 1", CountryName = "Country 1"},
                new CountryViewModel { Id = "Id 2", CountryName = "Country 2"},
                new CountryViewModel { Id = "Id 3", CountryName = "Country 3"}
            });
        _controller = new CountryController(logger, mockCountryService.Object);
    }

    [Fact]
    public async Task Get_OnReturnsData()
    {
        // Act
        var result = await _controller.GetAll();

        // Assert
        Assert.IsType<ActionResult<List<CountryViewModel>?>?>(result);
    }

    [Fact]
    public async Task GetCountry_OnReturnsData()
    {
        // Act
        var result = await _controller.GetCountry("Id 100");

        // Assert
        Assert.IsType<ActionResult<CountryViewModel?>?>(result);
    }

    [Fact]
    public async Task Create_OnReturnsData()
    {
        // Act
        var result = await _controller.CreateCountry(new CountryViewModel { Id = "Id 4", CountryName = "Country 4" });

        // Assert
        Assert.IsType<ActionResult<CountryViewModel?>>(result);
    }

    [Fact]
    public async Task Update_OnReturnsData()
    {
        // Act
        var result = await _controller.UpdateCountry(new CountryViewModel { Id = "Id 4", CountryName = "Country id updated 4" });

        // Assert
        Assert.IsType<ActionResult<CountryViewModel?>>(result);
    }

    [Fact]
    public async Task Delete_OnReturnsData()
    {
        // Act
        var result = await _controller.DeleteCountry("Id 4");

        // Assert
        Assert.IsType<ActionResult<List<CountryViewModel>>>(result);
    }
}