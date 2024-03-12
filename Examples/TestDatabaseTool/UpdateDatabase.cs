using Microsoft.Extensions.Logging;
using TestDatabase;

namespace AsyncToolBoilerTemplate.Services
{
    internal class UpdateDatabase : IUpdateDatabase
    {
        private ILogger<UpdateDatabase> Logger { get; }
        private MyDbContext MyDbContext { get; }

        public UpdateDatabase(ILogger<UpdateDatabase> logger, MyDbContext myDbContext)
        {
            Logger = logger;
            MyDbContext = myDbContext;
        }
        public async Task Synchronize()
        {
            Logger.LogWarning("Start");

            var random = new Random();

            // Generate random products first and save them to the database
            var products = Enumerable.Range(1, 10).Select(index => new Product
            {
                Name = $"Product{index}",
                Price = (decimal)(random.NextDouble() * 100),
                IsActive = random.Next(2) == 0
            }).ToList();

            MyDbContext.Products.AddRange(products);
            MyDbContext.SaveChanges(); // Persist the products first

            // Generate random customers with orders
            var customers = Enumerable.Range(1, 10).Select(index =>
            {
                var customer = new Customer
                {
                    Name = $"Customer{index}",
                    Email = $"customer{index}@example.com",
                    CreatedAt = DateTimeOffset.UtcNow.AddDays(-random.Next(365)),
                    Photo = new byte[random.Next(256, 1024)],   // random size for Photo (in range of 256 to 1024 bytes)
                    Orders = new List<Order>()
                };

                random.NextBytes(customer.Photo); // generating random bytes for Photo

                // Generate random orders for the customer
                for (var j = 0; j < random.Next(1, 5); j++)  // Random number of orders for each customer
                {
                    var order = new Order
                    {
                        OrderDate = DateTime.UtcNow.AddDays(-random.Next(0, 30)), // orders from the last 30 days
                        ProductId = products[random.Next(products.Count)].Id, // random product
                        Total = (decimal)(random.NextDouble() * 100)  // random total price
                    };

                    customer.Orders.Add(order);
                }

                return customer;
            }).ToList();

            // Now add customers with orders referencing the already-saved products
            MyDbContext.Customers.AddRange(customers);

            // All random data prepared, save it to the database
            MyDbContext.SaveChanges();

            await Task.CompletedTask;

            Logger.LogWarning("End");
        }
    }
}
