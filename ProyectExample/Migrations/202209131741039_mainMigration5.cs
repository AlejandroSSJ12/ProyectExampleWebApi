namespace ProyectExample.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mainMigration5 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.groupStudents", "Action");
        }
        
        public override void Down()
        {
            AddColumn("dbo.groupStudents", "Action", c => c.String());
        }
    }
}
