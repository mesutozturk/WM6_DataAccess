using Kuzey.Models.Entities;
using System;
using Kuzey.Models.ViewModels;

namespace Kuzey.BLL.Repository
{
    public class UrunRepo : RepositoryBase<Urun, Guid>
    {
        public int SiparisEkle(SiparisViewModel model)
        {
            using (var tran = db.Database.BeginTransaction())
            {
                return 1;
            }
        }
    }

    public class KategoriRepo : RepositoryBase<Kategori, int>
    {
    }

}
