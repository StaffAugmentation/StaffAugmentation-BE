using Microsoft.AspNetCore.Mvc;
using Business.IServices;
using Core.ViewModel;

namespace API.Controllers;

[Route("api/[controller]")]
[ApiController]
public sealed class PlaceOfDeliveryController : ControllerBase
{
    private readonly ILogger<PlaceOfDeliveryController> _logger;
    private readonly IPlaceOfDeliveryService _service;
    public PlaceOfDeliveryController(ILogger<PlaceOfDeliveryController> logger, IPlaceOfDeliveryService service)
    {
        _logger = logger;
        _service = service;
    }

    [HttpGet]
    public async Task<ActionResult<List<PlaceOfDeliveryViewModel>?>> GetAll()
    {
        try
        {
            _logger.LogInformation("GetPlaceOfDeliverys");
            return Ok(await _service.GetPlaceOfDelivery());
        }
        catch (Exception ex)
        {
            _logger.LogError(ex.StackTrace);
            return BadRequest(ex.Message);
        }
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<PlaceOfDeliveryViewModel?>> GetPlaceOfDelivery(int id)
    {
        try
        {
            _logger.LogInformation("GetPlaceOfDeliverys");
            return Ok(await _service.GetPlaceOfDelivery(id));
        }
        catch (Exception ex)
        {
            _logger.LogError(ex.StackTrace);
            return BadRequest(ex.Message);
        }
    }

    [HttpPost]
    public async Task<ActionResult<PlaceOfDeliveryViewModel?>> CreatePlaceOfDelivery(PlaceOfDeliveryViewModel PlaceOfDelivery)
    {
        try
        {
            _logger.LogInformation("Add PlaceOfDelivery");
            return Accepted(await _service.CreatePlaceOfDelivery(PlaceOfDelivery));
        }
        catch (Exception ex)
        {
            _logger.LogError(ex.StackTrace);
            return BadRequest(ex.Message);
        }
    }

    [HttpPut]
    public async Task<ActionResult<PlaceOfDeliveryViewModel?>> UpdatePlaceOfDelivery(PlaceOfDeliveryViewModel PlaceOfDelivery)
    {
        try
        {
            _logger.LogInformation("Update PlaceOfDelivery");
            return Accepted(await _service.UpdatePlaceOfDelivery(PlaceOfDelivery));
        }
        catch (Exception ex)
        {
            _logger.LogError(ex.StackTrace);
            return BadRequest(ex.Message);
        }

    }

    [HttpDelete("{id}")]
    public async Task<ActionResult<List<PlaceOfDeliveryViewModel>?>> DeletePlaceOfDelivery(int id)
    {
        try
        {
            _logger.LogInformation("Delete PlaceOfDelivery");
            return Accepted(await _service.DeletePlaceOfDelivery(id));
        }
        catch (Exception ex)
        {
            _logger.LogError(ex.StackTrace);
            return BadRequest(ex.Message);
        }
    }
}

