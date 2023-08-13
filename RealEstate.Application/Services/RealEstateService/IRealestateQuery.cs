using Realestate.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate.Application.Services.RealEstateService
{
    public interface IRealestateQuery
    {
        List<RealEstatesE> GetAllEstates();

        RealEstatesE? GetSingleEstates(int id);

    }
}
