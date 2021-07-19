namespace LMS_DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _202107191739224_FineModelAdded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Fines",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        fine = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Fines");
        }
    }
}
