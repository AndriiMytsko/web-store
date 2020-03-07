using AutoMapper;
using WebStore.Bll.DTOs;
using WebStore.Dal.Entities;

namespace WebStore.Bll
{
    public class BllMappingProfile : Profile
    {
        public BllMappingProfile()
        {
            CreateMap<CategoryDto, Category>().ReverseMap();
            CreateMap<CustomerDto, Customer>().ReverseMap();
            CreateMap<OrderDto, Order>().ReverseMap();
            CreateMap<OrderDetailsDto, OrderDetails>().ReverseMap();
            CreateMap<ProductDto, Product>().ReverseMap();


        }
    }
}
