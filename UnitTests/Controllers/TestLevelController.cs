using Microsoft.AspNetCore.Mvc;
using Moq;
using Xunit;
using API.Controllers;
using Business.IServices;
using Core.ViewModel;
using Microsoft.Extensions.Logging;

namespace UnitTests.Controllers;

public class TestLevelController
{
    private readonly LevelController _controller;

    public TestLevelController()
    {
        var loggerFactory = LoggerFactory.Create(builder => { builder.AddConsole(); });
        var logger = loggerFactory.CreateLogger<LevelController>();
        var mockLevelService = new Mock<ILevelService>();
        mockLevelService.Setup(svc => svc.GetLevel().Result).Returns(new List<LevelViewModel>
            {
                new LevelViewModel { Id = 1, ValueId = "Level 1", IsActive = true },
                new LevelViewModel { Id = 2, ValueId = "Level 2", IsActive = true },
                new LevelViewModel { Id = 3, ValueId = "Level 3", IsActive = false }
            });
        _controller = new LevelController(logger, mockLevelService.Object);
    }

    [Fact]
    public async Task Get_OnReturnsData()
    {
        // Act
        var result = await _controller.GetAll();

        // Assert
        Assert.IsType<ActionResult<List<LevelViewModel>?>?>(result);
    }

    [Fact]
    public async Task GetLevel_OnReturnsData()
    {
        // Act
        var result = await _controller.GetLevel(100);

        // Assert
        Assert.IsType<ActionResult<LevelViewModel?>?>(result);
    }

    [Fact]
    public async Task Create_OnReturnsData()
    {
        // Act
        var result = await _controller.CreateLevel(new LevelViewModel { Id = 4, ValueId = "Level 4", IsActive = false });

        // Assert
        Assert.IsType<ActionResult<LevelViewModel?>>(result);
    }

    [Fact]
    public async Task Update_OnReturnsData()
    {
        // Act
        var result = await _controller.UpdateLevel(new LevelViewModel { Id = 4, ValueId = "Value id updated 4" });

        // Assert
        Assert.IsType<ActionResult<LevelViewModel?>>(result);
    }

    [Fact]
    public async Task Delete_OnReturnsData()
    {
        // Act
        var result = await _controller.DeleteLevel(4);

        // Assert
        Assert.IsType<ActionResult<List<LevelViewModel>>>(result);
    }
}