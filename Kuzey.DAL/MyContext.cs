using Kuzey.Models.Entities;
using System.Data.Entity;

namespace Kuzey.DAL
{
    public class MyContext : DbContext
    {
        public MyContext() : base("name=MyCon")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Urun>()
                .Property(x => x.Fiyat)
                .HasPrecision(10, 4);
        }

        public virtual DbSet<Kategori> Kategoriler { get; set; }
        public virtual DbSet<Urun> Urunler { get; set; }
    }
}
