#region

using System.Data.Entity;
using ChipClient.ServiceReference;

#endregion

namespace Chip.DataModel
{
    public class Context : DbContext
    {
        public DbSet<Group> Groups { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Lesson> Lessons { get; set; }
        public DbSet<ConcreteLesson> ConcreteLessons { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Schedule> Schedules { get; set; }
    }
}