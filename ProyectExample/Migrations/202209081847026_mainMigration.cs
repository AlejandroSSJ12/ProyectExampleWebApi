namespace ProyectExample.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mainMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.groups",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        group_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.groups", t => t.group_Id)
                .Index(t => t.group_Id);
            
            CreateTable(
                "dbo.groupStudents",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StudentId = c.Int(nullable: false),
                        GroupId = c.Int(nullable: false),
                        Action = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.groups", t => t.GroupId, cascadeDelete: true)
                .ForeignKey("dbo.students", t => t.StudentId, cascadeDelete: true)
                .Index(t => t.StudentId)
                .Index(t => t.GroupId);
            
            CreateTable(
                "dbo.students",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Age = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.groupStudents", "StudentId", "dbo.students");
            DropForeignKey("dbo.groupStudents", "GroupId", "dbo.groups");
            DropForeignKey("dbo.groups", "group_Id", "dbo.groups");
            DropIndex("dbo.groupStudents", new[] { "GroupId" });
            DropIndex("dbo.groupStudents", new[] { "StudentId" });
            DropIndex("dbo.groups", new[] { "group_Id" });
            DropTable("dbo.students");
            DropTable("dbo.groupStudents");
            DropTable("dbo.groups");
        }
    }
}
