#region

using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ChipClient.ServiceReference;

#endregion

namespace ChipClient
{
    public partial class ScheduleEditForm : Form
    {
        private readonly ServiceClient _client;
        private readonly DayOfWeek _dayOfWeek;
        private readonly Group _group;
        private readonly List<ServiceReference.ConcreteLesson> _lessons = new List<ServiceReference.ConcreteLesson>();

        public ScheduleEditForm(Group group, DayOfWeek dayOfWeek, ServiceClient client)
        {
            _client = client;
            _group = group;
            _dayOfWeek = dayOfWeek;

            InitializeComponent();
            UpdateSchedule();

            foreach (var lesson in _client.GetLessons())
            {
                cmbLesson.Items.Add(lesson);
            }
            foreach (var subject in _client.GetSubjects())
            {
                cmbSubject.Items.Add(subject);
            }
            foreach (var teacher in _client.GetTeachers())
            {
                cmbTeacher.Items.Add(teacher);
            }
            foreach (var room in _client.GetRooms())
            {
                cmbRoom.Items.Add(room);
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            _client.AddSchedule(_group.Id, _lessons.ToArray(), _dayOfWeek);
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var lesson = (Lesson) cmbLesson.SelectedItem;
            var subject = (Subject) cmbSubject.SelectedItem;
            var teacher = (Teacher) cmbTeacher.SelectedItem;
            var room = (Room) cmbRoom.SelectedItem;

            var concreteLesson = new ServiceReference.ConcreteLesson
                {
                    Subject = subject,
                    Lesson = lesson,
                    Teacher = teacher,
                    Room = room
            };

            _lessons.Add(concreteLesson);

            UpdateSchedule();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            _lessons.Remove(((ConcreteLesson) lbSchedule.SelectedItem).Lesson);
            UpdateSchedule();
        }

        public void UpdateSchedule()
        {
            lbSchedule.Items.Clear();

            foreach (var item in _lessons)
            {
                lbSchedule.Items.Add(new ConcreteLesson{Lesson = item});
            }
        }
    }
}