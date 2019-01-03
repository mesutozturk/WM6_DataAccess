using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reverse.Models.Entities;

namespace Reverse.BLL.Repository
{
   public class CategoryRepo : RepositoryBase<Category, int> { }
   public class CustomerRepo : RepositoryBase<Customer, string> { }
   public class EmployeeRepo : RepositoryBase<Employee, int> { }
   public class OrderRepo : RepositoryBase<Order, int> { }

    public class OrderDetailRepo : RepositoryBase<Order_Detail, int>
    {

    }
   public class ProductRepo : RepositoryBase<Product, int> { }
   public class ShipperRepo : RepositoryBase<Shipper, int> { }
   public class SupplierRepo : RepositoryBase<Supplier, int> { }
}
