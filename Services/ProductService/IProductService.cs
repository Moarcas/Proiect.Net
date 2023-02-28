using ProiectTest.Models.DTOs;

namespace ProiectTest.Services.ProductService
{
    public interface IProductService
    {
        Task<List<ProductDTO>> GetAll();

        // Delete product by id
        Task Delete(Guid id);
        
    }
}