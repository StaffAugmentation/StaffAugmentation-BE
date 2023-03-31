using Microsoft.AspNetCore.Mvc;
using Business.IServices;
using Core.ViewModel;

namespace API.Controllers;

[Route("api/[controller]")]
[ApiController]
public sealed class PaymentTermController : ControllerBase
{
    private readonly ILogger<PaymentTermController> _logger;
    private readonly IPaymentTermService _service;
    public PaymentTermController(ILogger<PaymentTermController> logger, IPaymentTermService service)
    {
        _logger = logger;
        _service = service;
    }

    [HttpGet]
    public async Task<ActionResult<List<PaymentTermViewModel>?>> GetAll()
    {
        try
        {
            _logger.LogInformation("GetPaymentTerm");
            return Ok(await _service.GetPaymentTerm());
        }
        catch (Exception ex)
        {
            _logger.LogError(ex.StackTrace);
            return BadRequest(ex.Message);
        }
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<PaymentTermViewModel?>> GetPaymentTerm(string id)
    {
        try
        {
            _logger.LogInformation("GetPaymentTerm");
            return Ok(await _service.GetPaymentTerm(id));
        }
        catch (Exception ex)
        {
            _logger.LogError(ex.StackTrace);
            return BadRequest(ex.Message);
        }
    }

    [HttpPost]
    public async Task<ActionResult<PaymentTermViewModel?>> CreatePaymentTerm(PaymentTermViewModel paymentTerm)
    {
        try
        {
            _logger.LogInformation("Add PaymentTerm");
            return Accepted(await _service.CreatePaymentTerm(paymentTerm));
        }
        catch (Exception ex)
        {
            _logger.LogError(ex.StackTrace);
            return BadRequest(ex.Message);
        }
    }

    [HttpPut]
    public async Task<ActionResult<PaymentTermViewModel?>> UpdatePaymentTerm(PaymentTermViewModel paymentTerm)
    {
        try
        {
            _logger.LogInformation("Update PaymentTerm");
            return Accepted(await _service.UpdatePaymentTerm(paymentTerm));
        }
        catch (Exception ex)
        {
            _logger.LogError(ex.StackTrace);
            return BadRequest(ex.Message);
        }

    }

    [HttpDelete("{id}")]
    public async Task<ActionResult<List<PaymentTermViewModel>?>> DeletePaymentTerm(string id)
    {
        try
        {
            _logger.LogInformation("Delete PaymentTerm");
            return Accepted(await _service.DeletePaymentTerm(id));
        }
        catch (Exception ex)
        {
            _logger.LogError(ex.StackTrace);
            return BadRequest(ex.Message);
        }
    }
}

