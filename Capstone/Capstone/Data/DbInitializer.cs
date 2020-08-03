using Capstone.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Capstone.Data
{
    public static class DbInitializer
    {

        public static void Initialize(StoreContext context)
        {
            context.Database.EnsureCreated();
            if (!context.Item.Any())
            {
                context.Item.Add(new StoreItems() { Name = "Make Up Brushes", Price = 80.00});
                context.Item.Add(new StoreItems() { Name = "Foundation", Price = 50.00});
                context.Item.Add(new StoreItems() { Name = "Concealer", Price = 40.00});
                context.Item.Add(new StoreItems() { Name = "Primer", Price = 35.00});
                context.Item.Add(new StoreItems() { Name = "Blush", Price = 45.00});
                context.Item.Add(new StoreItems() { Name = "Bronzer", Price = 30.00});
                context.Item.Add(new StoreItems() { Name = "Eyeshadow", Price = 60.00});
                context.SaveChanges();

            }
            context.SaveChangesAsync();
        }
    }
}