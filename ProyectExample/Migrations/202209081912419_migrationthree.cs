namespace ProyectExample.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migrationthree : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.groups", "group_Id", "dbo.groups");
            DropIndex("dbo.groups", new[] { "group_Id" });
            DropColumn("dbo.groups", "group_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.groups", "group_Id", c => c.Int());
            CreateIndex("dbo.groups", "group_Id");
            AddForeignKey("dbo.groups", "group_Id", "dbo.groups", "Id");
        }
    }
}
