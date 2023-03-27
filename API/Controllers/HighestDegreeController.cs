using Microsoft.AspNetCore.Mvc;
using Business.IServices;
using Core.ViewModel;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HighestDegreeController : ControllerBase
    {
        private readonly ILogger<HighestDegreeController> _logger;
        private readonly IHighestDegreeService _service;
        public HighestDegreeController(ILogger<HighestDegreeController> logger, IHighestDegreeService service)
        {
            _logger = logger;
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<List<HighestDegreeViewModel>?>> GetAll()
        {
            try
            {
                _logger.LogInformation("GetHighestDegrees");
                return Ok(await _service.GetHighestDegree());
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.StackTrace);
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<HighestDegreeViewModel?>> GetHighestDegree(int id)
        {
            try
            {
                _logger.LogInformation("GetHighestDegrees");
                return Ok(await _service.GetHighestDegree(id));
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.StackTrace);
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public async Task<ActionResult<HighestDegreeViewModel?>> CreateHighestDegree(HighestDegreeViewModel HighestDegree)
        {
            try
            {
                _logger.LogInformation("Add HighestDegree");
                return Accepted(await _service.CreateHighestDegree(HighestDegree));
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.StackTrace);
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public async Task<ActionResult<HighestDegreeViewModel?>> UpdateHighestDegree(HighestDegreeViewModel HighestDegree)
        {
            try
            {
                _logger.LogInformation("Update HighestDegree");
                return Accepted(await _service.UpdateHighestDegree(HighestDegree));
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.StackTrace);
                return BadRequest(ex.Message);
            }

        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<HighestDegreeViewModel>?>> DeleteHighestDegree(int id)
        {
            try
            {
                _logger.LogInformation("Delete HighestDegree");
                return Accepted(await _service.DeleteHighestDegree(id));
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.StackTrace);
                return BadRequest(ex.Message);
            }
        }
    }
}

