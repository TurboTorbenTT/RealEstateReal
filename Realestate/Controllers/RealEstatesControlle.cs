using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Realestate.Models;
using Realestate.Services.RealEstateService;

namespace Realestate.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RealEstatesControlle : ControllerBase
    {
        private readonly IRealEstateService _realEstateService;

        public RealEstatesControlle(IRealEstateService realEstateService) //kan få adgang til superhero service og metoder
        {
            _realEstateService= realEstateService;
        }
        [HttpGet]
        public async Task<ActionResult<List<RealEstates>>> GetAllEstates()
        {
            

            return _realEstateService.GetAllEstates();
        }


        [HttpGet("{id}")]
        
        public async Task<ActionResult<RealEstates>> GetSingleEstates(int id)
        {

            var result = _realEstateService.GetSingleEstates(id);

            if (result is null)
                return NotFound("Findes ikke");

            return Ok(result);
        }

        [HttpPost]

        public async Task<ActionResult<List<RealEstates>>> AddRealEstate(RealEstates realestate)
        {


            var result = _realEstateService.AddRealEstate(realestate);


            return Ok(result);
        }

        [HttpPut("{id}")]

        public async Task<ActionResult<List<RealEstates>>> UpdateEstates(int id, RealEstates request) //forward 
        {

            var result = _realEstateService.UpdateEstates(id, request);

            if (result is null)
                return NotFound("Findes ikke");

            return Ok(_realEstateService);
        }

        [HttpDelete("{id}")]

        public async Task<ActionResult<List<RealEstates>>> DeleteEstates(int id)
        {
            var result = _realEstateService.DeleteEstates(id);

            if(result is null)
                return NotFound("Findes ikke");

            return Ok(_realEstateService);
        }


    }
}
