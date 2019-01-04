using System.Collections.Generic;
using Otel.Models.Abstracts;
using Otel.Models.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Otel.Models.Entities
{
    [Table("Rooms")]
    public class Room : BaseEntity<int>
    {
        [StringLength(25)]
        [Required]
        public string Name { get; set; }
        public RoomTypes RoomType { get; set; }
        public decimal Price { get; set; }
        public bool IsEmpty { get; set; } = true;
        public bool IsUseable { get; set; } = true;
        public int RoomCategoryId { get; set; }


        [ForeignKey("RoomCategoryId")]
        public virtual RoomCategory RoomCategory { get; set; }
        public virtual ICollection<ReservationDetail> ReservationDetails { get; set; } = new HashSet<ReservationDetail>();

    }
}
