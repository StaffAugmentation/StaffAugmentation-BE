using Microsoft.AspNetCore.Mvc;
using Business.IServices;
using Core.ViewModel;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OERPCodeController : ControllerBase
    {
        private readonly ILogger<OERPCodeController> _logger;
        private readonly IOERPCodeService _service;
        public OERPCodeController(ILogger<OERPCodeController> logger, IOERPCodeService service)
        {
            _logger = logger;
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<List<OERPCodeViewModel>?>> GetAll()
        {
            try
            {
                _logger.LogInformation("GetOERPCode");
                return Ok(await _service.GetOERPCode());
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.StackTrace);
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<OERPCodeViewModel?>> GetOERPCode(int id)
        {
            try
            {
                _logger.LogInformation("GetOERPCode");
                return Ok(await _service.GetOERPCode(id));
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.StackTrace);
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public async Task<ActionResult<OERPCodeViewModel?>> CreateOERPCode(OERPCodeViewModel OERPCode)
        {
            try
            {
                _logger.LogInformation("Add OERPCode");
                return Accepted(await _service.CreateOERPCode(OERPCode));
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.StackTrace);
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public async Task<ActionResult<OERPCodeViewModel?>> UpdateOERPCode(OERPCodeViewModel OERPCode)
        {
            try
            {
                _logger.LogInformation("Update OERPCode");
                return Accepted(await _service.UpdateOERPCode(OERPCode));
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.StackTrace);
                return BadRequest(ex.Message);
            }

        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<OERPCodeViewModel>?>> DeleteOERPCode(int id)
        {
            try
            {
                _logger.LogInformation("Delete OERPCode");
                return Accepted(await _service.DeleteOERPCode(id));
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.StackTrace);
                return BadRequest(ex.Message);
            }
        }
    }
}

