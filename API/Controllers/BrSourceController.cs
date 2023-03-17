using Microsoft.AspNetCore.Mvc;
using Business.IServices;
using Core.ViewModel;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrSourceController : ControllerBase
    {
        private readonly ILogger<BrSourceController> _logger;
        private readonly IBrSourceService _service;
        public BrSourceController(ILogger<BrSourceController> logger, IBrSourceService service)
        {
            _logger = logger;
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<List<BrSourceViewModel>?>> GetAll()
        {
            try
            {
                _logger.LogInformation("GetBrSources");
                return Ok(await _service.GetBrSource());
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.StackTrace);
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{idSource}")]
        public async Task<ActionResult<BrSourceViewModel?>> GetBrSource(string idSource)
        {
            try
            {
                _logger.LogInformation("GetBrSources");
                return Ok(await _service.GetBrSource(idSource));
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.StackTrace);
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public async Task<ActionResult<BrSourceViewModel?>> CreateBrSource(BrSourceViewModel brSource)
        {
            try
            {
                _logger.LogInformation("Add BrSource");
                return Accepted(await _service.CreateBrSource(brSource));
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.StackTrace);
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public async Task<ActionResult<BrSourceViewModel?>> UpdateBrSource(BrSourceViewModel brSource)
        {
            try
            {
                _logger.LogInformation("Update BrSource");
                return Accepted(await _service.UpdateBrSource(brSource));
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.StackTrace);
                return BadRequest(ex.Message);
            }

        }

        [HttpDelete("{idSource}")]
        public async Task<ActionResult<List<BrSourceViewModel>?>> DeleteBrSource(string idSource)
        {
            try
            {
                _logger.LogInformation("Delete Department");
                return Accepted(await _service.DeleteBrSource(idSource));
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.StackTrace);
                return BadRequest(ex.Message);
            }
        }
    }
}

