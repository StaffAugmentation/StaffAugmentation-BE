using Microsoft.AspNetCore.Mvc;
using Moq;
using Xunit;
using API.Controllers;
using Business.IServices;
using Core.ViewModel;
using Microsoft.Extensions.Logging;

namespace UnitTests.Controllers;

public class TestTypeController
{
    private readonly TypeController _controller;

    public TestTypeController()
    {
        var loggerFactory = LoggerFactory.Create(builder => { builder.AddConsole(); });
        var logger = loggerFactory.CreateLogger<TypeController>();
        var mockTypeService = new Mock<ITypeService>();
        mockTypeService.Setup(svc => svc.GetType().Result).Returns(new List<TypeViewModel>
            {
                new TypeViewModel { Id = 1, ValueId = "Type 1", IsActive = false },
                new TypeViewModel { Id = 2, ValueId = "Type 2", IsActive = true },
                new TypeViewModel { Id = 3, ValueId = "Type 3", IsActive = false },
            });
        _controller = new TypeController(logger, mockTypeService.Object);
    }

    [Fact]
    public async Task Get_OnReturnsData()
    {
        // Act
        var result = await _controller.GetAll();

        // Assert
        Assert.IsType<ActionResult<List<TypeViewModel>?>?>(result);
    }

    [Fact]
    public async Task GetType_OnReturnsData()
    {
        // Act
        var result = await _controller.GetType(100);

        // Assert
        Assert.IsType<ActionResult<TypeViewModel?>?>(result);
    }

    [Fact]
    public async Task Create_OnReturnsData()
    {
        // Act
        var result = await _controller.CreateType(new TypeViewModel { Id = 4, ValueId = "Type 4", IsActive = false });

        // Assert
        Assert.IsType<ActionResult<TypeViewModel?>>(result);
    }

    [Fact]
    public async Task Update_OnReturnsData()
    {
        // Act
        var result = await _controller.UpdateType(new TypeViewModel { Id = 4, ValueId = "Type 4", IsActive = false });

        // Assert
        Assert.IsType<ActionResult<TypeViewModel?>>(result);
    }

    [Fact]
    public async Task Delete_OnReturnsData()
    {
        // Act
        var result = await _controller.DeleteType(4);

        // Assert
        Assert.IsType<ActionResult<List<TypeViewModel>>>(result);
    }
}