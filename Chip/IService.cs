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
        void AddSchedule(int groupId, List<ConcreteLesson> lessons, DayOfWeek day);
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
        void EditGroup(int id, string name);

        [OperationContract]
        void EditTeacher(int id, string name, string position);

        [OperationContract]
        void EditSubject(int id, string name);

        [OperationContract]
        void EditLesson(int id, int number, DateTime startTime, DateTime endTime);

        [OperationContract]
        void EditRoom(int id, string number);



        

        [OperationContract]
        void DeleteGroup(int groupId);

        [OperationContract]
        void DeleteTeacher(int teacherId);

        [OperationContract]
        void DeleteSubject(int subjectId);

        [OperationContract]
        void DeleteSchedule(int groupId, DayOfWeek day);

        [OperationContract]
        void DeleteLesson(int lessonId);

        [OperationContract]
        void DeleteConcreteLesson(int lessonId);

        [OperationContract]
        void DeleteRoom(int roomId);
    }
}