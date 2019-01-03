using Otel.Models.Entities;
using System.Data.Entity;

namespace Otel.DAL
{
    public class MyContext : DbContext
    {
        public MyContext()
            : base("name=OtelCon")
        { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Room>()
                .Property(x => x.Price)
                .HasPrecision(11, 2);
        }

        public virtual DbSet<Room> Rooms { get; set; }
        public virtual DbSet<RoomCategory> RoomCategories { get; set; }
        public virtual DbSet<Reservation> Reservations { get; set; }
        public virtual DbSet<ReservationDetail> ReservationDetails { get; set; }
    }
}
