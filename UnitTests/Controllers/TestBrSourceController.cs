using Microsoft.AspNetCore.Mvc;
using Moq;
using Xunit;
using API.Controllers;
using Business.IServices;
using Core.ViewModel;
using Microsoft.Extensions.Logging;

namespace UnitTests.Controllers;

public class TestBrSourceController
{
    private readonly BrSourceController _controller;

    public TestBrSourceController()
    {
        var loggerFactory = LoggerFactory.Create(builder => { builder.AddConsole(); });
        var logger = loggerFactory.CreateLogger<BrSourceController>();
        var mockBrSourceService = new Mock<IBrSourceService>();
        mockBrSourceService.Setup(svc => svc.GetBrSource().Result).Returns(new List<BrSourceViewModel>
            {
                new BrSourceViewModel { Id= "Source 1", Name = "Source 1" },
                new BrSourceViewModel { Id = "Source 2", Name = "Source 2" },
                new BrSourceViewModel { Id = "Source 3", Name = "Source 3" },
            });
        _controller = new BrSourceController(logger, mockBrSourceService.Object);
    }

    [Fact]
    public async Task Get_OnReturnsData()
    {
        // Act
        var result = await _controller.GetAll();

        // Assert
        Assert.IsType<ActionResult<List<BrSourceViewModel>?>?>(result);
    }

    [Fact]
    public async Task GetBrSource_OnReturnsData()
    {
        // Act
        var result = await _controller.GetBrSource("Source 1");

        // Assert
        Assert.IsType<ActionResult<BrSourceViewModel?>?>(result);
    }

    [Fact]
    public async Task Create_OnReturnsData()
    {
        // Act
        var result = await _controller.CreateBrSource(new BrSourceViewModel { Id = "Source 4", Name = "Source 4" });

        // Assert
        Assert.IsType<ActionResult<BrSourceViewModel?>>(result);
    }

    [Fact]
    public async Task Update_OnReturnsData()
    {
        // Act
        var result = await _controller.UpdateBrSource(new BrSourceViewModel { Id = "Source 4", Name = "Source 4" });

        // Assert
        Assert.IsType<ActionResult<BrSourceViewModel?>>(result);
    }

    [Fact]
    public async Task Delete_OnReturnsData()
    {
        // Act
        var result = await _controller.DeleteBrSource("Source 4");

        // Assert
        Assert.IsType<ActionResult<List<BrSourceViewModel>>>(result);
    }
}