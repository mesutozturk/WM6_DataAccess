using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EF_TemelCrudIslemleri.BLL;
using EF_TemelCrudIslemleri.ViewModels;

namespace EF_TemelCrudIslemleri
{
    public partial class SiparisForm : Form
    {
        public SiparisForm()
        {
            InitializeComponent();
        }

        private List<SepetViewModel> sepet = new List<SepetViewModel>();
        private void SiparisForm_Load(object sender, EventArgs e)
        {
            VerileriGetir();
        }

        private void VerileriGetir()
        {
            NorthwindEntities db = new NorthwindEntities();
            lstUrunler.DataSource =
                db.Products
                    .OrderBy(x => x.ProductName)
                    .Select(x => new ProductViewModel()
                    {
                        ProductID = x.ProductID,
                        ProductName = x.ProductName,
                        UnitPrice = x.UnitPrice
                    }).ToList();
            cmbCalisan.DataSource = db.Employees
                .OrderBy(x => x.FirstName)
                .ThenBy(x => x.LastName)
                .Select(x => new EmployeeViewModel()
                {
                    EmployeeID = x.EmployeeID,
                    FirstName = x.FirstName,
                    LastName = x.LastName
                })
                .ToList();
            cmbMusteri.DataSource = db.Customers
                .OrderBy(x => x.CompanyName)
                .ToList();
            cmbMusteri.DisplayMember = "CompanyName";

            cmbNakliye.DataSource = db.Shippers.OrderBy(x => x.CompanyName).ToList();
            cmbNakliye.DisplayMember = "CompanyName";
        }

        private void txtAra_KeyUp(object sender, KeyEventArgs e)
        {
            string ara = txtAra.Text.ToLower();

            NorthwindEntities db = new NorthwindEntities();
            List<ProductViewModel> bulunanlar = new List<ProductViewModel>();

            db.Products
                .Where(x => x.ProductName.ToLower().Contains(ara)
                          || x.Category.CategoryName.ToLower().Contains(ara))
                .ToList()
                .ForEach(x => bulunanlar.Add(new ProductViewModel()
                {
                    ProductID = x.ProductID,
                    UnitPrice = x.UnitPrice,
                    ProductName = x.ProductName
                }));
            lstUrunler.DataSource = bulunanlar;
        }

        private void btnSepeteEkle_Click(object sender, EventArgs e)
        {
            if (lstUrunler.SelectedItem == null) return;

            var seciliUrun = lstUrunler.SelectedItem as ProductViewModel;

            bool varmi = false;
            var sepettekiVarolanUrun = new SepetViewModel();
            foreach (var sepetViewModel in sepet)
            {
                if (seciliUrun.ProductID == sepetViewModel.ProductID)
                {
                    varmi = true;
                    sepettekiVarolanUrun = sepetViewModel;
                    break;
                }
            }

            if (varmi)
            {
                sepettekiVarolanUrun.Quantity++;
            }
            else
            {
                sepet.Add(new SepetViewModel()
                {
                    ProductID = seciliUrun.ProductID,
                    Discount = 0,
                    ProductName = seciliUrun.ProductName,
                    Quantity = 1,
                    UnitPrice = seciliUrun.UnitPrice ?? 0
                });
            }

            SepetHesapla();
        }

        private void SepetHesapla()
        {
            lstSepet.Items.Clear();
            foreach (var item in sepet)
            {
                lstSepet.Items.Add(item);
            }
            var tutar = sepet.Sum(x => x.UnitPrice * x.Quantity * Convert.ToDecimal(1 - x.Discount));
            lblTutar.Text = $"Sepet Tutar: {tutar:c2}";
        }

        private void çıkartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lstSepet.SelectedItem == null) return;

            var seciliSepet1 = lstSepet.SelectedItem as SepetViewModel;

            sepet.Remove(seciliSepet1);
            SepetHesapla();
        }

        private SepetViewModel seciliSepet;
        private void güncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lstSepet.SelectedItem == null) return;

            seciliSepet = lstSepet.SelectedItem as SepetViewModel;
            pSepetGuncelle.Visible = true;
            nAdet.Value = seciliSepet.Quantity;
            nOran.Value = Convert.ToDecimal(seciliSepet.Discount);
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            foreach (var item in sepet)
            {
                if (seciliSepet.ProductID == item.ProductID)
                {
                    item.Discount = Convert.ToSingle(nOran.Value);
                    item.Quantity = Convert.ToInt16(nAdet.Value);
                    break;
                }
            }

            pSepetGuncelle.Visible = false;
            seciliSepet = null;
            SepetHesapla();
        }

        private void btnSiparisVer_Click(object sender, EventArgs e)
        {
            if (!sepet.Any())
            {
                MessageBox.Show("Lutfen sepete urun ekleyiniz");
                return;
            }

            try
            {
                var orderBusiness = new OrderBusines();
                var cartModel = new CartViewModel()
                {
                    CartModel = sepet,
                    Freight = nNakliyeUcreti.Value,
                    RequiredDate = dtpTarih.Value,
                    EmployeeID = (cmbCalisan.SelectedItem as EmployeeViewModel).EmployeeID,
                    CustomerID = (cmbMusteri.SelectedItem as Customer).CustomerID,
                    ShipVia = (cmbNakliye.SelectedItem as Shipper).ShipperID,
                    Address = txtAdres.Text
                };

                var sipNo = orderBusiness.MakeOrder(cartModel);
                MessageBox.Show($"{sipNo}'nolu Siparisiniz basariyla olusturulmustur", "Siparis", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sepet=new List<SepetViewModel>();
                SepetHesapla();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
