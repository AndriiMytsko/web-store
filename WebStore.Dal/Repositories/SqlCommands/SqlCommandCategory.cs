namespace WebStore.Dal.Repositories.SqlCommands
{
    public static class SqlCommandCategory
    {
        public static readonly string CreateCategory = "INSERT INTO Categories (Name) VALUES(@Name)";
        public static readonly string GetCategory = "SELECT * FROM Categories WHERE Id = @id";
        public static readonly string GetCategories = "SELECT * FROM Categories";
        public static readonly string UpdateCategory = "UPDATE Categories SET Name = @Name WHERE Id = @Id";
        public static readonly string DeleteCategory = "DELETE FROM Categories WHERE Id = @id";

        public static readonly string GetProductsByCategoryId = @"
            SELECT* FROM Categories c
                INNER JOIN Products p
                    ON p.CategoryId = c.Id
            WHERE c.Id = @id";
    }
}
