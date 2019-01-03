using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Otel.Models.Abstracts
{
    public class BaseEntity2<T1, T2> : BaseEntity<T1>
    {
        [Key]
        [Column(Order = 2)]
        public T2 Id2 { get; set; }
    }
}
