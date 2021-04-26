using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quản_Lý_Nhân_Viên
{
    class DAO_DONHANG
    {
        NWDataContext db;
        public DAO_DONHANG()
        {
            db = new NWDataContext();   //tao ket den db
        }
        public IEnumerable<Order> LayDSDH()
        {
            var ds = from i in db.Orders select i;
            //var ds2 = db.Orders.Select(s => s);
            return ds;
        }
        public List<Order> LayDSDH2()
        {
            var ds2 = db.Orders.Select(s => s).ToList();
            return ds2;
        }
        public dynamic LayDSDH3()
        {
            dynamic ds2 = db.Orders.Select(s => new
            {
                s.OrderID,
                s.OrderDate,
                /* s.Customers.CompanyName
                 * s.Employees.LastName
                 */
                
            }).ToList();
            return ds2;
        }
        public dynamic LayDSKH()
        {
            var ds = db.Customers.Select(s => new
            {
                s.CustomerID,
                s.CompanyName
            });
            return ds;
        }
        public dynamic LayDSNV()
        {
            var ds = db.Employees.Select(s => new
            {
                s.EmployeeID,
                s.LastName
            });
            return ds;
        }
    }
}
