using QuanLyNhaSach.Dao;
using QuanLyNhaSach.Model;
using System;
using System.Windows.Forms;

namespace QuanLyNhaSach.Bus
{
    class Bus_KhachHang
    {
        DAO_KhachHang dKH;

        public int KhachHangId { get; internal set; }
        public String HoTenKH { get; internal set; }
        public String Sdt { get; internal set; }
        public String DiaChi { get; internal set; }

        public Bus_KhachHang()
        {
            dKH = new DAO_KhachHang();
        }

        public void HienThiDSKhachHang(DataGridView dg)
        {
            dg.DataSource = dKH.LayDSKH();
        }

        public void ThemKhachHang(KhachHang kh)
        {
            try
            {
                dKH.ThemKhachHang(kh);
                MessageBox.Show("Thêm thành công!");
            }
            catch (Exception)
            {
                MessageBox.Show("Thêm thất bại!");
            }
        }

        public bool SuaTTKhachHang(KhachHang kh)
        {
            try
            {
                dKH.SuaTTKhachHang(kh);
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }

    }
}
