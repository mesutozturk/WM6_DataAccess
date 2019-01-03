using Otel.Models.Abstracts;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Otel.Models.Entities
{
    [Table("ReservationDetails")]
    public class ReservationDetail : BaseEntity2<Guid, int>
    {
        [StringLength(50)]
        [Required]
        public string FirstName { get; set; }
        [StringLength(50)]
        [Required]
        public string LastName { get; set; }
        [StringLength(11)]
        [Required]
        [RegularExpression(@"^(05)[0-9][0-9][1-9]([0-9]){6}$",ErrorMessage = "05xxxxxxxxx şeklinde tel no giriniz")]
        public string TelephoneNumber { get; set; }


        [ForeignKey("Id")]
        public virtual Reservation Reservation { get; set; }
        [ForeignKey("Id2")]
        public virtual Room Room { get; set; }
    }
}
