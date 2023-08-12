namespace Realestate.Services.RealEstateService
{
    public class RealEstateService : IRealEstateService
    {
        private static List<RealEstates> realEstates = new List<RealEstates>
            {
                new RealEstates { Id = 1,

                Adresse = "Kongebro gade 31",

                PostNr = "6000"

                },

                new RealEstates { Id = 2,

                Adresse = "Bredgade",

                PostNr = "6000"

                }

            };

        public List<RealEstates> AddRealEstate(RealEstates realestate)
        {
            realEstates.Add(realestate);


            return realEstates;
        }

        public List<RealEstates>? DeleteEstates(int id)
        {
            var realestate = realEstates.Find(x => x.Id == id);

            if (realestate == null)
                return null; //Kunne lave et wrapper object med en boolean

            realEstates.Remove(realestate);


            return realEstates;
        }

        public List<RealEstates> GetAllEstates()
        {
            return realEstates;
        }

        public RealEstates? GetSingleEstates(int id)
        {
            var realestate = realEstates.Find(x => x.Id == id);

            if (realestate == null)
                return null;

            return realestate;
        }

        public List<RealEstates>? UpdateEstates(int id, RealEstates request)
        {
            var realestate = realEstates.Find(x => x.Id == id);

            if (realestate == null)
                return null;

            realestate.PostNr = request.PostNr;
            realestate.Adresse = request.Adresse;
            realestate.Id = request.Id;

            return realEstates;
        }
    }
}
