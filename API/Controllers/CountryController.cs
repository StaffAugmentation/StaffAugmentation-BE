using Microsoft.AspNetCore.Mvc;
using Business.IServices;
using Core.ViewModel;

namespace API.Controllers;

[Route("api/[controller]")]
[ApiController]
public sealed class CountryController : ControllerBase
{
    private readonly ILogger<CountryController> _logger;
    private readonly ICountryService _service;
    public CountryController(ILogger<CountryController> logger, ICountryService service)
    {
        _logger = logger;
        _service = service;
    }

    [HttpGet]
    public async Task<ActionResult<List<CountryViewModel>?>> GetAll()
    {
        try
        {
            _logger.LogInformation("GetCountry");
            return Ok(await _service.GetCountry());
        }
        catch (Exception ex)
        {
            _logger.LogError(ex.StackTrace);
            return BadRequest(ex.Message);
        }
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<CountryViewModel?>> GetCountry(int id)
    {
        try
        {
            _logger.LogInformation("GetCountry");
            return Ok(await _service.GetCountry(id));
        }
        catch (Exception ex)
        {
            _logger.LogError(ex.StackTrace);
            return BadRequest(ex.Message);
        }
    }

    [HttpPost]
    public async Task<ActionResult<CountryViewModel?>> CreateCountry(CountryViewModel country)
    {
        try
        {
            _logger.LogInformation("Add Country");
            return Accepted(await _service.CreateCountry(country));
        }
        catch (Exception ex)
        {
            _logger.LogError(ex.StackTrace);
            return BadRequest(ex.Message);
        }
    }

    [HttpPut]
    public async Task<ActionResult<CountryViewModel?>> UpdateCountry(CountryViewModel country)
    {
        try
        {
            _logger.LogInformation("Update Country");
            return Accepted(await _service.UpdateCountry(country));
        }
        catch (Exception ex)
        {
            _logger.LogError(ex.StackTrace);
            return BadRequest(ex.Message);
        }

    }

    [HttpDelete("{id}")]
    public async Task<ActionResult<List<CountryViewModel>?>> DeleteCountry(int id)
    {
        try
        {
            _logger.LogInformation("Delete Country");
            return Accepted(await _service.DeleteCountry(id));
        }
        catch (Exception ex)
        {
            _logger.LogError(ex.StackTrace);
            return BadRequest(ex.Message);
        }
    }
}

