using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Dapper;
using WebStore.Dal.Configs;
using WebStore.Dal.Entities;
 using WebStore.Dal.Repositories.Interfaces;
using WebStore.Dal.Repositories.SqlCommands;

namespace WebStore.Dal.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly ConnectionSettings _connection;

        public CustomerRepository(ConnectionSettings conn)
        {
            _connection = conn;
        }

        public async Task CreateAsync(Customer customer)
        {
            using (IDbConnection db = GetConnection())
            {
                var sqlQuery = SqlCommandCustomer.CreateCustomer;
                await db.ExecuteAsync(sqlQuery, customer);
            }
        }

        public async Task<Customer> GetAsync(int id)
        {
            using (IDbConnection db = GetConnection())
            {
                return await db.QueryFirstOrDefaultAsync<Customer>(SqlCommandCustomer.GetCustomer, new { id });
            }
        }

        public async Task<IEnumerable<Customer>> GetAllAsync()
        {
            using (IDbConnection db = GetConnection())
            {
                return await db.QueryAsync<Customer>(SqlCommandCustomer.GetCustomers);
            }
        }

        public async Task UpdateAsync(Customer customer)
        {
            using (IDbConnection db = GetConnection())
            {
                var sqlQuery = SqlCommandCustomer.UpdateCustomer;
                await db.ExecuteAsync(sqlQuery, customer);
            }
        }

        public async Task DeleteAsync(int id)
        {
            using (IDbConnection db = GetConnection())
            {
                var sqlQuery = SqlCommandCustomer.DeleteCustomer;
                await db.ExecuteAsync(sqlQuery, new { id });
            }
        }

        private SqlConnection GetConnection() => new SqlConnection(_connection.SqlConnection);
    }
}