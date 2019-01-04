using Otel.BLL.Repository;
using Otel.Models.Entities;
using Otel.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Exception = System.Exception;

namespace Otel.WFA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKategoriKaydet_Click(object sender, EventArgs e)
        {
            if (cmbKategori.SelectedItem == null) return;
            try
            {
                var selectedCat = cmbKategori.SelectedItem as CategoryCmbViewModel;
                new CategoryRepo().Insert(new Category()
                {
                    Name = txtKategoriAdi.Text,
                    Description = txtAciklama.Text,
                    SupCategoryId = selectedCat.Id == 0 ? (int?)null : selectedCat.Id
                });
                MessageBox.Show("Kategori ekleme islemi basarili");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            GetCategories();
            GetCategoryTreeView();
        }

        private void GetCategories()
        {
            var categories = new List<CategoryCmbViewModel>
            {
                new CategoryCmbViewModel() {Id = 0, Name = "Boş"}
            };
            try
            {
                categories.AddRange(new CategoryRepo().GetAll()
                    .OrderBy(x => x.Name)
                    .Select(x => new CategoryCmbViewModel()
                    {
                        Id = x.Id,
                        Name = x.Name,
                        Description = x.Description,
                        TotalSubCategory = x.Categories.Count
                    }));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            cmbKategori.DataSource = categories;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetCategories();
            GetCategoryTreeView();
        }

        private void GetCategoryTreeView()
        {
            tvCategory.Nodes.Clear();
            var categories = new CategoryRepo().GetAll(x => x.SupCategoryId == null).OrderBy(x => x.Name).ToList();
            foreach (var category in categories)
            {
                TreeNode node = new TreeNode(category.Name)
                {
                    Tag = category.Id
                };
                tvCategory.Nodes.Add(node);
                if (category.Categories.Count > 0)
                {
                    SetSubNodes(node, category.Categories.OrderBy(x => x.Name).ToList());
                }
            }
            tvCategory.ExpandAll();
        }

        private void SetSubNodes(TreeNode node, List<Category> categories)
        {
            foreach (var category in categories)
            {
                TreeNode subNode = new TreeNode(category.Name)
                {
                    Tag = category.Id
                };
                node.Nodes.Add(subNode);
                if (category.Categories.Count > 0)
                {
                    SetSubNodes(subNode, category.Categories.OrderBy(x => x.Name).ToList());
                }
            }
        }

        private int? categoryId;
        private void tvCategory_AfterSelect(object sender, TreeViewEventArgs e)
        {
            categoryId = (int)e.Node.Tag;
            var category = new CategoryRepo().GetById(categoryId.Value);
            lstUrunler.DataSource = new ProductRepo()
                .GetAll(x => x.CategoryId == categoryId)
                .OrderBy(x => x.Name)
                .Select(x => new ProductViewModel()
                {
                    Name = x.Name,
                    Id = x.Id,
                    CategoryId = x.CategoryId,
                    IsActive = x.IsActive,
                    Price = x.Price
                })
                .ToList();
        }

        private void btnUrunKaydet_Click(object sender, EventArgs e)
        {
            if (categoryId == null)
            {
                MessageBox.Show("Luften bir kategori seciniz");
                return;
            }
            try
            {
                using (var productRepo = new ProductRepo())
                {
                    productRepo.Insert(new Product()
                    {
                        CategoryId = categoryId.Value,
                        Name = txtUrunAdi.Text,
                        Price = nFiyat.Value,
                        IsActive = cbSatistaMi.Checked
                    });
                }

                MessageBox.Show("Urun ekleme islemi basarili");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private FrmRezervasyon rezervasyonForm;
        private void btnRezervasyonlar_Click(object sender, EventArgs e)
        {
            if (rezervasyonForm == null || rezervasyonForm.IsDisposed)
            {
                rezervasyonForm = new FrmRezervasyon
                {
                    Text = "Rezervasyon Form",
                    StartPosition = FormStartPosition.CenterScreen
                };
                rezervasyonForm.Show();
            }
        }
    }
}
