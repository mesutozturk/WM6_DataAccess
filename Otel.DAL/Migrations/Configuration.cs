using System.Collections.Generic;
using Otel.Models.Entities;
using Otel.Models.Enums;

namespace Otel.DAL.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Otel.DAL.MyContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Otel.DAL.MyContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            var db = context;
            var categories = new List<RoomCategory>()
            {
                new RoomCategory()
                {
                    Name = "Standart"
                },
                new RoomCategory()
                {
                    Name = "Deluxe"
                },
                new RoomCategory()
                {
                    Name = "Premium"
                }
            };
            if (!db.RoomCategories.Any())
            {
                foreach (var roomCategory in categories)
                {
                    db.RoomCategories.Add(roomCategory);
                }
                db.SaveChanges();
            }

            if (!db.Rooms.Any())
            {
                var rcats = db.RoomCategories.ToList();
                for (int i = 0; i < rcats.Count; i++)
                {
                    var cat = rcats[i];
                    for (int j = 0; j < 5; j++)
                    {
                        db.Rooms.Add(new Room()
                        {
                            Name = i + 1 + "0" + (j + 1),
                            IsEmpty = true,
                            IsUseable = true,
                            Price = FakeData.NumberData.GetNumber(100, 2000),
                            RoomType = FakeData.EnumData.GetElement<RoomTypes>(),
                            RoomCategoryId = cat.Id
                        });
                    }

                    db.SaveChanges();
                }
            }
        }
    }
}
