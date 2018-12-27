using System.Data.Entity;
using EF_CF1.Entities;

namespace EF_CF1
{
    public class MyContext : DbContext
    {
        public MyContext():base("name=MyCon")
        {
        }
        public virtual DbSet<Kategori> Kategoriler { get; set; }
        public virtual DbSet<Urun> Urunler { get; set; }
    }
}
