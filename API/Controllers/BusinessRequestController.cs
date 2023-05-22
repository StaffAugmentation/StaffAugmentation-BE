using Microsoft.AspNetCore.Mvc;
using Business.IServices;
using Core.ViewModel;
using Core.Model;
using System.Collections.Generic;

namespace API.Controllers;

[Route("api/[controller]")]
[ApiController]
public sealed class BusinessRequestController : ControllerBase
{
    private readonly ILogger<BusinessRequestController> _logger;
    private readonly IBusinessRequestService _service;
    public BusinessRequestController(ILogger<BusinessRequestController> logger, IBusinessRequestService service)
    {
        _logger = logger;
        _service = service;
    }
    [HttpGet]
    public async Task<ActionResult<List<BusinessRequestViewModel?>>> GetBusinessRequests(AdvancedSearchViewModel Search, int LocalUTC)
    {
        try
        {
            _logger.LogInformation("Get Business requests");
            return Ok(await _service.GetBusinessRequests(3251, Search, LocalUTC));

        }
        catch (Exception ex)
        {
            _logger.LogError(ex.StackTrace);
            return BadRequest(ex.Message);
        }
    }

    [HttpGet("{Id}")]
    public async Task<ActionResult<BusinessRequestViewModel?>> GetBusinessRequest(int Id, int LocalUTC)
    {
        try
        {
            _logger.LogInformation("Get Business request");
            return Ok(await _service.GetBusinessRequest(Id, LocalUTC));
        }
        catch (Exception ex)
        {
            _logger.LogError(ex.StackTrace);
            return BadRequest(ex.Message);
        }
    }

    [HttpPost]
    public async Task<ActionResult<AddResultViewModel?>> AddBusinessRequest(BusinessRequest BR, List<ProfileLevelViewModel> Listprofiles, List<BrConsultantViewModel> ListConsultants, List<CandidateDataViewModel> ListCandidates, List<BRAttachmentViewModel> ListAttachments, List<BrSubcontractorViewModel> ListBRSubcontractor)
    {
        try
        {
            _logger.LogInformation("Add Business request");
            string Login = HttpContext.User.Identity.Name;
            return Accepted(await _service.AddBusinessRequest(BR, Login, Listprofiles,ListConsultants, ListCandidates, ListAttachments, ListBRSubcontractor));
        }
        catch (Exception ex)
        {
            _logger.LogError(ex.StackTrace);
            return BadRequest(ex.Message);
        }
    }

    [HttpPut]
    public async Task<ActionResult<BusinessRequestViewModel?>> UpdateBusinessRequest(BusinessRequestViewModel BR)
    {
        try
        {
            _logger.LogInformation("Update Business request");
            return Accepted(await _service.UpdateBusinessRequest(BR));
        }
        catch (Exception ex)
        {
            _logger.LogError(ex.StackTrace);
            return BadRequest(ex.Message);
        }
    }
    [HttpDelete("{Id}")]
    public async Task<ActionResult<BusinessRequestViewModel?>> DeleteBusinessRequest(int Id)
    {
        try
        {
            _logger.LogInformation("Delete Business request");
            return Accepted(await _service.DeleteBusinessRequest(Id));
        }
        catch (Exception ex)
        {
            _logger.LogError(ex.StackTrace);
            return BadRequest(ex.Message);
        }
    }
}