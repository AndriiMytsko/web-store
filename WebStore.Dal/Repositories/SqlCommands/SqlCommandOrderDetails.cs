namespace WebStore.Dal.Repositories.SqlCommands
{
    public static class SqlCommandOrderDetails
    {
        public static readonly string CreateOrderDetails = @"INSERT INTO OrderDetails (
                                                    OrderID, ProductID, Quantity) 
                                                    VALUES(@OrderID, @ProductID, @Quantity)";
        public static readonly string GetOrderDetails = "SELECT * FROM OrderDetails WHERE OrderID = @Id";
        public static readonly string GetAll = "SELECT * FROM OrderDetails";
        public static readonly string UpdateOrderDetails = @"UPDATE OrderDetails 
                                                    SET OrderID = @OrderID, ProductID = @ProductID, Quantity = @Quantity 
                                                    WHERE OrderID = @OrderID";
        public static readonly string DeleteOrderDetails = "DELETE FROM OrderDetails WHERE Id = @id";


        public static readonly string GetOrderWithProductsAsync =  $@"
            SELECT *  FROM OrderDetails od
                JOIN Products p 
                    ON od.ProductId = p.Id
            WHERE od.OrderId = @id";
    }
}