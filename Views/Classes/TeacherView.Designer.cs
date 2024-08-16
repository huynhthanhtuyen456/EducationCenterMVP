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
            DeleteTeacherBtn = new Button();
            EditTeacherBtn = new Button();
            AddTeacherBtn = new Button();
            SearchTeacherBtn = new Button();
            TchSearchValTxb = new TextBox();
            TeacherDGView = new DataGridView();
            teacherBindingSource = new BindingSource(components);
            TeacherDetailTabPage = new TabPage();
            TchCancelBtn = new Button();
            TchSaveBtn = new Button();
            TeachingSubjectsLbl = new Label();
            TaughtSubjects = new Label();
            dataGridView3 = new DataGridView();
            dataGridView2 = new DataGridView();
            TeachingInfoGroupBox = new GroupBox();
            comboBox1 = new ComboBox();
            TchSalaryType = new Label();
            textBox4 = new TextBox();
            TchSalaryLbl = new Label();
            PersonalInfiGroupBox = new GroupBox();
            TchAgeTxb = new TextBox();
            TchAgeLbl = new Label();
            TchDOBErrorMsgLbl = new Label();
            TchLastNameErrorMsgLbl = new Label();
            TchFirstNameErrorMsgLbl = new Label();
            TchEmailTxb = new TextBox();
            TchEmailLbl = new Label();
            TchDOBDatePicker = new DateTimePicker();
            TchDOBLbl = new Label();
            TchLastNameLbl = new Label();
            TchFirstNameLbl = new Label();
            TchLastNameTxb = new TextBox();
            TchFirstNameTxb = new TextBox();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            firstNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            lastNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dateOfBirthDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            genderDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ageDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            telephoneDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            emailDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            roleDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
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
            SuspendLayout();
            // 
            // TeacherLbl
            // 
            TeacherLbl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            TeacherLbl.AutoSize = true;
            TeacherLbl.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TeacherLbl.Location = new Point(224, 13);
            TeacherLbl.Name = "TeacherLbl";
            TeacherLbl.Size = new Size(128, 37);
            TeacherLbl.TabIndex = 0;
            TeacherLbl.Text = "Teachers";
            // 
            // TecherPanel
            // 
            TecherPanel.Controls.Add(CloseTeacherFormBtn);
            TecherPanel.Controls.Add(TeacherLbl);
            TecherPanel.Dock = DockStyle.Top;
            TecherPanel.Location = new Point(0, 0);
            TecherPanel.Name = "TecherPanel";
            TecherPanel.Size = new Size(621, 69);
            TecherPanel.TabIndex = 1;
            // 
            // CloseTeacherFormBtn
            // 
            CloseTeacherFormBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            CloseTeacherFormBtn.AutoSize = true;
            CloseTeacherFormBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CloseTeacherFormBtn.Location = new Point(591, 13);
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
            TeacherTabControl.Location = new Point(12, 97);
            TeacherTabControl.Name = "TeacherTabControl";
            TeacherTabControl.SelectedIndex = 0;
            TeacherTabControl.Size = new Size(608, 369);
            TeacherTabControl.TabIndex = 2;
            // 
            // TeacherListTabPage
            // 
            TeacherListTabPage.Controls.Add(DeleteTeacherBtn);
            TeacherListTabPage.Controls.Add(EditTeacherBtn);
            TeacherListTabPage.Controls.Add(AddTeacherBtn);
            TeacherListTabPage.Controls.Add(SearchTeacherBtn);
            TeacherListTabPage.Controls.Add(TchSearchValTxb);
            TeacherListTabPage.Controls.Add(TeacherDGView);
            TeacherListTabPage.Location = new Point(4, 24);
            TeacherListTabPage.Name = "TeacherListTabPage";
            TeacherListTabPage.Padding = new Padding(3);
            TeacherListTabPage.Size = new Size(600, 341);
            TeacherListTabPage.TabIndex = 0;
            TeacherListTabPage.Text = "Teacher List";
            TeacherListTabPage.UseVisualStyleBackColor = true;
            // 
            // DeleteTeacherBtn
            // 
            DeleteTeacherBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            DeleteTeacherBtn.Location = new Point(489, 93);
            DeleteTeacherBtn.Name = "DeleteTeacherBtn";
            DeleteTeacherBtn.Size = new Size(75, 23);
            DeleteTeacherBtn.TabIndex = 5;
            DeleteTeacherBtn.Text = "Delete";
            DeleteTeacherBtn.UseVisualStyleBackColor = true;
            // 
            // EditTeacherBtn
            // 
            EditTeacherBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            EditTeacherBtn.Location = new Point(489, 64);
            EditTeacherBtn.Name = "EditTeacherBtn";
            EditTeacherBtn.Size = new Size(75, 23);
            EditTeacherBtn.TabIndex = 4;
            EditTeacherBtn.Text = "Edit";
            EditTeacherBtn.UseVisualStyleBackColor = true;
            // 
            // AddTeacherBtn
            // 
            AddTeacherBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            AddTeacherBtn.Location = new Point(489, 35);
            AddTeacherBtn.Name = "AddTeacherBtn";
            AddTeacherBtn.Size = new Size(75, 23);
            AddTeacherBtn.TabIndex = 3;
            AddTeacherBtn.Text = "Add";
            AddTeacherBtn.UseVisualStyleBackColor = true;
            // 
            // SearchTeacherBtn
            // 
            SearchTeacherBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            SearchTeacherBtn.Location = new Point(408, 6);
            SearchTeacherBtn.Name = "SearchTeacherBtn";
            SearchTeacherBtn.Size = new Size(75, 23);
            SearchTeacherBtn.TabIndex = 2;
            SearchTeacherBtn.Text = "Search";
            SearchTeacherBtn.UseVisualStyleBackColor = true;
            // 
            // TchSearchValTxb
            // 
            TchSearchValTxb.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TchSearchValTxb.Location = new Point(3, 6);
            TchSearchValTxb.Name = "TchSearchValTxb";
            TchSearchValTxb.Size = new Size(399, 23);
            TchSearchValTxb.TabIndex = 1;
            // 
            // TeacherDGView
            // 
            TeacherDGView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TeacherDGView.AutoGenerateColumns = false;
            TeacherDGView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TeacherDGView.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, firstNameDataGridViewTextBoxColumn, lastNameDataGridViewTextBoxColumn, dateOfBirthDataGridViewTextBoxColumn, genderDataGridViewTextBoxColumn, ageDataGridViewTextBoxColumn, telephoneDataGridViewTextBoxColumn, emailDataGridViewTextBoxColumn, roleDataGridViewTextBoxColumn });
            TeacherDGView.DataSource = teacherBindingSource;
            TeacherDGView.Location = new Point(3, 35);
            TeacherDGView.Name = "TeacherDGView";
            TeacherDGView.Size = new Size(480, 303);
            TeacherDGView.TabIndex = 0;
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
            TeacherDetailTabPage.Size = new Size(600, 341);
            TeacherDetailTabPage.TabIndex = 1;
            TeacherDetailTabPage.Text = "Teacher Detail";
            TeacherDetailTabPage.UseVisualStyleBackColor = true;
            // 
            // TchCancelBtn
            // 
            TchCancelBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TchCancelBtn.Location = new Point(87, 231);
            TchCancelBtn.Name = "TchCancelBtn";
            TchCancelBtn.Size = new Size(75, 23);
            TchCancelBtn.TabIndex = 7;
            TchCancelBtn.Text = "Cancel";
            TchCancelBtn.UseVisualStyleBackColor = true;
            // 
            // TchSaveBtn
            // 
            TchSaveBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TchSaveBtn.Location = new Point(6, 231);
            TchSaveBtn.Name = "TchSaveBtn";
            TchSaveBtn.Size = new Size(75, 23);
            TchSaveBtn.TabIndex = 6;
            TchSaveBtn.Text = "Save";
            TchSaveBtn.UseVisualStyleBackColor = true;
            // 
            // TeachingSubjectsLbl
            // 
            TeachingSubjectsLbl.AutoSize = true;
            TeachingSubjectsLbl.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TeachingSubjectsLbl.Location = new Point(410, 163);
            TeachingSubjectsLbl.Name = "TeachingSubjectsLbl";
            TeachingSubjectsLbl.Size = new Size(106, 15);
            TeachingSubjectsLbl.TabIndex = 5;
            TeachingSubjectsLbl.Text = "Teaching Subjects";
            // 
            // TaughtSubjects
            // 
            TaughtSubjects.AutoSize = true;
            TaughtSubjects.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TaughtSubjects.Location = new Point(421, 6);
            TaughtSubjects.Name = "TaughtSubjects";
            TaughtSubjects.Size = new Size(95, 15);
            TaughtSubjects.TabIndex = 4;
            TaughtSubjects.Text = "Taught Subjects";
            // 
            // dataGridView3
            // 
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(522, 163);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.Size = new Size(240, 144);
            dataGridView3.TabIndex = 3;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(522, 6);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(240, 150);
            dataGridView2.TabIndex = 2;
            // 
            // TeachingInfoGroupBox
            // 
            TeachingInfoGroupBox.Controls.Add(comboBox1);
            TeachingInfoGroupBox.Controls.Add(TchSalaryType);
            TeachingInfoGroupBox.Controls.Add(textBox4);
            TeachingInfoGroupBox.Controls.Add(TchSalaryLbl);
            TeachingInfoGroupBox.Location = new Point(6, 161);
            TeachingInfoGroupBox.Name = "TeachingInfoGroupBox";
            TeachingInfoGroupBox.Size = new Size(383, 64);
            TeachingInfoGroupBox.TabIndex = 1;
            TeachingInfoGroupBox.TabStop = false;
            TeachingInfoGroupBox.Text = "Teaching Info";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(256, 22);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 3;
            // 
            // TchSalaryType
            // 
            TchSalaryType.AutoSize = true;
            TchSalaryType.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TchSalaryType.Location = new Point(181, 25);
            TchSalaryType.Name = "TchSalaryType";
            TchSalaryType.Size = new Size(69, 15);
            TchSalaryType.TabIndex = 2;
            TchSalaryType.Text = "Salary Type";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(48, 22);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 1;
            // 
            // TchSalaryLbl
            // 
            TchSalaryLbl.AutoSize = true;
            TchSalaryLbl.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TchSalaryLbl.Location = new Point(6, 25);
            TchSalaryLbl.Name = "TchSalaryLbl";
            TchSalaryLbl.Size = new Size(40, 15);
            TchSalaryLbl.TabIndex = 0;
            TchSalaryLbl.Text = "Salary";
            // 
            // PersonalInfiGroupBox
            // 
            PersonalInfiGroupBox.Controls.Add(TchAgeTxb);
            PersonalInfiGroupBox.Controls.Add(TchAgeLbl);
            PersonalInfiGroupBox.Controls.Add(TchDOBErrorMsgLbl);
            PersonalInfiGroupBox.Controls.Add(TchLastNameErrorMsgLbl);
            PersonalInfiGroupBox.Controls.Add(TchFirstNameErrorMsgLbl);
            PersonalInfiGroupBox.Controls.Add(TchEmailTxb);
            PersonalInfiGroupBox.Controls.Add(TchEmailLbl);
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
            PersonalInfiGroupBox.Text = "Personal Information";
            // 
            // TchAgeTxb
            // 
            TchAgeTxb.Location = new Point(195, 112);
            TchAgeTxb.Name = "TchAgeTxb";
            TchAgeTxb.Size = new Size(100, 23);
            TchAgeTxb.TabIndex = 12;
            // 
            // TchAgeLbl
            // 
            TchAgeLbl.AutoSize = true;
            TchAgeLbl.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TchAgeLbl.Location = new Point(160, 115);
            TchAgeLbl.Name = "TchAgeLbl";
            TchAgeLbl.Size = new Size(29, 15);
            TchAgeLbl.TabIndex = 11;
            TchAgeLbl.Text = "Age";
            // 
            // TchDOBErrorMsgLbl
            // 
            TchDOBErrorMsgLbl.AutoSize = true;
            TchDOBErrorMsgLbl.ForeColor = Color.Red;
            TchDOBErrorMsgLbl.Location = new Point(94, 89);
            TchDOBErrorMsgLbl.Name = "TchDOBErrorMsgLbl";
            TchDOBErrorMsgLbl.Size = new Size(95, 15);
            TchDOBErrorMsgLbl.TabIndex = 10;
            TchDOBErrorMsgLbl.Text = "Invalid DateTime";
            // 
            // TchLastNameErrorMsgLbl
            // 
            TchLastNameErrorMsgLbl.AutoSize = true;
            TchLastNameErrorMsgLbl.ForeColor = Color.Red;
            TchLastNameErrorMsgLbl.Location = new Point(206, 42);
            TchLastNameErrorMsgLbl.Name = "TchLastNameErrorMsgLbl";
            TchLastNameErrorMsgLbl.Size = new Size(101, 15);
            TchLastNameErrorMsgLbl.TabIndex = 9;
            TchLastNameErrorMsgLbl.Text = "Invalid Last Name";
            // 
            // TchFirstNameErrorMsgLbl
            // 
            TchFirstNameErrorMsgLbl.AutoSize = true;
            TchFirstNameErrorMsgLbl.ForeColor = Color.Red;
            TchFirstNameErrorMsgLbl.Location = new Point(6, 42);
            TchFirstNameErrorMsgLbl.Name = "TchFirstNameErrorMsgLbl";
            TchFirstNameErrorMsgLbl.Size = new Size(102, 15);
            TchFirstNameErrorMsgLbl.TabIndex = 8;
            TchFirstNameErrorMsgLbl.Text = "Invalid First Name";
            // 
            // TchEmailTxb
            // 
            TchEmailTxb.Location = new Point(48, 112);
            TchEmailTxb.Name = "TchEmailTxb";
            TchEmailTxb.Size = new Size(100, 23);
            TchEmailTxb.TabIndex = 7;
            // 
            // TchEmailLbl
            // 
            TchEmailLbl.AutoSize = true;
            TchEmailLbl.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TchEmailLbl.Location = new Point(6, 115);
            TchEmailLbl.Name = "TchEmailLbl";
            TchEmailLbl.Size = new Size(36, 15);
            TchEmailLbl.TabIndex = 6;
            TchEmailLbl.Text = "Email";
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
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "ID";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            firstNameDataGridViewTextBoxColumn.HeaderText = "First Name";
            firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            lastNameDataGridViewTextBoxColumn.HeaderText = "Last Name";
            lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // dateOfBirthDataGridViewTextBoxColumn
            // 
            dateOfBirthDataGridViewTextBoxColumn.DataPropertyName = "DateOfBirth";
            dateOfBirthDataGridViewTextBoxColumn.HeaderText = "Date Of Birth";
            dateOfBirthDataGridViewTextBoxColumn.Name = "dateOfBirthDataGridViewTextBoxColumn";
            // 
            // genderDataGridViewTextBoxColumn
            // 
            genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            // 
            // ageDataGridViewTextBoxColumn
            // 
            ageDataGridViewTextBoxColumn.DataPropertyName = "Age";
            ageDataGridViewTextBoxColumn.HeaderText = "Age";
            ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
            // 
            // telephoneDataGridViewTextBoxColumn
            // 
            telephoneDataGridViewTextBoxColumn.DataPropertyName = "Telephone";
            telephoneDataGridViewTextBoxColumn.HeaderText = "Telephone";
            telephoneDataGridViewTextBoxColumn.Name = "telephoneDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            emailDataGridViewTextBoxColumn.HeaderText = "Email Address";
            emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // roleDataGridViewTextBoxColumn
            // 
            roleDataGridViewTextBoxColumn.DataPropertyName = "Role";
            roleDataGridViewTextBoxColumn.HeaderText = "Role";
            roleDataGridViewTextBoxColumn.Name = "roleDataGridViewTextBoxColumn";
            // 
            // TeacherView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(621, 468);
            Controls.Add(TeacherTabControl);
            Controls.Add(TecherPanel);
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
        private TextBox textBox4;
        private Label TchSalaryLbl;
        private Label TaughtSubjects;
        private DataGridView dataGridView3;
        private DataGridView dataGridView2;
        private ComboBox comboBox1;
        private Label TchSalaryType;
        private Button TchCancelBtn;
        private Button TchSaveBtn;
        private Label TeachingSubjectsLbl;
        private BindingSource teacherBindingSource;
        private Label CloseTeacherFormBtn;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dateOfBirthDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn telephoneDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn roleDataGridViewTextBoxColumn;
    }
}