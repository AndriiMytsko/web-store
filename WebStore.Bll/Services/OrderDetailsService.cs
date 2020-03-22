using AutoMapper;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebStore.Bll.DTOs;
using WebStore.Bll.Services.Interfaces;
using WebStore.Dal.Repositories.Interfaces;

namespace WebStore.Bll.Services
{

    public class OrderDetailsService : IOrderDetailsService
    {
        private readonly IMapper _mapper;
        private readonly IOrderDetailsRepository _orderDetailsRepository;

        public OrderDetailsService(
            IMapper mapper,
            IOrderDetailsRepository orderDetailsRepository)
        {
            _mapper = mapper;
            _orderDetailsRepository = orderDetailsRepository;
        }

        public async Task<OrderDetailsDto> GetAsync(int Id)
        {
            var entity = await _orderDetailsRepository.GetAsync(Id);
            var orderDetails = _mapper.Map<OrderDetailsDto>(entity);

            return orderDetails;
        }

        public async Task<IEnumerable<OrderDetailsDto>> GetAllAsync()
        {
            var entities = await _orderDetailsRepository.GetAllAsync();
            var orderDetails = _mapper.Map<IEnumerable<OrderDetailsDto>>(entities);

            return orderDetails;
        }

        public async Task UpdateAsync(OrderDetailsDto dto)
        {
            var entity = await _orderDetailsRepository.GetAsync(dto.Order.Id);
            entity.ProductId = dto.Product.Id;
            entity.Quantity = dto.Quantity;

            await _orderDetailsRepository.UpdateAsync(entity);
        }

        public async Task DeleteAsync(int Id)
        {
            var entity = await _orderDetailsRepository.GetAsync(Id);
            if (entity == null)
            {
                return;
            }

            await _orderDetailsRepository.DeleteAsync(Id);
        }
    }
}