using Otel.Models.Abstracts;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Otel.Models.Entities
{
    [Table("Reservations")]
    public class Reservation : BaseEntity<Guid>
    {
        public Reservation()
        {
            this.Id=Guid.NewGuid();
        }

        public DateTime ReservationDate { get; set; }
        public DateTime? CheckOutDate { get; set; }


    }
}
