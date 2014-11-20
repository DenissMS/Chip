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

        public Group GetGroup(int id)
        {
            return _context.Groups.First(b => b.Id == id);
        }
        public Teacher GetTeacher(int id)
        {
            return _context.Teachers.First(b => b.Id == id);
        }
        public List<Group> GetGroups()
        {
            var resp = from b in _context.Groups select b;
            return resp.ToList();
        }
        public Lesson GetLesson(int id)
        {
            return _context.Lessons.First(b => b.Id == id);
        }
        public List<Lesson> GetLessons()
        {
            return (from b in _context.Lessons select b).ToList();
        }
        public Room GetRoom(int id)
        {
            return _context.Rooms.First(b => b.Id == id);
        }
        public List<Room> GetRooms()
        {
            return (from b in _context.Rooms select b).ToList();
        }
        public Subject GetSubject(int id)
        {
            return _context.Subjects.First(b => b.Id == id);
        }
        public List<Subject> GetSubjects()
        {
            return (from b in _context.Subjects select b).ToList();
        }
        public List<Schedule> GetSchedules(int groupId)
        {
            var list = new List<Schedule>();
            foreach (var schedule in _context.Schedules.Where(s => s.GroupId == groupId))
            {
                
                list.Add(GetFinalizedSchedule(schedule));
            }
            return list;
        }
        public Schedule GetSchedule(int groupId, DayOfWeek day)
        {
            var schedule = (from b in _context.Schedules
                            where b.GroupId == groupId && b.Day == day
                            select b).FirstOrDefault();
            if (schedule == null) return new Schedule();
            
            return GetFinalizedSchedule(schedule);
        }
        public Schedule GetFinalizedSchedule(Schedule schedule)
        {
            var lessons = _context.ConcreteLessons
                    .Where(lesson => lesson.ScheduleId == schedule.Id)
                    .ToList();
            var lessonsList = lessons.Select(lesson => new ConcreteLesson
            {
                Id = lesson.Id,
                Lesson = (from b in _context.Lessons where b.Id == lesson.LessonId select b).First(),
                Subject = (from b in _context.Subjects where b.Id == lesson.SubjectId select b).First(),
                Teacher = (from b in _context.Teachers where b.Id == lesson.TeacherId select b).First(),
                Room = (from b in _context.Rooms where b.Id == lesson.RoomId select b).First(),
            }).ToList();
            schedule.Lessons = lessonsList;
            schedule.Group = (from b in _context.Groups
                              where b.Id == schedule.GroupId
                              select b).First();
            return schedule;
        }
        public List<Teacher> GetTeachers()
        {
            return (from b in _context.Teachers select b).ToList();
        }
        public void AddSchedule(int groupId, List<ConcreteLesson> lessons, DayOfWeek day)
        {
            var schedule = new Schedule
            {
                GroupId = groupId,
                Day = day,
            };

            _context.Schedules.Add(schedule);
            _context.SaveChanges();

            foreach (var l in lessons.Select(lesson => new ConcreteLesson
            {
                LessonId = lesson.Lesson.Id,
                RoomId = lesson.Room.Id,
                ScheduleId = schedule.Id,
                SubjectId = lesson.Subject.Id,
                TeacherId = lesson.Teacher.Id,
            }))
            {
                _context.ConcreteLessons.Add(l);
            }
            _context.SaveChanges();
        }
        public void AddGroup(string name)
        {
            _context.Groups.Add(new Group { Name = name });
            _context.SaveChanges();
        }
        public void AddTeacher(string name, string position)
        {
            _context.Teachers.Add(new Teacher { Name = name, Position = position });
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

        public void AddConcreteLesson(int scheduleId, int lessonId, int subjectId, int teacherId, int roomId)
        {
            _context.ConcreteLessons.Add(new ConcreteLesson
            {
                LessonId = lessonId,
                RoomId = roomId,
                ScheduleId = scheduleId,
                SubjectId = subjectId,
                TeacherId = teacherId,
            });
            _context.SaveChanges();
        }
        //public void AddConcreteLesson(Schedule schedule, Lesson lesson, Subject subject, Teacher teacher, Room room)
        //{
        //    _context.ConcreteLessons.Add(new ConcreteLesson
        //    {
        //        Lesson = lesson,
        //        Subject = subject,
        //        Teacher = teacher,
        //        Room = room
        //    });
        //    _context.SaveChanges();
        //}
        public void AddRoom(string number)
        {
            _context.Rooms.Add(new Room
            {
                Number = number
            });
            _context.SaveChanges();
        }
        public void EditGroup(int id, string name)
        {
            var query = (from b in _context.Groups where b.Id == id select b).First();
            query.Name = name;
            _context.SaveChanges();
        }
        public void EditTeacher(int id, string name, string position)
        {
            var query = (from b in _context.Teachers where b.Id == id select b).First();
            query.Name = name;
            query.Position = position;
            _context.SaveChanges();
        }
        public void EditSubject(int id, string name)
        {
            var query = (from b in _context.Subjects where b.Id == id select b).First();
            query.Name = name;
            _context.SaveChanges();
        }
        public void EditLesson(int id, int number, DateTime startTime, DateTime endTime)
        {
            var query = (from b in _context.Lessons where b.Id == id select b).First();
            query.Number = number;
            query.LessonStart = startTime;
            query.LessonEnd = endTime;
            _context.SaveChanges();
        }
        public void EditRoom(int id, string number)
        {
            var query = (from b in _context.Rooms where b.Id == id select b).First();
            query.Number = number;
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
        public void DeleteSchedule(int groupId, DayOfWeek day)
        {
            var schedule = (from x in _context.Schedules
                            where x.GroupId == groupId && x.Day == day
                            select x).FirstOrDefault();
            if (schedule == null) return;
            var lessons = from x in _context.ConcreteLessons
                          where x.ScheduleId == schedule.Id
                          select x;
            _context.ConcreteLessons.RemoveRange(lessons);
            _context.Schedules.Remove(schedule);
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
            _context.ConcreteLessons.Remove(lesson.FirstOrDefault());
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