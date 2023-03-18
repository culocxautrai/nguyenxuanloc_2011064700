namespace nguyenxuanloc_2011064700.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Web : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.courses", "LecturerId", "dbo.AspNetUsers");
            DropIndex("dbo.courses", new[] { "LecturerId" });
            AlterColumn("dbo.Categories", "Name", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.courses", "LecturerId", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.courses", "Place", c => c.String(nullable: false, maxLength: 255));
            CreateIndex("dbo.courses", "LecturerId");
            AddForeignKey("dbo.courses", "LecturerId", "dbo.AspNetUsers", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.courses", "LecturerId", "dbo.AspNetUsers");
            DropIndex("dbo.courses", new[] { "LecturerId" });
            AlterColumn("dbo.courses", "Place", c => c.String());
            AlterColumn("dbo.courses", "LecturerId", c => c.String(maxLength: 128));
            AlterColumn("dbo.Categories", "Name", c => c.String());
            CreateIndex("dbo.courses", "LecturerId");
            AddForeignKey("dbo.courses", "LecturerId", "dbo.AspNetUsers", "Id");
        }
    }
}
