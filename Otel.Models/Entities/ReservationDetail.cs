using Otel.Models.Abstracts;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Otel.Models.Entities
{
    [Table("ReservationDetails")]
    public class ReservationDetail : BaseEntity<Guid>
    {
        public ReservationDetail()
        {
            this.Id=Guid.NewGuid();
        }
        [StringLength(50)]
        [Required]
        public string FirstName { get; set; }
        [StringLength(50)]
        [Required]
        public string LastName { get; set; }
        [StringLength(11)]
        [Required]
        //[RegularExpression(@"^(05)[0-9][0-9][1-9]([0-9]){6}$",ErrorMessage = "05xxxxxxxxx şeklinde tel no giriniz")]
        public string TelephoneNumber { get; set; }
        public Guid ReservationId { get; set; }

        [ForeignKey("ReservationId")]
        public virtual Reservation Reservation { get; set; }
    }
}
