using Microsoft.AspNetCore.Mvc;
using Business.IServices;
using Core.ViewModel;

namespace API.Controllers;

[Route("api/[controller]")]
[ApiController]
public sealed class TypeOfCostController : ControllerBase
{
    private readonly ILogger<TypeOfCostController> _logger;
    private readonly ITypeOfCostService _service;
    public TypeOfCostController(ILogger<TypeOfCostController> logger, ITypeOfCostService service)
    {
        _logger = logger;
        _service = service;
    }

    [HttpGet]
    public async Task<ActionResult<List<TypeOfCostViewModel>?>> GetAll()
    {
        try
        {
            _logger.LogInformation("GetTypeOfCost");
            return Ok(await _service.GetTypeOfCost());
        }
        catch (Exception ex)
        {
            _logger.LogError(ex.StackTrace);
            return BadRequest(ex.Message);
        }
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<TypeOfCostViewModel?>> GetTypeOfCost(string id)
    {
        try
        {
            _logger.LogInformation("GetTypeOfCost");
            return Ok(await _service.GetTypeOfCost(id));
        }
        catch (Exception ex)
        {
            _logger.LogError(ex.StackTrace);
            return BadRequest(ex.Message);
        }
    }

    [HttpPost]
    public async Task<ActionResult<TypeOfCostViewModel?>> CreateTypeOfCost(TypeOfCostViewModel typeOfCost)
    {
        try
        {
            _logger.LogInformation("Add TypeOfCost");
            return Accepted(await _service.CreateTypeOfCost(typeOfCost));
        }
        catch (Exception ex)
        {
            _logger.LogError(ex.StackTrace);
            return BadRequest(ex.Message);
        }
    }

    [HttpPut]
    public async Task<ActionResult<TypeOfCostViewModel?>> UpdateTypeOfCost(TypeOfCostViewModel typeOfCost)
    {
        try
        {
            _logger.LogInformation("Update TypeOfCost");
            return Accepted(await _service.UpdateTypeOfCost(typeOfCost));
        }
        catch (Exception ex)
        {
            _logger.LogError(ex.StackTrace);
            return BadRequest(ex.Message);
        }

    }

    [HttpDelete("{id}")]
    public async Task<ActionResult<List<TypeOfCostViewModel>?>> DeleteTypeOfCost(string id)
    {
        try
        {
            _logger.LogInformation("Delete TypeOfCost");
            return Accepted(await _service.DeleteTypeOfCost(id));
        }
        catch (Exception ex)
        {
            _logger.LogError(ex.StackTrace);
            return BadRequest(ex.Message);
        }
    }
}

