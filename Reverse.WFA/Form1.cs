using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Reverse.BLL.Repository;
using Reverse.Models.Entities;

namespace Reverse.WFA
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
            cmbKategori.DataSource = new CategoryRepo().GetAll();
            cmbKategori.DisplayMember = "CategoryName";
        }

        private void btnKatKaydet_Click(object sender, EventArgs e)
        {
            new CategoryRepo().Insert(new Category()
            {
                CategoryName = txtKategoriAdi.Text,
                Description = txtAciklama.Text
            });
            KategorileriGetir();
        }
    }
}
