using System.Windows.Forms;
using Otel.Models.ViewModels;

namespace Otel.WFA.UserControls
{
    public partial class RezervasyonKisiUserControl : UserControl
    {
        public RezervasyonKisiUserControl()
        {
            InitializeComponent();
        }

        public ReservationRegisterViewModel Model => new ReservationRegisterViewModel()
        {
            Firstname = txtAd.Text,
            Number = txtTelefon.Text,
            Surname = txtSoyad.Text
        };
    }
}
