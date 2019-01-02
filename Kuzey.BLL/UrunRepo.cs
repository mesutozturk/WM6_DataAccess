using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kuzey.DAL;
using Kuzey.Models.Entities;

namespace Kuzey.BLL
{
    public class UrunRepo
    {
        public Guid UrunEkle(Urun model)
        {
            try
            {
                using (var db = new MyContext())
                {
                    db.Urunler.Add(model);
                    db.SaveChanges();
                    return model.Id;
                }
            }
            catch
            {
                throw;
            }
        }

        public List<Urun> UrunleriGetir()
        {
            try
            {
                using (var db = new MyContext())
                {
                    return db.Urunler.ToList();
                }
            }
            catch
            {
                throw;
            }
        }
    }
}
