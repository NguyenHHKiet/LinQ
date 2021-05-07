using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quản_Lý_Nhân_Viên
{
    class BUS_DONHANG
    {
        DAO_DONHANG da;
        public BUS_DONHANG()
        {
            da = new DAO_DONHANG(); //goi doi tuong dao
        }
        public void LayDSDH( DataGridView dg)
        {
            dg.DataSource = da.LayDSDH();
        }
        public void LayDSKH(ComboBox cb)
        {
            cb.DataSource = da.LayDSKH();
            cb.DisplayMember = "CompanyName";
            cb.ValueMember = "CustomerID";
        }
        public void LayDSNV(ComboBox cb)
        {
            cb.DataSource = da.LayDSNV();
            cb.DisplayMember = "LastName";
            cb.ValueMember = "EmployeeID";
        }
    }
}
