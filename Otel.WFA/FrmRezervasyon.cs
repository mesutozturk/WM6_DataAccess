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
using Otel.Models.ViewModels;
using Otel.WFA.Dialogs;

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
    }
}
