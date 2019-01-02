using Kuzey.Models.Entities;
using System.Data.Entity;

namespace Kuzey.DAL
{
    public class MyContext : DbContext
    {
        public MyContext() : base("name=MyCon")
        {
        }

        public virtual DbSet<Kategori> Kategoriler { get; set; }
        public virtual DbSet<Urun> Urunler { get; set; }
    }
}
