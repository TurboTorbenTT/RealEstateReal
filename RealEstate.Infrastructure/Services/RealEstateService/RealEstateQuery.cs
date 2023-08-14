using RealEstate.Application.Services.RealEstateService;
using Realestate.Models;

namespace RealEstate.Infrastructure.Services.RealEstateService
{
    public class RealEstateQuery : IRealestateQuery
    {
        private readonly SqlDb _sqlDb;

        public RealEstateQuery(SqlDb sqlDb)
        {
            _sqlDb = sqlDb;
        }
        public List<RealEstatesE> GetAllEstates()
        {
            var realestateresult = _sqlDb.realEstates.ToList();
            return realestateresult;

            
        }

        public RealEstatesE? GetSingleEstates(int id)
        {
            // Possibly null
            // Use var style instead of concrete types
            
            var singleestate = _sqlDb.realEstates.Find(id);

            return singleestate;

        }
    }
}
