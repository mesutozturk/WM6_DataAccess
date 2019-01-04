using Otel.Models.Abstracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Otel.Models.Entities
{
    [Table("Products")]
    public class Product : BaseEntity<Guid>
    {
        public Product()
        {
            this.Id = Guid.NewGuid();
        }
        [StringLength(100)]
        [Required]
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
        public bool IsActive { get; set; } = true;

        [ForeignKey("CategoryId")]
        public virtual Category Category { get; set; }
        public virtual ICollection<ReservationBill> ReservationBills { get; set; } = new HashSet<ReservationBill>();
    }
}
