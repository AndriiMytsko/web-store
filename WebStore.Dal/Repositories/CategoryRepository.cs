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
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ConnectionSettings _connection;

        public CategoryRepository(ConnectionSettings connection)
        {
            _connection = connection;
        }

        public async Task CreateAsync(Category category)
        {
            using (IDbConnection db = GetConnection())
            {
                var sqlQuery = SqlCommandCategory.CreateCategory;
                await db.ExecuteAsync(sqlQuery, category);
            }
        }

        public async Task<Category> GetAsync(int id)
        {
            using (IDbConnection db = GetConnection())
            {
                return await db.QueryFirstOrDefaultAsync<Category>(SqlCommandCategory.GetCategory, new { id });
            }
        }

        public async Task<IEnumerable<Product>> GetProductsByCategoryIdAsync(int id)
        {
            using (IDbConnection db = GetConnection())
            {
                return await db.QueryAsync<Product>(SqlCommandCategory.GetProductsByCategoryId, new { id });
            }
        }

        public async Task<IEnumerable<Category>> GetAllAsync()
        {
            using (IDbConnection db = GetConnection())
            {
                return await db.QueryAsync<Category>(SqlCommandCategory.GetCategories);
            }
        }

        public async Task UpdateAsync(Category category)
        {
            using (IDbConnection db = GetConnection())
            {
                var sqlQuery = SqlCommandCategory.UpdateCategory;
                await db.ExecuteAsync(sqlQuery, category);
            }
        }

        public async Task DeleteAsync(int id)
        {
            using (IDbConnection db = GetConnection())
            {
                var sqlQuery = SqlCommandCategory.DeleteCategory;
                await db.ExecuteAsync(sqlQuery, new { id });
            }
        }

        private SqlConnection GetConnection() => new SqlConnection(_connection.SqlConnection);
    }
}