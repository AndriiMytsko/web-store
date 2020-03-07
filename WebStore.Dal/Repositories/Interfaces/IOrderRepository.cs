using System.Collections.Generic;
using System.Threading.Tasks;
using WebStore.Dal.Entities;

namespace WebStore.Dal.Repositories.Interfaces
{
    public interface IOrderRepository
    {
        Task CreateAsync(Order order);
        Task DeleteAsync(int id);
        Task<Order> GetAsync(int id);
        Task<IEnumerable<OrderDetails>> GetOrderWithProductsAsync(int id);
        Task<IEnumerable<Order>> GetAllAsync();
        Task UpdateAsync(Order order);
    }
}