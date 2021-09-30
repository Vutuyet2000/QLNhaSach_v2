using QuanLyNhaSach.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLyNhaSach.Dao
{
    class DAO_KhachHang
    {
        ApplicationDBContext db;
        public DAO_KhachHang()
        {
            db = new ApplicationDBContext();
        }


        public dynamic LayDSKH()
        {
            return db.KhachHang.Select(kh => new
            {
                kh.KhachHangId,
                kh.HoTenKH,
                kh.Sdt,
                kh.DiaChi,
            }).ToList();
        }

        public void ThemKhachHang(KhachHang kh)
        {
            db.KhachHang.Add(kh);
            db.SaveChanges();
        }

        public bool KiemTraKH(KhachHang kh)
        {
            KhachHang kH = db.KhachHang.Find(kh.KhachHangId);
            if (kh != null)
            {
                return true;
            }
            else
                return false;
        }


        public void SuaTTKhachHang(KhachHang kh)
        {
            KhachHang KH = db.KhachHang.Find(kh.KhachHangId);
            KH.HoTenKH = kh.HoTenKH;
            KH.DiaChi = kh.DiaChi;
            KH.Sdt = kh.Sdt;
            db.SaveChanges();
        }

        public void XoaKH(KhachHang kh)
        {
            KhachHang KH = db.KhachHang.Find(kh.KhachHangId);
            db.KhachHang.Remove(KH);
            db.SaveChanges();
        }


    }
}

