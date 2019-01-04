using Otel.Models.Abstracts;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Otel.Models.Entities
{
    [Table("ReservationBills")]
    public class ReservationBill : BaseEntity2<Guid, Guid>
    {

        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public decimal SubTotal
        {
            get => Quantity * UnitPrice;
            private set { }
        }

        [ForeignKey("Id")]
        public virtual Reservation Reservation { get; set; }
        [ForeignKey("Id2")]
        public virtual Product Product { get; set; }
    }
}
