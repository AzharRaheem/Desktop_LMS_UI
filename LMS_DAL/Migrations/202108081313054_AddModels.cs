namespace LMS_DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddModels : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ReturnBooks",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        studentId = c.Int(nullable: false),
                        bookId = c.Int(nullable: false),
                        librarianId = c.Int(nullable: false),
                        returnDate = c.DateTime(nullable: false),
                        deliveryStatus = c.String(),
                        fine = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Books", t => t.bookId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.librarianId, cascadeDelete: true)
                .ForeignKey("dbo.Students", t => t.studentId, cascadeDelete: true)
                .Index(t => t.studentId)
                .Index(t => t.bookId)
                .Index(t => t.librarianId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ReturnBooks", "studentId", "dbo.Students");
            DropForeignKey("dbo.ReturnBooks", "librarianId", "dbo.Users");
            DropForeignKey("dbo.ReturnBooks", "bookId", "dbo.Books");
            DropIndex("dbo.ReturnBooks", new[] { "librarianId" });
            DropIndex("dbo.ReturnBooks", new[] { "bookId" });
            DropIndex("dbo.ReturnBooks", new[] { "studentId" });
            DropTable("dbo.ReturnBooks");
        }
    }
}
