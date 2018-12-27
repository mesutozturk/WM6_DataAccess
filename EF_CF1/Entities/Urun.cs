using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CF1.Entities
{
    [Table("Urunler")]
    public class Urun
    {
        [Key]
        public int Id { get; set; }

        [StringLength(50)]
        [Required]
        [Index(IsUnique = true)]
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public int KategoriId { get; set; }
        [Column("Eklenme",TypeName = "smalldatetime")]
        public DateTime EklenmeZamani { get; set; } = DateTime.Now;

        [ForeignKey("KategoriId")]
        public virtual Kategori Kategori { get; set; }
    }
}
