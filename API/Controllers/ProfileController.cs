using Microsoft.AspNetCore.Mvc;
using Business.IServices;
using Core.Model;
using Core.ViewModel;
using AutoMapper;

namespace API.Controllers;

[Route("api/[controller]")]
[ApiController]
public sealed class ProfileController : ControllerBase
{
    private readonly ILogger<ProfileController> _logger;
    private readonly IProfileService _service;
    public ProfileController(ILogger<ProfileController> logger, IProfileService service)
    {
        _logger = logger;
        _service = service;
    }

    [HttpGet]
    public async Task<ActionResult<List<ProfileViewModel>?>> GetAll()
    {
        try
        {
            _logger.LogInformation("GetProfile");
            return Ok(await _service.GetProfile());
        }
        catch (Exception ex)
        {
            _logger.LogError(ex.StackTrace);
            return BadRequest(ex.Message);
        }
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<ProfileViewModel?>> GetProfile(int id)
    {
        try
        {
            _logger.LogInformation("GetProfile");
            return Ok(await _service.GetProfile(id));
        }
        catch (Exception ex)
        {
            _logger.LogError(ex.StackTrace);
            return BadRequest(ex.Message);
        }
    }

    [HttpPost]
    public async Task<ActionResult<ProfileViewModel?>> CreateProfile(ProfileViewModel profile)
    {
        try
        {
            _logger.LogInformation("Add Profile");
            return Accepted(await _service.CreateProfile(profile));
        }
        catch (Exception ex)
        {
            _logger.LogError(ex.StackTrace);
            return BadRequest(ex.Message);
        }
    }

    [HttpPut]
    public async Task<ActionResult<ProfileViewModel?>> UpdateProfile(ProfileViewModel profile)
    {
        try
        {
            _logger.LogInformation("Update Profile");
            return Accepted(await _service.UpdateProfile(profile));
        }
        catch (Exception ex)
        {
            _logger.LogError(ex.StackTrace);
            return BadRequest(ex.Message);
        }

    }

    [HttpDelete("{id}")]
    public async Task<ActionResult<List<ProfileViewModel>?>> DeleteProfile(int id)
    {
        try
        {
            _logger.LogInformation("Delete Profile");
            return Accepted(await _service.DeleteProfile(id));
        }
        catch (Exception ex)
        {
            _logger.LogError(ex.StackTrace);
            return BadRequest(ex.Message);
        }
    }
}

