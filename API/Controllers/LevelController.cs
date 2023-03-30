using Microsoft.AspNetCore.Mvc;
using Business.IServices;
using Core.ViewModel;

namespace API.Controllers;

[Route("api/[controller]")]
[ApiController]
public sealed class LevelController : ControllerBase
{
    private readonly ILogger<LevelController> _logger;
    private readonly ILevelService _service;
    public LevelController(ILogger<LevelController> logger, ILevelService service)
    {
        _logger = logger;
        _service = service;
    }

    [HttpGet]
    public async Task<ActionResult<List<LevelViewModel>?>> GetAll()
    {
        try
        {
            _logger.LogInformation("GetLevel");
            return Ok(await _service.GetLevel());
        }
        catch (Exception ex)
        {
            _logger.LogError(ex.StackTrace);
            return BadRequest(ex.Message);
        }
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<LevelViewModel?>> GetLevel(int id)
    {
        try
        {
            _logger.LogInformation("GetLevel");
            return Ok(await _service.GetLevel(id));
        }
        catch (Exception ex)
        {
            _logger.LogError(ex.StackTrace);
            return BadRequest(ex.Message);
        }
    }

    [HttpPost]
    public async Task<ActionResult<LevelViewModel?>> CreateLevel(LevelViewModel level)
    {
        try
        {
            _logger.LogInformation("Add Level");
            return Accepted(await _service.CreateLevel(level));
        }
        catch (Exception ex)
        {
            _logger.LogError(ex.StackTrace);
            return BadRequest(ex.Message);
        }
    }

    [HttpPut]
    public async Task<ActionResult<LevelViewModel?>> UpdateLevel(LevelViewModel level)
    {
        try
        {
            _logger.LogInformation("Update Level");
            return Accepted(await _service.UpdateLevel(level));
        }
        catch (Exception ex)
        {
            _logger.LogError(ex.StackTrace);
            return BadRequest(ex.Message);
        }

    }

    [HttpDelete("{id}")]
    public async Task<ActionResult<List<LevelViewModel>?>> DeleteLevel(int id)
    {
        try
        {
            _logger.LogInformation("Delete Level");
            return Accepted(await _service.DeleteLevel(id));
        }
        catch (Exception ex)
        {
            _logger.LogError(ex.StackTrace);
            return BadRequest(ex.Message);
        }
    }
}

