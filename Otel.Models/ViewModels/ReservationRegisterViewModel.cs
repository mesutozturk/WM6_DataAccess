using System.ComponentModel.DataAnnotations;

namespace Otel.Models.ViewModels
{
    public class ReservationRegisterViewModel
    {
        [StringLength(50)]
        [Required]
        public string Firstname { get; set; }
        [StringLength(50)]
        [Required]
        public string Surname { get; set; }
        [StringLength(11)]
        [Required]
        [RegularExpression(@"^(05)[0-9][0-9][1-9]([0-9]){6}$", ErrorMessage = "05xxxxxxxxx şeklinde tel no giriniz")]
        public string Number { get; set; }
    }
}
