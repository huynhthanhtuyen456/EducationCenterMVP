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
            administratorBindingSource = new BindingSource(components);
            AdminDetailTabPage = new TabPage();
            SalaryInforGroupBox = new GroupBox();
            AdminWorkingHoursTxb = new TextBox();
            label2 = new Label();
            AdminWorkingTypeComboBox = new ComboBox();
            WorkingTypeLbl = new Label();
            label1 = new Label();
            AdminWorkingScheduleComboBox = new ComboBox();
            AdminSalaryTxb = new TextBox();
            SalaryLbl = new Label();
            AdminBasicInfoGroupBox = new GroupBox();
            AdminGenderComboBox = new ComboBox();
            GenderLbl = new Label();
            CancelAdminBtn = new Button();
            SaveAdminBtn = new Button();
            AdminAgeTxb = new TextBox();
            AgeLbl = new Label();
            AdminDOBDatePicker = new DateTimePicker();
            DOBLbl = new Label();
            AdminTelephoneTxb = new TextBox();
            TelephoneLbl = new Label();
            AdminEmailTxb = new TextBox();
            EmailLbl = new Label();
            AdminLastNameTxb = new TextBox();
            LastNameLbl = new Label();
            AdminFirstNameTxb = new TextBox();
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
            panel1.BackColor = SystemColors.ActiveCaption;
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
            CloseAdministratorViewBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
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
            AdminTitleLbl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
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
            AdminTabControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            AdminTabControl.Controls.Add(AdminListTabPage);
            AdminTabControl.Controls.Add(AdminDetailTabPage);
            AdminTabControl.Location = new Point(0, 100);
            AdminTabControl.Name = "AdminTabControl";
            AdminTabControl.SelectedIndex = 0;
            AdminTabControl.Size = new Size(797, 350);
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
            AdminListTabPage.Size = new Size(789, 322);
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
            DeleteAdminBtn.Location = new Point(706, 93);
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
            EditAdminBtn.Location = new Point(706, 64);
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
            AddAdminBtn.Location = new Point(706, 35);
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
            AdminListDgv.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, fullNameDataGridViewTextBoxColumn, genderDataGridViewTextBoxColumn, emailDataGridViewTextBoxColumn, telephoneDataGridViewTextBoxColumn, dateOfBirthDataGridViewTextBoxColumn, ageDataGridViewTextBoxColumn, salaryDataGridViewTextBoxColumn, workingHoursDataGridViewTextBoxColumn });
            AdminListDgv.DataSource = administratorBindingSource;
            AdminListDgv.Location = new Point(6, 35);
            AdminListDgv.Name = "AdminListDgv";
            AdminListDgv.ReadOnly = true;
            AdminListDgv.Size = new Size(694, 279);
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
            AdminDetailTabPage.Size = new Size(789, 322);
            AdminDetailTabPage.TabIndex = 1;
            AdminDetailTabPage.Text = "Admin Detail";
            AdminDetailTabPage.UseVisualStyleBackColor = true;
            // 
            // SalaryInforGroupBox
            // 
            SalaryInforGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            SalaryInforGroupBox.Controls.Add(AdminWorkingHoursTxb);
            SalaryInforGroupBox.Controls.Add(label2);
            SalaryInforGroupBox.Controls.Add(AdminWorkingTypeComboBox);
            SalaryInforGroupBox.Controls.Add(WorkingTypeLbl);
            SalaryInforGroupBox.Controls.Add(label1);
            SalaryInforGroupBox.Controls.Add(AdminWorkingScheduleComboBox);
            SalaryInforGroupBox.Controls.Add(AdminSalaryTxb);
            SalaryInforGroupBox.Controls.Add(SalaryLbl);
            SalaryInforGroupBox.Location = new Point(458, 6);
            SalaryInforGroupBox.Name = "SalaryInforGroupBox";
            SalaryInforGroupBox.Size = new Size(325, 185);
            SalaryInforGroupBox.TabIndex = 2;
            SalaryInforGroupBox.TabStop = false;
            SalaryInforGroupBox.Text = "Salary Information";
            // 
            // AdminWorkingHoursTxb
            // 
            AdminWorkingHoursTxb.Location = new Point(121, 136);
            AdminWorkingHoursTxb.Name = "AdminWorkingHoursTxb";
            AdminWorkingHoursTxb.Size = new Size(121, 23);
            AdminWorkingHoursTxb.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(6, 139);
            label2.Name = "label2";
            label2.Size = new Size(91, 15);
            label2.TabIndex = 6;
            label2.Text = "Working Hours";
            // 
            // AdminWorkingTypeComboBox
            // 
            AdminWorkingTypeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            AdminWorkingTypeComboBox.FormattingEnabled = true;
            AdminWorkingTypeComboBox.Location = new Point(121, 102);
            AdminWorkingTypeComboBox.Name = "AdminWorkingTypeComboBox";
            AdminWorkingTypeComboBox.Size = new Size(121, 23);
            AdminWorkingTypeComboBox.TabIndex = 5;
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
            // AdminWorkingScheduleComboBox
            // 
            AdminWorkingScheduleComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            AdminWorkingScheduleComboBox.FormattingEnabled = true;
            AdminWorkingScheduleComboBox.Location = new Point(121, 67);
            AdminWorkingScheduleComboBox.Name = "AdminWorkingScheduleComboBox";
            AdminWorkingScheduleComboBox.Size = new Size(121, 23);
            AdminWorkingScheduleComboBox.TabIndex = 2;
            // 
            // AdminSalaryTxb
            // 
            AdminSalaryTxb.Location = new Point(52, 22);
            AdminSalaryTxb.Name = "AdminSalaryTxb";
            AdminSalaryTxb.Size = new Size(100, 23);
            AdminSalaryTxb.TabIndex = 1;
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
            AdminBasicInfoGroupBox.Controls.Add(AdminGenderComboBox);
            AdminBasicInfoGroupBox.Controls.Add(GenderLbl);
            AdminBasicInfoGroupBox.Controls.Add(CancelAdminBtn);
            AdminBasicInfoGroupBox.Controls.Add(SaveAdminBtn);
            AdminBasicInfoGroupBox.Controls.Add(AdminAgeTxb);
            AdminBasicInfoGroupBox.Controls.Add(AgeLbl);
            AdminBasicInfoGroupBox.Controls.Add(AdminDOBDatePicker);
            AdminBasicInfoGroupBox.Controls.Add(DOBLbl);
            AdminBasicInfoGroupBox.Controls.Add(AdminTelephoneTxb);
            AdminBasicInfoGroupBox.Controls.Add(TelephoneLbl);
            AdminBasicInfoGroupBox.Controls.Add(AdminEmailTxb);
            AdminBasicInfoGroupBox.Controls.Add(EmailLbl);
            AdminBasicInfoGroupBox.Controls.Add(AdminLastNameTxb);
            AdminBasicInfoGroupBox.Controls.Add(LastNameLbl);
            AdminBasicInfoGroupBox.Controls.Add(AdminFirstNameTxb);
            AdminBasicInfoGroupBox.Controls.Add(FirstNameLbl);
            AdminBasicInfoGroupBox.Location = new Point(6, 6);
            AdminBasicInfoGroupBox.Name = "AdminBasicInfoGroupBox";
            AdminBasicInfoGroupBox.Size = new Size(446, 310);
            AdminBasicInfoGroupBox.TabIndex = 1;
            AdminBasicInfoGroupBox.TabStop = false;
            AdminBasicInfoGroupBox.Text = "Basic Information";
            // 
            // AdminGenderComboBox
            // 
            AdminGenderComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            AdminGenderComboBox.FormattingEnabled = true;
            AdminGenderComboBox.Location = new Point(289, 162);
            AdminGenderComboBox.Name = "AdminGenderComboBox";
            AdminGenderComboBox.Size = new Size(144, 23);
            AdminGenderComboBox.TabIndex = 15;
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
            // AdminAgeTxb
            // 
            AdminAgeTxb.Location = new Point(79, 162);
            AdminAgeTxb.Name = "AdminAgeTxb";
            AdminAgeTxb.ReadOnly = true;
            AdminAgeTxb.Size = new Size(133, 23);
            AdminAgeTxb.TabIndex = 11;
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
            // AdminDOBDatePicker
            // 
            AdminDOBDatePicker.Location = new Point(94, 118);
            AdminDOBDatePicker.Name = "AdminDOBDatePicker";
            AdminDOBDatePicker.Size = new Size(214, 23);
            AdminDOBDatePicker.TabIndex = 9;
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
            // AdminTelephoneTxb
            // 
            AdminTelephoneTxb.Location = new Point(289, 70);
            AdminTelephoneTxb.Name = "AdminTelephoneTxb";
            AdminTelephoneTxb.Size = new Size(144, 23);
            AdminTelephoneTxb.TabIndex = 7;
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
            // AdminEmailTxb
            // 
            AdminEmailTxb.Location = new Point(79, 70);
            AdminEmailTxb.Name = "AdminEmailTxb";
            AdminEmailTxb.Size = new Size(133, 23);
            AdminEmailTxb.TabIndex = 5;
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
            // AdminLastNameTxb
            // 
            AdminLastNameTxb.Location = new Point(289, 22);
            AdminLastNameTxb.Name = "AdminLastNameTxb";
            AdminLastNameTxb.Size = new Size(144, 23);
            AdminLastNameTxb.TabIndex = 3;
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
            // AdminFirstNameTxb
            // 
            AdminFirstNameTxb.Location = new Point(79, 22);
            AdminFirstNameTxb.Name = "AdminFirstNameTxb";
            AdminFirstNameTxb.Size = new Size(133, 23);
            AdminFirstNameTxb.TabIndex = 1;
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
        private ComboBox AdminGenderComboBox;
        private Label GenderLbl;
        private Button CancelAdminBtn;
        private Button SaveAdminBtn;
        private TextBox AdminAgeTxb;
        private Label AgeLbl;
        private DateTimePicker AdminDOBDatePicker;
        private Label DOBLbl;
        private TextBox AdminTelephoneTxb;
        private Label TelephoneLbl;
        private TextBox AdminEmailTxb;
        private Label EmailLbl;
        private TextBox AdminLastNameTxb;
        private Label LastNameLbl;
        private TextBox AdminFirstNameTxb;
        private Label FirstNameLbl;
        private GroupBox SalaryInforGroupBox;
        private ComboBox AdminWorkingTypeComboBox;
        private Label WorkingTypeLbl;
        private Label label1;
        private ComboBox AdminWorkingScheduleComboBox;
        private TextBox AdminSalaryTxb;
        private Label SalaryLbl;
        private BindingSource administratorBindingSource;
        private TextBox AdminWorkingHoursTxb;
        private Label label2;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn telephoneDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dateOfBirthDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn salaryDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn workingHoursDataGridViewTextBoxColumn;
    }
}