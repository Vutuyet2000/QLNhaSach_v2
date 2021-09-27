using QuanLyNhaSach.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSach.DAO
{
   
    class DAO_Sach
    {
        ApplicationDBContext db;
        public DAO_Sach()
        {
            db = new ApplicationDBContext();
        }
        public dynamic LayDSNV() {
            var ds = db.nhanVien.Select(s => new
            {
                s.NhanVienId,
                s.HoTenNV
            }).ToList();

            return ds;
        }
        public void ThemSach(Sach s)
        {

            db.sach.Add(s);
            db.SaveChanges();
        }
        public dynamic LayDSSach() {
            var sach = db.sach.Select(s=> new { 
                s.SachId,
                s.TenSach,
                s.TacGia,
                s.TheLoai,
                s.Gia,
                s.SoLuongTonKho,
                s.Nv.HoTenNV
            }).ToList();
            return sach;
        }
        public void SuaSach(Sach s)
        {
            Sach sachF = db.sach.Find(s.SachId);
            sachF.TenSach = s.TenSach;
            sachF.TacGia = s.TacGia;
            sachF.TheLoai = s.TheLoai;
            sachF.Gia = s.Gia;
            sachF.SoLuongTonKho = s.SoLuongTonKho;
            sachF.NhanVienId = s.NhanVienId;
            db.SaveChanges();
        }

        public void XoaSach(Sach s)
        {
            Sach sachF = db.sach.Find(s.SachId);
            db.sach.Remove(sachF);
            db.SaveChanges();
        }
        public bool KiemTraSach(Sach s)
        {
            Sach sachF = db.sach.Find(s.SachId);
            if (s != null)
            {
                return true;
            }
            else
                return false;
        }
    }
}
