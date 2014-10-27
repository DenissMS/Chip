#region

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#endregion

namespace Chip
{
    
    public class Group
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
    }

    public class ConcreteLesson
    {
        [Key]
        public int Id { get; set; }

        public Lesson Lesson { get; set; }

        [ForeignKey("Subject")]
        public int? SubjectId { get; set; }

        public Subject Subject { get; set; }

        [ForeignKey("Teacher")]
        public int? TeacherId { get; set; }

        public Teacher Teacher { get; set; }
        public Room Room { get; set; }
    }

    public class Lesson
    {
        [Key]
        public int Id { get; set; }

        public int Number { get; set; }
        public DateTime LessonStart { get; set; }
        public DateTime LessonEnd { get; set; }
    }

    public class Room
    {
        [Key]
        public int Id { get; set; }

        public string Number { get; set; }
    }

    public class Teacher
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
        public string Position { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }

    public class Subject
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }

    public class Schedule
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Group")]
        public int? GroupId { get; set; }

        public Group Group { get; set; }

        [ForeignKey("Lessons")]
        public IEnumerable<ConcreteLesson> Lessons { get; set; }

        public DayOfWeek Day { get; set; }
    }
}