using Realestate.Models;

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
