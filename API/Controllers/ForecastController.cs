using Microsoft.AspNetCore.Mvc;
using Business.IServices;
using Core.ViewModel;

namespace API.Controllers;

[Route("api/[controller]")]
[ApiController]
public sealed class ForecastController : ControllerBase
{
    private readonly ILogger<ForecastController> _logger;
    private readonly IForecastService _service;
    public ForecastController(ILogger<ForecastController> logger, IForecastService service)
    {
        _logger = logger;
        _service = service;
    }

    [HttpGet("{year}")]
    public async Task<ActionResult<ForecastViewModel?>> GetForecastByYear(int year)
    {
        try
        {
            _logger.LogInformation("GetForecasts");
            return Ok(await _service.GetForecastByYear(year));
        }
        catch (Exception ex)
        {
            _logger.LogError(ex.StackTrace);
            return BadRequest(ex.Message);
        }
    }

    [HttpPut]
    public async Task<ActionResult<ForecastViewModel?>> UpdateForecast(ForecastViewModel Forecast)
    {
        try
        {
            _logger.LogInformation("Update Forecast");
            return Accepted(await _service.UpdateForecast(Forecast));
        }
        catch (Exception ex)
        {
            _logger.LogError(ex.StackTrace);
            return BadRequest(ex.Message);
        }

    }

}

