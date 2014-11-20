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
        Lesson GetLesson(int id);
        [OperationContract]
        List<Lesson> GetLessons();
        [OperationContract]
        Room GetRoom(int id);
        [OperationContract]
        List<Room> GetRooms();
        [OperationContract]
        Subject GetSubject(int id);

        [OperationContract]
        List<Subject> GetSubjects();

        [OperationContract]
        List<Schedule> GetSchedules(int groupId);

        [OperationContract]
        Schedule GetSchedule(int groupId, DayOfWeek day);
        [OperationContract]
        Schedule GetFinalizedSchedule(Schedule schedule);
        [OperationContract]
        Teacher GetTeacher(int id);
        [OperationContract]
        List<Teacher> GetTeachers();
        [OperationContract]
        Group GetGroup(int id);
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
        void AddConcreteLesson(int scheduleId, int lessonId, int subjectId, int teacherId, int roomId);
        //void AddConcreteLesson(Schedule schedule, Lesson lesson, Subject subject, Teacher teacher, Room room);

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