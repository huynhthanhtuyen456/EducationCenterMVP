namespace EducationCenter.Views.Classes
{
    partial class SubjectView
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
            TecherPanel = new Panel();
            CloseSubjectViewBtn = new Label();
            CloseTeacherFormBtn = new Label();
            SubjectLbl = new Label();
            SubjectTabControl = new TabControl();
            SubjectListTabPage = new TabPage();
            DeleteSubjectBtn = new Button();
            EditSubjectBtn = new Button();
            AddSubjectBtn = new Button();
            SearchSubjectBtn = new Button();
            SearchSubjectTxb = new TextBox();
            SubjectListDgv = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            codeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            creditsDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            subjectBindingSource = new BindingSource(components);
            SubjectDetailTabPage = new TabPage();
            CancelSaveSubjectBtn = new Button();
            SaveSubjectBtn = new Button();
            SubjectGroupBox = new GroupBox();
            SubjectCreditsTxb = new TextBox();
            SubjectCreditsLbl = new Label();
            SubjectCodeTxb = new TextBox();
            SubjectCodeLbl = new Label();
            SubjectNameTxb = new TextBox();
            SubjectNameLbl = new Label();
            TecherPanel.SuspendLayout();
            SubjectTabControl.SuspendLayout();
            SubjectListTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SubjectListDgv).BeginInit();
            ((System.ComponentModel.ISupportInitialize)subjectBindingSource).BeginInit();
            SubjectDetailTabPage.SuspendLayout();
            SubjectGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // TecherPanel
            // 
            TecherPanel.BackColor = SystemColors.ActiveCaption;
            TecherPanel.Controls.Add(CloseSubjectViewBtn);
            TecherPanel.Controls.Add(CloseTeacherFormBtn);
            TecherPanel.Controls.Add(SubjectLbl);
            TecherPanel.Dock = DockStyle.Top;
            TecherPanel.Location = new Point(0, 0);
            TecherPanel.Name = "TecherPanel";
            TecherPanel.Size = new Size(800, 69);
            TecherPanel.TabIndex = 2;
            // 
            // CloseSubjectViewBtn
            // 
            CloseSubjectViewBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            CloseSubjectViewBtn.AutoSize = true;
            CloseSubjectViewBtn.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CloseSubjectViewBtn.Location = new Point(750, 9);
            CloseSubjectViewBtn.Name = "CloseSubjectViewBtn";
            CloseSubjectViewBtn.Size = new Size(24, 25);
            CloseSubjectViewBtn.TabIndex = 2;
            CloseSubjectViewBtn.Text = "X";
            // 
            // CloseTeacherFormBtn
            // 
            CloseTeacherFormBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            CloseTeacherFormBtn.AutoSize = true;
            CloseTeacherFormBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CloseTeacherFormBtn.Location = new Point(1493, 13);
            CloseTeacherFormBtn.Name = "CloseTeacherFormBtn";
            CloseTeacherFormBtn.Size = new Size(15, 15);
            CloseTeacherFormBtn.TabIndex = 1;
            CloseTeacherFormBtn.Text = "X";
            // 
            // SubjectLbl
            // 
            SubjectLbl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            SubjectLbl.AutoSize = true;
            SubjectLbl.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SubjectLbl.Location = new Point(319, 9);
            SubjectLbl.Name = "SubjectLbl";
            SubjectLbl.Size = new Size(124, 37);
            SubjectLbl.TabIndex = 0;
            SubjectLbl.Text = "Subjects";
            // 
            // SubjectTabControl
            // 
            SubjectTabControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            SubjectTabControl.Controls.Add(SubjectListTabPage);
            SubjectTabControl.Controls.Add(SubjectDetailTabPage);
            SubjectTabControl.Location = new Point(0, 75);
            SubjectTabControl.Name = "SubjectTabControl";
            SubjectTabControl.SelectedIndex = 0;
            SubjectTabControl.Size = new Size(800, 375);
            SubjectTabControl.TabIndex = 3;
            // 
            // SubjectListTabPage
            // 
            SubjectListTabPage.Controls.Add(DeleteSubjectBtn);
            SubjectListTabPage.Controls.Add(EditSubjectBtn);
            SubjectListTabPage.Controls.Add(AddSubjectBtn);
            SubjectListTabPage.Controls.Add(SearchSubjectBtn);
            SubjectListTabPage.Controls.Add(SearchSubjectTxb);
            SubjectListTabPage.Controls.Add(SubjectListDgv);
            SubjectListTabPage.Location = new Point(4, 24);
            SubjectListTabPage.Name = "SubjectListTabPage";
            SubjectListTabPage.Padding = new Padding(3);
            SubjectListTabPage.Size = new Size(792, 347);
            SubjectListTabPage.TabIndex = 0;
            SubjectListTabPage.Text = "Subjects";
            SubjectListTabPage.UseVisualStyleBackColor = true;
            // 
            // DeleteSubjectBtn
            // 
            DeleteSubjectBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            DeleteSubjectBtn.BackColor = Color.Red;
            DeleteSubjectBtn.FlatAppearance.BorderSize = 0;
            DeleteSubjectBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 192, 192);
            DeleteSubjectBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 128);
            DeleteSubjectBtn.FlatStyle = FlatStyle.Flat;
            DeleteSubjectBtn.Location = new Point(709, 93);
            DeleteSubjectBtn.Name = "DeleteSubjectBtn";
            DeleteSubjectBtn.Size = new Size(75, 23);
            DeleteSubjectBtn.TabIndex = 5;
            DeleteSubjectBtn.Text = "Delete";
            DeleteSubjectBtn.UseVisualStyleBackColor = false;
            // 
            // EditSubjectBtn
            // 
            EditSubjectBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            EditSubjectBtn.BackColor = Color.Yellow;
            EditSubjectBtn.FlatAppearance.BorderSize = 0;
            EditSubjectBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 255, 192);
            EditSubjectBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 255, 128);
            EditSubjectBtn.FlatStyle = FlatStyle.Flat;
            EditSubjectBtn.Location = new Point(709, 64);
            EditSubjectBtn.Name = "EditSubjectBtn";
            EditSubjectBtn.Size = new Size(75, 23);
            EditSubjectBtn.TabIndex = 4;
            EditSubjectBtn.Text = "Edit";
            EditSubjectBtn.UseVisualStyleBackColor = false;
            // 
            // AddSubjectBtn
            // 
            AddSubjectBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            AddSubjectBtn.BackColor = Color.Lime;
            AddSubjectBtn.FlatAppearance.BorderSize = 0;
            AddSubjectBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 255, 192);
            AddSubjectBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 255, 128);
            AddSubjectBtn.FlatStyle = FlatStyle.Flat;
            AddSubjectBtn.Location = new Point(709, 35);
            AddSubjectBtn.Name = "AddSubjectBtn";
            AddSubjectBtn.Size = new Size(75, 23);
            AddSubjectBtn.TabIndex = 3;
            AddSubjectBtn.Text = "Add";
            AddSubjectBtn.UseVisualStyleBackColor = false;
            // 
            // SearchSubjectBtn
            // 
            SearchSubjectBtn.BackColor = Color.FromArgb(255, 128, 0);
            SearchSubjectBtn.FlatAppearance.BorderSize = 0;
            SearchSubjectBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 224, 192);
            SearchSubjectBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 192, 128);
            SearchSubjectBtn.FlatStyle = FlatStyle.Flat;
            SearchSubjectBtn.Location = new Point(277, 6);
            SearchSubjectBtn.Name = "SearchSubjectBtn";
            SearchSubjectBtn.Size = new Size(75, 23);
            SearchSubjectBtn.TabIndex = 2;
            SearchSubjectBtn.Text = "Search";
            SearchSubjectBtn.UseVisualStyleBackColor = false;
            // 
            // SearchSubjectTxb
            // 
            SearchSubjectTxb.Location = new Point(6, 6);
            SearchSubjectTxb.Name = "SearchSubjectTxb";
            SearchSubjectTxb.Size = new Size(265, 23);
            SearchSubjectTxb.TabIndex = 1;
            // 
            // SubjectListDgv
            // 
            SubjectListDgv.AllowUserToAddRows = false;
            SubjectListDgv.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            SubjectListDgv.AutoGenerateColumns = false;
            SubjectListDgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            SubjectListDgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            SubjectListDgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            SubjectListDgv.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, codeDataGridViewTextBoxColumn, creditsDataGridViewTextBoxColumn });
            SubjectListDgv.DataSource = subjectBindingSource;
            SubjectListDgv.Location = new Point(8, 35);
            SubjectListDgv.Name = "SubjectListDgv";
            SubjectListDgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            SubjectListDgv.Size = new Size(695, 304);
            SubjectListDgv.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // codeDataGridViewTextBoxColumn
            // 
            codeDataGridViewTextBoxColumn.DataPropertyName = "Code";
            codeDataGridViewTextBoxColumn.HeaderText = "Code";
            codeDataGridViewTextBoxColumn.Name = "codeDataGridViewTextBoxColumn";
            // 
            // creditsDataGridViewTextBoxColumn
            // 
            creditsDataGridViewTextBoxColumn.DataPropertyName = "Credits";
            creditsDataGridViewTextBoxColumn.HeaderText = "Credits";
            creditsDataGridViewTextBoxColumn.Name = "creditsDataGridViewTextBoxColumn";
            // 
            // subjectBindingSource
            // 
            subjectBindingSource.DataSource = typeof(DataLayer.Entities.Subjects.Subject);
            // 
            // SubjectDetailTabPage
            // 
            SubjectDetailTabPage.Controls.Add(CancelSaveSubjectBtn);
            SubjectDetailTabPage.Controls.Add(SaveSubjectBtn);
            SubjectDetailTabPage.Controls.Add(SubjectGroupBox);
            SubjectDetailTabPage.Location = new Point(4, 24);
            SubjectDetailTabPage.Name = "SubjectDetailTabPage";
            SubjectDetailTabPage.Padding = new Padding(3);
            SubjectDetailTabPage.Size = new Size(792, 347);
            SubjectDetailTabPage.TabIndex = 1;
            SubjectDetailTabPage.Text = "Subject Detail";
            SubjectDetailTabPage.UseVisualStyleBackColor = true;
            // 
            // CancelSaveSubjectBtn
            // 
            CancelSaveSubjectBtn.BackColor = SystemColors.ActiveBorder;
            CancelSaveSubjectBtn.FlatAppearance.BorderSize = 0;
            CancelSaveSubjectBtn.FlatStyle = FlatStyle.Flat;
            CancelSaveSubjectBtn.ForeColor = SystemColors.ActiveCaptionText;
            CancelSaveSubjectBtn.Location = new Point(89, 151);
            CancelSaveSubjectBtn.Name = "CancelSaveSubjectBtn";
            CancelSaveSubjectBtn.Size = new Size(75, 23);
            CancelSaveSubjectBtn.TabIndex = 2;
            CancelSaveSubjectBtn.Text = "Cancel";
            CancelSaveSubjectBtn.UseVisualStyleBackColor = false;
            // 
            // SaveSubjectBtn
            // 
            SaveSubjectBtn.BackColor = Color.Violet;
            SaveSubjectBtn.FlatAppearance.BorderSize = 0;
            SaveSubjectBtn.FlatStyle = FlatStyle.Flat;
            SaveSubjectBtn.ForeColor = SystemColors.ActiveCaptionText;
            SaveSubjectBtn.Location = new Point(8, 151);
            SaveSubjectBtn.Name = "SaveSubjectBtn";
            SaveSubjectBtn.Size = new Size(75, 23);
            SaveSubjectBtn.TabIndex = 1;
            SaveSubjectBtn.Text = "Save";
            SaveSubjectBtn.UseVisualStyleBackColor = false;
            // 
            // SubjectGroupBox
            // 
            SubjectGroupBox.Controls.Add(SubjectCreditsTxb);
            SubjectGroupBox.Controls.Add(SubjectCreditsLbl);
            SubjectGroupBox.Controls.Add(SubjectCodeTxb);
            SubjectGroupBox.Controls.Add(SubjectCodeLbl);
            SubjectGroupBox.Controls.Add(SubjectNameTxb);
            SubjectGroupBox.Controls.Add(SubjectNameLbl);
            SubjectGroupBox.Location = new Point(8, 6);
            SubjectGroupBox.Name = "SubjectGroupBox";
            SubjectGroupBox.Size = new Size(458, 139);
            SubjectGroupBox.TabIndex = 0;
            SubjectGroupBox.TabStop = false;
            SubjectGroupBox.Text = "Subject Information";
            // 
            // SubjectCreditsTxb
            // 
            SubjectCreditsTxb.Location = new Point(331, 72);
            SubjectCreditsTxb.Name = "SubjectCreditsTxb";
            SubjectCreditsTxb.Size = new Size(100, 23);
            SubjectCreditsTxb.TabIndex = 5;
            // 
            // SubjectCreditsLbl
            // 
            SubjectCreditsLbl.AutoSize = true;
            SubjectCreditsLbl.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SubjectCreditsLbl.Location = new Point(229, 75);
            SubjectCreditsLbl.Name = "SubjectCreditsLbl";
            SubjectCreditsLbl.Size = new Size(91, 15);
            SubjectCreditsLbl.TabIndex = 4;
            SubjectCreditsLbl.Text = "Subject Credits";
            // 
            // SubjectCodeTxb
            // 
            SubjectCodeTxb.Location = new Point(98, 72);
            SubjectCodeTxb.Name = "SubjectCodeTxb";
            SubjectCodeTxb.Size = new Size(100, 23);
            SubjectCodeTxb.TabIndex = 3;
            // 
            // SubjectCodeLbl
            // 
            SubjectCodeLbl.AutoSize = true;
            SubjectCodeLbl.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SubjectCodeLbl.Location = new Point(6, 75);
            SubjectCodeLbl.Name = "SubjectCodeLbl";
            SubjectCodeLbl.Size = new Size(80, 15);
            SubjectCodeLbl.TabIndex = 2;
            SubjectCodeLbl.Text = "Subject Code";
            // 
            // SubjectNameTxb
            // 
            SubjectNameTxb.Location = new Point(98, 19);
            SubjectNameTxb.Name = "SubjectNameTxb";
            SubjectNameTxb.Size = new Size(333, 23);
            SubjectNameTxb.TabIndex = 1;
            // 
            // SubjectNameLbl
            // 
            SubjectNameLbl.AutoSize = true;
            SubjectNameLbl.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SubjectNameLbl.Location = new Point(6, 19);
            SubjectNameLbl.Name = "SubjectNameLbl";
            SubjectNameLbl.Size = new Size(85, 15);
            SubjectNameLbl.TabIndex = 0;
            SubjectNameLbl.Text = "Subject Name";
            // 
            // SubjectView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(SubjectTabControl);
            Controls.Add(TecherPanel);
            Name = "SubjectView";
            Text = "SubjectView";
            TecherPanel.ResumeLayout(false);
            TecherPanel.PerformLayout();
            SubjectTabControl.ResumeLayout(false);
            SubjectListTabPage.ResumeLayout(false);
            SubjectListTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)SubjectListDgv).EndInit();
            ((System.ComponentModel.ISupportInitialize)subjectBindingSource).EndInit();
            SubjectDetailTabPage.ResumeLayout(false);
            SubjectGroupBox.ResumeLayout(false);
            SubjectGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel TecherPanel;
        private Label CloseTeacherFormBtn;
        private Label SubjectLbl;
        private TabControl SubjectTabControl;
        private TabPage SubjectListTabPage;
        private Button DeleteSubjectBtn;
        private Button EditSubjectBtn;
        private Button AddSubjectBtn;
        private Button SearchSubjectBtn;
        private TextBox SearchSubjectTxb;
        private DataGridView SubjectListDgv;
        private TabPage SubjectDetailTabPage;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn creditsDataGridViewTextBoxColumn;
        private BindingSource subjectBindingSource;
        private GroupBox SubjectGroupBox;
        private Label SubjectCodeLbl;
        private TextBox SubjectNameTxb;
        private Label SubjectNameLbl;
        private TextBox SubjectCreditsTxb;
        private Label SubjectCreditsLbl;
        private TextBox SubjectCodeTxb;
        private Button CancelSaveSubjectBtn;
        private Button SaveSubjectBtn;
        private Label CloseSubjectViewBtn;
    }
}