using Microsoft.AspNetCore.Mvc;
using Business.IServices;
using Core.ViewModel;

namespace API.Controllers;

[Route("api/[controller]")]
[ApiController]
public sealed class PTMOwnerController : ControllerBase
{
    private readonly ILogger<PTMOwnerController> _logger;
    private readonly IPTMOwnerService _service;
    public PTMOwnerController(ILogger<PTMOwnerController> logger, IPTMOwnerService service)
    {
        _logger = logger;
        _service = service;
    }

    [HttpGet]
    public async Task<ActionResult<List<PTMOwnerViewModel>?>> GetAll()
    {
        try
        {
            _logger.LogInformation("GetPTMOwner");
            return Ok(await _service.GetPTMOwner());
        }
        catch (Exception ex)
        {
            _logger.LogError(ex.StackTrace);
            return BadRequest(ex.Message);
        }
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<PTMOwnerViewModel?>> GetPTMOwner(int id)
    {
        try
        {
            _logger.LogInformation("GetPTMOwner");
            return Ok(await _service.GetPTMOwner(id));
        }
        catch (Exception ex)
        {
            _logger.LogError(ex.StackTrace);
            return BadRequest(ex.Message);
        }
    }

    [HttpPost]
    public async Task<ActionResult<PTMOwnerViewModel?>> CreatePTMOwner(PTMOwnerViewModel PTMOwner)
    {
        try
        {
            _logger.LogInformation("Add PTMOwner");
            return Accepted(await _service.CreatePTMOwner(PTMOwner));
        }
        catch (Exception ex)
        {
            _logger.LogError(ex.StackTrace);
            return BadRequest(ex.Message);
        }
    }

    [HttpPut]
    public async Task<ActionResult<PTMOwnerViewModel?>> UpdatePTMOwner(PTMOwnerViewModel PTMOwner)
    {
        try
        {
            _logger.LogInformation("Update PTMOwner");
            return Accepted(await _service.UpdatePTMOwner(PTMOwner));
        }
        catch (Exception ex)
        {
            _logger.LogError(ex.StackTrace);
            return BadRequest(ex.Message);
        }

    }

    [HttpDelete("{id}")]
    public async Task<ActionResult<List<PTMOwnerViewModel>?>> DeletePTMOwner(int id)
    {
        try
        {
            _logger.LogInformation("Delete PTMOwner");
            return Accepted(await _service.DeletePTMOwner(id));
        }
        catch (Exception ex)
        {
            _logger.LogError(ex.StackTrace);
            return BadRequest(ex.Message);
        }
    }
}