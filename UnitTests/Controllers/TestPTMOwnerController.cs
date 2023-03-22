using Microsoft.AspNetCore.Mvc;
using Moq;
using Xunit;
using API.Controllers;
using Business.IServices;
using Core.ViewModel;
using Microsoft.Extensions.Logging;
using Core.Model;

namespace UnitTests.Controllers
{
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
                    new PTMOwnerViewModel { Id = 1, ValueId = "PTMOwner 1",PTMOwnerBA = "PTMOwnerBA 1",PTMOwnerBICSW ="PTMOwnerBICSW 1",PTMOwnerVatRate =10000, IsEveris = false, IdApprover=1, PTMOwnerVatNumber ="PTMOwnerVatNumber 1" },
                    new PTMOwnerViewModel { Id = 2, ValueId = "PTMOwner 2",PTMOwnerBA = "PTMOwnerBA 2",PTMOwnerBICSW ="PTMOwnerBICSW 2",PTMOwnerVatRate =20000, IsEveris = true, IdApprover=2, PTMOwnerVatNumber ="PTMOwnerVatNumber 2" },
                    new PTMOwnerViewModel { Id = 3, ValueId = "PTMOwner 3",PTMOwnerBA = "PTMOwnerBA 3",PTMOwnerBICSW ="PTMOwnerBICSW 3",PTMOwnerVatRate =30000, IsEveris = false, IdApprover=3, PTMOwnerVatNumber ="PTMOwnerVatNumber 3" },
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
            var result = await _controller.CreatePTMOwner(new PTMOwnerViewModel { Id = 4, ValueId = "PTMOwner 4", PTMOwnerBA = "PTMOwnerBA 4", PTMOwnerBICSW = "PTMOwnerBICSW 4", PTMOwnerVatRate = 40000, IsEveris = true, IdApprover = 4, PTMOwnerVatNumber = "PTMOwnerVatNumber 4" });

            // Assert
            Assert.IsType<ActionResult<PTMOwnerViewModel?>>(result);
        }

        [Fact]
        public async Task Update_OnReturnsData()
        {
            // Act
            var result = await _controller.UpdatePTMOwner(new PTMOwnerViewModel { Id = 4, ValueId = "PTMOwner 4", PTMOwnerBA = "PTMOwnerBA 4", PTMOwnerBICSW = "PTMOwnerBICSW 4", PTMOwnerVatRate = 40000, IsEveris = true, IdApprover = 4, PTMOwnerVatNumber = "PTMOwnerVatNumber 4" });

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
}