using System.Collections.Generic;
using System.Threading.Tasks;
using WebStore.Dal.Entities;

namespace WebStore.Dal.Repositories.Interfaces
{
    public interface IOrderDetailsRepository
    {
        Task CreateAsync(OrderDetails orderDetails);
        Task DeleteAsync(int id);
        Task<OrderDetails> GetAsync(int id);
        Task<IEnumerable<OrderDetails>> GetAllAsync();
        Task UpdateAsync(OrderDetails orderDetails);
    }
}