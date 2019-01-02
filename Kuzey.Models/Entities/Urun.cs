using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kuzey.Models.Entities
{
    [Table("Urunler")]
    public class Urun
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        [StringLength(50)]
        [Required]
        public string UrunAdi { get; set; }
        public decimal Fiyat { get; set; }
        public int KategoriId { get; set; }
        public int Stok { get; set; }

        [ForeignKey("KategoriId")]
        public virtual Kategori Kategori { get; set; }
    }
}
