using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Realestate.Models;
using RealEstate.Application.Services.RealEstateService;

namespace Realestate.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RealEstatesControlle : ControllerBase
    {
        private readonly IRealestateQuery _realestateQuery;
        private readonly IRealEstateCommand _realEstateCommand;

        public RealEstatesControlle(IRealestateQuery realestateQuery, IRealEstateCommand realEstateCommand ) //kan få adgang til superhero service og metoder
        {
            
            _realestateQuery = realestateQuery;
            _realEstateCommand = realEstateCommand;
        }
        [HttpGet]
        public async Task<ActionResult<List<RealEstatesE>>> GetAllEstates()
        {
            var resut = _realestateQuery.GetAllEstates();


            return Ok(resut);

        }


        [HttpGet("{id}")]
        
        public async Task<ActionResult<RealEstatesE>> GetSingleEstates(int id)
        {

            var result = _realestateQuery.GetSingleEstates(id);

            if (result is null)
                return NotFound("Findes ikke");

            return Ok(result);
        }

        [HttpPost]

        public async Task<ActionResult<List<RealEstatesE>>> AddRealEstate(RealEstatesE realestate)
        {


            var result = _realEstateCommand.AddRealEstate(realestate);


            return Ok(result);
        }

        [HttpPut("{id}")]

        public async Task<ActionResult<List<RealEstatesE>>> UpdateEstates( RealEstatesE request) //forward 
        {

            _realEstateCommand.UpdateEstates( request);



            return Ok();
        }

        [HttpDelete("{id}")]

        public async Task<ActionResult<List<RealEstatesE>>> DeleteEstates(int id)
        {
            _realEstateCommand.DeleteEstates(id);


            return Ok();
        }



    }
}
