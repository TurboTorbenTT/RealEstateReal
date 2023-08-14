using Microsoft.EntityFrameworkCore;
using Realestate.Models;

namespace RealEstate.Infrastructure
{
    // TODO
    // Name should not reflect the backing type of database but what context you interact with persistence.
    // RealEstateContext could be a good name
    public class SqlDb : DbContext
    {
        
        public SqlDb(DbContextOptions<SqlDb> options) : base(options)
        {

        }
    
        // TODO
        // Use PascalCase
        // PascalCase -> RealEstates
        public DbSet<RealEstatesE> realEstates { get; set; }

    }
}
