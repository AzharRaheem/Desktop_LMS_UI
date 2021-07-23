namespace LMS_DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IssuedBooksModelAdded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.IssueBooks",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        studentId = c.Int(nullable: false),
                        bookId = c.Int(nullable: false),
                        fineId = c.Int(nullable: false),
                        librarianId = c.Int(nullable: false),
                        issueDate = c.DateTime(nullable: false),
                        returnDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Books", t => t.bookId, cascadeDelete: true)
                .ForeignKey("dbo.Fines", t => t.fineId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.librarianId, cascadeDelete: true)
                .ForeignKey("dbo.Students", t => t.studentId, cascadeDelete: true)
                .Index(t => t.studentId)
                .Index(t => t.bookId)
                .Index(t => t.fineId)
                .Index(t => t.librarianId);
            
            CreateTable(
                "dbo.StudentBooks",
                c => new
                    {
                        Student_id = c.Int(nullable: false),
                        Book_id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Student_id, t.Book_id })
                .ForeignKey("dbo.Students", t => t.Student_id, cascadeDelete: true)
                .ForeignKey("dbo.Books", t => t.Book_id, cascadeDelete: true)
                .Index(t => t.Student_id)
                .Index(t => t.Book_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.IssueBooks", "studentId", "dbo.Students");
            DropForeignKey("dbo.IssueBooks", "librarianId", "dbo.Users");
            DropForeignKey("dbo.IssueBooks", "fineId", "dbo.Fines");
            DropForeignKey("dbo.IssueBooks", "bookId", "dbo.Books");
            DropForeignKey("dbo.StudentBooks", "Book_id", "dbo.Books");
            DropForeignKey("dbo.StudentBooks", "Student_id", "dbo.Students");
            DropIndex("dbo.StudentBooks", new[] { "Book_id" });
            DropIndex("dbo.StudentBooks", new[] { "Student_id" });
            DropIndex("dbo.IssueBooks", new[] { "librarianId" });
            DropIndex("dbo.IssueBooks", new[] { "fineId" });
            DropIndex("dbo.IssueBooks", new[] { "bookId" });
            DropIndex("dbo.IssueBooks", new[] { "studentId" });
            DropTable("dbo.StudentBooks");
            DropTable("dbo.IssueBooks");
        }
    }
}
