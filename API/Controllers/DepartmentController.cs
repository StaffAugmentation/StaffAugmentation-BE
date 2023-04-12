using Microsoft.AspNetCore.Mvc;
using Business.IServices;
using Core.ViewModel;

namespace API.Controllers;

[Route("api/[controller]")]
[ApiController]
public sealed class DepartmentController : ControllerBase
{
    private readonly ILogger<DepartmentController> _logger;
    private readonly IDepartmentService _service;
    public DepartmentController(ILogger<DepartmentController> logger, IDepartmentService service) 
    {
        _logger = logger;
        _service = service;
    }

    [HttpGet]
    public async Task<ActionResult<List<DepartmentViewModel>?>> GetAll()
    {
        try
        {
            _logger.LogInformation("GetDepartments");
            return Ok(await _service.GetDepartment());
        }catch (Exception ex)
        {
            _logger.LogError(ex.StackTrace);
            return BadRequest(ex.Message);
        }
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<DepartmentViewModel?>> GetDepartment(int id)
    {
        try
        {
            _logger.LogInformation("GetDepartments");
            return Ok(await _service.GetDepartment(id));
        }
        catch (Exception ex)
        {
            _logger.LogError(ex.StackTrace);
            return BadRequest(ex.Message);
        }
    }

    [HttpPost]
    public async Task<ActionResult<DepartmentViewModel?>> CreateDepartment(DepartmentViewModel department)
    {
        try
        {
            _logger.LogInformation("Add Department");
            return Accepted(await _service.CreateDepartment(department));
        }
        catch (Exception ex)
        {
            _logger.LogError(ex.StackTrace);
            return BadRequest(ex.Message);
        }
    }

    [HttpPut]
    public async Task<ActionResult<DepartmentViewModel?>> UpdateDepartment(DepartmentViewModel department)
    {
        try
        {
            _logger.LogInformation("Update Department");
            return Accepted(await _service.UpdateDepartment(department));
        }
        catch (Exception ex)
        {
            _logger.LogError(ex.StackTrace);
            return BadRequest(ex.Message);
        }
        
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult<List<DepartmentViewModel>?>> DeleteDepartment(int id)
    {
        try
        {
            _logger.LogInformation("Delete Department");
            return Accepted(await _service.DeleteDepartment(id));
        }
        catch (Exception ex)
        {
            _logger.LogError(ex.StackTrace);
            return BadRequest(ex.Message);
        }
    }
}

