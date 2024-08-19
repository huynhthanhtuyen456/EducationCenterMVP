namespace EducationCenter.Views.Classes
{
    partial class StudentView
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
            panel1 = new Panel();
            CloseStudentViewBtn = new Label();
            StudentViewLbl = new Label();
            StudentTabControl = new TabControl();
            StudentListTabPage = new TabPage();
            SearchStudentBtn = new Button();
            SearchStudentTxb = new TextBox();
            EnrollStudentSubjectBtn = new Button();
            DeleteStudentBtn = new Button();
            EditStudentBtn = new Button();
            AddStudentBtn = new Button();
            StudentListDgv = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fullNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            emailDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            telephoneDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            genderDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dateOfBirthDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ageDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            studentBindingSource = new BindingSource(components);
            StudentDetailTabPage = new TabPage();
            StudyingSubjectLbl = new Label();
            StudiedSubjectLbl = new Label();
            StudyingSubjectsDgv = new DataGridView();
            StudiedSubjectsDgv = new DataGridView();
            StudentBasicInfoGroupBox = new GroupBox();
            StudentGenderComboBox = new ComboBox();
            GenderLbl = new Label();
            CancelStudentBtn = new Button();
            SaveStudentBtn = new Button();
            StudentAgeTxb = new TextBox();
            AgeLbl = new Label();
            StudentDOBDatePicker = new DateTimePicker();
            DOBLbl = new Label();
            StudentTelephoneTxb = new TextBox();
            TelephoneLbl = new Label();
            StudentEmailTxb = new TextBox();
            EmailLbl = new Label();
            StudentLastNameTxb = new TextBox();
            LastNameLbl = new Label();
            StudentFirstNameTxb = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            StudentTabControl.SuspendLayout();
            StudentListTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)StudentListDgv).BeginInit();
            ((System.ComponentModel.ISupportInitialize)studentBindingSource).BeginInit();
            StudentDetailTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)StudyingSubjectsDgv).BeginInit();
            ((System.ComponentModel.ISupportInitialize)StudiedSubjectsDgv).BeginInit();
            StudentBasicInfoGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(CloseStudentViewBtn);
            panel1.Controls.Add(StudentViewLbl);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 100);
            panel1.TabIndex = 0;
            // 
            // CloseStudentViewBtn
            // 
            CloseStudentViewBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            CloseStudentViewBtn.AutoSize = true;
            CloseStudentViewBtn.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CloseStudentViewBtn.Location = new Point(761, 9);
            CloseStudentViewBtn.Name = "CloseStudentViewBtn";
            CloseStudentViewBtn.Size = new Size(27, 30);
            CloseStudentViewBtn.TabIndex = 1;
            CloseStudentViewBtn.Text = "X";
            // 
            // StudentViewLbl
            // 
            StudentViewLbl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            StudentViewLbl.AutoSize = true;
            StudentViewLbl.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            StudentViewLbl.Location = new Point(309, 21);
            StudentViewLbl.Name = "StudentViewLbl";
            StudentViewLbl.Size = new Size(136, 45);
            StudentViewLbl.TabIndex = 0;
            StudentViewLbl.Text = "Student";
            // 
            // StudentTabControl
            // 
            StudentTabControl.Controls.Add(StudentListTabPage);
            StudentTabControl.Controls.Add(StudentDetailTabPage);
            StudentTabControl.Dock = DockStyle.Fill;
            StudentTabControl.Location = new Point(0, 100);
            StudentTabControl.Name = "StudentTabControl";
            StudentTabControl.SelectedIndex = 0;
            StudentTabControl.Size = new Size(800, 350);
            StudentTabControl.TabIndex = 1;
            // 
            // StudentListTabPage
            // 
            StudentListTabPage.Controls.Add(SearchStudentBtn);
            StudentListTabPage.Controls.Add(SearchStudentTxb);
            StudentListTabPage.Controls.Add(EnrollStudentSubjectBtn);
            StudentListTabPage.Controls.Add(DeleteStudentBtn);
            StudentListTabPage.Controls.Add(EditStudentBtn);
            StudentListTabPage.Controls.Add(AddStudentBtn);
            StudentListTabPage.Controls.Add(StudentListDgv);
            StudentListTabPage.Location = new Point(4, 24);
            StudentListTabPage.Name = "StudentListTabPage";
            StudentListTabPage.Padding = new Padding(3);
            StudentListTabPage.Size = new Size(792, 322);
            StudentListTabPage.TabIndex = 0;
            StudentListTabPage.Text = "Student List";
            StudentListTabPage.UseVisualStyleBackColor = true;
            // 
            // SearchStudentBtn
            // 
            SearchStudentBtn.BackColor = Color.FromArgb(255, 128, 0);
            SearchStudentBtn.Cursor = Cursors.Hand;
            SearchStudentBtn.FlatAppearance.BorderSize = 0;
            SearchStudentBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 224, 192);
            SearchStudentBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 192, 128);
            SearchStudentBtn.FlatStyle = FlatStyle.Flat;
            SearchStudentBtn.Location = new Point(252, 6);
            SearchStudentBtn.Name = "SearchStudentBtn";
            SearchStudentBtn.Size = new Size(75, 23);
            SearchStudentBtn.TabIndex = 7;
            SearchStudentBtn.Text = "Search";
            SearchStudentBtn.UseVisualStyleBackColor = false;
            // 
            // SearchStudentTxb
            // 
            SearchStudentTxb.Location = new Point(8, 6);
            SearchStudentTxb.Name = "SearchStudentTxb";
            SearchStudentTxb.Size = new Size(238, 23);
            SearchStudentTxb.TabIndex = 6;
            // 
            // EnrollStudentSubjectBtn
            // 
            EnrollStudentSubjectBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            EnrollStudentSubjectBtn.BackColor = Color.FromArgb(255, 128, 0);
            EnrollStudentSubjectBtn.Cursor = Cursors.Hand;
            EnrollStudentSubjectBtn.FlatAppearance.BorderSize = 0;
            EnrollStudentSubjectBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 224, 192);
            EnrollStudentSubjectBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 192, 128);
            EnrollStudentSubjectBtn.FlatStyle = FlatStyle.Flat;
            EnrollStudentSubjectBtn.Location = new Point(709, 122);
            EnrollStudentSubjectBtn.Name = "EnrollStudentSubjectBtn";
            EnrollStudentSubjectBtn.Size = new Size(75, 23);
            EnrollStudentSubjectBtn.TabIndex = 4;
            EnrollStudentSubjectBtn.Text = "Enroll";
            EnrollStudentSubjectBtn.UseVisualStyleBackColor = false;
            // 
            // DeleteStudentBtn
            // 
            DeleteStudentBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            DeleteStudentBtn.BackColor = Color.Red;
            DeleteStudentBtn.Cursor = Cursors.Hand;
            DeleteStudentBtn.FlatAppearance.BorderSize = 0;
            DeleteStudentBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 192, 192);
            DeleteStudentBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 128);
            DeleteStudentBtn.FlatStyle = FlatStyle.Flat;
            DeleteStudentBtn.Location = new Point(709, 93);
            DeleteStudentBtn.Name = "DeleteStudentBtn";
            DeleteStudentBtn.Size = new Size(75, 23);
            DeleteStudentBtn.TabIndex = 3;
            DeleteStudentBtn.Text = "Delete";
            DeleteStudentBtn.UseVisualStyleBackColor = false;
            // 
            // EditStudentBtn
            // 
            EditStudentBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            EditStudentBtn.BackColor = Color.Yellow;
            EditStudentBtn.Cursor = Cursors.Hand;
            EditStudentBtn.FlatAppearance.BorderSize = 0;
            EditStudentBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 255, 192);
            EditStudentBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 255, 128);
            EditStudentBtn.FlatStyle = FlatStyle.Flat;
            EditStudentBtn.Location = new Point(709, 64);
            EditStudentBtn.Name = "EditStudentBtn";
            EditStudentBtn.Size = new Size(75, 23);
            EditStudentBtn.TabIndex = 2;
            EditStudentBtn.Text = "Edit";
            EditStudentBtn.UseVisualStyleBackColor = false;
            // 
            // AddStudentBtn
            // 
            AddStudentBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            AddStudentBtn.BackColor = Color.Lime;
            AddStudentBtn.Cursor = Cursors.Hand;
            AddStudentBtn.FlatAppearance.BorderSize = 0;
            AddStudentBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 255, 192);
            AddStudentBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 255, 128);
            AddStudentBtn.FlatStyle = FlatStyle.Flat;
            AddStudentBtn.Location = new Point(709, 35);
            AddStudentBtn.Name = "AddStudentBtn";
            AddStudentBtn.Size = new Size(75, 23);
            AddStudentBtn.TabIndex = 1;
            AddStudentBtn.Text = "Add";
            AddStudentBtn.UseVisualStyleBackColor = false;
            // 
            // StudentListDgv
            // 
            StudentListDgv.AllowUserToAddRows = false;
            StudentListDgv.AllowUserToDeleteRows = false;
            StudentListDgv.AllowUserToOrderColumns = true;
            StudentListDgv.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            StudentListDgv.AutoGenerateColumns = false;
            StudentListDgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            StudentListDgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            StudentListDgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            StudentListDgv.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, fullNameDataGridViewTextBoxColumn, emailDataGridViewTextBoxColumn, telephoneDataGridViewTextBoxColumn, genderDataGridViewTextBoxColumn, dateOfBirthDataGridViewTextBoxColumn, ageDataGridViewTextBoxColumn });
            StudentListDgv.DataSource = studentBindingSource;
            StudentListDgv.Location = new Point(8, 35);
            StudentListDgv.Name = "StudentListDgv";
            StudentListDgv.ReadOnly = true;
            StudentListDgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            StudentListDgv.Size = new Size(695, 279);
            StudentListDgv.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
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
            emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telephoneDataGridViewTextBoxColumn
            // 
            telephoneDataGridViewTextBoxColumn.DataPropertyName = "Telephone";
            telephoneDataGridViewTextBoxColumn.HeaderText = "Telephone";
            telephoneDataGridViewTextBoxColumn.Name = "telephoneDataGridViewTextBoxColumn";
            telephoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // genderDataGridViewTextBoxColumn
            // 
            genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            genderDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateOfBirthDataGridViewTextBoxColumn
            // 
            dateOfBirthDataGridViewTextBoxColumn.DataPropertyName = "DateOfBirth";
            dateOfBirthDataGridViewTextBoxColumn.HeaderText = "Date Of Birth";
            dateOfBirthDataGridViewTextBoxColumn.Name = "dateOfBirthDataGridViewTextBoxColumn";
            dateOfBirthDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ageDataGridViewTextBoxColumn
            // 
            ageDataGridViewTextBoxColumn.DataPropertyName = "Age";
            ageDataGridViewTextBoxColumn.HeaderText = "Age";
            ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
            ageDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studentBindingSource
            // 
            studentBindingSource.DataSource = typeof(DataLayer.Entities.Students.Student);
            // 
            // StudentDetailTabPage
            // 
            StudentDetailTabPage.Controls.Add(StudyingSubjectLbl);
            StudentDetailTabPage.Controls.Add(StudiedSubjectLbl);
            StudentDetailTabPage.Controls.Add(StudyingSubjectsDgv);
            StudentDetailTabPage.Controls.Add(StudiedSubjectsDgv);
            StudentDetailTabPage.Controls.Add(StudentBasicInfoGroupBox);
            StudentDetailTabPage.Location = new Point(4, 24);
            StudentDetailTabPage.Name = "StudentDetailTabPage";
            StudentDetailTabPage.Padding = new Padding(3);
            StudentDetailTabPage.Size = new Size(792, 322);
            StudentDetailTabPage.TabIndex = 1;
            StudentDetailTabPage.Text = "Student Detail";
            StudentDetailTabPage.UseVisualStyleBackColor = true;
            // 
            // StudyingSubjectLbl
            // 
            StudyingSubjectLbl.AutoSize = true;
            StudyingSubjectLbl.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            StudyingSubjectLbl.Location = new Point(460, 158);
            StudyingSubjectLbl.Name = "StudyingSubjectLbl";
            StudyingSubjectLbl.Size = new Size(106, 15);
            StudyingSubjectLbl.TabIndex = 4;
            StudyingSubjectLbl.Text = "Studying Subjects";
            // 
            // StudiedSubjectLbl
            // 
            StudiedSubjectLbl.AutoSize = true;
            StudiedSubjectLbl.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            StudiedSubjectLbl.Location = new Point(460, 6);
            StudiedSubjectLbl.Name = "StudiedSubjectLbl";
            StudiedSubjectLbl.Size = new Size(100, 15);
            StudiedSubjectLbl.TabIndex = 3;
            StudiedSubjectLbl.Text = "Studied Subjects";
            // 
            // StudyingSubjectsDgv
            // 
            StudyingSubjectsDgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            StudyingSubjectsDgv.Location = new Point(460, 176);
            StudyingSubjectsDgv.Name = "StudyingSubjectsDgv";
            StudyingSubjectsDgv.Size = new Size(324, 138);
            StudyingSubjectsDgv.TabIndex = 2;
            // 
            // StudiedSubjectsDgv
            // 
            StudiedSubjectsDgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            StudiedSubjectsDgv.Location = new Point(460, 24);
            StudiedSubjectsDgv.Name = "StudiedSubjectsDgv";
            StudiedSubjectsDgv.Size = new Size(324, 131);
            StudiedSubjectsDgv.TabIndex = 1;
            // 
            // StudentBasicInfoGroupBox
            // 
            StudentBasicInfoGroupBox.Controls.Add(StudentGenderComboBox);
            StudentBasicInfoGroupBox.Controls.Add(GenderLbl);
            StudentBasicInfoGroupBox.Controls.Add(CancelStudentBtn);
            StudentBasicInfoGroupBox.Controls.Add(SaveStudentBtn);
            StudentBasicInfoGroupBox.Controls.Add(StudentAgeTxb);
            StudentBasicInfoGroupBox.Controls.Add(AgeLbl);
            StudentBasicInfoGroupBox.Controls.Add(StudentDOBDatePicker);
            StudentBasicInfoGroupBox.Controls.Add(DOBLbl);
            StudentBasicInfoGroupBox.Controls.Add(StudentTelephoneTxb);
            StudentBasicInfoGroupBox.Controls.Add(TelephoneLbl);
            StudentBasicInfoGroupBox.Controls.Add(StudentEmailTxb);
            StudentBasicInfoGroupBox.Controls.Add(EmailLbl);
            StudentBasicInfoGroupBox.Controls.Add(StudentLastNameTxb);
            StudentBasicInfoGroupBox.Controls.Add(LastNameLbl);
            StudentBasicInfoGroupBox.Controls.Add(StudentFirstNameTxb);
            StudentBasicInfoGroupBox.Controls.Add(label1);
            StudentBasicInfoGroupBox.Location = new Point(8, 6);
            StudentBasicInfoGroupBox.Name = "StudentBasicInfoGroupBox";
            StudentBasicInfoGroupBox.Size = new Size(446, 308);
            StudentBasicInfoGroupBox.TabIndex = 0;
            StudentBasicInfoGroupBox.TabStop = false;
            StudentBasicInfoGroupBox.Text = "Basic Information";
            // 
            // StudentGenderComboBox
            // 
            StudentGenderComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            StudentGenderComboBox.FormattingEnabled = true;
            StudentGenderComboBox.Location = new Point(289, 162);
            StudentGenderComboBox.Name = "StudentGenderComboBox";
            StudentGenderComboBox.Size = new Size(144, 23);
            StudentGenderComboBox.TabIndex = 15;
            // 
            // GenderLbl
            // 
            GenderLbl.AutoSize = true;
            GenderLbl.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GenderLbl.Location = new Point(218, 165);
            GenderLbl.Name = "GenderLbl";
            GenderLbl.Size = new Size(49, 15);
            GenderLbl.TabIndex = 14;
            GenderLbl.Text = "Gender";
            // 
            // CancelStudentBtn
            // 
            CancelStudentBtn.BackColor = SystemColors.ActiveBorder;
            CancelStudentBtn.FlatAppearance.BorderSize = 0;
            CancelStudentBtn.FlatAppearance.MouseDownBackColor = SystemColors.ControlDark;
            CancelStudentBtn.FlatAppearance.MouseOverBackColor = SystemColors.ControlDarkDark;
            CancelStudentBtn.FlatStyle = FlatStyle.Flat;
            CancelStudentBtn.Location = new Point(160, 217);
            CancelStudentBtn.Name = "CancelStudentBtn";
            CancelStudentBtn.Size = new Size(75, 23);
            CancelStudentBtn.TabIndex = 13;
            CancelStudentBtn.Text = "Cancel";
            CancelStudentBtn.UseVisualStyleBackColor = false;
            // 
            // SaveStudentBtn
            // 
            SaveStudentBtn.BackColor = SystemColors.ActiveCaption;
            SaveStudentBtn.FlatAppearance.BorderSize = 0;
            SaveStudentBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 192, 255);
            SaveStudentBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 128, 255);
            SaveStudentBtn.FlatStyle = FlatStyle.Flat;
            SaveStudentBtn.Location = new Point(79, 217);
            SaveStudentBtn.Name = "SaveStudentBtn";
            SaveStudentBtn.Size = new Size(75, 23);
            SaveStudentBtn.TabIndex = 12;
            SaveStudentBtn.Text = "Save";
            SaveStudentBtn.UseVisualStyleBackColor = false;
            // 
            // StudentAgeTxb
            // 
            StudentAgeTxb.Location = new Point(79, 162);
            StudentAgeTxb.Name = "StudentAgeTxb";
            StudentAgeTxb.ReadOnly = true;
            StudentAgeTxb.Size = new Size(133, 23);
            StudentAgeTxb.TabIndex = 11;
            // 
            // AgeLbl
            // 
            AgeLbl.AutoSize = true;
            AgeLbl.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AgeLbl.Location = new Point(6, 170);
            AgeLbl.Name = "AgeLbl";
            AgeLbl.Size = new Size(29, 15);
            AgeLbl.TabIndex = 10;
            AgeLbl.Text = "Age";
            // 
            // StudentDOBDatePicker
            // 
            StudentDOBDatePicker.Location = new Point(94, 118);
            StudentDOBDatePicker.Name = "StudentDOBDatePicker";
            StudentDOBDatePicker.Size = new Size(214, 23);
            StudentDOBDatePicker.TabIndex = 9;
            // 
            // DOBLbl
            // 
            DOBLbl.AutoSize = true;
            DOBLbl.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DOBLbl.Location = new Point(6, 124);
            DOBLbl.Name = "DOBLbl";
            DOBLbl.Size = new Size(82, 15);
            DOBLbl.TabIndex = 8;
            DOBLbl.Text = "Date Of Birth";
            // 
            // StudentTelephoneTxb
            // 
            StudentTelephoneTxb.Location = new Point(289, 70);
            StudentTelephoneTxb.Name = "StudentTelephoneTxb";
            StudentTelephoneTxb.Size = new Size(144, 23);
            StudentTelephoneTxb.TabIndex = 7;
            // 
            // TelephoneLbl
            // 
            TelephoneLbl.AutoSize = true;
            TelephoneLbl.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TelephoneLbl.Location = new Point(218, 73);
            TelephoneLbl.Name = "TelephoneLbl";
            TelephoneLbl.Size = new Size(65, 15);
            TelephoneLbl.TabIndex = 6;
            TelephoneLbl.Text = "Telephone";
            // 
            // StudentEmailTxb
            // 
            StudentEmailTxb.Location = new Point(79, 70);
            StudentEmailTxb.Name = "StudentEmailTxb";
            StudentEmailTxb.Size = new Size(133, 23);
            StudentEmailTxb.TabIndex = 5;
            // 
            // EmailLbl
            // 
            EmailLbl.AutoSize = true;
            EmailLbl.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EmailLbl.Location = new Point(6, 73);
            EmailLbl.Name = "EmailLbl";
            EmailLbl.Size = new Size(36, 15);
            EmailLbl.TabIndex = 4;
            EmailLbl.Text = "Email";
            // 
            // StudentLastNameTxb
            // 
            StudentLastNameTxb.Location = new Point(289, 22);
            StudentLastNameTxb.Name = "StudentLastNameTxb";
            StudentLastNameTxb.Size = new Size(144, 23);
            StudentLastNameTxb.TabIndex = 3;
            // 
            // LastNameLbl
            // 
            LastNameLbl.AutoSize = true;
            LastNameLbl.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LastNameLbl.Location = new Point(218, 25);
            LastNameLbl.Name = "LastNameLbl";
            LastNameLbl.Size = new Size(65, 15);
            LastNameLbl.TabIndex = 2;
            LastNameLbl.Text = "Last Name";
            // 
            // StudentFirstNameTxb
            // 
            StudentFirstNameTxb.Location = new Point(79, 22);
            StudentFirstNameTxb.Name = "StudentFirstNameTxb";
            StudentFirstNameTxb.Size = new Size(133, 23);
            StudentFirstNameTxb.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(6, 25);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 0;
            label1.Text = "First Name";
            // 
            // StudentView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(StudentTabControl);
            Controls.Add(panel1);
            Name = "StudentView";
            Text = "StudentView";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            StudentTabControl.ResumeLayout(false);
            StudentListTabPage.ResumeLayout(false);
            StudentListTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)StudentListDgv).EndInit();
            ((System.ComponentModel.ISupportInitialize)studentBindingSource).EndInit();
            StudentDetailTabPage.ResumeLayout(false);
            StudentDetailTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)StudyingSubjectsDgv).EndInit();
            ((System.ComponentModel.ISupportInitialize)StudiedSubjectsDgv).EndInit();
            StudentBasicInfoGroupBox.ResumeLayout(false);
            StudentBasicInfoGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label StudentViewLbl;
        private TabControl StudentTabControl;
        private TabPage StudentListTabPage;
        private TabPage StudentDetailTabPage;
        private DataGridView StudentListDgv;
        private Button SearchStudentBtn;
        private TextBox SearchStudentTxb;
        private Button EnrollStudentSubjectBtn;
        private Button DeleteStudentBtn;
        private Button EditStudentBtn;
        private Button AddStudentBtn;
        private GroupBox StudentBasicInfoGroupBox;
        private DataGridView StudyingSubjectsDgv;
        private DataGridView StudiedSubjectsDgv;
        private Label StudyingSubjectLbl;
        private Label StudiedSubjectLbl;
        private Label label1;
        private Label DOBLbl;
        private TextBox StudentTelephoneTxb;
        private Label TelephoneLbl;
        private TextBox StudentEmailTxb;
        private Label EmailLbl;
        private TextBox StudentLastNameTxb;
        private Label LastNameLbl;
        private TextBox StudentFirstNameTxb;
        private TextBox StudentAgeTxb;
        private Label AgeLbl;
        private DateTimePicker StudentDOBDatePicker;
        private Button CancelStudentBtn;
        private Button SaveStudentBtn;
        private ComboBox StudentGenderComboBox;
        private Label GenderLbl;
        private Label CloseStudentViewBtn;
        private BindingSource studentBindingSource;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn telephoneDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dateOfBirthDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
    }
}