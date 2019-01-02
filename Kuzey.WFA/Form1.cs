using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kuzey.BLL;
using Kuzey.BLL.Repository;
using Kuzey.Models.Entities;

namespace Kuzey.WFA
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
            var db = new KategoriRepo();
            List<Kategori> kategoriler = db.GetAll();
            listBox1.DataSource = kategoriler;
            listBox1.DisplayMember = "KategoriAdi";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var kategoriRepo = new KategoriRepo();
            kategoriRepo.Insert(new Kategori()
            {
                KategoriAdi = "asdasd",
            });
            KategorileriGetir();

            new UrunRepo()
                .Insert(new Urun()
                {
                    Fiyat = 3,
                    UrunAdi = "alfmakmf",
                    KategoriId = kategoriRepo.GetAll().First().Id
                });
            var urulerim = new UrunRepo()
                .GetQueryList(x => x.UrunAdi.StartsWith("a")&&x.Kategori.KategoriAdi.StartsWith("a"));
        }
    }
}
