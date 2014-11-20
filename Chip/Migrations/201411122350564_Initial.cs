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
                        ScheduleId = c.Int(),
                        LessonId = c.Int(),
                        SubjectId = c.Int(),
                        TeacherId = c.Int(),
                        RoomId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Lessons", t => t.LessonId)
                .ForeignKey("dbo.Rooms", t => t.RoomId)
                .ForeignKey("dbo.Schedules", t => t.ScheduleId)
                .ForeignKey("dbo.Subjects", t => t.SubjectId)
                .ForeignKey("dbo.Teachers", t => t.TeacherId)
                .Index(t => t.ScheduleId)
                .Index(t => t.LessonId)
                .Index(t => t.SubjectId)
                .Index(t => t.TeacherId)
                .Index(t => t.RoomId);
            
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
            
            CreateTable(
                "dbo.Groups",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
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
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ConcreteLessons", "TeacherId", "dbo.Teachers");
            DropForeignKey("dbo.ConcreteLessons", "SubjectId", "dbo.Subjects");
            DropForeignKey("dbo.ConcreteLessons", "ScheduleId", "dbo.Schedules");
            DropForeignKey("dbo.Schedules", "GroupId", "dbo.Groups");
            DropForeignKey("dbo.ConcreteLessons", "RoomId", "dbo.Rooms");
            DropForeignKey("dbo.ConcreteLessons", "LessonId", "dbo.Lessons");
            DropIndex("dbo.Schedules", new[] { "GroupId" });
            DropIndex("dbo.ConcreteLessons", new[] { "RoomId" });
            DropIndex("dbo.ConcreteLessons", new[] { "TeacherId" });
            DropIndex("dbo.ConcreteLessons", new[] { "SubjectId" });
            DropIndex("dbo.ConcreteLessons", new[] { "LessonId" });
            DropIndex("dbo.ConcreteLessons", new[] { "ScheduleId" });
            DropTable("dbo.Teachers");
            DropTable("dbo.Subjects");
            DropTable("dbo.Groups");
            DropTable("dbo.Schedules");
            DropTable("dbo.Rooms");
            DropTable("dbo.Lessons");
            DropTable("dbo.ConcreteLessons");
        }
    }
}
