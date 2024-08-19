namespace EducationCenter.Views.Classes
{
    partial class AdministratorView
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
            CloseAdministratorViewBtn = new Label();
            AdminTitleLbl = new Label();
            AdminTabControl = new TabControl();
            AdminListTabPage = new TabPage();
            SearchAdminBtn = new Button();
            SearchAdminTxb = new TextBox();
            DeleteAdminBtn = new Button();
            EditAdminBtn = new Button();
            AddAdminBtn = new Button();
            AdminListDgv = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fullNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            genderDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            emailDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            telephoneDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dateOfBirthDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ageDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            salaryDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            workingHoursDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            workingScheduleDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            administratorBindingSource = new BindingSource(components);
            AdminDetailTabPage = new TabPage();
            SalaryInforGroupBox = new GroupBox();
            WorkingTypeComboBox = new ComboBox();
            WorkingTypeLbl = new Label();
            label1 = new Label();
            WorkingScheduleComboBox = new ComboBox();
            SalaryTxb = new TextBox();
            SalaryLbl = new Label();
            AdminBasicInfoGroupBox = new GroupBox();
            GenderComboBox = new ComboBox();
            GenderLbl = new Label();
            CancelAdminBtn = new Button();
            SaveAdminBtn = new Button();
            AgeTxb = new TextBox();
            AgeLbl = new Label();
            DOBDatePicker = new DateTimePicker();
            DOBLbl = new Label();
            TelephoneTxb = new TextBox();
            TelephoneLbl = new Label();
            EmailTxb = new TextBox();
            EmailLbl = new Label();
            LastNameTxb = new TextBox();
            LastNameLbl = new Label();
            FirstNameTxb = new TextBox();
            FirstNameLbl = new Label();
            panel1.SuspendLayout();
            AdminTabControl.SuspendLayout();
            AdminListTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AdminListDgv).BeginInit();
            ((System.ComponentModel.ISupportInitialize)administratorBindingSource).BeginInit();
            AdminDetailTabPage.SuspendLayout();
            SalaryInforGroupBox.SuspendLayout();
            AdminBasicInfoGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(CloseAdministratorViewBtn);
            panel1.Controls.Add(AdminTitleLbl);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 100);
            panel1.TabIndex = 0;
            // 
            // CloseAdministratorViewBtn
            // 
            CloseAdministratorViewBtn.AutoSize = true;
            CloseAdministratorViewBtn.Cursor = Cursors.Hand;
            CloseAdministratorViewBtn.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CloseAdministratorViewBtn.Location = new Point(761, 9);
            CloseAdministratorViewBtn.Name = "CloseAdministratorViewBtn";
            CloseAdministratorViewBtn.Size = new Size(27, 30);
            CloseAdministratorViewBtn.TabIndex = 1;
            CloseAdministratorViewBtn.Text = "X";
            // 
            // AdminTitleLbl
            // 
            AdminTitleLbl.AutoSize = true;
            AdminTitleLbl.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AdminTitleLbl.Location = new Point(308, 34);
            AdminTitleLbl.Name = "AdminTitleLbl";
            AdminTitleLbl.Size = new Size(174, 32);
            AdminTitleLbl.TabIndex = 0;
            AdminTitleLbl.Text = "Administrator";
            // 
            // AdminTabControl
            // 
            AdminTabControl.Controls.Add(AdminListTabPage);
            AdminTabControl.Controls.Add(AdminDetailTabPage);
            AdminTabControl.Dock = DockStyle.Fill;
            AdminTabControl.Location = new Point(0, 100);
            AdminTabControl.Name = "AdminTabControl";
            AdminTabControl.SelectedIndex = 0;
            AdminTabControl.Size = new Size(800, 350);
            AdminTabControl.TabIndex = 1;
            // 
            // AdminListTabPage
            // 
            AdminListTabPage.Controls.Add(SearchAdminBtn);
            AdminListTabPage.Controls.Add(SearchAdminTxb);
            AdminListTabPage.Controls.Add(DeleteAdminBtn);
            AdminListTabPage.Controls.Add(EditAdminBtn);
            AdminListTabPage.Controls.Add(AddAdminBtn);
            AdminListTabPage.Controls.Add(AdminListDgv);
            AdminListTabPage.Location = new Point(4, 24);
            AdminListTabPage.Name = "AdminListTabPage";
            AdminListTabPage.Padding = new Padding(3);
            AdminListTabPage.Size = new Size(792, 322);
            AdminListTabPage.TabIndex = 0;
            AdminListTabPage.Text = "Admin List";
            AdminListTabPage.UseVisualStyleBackColor = true;
            // 
            // SearchAdminBtn
            // 
            SearchAdminBtn.BackColor = Color.FromArgb(255, 128, 0);
            SearchAdminBtn.FlatAppearance.BorderSize = 0;
            SearchAdminBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 224, 192);
            SearchAdminBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 192, 128);
            SearchAdminBtn.FlatStyle = FlatStyle.Flat;
            SearchAdminBtn.Location = new Point(223, 5);
            SearchAdminBtn.Name = "SearchAdminBtn";
            SearchAdminBtn.Size = new Size(75, 23);
            SearchAdminBtn.TabIndex = 5;
            SearchAdminBtn.Text = "Search";
            SearchAdminBtn.UseVisualStyleBackColor = false;
            // 
            // SearchAdminTxb
            // 
            SearchAdminTxb.Location = new Point(6, 6);
            SearchAdminTxb.Name = "SearchAdminTxb";
            SearchAdminTxb.Size = new Size(211, 23);
            SearchAdminTxb.TabIndex = 4;
            // 
            // DeleteAdminBtn
            // 
            DeleteAdminBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            DeleteAdminBtn.BackColor = Color.Red;
            DeleteAdminBtn.FlatAppearance.BorderSize = 0;
            DeleteAdminBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 192, 192);
            DeleteAdminBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 128);
            DeleteAdminBtn.FlatStyle = FlatStyle.Flat;
            DeleteAdminBtn.Location = new Point(709, 93);
            DeleteAdminBtn.Name = "DeleteAdminBtn";
            DeleteAdminBtn.Size = new Size(75, 23);
            DeleteAdminBtn.TabIndex = 3;
            DeleteAdminBtn.Text = "Delete";
            DeleteAdminBtn.UseVisualStyleBackColor = false;
            // 
            // EditAdminBtn
            // 
            EditAdminBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            EditAdminBtn.BackColor = Color.Yellow;
            EditAdminBtn.FlatAppearance.BorderSize = 0;
            EditAdminBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 255, 192);
            EditAdminBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 255, 128);
            EditAdminBtn.FlatStyle = FlatStyle.Flat;
            EditAdminBtn.Location = new Point(709, 64);
            EditAdminBtn.Name = "EditAdminBtn";
            EditAdminBtn.Size = new Size(75, 23);
            EditAdminBtn.TabIndex = 2;
            EditAdminBtn.Text = "Edit";
            EditAdminBtn.UseVisualStyleBackColor = false;
            // 
            // AddAdminBtn
            // 
            AddAdminBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            AddAdminBtn.BackColor = Color.Lime;
            AddAdminBtn.FlatAppearance.BorderSize = 0;
            AddAdminBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 255, 192);
            AddAdminBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 255, 128);
            AddAdminBtn.FlatStyle = FlatStyle.Flat;
            AddAdminBtn.Location = new Point(709, 35);
            AddAdminBtn.Name = "AddAdminBtn";
            AddAdminBtn.Size = new Size(75, 23);
            AddAdminBtn.TabIndex = 1;
            AddAdminBtn.Text = "Add";
            AddAdminBtn.UseVisualStyleBackColor = false;
            // 
            // AdminListDgv
            // 
            AdminListDgv.AllowUserToAddRows = false;
            AdminListDgv.AllowUserToDeleteRows = false;
            AdminListDgv.AllowUserToOrderColumns = true;
            AdminListDgv.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            AdminListDgv.AutoGenerateColumns = false;
            AdminListDgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            AdminListDgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            AdminListDgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AdminListDgv.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, fullNameDataGridViewTextBoxColumn, genderDataGridViewTextBoxColumn, emailDataGridViewTextBoxColumn, telephoneDataGridViewTextBoxColumn, dateOfBirthDataGridViewTextBoxColumn, ageDataGridViewTextBoxColumn, salaryDataGridViewTextBoxColumn, workingHoursDataGridViewTextBoxColumn, workingScheduleDataGridViewTextBoxColumn });
            AdminListDgv.DataSource = administratorBindingSource;
            AdminListDgv.Location = new Point(6, 35);
            AdminListDgv.Name = "AdminListDgv";
            AdminListDgv.ReadOnly = true;
            AdminListDgv.Size = new Size(697, 279);
            AdminListDgv.TabIndex = 0;
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
            // genderDataGridViewTextBoxColumn
            // 
            genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            genderDataGridViewTextBoxColumn.ReadOnly = true;
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
            // salaryDataGridViewTextBoxColumn
            // 
            salaryDataGridViewTextBoxColumn.DataPropertyName = "Salary";
            salaryDataGridViewTextBoxColumn.HeaderText = "Salary";
            salaryDataGridViewTextBoxColumn.Name = "salaryDataGridViewTextBoxColumn";
            salaryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // workingHoursDataGridViewTextBoxColumn
            // 
            workingHoursDataGridViewTextBoxColumn.DataPropertyName = "WorkingHours";
            workingHoursDataGridViewTextBoxColumn.HeaderText = "WorkingHours";
            workingHoursDataGridViewTextBoxColumn.Name = "workingHoursDataGridViewTextBoxColumn";
            workingHoursDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // workingScheduleDataGridViewTextBoxColumn
            // 
            workingScheduleDataGridViewTextBoxColumn.DataPropertyName = "WorkingSchedule";
            workingScheduleDataGridViewTextBoxColumn.HeaderText = "WorkingSchedule";
            workingScheduleDataGridViewTextBoxColumn.Name = "workingScheduleDataGridViewTextBoxColumn";
            workingScheduleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // administratorBindingSource
            // 
            administratorBindingSource.DataSource = typeof(DataLayer.Entities.Administrators.Administrator);
            // 
            // AdminDetailTabPage
            // 
            AdminDetailTabPage.Controls.Add(SalaryInforGroupBox);
            AdminDetailTabPage.Controls.Add(AdminBasicInfoGroupBox);
            AdminDetailTabPage.Location = new Point(4, 24);
            AdminDetailTabPage.Name = "AdminDetailTabPage";
            AdminDetailTabPage.Padding = new Padding(3);
            AdminDetailTabPage.Size = new Size(792, 322);
            AdminDetailTabPage.TabIndex = 1;
            AdminDetailTabPage.Text = "Admin Detail";
            AdminDetailTabPage.UseVisualStyleBackColor = true;
            // 
            // SalaryInforGroupBox
            // 
            SalaryInforGroupBox.Controls.Add(WorkingTypeComboBox);
            SalaryInforGroupBox.Controls.Add(WorkingTypeLbl);
            SalaryInforGroupBox.Controls.Add(label1);
            SalaryInforGroupBox.Controls.Add(WorkingScheduleComboBox);
            SalaryInforGroupBox.Controls.Add(SalaryTxb);
            SalaryInforGroupBox.Controls.Add(SalaryLbl);
            SalaryInforGroupBox.Location = new Point(458, 6);
            SalaryInforGroupBox.Name = "SalaryInforGroupBox";
            SalaryInforGroupBox.Size = new Size(331, 139);
            SalaryInforGroupBox.TabIndex = 2;
            SalaryInforGroupBox.TabStop = false;
            SalaryInforGroupBox.Text = "Salary Information";
            // 
            // WorkingTypeComboBox
            // 
            WorkingTypeComboBox.FormattingEnabled = true;
            WorkingTypeComboBox.Location = new Point(121, 102);
            WorkingTypeComboBox.Name = "WorkingTypeComboBox";
            WorkingTypeComboBox.Size = new Size(121, 23);
            WorkingTypeComboBox.TabIndex = 5;
            // 
            // WorkingTypeLbl
            // 
            WorkingTypeLbl.AutoSize = true;
            WorkingTypeLbl.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            WorkingTypeLbl.Location = new Point(8, 105);
            WorkingTypeLbl.Name = "WorkingTypeLbl";
            WorkingTypeLbl.Size = new Size(84, 15);
            WorkingTypeLbl.TabIndex = 4;
            WorkingTypeLbl.Text = "Working Type";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(6, 70);
            label1.Name = "label1";
            label1.Size = new Size(109, 15);
            label1.TabIndex = 3;
            label1.Text = "Working Schedule";
            // 
            // WorkingScheduleComboBox
            // 
            WorkingScheduleComboBox.FormattingEnabled = true;
            WorkingScheduleComboBox.Location = new Point(121, 67);
            WorkingScheduleComboBox.Name = "WorkingScheduleComboBox";
            WorkingScheduleComboBox.Size = new Size(121, 23);
            WorkingScheduleComboBox.TabIndex = 2;
            // 
            // SalaryTxb
            // 
            SalaryTxb.Location = new Point(52, 22);
            SalaryTxb.Name = "SalaryTxb";
            SalaryTxb.Size = new Size(121, 23);
            SalaryTxb.TabIndex = 1;
            // 
            // SalaryLbl
            // 
            SalaryLbl.AutoSize = true;
            SalaryLbl.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SalaryLbl.Location = new Point(6, 25);
            SalaryLbl.Name = "SalaryLbl";
            SalaryLbl.Size = new Size(40, 15);
            SalaryLbl.TabIndex = 0;
            SalaryLbl.Text = "Salary";
            // 
            // AdminBasicInfoGroupBox
            // 
            AdminBasicInfoGroupBox.Controls.Add(GenderComboBox);
            AdminBasicInfoGroupBox.Controls.Add(GenderLbl);
            AdminBasicInfoGroupBox.Controls.Add(CancelAdminBtn);
            AdminBasicInfoGroupBox.Controls.Add(SaveAdminBtn);
            AdminBasicInfoGroupBox.Controls.Add(AgeTxb);
            AdminBasicInfoGroupBox.Controls.Add(AgeLbl);
            AdminBasicInfoGroupBox.Controls.Add(DOBDatePicker);
            AdminBasicInfoGroupBox.Controls.Add(DOBLbl);
            AdminBasicInfoGroupBox.Controls.Add(TelephoneTxb);
            AdminBasicInfoGroupBox.Controls.Add(TelephoneLbl);
            AdminBasicInfoGroupBox.Controls.Add(EmailTxb);
            AdminBasicInfoGroupBox.Controls.Add(EmailLbl);
            AdminBasicInfoGroupBox.Controls.Add(LastNameTxb);
            AdminBasicInfoGroupBox.Controls.Add(LastNameLbl);
            AdminBasicInfoGroupBox.Controls.Add(FirstNameTxb);
            AdminBasicInfoGroupBox.Controls.Add(FirstNameLbl);
            AdminBasicInfoGroupBox.Location = new Point(6, 6);
            AdminBasicInfoGroupBox.Name = "AdminBasicInfoGroupBox";
            AdminBasicInfoGroupBox.Size = new Size(446, 310);
            AdminBasicInfoGroupBox.TabIndex = 1;
            AdminBasicInfoGroupBox.TabStop = false;
            AdminBasicInfoGroupBox.Text = "Basic Information";
            // 
            // GenderComboBox
            // 
            GenderComboBox.FormattingEnabled = true;
            GenderComboBox.Location = new Point(289, 162);
            GenderComboBox.Name = "GenderComboBox";
            GenderComboBox.Size = new Size(144, 23);
            GenderComboBox.TabIndex = 15;
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
            // CancelAdminBtn
            // 
            CancelAdminBtn.BackColor = SystemColors.ActiveBorder;
            CancelAdminBtn.FlatAppearance.BorderSize = 0;
            CancelAdminBtn.FlatAppearance.MouseDownBackColor = SystemColors.ControlDark;
            CancelAdminBtn.FlatAppearance.MouseOverBackColor = SystemColors.ControlDarkDark;
            CancelAdminBtn.FlatStyle = FlatStyle.Flat;
            CancelAdminBtn.Location = new Point(160, 217);
            CancelAdminBtn.Name = "CancelAdminBtn";
            CancelAdminBtn.Size = new Size(75, 23);
            CancelAdminBtn.TabIndex = 13;
            CancelAdminBtn.Text = "Cancel";
            CancelAdminBtn.UseVisualStyleBackColor = false;
            // 
            // SaveAdminBtn
            // 
            SaveAdminBtn.BackColor = SystemColors.ActiveCaption;
            SaveAdminBtn.FlatAppearance.BorderSize = 0;
            SaveAdminBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 192, 255);
            SaveAdminBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 128, 255);
            SaveAdminBtn.FlatStyle = FlatStyle.Flat;
            SaveAdminBtn.Location = new Point(79, 217);
            SaveAdminBtn.Name = "SaveAdminBtn";
            SaveAdminBtn.Size = new Size(75, 23);
            SaveAdminBtn.TabIndex = 12;
            SaveAdminBtn.Text = "Save";
            SaveAdminBtn.UseVisualStyleBackColor = false;
            // 
            // AgeTxb
            // 
            AgeTxb.Location = new Point(79, 162);
            AgeTxb.Name = "AgeTxb";
            AgeTxb.ReadOnly = true;
            AgeTxb.Size = new Size(133, 23);
            AgeTxb.TabIndex = 11;
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
            // DOBDatePicker
            // 
            DOBDatePicker.Location = new Point(94, 118);
            DOBDatePicker.Name = "DOBDatePicker";
            DOBDatePicker.Size = new Size(214, 23);
            DOBDatePicker.TabIndex = 9;
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
            // TelephoneTxb
            // 
            TelephoneTxb.Location = new Point(289, 70);
            TelephoneTxb.Name = "TelephoneTxb";
            TelephoneTxb.Size = new Size(144, 23);
            TelephoneTxb.TabIndex = 7;
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
            // EmailTxb
            // 
            EmailTxb.Location = new Point(79, 70);
            EmailTxb.Name = "EmailTxb";
            EmailTxb.Size = new Size(133, 23);
            EmailTxb.TabIndex = 5;
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
            // LastNameTxb
            // 
            LastNameTxb.Location = new Point(289, 22);
            LastNameTxb.Name = "LastNameTxb";
            LastNameTxb.Size = new Size(144, 23);
            LastNameTxb.TabIndex = 3;
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
            // FirstNameTxb
            // 
            FirstNameTxb.Location = new Point(79, 22);
            FirstNameTxb.Name = "FirstNameTxb";
            FirstNameTxb.Size = new Size(133, 23);
            FirstNameTxb.TabIndex = 1;
            // 
            // FirstNameLbl
            // 
            FirstNameLbl.AutoSize = true;
            FirstNameLbl.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FirstNameLbl.Location = new Point(6, 25);
            FirstNameLbl.Name = "FirstNameLbl";
            FirstNameLbl.Size = new Size(67, 15);
            FirstNameLbl.TabIndex = 0;
            FirstNameLbl.Text = "First Name";
            // 
            // AdministratorView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(AdminTabControl);
            Controls.Add(panel1);
            Name = "AdministratorView";
            Text = "AdministratorView";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            AdminTabControl.ResumeLayout(false);
            AdminListTabPage.ResumeLayout(false);
            AdminListTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)AdminListDgv).EndInit();
            ((System.ComponentModel.ISupportInitialize)administratorBindingSource).EndInit();
            AdminDetailTabPage.ResumeLayout(false);
            SalaryInforGroupBox.ResumeLayout(false);
            SalaryInforGroupBox.PerformLayout();
            AdminBasicInfoGroupBox.ResumeLayout(false);
            AdminBasicInfoGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label AdminTitleLbl;
        private Label CloseAdministratorViewBtn;
        private TabControl AdminTabControl;
        private TabPage AdminListTabPage;
        private TabPage AdminDetailTabPage;
        private Button DeleteAdminBtn;
        private Button EditAdminBtn;
        private Button AddAdminBtn;
        private DataGridView AdminListDgv;
        private Button SearchAdminBtn;
        private TextBox SearchAdminTxb;
        private GroupBox AdminBasicInfoGroupBox;
        private ComboBox GenderComboBox;
        private Label GenderLbl;
        private Button CancelAdminBtn;
        private Button SaveAdminBtn;
        private TextBox AgeTxb;
        private Label AgeLbl;
        private DateTimePicker DOBDatePicker;
        private Label DOBLbl;
        private TextBox TelephoneTxb;
        private Label TelephoneLbl;
        private TextBox EmailTxb;
        private Label EmailLbl;
        private TextBox LastNameTxb;
        private Label LastNameLbl;
        private TextBox FirstNameTxb;
        private Label FirstNameLbl;
        private GroupBox SalaryInforGroupBox;
        private ComboBox WorkingTypeComboBox;
        private Label WorkingTypeLbl;
        private Label label1;
        private ComboBox WorkingScheduleComboBox;
        private TextBox SalaryTxb;
        private Label SalaryLbl;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn telephoneDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dateOfBirthDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn salaryDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn workingHoursDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn workingScheduleDataGridViewTextBoxColumn;
        private BindingSource administratorBindingSource;
    }
}