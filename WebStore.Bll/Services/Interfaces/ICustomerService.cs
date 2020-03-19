using System.Collections.Generic;
using System.Threading.Tasks;
using WebStore.Bll.DTOs;

namespace WebStore.Bll.Services.Interfaces
{
    public interface ICustomerService
    {
        Task CreateAsync(CustomerDto dto);
        Task<CustomerDto> GetAsync(int id);
        Task<IEnumerable<CustomerDto>> GetAllAsync();
        Task UpdateAsync(CustomerDto dto);
        Task DeleteAsync(int id);
    }
}