
namespace WebStore.Dal.Repositories.SqlCommands
{
    public static class SqlCommandProduct
    {
        public static readonly string CreateProduct = @"
            INSERT INTO Products 
                Name
               ,Price
               ,CategoryId 
            VALUES (
                @Name
               ,@Price
               ,@CategoryId)";

        public static readonly string GetProduct = "SELECT * FROM Products WHERE Id = @id";
        public static readonly string GetProducts = "SELECT * FROM Products";
        public static readonly string UpdateProduct = @"UPDATE Products 
                                                SET Name = @Name, Price = @Price, CategoryId = @CategoryId
                                                WHERE Id = @Id";
        public static readonly string DeleteProduct = "DELETE FROM Products WHERE Id = @id";

        public static readonly string GetProductWithCategory = @"
                SELECT * FROM Products p 
                    INNER JOIN Categories c 
                        ON p.CategoryId = c.Id";

        public static readonly string GetTopProducts = @"
                                SELECT TOP(@count) Id, [Name], Price, SUM(od.Quantity) AS CountProducts
                                FROM Products p 
                                    JOIN OrderDetails od
                                        ON od.ProductId = p.Id
                                GROUP BY id,[Name], Price
                                ORDER BY CountProducts DESC";
    }
}