using QuanLyNhaSach.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace QuanLyNhaSach
{
    class ApplicationDBContext: DbContext
    {
        public ApplicationDBContext() : base("CnStr") { }

        public DbSet<NhanVien> NhanVien { get; set; }
    }
}
