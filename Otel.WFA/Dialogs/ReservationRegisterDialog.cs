using Otel.Models.ViewModels;
using System.Collections.Generic;
using System.Windows.Forms;
using Otel.WFA.UserControls;

namespace Otel.WFA.Dialogs
{
    public partial class ReservationRegisterDialog : Form
    {
        public ReservationRegisterDialog()
        {
            InitializeComponent();
            Models = new List<ReservationRegisterViewModel>();
        }

        public int Count { get; set; }
        public List<ReservationRegisterViewModel> Models { get; set; }

        private void ReservationRegisterDialog_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (Control control in this.flpPanel.Controls)
            {
                if (control is RezervasyonKisiUserControl rez)
                    Models.Add(rez.Model);
            }
        }
    }
}
