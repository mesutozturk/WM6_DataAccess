using System;
using System.Collections.Generic;

namespace Otel.Models.ViewModels
{
    public class MakeReservationViewModel
    {
        public List<ReservationRegisterViewModel> RegisterViewModels { get; set; }
        public int RoomId { get; set; }
        public DateTime ReservationDate { get; set; }
        public DateTime? CheckOutDate { get; set; }
    }
}
