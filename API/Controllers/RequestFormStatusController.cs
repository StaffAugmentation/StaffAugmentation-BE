using Microsoft.AspNetCore.Mvc;
using Business.IServices;
using Core.ViewModel;

namespace API.Controllers;

[Route("api/[controller]")]
[ApiController]
public sealed class RequestFormStatusController : ControllerBase
{
    private readonly ILogger<RequestFormStatusController> _logger;
    private readonly IRequestFormStatusService _service;
    public RequestFormStatusController(ILogger<RequestFormStatusController> logger, IRequestFormStatusService service)
    {
        _logger = logger;
        _service = service;
    }

    [HttpGet]
    public async Task<ActionResult<List<RequestFormStatusViewModel>?>> GetAll()
    {
        try
        {
            _logger.LogInformation("GetRequestFormStatus");
            return Ok(await _service.GetRequestFormStatus());
        }
        catch (Exception ex)
        {
            _logger.LogError(ex.StackTrace);
            return BadRequest(ex.Message);
        }
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<RequestFormStatusViewModel?>> GetRequestFormStatus(string id)
    {
        try
        {
            _logger.LogInformation("GetRequestFormStatus");
            return Ok(await _service.GetRequestFormStatus(id));
        }
        catch (Exception ex)
        {
            _logger.LogError(ex.StackTrace);
            return BadRequest(ex.Message);
        }
    }

    [HttpPost]
    public async Task<ActionResult<RequestFormStatusViewModel?>> CreateRequestFormStatus(RequestFormStatusViewModel RequestFormStatus)
    {
        try
        {
            _logger.LogInformation("Add RequestFormStatus");
            return Accepted(await _service.CreateRequestFormStatus(RequestFormStatus));
        }
        catch (Exception ex)
        {
            _logger.LogError(ex.StackTrace);
            return BadRequest(ex.Message);
        }
    }

    [HttpPut]
    public async Task<ActionResult<RequestFormStatusViewModel?>> UpdateRequestFormStatus(RequestFormStatusViewModel RequestFormStatus)
    {
        try
        {
            _logger.LogInformation("Update RequestFormStatus");
            return Accepted(await _service.UpdateRequestFormStatus(RequestFormStatus));
        }
        catch (Exception ex)
        {
            _logger.LogError(ex.StackTrace);
            return BadRequest(ex.Message);
        }

    }

    [HttpDelete("{id}")]
    public async Task<ActionResult<List<RequestFormStatusViewModel>?>> DeleteRequestFormStatus(string id)
    {
        try
        {
            _logger.LogInformation("Delete RequestFormStatus");
            return Accepted(await _service.DeleteRequestFormStatus(id));
        }
        catch (Exception ex)
        {
            _logger.LogError(ex.StackTrace);
            return BadRequest(ex.Message);
        }

    }
}

