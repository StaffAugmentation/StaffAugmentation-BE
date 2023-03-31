using Microsoft.AspNetCore.Mvc;
using Moq;
using Xunit;
using API.Controllers;
using Business.IServices;
using Core.ViewModel;
using Microsoft.Extensions.Logging;
using System.Net;
using FluentAssertions;

namespace UnitTests.Controllers;

public class TestApproverController
{
    private readonly ApproverController _controller;
    private ApproverViewModel testApprover = new ApproverViewModel { Id = 4, FirstName = "First name 4", LastName = "Last name 4" };

    public TestApproverController()
    {
        var loggerFactory = LoggerFactory.Create(builder => { builder.AddConsole(); });
        var logger = loggerFactory.CreateLogger<ApproverController>();

        List<ApproverViewModel> approvers = new List<ApproverViewModel>
        {
            new ApproverViewModel { Id = 1, FirstName = "First name 1", LastName = "Last name 1" },
            new ApproverViewModel { Id = 2, FirstName = "First name 2", LastName = "Last name 2" },
            new ApproverViewModel { Id = 3, FirstName = "First name 3", LastName = "Last name 3" }
        };

        var mockApproverService = new Mock<IApproverService>();
        mockApproverService.Setup(svc => svc.GetApprover().Result).Returns(approvers);
        mockApproverService.Setup(svc => svc.GetApprover(1).Result).Returns(approvers.FirstOrDefault());
        mockApproverService.Setup(svc => svc.CreateApprover(testApprover).Result).Returns(approvers.FirstOrDefault());
        mockApproverService.Setup(svc => svc.UpdateApprover(testApprover).Result).Returns(approvers.FirstOrDefault());
        mockApproverService.Setup(svc => svc.DeleteApprover(1).Result).Returns(approvers);

        _controller = new ApproverController(logger, mockApproverService.Object);
    }

    [Fact]
    public async Task Get_OnReturnsData()
    {
        // Act
        var result = (await _controller.GetAll()).Result as OkObjectResult;

        // check data
        Assert.IsType<List<ApproverViewModel>?>(result?.Value);

        // check status
        result.StatusCode.Should().Be((int)HttpStatusCode.OK);
    }

    [Fact]
    public async Task GetApprover_OnReturnsData()
    {
        // Act
        var result = (await _controller.GetApprover(1)).Result as OkObjectResult;

        // check data
        Assert.IsType<ApproverViewModel?>(result?.Value);

        // check status
        result.StatusCode.Should().Be((int)HttpStatusCode.OK);
    }

    [Fact]
    public async Task Create_OnReturnsData()
    {
        // Act
        var result = (await _controller.CreateApprover(testApprover)).Result as ObjectResult;

        // check data
        Assert.IsType<ApproverViewModel?>(result?.Value);

        // check status
        result.StatusCode.Should().Be((int)HttpStatusCode.Accepted);
    }

    [Fact]
    public async Task Update_OnReturnsData()
    {
        // Act
        var result = (await _controller.UpdateApprover(testApprover)).Result as ObjectResult;

        // check data
        Assert.IsType<ApproverViewModel?>(result?.Value);

        // check status
        result.StatusCode.Should().Be((int)HttpStatusCode.Accepted);
    }

    [Fact]
    public async Task Delete_OnReturnsData()
    {
        // Act
        var result = (await _controller.DeleteApprover(1)).Result as ObjectResult;

        // check data
        Assert.IsType<List<ApproverViewModel>?>(result?.Value);

        // check status
        result.StatusCode.Should().Be((int)HttpStatusCode.Accepted);
    }
}