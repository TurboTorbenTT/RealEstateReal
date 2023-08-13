using Realestate.Models;
using RealEstate.Application.Services.RealEstateService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate.Infrastructure.Services.RealEstateService
{
    public class RealEstateRepos : IRealEstateRepoService
    {
        private readonly SqlDb _sqlDb;

        public RealEstateRepos(SqlDb sqlDb)
        {
            _sqlDb = sqlDb;
        }

        public int AddRealEstate(RealEstatesE realestate)
        {
            _sqlDb.realEstates.Add(realestate);


            _sqlDb.SaveChanges();

            return realestate.Id;

            
        }

        public void DeleteEstates(int id)
        {
            var realestate = _sqlDb.realEstates.Find(id) ?? throw new ArgumentException("Real estate not found");

            _sqlDb.realEstates.Remove(realestate);

            _sqlDb.SaveChanges();
        }

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
