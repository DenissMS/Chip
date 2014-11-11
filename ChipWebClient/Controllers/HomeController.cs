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
        public PartialViewResult Schedules()
        {
            return PartialView();
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

        public void Add(string table, string[] data)
        {
            switch (table)
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
            }
        }
        public void Edit(string table, int id, string[] data)
        {
            switch (table)
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
        public void Remove(string table, int id)
        {
            switch (table)
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
            }
        }

        //public JsonResult GetProductDataJson(string selectedCategory = "All")
        //{
        //    _client.GetG
        //    return Json(data, JsonRequestBehavior.AllowGet);
        //}
    }
}