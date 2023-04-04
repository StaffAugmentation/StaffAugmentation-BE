using Microsoft.AspNetCore.Mvc;
using Business.IServices;
using Core.ViewModel;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppParameterController : ControllerBase
    {
        private readonly ILogger<AppParameterController> _logger;
        private readonly IAppParameterService _service;
        public AppParameterController(ILogger<AppParameterController> logger, IAppParameterService service)
        {
            _logger = logger;
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<List<AppParameterViewModel>?>> GetAll()
        {
            try
            {
                _logger.LogInformation("GetAppParameter");
                return Ok(await _service.GetAppParameter());
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.StackTrace);
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<AppParameterViewModel?>> GetAppParameter(int id)
        {
            try
            {
                _logger.LogInformation("GetAppParameter");
                return Ok(await _service.GetAppParameter(id));
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.StackTrace);
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public async Task<ActionResult<AppParameterViewModel?>> CreateAppParameter(AppParameterViewModel appParameter)
        {
            try
            {
                _logger.LogInformation("Add AppParameter");
                return Accepted(await _service.CreateAppParameter(appParameter));
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.StackTrace);
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public async Task<ActionResult<AppParameterViewModel?>> UpdateAppParameter(AppParameterViewModel appParameter)
        {
            try
            {
                _logger.LogInformation("Update AppParameter");
                return Accepted(await _service.UpdateAppParameter(appParameter));
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.StackTrace);
                return BadRequest(ex.Message);
            }

        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<AppParameterViewModel>?>> DeleteAppParameter(int id)
        {
            try
            {
                _logger.LogInformation("Delete AppParameter");
                return Accepted(await _service.DeleteAppParameter(id));
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.StackTrace);
                return BadRequest(ex.Message);
            }
        }
    }
}

