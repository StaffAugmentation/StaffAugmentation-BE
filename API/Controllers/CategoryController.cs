using Microsoft.AspNetCore.Mvc;
using Business.IServices;
using Core.ViewModel;

namespace API.Controllers;

[Route("api/[controller]")]
[ApiController]
public sealed class CategoryController : ControllerBase
{
    private readonly ILogger<CategoryController> _logger;
    private readonly ICategoryService _service;
    public CategoryController(ILogger<CategoryController> logger, ICategoryService service)
    {
        _logger = logger;
        _service = service;
    }

    [HttpGet]
    public async Task<ActionResult<List<CategoryViewModel>?>> GetAll()
    {
        try
        {
            _logger.LogInformation("GetCategories");
            return Ok(await _service.GetCategory());
        }
        catch (Exception ex)
        {
            _logger.LogError(ex.StackTrace);
            return BadRequest(ex.Message);
        }
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<CategoryViewModel?>> GetCategory(int id)
    {
        try
        {
            _logger.LogInformation("GetCategory");
            return Ok(await _service.GetCategory(id));
        }
        catch (Exception ex)
        {
            _logger.LogError(ex.StackTrace);
            return BadRequest(ex.Message);
        }
    }

    [HttpPost]
    public async Task<ActionResult<CategoryViewModel?>> CreateCategory(CategoryViewModel category)
    {
        try
        {
            _logger.LogInformation("Add Category");
            return Accepted(await _service.CreateCategory(category));
        }
        catch (Exception ex)
        {
            _logger.LogError(ex.StackTrace);
            return BadRequest(ex.Message);
        }
    }

    [HttpPut]
    public async Task<ActionResult<CategoryViewModel?>> UpdateCategory(CategoryViewModel category)
    {
        try
        {
            _logger.LogInformation("Update Category");
            return Accepted(await _service.UpdateCategory(category));
        }
        catch (Exception ex)
        {
            _logger.LogError(ex.StackTrace);
            return BadRequest(ex.Message);
        }

    }

    [HttpDelete("{id}")]
    public async Task<ActionResult<List<CategoryViewModel>?>> DeleteCategory(int id)
    {
        try
        {
            _logger.LogInformation("Delete Category");
            return Accepted(await _service.DeleteCategory(id));
        }
        catch (Exception ex)
        {
            _logger.LogError(ex.StackTrace);
            return BadRequest(ex.Message);
        }
    }
}

