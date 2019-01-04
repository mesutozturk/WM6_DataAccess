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
using Otel.Models.Entities;
using Otel.Models.ViewModels;
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
            var categories = new CategoryRepo().GetAll(x => x.SupCategoryId == null).OrderBy(x=>x.Name).ToList();
            foreach (var category in categories)
            {
                tvCategory.Nodes.Add(category.Name);
                if (category.Categories.Count > 0)
                {

                }
            }
        }
    }
}
