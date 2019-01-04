using Otel.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Otel.BLL.Repository
{
    public class ProductRepo : RepositoryBase<Product, Guid>
    {
        public override List<Product> GetAll()
        {
            return base.GetAll().OrderBy(x => x.Name).ToList();
        }

        public override int Insert(Product entity)
        {
            try
            {
                var category = db.Categories.Find(entity.CategoryId);
                if (category == null)
                    throw new Exception("Kategori bulunamadi");
                if (category.Categories.Any())
                    throw new Exception("Ust kategorilere urun ekleyemezsiniz");
                return base.Insert(entity);
            }
            catch
            {
                throw;
            }
        }
    }
}
