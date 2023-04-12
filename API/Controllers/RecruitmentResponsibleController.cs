using Microsoft.AspNetCore.Mvc;
using Business.IServices;
using Core.ViewModel;
using Core.Model;

namespace API.Controllers;

[Route("api/[controller]")]
[ApiController]
public sealed class RecruitmentResponsibleController : ControllerBase
{
    private readonly ILogger<RecruitmentResponsibleController> _logger;
    private readonly IRecruitmentResponsibleService _service;
    public RecruitmentResponsibleController(ILogger<RecruitmentResponsibleController> logger, IRecruitmentResponsibleService service)
    {
        _logger = logger;
        _service = service;
    }

    [HttpGet]
    public async Task<ActionResult<List<RecruitmentResponsibleViewModel>?>> GetAll()
    {
        try
        {
            _logger.LogInformation("Get Recruitement");
            return Ok(await _service.GetRecruitmentResponsible());
        }
        catch (Exception ex)
        {
            _logger.LogError(ex.StackTrace);
            return BadRequest(ex.Message);
        }
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<RecruitmentResponsibleViewModel?>> GetRecruitmentResponsible(int id)
    {
        try
        {
            _logger.LogInformation("GetRecruitement");
            return Ok(await _service.GetRecruitmentResponsible(id));
        }
        catch (Exception ex)
        {
            _logger.LogError(ex.StackTrace);
            return BadRequest(ex.Message);
        }
    }

    [HttpPost]
    public async Task<ActionResult<RecruitmentResponsibleViewModel?>> CreateRecruitmentResponsible(RecruitmentResponsibleViewModel recruitmentResponsible)
    {
        try
        {
            _logger.LogInformation("Add Recruitement");
            return Accepted(await _service.CreateRecruitmentResponsible(recruitmentResponsible));
        }
        catch (Exception ex)
        {
            _logger.LogError(ex.StackTrace);
            return BadRequest(ex.Message);
        }
    }

    [HttpPut]
    public async Task<ActionResult<RecruitmentResponsibleViewModel?>> UpdateRecruitmentResponsible(RecruitmentResponsibleViewModel recruitmentResponsible)
    {
        try
        {
            _logger.LogInformation("Update Recruitement");
            return Accepted(await _service.UpdateRecruitmentResponsible(recruitmentResponsible));
        }
        catch (Exception ex)
        {
            _logger.LogError(ex.StackTrace);
            return BadRequest(ex.Message);
        }

    }

    [HttpDelete("{id}")]
    public async Task<ActionResult<List<RecruitmentResponsibleViewModel>?>> DeleteRecruitmentResponsible(int id)
    {
        try
        {
            _logger.LogInformation("Delete Recruitement");
            return Accepted(await _service.DeleteRecruitmentResponsible(id));
        }
        catch (Exception ex)
        {
            _logger.LogError(ex.StackTrace);
            return BadRequest(ex.Message);
        }
    }
}

