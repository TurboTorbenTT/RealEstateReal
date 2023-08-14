using Realestate.Models;

namespace RealEstate.Application.Services.RealEstateService
{
    public class RealEstateCommand : IRealEstateCommand
    {
        private readonly IRealEstateRepoService _realEstateRepoService;

        public RealEstateCommand(IRealEstateRepoService realEstateRepoService)
        {
            _realEstateRepoService = realEstateRepoService;
        }

        public int AddRealEstate(RealEstatesE realestate)
        {
            var id =_realEstateRepoService.AddRealEstate(realestate);

            return id;
            
        }

        public void DeleteEstates(int id)
        {
            _realEstateRepoService.DeleteEstates(id);
        }

        public void UpdateEstates(RealEstatesE request)
        {

            var oldrealestate = _realEstateRepoService.LoadRealestates(request.Id);

            oldrealestate.PostNr = request.PostNr;
            oldrealestate.Adresse = request.Adresse;
            
            _realEstateRepoService.UpdateEstates(oldrealestate);

            

            

        }
    }
}
