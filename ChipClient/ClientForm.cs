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
        private readonly ServiceClient _client = new ServiceClient();
        private DayOfWeek _selectedDay;
        private ListBox _selectedSchedule, _previousSelectedBox;
        private ListBox[] _schedules;
        public ClientForm()
        {
            InitializeComponent();

            _schedules = new[]
            {
                lbMonday,
                lbWednesday,
                lbThursday,
                lbFriday,
                lbSaturday
            };
            UpdateGroups();
            UpdateSettings();
        }

        public void UpdateSchedule()
        {
            if(lbGroups.SelectedItem == null)return;
            var group = (Group)lbGroups.SelectedItem;

            var schedules = _client.GetSchedules(group.Id);
            int i = 0;
            foreach (var schedule in schedules)
            {
                _schedules[i].Items.Clear();
                if (schedule.Lessons != null)
                {
                    foreach (var lesson in schedule.Lessons)
                    {
                        _schedules[i].Items.Add(lesson);
                    }
                }
                i++;
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
        }

        private void lbSchedule_SelectedIndexChanged(object sender, EventArgs e)
        {
            var listBox = (ListBox) sender;

            var lesson = (ConcreteLesson) listBox.SelectedItem;

            lLessonNumberValue.Text = lesson.Lesson.Number.ToString();
            lLessonStartValue.Text = lesson.Lesson.LessonStart.ToShortTimeString();
            lLessonEndValue.Text = lesson.Lesson.LessonEnd.ToShortTimeString();
            lTeacherValue.Text = string.Format("{0} ({1})",
                lesson.Teacher.Name, lesson.Teacher.Position);
            lSubjectValue.Text = lesson.Subject.Name;
            lRoomValue.Text = lesson.Room.ToString();
        }

        private void btnAddLesson_Click(object sender, EventArgs e)
        {
            const string style = "hh:mm";
            var provider = CultureInfo.InvariantCulture;
            var number = Convert.ToInt32(tbLessonNumber.Text);
            var start = DateTime.ParseExact(tbLessonStart.Text, style, provider);
            var end = DateTime.ParseExact(tbLessonEnd.Text, style, provider);

            _client.AddLesson(number, start, end);
            UpdateSettings();
        }

        private void btnRemoveLesson_Click(object sender, EventArgs e)
        {
            _client.DeleteLesson(((Lesson) lbLessons.SelectedItem).Id);
            UpdateSettings();
        }

        private void btnAddSubject_Click(object sender, EventArgs e)
        {
            _client.AddSubject(tbSubjectName.Text);
            UpdateSettings();
        }

        private void btnRemoveSubject_Click(object sender, EventArgs e)
        {
            _client.DeleteSubject(((Subject) lbSubjects.SelectedItem).Id);
            UpdateSettings();
        }

        private void btnAddTeacher_Click(object sender, EventArgs e)
        {
            _client.AddTeacher(tbTeacherName.Text, tbTeacherPosition.Text);
            UpdateSettings();
        }

        private void btnRemoveTeacher_Click(object sender, EventArgs e)
        {
            _client.DeleteTeacher(((Teacher) lbTeachers.SelectedItem).Id);
            UpdateSettings();
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            _client.AddRoom(tbRoomNumber.Text);
            UpdateSettings();
        }

        private void btnRemoveRoom_Click(object sender, EventArgs e)
        {
            _client.DeleteRoom(((Room) lbRooms.SelectedItem).Id);
            UpdateSettings();
        }

        private void btnAddSchedule_Click(object sender, EventArgs e)
        {
        }

        private void btnRemoveSchedule_Click(object sender, EventArgs e)
        {
        }

        private void btnAddSchedule_Click_1(object sender, EventArgs e)
        {
            var form = new ScheduleEditForm((Group) lbGroups.SelectedItem, _selectedDay, _client);
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
            _client.DeleteGroup(((Group) lbGroups.SelectedItem).Id);
            UpdateGroups();
        }

        private void lbSchedule_Click(object sender, EventArgs e)
        {     
            _previousSelectedBox = _selectedSchedule;
            if (_previousSelectedBox != null) _previousSelectedBox.BackColor = Color.White;
            var listBox = (ListBox) sender;
            _selectedSchedule = listBox;
            listBox.BackColor = Color.LightSkyBlue;
        }
    }
}