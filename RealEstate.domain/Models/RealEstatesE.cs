using System.ComponentModel.DataAnnotations;

namespace Realestate.Models
{
    // TODO
    // Fix typo
    public class RealEstatesE
    {
        
        // TODO
        // Should be GUID
        public int Id { get; set; }
        
        [Timestamp]
        public byte[] Version { get; set; }
        // TODO
        // Default value is not needed and should be enforced by constructor if needed
        public string Adresse { get; set; } = string.Empty;

        public string PostNr { get; set; } = string.Empty;
        
        
    }
}
