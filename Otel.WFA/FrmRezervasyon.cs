using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Otel.BLL.Repository;
using Otel.Models.Enums;
using Otel.Models.ViewModels;
using Otel.WFA.Dialogs;
using Otel.WFA.UserControls;

namespace Otel.WFA
{
    public partial class FrmRezervasyon : Form
    {
        public FrmRezervasyon()
        {
            InitializeComponent();
        }

        private void FrmRezervasyon_Load(object sender, EventArgs e)
        {
            GetRooms();
        }

        private void GetRooms()
        {
            try
            {
                lstOdalar.DataSource = new RoomRepo().GetAll()
                    .Select(x => new RoomViewModel()
                    {
                        Name = x.Name,
                        Id = x.Id,
                        Price = x.Price,
                        IsEmpty = x.IsEmpty,
                        RoomType = x.RoomType
                    })
                    .ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                ReservationRegisterDialog dialog = new ReservationRegisterDialog();
            }
        }

        private ReservationRegisterDialog registerDialog;
        private void btnRezervasyonKayit_Click(object sender, EventArgs e)
        {
            if (lstOdalar.SelectedItem == null) return;

            var selectedRoom = lstOdalar.SelectedItem as RoomViewModel;
            int kisiSayisi = Convert.ToInt32(nKisi.Value);
            try
            {
                switch (selectedRoom.RoomType)
                {
                    case RoomTypes.Single:
                        if (kisiSayisi > 1)
                            throw new Exception("Maksimum 1 kisilik rezervasyon yapabilirsiniz");
                        break;
                    case RoomTypes.Double:
                        if (kisiSayisi > 2)
                            throw new Exception("Maksimum 2 kisilik rezervasyon yapabilirsiniz");
                        break;
                    case RoomTypes.Triple:
                        if (kisiSayisi > 3)
                            throw new Exception("Maksimum 3 kisilik rezervasyon yapabilirsiniz");
                        break;
                    case RoomTypes.Suite:
                        if (kisiSayisi > 3)
                            throw new Exception("Maksimum 3 kisilik rezervasyon yapabilirsiniz");
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            registerDialog = new ReservationRegisterDialog();
            var model = GenerateRegisterDialog(registerDialog, kisiSayisi);
            if (model != null)
            {
                try
                {
                    var id = new ReservationRepo().MakeReservation(new MakeReservationViewModel()
                    {
                        CheckOutDate = dtpCikis.Value,
                        ReservationDate = dtpGiris.Value,
                        RoomId = selectedRoom.Id,
                        RegisterViewModels = model
                    });
                    MessageBox.Show($"Rezervasyonunuz basariyla olustu\n{id}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata olustu: " + ex.Message);
                }
            }
        }

        private List<ReservationRegisterViewModel> GenerateRegisterDialog(ReservationRegisterDialog dialog, int kisiSayisi)
        {
            for (int i = 0; i < kisiSayisi; i++)
            {
                var lbl = new System.Windows.Forms.Label { Text = (i + 1) + ". Kisi" };
                dialog.flpPanel.Controls.Add(lbl);
                var uc = new RezervasyonKisiUserControl();
                dialog.flpPanel.Controls.Add(uc);
            }

            var btn = new Button
            {
                Text = "Kaydet",
                Size = new Size(156, 42),
                DialogResult = DialogResult.OK
            };
            dialog.AcceptButton = btn;
            dialog.flpPanel.Controls.Add(btn);
            DialogResult cevap = dialog.ShowDialog();
            if (cevap == DialogResult.OK)
            {
                return dialog.Models;
            }

            return null;
        }


    }
}
