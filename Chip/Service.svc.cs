#region

using System;
using System.Collections.Generic;
using System.Linq;

#endregion

namespace Chip
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service : IService
    {
        private readonly Context _context = new Context();

        public List<Group> GetGroups()
        {
            var resp = from b in _context.Groups select b;
            return resp.ToList();
        }

        public List<Lesson> GetLessons()
        {
            return (from b in _context.Lessons select b).ToList();
        }

        public List<Room> GetRooms()
        {
            return (from b in _context.Rooms select b).ToList();
        }

        public List<Subject> GetSubjects()
        {
            return (from b in _context.Subjects select b).ToList();
        }

        public List<Schedule> GetSchedules(int groupId)
        {
            return (from b in _context.Schedules
                where b.Id == groupId
                select b).ToList();
        }

        public Schedule GetSchedule(Group gr, DayOfWeek day)
        {
            return (from b in _context.Schedules
                where b.Group == gr && b.Day == day
                select b).FirstOrDefault();
        }

        public List<Teacher> GetTeachers()
        {
            return (from b in _context.Teachers select b).ToList();
        }

        public void AddGroup(string name)
        {
            using (var context = new Context())
            {
                context.Groups.Add(new Group {Id = 1, Name = name});
                context.SaveChanges();
            }
        }

        public void AddTeacher(string name, string position)
        {
            _context.Teachers.Add(new Teacher {Name = name, Position = position});
            _context.SaveChanges();
        }

        public void AddSubject(string name)
        {
            _context.Subjects.Add(new Subject
            {
                Name = name,
            });
            _context.SaveChanges();
        }

        public void AddLesson(int number, DateTime startTime, DateTime endTime)
        {
            _context.Lessons.Add(new Lesson
            {
                Number = number,
                LessonStart = startTime,
                LessonEnd = endTime
            });
            _context.SaveChanges();
        }

        public void AddConcreteLesson(Lesson lesson, Subject subject, Teacher teacher, Room room)
        {
            _context.ConcreteLessons.Add(new ConcreteLesson
            {
                Lesson = lesson,
                Subject = subject,
                Teacher = teacher,
                Room = room
            });
            _context.SaveChanges();
        }

        public void AddRoom(string number)
        {
            _context.Rooms.Add(new Room
            {
                Number = number
            });
            _context.SaveChanges();
        }

        public void AddSchedule(Group group, List<ConcreteLesson> lessons, DayOfWeek day)
        {
            _context.Schedules.Add(new Schedule
            {
                Group = group,
                Lessons = lessons,
                Day = day,
            });
            _context.SaveChanges();
        }

        public void DeleteGroup(int groupId)
        {
            var group = from x in _context.Groups where x.Id == groupId select x;
            _context.Groups.Remove(group.First());
            _context.SaveChanges();
        }

        public void DeleteTeacher(int teacherId)
        {
            var teacher = from x in _context.Teachers where x.Id == teacherId select x;
            _context.Teachers.Remove(teacher.First());
            _context.SaveChanges();
        }

        public void DeleteSubject(int subjectId)
        {
            var subject = from x in _context.Subjects where x.Id == subjectId select x;
            _context.Subjects.Remove(subject.First());
            _context.SaveChanges();
        }

        public void DeleteSchedule(int scheduleId)
        {
            var schedule = from x in _context.Schedules where x.Id == scheduleId select x;
            _context.Schedules.Remove(schedule.First());
            _context.SaveChanges();
        }

        public void DeleteLesson(int lessonId)
        {
            var lesson = from x in _context.Lessons where x.Id == lessonId select x;
            _context.Lessons.Remove(lesson.First());
            _context.SaveChanges();
        }

        public void DeleteConcreteLesson(int lessonId)
        {
            var lesson = from x in _context.ConcreteLessons where x.Id == lessonId select x;
            _context.ConcreteLessons.Remove(lesson.First());
            _context.SaveChanges();
        }

        public void DeleteRoom(int roomId)
        {
            var room = from x in _context.Rooms where x.Id == roomId select x;
            _context.Rooms.Remove(room.First());
            _context.SaveChanges();
        }
    }
}