using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quản_Lý_Nhân_Viên
{
    public partial class Form1 : Form
    {
        BUS_DONHANG busDH;
        public Form1()
        {
            InitializeComponent();
            busDH = new BUS_DONHANG();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            busDH.LayDSDH(dGNhanVien); // gVDHs
            busDH.LayDSKH(cbKhachHang);
            busDH.LayDSNV(cbNhanVien);
        }
    }
}
