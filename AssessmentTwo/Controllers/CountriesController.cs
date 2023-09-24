using Microsoft.AspNetCore.Mvc;
using Shared.Contracts;

namespace AssessmentTwo.Controllers
{
    [Route("api/countries")]
    [ApiController]
    public class CountriesController : ControllerBase
    {
        private readonly ICountryService _countryService;

        public CountriesController(ICountryService countryService)
        {
            _countryService = countryService;
        }

        [HttpGet("GetCountryByPhoneNumber/{phoneNumber}")]
        public async Task<IActionResult> GetCountryByPhoneNumber(string phoneNumber)
        {
            var countryDto = await _countryService.GetCountryByPhoneNumber(phoneNumber);
            return Ok(countryDto);
        }

    }
}
