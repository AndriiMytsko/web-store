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
    public class OrderDetailsRepository : IOrderDetailsRepository
    {
        private readonly ConnectionSettings _connection;

        public OrderDetailsRepository(ConnectionSettings conn)
        {
            _connection = conn;
        }

        public async Task CreateAsync(IEnumerable<OrderDetails> orderDetails)
        {
            using (IDbConnection db = GetConnection())
            {
                var sqlQuery = SqlCommandOrderDetails.CreateOrderDetails;
                await db.ExecuteAsync(sqlQuery, orderDetails);
            }
        }

        public async Task<OrderDetails> GetAsync(int id)
        {
            using (IDbConnection db = GetConnection())
            {
                return await db.QueryFirstOrDefaultAsync<OrderDetails>(SqlCommandOrderDetails.GetOrderDetails, new { id });
            }
        }

        public async Task<IEnumerable<OrderDetails>> GetAllAsync()
        {
            using (IDbConnection db = GetConnection())
            {
                return await db.QueryAsync<OrderDetails>(SqlCommandOrderDetails.GetAll);
            }
        }

        public async Task UpdateAsync(OrderDetails orderDetails)
        {
            using (IDbConnection db = GetConnection())
            {
                var sqlQuery = SqlCommandOrderDetails.UpdateOrderDetails;
                await db.ExecuteAsync(sqlQuery, orderDetails);
            }
        }

        public async Task DeleteAsync(int id)
        {
            using (IDbConnection db = GetConnection())
            {
                var sqlQuery = SqlCommandOrderDetails.DeleteOrderDetails;
                await db.ExecuteAsync(sqlQuery, new { id });
            }
        }

        private SqlConnection GetConnection() => new SqlConnection(_connection.SqlConnection);
    }
}
