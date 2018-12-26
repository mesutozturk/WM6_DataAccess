using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            cmbKategori.DataSource = db.Categories.OrderBy(x => x.CategoryName).ToList();
            cmbKategori.DisplayMember = "CategoryName";
            cmbKategori.ValueMember = "CategoryID";
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
            if(cmbKategori.SelectedItem== null) return;
            Category cat = cmbKategori.SelectedItem as Category;
            

            NorthwindEntities db = new NorthwindEntities();
            //lstUrunler.DataSource = db.Products
            //    .Where(x => x.CategoryID == cat.CategoryID)
            //    .OrderBy(x => x.ProductName)
            //    .ToList();
            lstUrunler.DataSource = db.Categories
                .First(x => x.CategoryID == cat.CategoryID)
                .Products.ToList();
            lstUrunler.DisplayMember = "ProductName";
        }
    }
}
