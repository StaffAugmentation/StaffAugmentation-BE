using Microsoft.AspNetCore.Mvc;
using Moq;
using Xunit;
using API.Controllers;
using Business.IServices;
using Core.ViewModel;
using Microsoft.Extensions.Logging;

namespace UnitTests.Controllers;

public class TestPTMOwnerController
{
    private readonly PTMOwnerController _controller;

    public TestPTMOwnerController()
    {
        var loggerFactory = LoggerFactory.Create(builder => { builder.AddConsole(); });
        var logger = loggerFactory.CreateLogger<PTMOwnerController>();
        var mockPTMOwnerService = new Mock<IPTMOwnerService>();
        mockPTMOwnerService.Setup(svc => svc.GetPTMOwner().Result).Returns(new List<PTMOwnerViewModel>
        {
                new PTMOwnerViewModel { Id = 1, ValueId = "PTMOwner 1",BA = "BA 1",BICSW ="BICSW 1",VatRate =10000, IsEveris = false, VatNumber ="VatNumber 1" },
                new PTMOwnerViewModel { Id = 2, ValueId = "PTMOwner 2",BA = "BA 2",BICSW ="BICSW 2",VatRate =20000, IsEveris = true, VatNumber ="VatNumber 2" },
                new PTMOwnerViewModel { Id = 3, ValueId = "PTMOwner 3",BA = "BA 3",BICSW ="BICSW 3",VatRate =30000, IsEveris = false, Approver = new ApproverViewModel{ Id = 1, FirstName= "test", LastName = "test" }, VatNumber ="VatNumber 3" },
            });
        _controller = new PTMOwnerController(logger, mockPTMOwnerService.Object);
    }

    [Fact]
    public async Task Get_OnReturnsData()
    {
        // Act
        var result = await _controller.GetAll();

        // Assert
        Assert.IsType<ActionResult<List<PTMOwnerViewModel>?>?>(result);
    }

    [Fact]
    public async Task GetPTMOwner_OnReturnsData()
    {
        // Act
        var result = await _controller.GetPTMOwner(100);

        // Assert
        Assert.IsType<ActionResult<PTMOwnerViewModel?>?>(result);
    }

    [Fact]
    public async Task Create_OnReturnsData()
    {
        // Act
        var result = await _controller.CreatePTMOwner(new PTMOwnerViewModel { Id = 4, ValueId = "PTMOwner 4", BA = "BA 4", BICSW = "BICSW 4", VatRate = 40000, IsEveris = true, VatNumber = "VatNumber 4" });

        // Assert
        Assert.IsType<ActionResult<PTMOwnerViewModel?>>(result);
    }

    [Fact]
    public async Task Update_OnReturnsData()
    {
        // Act
        var result = await _controller.UpdatePTMOwner(new PTMOwnerViewModel { Id = 4, ValueId = "PTMOwner 4", BA = "BA 4", BICSW = "BICSW 4", VatRate = 40000, IsEveris = true, VatNumber = "VatNumber 4" });

        // Assert
        Assert.IsType<ActionResult<PTMOwnerViewModel?>>(result);
    }

    [Fact]
    public async Task Delete_OnReturnsData()
    {
        // Act
        var result = await _controller.DeletePTMOwner(4);

        // Assert
        Assert.IsType<ActionResult<List<PTMOwnerViewModel>>>(result);
    }
}