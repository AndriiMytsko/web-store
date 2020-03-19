using AutoMapper;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebStore.Bll.DTOs;
using WebStore.Bll.Services.Interfaces;
using WebStore.Dal.Entities;
using WebStore.Dal.Repositories.Interfaces;

namespace WebStore.Bll.Services
{

    public class OrderService : IOrderService
    {
        private readonly IMapper _mapper;
        private readonly IOrderRepository _orderRepository;

        public OrderService(
            IMapper mapper,
            IOrderRepository orderRepository)
        {
            _mapper = mapper;
            _orderRepository = orderRepository;
        }

        public async Task CreateAsync(OrderDto dto)
        {
            var entity = _mapper.Map<Order>(dto);

            await _orderRepository.CreateAsync(entity);
        }

        public async Task<OrderDto> GetAsync(int Id)
        {
            var entity = await _orderRepository.GetAsync(Id);
            var order = _mapper.Map<OrderDto>(entity);

            return order;
        }

        public async Task<IEnumerable<OrderDetailsDto>> GetOrderWithProductsAsync(int id)
        {
            var entity = await _orderRepository.GetOrderWithProductsAsync(id);
            var orders = _mapper.Map<IEnumerable<OrderDetailsDto>>(entity);

            return orders;
        }

        public async Task<IEnumerable<OrderDto>> GetAllAsync()
        {
            var entities = await _orderRepository.GetAllAsync();
            var orders = _mapper.Map<IEnumerable<OrderDto>>(entities);

            return orders;
        }

        public async Task UpdateAsync(OrderDto dto)
        {
            var entity = await _orderRepository.GetAsync(dto.Id);
         
            await _orderRepository.UpdateAsync(entity);
        }

        public async Task DeleteAsync(int Id)
        {
            var entity = await _orderRepository.GetAsync(Id);
            if (entity == null)
            {
                return;
            }

            await _orderRepository.DeleteAsync(Id);
        }
    }
}