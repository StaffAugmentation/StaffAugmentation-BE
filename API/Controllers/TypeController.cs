using Microsoft.AspNetCore.Mvc;
using Business.IServices;
using Core.ViewModel;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TypeController : ControllerBase
    {
        private readonly ILogger<TypeController> _logger;
        private readonly ITypeService _service;
        public TypeController(ILogger<TypeController> logger, ITypeService service)
        {
            _logger = logger;
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<List<TypeViewModel>?>> GetAll()
        {
            try
            {
                _logger.LogInformation("GetTypes");
                return Ok(await _service.GetType());
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.StackTrace);
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<TypeViewModel?>> GetType(int id)
        {
            try
            {
                _logger.LogInformation("GetTypes");
                return Ok(await _service.GetType(id));
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.StackTrace);
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public async Task<ActionResult<TypeViewModel?>> CreateType(TypeViewModel type)
        {
            try
            {
                _logger.LogInformation("Add Type");
                return Accepted(await _service.CreateType(type));
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.StackTrace);
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public async Task<ActionResult<TypeViewModel?>> UpdateType(TypeViewModel type)
        {
            try
            {
                _logger.LogInformation("Update Type");
                return Accepted(await _service.UpdateType(type));
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.StackTrace);
                return BadRequest(ex.Message);
            }

        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<TypeViewModel>?>> DeleteType(int id)
        {
            try
            {
                _logger.LogInformation("Delete Type");
                return Accepted(await _service.DeleteType(id));
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.StackTrace);
                return BadRequest(ex.Message);
            }
        }
    }
}

