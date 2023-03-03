using AutoMapper;
using ProiectTest.Models;
using ProiectTest.Models.DTOs;

namespace ProiectTest.Helper.Mapper
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<Product, ProductDTO>();
            CreateMap<Category, CategoryDTO>();   
            CreateMap<User, UserRequestDTO>();         
        }
    }
}