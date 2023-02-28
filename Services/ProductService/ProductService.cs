using AutoMapper;
using ProiectTest.Models;
using ProiectTest.Models.DTOs;
using ProiectTest.ProductRepositoryy;

namespace ProiectTest.Services.ProductService
{
    public class ProductService : IProductService
    {
        public IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public ProductService(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        public async Task<List<ProductDTO>> GetAll()
        {
            var products = await _productRepository.GetAll();

            return _mapper.Map<List<ProductDTO>>(products);
        }

        public async Task Delete(Guid id)
        {
            var product = await _productRepository.FindByIdAsync(id);

            if (product == null)
            {
                throw new Exception("Product not found");
            }

            await _productRepository.DeleteAsync(product);
        }
    }
}