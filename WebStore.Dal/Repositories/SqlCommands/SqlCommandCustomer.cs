namespace WebStore.Dal.Repositories.SqlCommands
{
    public static class SqlCommandCustomer
    {
        public static readonly string CreateCustomer = @"
                                                INSERT INTO Customers (FirstName, LastName, Phone) VALUES(@FirstName, @LastName, @Phone)";
        public static readonly string GetCustomer = "SELECT * FROM Customers WHERE Id = @id";
        public static readonly string GetCustomers = "SELECT * FROM Customers";
        public static readonly string UpdateCustomer = @"
                                                UPDATE Customers 
                                                    SET 
                                                        FirstName = @FirstName,
                                                        LastName = @LastName,
                                                        Phone = @Phone
                                                WHERE Id = @Id";
        public static readonly string DeleteCustomer = "DELETE FROM Customers WHERE Id = @id";
    }
}
