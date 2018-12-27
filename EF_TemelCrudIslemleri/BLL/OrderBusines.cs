using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EF_TemelCrudIslemleri.ViewModels;

namespace EF_TemelCrudIslemleri.BLL
{
    public class OrderBusines
    {
        public int MakeOrder(CartViewModel cart)
        {
            NorthwindEntities db = new NorthwindEntities();
            using (var tran = db.Database.BeginTransaction())
            {
                try
                {

                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            

        }
    }
}
