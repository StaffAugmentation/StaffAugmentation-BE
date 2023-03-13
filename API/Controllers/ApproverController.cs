using Microsoft.AspNetCore.Mvc;
using Business.IServices;
using Core.Model;
using Core.ViewModel;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApproverController : ControllerBase
    {
        private readonly ILogger<ApproverController> _logger;
        private readonly IApproverService _service;
        public ApproverController(ILogger<ApproverController> logger, IApproverService service)
        {
            _logger = logger;
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<List<ApproverViewModel>?>> GetAll()
        {
            try
            {
                _logger.LogInformation("GetApprover");
                return Ok(await _service.GetApprover());
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.StackTrace);
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ApproverViewModel?>> GetApprover(int id)
        {
            try
            {
                _logger.LogInformation("GetApprover");
                return Ok(await _service.GetApprover(id));
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.StackTrace);
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public async Task<ActionResult<ApproverViewModel?>> CreateApprover(ApproverViewModel approver)
        {
            try
            {
                _logger.LogInformation("Add Approver");
                return Accepted(await _service.CreateApprover(approver));
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.StackTrace);
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public async Task<ActionResult<ApproverViewModel?>> UpdateApprover(ApproverViewModel approver)
        {
            try
            {
                _logger.LogInformation("Update Approver");
                return Accepted(await _service.UpdateApprover(approver));
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.StackTrace);
                return BadRequest(ex.Message);
            }

        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<ApproverViewModel>?>> DeleteApprover(int id)
        {
            try
            {
                _logger.LogInformation("Delete Approver");
                return Accepted(await _service.DeleteApprover(id));
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.StackTrace);
                return BadRequest(ex.Message);
            }
        }
    }
}

