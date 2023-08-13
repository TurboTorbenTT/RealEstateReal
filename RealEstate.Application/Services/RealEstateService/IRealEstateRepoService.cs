using Realestate.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate.Application.Services.RealEstateService
{
    public interface IRealEstateRepoService
    {

        int AddRealEstate(RealEstatesE realestate);

        void UpdateEstates(RealEstatesE request);

        void DeleteEstates(int id);

        RealEstatesE LoadRealestates(int id);
    }
}
