using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Otel.Models.Enums;

namespace Otel.Models.ViewModels
{
    public class RoomViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public RoomTypes RoomType { get; set; }
        public decimal Price { get; set; }
        public bool IsEmpty { get; set; } = true;
        public bool IsUseable { get; set; } = true;
        public int RoomCategoryId { get; set; }

        public override string ToString() => $"{RoomType} {Name}-{Price:c2} {(IsEmpty ? "√" : "x")}";
    }
}
