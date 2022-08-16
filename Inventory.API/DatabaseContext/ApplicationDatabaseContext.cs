using Inventory.API.Contracts;
using Inventory.API.Models;
using Microsoft.EntityFrameworkCore;

namespace Inventory.API.DatabaseContext
{
    public class ApplicationDatabaseContext : DbContext, IApplicationDatabaseContext
    {

        public ApplicationDatabaseContext(DbContextOptions<ApplicationDatabaseContext> options) : base(options)
        {

        }

        public DbSet<Product> Product { get; set; }
    }
}
