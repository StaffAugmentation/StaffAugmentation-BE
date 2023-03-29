using Microsoft.AspNetCore.Mvc;
using Moq;
using Xunit;
using API.Controllers;
using Business.IServices;
using Core.ViewModel;
using Microsoft.Extensions.Logging;

namespace UnitTests.Controllers
{
    public class TestPaymentTermController
    {
        private readonly PaymentTermController _controller;

        public TestPaymentTermController()
        {
            var loggerFactory = LoggerFactory.Create(builder => { builder.AddConsole(); });
            var logger = loggerFactory.CreateLogger<PaymentTermController>();
            var mockPaymentTermService = new Mock<IPaymentTermService>();
            mockPaymentTermService.Setup(svc => svc.GetPaymentTerm().Result).Returns(new List<PaymentTermViewModel>
                {
                    new PaymentTermViewModel { Id = "Id 1", Value = "PaymentTerm 1"},
                    new PaymentTermViewModel { Id = "Id 2", Value = "PaymentTerm 2"},
                    new PaymentTermViewModel { Id = "Id 3", Value = "PaymentTerm 3"}
                });
            _controller = new PaymentTermController(logger, mockPaymentTermService.Object);
        }

        [Fact]
        public async Task Get_OnReturnsData()
        {
            // Act
            var result = await _controller.GetAll();

            // Assert
            Assert.IsType<ActionResult<List<PaymentTermViewModel>?>?>(result);
        }

        [Fact]
        public async Task GetPaymentTerm_OnReturnsData()
        {
            // Act
            var result = await _controller.GetPaymentTerm("Id 100");

            // Assert
            Assert.IsType<ActionResult<PaymentTermViewModel?>?>(result);
        }

        [Fact]
        public async Task Create_OnReturnsData()
        {
            // Act
            var result = await _controller.CreatePaymentTerm(new PaymentTermViewModel { Id = "Id 4", Value = "PaymentTerm 4" });

            // Assert
            Assert.IsType<ActionResult<PaymentTermViewModel?>>(result);
        }

        [Fact]
        public async Task Update_OnReturnsData()
        {
            // Act
            var result = await _controller.UpdatePaymentTerm(new PaymentTermViewModel { Id = "Id 4", Value = "Value id updated 4" });

            // Assert
            Assert.IsType<ActionResult<PaymentTermViewModel?>>(result);
        }

        [Fact]
        public async Task Delete_OnReturnsData()
        {
            // Act
            var result = await _controller.DeletePaymentTerm("Id 4");

            // Assert
            Assert.IsType<ActionResult<List<PaymentTermViewModel>>>(result);
        }
    }
}