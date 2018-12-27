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
                    //1 bir order olsuturma
                    var order = new Order()
                    {
                        CustomerID = cart.CustomerID,
                        EmployeeID = cart.EmployeeID,
                        ShipVia = cart.ShipVia,
                        ShipAddress = cart.Address,
                        Freight = cart.Freight,
                        RequiredDate = cart.RequiredDate.Date,
                        OrderDate = cart.OrderDate
                    };
                    db.Orders.Add(order);
                    db.SaveChanges();

                    foreach (var item in cart.CartModel)
                    {
                        if (item.ProductID == 2)
                            throw new Exception("bir hata olustu");
                        db.Order_Details.Add(new Order_Detail()
                        {
                            OrderID = order.OrderID,
                            ProductID = item.ProductID,
                            UnitPrice = item.UnitPrice,
                            Quantity = item.Quantity,
                            Discount = item.Discount
                        });
                    }

                    db.SaveChanges();
                    tran.Commit();
                    return order.OrderID;
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    throw ex;
                }
            }


        }
    }
}
