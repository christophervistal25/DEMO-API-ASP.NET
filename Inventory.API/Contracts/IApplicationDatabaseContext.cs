using Inventory.API.Models;
using Microsoft.EntityFrameworkCore;

namespace Inventory.API.Contracts
{
    public interface IApplicationDatabaseContext
    {
        public DbSet<Product> Product { get; set; }
    }
}
