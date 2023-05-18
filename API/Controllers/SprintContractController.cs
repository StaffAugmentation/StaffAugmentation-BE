using Microsoft.AspNetCore.Mvc;
using Business.IServices;
using Core.ViewModel;

namespace API.Controllers;

[Route("api/[controller]")]
[ApiController]
public sealed class SprintContractController : ControllerBase
{
    private readonly ILogger<SprintContractController> _logger;
    private readonly ISprintContractService _service;
    public SprintContractController(ILogger<SprintContractController> logger, ISprintContractService service)
    {
        _logger = logger;
        _service = service;
    }
    
    [HttpGet]
    public async Task<ActionResult<IEnumerable<object?>>> GetAll(string state, AdvancedSearchViewModel search)
    {
        try
        {
            _logger.LogInformation("Get Business requests");
            return Ok(await _service.GetSprintContracts(3251, state, search));

        }
        catch (Exception ex)
        {
            _logger.LogError(ex.StackTrace);
            return BadRequest(ex.Message);
        }
    }

    [HttpGet("{Id}")]
    public async Task<ActionResult<SprintContractViewModel?>> getBusinessRequest(int Id)
    {
        try
        {
            _logger.LogInformation("Get Business request");
            return Ok(await _service.GetSprintContract(Id));
        }
        catch (Exception ex)
        {
            _logger.LogError(ex.StackTrace);
            return BadRequest(ex.Message);
        }
    }

    [HttpPost]
    public async Task<ActionResult<SprintContractViewModel?>> CreateBusinessRequest(SprintContractViewModel SC)
    {
        try
        {
            _logger.LogInformation("Add Business request");
            return Accepted(await _service.CreateSprintContract(SC));
        }
        catch (Exception ex)
        {
            _logger.LogError(ex.StackTrace);
            return BadRequest(ex.Message);
        }
    }

    [HttpPut]
    public async Task<ActionResult<SprintContractViewModel?>> UpdateBusinessRequest(SprintContractViewModel SC)
    {
        try
        {
            _logger.LogInformation("Update Business request");
            return Accepted(await _service.UpdateSprintContract(SC));
        }
        catch (Exception ex)
        {
            _logger.LogError(ex.StackTrace);
            return BadRequest(ex.Message);
        }
    }
    [HttpDelete("{Id}")]
    public async Task<ActionResult<SprintContractViewModel?>> DeleteBusinessRequest(int Id)
    {
        try
        {
            _logger.LogInformation("Delete Business request");
            return Accepted(await _service.DeleteSprintContract(Id));
        }
        catch (Exception ex)
        {
            _logger.LogError(ex.StackTrace);
            return BadRequest(ex.Message);
        }
    }
}