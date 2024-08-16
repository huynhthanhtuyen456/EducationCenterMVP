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
            panel2 = new Panel();
            EducationCenterLbl = new Label();
            ShowStudentViewBtn = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // ShowTeacherViewBtn
            // 
            ShowTeacherViewBtn.BackColor = SystemColors.Control;
            ShowTeacherViewBtn.Location = new Point(3, 51);
            ShowTeacherViewBtn.Name = "ShowTeacherViewBtn";
            ShowTeacherViewBtn.Size = new Size(194, 23);
            ShowTeacherViewBtn.TabIndex = 1;
            ShowTeacherViewBtn.Text = "Teacher";
            ShowTeacherViewBtn.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(ShowStudentViewBtn);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(ShowTeacherViewBtn);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 483);
            panel1.TabIndex = 2;
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
            // ShowStudentViewBtn
            // 
            ShowStudentViewBtn.BackColor = SystemColors.Control;
            ShowStudentViewBtn.Location = new Point(3, 80);
            ShowStudentViewBtn.Name = "ShowStudentViewBtn";
            ShowStudentViewBtn.Size = new Size(194, 23);
            ShowStudentViewBtn.TabIndex = 3;
            ShowStudentViewBtn.Text = "Student";
            ShowStudentViewBtn.UseVisualStyleBackColor = false;
            // 
            // MainView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(827, 483);
            Controls.Add(panel1);
            IsMdiContainer = true;
            Name = "MainView";
            Text = "MainView";
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
    }
}