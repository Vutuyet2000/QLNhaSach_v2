using QuanLyNhaSach.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSach
{
    class ApplicationDBContext: DbContext
    {
        public ApplicationDBContext() : base("cnStr") { }

        public DbSet<NhanVien> NhanVien { get; set;}
        public DbSet<KhachHang> KhachHang { get; set; }
        public DbSet<HoaDon> HoaDon { get; set; }
        public DbSet<Sach> Sach { get; set; }
    }
}
