using ProiectTest.Data;
using ProiectTest.GenericRepository;
using ProiectTest.Models;

namespace ProiectTest.ProductRepositoryy
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(ProiectTestContext context) : base(context)
        {
        }

        public Product GetByName(string name)
        {
            return _table.FirstOrDefault(x => x.Name == name);
        }

        public Product GetById(Guid id)
        {
            return _table.FirstOrDefault(x => x.Id == id);
        }
    }
}