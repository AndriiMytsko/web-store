namespace WebStore.Dal.Repositories.SqlCommands
{
    public static class SqlCommandOrder
    {
        public static readonly string CreateOrder = "INSERT INTO Orders (CustomerId) VALUES(@CustomerId)";
        public static readonly string GetOrder = "SELECT * FROM Orders WHERE Id = @id";
        public static readonly string GetOrders = "SELECT * FROM Orders";
        public static readonly string UpdateOrder = "UPDATE Orders SET CustomerId = @CustomerId WHERE Id = @Id";
        public static readonly string DeleteOrder = "DELETE FROM Orders WHERE Id = @id";

        public static readonly string GetOrderWithCustomer = @"
                SELECT * FROM Orders o 
                    INNER JOIN Customers c 
                        ON o.CustomerId = c.Id";
    }
}
