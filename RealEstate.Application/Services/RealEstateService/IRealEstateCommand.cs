using Realestate.Models;

namespace RealEstate.Application.Services.RealEstateService
{
    public interface IRealEstateCommand
    {

        // TODO 
        // Name implies something already exists and being added, something is actually being created so name is misleading.
        int AddRealEstate(RealEstatesE realestate);

        void UpdateEstates(RealEstatesE request);

        void DeleteEstates(int id);

    }
}
