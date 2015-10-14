namespace MVCStorage.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using MVCStorage.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<MVCStorage.Models.StorageContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "MVCStorage.Models.StorageContext";
        }

        protected override void Seed(MVCStorage.Models.StorageContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            context.Items.AddOrUpdate(
                i => i.Name,
                new Item { Name = "Datormus", Brand = "Logitech", Model = "MX-100n", Count = 47, Price = 189.90m },
                new Item { Name = "Skärm", Brand = "Phillips", Model = "GX400", Count = 7, Price = 3199.90m },
                new Item { Name = "Hårddisk", Brand = "Seagate", Model = "R480", Count = 35, Price = 512.50m }
            );            
        }
    }
}
