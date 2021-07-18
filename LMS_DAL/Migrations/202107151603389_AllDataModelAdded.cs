namespace LMS_DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AllDataModelAdded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(nullable: false),
                        fatherName = c.String(nullable: false),
                        dob = c.DateTime(nullable: false),
                        cnic = c.String(nullable: false),
                        email = c.String(nullable: false),
                        address = c.String(nullable: false),
                        contact = c.String(nullable: false),
                        departmentId = c.Int(nullable: false),
                        gender = c.Int(nullable: false),
                        studentImage = c.String(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Departments", t => t.departmentId, cascadeDelete: true)
                .Index(t => t.departmentId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Students", "departmentId", "dbo.Departments");
            DropIndex("dbo.Students", new[] { "departmentId" });
            DropTable("dbo.Students");
        }
    }
}
