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
    public class ProductRepository : IProductRepository
    {
        private readonly ConnectionSettings _connection;

        public ProductRepository(ConnectionSettings conn)
        {
            _connection = conn;
        }

        public async Task CreateAsync(Product product)
        {
            using (IDbConnection db = GetConnection())
            {
                var sqlQuery = SqlCommandProduct.CreateProduct;
                await db.ExecuteAsync(sqlQuery, product);
            }
        }

        public async Task<Product> GetAsync(int id)
        {
            using (IDbConnection db = GetConnection())
            {
                var sqlQuery = SqlCommandProduct.GetProduct;
                try
                {
                    var product = await db.QueryAsync<Product>(sqlQuery, new {id});

                    return product.FirstOrDefault();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }
            
            }
        }

        public async Task<IEnumerable<Product>> GetTopAsync(int count)
        {
            using (IDbConnection db = GetConnection())
            {
                return await db.QueryAsync<Product>(SqlCommandProduct.GetTopProducts, new { count });
            }
        }

        public async  Task<IEnumerable<Product>> GetAllAsync()
        {
            using (IDbConnection db = GetConnection())
            {

                var products = await db.QueryAsync<Product, Category, Product>(
                    SqlCommandProduct.GetProductWithCategory,
                    (product, category) =>
                        {
                            product.Category = category;
                            return product;
                        });
                return products;
            }
        }

        public async Task UpdateAsync(Product product)
        {
            using (IDbConnection db = GetConnection())
            {
                var sqlQuery = SqlCommandProduct.UpdateProduct;
                await db.ExecuteAsync(sqlQuery, product);
            }
        }

        public async Task DeleteAsync(int id)
        {
            using (IDbConnection db = GetConnection())
            {
                var sqlQuery = SqlCommandProduct.DeleteProduct;
                await db.ExecuteAsync(sqlQuery, new { id });
            }
        }

        private SqlConnection GetConnection() => new SqlConnection(_connection.SqlConnection);
    }
}
