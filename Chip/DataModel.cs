#region

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Web.Script.Serialization;

#endregion

namespace Chip
{
    [ServiceContract]
    public interface IIdentifier
    {
        int Id { get; set; }
    }
    [DataContract(IsReference = true)]
    public class Group : IIdentifier
    {
        [Key]
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Name { get; set; }
    }

    [DataContract(IsReference = true)]
    public class ConcreteLesson : IIdentifier
    {
        [Key]
        [DataMember]
        public int Id { get; set; }
        [ForeignKey("Schedule")]
        public int? ScheduleId { get; set; }
        [DataMember]
        public virtual Schedule Schedule { get; set; }
        public int? LessonId { get; set; }
        [DataMember]
        public virtual Lesson Lesson { get; set; }
        public int? SubjectId { get; set; }
        [DataMember]
        public virtual Subject Subject { get; set; }
        public int? TeacherId { get; set; }
        [DataMember]
        public virtual Teacher Teacher { get; set; }
        public int? RoomId { get; set; }
        [DataMember]
        public virtual Room Room { get; set; }
    }
    [DataContract(IsReference = true)]
    public class Lesson : IIdentifier
    {
        [Key]
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public int Number { get; set; }
        [DataMember]
        public DateTime LessonStart { get; set; }
        [DataMember]
        public DateTime LessonEnd { get; set; }
    }
    [DataContract(IsReference = true)]
    public class Room : IIdentifier
    {
        [Key]
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Number { get; set; }
    }
    [DataContract(IsReference = true)]
    public class Teacher : IIdentifier
    {
        [Key]
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Position { get; set; }
        [OperationContract]
        public override string ToString()
        {
            return Name;
        }
    }
    [DataContract(IsReference = true)]
    public class Subject : IIdentifier
    {
        [Key]
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Name { get; set; }
        [OperationContract]
        public override string ToString()
        {
            return Name;
        }
    }
    [DataContract(IsReference = true)]
    public class Schedule : IIdentifier
    {
        [Key]
        [DataMember]
        public int Id { get; set; }
        [ForeignKey("Group")]
        public int? GroupId { get; set; }
        [DataMember]
        public virtual Group Group { get; set; }
        [DataMember]
        public virtual ICollection<ConcreteLesson> Lessons { get; set; }
        [DataMember]
        public DayOfWeek Day { get; set; }
    }
}