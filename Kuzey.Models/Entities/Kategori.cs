using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kuzey.Models.Entities
{
    [Table("Kategoriler")]
    public class Kategori
    {
        [Key]
        public int Id { get; set; }
        [StringLength(50)]
        [Required]
        public string KategoriAdi { get; set; }

        public virtual ICollection<Urun> Urunler { get; set; } = new HashSet<Urun>();
    }
}
