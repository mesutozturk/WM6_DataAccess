using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EF_TemelCrudIslemleri.ViewModels;

namespace EF_TemelCrudIslemleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            KategorileriGetir();
        }

        private void KategorileriGetir()
        {
            NorthwindEntities db = new NorthwindEntities();
            var kategoriler1 = db.Categories
                .OrderBy(x => x.CategoryName)
                .Select(x => new CategoryViewModel()
                {
                    CategoryID = x.CategoryID,
                    CategoryName = x.CategoryName,
                    ProductCount = x.Products.Count
                })
                .ToList();
            var kategoriler2 = db.Categories
                .OrderBy(x => x.CategoryName)
                .Select(x => new CategoryViewModel()
                {
                    CategoryID = x.CategoryID,
                    CategoryName = x.CategoryName,
                    ProductCount = x.Products.Count
                })
                .ToList();

            cmbUrunKategori.DataSource = kategoriler2;
            cmbKategori.DataSource = kategoriler1;

            //cmbKategori.DisplayMember = "CategoryName";
            //cmbKategori.ValueMember = "CategoryID";
        }

        private void btnKatKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                ep1.Clear();
                NorthwindEntities db = new NorthwindEntities();
                db.Categories.Add(new Category()
                {
                    CategoryName = string.IsNullOrEmpty(txtKategoriAdi.Text) ? null : txtKategoriAdi.Text,
                    Description = txtAciklama.Text
                });
                int sonuc = db.SaveChanges();
                MessageBox.Show($"{sonuc} kayit eklendi");
                KategorileriGetir();
            }
            catch (DbEntityValidationException ex)
            {
                foreach (var validationError in ex.EntityValidationErrors)
                {
                    foreach (var error in validationError.ValidationErrors)
                    {
                        if (error.PropertyName == "CategoryName")
                            ep1.SetError(txtKategoriAdi, error.ErrorMessage);
                    }
                }
                MessageBox.Show(EntityHelper.ValidationMessage(ex), "Bir Hata Olustu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbKategori.SelectedItem == null) return;
            CategoryViewModel cat = cmbKategori.SelectedItem as CategoryViewModel;


            NorthwindEntities db = new NorthwindEntities();
            //lstUrunler.DataSource = db.Products
            //    .Where(x => x.CategoryID == cat.CategoryID)
            //    .OrderBy(x => x.ProductName)
            //    .ToList();
            //lstUrunler.DisplayMember = "ProductName";
            var sorgu = db.Categories
                .First(x => x.CategoryID == cat.CategoryID)
                .Products
                .Select(x => new ProductViewModel()
                {
                    ProductID = x.ProductID,
                    ProductName = x.ProductName,
                    UnitPrice = x.UnitPrice
                })
                .OrderBy(x => x.ProductName)
                .ToList();
            lstUrunler.DataSource = sorgu;
            gbUrun.Visible = sorgu.Count > 0;
        }

        private void lstUrunler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstUrunler.SelectedItem == null) return;

            var seciliUrun = lstUrunler.SelectedItem as ProductViewModel;

            NorthwindEntities db = new NorthwindEntities();
            var urun = db.Products.Find(seciliUrun.ProductID);
            txtUrunAdi.Text = urun.ProductName;
            //nuFiyat.Value = urun.UnitPrice.HasValue? urun.UnitPrice.Value:0;
            nuFiyat.Value = urun.UnitPrice ?? 0;
            //nuFiyat.Value = urun.UnitPrice.GetValueOrDefault();

            var uruncatlist = cmbUrunKategori.DataSource as List<CategoryViewModel>;
            foreach (var item in uruncatlist)
            {
                if (item.CategoryID == urun.CategoryID)
                {
                    cmbUrunKategori.SelectedItem = item;
                    break;
                }
            }
        }

        private void btnUrunGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                ep1.Clear();
                NorthwindEntities db = new NorthwindEntities();
                var seciliUrun = lstUrunler.SelectedItem as ProductViewModel;
                var urun = db.Products.Find(seciliUrun.ProductID);
                urun.ProductName = txtUrunAdi.Text;
                urun.UnitPrice = nuFiyat.Value;
                urun.CategoryID = (cmbUrunKategori.SelectedItem as CategoryViewModel).CategoryID;
                int sonuc = db.SaveChanges();
                KategorileriGetir();
                MessageBox.Show($"{sonuc} urun guncellendi");
            }
            catch (DbEntityValidationException ex)
            {
                foreach (var validationError in ex.EntityValidationErrors)
                {
                    foreach (var error in validationError.ValidationErrors)
                    {
                        if (error.PropertyName == "ProductName")
                            ep1.SetError(txtUrunAdi, error.ErrorMessage);
                    }
                }
                MessageBox.Show(EntityHelper.ValidationMessage(ex), "Bir Hata Olustu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lstUrunler.SelectedItem == null) return;

            var urunId = (lstUrunler.SelectedItem as ProductViewModel).ProductID;
            var cevap = MessageBox.Show("Secili urunu silmek istiyor musunuz?", "Urun silme",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap != DialogResult.Yes) return;
            try
            {
                NorthwindEntities db = new NorthwindEntities();
                var urun = db.Products.Find(urunId);
                db.Products.Remove(urun);
                MessageBox.Show($"{db.SaveChanges()} kayit silindi");
                KategorileriGetir();
            }
            catch (DbUpdateException ex)
            {
                MessageBox.Show("Silmek istediginiz kayit baska bir tabloda kullanildigi icin silemezsiniz");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
