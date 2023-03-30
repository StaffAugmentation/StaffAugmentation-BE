using Microsoft.AspNetCore.Mvc;
using Business.IServices;
using Core.ViewModel;

namespace API.Controllers;

[Route("api/[controller]")]
[ApiController]
public sealed class CompanyController : ControllerBase
{
    private readonly ILogger<CompanyController> _logger;
    private readonly ICompanyService _service;
    public CompanyController(ILogger<CompanyController> logger, ICompanyService service) 
    {
        _logger = logger;
        _service = service;
    }

    [HttpGet]
    public async Task<ActionResult<List<CompanyViewModel>?>> GetAll()
    {
        try
        {
            _logger.LogInformation("GetCompanies");
            return Ok(await _service.GetCompany());
        }catch (Exception ex)
        {
            _logger.LogError(ex.StackTrace);
            return BadRequest(ex.Message);
        }
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<CompanyViewModel?>> GetCompany(int id)
    {
        try
        {
            _logger.LogInformation("GetCompanies");
            return Ok(await _service.GetCompany(id));
        }
        catch (Exception ex)
        {
            _logger.LogError(ex.StackTrace);
            return BadRequest(ex.Message);
        }
    }

    [HttpPost]
    public async Task<ActionResult<CompanyViewModel?>> CreateCompany(CompanyViewModel company)
    {
        try
        {
            _logger.LogInformation("Add Company");
            return Accepted(await _service.CreateCompany(company));
        }
        catch (Exception ex)
        {
            _logger.LogError(ex.StackTrace);
            return BadRequest(ex.Message);
        }
    }

    [HttpPut]
    public async Task<ActionResult<CompanyViewModel?>> UpdateCompany(CompanyViewModel company)
    {
        try
        {
            _logger.LogInformation("Update Company");
            return Accepted(await _service.UpdateCompany(company));
        }
        catch (Exception ex)
        {
            _logger.LogError(ex.StackTrace);
            return BadRequest(ex.Message);
        }
        
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult<List<CompanyViewModel>?>> DeleteCompany(int id)
    {
        try
        {
            _logger.LogInformation("Delete Company");
            return Accepted(await _service.DeleteCompany(id));
        }
        catch (Exception ex)
        {
            _logger.LogError(ex.StackTrace);
            return BadRequest(ex.Message);
        }
    }
}

