namespace QuanLyNhaSach.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TaoBangNhanVien : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.NhanViens",
                c => new
                    {
                        NhanVienId = c.Int(nullable: false, identity: true),
                        HoTenNV = c.String(nullable: false, maxLength: 100),
                        Sdt = c.String(nullable: false, maxLength: 11),
                        DiaChi = c.String(maxLength: 255),
                        ChucVu = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.NhanVienId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.NhanViens");
        }
    }
}
