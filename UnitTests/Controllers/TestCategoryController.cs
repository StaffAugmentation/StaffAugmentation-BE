using Microsoft.AspNetCore.Mvc;
using Moq;
using Xunit;
using API.Controllers;
using Business.IServices;
using Core.ViewModel;
using Microsoft.Extensions.Logging;

namespace UnitTests.Controllers;

public class TestCategoryController
{
    private readonly CategoryController _controller;

    public TestCategoryController()
    {
        var loggerFactory = LoggerFactory.Create(builder => { builder.AddConsole(); });
        var logger = loggerFactory.CreateLogger<CategoryController>();
        var mockCategoryService = new Mock<ICategoryService>();
        mockCategoryService.Setup(svc => svc.GetCategory().Result).Returns(new List<CategoryViewModel>
            {
                new CategoryViewModel { Id = 1, ValueId = "Category 1", IsActive = true },
                new CategoryViewModel { Id = 2, ValueId = "Category 2", IsActive = true },
                new CategoryViewModel { Id = 3, ValueId = "Category 3", IsActive = false }
            });
        _controller = new CategoryController(logger, mockCategoryService.Object);
    }

    [Fact]
    public async Task Get_OnReturnsData()
    {
        // Act
        var result = await _controller.GetAll();

        // Assert
        Assert.IsType<ActionResult<List<CategoryViewModel>?>?>(result);
    }

    [Fact]
    public async Task GetCategory_OnReturnsData()
    {
        // Act
        var result = await _controller.GetCategory(100);

        // Assert
        Assert.IsType<ActionResult<CategoryViewModel?>?>(result);
    }

    [Fact]
    public async Task Create_OnReturnsData()
    {
        // Act
        var result = await _controller.CreateCategory(new CategoryViewModel { Id = 4, ValueId = "Category 4", IsActive = false });

        // Assert
        Assert.IsType<ActionResult<CategoryViewModel?>>(result);
    }

    [Fact]
    public async Task Update_OnReturnsData()
    {
        // Act
        var result = await _controller.UpdateCategory(new CategoryViewModel { Id = 4, ValueId = "Value id updated 4" });

        // Assert
        Assert.IsType<ActionResult<CategoryViewModel?>>(result);
    }

    [Fact]
    public async Task Delete_OnReturnsData()
    {
        // Act
        var result = await _controller.DeleteCategory(4);

        // Assert
        Assert.IsType<ActionResult<List<CategoryViewModel>>>(result);
    }
}