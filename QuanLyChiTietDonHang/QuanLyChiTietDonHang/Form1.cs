using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyChiTietDonHang
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void gVCTDH_DoubleClick(object sender, EventArgs e)
        {
            int maDH;
            maDH = int.Parse(gVCTDH.CurrentRow.Cells["OrderID"].Value.ToString());

            Form1 c = new Form1();

            c.maDonHang = maDH;

            c.ShowDialog();
        }
        public int maDonHang;
        private void Form1_Load(object sender, EventArgs e)
        {
            txtMaDH.Text = maDonHang.ToString();
        }
    }
}
