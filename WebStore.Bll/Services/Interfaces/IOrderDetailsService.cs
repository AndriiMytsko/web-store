using System.Collections.Generic;
using System.Threading.Tasks;
using WebStore.Bll.DTOs;

namespace WebStore.Bll.Services.Interfaces
{
    public interface IOrderDetailsService
    {
        Task<OrderDetailsDto> GetAsync(int id);
        Task<IEnumerable<OrderDetailsDto>> GetAllAsync();
        Task UpdateAsync(OrderDetailsDto dto);
        Task DeleteAsync(int id);
    }
}
