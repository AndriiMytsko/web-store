using AutoMapper;
using WebStore.Bll.DTOs;
using WebStore.WebApi.Models.Orders;

namespace WebStore.WebApi.Infrastructure.ServiceExtensions
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<OrderDetailsDto, OrderProductsViewModel>().ReverseMap();
        }
    }
}
