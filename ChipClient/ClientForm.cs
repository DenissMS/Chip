#region

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using ChipClient.ServiceReference;

#endregion

namespace ChipClient
{
    public partial class ClientForm : Form
    {
        readonly CultureInfo _provider = CultureInfo.InvariantCulture;
        private const string NA = "--";
        const string STYLE = "hh:mm";
        private readonly ServiceClient _client = new ServiceClient();
        private DayOfWeek _selectedDay;
        private ListBox _selectedSchedule, _previousSelectedBox;
        private Dictionary<DayOfWeek, ListBox> _schedules;
        public ClientForm()
        {
            InitializeComponent();

            _schedules = new Dictionary<DayOfWeek, ListBox>
            {
                {DayOfWeek.Monday, lbMonday},
                {DayOfWeek.Tuesday, lbTuesday},
                {DayOfWeek.Wednesday, lbWednesday},
                {DayOfWeek.Thursday, lbThursday},
                {DayOfWeek.Friday, lbFriday},
                {DayOfWeek.Saturday, lbSaturday}
            };
            UpdateGroups();
            UpdateSettings();
        }

        public void ClearSchedule()
        {
            foreach (var schedule in _schedules)
            {
                schedule.Value.Items.Clear();
            }
        }

        public void UpdateSchedule()
        {
            if (lbGroups.SelectedItem == null) return;
            var group = (Group)lbGroups.SelectedItem;

            var schedules = _client.GetSchedules(group.Id);
            ClearSchedule();
            foreach (DayOfWeek day in Enum.GetValues(typeof(DayOfWeek)))
            {
                var schedule = schedules.FirstOrDefault(sch => sch.Day == day);
                if (schedule != null && schedule.Lessons != null)
                {
                    foreach (var lesson in schedule.Lessons)
                    {
                        _schedules[day].Items.Add(new ConcreteLesson { Lesson = lesson });
                    }
                }
            }
        }

        public void UpdateSettings()
        {
            UpdateLessons();
            UpdateRooms();
            UpdateSubjects();
            UpdateTeachers();
        }

        public void UpdateGroups()
        {
            lbGroups.Items.Clear();
            var groups = _client.GetGroups();
            foreach (var group in groups)
            {
                lbGroups.Items.Add(group);
            }
        }

        public void UpdateTeachers()
        {
            lbTeachers.Items.Clear();
            var teachers = _client.GetTeachers();
            foreach (var teacher in teachers)
            {
                lbTeachers.Items.Add(teacher);
            }
        }

        public void UpdateRooms()
        {
            lbRooms.Items.Clear();
            var rooms = _client.GetRooms();
            foreach (var room in rooms)
            {
                lbRooms.Items.Add(room);
            }
        }

        public void UpdateSubjects()
        {
            lbSubjects.Items.Clear();
            var subjects = _client.GetSubjects();
            foreach (var subject in subjects)
            {
                lbSubjects.Items.Add(subject);
            }
        }

        public void UpdateLessons()
        {
            lbLessons.Items.Clear();
            var lessons = _client.GetLessons();
            foreach (var lesson in lessons)
            {
                lbLessons.Items.Add(lesson);
            }
        }

        private void lbGroups_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateSchedule();
            var item = lbGroups.SelectedItem;
            if (item != null)
            {
                tbGroupName.Text = ((Group)item).Name;
            }
        }

        private void lbSchedule_SelectedIndexChanged(object sender, EventArgs e)
        {
            var listBox = (ListBox)sender;
            ClearDetails();
            var lesson = (ConcreteLesson)listBox.SelectedItem;
            if (lesson != null)
            {
                lLessonNumberValue.Text = lesson.Lesson.Lesson.Number.ToString();
                lLessonStartValue.Text = lesson.Lesson.Lesson.LessonStart.ToShortTimeString();
                lLessonEndValue.Text = lesson.Lesson.Lesson.LessonEnd.ToShortTimeString();
                lTeacherValue.Text = string.Format("{1} {0}", lesson.Lesson.Teacher.Name, lesson.Lesson.Teacher.Position);
                lSubjectValue.Text = lesson.Lesson.Subject.Name;
                lRoomValue.Text = lesson.Lesson.Room.Number;
            }
        }

        public void ClearDetails()
        {
            lLessonNumberValue.Text = NA;
            lLessonStartValue.Text = NA;
            lLessonEndValue.Text = NA;
            lTeacherValue.Text = NA;
            lSubjectValue.Text = NA;
            lRoomValue.Text = NA;
        }

        private void btnAddLesson_Click(object sender, EventArgs e)
        {
            var number = Convert.ToInt32(tbLessonNumber.Text);
            var start = DateTime.ParseExact(tbLessonStart.Text, STYLE, _provider);
            var end = DateTime.ParseExact(tbLessonEnd.Text, STYLE, _provider);
            tbLessonNumber.Clear();
            tbLessonStart.Clear();
            tbLessonEnd.Clear();
            _client.AddLesson(number, start, end);
            UpdateSettings();
        }

        private void btnRemoveLesson_Click(object sender, EventArgs e)
        {
            _client.DeleteLesson(((Lesson)lbLessons.SelectedItem).Id);
            UpdateSettings();
        }

        private void btnAddSubject_Click(object sender, EventArgs e)
        {
            _client.AddSubject(tbSubjectName.Text);
            tbSubjectName.Clear();
            UpdateSettings();
        }

        private void btnRemoveSubject_Click(object sender, EventArgs e)
        {
            _client.DeleteSubject(((Subject)lbSubjects.SelectedItem).Id);
            UpdateSettings();
        }

        private void btnAddTeacher_Click(object sender, EventArgs e)
        {
            _client.AddTeacher(tbTeacherName.Text, tbTeacherPosition.Text);
            tbTeacherName.Clear();
            tbTeacherPosition.Clear();
            UpdateSettings();
        }

        private void btnRemoveTeacher_Click(object sender, EventArgs e)
        {
            _client.DeleteTeacher(((Teacher)lbTeachers.SelectedItem).Id);
            UpdateSettings();
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            _client.AddRoom(tbRoomNumber.Text);
            tbRoomNumber.Clear();
            UpdateSettings();
        }

        private void btnRemoveRoom_Click(object sender, EventArgs e)
        {
            _client.DeleteRoom(((Room)lbRooms.SelectedItem).Id);
            UpdateSettings();
        }

        private void btnAddSchedule_Click_1(object sender, EventArgs e)
        {
            var form = new ScheduleEditForm((Group)lbGroups.SelectedItem, _selectedDay, _client);
            form.Closing += ScheduleForm_Closing;
            form.Show();
        }

        private void ScheduleForm_Closing(object sender, EventArgs e)
        {
            UpdateSchedule();
        }

        private void btnAddGroup_Click(object sender, EventArgs e)
        {
            _client.AddGroup(tbGroupName.Text);
            UpdateGroups();
        }

        private void btnRemoveGroup_Click(object sender, EventArgs e)
        {
            _client.DeleteGroup(((Group)lbGroups.SelectedItem).Id);
            UpdateGroups();
        }

        private void lbSchedule_Click(object sender, EventArgs e)
        {
            _previousSelectedBox = _selectedSchedule;
            if (_previousSelectedBox != null) _previousSelectedBox.BackColor = Color.White;
            var listBox = (ListBox)sender;
            _selectedSchedule = listBox;
            switch (Convert.ToInt32(listBox.Tag))
            {
                case 1: _selectedDay = DayOfWeek.Monday;
                    break;
                case 2: _selectedDay = DayOfWeek.Tuesday;
                    break;
                case 3: _selectedDay = DayOfWeek.Wednesday;
                    break;
                case 4: _selectedDay = DayOfWeek.Thursday;
                    break;
                case 5: _selectedDay = DayOfWeek.Friday;
                    break;
                case 6: _selectedDay = DayOfWeek.Saturday;
                    break;
            }
            listBox.BackColor = Color.LightSkyBlue;
        }

        private void lbLessons_SelectedIndexChanged(object sender, EventArgs e)
        {
            var lesson = (Lesson)lbLessons.SelectedItem;
            tbLessonNumber.Text = lesson.Number.ToString(CultureInfo.InvariantCulture);
            tbLessonStart.Text = lesson.LessonStart.ToString(STYLE);
            tbLessonEnd.Text = lesson.LessonEnd.ToString(STYLE);
        }

        private void lbSubjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            var subject = (Subject)lbSubjects.SelectedItem;
            tbSubjectName.Text = subject.Name;
        }

        private void lbTeachers_SelectedIndexChanged(object sender, EventArgs e)
        {
            var teacher = (Teacher)lbTeachers.SelectedItem;
            tbTeacherName.Text = teacher.Name;
            tbTeacherPosition.Text = teacher.Position;
        }

        private void lbRooms_SelectedIndexChanged(object sender, EventArgs e)
        {
            var room = (Room)lbRooms.SelectedItem;
            tbRoomNumber.Text = room.Number;
        }

        private void btnLessonsEdit_Click(object sender, EventArgs e)
        {
            var id = ((Lesson)lbLessons.SelectedItem).Id;
            var number = Convert.ToInt32(tbLessonNumber.Text);
            var start = DateTime.ParseExact(tbLessonStart.Text, STYLE, _provider);
            var end = DateTime.ParseExact(tbLessonEnd.Text, STYLE, _provider);
            _client.EditLesson(id, number, start, end);
            UpdateSettings();
        }

        private void btnSubjectsEdit_Click(object sender, EventArgs e)
        {
            var id = ((Subject)lbSubjects.SelectedItem).Id;
            _client.EditSubject(id, tbSubjectName.Text);
            UpdateSettings();
        }

        private void btnTeachersEdit_Click(object sender, EventArgs e)
        {
            var id = ((Teacher)lbTeachers.SelectedItem).Id;
            _client.EditTeacher(id, tbTeacherName.Text, tbTeacherPosition.Text);
            UpdateSettings();
        }

        private void btnRoomsEdit_Click(object sender, EventArgs e)
        {
            var id = ((Room)lbRooms.SelectedItem).Id;
            _client.EditRoom(id, tbRoomNumber.Text);
            UpdateSettings();
        }

        private void btnGroupEdit_Click(object sender, EventArgs e)
        {
            var id = ((Group)lbGroups.SelectedItem).Id;
            _client.EditGroup(id, tbGroupName.Text);
            UpdateSettings();
        }

        private void btnRemoveSchedule_Click(object sender, EventArgs e)
        {
            var groupId = ((Group)lbGroups.SelectedItem).Id;
            _client.DeleteSchedule(groupId, _selectedDay);
            UpdateSchedule();
        }
    }
}