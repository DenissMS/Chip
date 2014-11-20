namespace ChipClient
{
    partial class ScheduleEditForm
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
            this.lbSchedule = new System.Windows.Forms.ListBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cmbLesson = new System.Windows.Forms.ComboBox();
            this.cmbSubject = new System.Windows.Forms.ComboBox();
            this.cmbTeacher = new System.Windows.Forms.ComboBox();
            this.cmbRoom = new System.Windows.Forms.ComboBox();
            this.lLesson = new System.Windows.Forms.Label();
            this.lSubject = new System.Windows.Forms.Label();
            this.lTeacher = new System.Windows.Forms.Label();
            this.lRoom = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbSchedule
            // 
            this.lbSchedule.DisplayMember = "ConcreteLesson.Name";
            this.lbSchedule.FormattingEnabled = true;
            this.lbSchedule.Location = new System.Drawing.Point(12, 12);
            this.lbSchedule.Name = "lbSchedule";
            this.lbSchedule.Size = new System.Drawing.Size(171, 82);
            this.lbSchedule.TabIndex = 0;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(21, 208);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 1;
            this.btnSubmit.Text = "OK";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(102, 208);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cmbLesson
            // 
            this.cmbLesson.DisplayMember = "Lesson.Number";
            this.cmbLesson.FormattingEnabled = true;
            this.cmbLesson.Location = new System.Drawing.Point(62, 100);
            this.cmbLesson.Name = "cmbLesson";
            this.cmbLesson.Size = new System.Drawing.Size(41, 21);
            this.cmbLesson.TabIndex = 3;
            // 
            // cmbSubject
            // 
            this.cmbSubject.DisplayMember = "Subject.Name";
            this.cmbSubject.FormattingEnabled = true;
            this.cmbSubject.Location = new System.Drawing.Point(62, 127);
            this.cmbSubject.Name = "cmbSubject";
            this.cmbSubject.Size = new System.Drawing.Size(121, 21);
            this.cmbSubject.TabIndex = 4;
            // 
            // cmbTeacher
            // 
            this.cmbTeacher.DisplayMember = "Teacher.Name";
            this.cmbTeacher.FormattingEnabled = true;
            this.cmbTeacher.Location = new System.Drawing.Point(62, 154);
            this.cmbTeacher.Name = "cmbTeacher";
            this.cmbTeacher.Size = new System.Drawing.Size(121, 21);
            this.cmbTeacher.TabIndex = 5;
            // 
            // cmbRoom
            // 
            this.cmbRoom.DisplayMember = "Room.Number";
            this.cmbRoom.FormattingEnabled = true;
            this.cmbRoom.Location = new System.Drawing.Point(62, 181);
            this.cmbRoom.Name = "cmbRoom";
            this.cmbRoom.Size = new System.Drawing.Size(41, 21);
            this.cmbRoom.TabIndex = 6;
            // 
            // lLesson
            // 
            this.lLesson.AutoSize = true;
            this.lLesson.Location = new System.Drawing.Point(12, 103);
            this.lLesson.Name = "lLesson";
            this.lLesson.Size = new System.Drawing.Size(44, 13);
            this.lLesson.TabIndex = 7;
            this.lLesson.Text = "Lesson:";
            // 
            // lSubject
            // 
            this.lSubject.AutoSize = true;
            this.lSubject.Location = new System.Drawing.Point(12, 130);
            this.lSubject.Name = "lSubject";
            this.lSubject.Size = new System.Drawing.Size(46, 13);
            this.lSubject.TabIndex = 8;
            this.lSubject.Text = "Subject:";
            // 
            // lTeacher
            // 
            this.lTeacher.AutoSize = true;
            this.lTeacher.Location = new System.Drawing.Point(12, 157);
            this.lTeacher.Name = "lTeacher";
            this.lTeacher.Size = new System.Drawing.Size(50, 13);
            this.lTeacher.TabIndex = 9;
            this.lTeacher.Text = "Teacher:";
            // 
            // lRoom
            // 
            this.lRoom.AutoSize = true;
            this.lRoom.Location = new System.Drawing.Point(12, 184);
            this.lRoom.Name = "lRoom";
            this.lRoom.Size = new System.Drawing.Size(35, 13);
            this.lRoom.TabIndex = 10;
            this.lRoom.Text = "Room";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(189, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(189, 41);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 12;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // ScheduleEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 237);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lRoom);
            this.Controls.Add(this.lTeacher);
            this.Controls.Add(this.lSubject);
            this.Controls.Add(this.lLesson);
            this.Controls.Add(this.cmbRoom);
            this.Controls.Add(this.cmbTeacher);
            this.Controls.Add(this.cmbSubject);
            this.Controls.Add(this.cmbLesson);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lbSchedule);
            this.Name = "ScheduleEditForm";
            this.Text = "ScheduleEditForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbSchedule;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cmbLesson;
        private System.Windows.Forms.ComboBox cmbSubject;
        private System.Windows.Forms.ComboBox cmbTeacher;
        private System.Windows.Forms.ComboBox cmbRoom;
        private System.Windows.Forms.Label lLesson;
        private System.Windows.Forms.Label lSubject;
        private System.Windows.Forms.Label lTeacher;
        private System.Windows.Forms.Label lRoom;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
    }
}