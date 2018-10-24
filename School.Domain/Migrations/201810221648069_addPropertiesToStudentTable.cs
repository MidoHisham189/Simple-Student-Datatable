namespace School.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addPropertiesToStudentTable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Students", "firstName", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Students", "lastName", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Students", "address", c => c.String(nullable: false, maxLength: 200));
            AlterColumn("dbo.Students", "phone", c => c.String(nullable: false, maxLength: 10));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Students", "phone", c => c.String());
            AlterColumn("dbo.Students", "address", c => c.String());
            AlterColumn("dbo.Students", "lastName", c => c.String());
            AlterColumn("dbo.Students", "firstName", c => c.String());
        }
    }
}
