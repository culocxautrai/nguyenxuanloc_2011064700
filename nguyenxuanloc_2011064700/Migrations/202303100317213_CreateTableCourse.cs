namespace nguyenxuanloc_2011064700.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateTableCourse : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.courses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        LecturerId = c.String(maxLength: 128),
                        Place = c.String(),
                        DateTime = c.DateTime(nullable: false),
                        CategoryId = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.CategoryId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.LecturerId)
                .Index(t => t.LecturerId)
                .Index(t => t.CategoryId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.courses", "LecturerId", "dbo.AspNetUsers");
            DropForeignKey("dbo.courses", "CategoryId", "dbo.Categories");
            DropIndex("dbo.courses", new[] { "CategoryId" });
            DropIndex("dbo.courses", new[] { "LecturerId" });
            DropTable("dbo.courses");
            DropTable("dbo.Categories");
        }
    }
}
