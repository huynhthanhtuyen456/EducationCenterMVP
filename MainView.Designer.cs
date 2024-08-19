namespace EducationCenter
{
    partial class MainView
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
            ShowTeacherViewBtn = new Button();
            panel1 = new Panel();
            LogoutBtn = new Button();
            ShowSubjectViewBtn = new Button();
            ShowStudentViewBtn = new Button();
            panel2 = new Panel();
            EducationCenterLbl = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // ShowTeacherViewBtn
            // 
            ShowTeacherViewBtn.BackColor = SystemColors.ActiveCaption;
            ShowTeacherViewBtn.Cursor = Cursors.Hand;
            ShowTeacherViewBtn.FlatAppearance.BorderSize = 0;
            ShowTeacherViewBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 224, 192);
            ShowTeacherViewBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 192, 128);
            ShowTeacherViewBtn.FlatStyle = FlatStyle.Flat;
            ShowTeacherViewBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ShowTeacherViewBtn.Location = new Point(3, 51);
            ShowTeacherViewBtn.Name = "ShowTeacherViewBtn";
            ShowTeacherViewBtn.Size = new Size(194, 23);
            ShowTeacherViewBtn.TabIndex = 1;
            ShowTeacherViewBtn.Text = "Teacher";
            ShowTeacherViewBtn.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(LogoutBtn);
            panel1.Controls.Add(ShowSubjectViewBtn);
            panel1.Controls.Add(ShowStudentViewBtn);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(ShowTeacherViewBtn);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 534);
            panel1.TabIndex = 2;
            // 
            // LogoutBtn
            // 
            LogoutBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LogoutBtn.Cursor = Cursors.Hand;
            LogoutBtn.FlatAppearance.BorderSize = 0;
            LogoutBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 224, 192);
            LogoutBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 192, 128);
            LogoutBtn.FlatStyle = FlatStyle.Flat;
            LogoutBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LogoutBtn.Location = new Point(3, 508);
            LogoutBtn.Name = "LogoutBtn";
            LogoutBtn.Size = new Size(194, 23);
            LogoutBtn.TabIndex = 5;
            LogoutBtn.Text = "Log Out";
            LogoutBtn.UseVisualStyleBackColor = true;
            // 
            // ShowSubjectViewBtn
            // 
            ShowSubjectViewBtn.Cursor = Cursors.Hand;
            ShowSubjectViewBtn.FlatAppearance.BorderSize = 0;
            ShowSubjectViewBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 224, 192);
            ShowSubjectViewBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 192, 128);
            ShowSubjectViewBtn.FlatStyle = FlatStyle.Flat;
            ShowSubjectViewBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ShowSubjectViewBtn.Location = new Point(3, 109);
            ShowSubjectViewBtn.Name = "ShowSubjectViewBtn";
            ShowSubjectViewBtn.Size = new Size(194, 23);
            ShowSubjectViewBtn.TabIndex = 4;
            ShowSubjectViewBtn.Text = "Subject";
            ShowSubjectViewBtn.UseVisualStyleBackColor = true;
            // 
            // ShowStudentViewBtn
            // 
            ShowStudentViewBtn.BackColor = SystemColors.ActiveCaption;
            ShowStudentViewBtn.Cursor = Cursors.Hand;
            ShowStudentViewBtn.FlatAppearance.BorderSize = 0;
            ShowStudentViewBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 224, 192);
            ShowStudentViewBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 192, 128);
            ShowStudentViewBtn.FlatStyle = FlatStyle.Flat;
            ShowStudentViewBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ShowStudentViewBtn.Location = new Point(3, 80);
            ShowStudentViewBtn.Name = "ShowStudentViewBtn";
            ShowStudentViewBtn.Size = new Size(194, 23);
            ShowStudentViewBtn.TabIndex = 3;
            ShowStudentViewBtn.Text = "Student";
            ShowStudentViewBtn.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(EducationCenterLbl);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(194, 42);
            panel2.TabIndex = 2;
            // 
            // EducationCenterLbl
            // 
            EducationCenterLbl.AutoSize = true;
            EducationCenterLbl.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EducationCenterLbl.Location = new Point(24, 6);
            EducationCenterLbl.Name = "EducationCenterLbl";
            EducationCenterLbl.Size = new Size(141, 21);
            EducationCenterLbl.TabIndex = 0;
            EducationCenterLbl.Text = "Education Center";
            // 
            // MainView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(962, 534);
            Controls.Add(panel1);
            IsMdiContainer = true;
            MinimumSize = new Size(978, 573);
            Name = "MainView";
            Text = "Education Center";
            Load += MainView_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button ShowTeacherViewBtn;
        private Panel panel1;
        private Panel panel2;
        private Label EducationCenterLbl;
        private Button ShowStudentViewBtn;
        private Button ShowSubjectViewBtn;
        private Button LogoutBtn;
    }
}