﻿using EducationCenter.Presenters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EducationCenter
{
    public partial class MainView : Form, IMainView
    {
        private bool isLoggedOut = false;
        public MainView()
        {
            InitializeComponent();
            ShowTeacherViewBtn.Click += delegate
            {
                ShowTeacherView?.Invoke(this, EventArgs.Empty);
                ShowTeacherViewBtn.BackColor = Color.FromArgb(255, 224, 192);
                ShowStudentViewBtn.BackColor = SystemColors.ActiveCaption;
                ShowSubjectViewBtn.BackColor = SystemColors.ActiveCaption;
                ShowAdministratorViewBtn.BackColor = SystemColors.ActiveCaption;
            };
            ShowStudentViewBtn.Click += delegate
            {
                ShowStudentView?.Invoke(this, EventArgs.Empty);
                ShowStudentViewBtn.BackColor = Color.FromArgb(255, 224, 192);
                ShowTeacherViewBtn.BackColor = SystemColors.ActiveCaption;
                ShowSubjectViewBtn.BackColor = SystemColors.ActiveCaption;
                ShowAdministratorViewBtn.BackColor = SystemColors.ActiveCaption;
            };
            ShowSubjectViewBtn.Click += delegate
            {
                ShowSubjectView?.Invoke(this, EventArgs.Empty);
                ShowSubjectViewBtn.BackColor = Color.FromArgb(255, 224, 192);
                ShowTeacherViewBtn.BackColor = SystemColors.ActiveCaption;
                ShowStudentViewBtn.BackColor = SystemColors.ActiveCaption;
                ShowAdministratorViewBtn.BackColor = SystemColors.ActiveCaption;
            };
            ShowAdministratorViewBtn.Click += delegate
            {
                ShowAdministratorView?.Invoke(this, EventArgs.Empty);
                ShowAdministratorViewBtn.BackColor = Color.FromArgb(255, 224, 192);
                ShowTeacherViewBtn.BackColor = SystemColors.ActiveCaption;
                ShowStudentViewBtn.BackColor = SystemColors.ActiveCaption;
                ShowSubjectViewBtn.BackColor = SystemColors.ActiveCaption;
            };
            LogoutBtn.Click += delegate
            {
                LogOutEvent?.Invoke(this, EventArgs.Empty);
            };
        }

        public event EventHandler? ShowTeacherView;
        public event EventHandler? ShowStudentView;
        public event EventHandler? ShowSubjectView;
        public event EventHandler? ShowAdministratorView;
        public event EventHandler? LogOutEvent;
        public bool IsLoggedOut
        { 
            get { return isLoggedOut; }
            set { isLoggedOut = value; }
        }

        private void MainView_Load(object sender, EventArgs e)
        {
            ShowSubjectView?.Invoke(this, EventArgs.Empty);
            ShowSubjectViewBtn.BackColor = Color.FromArgb(255, 224, 192);
            ShowTeacherViewBtn.BackColor = SystemColors.ActiveCaption;
            ShowStudentViewBtn.BackColor = SystemColors.ActiveCaption;
            ShowAdministratorViewBtn.BackColor = SystemColors.ActiveCaption;
        }
    }
}
