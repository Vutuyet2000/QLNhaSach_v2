namespace QuanLyNhaSach.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTinhTrangColumn : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.NhanViens", "TinhTrang", c => c.Boolean(nullable: false, defaultValue: true));
        }
        
        public override void Down()
        {
            DropColumn("dbo.NhanViens", "TinhTrang");
        }
    }
}
