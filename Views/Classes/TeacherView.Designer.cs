namespace EducationCenter
{
    partial class TeacherView
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
            components = new System.ComponentModel.Container();
            TeacherLbl = new Label();
            TecherPanel = new Panel();
            CloseTeacherFormBtn = new Label();
            TeacherTabControl = new TabControl();
            TeacherListTabPage = new TabPage();
            AssignSubjectBtn = new Button();
            DeleteTeacherBtn = new Button();
            EditTeacherBtn = new Button();
            AddTeacherBtn = new Button();
            SearchTeacherBtn = new Button();
            TchSearchValTxb = new TextBox();
            TeacherDGView = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fullNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            emailDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            telephoneDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dateOfBirthDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ageDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            genderDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            teacherBindingSource = new BindingSource(components);
            TeacherDetailTabPage = new TabPage();
            TchCancelBtn = new Button();
            TchSaveBtn = new Button();
            TeachingSubjectsLbl = new Label();
            TaughtSubjects = new Label();
            dataGridView3 = new DataGridView();
            dataGridView2 = new DataGridView();
            TeachingInfoGroupBox = new GroupBox();
            TeacherTelephoneTxb = new TextBox();
            TelephoneLbl = new Label();
            TeacherSalaryTxb = new TextBox();
            TchSalaryLbl = new Label();
            TchEmailLbl = new Label();
            TchEmailTxb = new TextBox();
            PersonalInfiGroupBox = new GroupBox();
            TeacherGenderCbox = new ComboBox();
            GenderLbl = new Label();
            TchAgeTxb = new TextBox();
            TchDOBErrorMsgLbl = new Label();
            TchLastNameErrorMsgLbl = new Label();
            TchAgeLbl = new Label();
            TchFirstNameErrorMsgLbl = new Label();
            TchDOBDatePicker = new DateTimePicker();
            TchDOBLbl = new Label();
            TchLastNameLbl = new Label();
            TchFirstNameLbl = new Label();
            TchLastNameTxb = new TextBox();
            TchFirstNameTxb = new TextBox();
            AssignSubjectTabPage = new TabPage();
            AssignSubject1GrpBox = new GroupBox();
            AssignSubject2GrpBox = new GroupBox();
            Subject1Lbl = new Label();
            Subject1ComboBox = new ComboBox();
            FinishedSubject1CheckBox = new CheckBox();
            StudyingSubject1CheckBox = new CheckBox();
            StartDateSubject1Txb = new DateTimePicker();
            StartDateSubject1Lbl = new Label();
            EndDateSubject1Lbl = new Label();
            EndDateSubject1DatePck = new DateTimePicker();
            EndDateSub2DtPck = new DateTimePicker();
            StartDateSub1Lbl = new Label();
            StartDateSub1DtPck = new DateTimePicker();
            StudyingSub2CheckBox = new CheckBox();
            FinishedSub2CheckBox = new CheckBox();
            Subject2Lbl = new Label();
            Subject2Combobox = new ComboBox();
            EndDateSub2Lbl = new Label();
            SaveSub1Btn = new Button();
            CancelSub2Btn = new Button();
            button1 = new Button();
            button2 = new Button();
            TecherPanel.SuspendLayout();
            TeacherTabControl.SuspendLayout();
            TeacherListTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TeacherDGView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)teacherBindingSource).BeginInit();
            TeacherDetailTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            TeachingInfoGroupBox.SuspendLayout();
            PersonalInfiGroupBox.SuspendLayout();
            AssignSubjectTabPage.SuspendLayout();
            AssignSubject1GrpBox.SuspendLayout();
            AssignSubject2GrpBox.SuspendLayout();
            SuspendLayout();
            // 
            // TeacherLbl
            // 
            TeacherLbl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            TeacherLbl.AutoSize = true;
            TeacherLbl.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TeacherLbl.Location = new Point(261, 13);
            TeacherLbl.Name = "TeacherLbl";
            TeacherLbl.Size = new Size(128, 37);
            TeacherLbl.TabIndex = 0;
            TeacherLbl.Text = "Teachers";
            // 
            // TecherPanel
            // 
            TecherPanel.BackColor = SystemColors.ActiveCaption;
            TecherPanel.Controls.Add(CloseTeacherFormBtn);
            TecherPanel.Controls.Add(TeacherLbl);
            TecherPanel.Dock = DockStyle.Top;
            TecherPanel.Location = new Point(0, 0);
            TecherPanel.Name = "TecherPanel";
            TecherPanel.Size = new Size(695, 69);
            TecherPanel.TabIndex = 1;
            // 
            // CloseTeacherFormBtn
            // 
            CloseTeacherFormBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            CloseTeacherFormBtn.AutoSize = true;
            CloseTeacherFormBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CloseTeacherFormBtn.Location = new Point(665, 13);
            CloseTeacherFormBtn.Name = "CloseTeacherFormBtn";
            CloseTeacherFormBtn.Size = new Size(15, 15);
            CloseTeacherFormBtn.TabIndex = 1;
            CloseTeacherFormBtn.Text = "X";
            // 
            // TeacherTabControl
            // 
            TeacherTabControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TeacherTabControl.Controls.Add(TeacherListTabPage);
            TeacherTabControl.Controls.Add(TeacherDetailTabPage);
            TeacherTabControl.Controls.Add(AssignSubjectTabPage);
            TeacherTabControl.Location = new Point(12, 97);
            TeacherTabControl.Name = "TeacherTabControl";
            TeacherTabControl.SelectedIndex = 0;
            TeacherTabControl.Size = new Size(682, 392);
            TeacherTabControl.TabIndex = 2;
            // 
            // TeacherListTabPage
            // 
            TeacherListTabPage.Controls.Add(AssignSubjectBtn);
            TeacherListTabPage.Controls.Add(DeleteTeacherBtn);
            TeacherListTabPage.Controls.Add(EditTeacherBtn);
            TeacherListTabPage.Controls.Add(AddTeacherBtn);
            TeacherListTabPage.Controls.Add(SearchTeacherBtn);
            TeacherListTabPage.Controls.Add(TchSearchValTxb);
            TeacherListTabPage.Controls.Add(TeacherDGView);
            TeacherListTabPage.Location = new Point(4, 24);
            TeacherListTabPage.Name = "TeacherListTabPage";
            TeacherListTabPage.Padding = new Padding(3);
            TeacherListTabPage.Size = new Size(674, 364);
            TeacherListTabPage.TabIndex = 0;
            TeacherListTabPage.Text = "Teacher List";
            TeacherListTabPage.UseVisualStyleBackColor = true;
            // 
            // AssignSubjectBtn
            // 
            AssignSubjectBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            AssignSubjectBtn.BackColor = Color.FromArgb(255, 128, 0);
            AssignSubjectBtn.FlatAppearance.BorderSize = 0;
            AssignSubjectBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 224, 192);
            AssignSubjectBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 192, 128);
            AssignSubjectBtn.FlatStyle = FlatStyle.Flat;
            AssignSubjectBtn.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AssignSubjectBtn.Location = new Point(489, 122);
            AssignSubjectBtn.Name = "AssignSubjectBtn";
            AssignSubjectBtn.Size = new Size(75, 44);
            AssignSubjectBtn.TabIndex = 6;
            AssignSubjectBtn.Text = "Assign Subject";
            AssignSubjectBtn.UseVisualStyleBackColor = false;
            // 
            // DeleteTeacherBtn
            // 
            DeleteTeacherBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            DeleteTeacherBtn.BackColor = Color.Red;
            DeleteTeacherBtn.FlatAppearance.BorderSize = 0;
            DeleteTeacherBtn.FlatStyle = FlatStyle.Flat;
            DeleteTeacherBtn.ForeColor = Color.Black;
            DeleteTeacherBtn.Location = new Point(489, 93);
            DeleteTeacherBtn.Name = "DeleteTeacherBtn";
            DeleteTeacherBtn.Size = new Size(75, 23);
            DeleteTeacherBtn.TabIndex = 5;
            DeleteTeacherBtn.Text = "Delete";
            DeleteTeacherBtn.UseVisualStyleBackColor = false;
            // 
            // EditTeacherBtn
            // 
            EditTeacherBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            EditTeacherBtn.BackColor = Color.Yellow;
            EditTeacherBtn.Cursor = Cursors.Hand;
            EditTeacherBtn.FlatAppearance.BorderSize = 0;
            EditTeacherBtn.FlatStyle = FlatStyle.Flat;
            EditTeacherBtn.Location = new Point(489, 64);
            EditTeacherBtn.Name = "EditTeacherBtn";
            EditTeacherBtn.Size = new Size(75, 23);
            EditTeacherBtn.TabIndex = 4;
            EditTeacherBtn.Text = "Edit";
            EditTeacherBtn.UseVisualStyleBackColor = false;
            // 
            // AddTeacherBtn
            // 
            AddTeacherBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            AddTeacherBtn.BackColor = Color.FromArgb(128, 255, 128);
            AddTeacherBtn.Cursor = Cursors.Hand;
            AddTeacherBtn.FlatAppearance.BorderSize = 0;
            AddTeacherBtn.FlatStyle = FlatStyle.Flat;
            AddTeacherBtn.Location = new Point(489, 35);
            AddTeacherBtn.Name = "AddTeacherBtn";
            AddTeacherBtn.Size = new Size(75, 23);
            AddTeacherBtn.TabIndex = 3;
            AddTeacherBtn.Text = "Add";
            AddTeacherBtn.UseVisualStyleBackColor = false;
            // 
            // SearchTeacherBtn
            // 
            SearchTeacherBtn.BackColor = Color.FromArgb(255, 128, 0);
            SearchTeacherBtn.Cursor = Cursors.Hand;
            SearchTeacherBtn.FlatAppearance.BorderSize = 0;
            SearchTeacherBtn.FlatStyle = FlatStyle.Flat;
            SearchTeacherBtn.Location = new Point(252, 6);
            SearchTeacherBtn.Name = "SearchTeacherBtn";
            SearchTeacherBtn.Size = new Size(75, 23);
            SearchTeacherBtn.TabIndex = 2;
            SearchTeacherBtn.Text = "Search";
            SearchTeacherBtn.UseVisualStyleBackColor = false;
            // 
            // TchSearchValTxb
            // 
            TchSearchValTxb.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            TchSearchValTxb.Location = new Point(3, 6);
            TchSearchValTxb.Name = "TchSearchValTxb";
            TchSearchValTxb.Size = new Size(243, 23);
            TchSearchValTxb.TabIndex = 1;
            // 
            // TeacherDGView
            // 
            TeacherDGView.AllowUserToAddRows = false;
            TeacherDGView.AllowUserToDeleteRows = false;
            TeacherDGView.AllowUserToOrderColumns = true;
            TeacherDGView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TeacherDGView.AutoGenerateColumns = false;
            TeacherDGView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            TeacherDGView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            TeacherDGView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TeacherDGView.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, fullNameDataGridViewTextBoxColumn, emailDataGridViewTextBoxColumn, telephoneDataGridViewTextBoxColumn, dateOfBirthDataGridViewTextBoxColumn, ageDataGridViewTextBoxColumn, genderDataGridViewTextBoxColumn });
            TeacherDGView.DataSource = teacherBindingSource;
            TeacherDGView.Location = new Point(3, 35);
            TeacherDGView.Name = "TeacherDGView";
            TeacherDGView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            TeacherDGView.Size = new Size(480, 323);
            TeacherDGView.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // fullNameDataGridViewTextBoxColumn
            // 
            fullNameDataGridViewTextBoxColumn.DataPropertyName = "FullName";
            fullNameDataGridViewTextBoxColumn.HeaderText = "Name";
            fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
            fullNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            emailDataGridViewTextBoxColumn.HeaderText = "Email Address";
            emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // telephoneDataGridViewTextBoxColumn
            // 
            telephoneDataGridViewTextBoxColumn.DataPropertyName = "Telephone";
            telephoneDataGridViewTextBoxColumn.HeaderText = "Telephone";
            telephoneDataGridViewTextBoxColumn.Name = "telephoneDataGridViewTextBoxColumn";
            // 
            // dateOfBirthDataGridViewTextBoxColumn
            // 
            dateOfBirthDataGridViewTextBoxColumn.DataPropertyName = "DateOfBirth";
            dateOfBirthDataGridViewTextBoxColumn.HeaderText = "Date Of Birth";
            dateOfBirthDataGridViewTextBoxColumn.Name = "dateOfBirthDataGridViewTextBoxColumn";
            // 
            // ageDataGridViewTextBoxColumn
            // 
            ageDataGridViewTextBoxColumn.DataPropertyName = "Age";
            ageDataGridViewTextBoxColumn.HeaderText = "Age";
            ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
            ageDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // genderDataGridViewTextBoxColumn
            // 
            genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            // 
            // teacherBindingSource
            // 
            teacherBindingSource.DataSource = typeof(DataLayer.Entities.Teachers.Teacher);
            // 
            // TeacherDetailTabPage
            // 
            TeacherDetailTabPage.Controls.Add(TchCancelBtn);
            TeacherDetailTabPage.Controls.Add(TchSaveBtn);
            TeacherDetailTabPage.Controls.Add(TeachingSubjectsLbl);
            TeacherDetailTabPage.Controls.Add(TaughtSubjects);
            TeacherDetailTabPage.Controls.Add(dataGridView3);
            TeacherDetailTabPage.Controls.Add(dataGridView2);
            TeacherDetailTabPage.Controls.Add(TeachingInfoGroupBox);
            TeacherDetailTabPage.Controls.Add(PersonalInfiGroupBox);
            TeacherDetailTabPage.Location = new Point(4, 24);
            TeacherDetailTabPage.Name = "TeacherDetailTabPage";
            TeacherDetailTabPage.Padding = new Padding(3);
            TeacherDetailTabPage.Size = new Size(674, 364);
            TeacherDetailTabPage.TabIndex = 1;
            TeacherDetailTabPage.Text = "Teacher Detail";
            TeacherDetailTabPage.UseVisualStyleBackColor = true;
            // 
            // TchCancelBtn
            // 
            TchCancelBtn.BackColor = SystemColors.ActiveBorder;
            TchCancelBtn.FlatAppearance.BorderSize = 0;
            TchCancelBtn.FlatAppearance.MouseDownBackColor = SystemColors.Control;
            TchCancelBtn.FlatAppearance.MouseOverBackColor = SystemColors.ControlDark;
            TchCancelBtn.FlatStyle = FlatStyle.Flat;
            TchCancelBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TchCancelBtn.Location = new Point(87, 279);
            TchCancelBtn.Name = "TchCancelBtn";
            TchCancelBtn.Size = new Size(75, 23);
            TchCancelBtn.TabIndex = 7;
            TchCancelBtn.Text = "Cancel";
            TchCancelBtn.UseVisualStyleBackColor = false;
            // 
            // TchSaveBtn
            // 
            TchSaveBtn.BackColor = SystemColors.ActiveCaption;
            TchSaveBtn.FlatAppearance.BorderSize = 0;
            TchSaveBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 192, 255);
            TchSaveBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 128, 255);
            TchSaveBtn.FlatStyle = FlatStyle.Flat;
            TchSaveBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TchSaveBtn.Location = new Point(6, 279);
            TchSaveBtn.Name = "TchSaveBtn";
            TchSaveBtn.Size = new Size(75, 23);
            TchSaveBtn.TabIndex = 6;
            TchSaveBtn.Text = "Save";
            TchSaveBtn.UseVisualStyleBackColor = false;
            // 
            // TeachingSubjectsLbl
            // 
            TeachingSubjectsLbl.AutoSize = true;
            TeachingSubjectsLbl.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TeachingSubjectsLbl.Location = new Point(395, 183);
            TeachingSubjectsLbl.Name = "TeachingSubjectsLbl";
            TeachingSubjectsLbl.Size = new Size(106, 15);
            TeachingSubjectsLbl.TabIndex = 5;
            TeachingSubjectsLbl.Text = "Teaching Subjects";
            // 
            // TaughtSubjects
            // 
            TaughtSubjects.AutoSize = true;
            TaughtSubjects.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TaughtSubjects.Location = new Point(395, 6);
            TaughtSubjects.Name = "TaughtSubjects";
            TaughtSubjects.Size = new Size(95, 15);
            TaughtSubjects.TabIndex = 4;
            TaughtSubjects.Text = "Taught Subjects";
            // 
            // dataGridView3
            // 
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(395, 201);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.Size = new Size(272, 157);
            dataGridView3.TabIndex = 3;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(395, 25);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(272, 155);
            dataGridView2.TabIndex = 2;
            // 
            // TeachingInfoGroupBox
            // 
            TeachingInfoGroupBox.Controls.Add(TeacherTelephoneTxb);
            TeachingInfoGroupBox.Controls.Add(TelephoneLbl);
            TeachingInfoGroupBox.Controls.Add(TeacherSalaryTxb);
            TeachingInfoGroupBox.Controls.Add(TchSalaryLbl);
            TeachingInfoGroupBox.Controls.Add(TchEmailLbl);
            TeachingInfoGroupBox.Controls.Add(TchEmailTxb);
            TeachingInfoGroupBox.Location = new Point(6, 161);
            TeachingInfoGroupBox.Name = "TeachingInfoGroupBox";
            TeachingInfoGroupBox.Size = new Size(383, 112);
            TeachingInfoGroupBox.TabIndex = 1;
            TeachingInfoGroupBox.TabStop = false;
            TeachingInfoGroupBox.Text = "Teaching Info";
            // 
            // TeacherTelephoneTxb
            // 
            TeacherTelephoneTxb.Location = new Point(277, 19);
            TeacherTelephoneTxb.Name = "TeacherTelephoneTxb";
            TeacherTelephoneTxb.Size = new Size(100, 23);
            TeacherTelephoneTxb.TabIndex = 9;
            // 
            // TelephoneLbl
            // 
            TelephoneLbl.AutoSize = true;
            TelephoneLbl.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TelephoneLbl.Location = new Point(206, 19);
            TelephoneLbl.Name = "TelephoneLbl";
            TelephoneLbl.Size = new Size(65, 15);
            TelephoneLbl.TabIndex = 8;
            TelephoneLbl.Text = "Telephone";
            // 
            // TeacherSalaryTxb
            // 
            TeacherSalaryTxb.Location = new Point(48, 74);
            TeacherSalaryTxb.Name = "TeacherSalaryTxb";
            TeacherSalaryTxb.Size = new Size(100, 23);
            TeacherSalaryTxb.TabIndex = 1;
            // 
            // TchSalaryLbl
            // 
            TchSalaryLbl.AutoSize = true;
            TchSalaryLbl.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TchSalaryLbl.Location = new Point(6, 77);
            TchSalaryLbl.Name = "TchSalaryLbl";
            TchSalaryLbl.Size = new Size(40, 15);
            TchSalaryLbl.TabIndex = 0;
            TchSalaryLbl.Text = "Salary";
            // 
            // TchEmailLbl
            // 
            TchEmailLbl.AutoSize = true;
            TchEmailLbl.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TchEmailLbl.Location = new Point(6, 22);
            TchEmailLbl.Name = "TchEmailLbl";
            TchEmailLbl.Size = new Size(36, 15);
            TchEmailLbl.TabIndex = 6;
            TchEmailLbl.Text = "Email";
            // 
            // TchEmailTxb
            // 
            TchEmailTxb.Location = new Point(48, 19);
            TchEmailTxb.Name = "TchEmailTxb";
            TchEmailTxb.Size = new Size(100, 23);
            TchEmailTxb.TabIndex = 7;
            // 
            // PersonalInfiGroupBox
            // 
            PersonalInfiGroupBox.Controls.Add(TeacherGenderCbox);
            PersonalInfiGroupBox.Controls.Add(GenderLbl);
            PersonalInfiGroupBox.Controls.Add(TchAgeTxb);
            PersonalInfiGroupBox.Controls.Add(TchDOBErrorMsgLbl);
            PersonalInfiGroupBox.Controls.Add(TchLastNameErrorMsgLbl);
            PersonalInfiGroupBox.Controls.Add(TchAgeLbl);
            PersonalInfiGroupBox.Controls.Add(TchFirstNameErrorMsgLbl);
            PersonalInfiGroupBox.Controls.Add(TchDOBDatePicker);
            PersonalInfiGroupBox.Controls.Add(TchDOBLbl);
            PersonalInfiGroupBox.Controls.Add(TchLastNameLbl);
            PersonalInfiGroupBox.Controls.Add(TchFirstNameLbl);
            PersonalInfiGroupBox.Controls.Add(TchLastNameTxb);
            PersonalInfiGroupBox.Controls.Add(TchFirstNameTxb);
            PersonalInfiGroupBox.Location = new Point(6, 6);
            PersonalInfiGroupBox.Name = "PersonalInfiGroupBox";
            PersonalInfiGroupBox.Size = new Size(383, 149);
            PersonalInfiGroupBox.TabIndex = 0;
            PersonalInfiGroupBox.TabStop = false;
            PersonalInfiGroupBox.Text = "Basic Information";
            // 
            // TeacherGenderCbox
            // 
            TeacherGenderCbox.FormattingEnabled = true;
            TeacherGenderCbox.Location = new Point(277, 109);
            TeacherGenderCbox.Name = "TeacherGenderCbox";
            TeacherGenderCbox.Size = new Size(100, 23);
            TeacherGenderCbox.TabIndex = 14;
            // 
            // GenderLbl
            // 
            GenderLbl.AutoSize = true;
            GenderLbl.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GenderLbl.Location = new Point(206, 117);
            GenderLbl.Name = "GenderLbl";
            GenderLbl.Size = new Size(49, 15);
            GenderLbl.TabIndex = 13;
            GenderLbl.Text = "Gender";
            // 
            // TchAgeTxb
            // 
            TchAgeTxb.Location = new Point(79, 114);
            TchAgeTxb.Name = "TchAgeTxb";
            TchAgeTxb.ReadOnly = true;
            TchAgeTxb.Size = new Size(100, 23);
            TchAgeTxb.TabIndex = 12;
            // 
            // TchDOBErrorMsgLbl
            // 
            TchDOBErrorMsgLbl.AutoSize = true;
            TchDOBErrorMsgLbl.ForeColor = Color.Red;
            TchDOBErrorMsgLbl.Location = new Point(94, 89);
            TchDOBErrorMsgLbl.Name = "TchDOBErrorMsgLbl";
            TchDOBErrorMsgLbl.Size = new Size(0, 15);
            TchDOBErrorMsgLbl.TabIndex = 10;
            // 
            // TchLastNameErrorMsgLbl
            // 
            TchLastNameErrorMsgLbl.AutoSize = true;
            TchLastNameErrorMsgLbl.ForeColor = Color.Red;
            TchLastNameErrorMsgLbl.Location = new Point(206, 42);
            TchLastNameErrorMsgLbl.Name = "TchLastNameErrorMsgLbl";
            TchLastNameErrorMsgLbl.Size = new Size(0, 15);
            TchLastNameErrorMsgLbl.TabIndex = 9;
            // 
            // TchAgeLbl
            // 
            TchAgeLbl.AutoSize = true;
            TchAgeLbl.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TchAgeLbl.Location = new Point(6, 117);
            TchAgeLbl.Name = "TchAgeLbl";
            TchAgeLbl.Size = new Size(29, 15);
            TchAgeLbl.TabIndex = 11;
            TchAgeLbl.Text = "Age";
            // 
            // TchFirstNameErrorMsgLbl
            // 
            TchFirstNameErrorMsgLbl.AutoSize = true;
            TchFirstNameErrorMsgLbl.ForeColor = Color.Red;
            TchFirstNameErrorMsgLbl.Location = new Point(6, 42);
            TchFirstNameErrorMsgLbl.Name = "TchFirstNameErrorMsgLbl";
            TchFirstNameErrorMsgLbl.Size = new Size(0, 15);
            TchFirstNameErrorMsgLbl.TabIndex = 8;
            // 
            // TchDOBDatePicker
            // 
            TchDOBDatePicker.Location = new Point(94, 63);
            TchDOBDatePicker.Name = "TchDOBDatePicker";
            TchDOBDatePicker.Size = new Size(283, 23);
            TchDOBDatePicker.TabIndex = 5;
            // 
            // TchDOBLbl
            // 
            TchDOBLbl.AutoSize = true;
            TchDOBLbl.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TchDOBLbl.Location = new Point(6, 69);
            TchDOBLbl.Name = "TchDOBLbl";
            TchDOBLbl.Size = new Size(82, 15);
            TchDOBLbl.TabIndex = 4;
            TchDOBLbl.Text = "Date Of Birth";
            // 
            // TchLastNameLbl
            // 
            TchLastNameLbl.AutoSize = true;
            TchLastNameLbl.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TchLastNameLbl.Location = new Point(206, 16);
            TchLastNameLbl.Name = "TchLastNameLbl";
            TchLastNameLbl.Size = new Size(65, 15);
            TchLastNameLbl.TabIndex = 3;
            TchLastNameLbl.Text = "Last Name";
            // 
            // TchFirstNameLbl
            // 
            TchFirstNameLbl.AutoSize = true;
            TchFirstNameLbl.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TchFirstNameLbl.Location = new Point(6, 19);
            TchFirstNameLbl.Name = "TchFirstNameLbl";
            TchFirstNameLbl.Size = new Size(67, 15);
            TchFirstNameLbl.TabIndex = 2;
            TchFirstNameLbl.Text = "First Name";
            // 
            // TchLastNameTxb
            // 
            TchLastNameTxb.Location = new Point(277, 16);
            TchLastNameTxb.Name = "TchLastNameTxb";
            TchLastNameTxb.Size = new Size(100, 23);
            TchLastNameTxb.TabIndex = 1;
            // 
            // TchFirstNameTxb
            // 
            TchFirstNameTxb.Location = new Point(79, 16);
            TchFirstNameTxb.Name = "TchFirstNameTxb";
            TchFirstNameTxb.Size = new Size(100, 23);
            TchFirstNameTxb.TabIndex = 0;
            // 
            // AssignSubjectTabPage
            // 
            AssignSubjectTabPage.Controls.Add(AssignSubject2GrpBox);
            AssignSubjectTabPage.Controls.Add(AssignSubject1GrpBox);
            AssignSubjectTabPage.Location = new Point(4, 24);
            AssignSubjectTabPage.Name = "AssignSubjectTabPage";
            AssignSubjectTabPage.Padding = new Padding(3);
            AssignSubjectTabPage.Size = new Size(674, 364);
            AssignSubjectTabPage.TabIndex = 2;
            AssignSubjectTabPage.Text = "Assign Subject";
            AssignSubjectTabPage.UseVisualStyleBackColor = true;
            // 
            // AssignSubject1GrpBox
            // 
            AssignSubject1GrpBox.Controls.Add(CancelSub2Btn);
            AssignSubject1GrpBox.Controls.Add(SaveSub1Btn);
            AssignSubject1GrpBox.Controls.Add(EndDateSubject1DatePck);
            AssignSubject1GrpBox.Controls.Add(EndDateSubject1Lbl);
            AssignSubject1GrpBox.Controls.Add(StartDateSubject1Lbl);
            AssignSubject1GrpBox.Controls.Add(StartDateSubject1Txb);
            AssignSubject1GrpBox.Controls.Add(StudyingSubject1CheckBox);
            AssignSubject1GrpBox.Controls.Add(FinishedSubject1CheckBox);
            AssignSubject1GrpBox.Controls.Add(Subject1ComboBox);
            AssignSubject1GrpBox.Controls.Add(Subject1Lbl);
            AssignSubject1GrpBox.Location = new Point(6, 6);
            AssignSubject1GrpBox.Name = "AssignSubject1GrpBox";
            AssignSubject1GrpBox.Size = new Size(658, 165);
            AssignSubject1GrpBox.TabIndex = 0;
            AssignSubject1GrpBox.TabStop = false;
            AssignSubject1GrpBox.Text = "Subject 1";
            // 
            // AssignSubject2GrpBox
            // 
            AssignSubject2GrpBox.Controls.Add(button1);
            AssignSubject2GrpBox.Controls.Add(button2);
            AssignSubject2GrpBox.Controls.Add(EndDateSub2Lbl);
            AssignSubject2GrpBox.Controls.Add(Subject2Combobox);
            AssignSubject2GrpBox.Controls.Add(EndDateSub2DtPck);
            AssignSubject2GrpBox.Controls.Add(StartDateSub1Lbl);
            AssignSubject2GrpBox.Controls.Add(StartDateSub1DtPck);
            AssignSubject2GrpBox.Controls.Add(StudyingSub2CheckBox);
            AssignSubject2GrpBox.Controls.Add(FinishedSub2CheckBox);
            AssignSubject2GrpBox.Controls.Add(Subject2Lbl);
            AssignSubject2GrpBox.Location = new Point(6, 177);
            AssignSubject2GrpBox.Name = "AssignSubject2GrpBox";
            AssignSubject2GrpBox.Size = new Size(658, 181);
            AssignSubject2GrpBox.TabIndex = 1;
            AssignSubject2GrpBox.TabStop = false;
            AssignSubject2GrpBox.Text = "Subject 2";
            // 
            // Subject1Lbl
            // 
            Subject1Lbl.AutoSize = true;
            Subject1Lbl.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Subject1Lbl.Location = new Point(0, 24);
            Subject1Lbl.Name = "Subject1Lbl";
            Subject1Lbl.Size = new Size(49, 15);
            Subject1Lbl.TabIndex = 0;
            Subject1Lbl.Text = "Subject";
            // 
            // Subject1ComboBox
            // 
            Subject1ComboBox.FormattingEnabled = true;
            Subject1ComboBox.Location = new Point(53, 20);
            Subject1ComboBox.Name = "Subject1ComboBox";
            Subject1ComboBox.Size = new Size(121, 23);
            Subject1ComboBox.TabIndex = 1;
            // 
            // FinishedSubject1CheckBox
            // 
            FinishedSubject1CheckBox.AutoSize = true;
            FinishedSubject1CheckBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FinishedSubject1CheckBox.Location = new Point(213, 23);
            FinishedSubject1CheckBox.Name = "FinishedSubject1CheckBox";
            FinishedSubject1CheckBox.Size = new Size(71, 19);
            FinishedSubject1CheckBox.TabIndex = 2;
            FinishedSubject1CheckBox.Text = "Finished";
            FinishedSubject1CheckBox.UseVisualStyleBackColor = true;
            // 
            // StudyingSubject1CheckBox
            // 
            StudyingSubject1CheckBox.AutoSize = true;
            StudyingSubject1CheckBox.Enabled = false;
            StudyingSubject1CheckBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            StudyingSubject1CheckBox.Location = new Point(290, 23);
            StudyingSubject1CheckBox.Name = "StudyingSubject1CheckBox";
            StudyingSubject1CheckBox.Size = new Size(75, 19);
            StudyingSubject1CheckBox.TabIndex = 3;
            StudyingSubject1CheckBox.Text = "Studying";
            StudyingSubject1CheckBox.UseVisualStyleBackColor = true;
            // 
            // StartDateSubject1Txb
            // 
            StartDateSubject1Txb.Location = new Point(68, 72);
            StartDateSubject1Txb.Name = "StartDateSubject1Txb";
            StartDateSubject1Txb.Size = new Size(216, 23);
            StartDateSubject1Txb.TabIndex = 4;
            // 
            // StartDateSubject1Lbl
            // 
            StartDateSubject1Lbl.AutoSize = true;
            StartDateSubject1Lbl.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            StartDateSubject1Lbl.Location = new Point(0, 78);
            StartDateSubject1Lbl.Name = "StartDateSubject1Lbl";
            StartDateSubject1Lbl.Size = new Size(62, 15);
            StartDateSubject1Lbl.TabIndex = 5;
            StartDateSubject1Lbl.Text = "StartDate";
            // 
            // EndDateSubject1Lbl
            // 
            EndDateSubject1Lbl.AutoSize = true;
            EndDateSubject1Lbl.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EndDateSubject1Lbl.Location = new Point(290, 78);
            EndDateSubject1Lbl.Name = "EndDateSubject1Lbl";
            EndDateSubject1Lbl.Size = new Size(54, 15);
            EndDateSubject1Lbl.TabIndex = 6;
            EndDateSubject1Lbl.Text = "EndDate";
            // 
            // EndDateSubject1DatePck
            // 
            EndDateSubject1DatePck.Location = new Point(350, 72);
            EndDateSubject1DatePck.Name = "EndDateSubject1DatePck";
            EndDateSubject1DatePck.Size = new Size(206, 23);
            EndDateSubject1DatePck.TabIndex = 7;
            // 
            // EndDateSub2DtPck
            // 
            EndDateSub2DtPck.Location = new Point(350, 78);
            EndDateSub2DtPck.Name = "EndDateSub2DtPck";
            EndDateSub2DtPck.Size = new Size(206, 23);
            EndDateSub2DtPck.TabIndex = 13;
            // 
            // StartDateSub1Lbl
            // 
            StartDateSub1Lbl.AutoSize = true;
            StartDateSub1Lbl.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            StartDateSub1Lbl.Location = new Point(6, 84);
            StartDateSub1Lbl.Name = "StartDateSub1Lbl";
            StartDateSub1Lbl.Size = new Size(62, 15);
            StartDateSub1Lbl.TabIndex = 12;
            StartDateSub1Lbl.Text = "StartDate";
            // 
            // StartDateSub1DtPck
            // 
            StartDateSub1DtPck.Location = new Point(68, 78);
            StartDateSub1DtPck.Name = "StartDateSub1DtPck";
            StartDateSub1DtPck.Size = new Size(216, 23);
            StartDateSub1DtPck.TabIndex = 11;
            // 
            // StudyingSub2CheckBox
            // 
            StudyingSub2CheckBox.AutoSize = true;
            StudyingSub2CheckBox.Enabled = false;
            StudyingSub2CheckBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            StudyingSub2CheckBox.Location = new Point(290, 19);
            StudyingSub2CheckBox.Name = "StudyingSub2CheckBox";
            StudyingSub2CheckBox.Size = new Size(75, 19);
            StudyingSub2CheckBox.TabIndex = 10;
            StudyingSub2CheckBox.Text = "Studying";
            StudyingSub2CheckBox.UseVisualStyleBackColor = true;
            // 
            // FinishedSub2CheckBox
            // 
            FinishedSub2CheckBox.AutoSize = true;
            FinishedSub2CheckBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FinishedSub2CheckBox.Location = new Point(213, 20);
            FinishedSub2CheckBox.Name = "FinishedSub2CheckBox";
            FinishedSub2CheckBox.Size = new Size(71, 19);
            FinishedSub2CheckBox.TabIndex = 9;
            FinishedSub2CheckBox.Text = "Finished";
            FinishedSub2CheckBox.UseVisualStyleBackColor = true;
            // 
            // Subject2Lbl
            // 
            Subject2Lbl.AutoSize = true;
            Subject2Lbl.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Subject2Lbl.Location = new Point(6, 19);
            Subject2Lbl.Name = "Subject2Lbl";
            Subject2Lbl.Size = new Size(49, 15);
            Subject2Lbl.TabIndex = 8;
            Subject2Lbl.Text = "Subject";
            // 
            // Subject2Combobox
            // 
            Subject2Combobox.FormattingEnabled = true;
            Subject2Combobox.Location = new Point(61, 16);
            Subject2Combobox.Name = "Subject2Combobox";
            Subject2Combobox.Size = new Size(121, 23);
            Subject2Combobox.TabIndex = 14;
            // 
            // EndDateSub2Lbl
            // 
            EndDateSub2Lbl.AutoSize = true;
            EndDateSub2Lbl.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EndDateSub2Lbl.Location = new Point(290, 84);
            EndDateSub2Lbl.Name = "EndDateSub2Lbl";
            EndDateSub2Lbl.Size = new Size(54, 15);
            EndDateSub2Lbl.TabIndex = 15;
            EndDateSub2Lbl.Text = "EndDate";
            // 
            // SaveSub1Btn
            // 
            SaveSub1Btn.BackColor = Color.Lime;
            SaveSub1Btn.FlatAppearance.BorderSize = 0;
            SaveSub1Btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 255, 192);
            SaveSub1Btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 255, 128);
            SaveSub1Btn.FlatStyle = FlatStyle.Flat;
            SaveSub1Btn.Location = new Point(6, 136);
            SaveSub1Btn.Name = "SaveSub1Btn";
            SaveSub1Btn.Size = new Size(75, 23);
            SaveSub1Btn.TabIndex = 8;
            SaveSub1Btn.Text = "Save";
            SaveSub1Btn.UseVisualStyleBackColor = false;
            // 
            // CancelSub2Btn
            // 
            CancelSub2Btn.Location = new Point(87, 136);
            CancelSub2Btn.Name = "CancelSub2Btn";
            CancelSub2Btn.Size = new Size(75, 23);
            CancelSub2Btn.TabIndex = 9;
            CancelSub2Btn.Text = "Cancel";
            CancelSub2Btn.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(87, 152);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 17;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.BackColor = Color.Lime;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 255, 192);
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 255, 128);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(6, 152);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 16;
            button2.Text = "Save";
            button2.UseVisualStyleBackColor = false;
            // 
            // TeacherView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(695, 491);
            Controls.Add(TeacherTabControl);
            Controls.Add(TecherPanel);
            MinimumSize = new Size(674, 364);
            Name = "TeacherView";
            Text = "TeacherView";
            TecherPanel.ResumeLayout(false);
            TecherPanel.PerformLayout();
            TeacherTabControl.ResumeLayout(false);
            TeacherListTabPage.ResumeLayout(false);
            TeacherListTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)TeacherDGView).EndInit();
            ((System.ComponentModel.ISupportInitialize)teacherBindingSource).EndInit();
            TeacherDetailTabPage.ResumeLayout(false);
            TeacherDetailTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            TeachingInfoGroupBox.ResumeLayout(false);
            TeachingInfoGroupBox.PerformLayout();
            PersonalInfiGroupBox.ResumeLayout(false);
            PersonalInfiGroupBox.PerformLayout();
            AssignSubjectTabPage.ResumeLayout(false);
            AssignSubject1GrpBox.ResumeLayout(false);
            AssignSubject1GrpBox.PerformLayout();
            AssignSubject2GrpBox.ResumeLayout(false);
            AssignSubject2GrpBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label TeacherLbl;
        private Panel TecherPanel;
        private TabControl TeacherTabControl;
        private TabPage TeacherListTabPage;
        private TabPage TeacherDetailTabPage;
        private Button DeleteTeacherBtn;
        private Button EditTeacherBtn;
        private Button AddTeacherBtn;
        private Button SearchTeacherBtn;
        private TextBox TchSearchValTxb;
        private DataGridView TeacherDGView;
        private GroupBox PersonalInfiGroupBox;
        private Label TchLastNameLbl;
        private Label TchFirstNameLbl;
        private TextBox TchLastNameTxb;
        private TextBox TchFirstNameTxb;
        private DateTimePicker TchDOBDatePicker;
        private Label TchDOBLbl;
        private Label TchLastNameErrorMsgLbl;
        private Label TchFirstNameErrorMsgLbl;
        private TextBox TchEmailTxb;
        private Label TchEmailLbl;
        private Label TchDOBErrorMsgLbl;
        private TextBox TchAgeTxb;
        private Label TchAgeLbl;
        private GroupBox TeachingInfoGroupBox;
        private TextBox TeacherSalaryTxb;
        private Label TchSalaryLbl;
        private Label TaughtSubjects;
        private DataGridView dataGridView3;
        private DataGridView dataGridView2;
        private Button TchCancelBtn;
        private Button TchSaveBtn;
        private Label TeachingSubjectsLbl;
        private BindingSource teacherBindingSource;
        private Label CloseTeacherFormBtn;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn telephoneDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dateOfBirthDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private TextBox TeacherTelephoneTxb;
        private Label TelephoneLbl;
        private ComboBox TeacherGenderCbox;
        private Label GenderLbl;
        private Button AssignSubjectBtn;
        private TabPage AssignSubjectTabPage;
        private GroupBox AssignSubject2GrpBox;
        private GroupBox AssignSubject1GrpBox;
        private Label StartDateSubject1Lbl;
        private DateTimePicker StartDateSubject1Txb;
        private CheckBox StudyingSubject1CheckBox;
        private CheckBox FinishedSubject1CheckBox;
        private ComboBox Subject1ComboBox;
        private Label Subject1Lbl;
        private Label EndDateSubject1Lbl;
        private Label EndDateSub2Lbl;
        private ComboBox Subject2Combobox;
        private DateTimePicker EndDateSub2DtPck;
        private Label StartDateSub1Lbl;
        private DateTimePicker StartDateSub1DtPck;
        private CheckBox StudyingSub2CheckBox;
        private CheckBox FinishedSub2CheckBox;
        private Label Subject2Lbl;
        private Button CancelSub2Btn;
        private Button SaveSub1Btn;
        private DateTimePicker EndDateSubject1DatePck;
        private Button button1;
        private Button button2;
    }
}