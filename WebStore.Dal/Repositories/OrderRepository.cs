using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using WebStore.Dal.Configs;
using WebStore.Dal.Entities;
using WebStore.Dal.Repositories.Interfaces;
using WebStore.Dal.Repositories.SqlCommands;

namespace WebStore.Dal.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly ConnectionSettings _connection;

        public OrderRepository(ConnectionSettings conn)
        {
            _connection = conn;
        }

        public async Task CreateAsync(Order order)
        {
            using (IDbConnection db = GetConnection())
            {
                var sqlQuery = SqlCommandOrder.CreateOrder;
                await db.ExecuteAsync(sqlQuery, order);
            }
        }

        public async Task<Order> GetAsync(int id)
        {
            using (IDbConnection db = GetConnection())
            {
                var order = await db.QueryAsync<Order, Customer, Order>(
                    SqlCommandOrder.GetOrderWithCustomer,
                    (or, customer) =>
                    {
                        or.Customer = customer;
                        return or;
                    },
                    splitOn: "Id",
                    param: new { id });

                return order.FirstOrDefault();
            }
        }

        public async Task<IEnumerable<OrderDetails>> GetOrderWithProductsAsync(int id)
        {
            using (IDbConnection db = GetConnection())
            {
                try
                {
                    var orderDetails = await db.QueryAsync<OrderDetails, Product, OrderDetails>(
                        SqlCommandOrderDetails.GetOrderWithProductsAsync,
                        (od, product) =>
                        {
                            od.Product = product;
                            return od;
                        },
                        splitOn: "Id",
                        param: new { id });
                    return orderDetails;

                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }
            }
        }

        public async Task<IEnumerable<Order>> GetAllAsync()
        {
            using (IDbConnection db = GetConnection())
            {

                var orders = await db.QueryAsync<Order, Customer, Order>(
                    SqlCommandOrder.GetOrderWithCustomer,
                    (order, customer) =>
                    {
                        order.Customer = customer;
                        return order;
                    });
                return orders;
            }
        }

        public async Task UpdateAsync(Order order)
        {
            using (IDbConnection db = GetConnection())
            {
                var sqlQuery = SqlCommandOrder.UpdateOrder;
                await db.ExecuteAsync(sqlQuery, order);
            }
        }

        public async Task DeleteAsync(int id)
        {
            using (IDbConnection db = GetConnection())
            {
                var sqlQuery = SqlCommandOrder.DeleteOrder;
                await db.ExecuteAsync(sqlQuery, new { id });
            }
        }

        private SqlConnection GetConnection() => new SqlConnection(_connection.SqlConnection);
    }
}
