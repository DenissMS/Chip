#region

using System;
using System.Collections.Generic;
using System.ServiceModel;

#endregion

namespace Chip
{
    [ServiceContract]
    public interface IService
    {
        [OperationContract]
        List<Lesson> GetLessons();

        [OperationContract]
        List<Room> GetRooms();

        [OperationContract]
        List<Subject> GetSubjects();

        [OperationContract]
        List<Schedule> GetSchedules(int groupId);

        [OperationContract]
        Schedule GetSchedule(Group group, DayOfWeek day);

        [OperationContract]
        List<Teacher> GetTeachers();

        [OperationContract]
        List<Group> GetGroups();

        [OperationContract]
        void AddGroup(string name);

        [OperationContract]
        void AddTeacher(string name, string position);

        [OperationContract]
        void AddSubject(string name);

        [OperationContract]
        void AddLesson(int number, DateTime startTime, DateTime endTime);

        [OperationContract]
        void AddConcreteLesson(Lesson lesson, Subject subject, Teacher teacher, Room room);

        [OperationContract]
        void AddRoom(string number);

        [OperationContract]
        void AddSchedule(Group group, List<ConcreteLesson> lessons, DayOfWeek day);

        [OperationContract]
        void DeleteGroup(int groupId);

        [OperationContract]
        void DeleteTeacher(int teacherId);

        [OperationContract]
        void DeleteSubject(int subjectId);

        [OperationContract]
        void DeleteSchedule(int scheduleId);

        [OperationContract]
        void DeleteLesson(int lessonId);

        [OperationContract]
        void DeleteConcreteLesson(int lessonId);

        [OperationContract]
        void DeleteRoom(int roomId);
    }
}