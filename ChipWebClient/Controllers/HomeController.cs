using System;
using System.Collections.Generic;
using System.Globalization;
using System.Web.Mvc;
using Chip;
using ChipWebClient.ServiceReference;

namespace ChipWebClient.Controllers
{
    public class HomeController : Controller
    {
        private readonly CultureInfo _culture = CultureInfo.InvariantCulture;
        readonly ServiceClient _client = new ServiceClient();
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult Schedules(int param)
        {
            return PartialView(_client.GetSchedules(param));
        }

        public PartialViewResult ManageSchedule(string[] param)
        {
            var groupId = Convert.ToInt32(param[0]);
            var day = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), param[1]);
            var tuple = new Tuple<Teacher[], Lesson[], Subject[], Room[], Schedule>
            (_client.GetTeachers(), 
            _client.GetLessons(), 
            _client.GetSubjects(),
            _client.GetRooms(), 
            _client.GetSchedule(groupId,day));
           return PartialView(tuple);
        }
        public PartialViewResult GroupSelection()
        {
            return PartialView(_client.GetGroups());
        }
        public PartialViewResult Management(string section)
        {
            ICollection<IIdentifier> data = null;
            switch (section)
            {
                case Global.LESSONS:
                    data = _client.GetLessons(); break;
                case Global.SUBJECTS:
                    data = _client.GetSubjects(); break;
                case Global.GROUPS:
                    data = _client.GetGroups(); break;
                case Global.TEACHERS:
                    data = _client.GetTeachers(); break;
            }
            return PartialView(data);
        }
        public void Add(string section, IList<string> data)
        {
            switch (section)
            {
                case Global.SCHEDULES:
                    break;
                case Global.GROUPS:
                    _client.AddGroup(data[0]);
                    break;
                case Global.TEACHERS:
                    _client.AddTeacher(data[0], data[1]);
                    break;
                case Global.SUBJECTS:
                    _client.AddSubject(data[0]);
                    break;
                case Global.LESSONS:
                    _client.AddLesson(Convert.ToInt32(data[0]),
                        DateTime.ParseExact(data[1], Global.STYLE, _culture),
                        DateTime.ParseExact(data[2], Global.STYLE, _culture));
                    break;
                case Global.MANAGE_SCHEDULE:
                    var scheduleId = Convert.ToInt32(data[0]);
                    var lessonId = Convert.ToInt32(data[1]);
                    var subjectId = Convert.ToInt32(data[2]);
                    var teacherId = Convert.ToInt32(data[3]);
                    var roomId = Convert.ToInt32(data[4]);
                    _client.AddConcreteLesson(scheduleId, lessonId, subjectId, teacherId, roomId);
                    break;
            }
        }
        public void Edit(string section, int id, IList<string> data)
        {
            switch (section)
            {
                case Global.SCHEDULES:
                    break;
                case Global.GROUPS:
                    _client.EditGroup(id, data[0]);
                    break;
                case Global.TEACHERS:
                    _client.EditTeacher(id, data[0], data[1]);
                    break;
                case Global.SUBJECTS:
                    _client.EditSubject(id, data[0]);
                    break;
                case Global.LESSONS:
                    _client.EditLesson(id, Convert.ToInt32(data[0]),
                        DateTime.ParseExact(data[1], Global.STYLE, _culture),
                        DateTime.ParseExact(data[2], Global.STYLE, _culture));
                    break;
            }
        }
        public void Remove(string section, int id)
        {
            switch (section)
            {
                case Global.SCHEDULES:
                    break;
                case Global.GROUPS:
                    _client.DeleteGroup(id);
                    break;
                case Global.TEACHERS:
                    _client.DeleteTeacher(id);
                    break;
                case Global.SUBJECTS:
                    _client.DeleteSubject(id);
                    break;
                case Global.LESSONS:
                    _client.DeleteLesson(id);
                    break;
                case Global.MANAGE_SCHEDULE:
                    _client.DeleteConcreteLesson(id);
                    break;
            }
        }

        public JsonResult GetDetailsJson(string section, int id)
        {
            IIdentifier data = null;
            switch (section)
            {
                case Global.SCHEDULES:
                    break;
                case Global.GROUPS:
                    data = _client.GetGroup(id);
                    break;
                case Global.TEACHERS:
                    data = _client.GetTeacher(id);
                    break;
                case Global.SUBJECTS:
                    data = _client.GetSubject(id);
                    break;
                case Global.LESSONS:
                    data = _client.GetLesson(id);
                    break;
            }
            return Json(data, JsonRequestBehavior.AllowGet);
        }
    }
}