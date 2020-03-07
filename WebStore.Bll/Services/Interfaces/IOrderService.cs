using System.Collections.Generic;
using System.Threading.Tasks;
using WebStore.Bll.DTOs;

namespace WebStore.Bll.Services.Interfaces
{
    public interface IOrderService
    {
        Task CreateAsync(OrderDto dto);
        Task<OrderDto> GetAsync(int id);
        Task<IEnumerable<OrderDetailsDto>> GetOrderWithProductsAsync(int id);
        Task<IEnumerable<OrderDto>> GetAllAsync();
        Task UpdateAsync(OrderDto dto);
        Task DeleteAsync(int id);
    }
}
