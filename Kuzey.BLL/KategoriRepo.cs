using Kuzey.DAL;
using Kuzey.Models.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Kuzey.BLL
{
    public class KategoriRepo
    {
        public int KategoriEkle(Kategori model)
        {
            using (var db = new MyContext())
            {
                try
                {
                    db.Kategoriler.Add(model);
                    db.SaveChanges();
                    return model.Id;
                }
                catch
                {
                    throw;
                }
            }
        }

        public List<Kategori> KategorileriGetir()
        {
            using (var db = new MyContext())
            {
                try
                {
                    return db.Kategoriler.ToList();
                }
                catch 
                {
                    throw;
                }
            }
        }
    }
}
