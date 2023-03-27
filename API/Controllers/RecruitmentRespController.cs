using Microsoft.AspNetCore.Mvc;
using Business.IServices;
using Core.ViewModel;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecruitmentRespController : ControllerBase
    {
        private readonly ILogger<RecruitmentRespController> _logger;
        private readonly IRecruitmentRespService _service;
        public RecruitmentRespController(ILogger<RecruitmentRespController> logger, IRecruitmentRespService service)
        {
            _logger = logger;
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<List<RecruitmentRespViewModel>?>> GetAll()
        {
            try
            {
                _logger.LogInformation("GetRecruitement");
                return Ok(await _service.GetRecruitmentResp());
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.StackTrace);
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<RecruitmentRespViewModel?>> GetRecruitmentResp(int id)
        {
            try
            {
                _logger.LogInformation("GetRecruitement");
                return Ok(await _service.GetRecruitmentResp(id));
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.StackTrace);
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public async Task<ActionResult<RecruitmentRespViewModel?>> CreateRecruitmentResp(RecruitmentRespViewModel recruitmentResp)
        {
            try
            {
                _logger.LogInformation("Add Recruitement");
                return Accepted(await _service.CreateRecruitmentResp(recruitmentResp));
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.StackTrace);
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public async Task<ActionResult<RecruitmentRespViewModel?>> UpdateRecruitmentResp(RecruitmentRespViewModel recruitmentResp)
        {
            try
            {
                _logger.LogInformation("Update Recruitement");
                return Accepted(await _service.UpdateRecruitmentResp(recruitmentResp));
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.StackTrace);
                return BadRequest(ex.Message);
            }

        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<RecruitmentRespViewModel>?>> DeleteRecruitmentResp(int id)
        {
            try
            {
                _logger.LogInformation("Delete Recruitement");
                return Accepted(await _service.DeleteRecruitmentResp(id));
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.StackTrace);
                return BadRequest(ex.Message);
            }
        }
    }
}

