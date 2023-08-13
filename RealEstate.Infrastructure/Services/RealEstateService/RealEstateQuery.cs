using Realestate.Models;
using RealEstate.Application.Services.RealEstateService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            List<RealEstatesE> realestateresult = _sqlDb.realEstates.ToList();

            return realestateresult;

            
        }

        public RealEstatesE? GetSingleEstates(int id)
        {
            RealEstatesE singleestate = _sqlDb.realEstates.Find(id);

            return singleestate;

        }
    }
}
