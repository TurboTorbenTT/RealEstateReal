namespace Realestate.Services.RealEstateService
{
    public interface IRealEstateService
    {
        List<RealEstates> GetAllEstates();

        RealEstates? GetSingleEstates(int id);

        List<RealEstates> AddRealEstate(RealEstates realestate);

        List<RealEstates>? UpdateEstates(int id, RealEstates request);

        List<RealEstates>? DeleteEstates(int id);

    }
}
