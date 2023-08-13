using Realestate.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate.Application.Services.RealEstateService
{
    public interface IRealEstateCommand
    {


        int AddRealEstate(RealEstatesE realestate);

        void UpdateEstates(RealEstatesE request);

        void DeleteEstates(int id);

    }
}
