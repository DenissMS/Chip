namespace Chip.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ConcreteLessons",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SubjectId = c.Int(),
                        TeacherId = c.Int(),
                        Lesson_Id = c.Int(),
                        Room_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Lessons", t => t.Lesson_Id)
                .ForeignKey("dbo.Rooms", t => t.Room_Id)
                .ForeignKey("dbo.Subjects", t => t.SubjectId)
                .ForeignKey("dbo.Teachers", t => t.TeacherId)
                .Index(t => t.SubjectId)
                .Index(t => t.TeacherId)
                .Index(t => t.Lesson_Id)
                .Index(t => t.Room_Id);
            
            CreateTable(
                "dbo.Lessons",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Number = c.Int(nullable: false),
                        LessonStart = c.DateTime(nullable: false),
                        LessonEnd = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Rooms",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Number = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Subjects",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Teachers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Position = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Groups",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Schedules",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        GroupId = c.Int(),
                        Day = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Groups", t => t.GroupId)
                .Index(t => t.GroupId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Schedules", "GroupId", "dbo.Groups");
            DropForeignKey("dbo.ConcreteLessons", "TeacherId", "dbo.Teachers");
            DropForeignKey("dbo.ConcreteLessons", "SubjectId", "dbo.Subjects");
            DropForeignKey("dbo.ConcreteLessons", "Room_Id", "dbo.Rooms");
            DropForeignKey("dbo.ConcreteLessons", "Lesson_Id", "dbo.Lessons");
            DropIndex("dbo.Schedules", new[] { "GroupId" });
            DropIndex("dbo.ConcreteLessons", new[] { "Room_Id" });
            DropIndex("dbo.ConcreteLessons", new[] { "Lesson_Id" });
            DropIndex("dbo.ConcreteLessons", new[] { "TeacherId" });
            DropIndex("dbo.ConcreteLessons", new[] { "SubjectId" });
            DropTable("dbo.Schedules");
            DropTable("dbo.Groups");
            DropTable("dbo.Teachers");
            DropTable("dbo.Subjects");
            DropTable("dbo.Rooms");
            DropTable("dbo.Lessons");
            DropTable("dbo.ConcreteLessons");
        }
    }
}
