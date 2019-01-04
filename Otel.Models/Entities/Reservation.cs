using Otel.Models.Abstracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Otel.Models.Entities
{
    [Table("Reservations")]
    public class Reservation : BaseEntity<Guid>
    {
        public Reservation()
        {
            this.Id = Guid.NewGuid();
        }

        public DateTime ReservationDate { get; set; }
        public DateTime? CheckOutDate { get; set; }
        public int RoomId { get; set; }

        [ForeignKey("RoomId")]
        public virtual Room Room { get; set; }
        public virtual ICollection<ReservationDetail> ReservationDetails { get; set; } = new HashSet<ReservationDetail>();
        public virtual ICollection<ReservationBill> ReservationBills { get; set; } = new HashSet<ReservationBill>();
    }
}
