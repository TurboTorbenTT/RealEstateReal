using Realestate.Models;

namespace RealEstate.Application.Services.RealEstateService
{
    public interface IRealestateQuery
    {
        List<RealEstatesE> GetAllEstates();

        RealEstatesE? GetSingleEstates(int id);

    }
}
