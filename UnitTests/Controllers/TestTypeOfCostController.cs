using Microsoft.AspNetCore.Mvc;
using Moq;
using Xunit;
using API.Controllers;
using Business.IServices;
using Core.ViewModel;
using Microsoft.Extensions.Logging;

namespace UnitTests.Controllers;

public class TestTypeOfCostController
{
    private readonly TypeOfCostController _controller;

    public TestTypeOfCostController()
    {
        var loggerFactory = LoggerFactory.Create(builder => { builder.AddConsole(); });
        var logger = loggerFactory.CreateLogger<TypeOfCostController>();
        var mockTypeOfCostService = new Mock<ITypeOfCostService>();
        mockTypeOfCostService.Setup(svc => svc.GetTypeOfCost().Result).Returns(new List<TypeOfCostViewModel>
            {
                new TypeOfCostViewModel { Id = "Id 1", Value = "TypeOfCost 1"},
                new TypeOfCostViewModel { Id = "Id 2", Value = "TypeOfCost 2"},
                new TypeOfCostViewModel { Id = "Id 3", Value = "TypeOfCost 3"}
            });
        _controller = new TypeOfCostController(logger, mockTypeOfCostService.Object);
    }

    [Fact]
    public async Task Get_OnReturnsData()
    {
        // Act
        var result = await _controller.GetAll();

        // Assert
        Assert.IsType<ActionResult<List<TypeOfCostViewModel>?>?>(result);
    }

    [Fact]
    public async Task GetTypeOfCost_OnReturnsData()
    {
        // Act
        var result = await _controller.GetTypeOfCost("Id 100");

        // Assert
        Assert.IsType<ActionResult<TypeOfCostViewModel?>?>(result);
    }

    [Fact]
    public async Task Create_OnReturnsData()
    {
        // Act
        var result = await _controller.CreateTypeOfCost(new TypeOfCostViewModel { Id = "Id 4", Value = "TypeOfCost 4" });

        // Assert
        Assert.IsType<ActionResult<TypeOfCostViewModel?>>(result);
    }

    [Fact]
    public async Task Update_OnReturnsData()
    {
        // Act
        var result = await _controller.UpdateTypeOfCost(new TypeOfCostViewModel { Id = "Id 4", Value = "Value id updated 4" });

        // Assert
        Assert.IsType<ActionResult<TypeOfCostViewModel?>>(result);
    }

    [Fact]
    public async Task Delete_OnReturnsData()
    {
        // Act
        var result = await _controller.DeleteTypeOfCost("Id 4");

        // Assert
        Assert.IsType<ActionResult<List<TypeOfCostViewModel>>>(result);
    }
}