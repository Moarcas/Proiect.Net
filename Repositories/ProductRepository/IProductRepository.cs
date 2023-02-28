using ProiectTest.GenericRepository;
using ProiectTest.Models;

namespace ProiectTest.ProductRepositoryy
{
    public interface IProductRepository : IGenericRepository<Product>
    {
        // get by name
        Product GetByName(string name);

        // get by id
        Product GetById(Guid id);
    }
}