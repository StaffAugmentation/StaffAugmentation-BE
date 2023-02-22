using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Business.IServices;
using Core.Model;
using Core.ViewModel;

namespace SuperHero.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        private readonly ILogger<CompanyController> _logger;
        private readonly ICompanyService _service;
        public CompanyController(ILogger<CompanyController> logger, ICompanyService service) 
        {
            _logger = logger;
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<List<Company>>> GetAll()
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

        [HttpPost]
        public async Task<ActionResult<List<CompanyViewModel>>> CreateCompany(CompanyViewModel company)
        {
            try
            {
                _logger.LogInformation("Add Company");
                return Ok(await _service.CreateCompany(company));
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.StackTrace);
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public async Task<ActionResult<List<CompanyViewModel>>> UpdateCompany(CompanyViewModel company)
        {
            try
            {
                _logger.LogInformation("Update Company");
                var dbHeroes = await _service.UpdateCompany(company);
                if (dbHeroes == null)
                    return NotFound("Company not found");

                return Ok(dbHeroes);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.StackTrace);
                return BadRequest(ex.Message);
            }
            
        }
    
        [HttpDelete("{id}")]
        public async Task<ActionResult<List<CompanyViewModel>>> DeleteCompany(int id)
        {
            try
            {
                _logger.LogInformation("Delete Company");
                var dbHeroes = await _service.DeleteCompany(id);
                if (dbHeroes == null)
                    return NotFound("Company not found.");

                return Ok(dbHeroes);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.StackTrace);
                return BadRequest(ex.Message);
            }
        }
    }
}

