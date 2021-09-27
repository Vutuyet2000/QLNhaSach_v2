namespace QuanLyNhaSach.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ThemDLVaoNhanVien : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO [dbo].[NhanViens]([HoTenNV],[Sdt],[DiaChi],[ChucVu],[TinhTrang]) VALUES('admin', '123', 'abc', 'ADMIN', N'Hoạt động')");
            Sql("INSERT INTO [dbo].[NhanViens]([HoTenNV],[Sdt],[DiaChi],[ChucVu],[TinhTrang]) VALUES('thukho','456','def','Thu_kho',N'Hoạt động')");
            Sql("INSERT INTO [dbo].[NhanViens]([HoTenNV],[Sdt],[DiaChi],[ChucVu],[TinhTrang]) VALUES('thungan','789','ghi','Thu_ngan',N'Hoạt động')");
        }
        
        public override void Down()
        {
        }
    }
}
