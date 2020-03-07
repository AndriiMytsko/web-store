using System.Collections.Generic;
using System.Threading.Tasks;
using WebStore.Dal.Entities;

namespace WebStore.Dal.Repositories.Interfaces
{
    public interface ICustomerRepository
    {
        Task CreateAsync(Customer customer);
        Task DeleteAsync(int id);
        Task<Customer> GetAsync(int id);
        Task<IEnumerable<Customer>> GetAllAsync();
        Task UpdateAsync(Customer customer);
    }
}