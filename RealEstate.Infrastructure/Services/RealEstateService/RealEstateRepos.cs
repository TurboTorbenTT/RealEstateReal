using RealEstate.Application.Services.RealEstateService;
using Realestate.Models;

namespace RealEstate.Infrastructure.Services.RealEstateService
{
    public class RealEstateRepos : IRealEstateRepoService
    {
        private readonly SqlDb _sqlDb;

        public RealEstateRepos(SqlDb sqlDb)
        {
            _sqlDb = sqlDb;
        }

        // TODO
        // RealEstate is implied from repo name and does not need to exist in function naming.
        public int AddRealEstate(RealEstatesE realestate)
        {
            _sqlDb.realEstates.Add(realestate);


            _sqlDb.SaveChanges();

            return realestate.Id;

            
        }

        // TODO
        // Name implies plural yet function affects singular
        public void DeleteEstates(int id)
        {
            var realestate = _sqlDb.realEstates.Find(id) ?? throw new ArgumentException("Real estate not found");

            _sqlDb.realEstates.Remove(realestate);

            _sqlDb.SaveChanges();
        }
        
        // TODO
        // Name could be better defining, maybe mirror inner Find() method?
        public RealEstatesE LoadRealestates(int id)
        {
            var realestate = _sqlDb.realEstates.Find(id) ?? throw new ArgumentException("Real estate not found");

            return realestate;
        }
        
        public void UpdateEstates(RealEstatesE request)
        {
            _sqlDb.realEstates.Update(request);

            _sqlDb.SaveChanges();
        }
    }
}
