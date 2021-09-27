using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSach.Model
{
    class HoaDon
    {
        [Key]
        public int HoaDonId { get; set; }
        [Display(Name = "Ngày lập hóa đơn")]
        public DateTime NgayLapHoaDon { get; set; }

        public int KhachHangId { get; set; }
        public virtual KhachHang Kh { get; set; }
    }
}
