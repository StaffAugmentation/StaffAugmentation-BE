using Microsoft.AspNetCore.Mvc;
using Moq;
using Xunit;
using API.Controllers;
using Business.IServices;
using Core.ViewModel;
using Microsoft.Extensions.Logging;

namespace UnitTests.Controllers;

public class TestApproverController
{
    private readonly ApproverController _controller;

    public TestApproverController()
    {
        var loggerFactory = LoggerFactory.Create(builder => { builder.AddConsole(); });
        var logger = loggerFactory.CreateLogger<ApproverController>();
        var mockApproverService = new Mock<IApproverService>();
        mockApproverService.Setup(svc => svc.GetApprover().Result).Returns(new List<ApproverViewModel>
            {
                new ApproverViewModel { Id = 1, FirstName = "First name 1", LastName = "Last name 1" },
                new ApproverViewModel { Id = 2, FirstName = "First name 2", LastName = "Last name 2" },
                new ApproverViewModel { Id = 3, FirstName = "First name 3", LastName = "Last name 3" }
            });
        _controller = new ApproverController(logger, mockApproverService.Object);
    }

    [Fact]
    public async Task Get_OnReturnsData()
    {
        // Act
        var result = await _controller.GetAll();

        // Assert
        Assert.IsType<ActionResult<List<ApproverViewModel>?>?>(result);

        //result.Should().BeOfType<ActionResult<List<ApproverViewModel>?>?>()
        //    .Which.Result.Should().Be((int)HttpStatusCode.OK);
    }

    [Fact]
    public async Task GetApprover_OnReturnsData()
    {
        // Act
        var result = await _controller.GetApprover(100);

        // Assert
        Assert.IsType<ActionResult<ApproverViewModel?>?>(result);
    }

    [Fact]
    public async Task Create_OnReturnsData()
    {
        // Act
        var result = await _controller.CreateApprover(new ApproverViewModel { Id = 4, FirstName = "First name 4", LastName = "Last name 4" });

        // Assert
        Assert.IsType<ActionResult<ApproverViewModel?>>(result);
    }

    [Fact]
    public async Task Update_OnReturnsData()
    {
        // Act
        var result = await _controller.UpdateApprover(new ApproverViewModel { Id = 4, FirstName = "First name updated 4" });

        // Assert
        Assert.IsType<ActionResult<ApproverViewModel?>>(result);
    }

    [Fact]
    public async Task Delete_OnReturnsData()
    {
        // Act
        var result = await _controller.DeleteApprover(4);

        // Assert
        Assert.IsType<ActionResult<List<ApproverViewModel>>>(result);
    }
}