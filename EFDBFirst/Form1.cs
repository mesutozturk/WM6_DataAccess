using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFDBFirst
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // tum urunleri listeleyelim
            NorthwindEntities db = new NorthwindEntities();
            // product uzerinden ilerlendigi icin tum productlar gozukmeli yani left join
            var sorgu1 = db.Products
                .Select(x => new
                {
                    x.ProductName,
                    x.UnitPrice,
                    x.Category.CategoryName
                })
                .ToList();
            //burada iliski kuruldugu icin iliskideki kurala gore inner join calisir.
            var sorgu2 = from p in db.Products
                         join cat in db.Categories on p.CategoryID equals cat.CategoryID
                         select new
                         {
                             UrunAdi = p.ProductName,
                             Fiyat = p.UnitPrice,
                             Kategori = cat.CategoryName
                         };

            dgvTest.DataSource = sorgu2.ToList();

            //calisanlarimi email adresleri ile listeleyin

            var sorgu3 = db.Employees
                .Select(x => new
                {
                    x.FirstName,
                    x.LastName,
                    Email = (x.FirstName.Substring(0, 1) + x.LastName + "@northwind.com").ToLower()
                }).ToList();
            dgvTest.DataSource = sorgu3;
            var sorgu4 = from emp in db.Employees
                         select new
                         {
                             emp.FirstName,
                             emp.LastName,
                             Email = (emp.FirstName.Substring(0, 1) + emp.LastName + "@northwind.com").ToLower()
                         };

            dgvTest.DataSource = sorgu4.ToList();

            this.Text = $"{db.Products.Average(x => x.UnitPrice):c2}";

            var sorgu5 = db.Products
                .Where(x => x.UnitPrice >= db.Products.Average(y => y.UnitPrice))
                .Select(x => new
                {
                    x.ProductName,
                    Fiyat = x.UnitPrice,
                    x.Category.CategoryName
                })
                .OrderByDescending(x => x.Fiyat)
                .ToList();
            dgvTest.DataSource = sorgu5;

            var sorgu6 = from p in db.Products
                where p.UnitPrice >= db.Products.Average(x => x.UnitPrice)
                orderby p.UnitPrice descending
                select new
                {
                    p.ProductName,
                    Fiyat = p.UnitPrice,
                    p.Category.CategoryName
                };

            dgvTest.DataSource = sorgu6.ToList();
        }
    }
}
