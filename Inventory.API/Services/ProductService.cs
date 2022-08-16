using Inventory.API.Contracts;
using Inventory.API.DatabaseContext;
using Inventory.API.Models;

namespace Inventory.API.Services
{
    public class ProductService : IProductService
    {
        private readonly ApplicationDatabaseContext _context;
        public ProductService(ApplicationDatabaseContext context)
        {
            _context = context;
        }

        public void Add(Product entity)
        {
          _context.Product.Add(entity);
          _context.SaveChanges();
        }

        public Product Find(int id)
        {
            return _context.Product.Where((product) => product.Id == id).FirstOrDefault();
        }

        public IEnumerable<Product> Get()
        {
            return _context.Product.ToList();
        }

        public void Update(Product entity)
        {
            _context.Product.Update(entity);
            _context.SaveChanges();
        }
    }
}
