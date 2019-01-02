namespace Reverse.DAL.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Reverse.DAL.MyContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Reverse.DAL.MyContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            //var products = context.Products.ToList();
            //foreach (var product in products)
            //{
            //    if(!product.AddedDate.HasValue)
            //        product.AddedDate=new DateTime(2000,1,1);
            //}

            //context.SaveChanges();
        }
    }
}
