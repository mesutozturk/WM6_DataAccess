using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF_CF1.Entities
{
    [Table("Kategoriler")]
    public class Kategori
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(20, ErrorMessage = "Kategori adi 20 karakterden fazla olamaz")]
        [Index("IX_KategoriUnique", IsUnique = true)]
        public string KategoriAdi { get; set; }
        [StringLength(200)]
        public string Aciklama { get; set; }
        public DateTime EklenmeZamani { get; set; } = DateTime.Now;

        public virtual ICollection<Urun> Urunler { get; set; } = new HashSet<Urun>();
    }
}
