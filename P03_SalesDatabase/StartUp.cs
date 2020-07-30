using P03_SalesDatabase.Data;
using P03_SalesDatabase.Data.Models;
using System;

namespace P03_SalesDatabase
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var context = new SalesContext();

            GenerateDbData(context);
        }

        private static void GenerateDbData(SalesContext context)
        {
            var product = new Product
            {
                Name = "Samsung",
                Price = 323.5M,
                Quantity = 10
            };

            context.Add(product);

            var customer = new Customer
            {
                CreditCardNumber = "54546546546",
                Email = "fddfs@abv.bg",
                Name = "Ivan Ivanov"
            };

            context.Add(customer);

            var store = new Store
            {
                Name = "TP Burgas"
            };

            context.Add(store);
            context.SaveChanges();

            var sale = new Sale
            {
                CustomerId = customer.CustomerId,
                ProductId = product.ProductId,
                StoreId = store.StoreId
            };

            context.Add(sale);
            context.SaveChanges();
        }
    }
}
