using ProiectTest.Models;
using ProiectTest.Models.DTOs;

namespace ProiectTest.Services.ProductService
{
    public interface IProductService
    {
        Task<List<ProductDTO>> GetAll();

        // Get product by id
        Task<ProductDTO> GetById(Guid id);

        // Get product by name
        ProductDTO GetByName(string name);

        // Delete product by id
        Task Delete(Guid id);

        // Create product
        Task<Product> CreateProduct(Product product);

        // Update product
        void UpdateProduct(Guid id, Product product);
    }
}