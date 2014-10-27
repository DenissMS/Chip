namespace ChipClient
{
    partial class ClientForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbGroups = new System.Windows.Forms.ListBox();
            this.lbMonday = new System.Windows.Forms.ListBox();
            this.lbThursday = new System.Windows.Forms.ListBox();
            this.gbDetails = new System.Windows.Forms.GroupBox();
            this.lRoomValue = new System.Windows.Forms.Label();
            this.lRoom = new System.Windows.Forms.Label();
            this.lSubjectValue = new System.Windows.Forms.Label();
            this.lSubject = new System.Windows.Forms.Label();
            this.lTeacherValue = new System.Windows.Forms.Label();
            this.lLessonEndValue = new System.Windows.Forms.Label();
            this.lLessonStartValue = new System.Windows.Forms.Label();
            this.lLessonNumberValue = new System.Windows.Forms.Label();
            this.lTeacher = new System.Windows.Forms.Label();
            this.lLessonEnd = new System.Windows.Forms.Label();
            this.lLessonStart = new System.Windows.Forms.Label();
            this.lLessonNumber = new System.Windows.Forms.Label();
            this.tcSchedule = new System.Windows.Forms.TabControl();
            this.tpSchedule = new System.Windows.Forms.TabPage();
            this.btnRemoveGroup = new System.Windows.Forms.Button();
            this.btnAddGroup = new System.Windows.Forms.Button();
            this.tbGroupName = new System.Windows.Forms.TextBox();
            this.btnRemoveSchedule = new System.Windows.Forms.Button();
            this.btnAddSchedule = new System.Windows.Forms.Button();
            this.lbSaturday = new System.Windows.Forms.ListBox();
            this.Tuesday = new System.Windows.Forms.ListBox();
            this.lbFriday = new System.Windows.Forms.ListBox();
            this.lbWednesday = new System.Windows.Forms.ListBox();
            this.tpSettings = new System.Windows.Forms.TabPage();
            this.tbTeacherPosition = new System.Windows.Forms.TextBox();
            this.tbLessonEnd = new System.Windows.Forms.TextBox();
            this.tbLessonStart = new System.Windows.Forms.TextBox();
            this.tbRoomNumber = new System.Windows.Forms.TextBox();
            this.tbTeacherName = new System.Windows.Forms.TextBox();
            this.tbSubjectName = new System.Windows.Forms.TextBox();
            this.tbLessonNumber = new System.Windows.Forms.TextBox();
            this.btnRemoveRoom = new System.Windows.Forms.Button();
            this.btnAddRoom = new System.Windows.Forms.Button();
            this.btnRemoveTeacher = new System.Windows.Forms.Button();
            this.btnAddTeacher = new System.Windows.Forms.Button();
            this.btnRemoveSubject = new System.Windows.Forms.Button();
            this.btnAddSubject = new System.Windows.Forms.Button();
            this.btnRemoveLesson = new System.Windows.Forms.Button();
            this.btnAddLesson = new System.Windows.Forms.Button();
            this.cmbDays = new System.Windows.Forms.ComboBox();
            this.cmbRooms = new System.Windows.Forms.ComboBox();
            this.cmbTeachers = new System.Windows.Forms.ComboBox();
            this.cmbSubjects = new System.Windows.Forms.ComboBox();
            this.cmbLessons = new System.Windows.Forms.ComboBox();
            this.lbSchedules = new System.Windows.Forms.ListBox();
            this.lbRooms = new System.Windows.Forms.ListBox();
            this.lbTeachers = new System.Windows.Forms.ListBox();
            this.lbSubjects = new System.Windows.Forms.ListBox();
            this.lbLessons = new System.Windows.Forms.ListBox();
            this.gbDetails.SuspendLayout();
            this.tcSchedule.SuspendLayout();
            this.tpSchedule.SuspendLayout();
            this.tpSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbGroups
            // 
            this.lbGroups.DisplayMember = "Group.Name";
            this.lbGroups.FormattingEnabled = true;
            this.lbGroups.Location = new System.Drawing.Point(6, 6);
            this.lbGroups.Name = "lbGroups";
            this.lbGroups.Size = new System.Drawing.Size(120, 329);
            this.lbGroups.TabIndex = 1;
            this.lbGroups.SelectedIndexChanged += new System.EventHandler(this.lbGroups_SelectedIndexChanged);
            // 
            // lbMonday
            // 
            this.lbMonday.BackColor = System.Drawing.SystemColors.Window;
            this.lbMonday.DisplayMember = "ConcreteLesson.Subject";
            this.lbMonday.FormattingEnabled = true;
            this.lbMonday.Location = new System.Drawing.Point(133, 7);
            this.lbMonday.Name = "lbMonday";
            this.lbMonday.Size = new System.Drawing.Size(162, 121);
            this.lbMonday.TabIndex = 2;
            this.lbMonday.Click += new System.EventHandler(this.lbSchedule_Click);
            this.lbMonday.SelectedIndexChanged += new System.EventHandler(this.lbSchedule_SelectedIndexChanged);
            // 
            // lbThursday
            // 
            this.lbThursday.DisplayMember = "ConcreteLesson.Subject";
            this.lbThursday.FormattingEnabled = true;
            this.lbThursday.Location = new System.Drawing.Point(133, 134);
            this.lbThursday.Name = "lbThursday";
            this.lbThursday.Size = new System.Drawing.Size(162, 121);
            this.lbThursday.TabIndex = 5;
            this.lbThursday.Click += new System.EventHandler(this.lbSchedule_Click);
            this.lbThursday.SelectedIndexChanged += new System.EventHandler(this.lbSchedule_SelectedIndexChanged);
            // 
            // gbDetails
            // 
            this.gbDetails.Controls.Add(this.lRoomValue);
            this.gbDetails.Controls.Add(this.lRoom);
            this.gbDetails.Controls.Add(this.lSubjectValue);
            this.gbDetails.Controls.Add(this.lSubject);
            this.gbDetails.Controls.Add(this.lTeacherValue);
            this.gbDetails.Controls.Add(this.lLessonEndValue);
            this.gbDetails.Controls.Add(this.lLessonStartValue);
            this.gbDetails.Controls.Add(this.lLessonNumberValue);
            this.gbDetails.Controls.Add(this.lTeacher);
            this.gbDetails.Controls.Add(this.lLessonEnd);
            this.gbDetails.Controls.Add(this.lLessonStart);
            this.gbDetails.Controls.Add(this.lLessonNumber);
            this.gbDetails.Location = new System.Drawing.Point(133, 262);
            this.gbDetails.Name = "gbDetails";
            this.gbDetails.Size = new System.Drawing.Size(411, 164);
            this.gbDetails.TabIndex = 8;
            this.gbDetails.TabStop = false;
            this.gbDetails.Text = "Details";
            // 
            // lRoomValue
            // 
            this.lRoomValue.AutoSize = true;
            this.lRoomValue.Location = new System.Drawing.Point(254, 70);
            this.lRoomValue.Name = "lRoomValue";
            this.lRoomValue.Size = new System.Drawing.Size(13, 13);
            this.lRoomValue.TabIndex = 13;
            this.lRoomValue.Text = "--";
            // 
            // lRoom
            // 
            this.lRoom.AutoSize = true;
            this.lRoom.Location = new System.Drawing.Point(165, 70);
            this.lRoom.Name = "lRoom";
            this.lRoom.Size = new System.Drawing.Size(38, 13);
            this.lRoom.TabIndex = 12;
            this.lRoom.Text = "Room:";
            // 
            // lSubjectValue
            // 
            this.lSubjectValue.AutoSize = true;
            this.lSubjectValue.Location = new System.Drawing.Point(254, 47);
            this.lSubjectValue.Name = "lSubjectValue";
            this.lSubjectValue.Size = new System.Drawing.Size(13, 13);
            this.lSubjectValue.TabIndex = 11;
            this.lSubjectValue.Text = "--";
            // 
            // lSubject
            // 
            this.lSubject.AutoSize = true;
            this.lSubject.Location = new System.Drawing.Point(165, 47);
            this.lSubject.Name = "lSubject";
            this.lSubject.Size = new System.Drawing.Size(46, 13);
            this.lSubject.TabIndex = 10;
            this.lSubject.Text = "Subject:";
            // 
            // lTeacherValue
            // 
            this.lTeacherValue.AutoSize = true;
            this.lTeacherValue.Location = new System.Drawing.Point(254, 25);
            this.lTeacherValue.Name = "lTeacherValue";
            this.lTeacherValue.Size = new System.Drawing.Size(13, 13);
            this.lTeacherValue.TabIndex = 9;
            this.lTeacherValue.Text = "--";
            // 
            // lLessonEndValue
            // 
            this.lLessonEndValue.AutoSize = true;
            this.lLessonEndValue.Location = new System.Drawing.Point(106, 70);
            this.lLessonEndValue.Name = "lLessonEndValue";
            this.lLessonEndValue.Size = new System.Drawing.Size(13, 13);
            this.lLessonEndValue.TabIndex = 8;
            this.lLessonEndValue.Text = "--";
            // 
            // lLessonStartValue
            // 
            this.lLessonStartValue.AutoSize = true;
            this.lLessonStartValue.Location = new System.Drawing.Point(106, 48);
            this.lLessonStartValue.Name = "lLessonStartValue";
            this.lLessonStartValue.Size = new System.Drawing.Size(13, 13);
            this.lLessonStartValue.TabIndex = 7;
            this.lLessonStartValue.Text = "--";
            // 
            // lLessonNumberValue
            // 
            this.lLessonNumberValue.AutoSize = true;
            this.lLessonNumberValue.Location = new System.Drawing.Point(106, 25);
            this.lLessonNumberValue.Name = "lLessonNumberValue";
            this.lLessonNumberValue.Size = new System.Drawing.Size(13, 13);
            this.lLessonNumberValue.TabIndex = 6;
            this.lLessonNumberValue.Text = "--";
            // 
            // lTeacher
            // 
            this.lTeacher.AutoSize = true;
            this.lTeacher.Location = new System.Drawing.Point(165, 25);
            this.lTeacher.Name = "lTeacher";
            this.lTeacher.Size = new System.Drawing.Size(50, 13);
            this.lTeacher.TabIndex = 4;
            this.lTeacher.Text = "Teacher:";
            // 
            // lLessonEnd
            // 
            this.lLessonEnd.AutoSize = true;
            this.lLessonEnd.Location = new System.Drawing.Point(6, 70);
            this.lLessonEnd.Name = "lLessonEnd";
            this.lLessonEnd.Size = new System.Drawing.Size(34, 13);
            this.lLessonEnd.TabIndex = 3;
            this.lLessonEnd.Text = "Ends:";
            // 
            // lLessonStart
            // 
            this.lLessonStart.AutoSize = true;
            this.lLessonStart.Location = new System.Drawing.Point(6, 48);
            this.lLessonStart.Name = "lLessonStart";
            this.lLessonStart.Size = new System.Drawing.Size(37, 13);
            this.lLessonStart.TabIndex = 2;
            this.lLessonStart.Text = "Starts:";
            // 
            // lLessonNumber
            // 
            this.lLessonNumber.AutoSize = true;
            this.lLessonNumber.Location = new System.Drawing.Point(6, 25);
            this.lLessonNumber.Name = "lLessonNumber";
            this.lLessonNumber.Size = new System.Drawing.Size(44, 13);
            this.lLessonNumber.TabIndex = 1;
            this.lLessonNumber.Text = "Lesson:";
            // 
            // tcSchedule
            // 
            this.tcSchedule.Controls.Add(this.tpSchedule);
            this.tcSchedule.Controls.Add(this.tpSettings);
            this.tcSchedule.Location = new System.Drawing.Point(12, 12);
            this.tcSchedule.Name = "tcSchedule";
            this.tcSchedule.SelectedIndex = 0;
            this.tcSchedule.Size = new System.Drawing.Size(646, 463);
            this.tcSchedule.TabIndex = 9;
            // 
            // tpSchedule
            // 
            this.tpSchedule.Controls.Add(this.btnRemoveGroup);
            this.tpSchedule.Controls.Add(this.btnAddGroup);
            this.tpSchedule.Controls.Add(this.tbGroupName);
            this.tpSchedule.Controls.Add(this.btnRemoveSchedule);
            this.tpSchedule.Controls.Add(this.btnAddSchedule);
            this.tpSchedule.Controls.Add(this.lbGroups);
            this.tpSchedule.Controls.Add(this.gbDetails);
            this.tpSchedule.Controls.Add(this.lbMonday);
            this.tpSchedule.Controls.Add(this.lbSaturday);
            this.tpSchedule.Controls.Add(this.Tuesday);
            this.tpSchedule.Controls.Add(this.lbFriday);
            this.tpSchedule.Controls.Add(this.lbWednesday);
            this.tpSchedule.Controls.Add(this.lbThursday);
            this.tpSchedule.Location = new System.Drawing.Point(4, 22);
            this.tpSchedule.Name = "tpSchedule";
            this.tpSchedule.Padding = new System.Windows.Forms.Padding(3);
            this.tpSchedule.Size = new System.Drawing.Size(638, 437);
            this.tpSchedule.TabIndex = 0;
            this.tpSchedule.Text = "Schedule";
            this.tpSchedule.UseVisualStyleBackColor = true;
            // 
            // btnRemoveGroup
            // 
            this.btnRemoveGroup.Location = new System.Drawing.Point(7, 397);
            this.btnRemoveGroup.Name = "btnRemoveGroup";
            this.btnRemoveGroup.Size = new System.Drawing.Size(119, 23);
            this.btnRemoveGroup.TabIndex = 24;
            this.btnRemoveGroup.Text = "Remove";
            this.btnRemoveGroup.UseVisualStyleBackColor = true;
            this.btnRemoveGroup.Click += new System.EventHandler(this.btnRemoveGroup_Click);
            // 
            // btnAddGroup
            // 
            this.btnAddGroup.Location = new System.Drawing.Point(7, 368);
            this.btnAddGroup.Name = "btnAddGroup";
            this.btnAddGroup.Size = new System.Drawing.Size(119, 23);
            this.btnAddGroup.TabIndex = 23;
            this.btnAddGroup.Text = "Add";
            this.btnAddGroup.UseVisualStyleBackColor = true;
            this.btnAddGroup.Click += new System.EventHandler(this.btnAddGroup_Click);
            // 
            // tbGroupName
            // 
            this.tbGroupName.Location = new System.Drawing.Point(7, 342);
            this.tbGroupName.Name = "tbGroupName";
            this.tbGroupName.Size = new System.Drawing.Size(119, 20);
            this.tbGroupName.TabIndex = 22;
            // 
            // btnRemoveSchedule
            // 
            this.btnRemoveSchedule.Location = new System.Drawing.Point(550, 403);
            this.btnRemoveSchedule.Name = "btnRemoveSchedule";
            this.btnRemoveSchedule.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveSchedule.TabIndex = 21;
            this.btnRemoveSchedule.Text = "Remove";
            this.btnRemoveSchedule.UseVisualStyleBackColor = true;
            // 
            // btnAddSchedule
            // 
            this.btnAddSchedule.Location = new System.Drawing.Point(550, 374);
            this.btnAddSchedule.Name = "btnAddSchedule";
            this.btnAddSchedule.Size = new System.Drawing.Size(75, 23);
            this.btnAddSchedule.TabIndex = 20;
            this.btnAddSchedule.Text = "Add";
            this.btnAddSchedule.UseVisualStyleBackColor = true;
            this.btnAddSchedule.Click += new System.EventHandler(this.btnAddSchedule_Click_1);
            // 
            // lbSaturday
            // 
            this.lbSaturday.DisplayMember = "ConcreteLesson.Subject";
            this.lbSaturday.FormattingEnabled = true;
            this.lbSaturday.Location = new System.Drawing.Point(469, 134);
            this.lbSaturday.Name = "lbSaturday";
            this.lbSaturday.Size = new System.Drawing.Size(162, 121);
            this.lbSaturday.TabIndex = 7;
            this.lbSaturday.Click += new System.EventHandler(this.lbSchedule_Click);
            this.lbSaturday.SelectedIndexChanged += new System.EventHandler(this.lbSchedule_SelectedIndexChanged);
            // 
            // Tuesday
            // 
            this.Tuesday.DisplayMember = "ConcreteLesson.Subject";
            this.Tuesday.FormattingEnabled = true;
            this.Tuesday.Location = new System.Drawing.Point(301, 7);
            this.Tuesday.Name = "Tuesday";
            this.Tuesday.Size = new System.Drawing.Size(162, 121);
            this.Tuesday.TabIndex = 3;
            this.Tuesday.Click += new System.EventHandler(this.lbSchedule_Click);
            this.Tuesday.SelectedIndexChanged += new System.EventHandler(this.lbSchedule_SelectedIndexChanged);
            // 
            // lbFriday
            // 
            this.lbFriday.DisplayMember = "ConcreteLesson.Subject";
            this.lbFriday.FormattingEnabled = true;
            this.lbFriday.Location = new System.Drawing.Point(301, 134);
            this.lbFriday.Name = "lbFriday";
            this.lbFriday.Size = new System.Drawing.Size(162, 121);
            this.lbFriday.TabIndex = 6;
            this.lbFriday.Click += new System.EventHandler(this.lbSchedule_Click);
            this.lbFriday.SelectedIndexChanged += new System.EventHandler(this.lbSchedule_SelectedIndexChanged);
            // 
            // lbWednesday
            // 
            this.lbWednesday.DisplayMember = "ConcreteLesson.Subject";
            this.lbWednesday.FormattingEnabled = true;
            this.lbWednesday.Location = new System.Drawing.Point(469, 7);
            this.lbWednesday.Name = "lbWednesday";
            this.lbWednesday.Size = new System.Drawing.Size(162, 121);
            this.lbWednesday.TabIndex = 4;
            this.lbWednesday.Click += new System.EventHandler(this.lbSchedule_Click);
            this.lbWednesday.SelectedIndexChanged += new System.EventHandler(this.lbSchedule_SelectedIndexChanged);
            // 
            // tpSettings
            // 
            this.tpSettings.Controls.Add(this.tbTeacherPosition);
            this.tpSettings.Controls.Add(this.tbLessonEnd);
            this.tpSettings.Controls.Add(this.tbLessonStart);
            this.tpSettings.Controls.Add(this.tbRoomNumber);
            this.tpSettings.Controls.Add(this.tbTeacherName);
            this.tpSettings.Controls.Add(this.tbSubjectName);
            this.tpSettings.Controls.Add(this.tbLessonNumber);
            this.tpSettings.Controls.Add(this.btnRemoveRoom);
            this.tpSettings.Controls.Add(this.btnAddRoom);
            this.tpSettings.Controls.Add(this.btnRemoveTeacher);
            this.tpSettings.Controls.Add(this.btnAddTeacher);
            this.tpSettings.Controls.Add(this.btnRemoveSubject);
            this.tpSettings.Controls.Add(this.btnAddSubject);
            this.tpSettings.Controls.Add(this.btnRemoveLesson);
            this.tpSettings.Controls.Add(this.btnAddLesson);
            this.tpSettings.Controls.Add(this.cmbDays);
            this.tpSettings.Controls.Add(this.cmbRooms);
            this.tpSettings.Controls.Add(this.cmbTeachers);
            this.tpSettings.Controls.Add(this.cmbSubjects);
            this.tpSettings.Controls.Add(this.cmbLessons);
            this.tpSettings.Controls.Add(this.lbSchedules);
            this.tpSettings.Controls.Add(this.lbRooms);
            this.tpSettings.Controls.Add(this.lbTeachers);
            this.tpSettings.Controls.Add(this.lbSubjects);
            this.tpSettings.Controls.Add(this.lbLessons);
            this.tpSettings.Location = new System.Drawing.Point(4, 22);
            this.tpSettings.Name = "tpSettings";
            this.tpSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tpSettings.Size = new System.Drawing.Size(638, 437);
            this.tpSettings.TabIndex = 1;
            this.tpSettings.Text = "Settings";
            this.tpSettings.UseVisualStyleBackColor = true;
            // 
            // tbTeacherPosition
            // 
            this.tbTeacherPosition.Location = new System.Drawing.Point(464, 33);
            this.tbTeacherPosition.Name = "tbTeacherPosition";
            this.tbTeacherPosition.Size = new System.Drawing.Size(57, 20);
            this.tbTeacherPosition.TabIndex = 26;
            // 
            // tbLessonEnd
            // 
            this.tbLessonEnd.Location = new System.Drawing.Point(118, 59);
            this.tbLessonEnd.Name = "tbLessonEnd";
            this.tbLessonEnd.Size = new System.Drawing.Size(49, 20);
            this.tbLessonEnd.TabIndex = 25;
            // 
            // tbLessonStart
            // 
            this.tbLessonStart.Location = new System.Drawing.Point(118, 33);
            this.tbLessonStart.Name = "tbLessonStart";
            this.tbLessonStart.Size = new System.Drawing.Size(49, 20);
            this.tbLessonStart.TabIndex = 24;
            // 
            // tbRoomNumber
            // 
            this.tbRoomNumber.Location = new System.Drawing.Point(464, 121);
            this.tbRoomNumber.Name = "tbRoomNumber";
            this.tbRoomNumber.Size = new System.Drawing.Size(57, 20);
            this.tbRoomNumber.TabIndex = 23;
            // 
            // tbTeacherName
            // 
            this.tbTeacherName.Location = new System.Drawing.Point(464, 7);
            this.tbTeacherName.Name = "tbTeacherName";
            this.tbTeacherName.Size = new System.Drawing.Size(57, 20);
            this.tbTeacherName.TabIndex = 22;
            // 
            // tbSubjectName
            // 
            this.tbSubjectName.Location = new System.Drawing.Point(284, 7);
            this.tbSubjectName.Name = "tbSubjectName";
            this.tbSubjectName.Size = new System.Drawing.Size(63, 20);
            this.tbSubjectName.TabIndex = 21;
            // 
            // tbLessonNumber
            // 
            this.tbLessonNumber.Location = new System.Drawing.Point(118, 7);
            this.tbLessonNumber.Name = "tbLessonNumber";
            this.tbLessonNumber.Size = new System.Drawing.Size(27, 20);
            this.tbLessonNumber.TabIndex = 20;
            // 
            // btnRemoveRoom
            // 
            this.btnRemoveRoom.Location = new System.Drawing.Point(527, 176);
            this.btnRemoveRoom.Name = "btnRemoveRoom";
            this.btnRemoveRoom.Size = new System.Drawing.Size(105, 23);
            this.btnRemoveRoom.TabIndex = 17;
            this.btnRemoveRoom.Text = "Remove";
            this.btnRemoveRoom.UseVisualStyleBackColor = true;
            this.btnRemoveRoom.Click += new System.EventHandler(this.btnRemoveRoom_Click);
            // 
            // btnAddRoom
            // 
            this.btnAddRoom.Location = new System.Drawing.Point(527, 147);
            this.btnAddRoom.Name = "btnAddRoom";
            this.btnAddRoom.Size = new System.Drawing.Size(105, 23);
            this.btnAddRoom.TabIndex = 16;
            this.btnAddRoom.Text = "Add";
            this.btnAddRoom.UseVisualStyleBackColor = true;
            this.btnAddRoom.Click += new System.EventHandler(this.btnAddRoom_Click);
            // 
            // btnRemoveTeacher
            // 
            this.btnRemoveTeacher.Location = new System.Drawing.Point(353, 176);
            this.btnRemoveTeacher.Name = "btnRemoveTeacher";
            this.btnRemoveTeacher.Size = new System.Drawing.Size(105, 23);
            this.btnRemoveTeacher.TabIndex = 15;
            this.btnRemoveTeacher.Text = "Remove";
            this.btnRemoveTeacher.UseVisualStyleBackColor = true;
            this.btnRemoveTeacher.Click += new System.EventHandler(this.btnRemoveTeacher_Click);
            // 
            // btnAddTeacher
            // 
            this.btnAddTeacher.Location = new System.Drawing.Point(353, 147);
            this.btnAddTeacher.Name = "btnAddTeacher";
            this.btnAddTeacher.Size = new System.Drawing.Size(105, 23);
            this.btnAddTeacher.TabIndex = 14;
            this.btnAddTeacher.Text = "Add";
            this.btnAddTeacher.UseVisualStyleBackColor = true;
            this.btnAddTeacher.Click += new System.EventHandler(this.btnAddTeacher_Click);
            // 
            // btnRemoveSubject
            // 
            this.btnRemoveSubject.Location = new System.Drawing.Point(173, 176);
            this.btnRemoveSubject.Name = "btnRemoveSubject";
            this.btnRemoveSubject.Size = new System.Drawing.Size(105, 23);
            this.btnRemoveSubject.TabIndex = 13;
            this.btnRemoveSubject.Text = "Remove";
            this.btnRemoveSubject.UseVisualStyleBackColor = true;
            this.btnRemoveSubject.Click += new System.EventHandler(this.btnRemoveSubject_Click);
            // 
            // btnAddSubject
            // 
            this.btnAddSubject.Location = new System.Drawing.Point(173, 147);
            this.btnAddSubject.Name = "btnAddSubject";
            this.btnAddSubject.Size = new System.Drawing.Size(105, 23);
            this.btnAddSubject.TabIndex = 12;
            this.btnAddSubject.Text = "Add";
            this.btnAddSubject.UseVisualStyleBackColor = true;
            this.btnAddSubject.Click += new System.EventHandler(this.btnAddSubject_Click);
            // 
            // btnRemoveLesson
            // 
            this.btnRemoveLesson.Location = new System.Drawing.Point(7, 176);
            this.btnRemoveLesson.Name = "btnRemoveLesson";
            this.btnRemoveLesson.Size = new System.Drawing.Size(105, 23);
            this.btnRemoveLesson.TabIndex = 11;
            this.btnRemoveLesson.Text = "Remove";
            this.btnRemoveLesson.UseVisualStyleBackColor = true;
            this.btnRemoveLesson.Click += new System.EventHandler(this.btnRemoveLesson_Click);
            // 
            // btnAddLesson
            // 
            this.btnAddLesson.Location = new System.Drawing.Point(7, 147);
            this.btnAddLesson.Name = "btnAddLesson";
            this.btnAddLesson.Size = new System.Drawing.Size(105, 23);
            this.btnAddLesson.TabIndex = 10;
            this.btnAddLesson.Text = "Add";
            this.btnAddLesson.UseVisualStyleBackColor = true;
            this.btnAddLesson.Click += new System.EventHandler(this.btnAddLesson_Click);
            // 
            // cmbDays
            // 
            this.cmbDays.FormattingEnabled = true;
            this.cmbDays.Location = new System.Drawing.Point(174, 408);
            this.cmbDays.Name = "cmbDays";
            this.cmbDays.Size = new System.Drawing.Size(121, 21);
            this.cmbDays.TabIndex = 9;
            // 
            // cmbRooms
            // 
            this.cmbRooms.FormattingEnabled = true;
            this.cmbRooms.Location = new System.Drawing.Point(174, 381);
            this.cmbRooms.Name = "cmbRooms";
            this.cmbRooms.Size = new System.Drawing.Size(121, 21);
            this.cmbRooms.TabIndex = 8;
            // 
            // cmbTeachers
            // 
            this.cmbTeachers.FormattingEnabled = true;
            this.cmbTeachers.Location = new System.Drawing.Point(174, 353);
            this.cmbTeachers.Name = "cmbTeachers";
            this.cmbTeachers.Size = new System.Drawing.Size(121, 21);
            this.cmbTeachers.TabIndex = 7;
            // 
            // cmbSubjects
            // 
            this.cmbSubjects.FormattingEnabled = true;
            this.cmbSubjects.Location = new System.Drawing.Point(174, 325);
            this.cmbSubjects.Name = "cmbSubjects";
            this.cmbSubjects.Size = new System.Drawing.Size(121, 21);
            this.cmbSubjects.TabIndex = 6;
            // 
            // cmbLessons
            // 
            this.cmbLessons.FormattingEnabled = true;
            this.cmbLessons.Location = new System.Drawing.Point(174, 297);
            this.cmbLessons.Name = "cmbLessons";
            this.cmbLessons.Size = new System.Drawing.Size(121, 21);
            this.cmbLessons.TabIndex = 5;
            // 
            // lbSchedules
            // 
            this.lbSchedules.FormattingEnabled = true;
            this.lbSchedules.Location = new System.Drawing.Point(7, 297);
            this.lbSchedules.Name = "lbSchedules";
            this.lbSchedules.Size = new System.Drawing.Size(160, 134);
            this.lbSchedules.TabIndex = 4;
            // 
            // lbRooms
            // 
            this.lbRooms.DisplayMember = "Room.Number";
            this.lbRooms.FormattingEnabled = true;
            this.lbRooms.Location = new System.Drawing.Point(527, 7);
            this.lbRooms.Name = "lbRooms";
            this.lbRooms.Size = new System.Drawing.Size(105, 134);
            this.lbRooms.TabIndex = 3;
            // 
            // lbTeachers
            // 
            this.lbTeachers.DisplayMember = "Teacher.Name";
            this.lbTeachers.FormattingEnabled = true;
            this.lbTeachers.Location = new System.Drawing.Point(353, 7);
            this.lbTeachers.Name = "lbTeachers";
            this.lbTeachers.Size = new System.Drawing.Size(105, 134);
            this.lbTeachers.TabIndex = 2;
            // 
            // lbSubjects
            // 
            this.lbSubjects.DisplayMember = "Subject.Name";
            this.lbSubjects.FormattingEnabled = true;
            this.lbSubjects.Location = new System.Drawing.Point(173, 7);
            this.lbSubjects.Name = "lbSubjects";
            this.lbSubjects.Size = new System.Drawing.Size(105, 134);
            this.lbSubjects.TabIndex = 1;
            // 
            // lbLessons
            // 
            this.lbLessons.DisplayMember = "Lesson.Number";
            this.lbLessons.FormattingEnabled = true;
            this.lbLessons.Location = new System.Drawing.Point(7, 7);
            this.lbLessons.Name = "lbLessons";
            this.lbLessons.Size = new System.Drawing.Size(105, 134);
            this.lbLessons.TabIndex = 0;
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 487);
            this.Controls.Add(this.tcSchedule);
            this.Name = "ClientForm";
            this.Text = "Form1";
            this.gbDetails.ResumeLayout(false);
            this.gbDetails.PerformLayout();
            this.tcSchedule.ResumeLayout(false);
            this.tpSchedule.ResumeLayout(false);
            this.tpSchedule.PerformLayout();
            this.tpSettings.ResumeLayout(false);
            this.tpSettings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbGroups;
        private System.Windows.Forms.ListBox lbMonday;
        private System.Windows.Forms.ListBox lbThursday;
        private System.Windows.Forms.GroupBox gbDetails;
        private System.Windows.Forms.TabControl tcSchedule;
        private System.Windows.Forms.TabPage tpSchedule;
        private System.Windows.Forms.ListBox lbSaturday;
        private System.Windows.Forms.ListBox Tuesday;
        private System.Windows.Forms.ListBox lbFriday;
        private System.Windows.Forms.ListBox lbWednesday;
        private System.Windows.Forms.TabPage tpSettings;
        private System.Windows.Forms.ListBox lbRooms;
        private System.Windows.Forms.ListBox lbTeachers;
        private System.Windows.Forms.ListBox lbSubjects;
        private System.Windows.Forms.ListBox lbLessons;
        private System.Windows.Forms.ComboBox cmbRooms;
        private System.Windows.Forms.ComboBox cmbTeachers;
        private System.Windows.Forms.ComboBox cmbSubjects;
        private System.Windows.Forms.ComboBox cmbLessons;
        private System.Windows.Forms.ListBox lbSchedules;
        private System.Windows.Forms.Button btnRemoveRoom;
        private System.Windows.Forms.Button btnAddRoom;
        private System.Windows.Forms.Button btnRemoveTeacher;
        private System.Windows.Forms.Button btnAddTeacher;
        private System.Windows.Forms.Button btnRemoveSubject;
        private System.Windows.Forms.Button btnAddSubject;
        private System.Windows.Forms.Button btnRemoveLesson;
        private System.Windows.Forms.Button btnAddLesson;
        private System.Windows.Forms.ComboBox cmbDays;
        private System.Windows.Forms.Label lLessonEndValue;
        private System.Windows.Forms.Label lLessonStartValue;
        private System.Windows.Forms.Label lLessonNumberValue;
        private System.Windows.Forms.Label lTeacher;
        private System.Windows.Forms.Label lLessonEnd;
        private System.Windows.Forms.Label lLessonStart;
        private System.Windows.Forms.Label lLessonNumber;
        private System.Windows.Forms.Label lTeacherValue;
        private System.Windows.Forms.Label lRoomValue;
        private System.Windows.Forms.Label lRoom;
        private System.Windows.Forms.Label lSubjectValue;
        private System.Windows.Forms.Label lSubject;
        private System.Windows.Forms.TextBox tbRoomNumber;
        private System.Windows.Forms.TextBox tbTeacherName;
        private System.Windows.Forms.TextBox tbSubjectName;
        private System.Windows.Forms.TextBox tbLessonNumber;
        private System.Windows.Forms.TextBox tbTeacherPosition;
        private System.Windows.Forms.TextBox tbLessonEnd;
        private System.Windows.Forms.TextBox tbLessonStart;
        private System.Windows.Forms.Button btnRemoveSchedule;
        private System.Windows.Forms.Button btnAddSchedule;
        private System.Windows.Forms.Button btnRemoveGroup;
        private System.Windows.Forms.Button btnAddGroup;
        private System.Windows.Forms.TextBox tbGroupName;
    }
}

