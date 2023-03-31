using Microsoft.AspNetCore.Mvc;
using Business.IServices;
using Core.ViewModel;

namespace API.Controllers;

[Route("api/[controller]")]
[ApiController]
public sealed class SubContractorController : ControllerBase
{
    private readonly ILogger<SubContractorController> _logger;
    private readonly ISubContractorService _service;
    public SubContractorController(ILogger<SubContractorController> logger, ISubContractorService service)
    {
        _logger = logger;
        _service = service;
    }

    [HttpGet]
    public async Task<ActionResult<List<SubContractorViewModel>?>> GetAll()
    {
        try
        {
            _logger.LogInformation("GetSubContractor");
            return Ok(await _service.GetSubContractor());
        }
        catch (Exception ex)
        {
            _logger.LogError(ex.StackTrace);
            return BadRequest(ex.Message);
        }
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<SubContractorViewModel?>> GetSubContractor(int id)
    {
        try
        {
            _logger.LogInformation("GetSubContractor");
            return Ok(await _service.GetSubContractor(id));
        }
        catch (Exception ex)
        {
            _logger.LogError(ex.StackTrace);
            return BadRequest(ex.Message);
        }
    }

    [HttpPost]
    public async Task<ActionResult<SubContractorViewModel?>> CreateSubContractor(SubContractorViewModel subContractor)
    {
        try
        {
            _logger.LogInformation("Add SubContractor");
            return Accepted(await _service.CreateSubContractor(subContractor));
        }
        catch (Exception ex)
        {
            _logger.LogError(ex.StackTrace);
            return BadRequest(ex.Message);
        }
    }

    [HttpPut]
    public async Task<ActionResult<SubContractorViewModel?>> UpdateSubContractor(SubContractorViewModel subContractor)
    {
        try
        {
            _logger.LogInformation("Update SubContractor");
            return Accepted(await _service.UpdateSubContractor(subContractor));
        }
        catch (Exception ex)
        {
            _logger.LogError(ex.StackTrace);
            return BadRequest(ex.Message);
        }

    }

    [HttpDelete("{id}")]
    public async Task<ActionResult<List<SubContractorViewModel>?>> DeleteSubContractor(int id)
    {
        try
        {
            _logger.LogInformation("Delete SubContractor");
            return Accepted(await _service.DeleteSubContractor(id));
        }
        catch (Exception ex)
        {
            _logger.LogError(ex.StackTrace);
            return BadRequest(ex.Message);
        }
    }
}

