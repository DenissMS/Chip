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
            this.btnGroupEdit = new System.Windows.Forms.Button();
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
            this.gbRooms = new System.Windows.Forms.GroupBox();
            this.btnRoomsEdit = new System.Windows.Forms.Button();
            this.lRoomNumber = new System.Windows.Forms.Label();
            this.lbRooms = new System.Windows.Forms.ListBox();
            this.btnAddRoom = new System.Windows.Forms.Button();
            this.btnRemoveRoom = new System.Windows.Forms.Button();
            this.tbRoomNumber = new System.Windows.Forms.TextBox();
            this.gbTeachers = new System.Windows.Forms.GroupBox();
            this.btnTeachersEdit = new System.Windows.Forms.Button();
            this.lTeacherPosition = new System.Windows.Forms.Label();
            this.lTeacherName = new System.Windows.Forms.Label();
            this.lbTeachers = new System.Windows.Forms.ListBox();
            this.btnAddTeacher = new System.Windows.Forms.Button();
            this.btnRemoveTeacher = new System.Windows.Forms.Button();
            this.tbTeacherPosition = new System.Windows.Forms.TextBox();
            this.tbTeacherName = new System.Windows.Forms.TextBox();
            this.gbSubjects = new System.Windows.Forms.GroupBox();
            this.btnSubjectsEdit = new System.Windows.Forms.Button();
            this.lSubjectName = new System.Windows.Forms.Label();
            this.lbSubjects = new System.Windows.Forms.ListBox();
            this.btnAddSubject = new System.Windows.Forms.Button();
            this.btnRemoveSubject = new System.Windows.Forms.Button();
            this.tbSubjectName = new System.Windows.Forms.TextBox();
            this.bgLessons = new System.Windows.Forms.GroupBox();
            this.btnLessonsEdit = new System.Windows.Forms.Button();
            this.lEnd = new System.Windows.Forms.Label();
            this.lStart = new System.Windows.Forms.Label();
            this.lNumber = new System.Windows.Forms.Label();
            this.lbLessons = new System.Windows.Forms.ListBox();
            this.btnAddLesson = new System.Windows.Forms.Button();
            this.tbLessonEnd = new System.Windows.Forms.TextBox();
            this.btnRemoveLesson = new System.Windows.Forms.Button();
            this.tbLessonStart = new System.Windows.Forms.TextBox();
            this.tbLessonNumber = new System.Windows.Forms.TextBox();
            this.gbDetails.SuspendLayout();
            this.tcSchedule.SuspendLayout();
            this.tpSchedule.SuspendLayout();
            this.tpSettings.SuspendLayout();
            this.gbRooms.SuspendLayout();
            this.gbTeachers.SuspendLayout();
            this.gbSubjects.SuspendLayout();
            this.bgLessons.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbGroups
            // 
            this.lbGroups.DisplayMember = "Group.Name";
            this.lbGroups.FormattingEnabled = true;
            this.lbGroups.Location = new System.Drawing.Point(7, 7);
            this.lbGroups.Name = "lbGroups";
            this.lbGroups.Size = new System.Drawing.Size(120, 303);
            this.lbGroups.TabIndex = 1;
            this.lbGroups.SelectedIndexChanged += new System.EventHandler(this.lbGroups_SelectedIndexChanged);
            // 
            // lbMonday
            // 
            this.lbMonday.BackColor = System.Drawing.SystemColors.Window;
            this.lbMonday.DisplayMember = "Subject.Name";
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
            this.tcSchedule.Size = new System.Drawing.Size(775, 463);
            this.tcSchedule.TabIndex = 9;
            // 
            // tpSchedule
            // 
            this.tpSchedule.Controls.Add(this.btnGroupEdit);
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
            this.tpSchedule.Size = new System.Drawing.Size(767, 437);
            this.tpSchedule.TabIndex = 0;
            this.tpSchedule.Text = "Schedule";
            this.tpSchedule.UseVisualStyleBackColor = true;
            // 
            // btnGroupEdit
            // 
            this.btnGroupEdit.Location = new System.Drawing.Point(7, 368);
            this.btnGroupEdit.Name = "btnGroupEdit";
            this.btnGroupEdit.Size = new System.Drawing.Size(119, 23);
            this.btnGroupEdit.TabIndex = 25;
            this.btnGroupEdit.Text = "Edit";
            this.btnGroupEdit.UseVisualStyleBackColor = true;
            this.btnGroupEdit.Click += new System.EventHandler(this.btnGroupEdit_Click);
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
            this.btnAddGroup.Location = new System.Drawing.Point(7, 339);
            this.btnAddGroup.Name = "btnAddGroup";
            this.btnAddGroup.Size = new System.Drawing.Size(119, 23);
            this.btnAddGroup.TabIndex = 23;
            this.btnAddGroup.Text = "Add";
            this.btnAddGroup.UseVisualStyleBackColor = true;
            this.btnAddGroup.Click += new System.EventHandler(this.btnAddGroup_Click);
            // 
            // tbGroupName
            // 
            this.tbGroupName.Location = new System.Drawing.Point(8, 313);
            this.tbGroupName.Name = "tbGroupName";
            this.tbGroupName.Size = new System.Drawing.Size(119, 20);
            this.tbGroupName.TabIndex = 22;
            this.tbGroupName.Text = "Group";
            // 
            // btnRemoveSchedule
            // 
            this.btnRemoveSchedule.Location = new System.Drawing.Point(550, 403);
            this.btnRemoveSchedule.Name = "btnRemoveSchedule";
            this.btnRemoveSchedule.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveSchedule.TabIndex = 21;
            this.btnRemoveSchedule.Text = "Remove";
            this.btnRemoveSchedule.UseVisualStyleBackColor = true;
            this.btnRemoveSchedule.Click += new System.EventHandler(this.btnRemoveSchedule_Click);
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
            this.tpSettings.Controls.Add(this.gbRooms);
            this.tpSettings.Controls.Add(this.gbTeachers);
            this.tpSettings.Controls.Add(this.gbSubjects);
            this.tpSettings.Controls.Add(this.bgLessons);
            this.tpSettings.Location = new System.Drawing.Point(4, 22);
            this.tpSettings.Name = "tpSettings";
            this.tpSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tpSettings.Size = new System.Drawing.Size(767, 437);
            this.tpSettings.TabIndex = 1;
            this.tpSettings.Text = "Settings";
            this.tpSettings.UseVisualStyleBackColor = true;
            // 
            // gbRooms
            // 
            this.gbRooms.Controls.Add(this.btnRoomsEdit);
            this.gbRooms.Controls.Add(this.lRoomNumber);
            this.gbRooms.Controls.Add(this.lbRooms);
            this.gbRooms.Controls.Add(this.btnAddRoom);
            this.gbRooms.Controls.Add(this.btnRemoveRoom);
            this.gbRooms.Controls.Add(this.tbRoomNumber);
            this.gbRooms.Location = new System.Drawing.Point(572, 6);
            this.gbRooms.Name = "gbRooms";
            this.gbRooms.Size = new System.Drawing.Size(181, 250);
            this.gbRooms.TabIndex = 30;
            this.gbRooms.TabStop = false;
            this.gbRooms.Text = "Rooms";
            // 
            // btnRoomsEdit
            // 
            this.btnRoomsEdit.Location = new System.Drawing.Point(6, 192);
            this.btnRoomsEdit.Name = "btnRoomsEdit";
            this.btnRoomsEdit.Size = new System.Drawing.Size(105, 23);
            this.btnRoomsEdit.TabIndex = 32;
            this.btnRoomsEdit.Text = "Edit";
            this.btnRoomsEdit.UseVisualStyleBackColor = true;
            this.btnRoomsEdit.Click += new System.EventHandler(this.btnRoomsEdit_Click);
            // 
            // lRoomNumber
            // 
            this.lRoomNumber.AutoSize = true;
            this.lRoomNumber.Location = new System.Drawing.Point(117, 19);
            this.lRoomNumber.Name = "lRoomNumber";
            this.lRoomNumber.Size = new System.Drawing.Size(44, 13);
            this.lRoomNumber.TabIndex = 29;
            this.lRoomNumber.Text = "Number";
            // 
            // lbRooms
            // 
            this.lbRooms.DisplayMember = "Room.Number";
            this.lbRooms.FormattingEnabled = true;
            this.lbRooms.Location = new System.Drawing.Point(6, 19);
            this.lbRooms.Name = "lbRooms";
            this.lbRooms.Size = new System.Drawing.Size(105, 134);
            this.lbRooms.TabIndex = 3;
            this.lbRooms.SelectedIndexChanged += new System.EventHandler(this.lbRooms_SelectedIndexChanged);
            // 
            // btnAddRoom
            // 
            this.btnAddRoom.Location = new System.Drawing.Point(6, 163);
            this.btnAddRoom.Name = "btnAddRoom";
            this.btnAddRoom.Size = new System.Drawing.Size(105, 23);
            this.btnAddRoom.TabIndex = 16;
            this.btnAddRoom.Text = "Add";
            this.btnAddRoom.UseVisualStyleBackColor = true;
            this.btnAddRoom.Click += new System.EventHandler(this.btnAddRoom_Click);
            // 
            // btnRemoveRoom
            // 
            this.btnRemoveRoom.Location = new System.Drawing.Point(6, 221);
            this.btnRemoveRoom.Name = "btnRemoveRoom";
            this.btnRemoveRoom.Size = new System.Drawing.Size(105, 23);
            this.btnRemoveRoom.TabIndex = 17;
            this.btnRemoveRoom.Text = "Remove";
            this.btnRemoveRoom.UseVisualStyleBackColor = true;
            this.btnRemoveRoom.Click += new System.EventHandler(this.btnRemoveRoom_Click);
            // 
            // tbRoomNumber
            // 
            this.tbRoomNumber.Location = new System.Drawing.Point(117, 35);
            this.tbRoomNumber.Name = "tbRoomNumber";
            this.tbRoomNumber.Size = new System.Drawing.Size(57, 20);
            this.tbRoomNumber.TabIndex = 23;
            this.tbRoomNumber.Text = "123";
            // 
            // gbTeachers
            // 
            this.gbTeachers.Controls.Add(this.btnTeachersEdit);
            this.gbTeachers.Controls.Add(this.lTeacherPosition);
            this.gbTeachers.Controls.Add(this.lTeacherName);
            this.gbTeachers.Controls.Add(this.lbTeachers);
            this.gbTeachers.Controls.Add(this.btnAddTeacher);
            this.gbTeachers.Controls.Add(this.btnRemoveTeacher);
            this.gbTeachers.Controls.Add(this.tbTeacherPosition);
            this.gbTeachers.Controls.Add(this.tbTeacherName);
            this.gbTeachers.Location = new System.Drawing.Point(378, 6);
            this.gbTeachers.Name = "gbTeachers";
            this.gbTeachers.Size = new System.Drawing.Size(188, 250);
            this.gbTeachers.TabIndex = 29;
            this.gbTeachers.TabStop = false;
            this.gbTeachers.Text = "Teachers";
            // 
            // btnTeachersEdit
            // 
            this.btnTeachersEdit.Location = new System.Drawing.Point(6, 192);
            this.btnTeachersEdit.Name = "btnTeachersEdit";
            this.btnTeachersEdit.Size = new System.Drawing.Size(105, 23);
            this.btnTeachersEdit.TabIndex = 31;
            this.btnTeachersEdit.Text = "Edit";
            this.btnTeachersEdit.UseVisualStyleBackColor = true;
            this.btnTeachersEdit.Click += new System.EventHandler(this.btnTeachersEdit_Click);
            // 
            // lTeacherPosition
            // 
            this.lTeacherPosition.AutoSize = true;
            this.lTeacherPosition.Location = new System.Drawing.Point(117, 58);
            this.lTeacherPosition.Name = "lTeacherPosition";
            this.lTeacherPosition.Size = new System.Drawing.Size(44, 13);
            this.lTeacherPosition.TabIndex = 31;
            this.lTeacherPosition.Text = "Position";
            // 
            // lTeacherName
            // 
            this.lTeacherName.AutoSize = true;
            this.lTeacherName.Location = new System.Drawing.Point(117, 19);
            this.lTeacherName.Name = "lTeacherName";
            this.lTeacherName.Size = new System.Drawing.Size(35, 13);
            this.lTeacherName.TabIndex = 30;
            this.lTeacherName.Text = "Name";
            // 
            // lbTeachers
            // 
            this.lbTeachers.DisplayMember = "Teacher.Name";
            this.lbTeachers.FormattingEnabled = true;
            this.lbTeachers.Location = new System.Drawing.Point(6, 19);
            this.lbTeachers.Name = "lbTeachers";
            this.lbTeachers.Size = new System.Drawing.Size(105, 134);
            this.lbTeachers.TabIndex = 2;
            this.lbTeachers.SelectedIndexChanged += new System.EventHandler(this.lbTeachers_SelectedIndexChanged);
            // 
            // btnAddTeacher
            // 
            this.btnAddTeacher.Location = new System.Drawing.Point(6, 163);
            this.btnAddTeacher.Name = "btnAddTeacher";
            this.btnAddTeacher.Size = new System.Drawing.Size(105, 23);
            this.btnAddTeacher.TabIndex = 14;
            this.btnAddTeacher.Text = "Add";
            this.btnAddTeacher.UseVisualStyleBackColor = true;
            this.btnAddTeacher.Click += new System.EventHandler(this.btnAddTeacher_Click);
            // 
            // btnRemoveTeacher
            // 
            this.btnRemoveTeacher.Location = new System.Drawing.Point(6, 221);
            this.btnRemoveTeacher.Name = "btnRemoveTeacher";
            this.btnRemoveTeacher.Size = new System.Drawing.Size(105, 23);
            this.btnRemoveTeacher.TabIndex = 15;
            this.btnRemoveTeacher.Text = "Remove";
            this.btnRemoveTeacher.UseVisualStyleBackColor = true;
            this.btnRemoveTeacher.Click += new System.EventHandler(this.btnRemoveTeacher_Click);
            // 
            // tbTeacherPosition
            // 
            this.tbTeacherPosition.Location = new System.Drawing.Point(117, 74);
            this.tbTeacherPosition.Name = "tbTeacherPosition";
            this.tbTeacherPosition.Size = new System.Drawing.Size(57, 20);
            this.tbTeacherPosition.TabIndex = 26;
            this.tbTeacherPosition.Text = "Professor";
            // 
            // tbTeacherName
            // 
            this.tbTeacherName.Location = new System.Drawing.Point(117, 35);
            this.tbTeacherName.Name = "tbTeacherName";
            this.tbTeacherName.Size = new System.Drawing.Size(57, 20);
            this.tbTeacherName.TabIndex = 22;
            this.tbTeacherName.Text = "Matias";
            // 
            // gbSubjects
            // 
            this.gbSubjects.Controls.Add(this.btnSubjectsEdit);
            this.gbSubjects.Controls.Add(this.lSubjectName);
            this.gbSubjects.Controls.Add(this.lbSubjects);
            this.gbSubjects.Controls.Add(this.btnAddSubject);
            this.gbSubjects.Controls.Add(this.btnRemoveSubject);
            this.gbSubjects.Controls.Add(this.tbSubjectName);
            this.gbSubjects.Location = new System.Drawing.Point(185, 6);
            this.gbSubjects.Name = "gbSubjects";
            this.gbSubjects.Size = new System.Drawing.Size(187, 250);
            this.gbSubjects.TabIndex = 28;
            this.gbSubjects.TabStop = false;
            this.gbSubjects.Text = "Subjects";
            // 
            // btnSubjectsEdit
            // 
            this.btnSubjectsEdit.Location = new System.Drawing.Point(6, 192);
            this.btnSubjectsEdit.Name = "btnSubjectsEdit";
            this.btnSubjectsEdit.Size = new System.Drawing.Size(105, 23);
            this.btnSubjectsEdit.TabIndex = 30;
            this.btnSubjectsEdit.Text = "Edit";
            this.btnSubjectsEdit.UseVisualStyleBackColor = true;
            this.btnSubjectsEdit.Click += new System.EventHandler(this.btnSubjectsEdit_Click);
            // 
            // lSubjectName
            // 
            this.lSubjectName.AutoSize = true;
            this.lSubjectName.Location = new System.Drawing.Point(117, 19);
            this.lSubjectName.Name = "lSubjectName";
            this.lSubjectName.Size = new System.Drawing.Size(35, 13);
            this.lSubjectName.TabIndex = 29;
            this.lSubjectName.Text = "Name";
            // 
            // lbSubjects
            // 
            this.lbSubjects.DisplayMember = "Subject.Name";
            this.lbSubjects.FormattingEnabled = true;
            this.lbSubjects.Location = new System.Drawing.Point(6, 19);
            this.lbSubjects.Name = "lbSubjects";
            this.lbSubjects.Size = new System.Drawing.Size(105, 134);
            this.lbSubjects.TabIndex = 1;
            this.lbSubjects.SelectedIndexChanged += new System.EventHandler(this.lbSubjects_SelectedIndexChanged);
            // 
            // btnAddSubject
            // 
            this.btnAddSubject.Location = new System.Drawing.Point(6, 163);
            this.btnAddSubject.Name = "btnAddSubject";
            this.btnAddSubject.Size = new System.Drawing.Size(105, 23);
            this.btnAddSubject.TabIndex = 12;
            this.btnAddSubject.Text = "Add";
            this.btnAddSubject.UseVisualStyleBackColor = true;
            this.btnAddSubject.Click += new System.EventHandler(this.btnAddSubject_Click);
            // 
            // btnRemoveSubject
            // 
            this.btnRemoveSubject.Location = new System.Drawing.Point(6, 221);
            this.btnRemoveSubject.Name = "btnRemoveSubject";
            this.btnRemoveSubject.Size = new System.Drawing.Size(105, 23);
            this.btnRemoveSubject.TabIndex = 13;
            this.btnRemoveSubject.Text = "Remove";
            this.btnRemoveSubject.UseVisualStyleBackColor = true;
            this.btnRemoveSubject.Click += new System.EventHandler(this.btnRemoveSubject_Click);
            // 
            // tbSubjectName
            // 
            this.tbSubjectName.Location = new System.Drawing.Point(117, 35);
            this.tbSubjectName.Name = "tbSubjectName";
            this.tbSubjectName.Size = new System.Drawing.Size(63, 20);
            this.tbSubjectName.TabIndex = 21;
            this.tbSubjectName.Text = "Programming";
            // 
            // bgLessons
            // 
            this.bgLessons.Controls.Add(this.btnLessonsEdit);
            this.bgLessons.Controls.Add(this.lEnd);
            this.bgLessons.Controls.Add(this.lStart);
            this.bgLessons.Controls.Add(this.lNumber);
            this.bgLessons.Controls.Add(this.lbLessons);
            this.bgLessons.Controls.Add(this.btnAddLesson);
            this.bgLessons.Controls.Add(this.tbLessonEnd);
            this.bgLessons.Controls.Add(this.btnRemoveLesson);
            this.bgLessons.Controls.Add(this.tbLessonStart);
            this.bgLessons.Controls.Add(this.tbLessonNumber);
            this.bgLessons.Location = new System.Drawing.Point(6, 6);
            this.bgLessons.Name = "bgLessons";
            this.bgLessons.Size = new System.Drawing.Size(173, 250);
            this.bgLessons.TabIndex = 27;
            this.bgLessons.TabStop = false;
            this.bgLessons.Text = "Lessons";
            // 
            // btnLessonsEdit
            // 
            this.btnLessonsEdit.Location = new System.Drawing.Point(6, 192);
            this.btnLessonsEdit.Name = "btnLessonsEdit";
            this.btnLessonsEdit.Size = new System.Drawing.Size(105, 23);
            this.btnLessonsEdit.TabIndex = 29;
            this.btnLessonsEdit.Text = "Edit";
            this.btnLessonsEdit.UseVisualStyleBackColor = true;
            this.btnLessonsEdit.Click += new System.EventHandler(this.btnLessonsEdit_Click);
            // 
            // lEnd
            // 
            this.lEnd.AutoSize = true;
            this.lEnd.Location = new System.Drawing.Point(117, 97);
            this.lEnd.Name = "lEnd";
            this.lEnd.Size = new System.Drawing.Size(26, 13);
            this.lEnd.TabIndex = 28;
            this.lEnd.Text = "End";
            // 
            // lStart
            // 
            this.lStart.AutoSize = true;
            this.lStart.Location = new System.Drawing.Point(117, 58);
            this.lStart.Name = "lStart";
            this.lStart.Size = new System.Drawing.Size(29, 13);
            this.lStart.TabIndex = 27;
            this.lStart.Text = "Start";
            // 
            // lNumber
            // 
            this.lNumber.AutoSize = true;
            this.lNumber.Location = new System.Drawing.Point(117, 19);
            this.lNumber.Name = "lNumber";
            this.lNumber.Size = new System.Drawing.Size(44, 13);
            this.lNumber.TabIndex = 26;
            this.lNumber.Text = "Number";
            // 
            // lbLessons
            // 
            this.lbLessons.DisplayMember = "Lesson.Number";
            this.lbLessons.FormattingEnabled = true;
            this.lbLessons.Location = new System.Drawing.Point(6, 19);
            this.lbLessons.Name = "lbLessons";
            this.lbLessons.Size = new System.Drawing.Size(105, 134);
            this.lbLessons.TabIndex = 0;
            this.lbLessons.SelectedIndexChanged += new System.EventHandler(this.lbLessons_SelectedIndexChanged);
            // 
            // btnAddLesson
            // 
            this.btnAddLesson.Location = new System.Drawing.Point(6, 163);
            this.btnAddLesson.Name = "btnAddLesson";
            this.btnAddLesson.Size = new System.Drawing.Size(105, 23);
            this.btnAddLesson.TabIndex = 10;
            this.btnAddLesson.Text = "Add";
            this.btnAddLesson.UseVisualStyleBackColor = true;
            this.btnAddLesson.Click += new System.EventHandler(this.btnAddLesson_Click);
            // 
            // tbLessonEnd
            // 
            this.tbLessonEnd.Location = new System.Drawing.Point(117, 113);
            this.tbLessonEnd.Name = "tbLessonEnd";
            this.tbLessonEnd.Size = new System.Drawing.Size(49, 20);
            this.tbLessonEnd.TabIndex = 25;
            this.tbLessonEnd.Text = "06:50";
            // 
            // btnRemoveLesson
            // 
            this.btnRemoveLesson.Location = new System.Drawing.Point(6, 221);
            this.btnRemoveLesson.Name = "btnRemoveLesson";
            this.btnRemoveLesson.Size = new System.Drawing.Size(105, 23);
            this.btnRemoveLesson.TabIndex = 11;
            this.btnRemoveLesson.Text = "Remove";
            this.btnRemoveLesson.UseVisualStyleBackColor = true;
            this.btnRemoveLesson.Click += new System.EventHandler(this.btnRemoveLesson_Click);
            // 
            // tbLessonStart
            // 
            this.tbLessonStart.Location = new System.Drawing.Point(117, 74);
            this.tbLessonStart.Name = "tbLessonStart";
            this.tbLessonStart.Size = new System.Drawing.Size(49, 20);
            this.tbLessonStart.TabIndex = 24;
            this.tbLessonStart.Text = "05:30";
            // 
            // tbLessonNumber
            // 
            this.tbLessonNumber.Location = new System.Drawing.Point(117, 35);
            this.tbLessonNumber.Name = "tbLessonNumber";
            this.tbLessonNumber.Size = new System.Drawing.Size(27, 20);
            this.tbLessonNumber.TabIndex = 20;
            this.tbLessonNumber.Text = "1";
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 487);
            this.Controls.Add(this.tcSchedule);
            this.Name = "ClientForm";
            this.Text = "Book of Schedules";
            this.gbDetails.ResumeLayout(false);
            this.gbDetails.PerformLayout();
            this.tcSchedule.ResumeLayout(false);
            this.tpSchedule.ResumeLayout(false);
            this.tpSchedule.PerformLayout();
            this.tpSettings.ResumeLayout(false);
            this.gbRooms.ResumeLayout(false);
            this.gbRooms.PerformLayout();
            this.gbTeachers.ResumeLayout(false);
            this.gbTeachers.PerformLayout();
            this.gbSubjects.ResumeLayout(false);
            this.gbSubjects.PerformLayout();
            this.bgLessons.ResumeLayout(false);
            this.bgLessons.PerformLayout();
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
        private System.Windows.Forms.Button btnRemoveRoom;
        private System.Windows.Forms.Button btnAddRoom;
        private System.Windows.Forms.Button btnRemoveTeacher;
        private System.Windows.Forms.Button btnAddTeacher;
        private System.Windows.Forms.Button btnRemoveSubject;
        private System.Windows.Forms.Button btnAddSubject;
        private System.Windows.Forms.Button btnRemoveLesson;
        private System.Windows.Forms.Button btnAddLesson;
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
        private System.Windows.Forms.GroupBox gbRooms;
        private System.Windows.Forms.GroupBox gbTeachers;
        private System.Windows.Forms.GroupBox gbSubjects;
        private System.Windows.Forms.Label lSubjectName;
        private System.Windows.Forms.GroupBox bgLessons;
        private System.Windows.Forms.Label lEnd;
        private System.Windows.Forms.Label lStart;
        private System.Windows.Forms.Label lNumber;
        private System.Windows.Forms.Label lRoomNumber;
        private System.Windows.Forms.Label lTeacherPosition;
        private System.Windows.Forms.Label lTeacherName;
        private System.Windows.Forms.Button btnRoomsEdit;
        private System.Windows.Forms.Button btnTeachersEdit;
        private System.Windows.Forms.Button btnSubjectsEdit;
        private System.Windows.Forms.Button btnLessonsEdit;
        private System.Windows.Forms.Button btnGroupEdit;
    }
}

