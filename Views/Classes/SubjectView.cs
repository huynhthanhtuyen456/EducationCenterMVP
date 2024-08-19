﻿using EducationCenter.Views.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EducationCenter.Views.Classes
{
    public partial class SubjectView : Form, ISubjectView
    {
        // Private Properties
        private string message;
        private bool isSuccessfull;
        private bool isEdit;

        public SubjectView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
            SubjectTabControl.TabPages.Remove(SubjectDetailTabPage);
            CloseTeacherFormBtn.Click += delegate { this.Close(); };
        }

        private void AssociateAndRaiseViewEvents()
        {
            //Search
            SearchSubjectBtn.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };
            SearchSubjectTxb.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                    SearchEvent?.Invoke(this, EventArgs.Empty);
            };
            //Add new
            AddSubjectBtn.Click += delegate
            {
                AddNewEvent?.Invoke(this, EventArgs.Empty);
                SubjectTabControl.TabPages.Remove(SubjectListTabPage);
                SubjectTabControl.TabPages.Add(SubjectDetailTabPage);
                SubjectDetailTabPage.Text = "Add new subject";
            };
            //Edit
            EditSubjectBtn.Click += delegate
            {
                SubjectTabControl.TabPages.Remove(SubjectListTabPage);
                SubjectTabControl.TabPages.Add(SubjectDetailTabPage);
                SubjectDetailTabPage.Text = "Edit Subject";
                EditEvent?.Invoke(this, EventArgs.Empty);
            };
            //Save changes
            SaveSubjectBtn.Click += delegate
            {
                SaveEvent?.Invoke(this, EventArgs.Empty);
                if (isSuccessfull)
                {
                    SubjectTabControl.TabPages.Remove(SubjectDetailTabPage);
                    SubjectTabControl.TabPages.Add(SubjectListTabPage);
                }
                MessageBox.Show(Message);
            };
            //Cancel
            CancelSaveSubjectBtn.Click += delegate
            {
                CancelEvent?.Invoke(this, EventArgs.Empty);
                SubjectTabControl.TabPages.Remove(SubjectDetailTabPage);
                SubjectTabControl.TabPages.Add(SubjectListTabPage);
            };
            //Delete
            DeleteSubjectBtn.Click += delegate
            {
                var result = MessageBox.Show("Are you sure you want to delete the selected subject?", "Warning",
                      MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    DeleteEvent?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(Message);
                }
            };
        }

        public int SubjectId { get ; set; }
        public string SubjectName 
        { 
            get => SubjectNameTxb.Text;
            set => SubjectNameTxb.Text = value;
        }
        public string SubjectCode 
        { 
            get => SubjectCodeTxb.Text;
            set => SubjectCodeTxb.Text = value;
        }
        public int SubjectCredits 
        { 
            get => Int32.Parse(SubjectCreditsTxb.Text);
            set => SubjectCreditsTxb.Text = value.ToString();
        }
        public string SearchValue
        {
            get { return SearchSubjectTxb.Text; }
            set { SearchSubjectTxb.Text = value; }
        }
        public bool IsEdit
        {
            get { return isEdit; }
            set { isEdit = value; }
        }
        public bool IsSuccessfull
        {
            get { return isSuccessfull; }
            set { isSuccessfull = value; }
        }
        public string Message
        {
            get { return message; }
            set { message = value; }
        }

        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;

        public void SetSubjectListBindingSource(BindingSource subjectList)
        {
            SubjectListDgv.DataSource = subjectList;
        }

        //Singleton pattern (Open a single form instance)
        private static SubjectView? instance;
        public static SubjectView GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new SubjectView();
                instance.MdiParent = parentContainer;
                instance.FormBorderStyle = FormBorderStyle.None;
                instance.Dock = DockStyle.Fill;
            }
            else
            {
                if (instance.WindowState == FormWindowState.Minimized)
                    instance.WindowState = FormWindowState.Normal;
                instance.BringToFront();
            }
            return instance;
        }
    }
}
