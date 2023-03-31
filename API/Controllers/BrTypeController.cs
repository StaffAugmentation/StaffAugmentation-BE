using Microsoft.AspNetCore.Mvc;
using Business.IServices;
using Core.ViewModel;

namespace API.Controllers;

[Route("api/[controller]")]
[ApiController]
public sealed class BrTypeController : ControllerBase
{
    private readonly ILogger<BrTypeController> _logger;
    private readonly IBrTypeService _service;
    public BrTypeController(ILogger<BrTypeController> logger, IBrTypeService service)
    {
        _logger = logger;
        _service = service;
    }

    [HttpGet]
    public async Task<ActionResult<List<BrTypeViewModel>?>> GetAll()
    {
        try
        {
            _logger.LogInformation("GetBrTypes");
            return Ok(await _service.GetBrType());
        }
        catch (Exception ex)
        {
            _logger.LogError(ex.StackTrace);
            return BadRequest(ex.Message);
        }
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<BrTypeViewModel?>> GetBrType(int id)
    {
        try
        {
            _logger.LogInformation("GetBrTypes");
            return Ok(await _service.GetBrType(id));
        }
        catch (Exception ex)
        {
            _logger.LogError(ex.StackTrace);
            return BadRequest(ex.Message);
        }
    }

    [HttpPost]
    public async Task<ActionResult<BrTypeViewModel?>> CreateBrType(BrTypeViewModel brType)
    {
        try
        {
            _logger.LogInformation("Add BrType");
            return Accepted(await _service.CreateBrType(brType));
        }
        catch (Exception ex)
        {
            _logger.LogError(ex.StackTrace);
            return BadRequest(ex.Message);
        }
    }

    [HttpPut]
    public async Task<ActionResult<BrTypeViewModel?>> UpdateBrType(BrTypeViewModel brType)
    {
        try
        {
            _logger.LogInformation("Update BrType");
            return Accepted(await _service.UpdateBrType(brType));
        }
        catch (Exception ex)
        {
            _logger.LogError(ex.StackTrace);
            return BadRequest(ex.Message);
        }

    }

    [HttpDelete("{id}")]
    public async Task<ActionResult<List<BrTypeViewModel>?>> DeleteBrType(int id)
    {
        try
        {
            _logger.LogInformation("Delete BrType");
            return Accepted(await _service.DeleteBrType(id));
        }
        catch (Exception ex)
        {
            _logger.LogError(ex.StackTrace);
            return BadRequest(ex.Message);
        }
    }
}

