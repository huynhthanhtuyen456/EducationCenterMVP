using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EducationCenter.Views.Interfaces;
using Helper.Enums;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace EducationCenter
{
    public partial class TeacherView : Form, ITeacherView
    {
        // Private Properties
        private string message;
        private bool isSuccessfull;
        private bool isEdit;

        public TeacherView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
            TeacherTabControl.TabPages.Remove(TeacherDetailTabPage);
            TeacherTabControl.TabPages.Remove(AssignSubjectTabPage);
            TeacherGenderCbox.DataSource = Enum.GetValues(typeof(GenderEnum));
            CloseTeacherFormBtn.Click += delegate { this.Close(); };
        }

        private void AssociateAndRaiseViewEvents()
        {
            /* Start Emitting Event Related to Teacher Record */
            //Search
            SearchTeacherBtn.Click += delegate { SearchTeacherEvent?.Invoke(this, EventArgs.Empty); };
            TchSearchValTxb.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                    SearchTeacherEvent?.Invoke(this, EventArgs.Empty);
            };
            //Add new
            AddTeacherBtn.Click += delegate
            {
                TeacherTabControl.TabPages.Remove(AssignSubjectTabPage);
                TeacherTabControl.TabPages.Remove(TeacherListTabPage);
                TeacherTabControl.TabPages.Add(TeacherDetailTabPage);
                AddNewTeacherEvent?.Invoke(this, EventArgs.Empty);
                TeacherDetailTabPage.Text = "Add new teacher";
            };
            //Edit
            EditTeacherBtn.Click += delegate
            {
                TeacherTabControl.TabPages.Remove(AssignSubjectTabPage);
                TeacherTabControl.TabPages.Remove(TeacherListTabPage);
                TeacherTabControl.TabPages.Add(TeacherDetailTabPage);
                EditTeacherEvent?.Invoke(this, EventArgs.Empty);
                TeacherDetailTabPage.Text = "Edit Teacher";
            };
            //Save changes
            TchSaveBtn.Click += delegate
            {
                SaveTeacherEvent?.Invoke(this, EventArgs.Empty);
                if (isSuccessfull)
                {
                    TeacherTabControl.TabPages.Remove(AssignSubjectTabPage);
                    TeacherTabControl.TabPages.Remove(TeacherDetailTabPage);
                    TeacherTabControl.TabPages.Add(TeacherListTabPage);
                }
                MessageBox.Show(Message);
            };
            //Cancel
            TchCancelBtn.Click += delegate
            {
                CancelTeacherEvent?.Invoke(this, EventArgs.Empty);
                TeacherTabControl.TabPages.Remove(AssignSubjectTabPage);
                TeacherTabControl.TabPages.Remove(TeacherDetailTabPage);
                TeacherTabControl.TabPages.Add(TeacherListTabPage);
            };
            //Delete
            DeleteTeacherBtn.Click += delegate
            {
                var result = MessageBox.Show("Are you sure you want to delete the selected teacher?", "Warning",
                      MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    DeleteTeacherEvent?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(Message);
                }
            };
            /* End Emitting Event Related to Teacher Record */
            AssignSubjectBtn.Click += delegate
            {
                TeacherTabControl.TabPages.Remove(TeacherListTabPage);
                TeacherTabControl.TabPages.Remove(TeacherDetailTabPage);
                TeacherTabControl.TabPages.Add(AssignSubjectTabPage);
                AssignSubjectTabPageEvent?.Invoke(this, EventArgs.Empty);
                TeacherDetailTabPage.Text = "Add new teacher";
            };
            /* Start Emitting Event To Assign Subject To Teachers */

        }

        public int TeacherId { get; set; }

        public string TeacherFirstName
        {
            get { return TeacherFirstNameTxb.Text; }
            set { TeacherFirstNameTxb.Text = value; }
        }
        public string TeacherLastName
        {
            get { return TeacherLastNameTxb.Text; }
            set { TeacherLastNameTxb.Text = value; }
        }
        public DateOnly TeacherDateOfBirth
        {
            get { return DateOnly.FromDateTime(TeacherDOBDatePicker.Value); }
            set
            {
                TeacherDOBDatePicker.Value = new DateTime(value.Year, value.Month, value.Day);
            }
        }
        public GenderEnum TeacherGender
        {
            get { return (GenderEnum)TeacherGenderCbox.SelectedItem; }
            set
            {
                TeacherGenderCbox.SelectedItem = (GenderEnum)value;
            }
        }
        public int TeacherAge
        {
            get { return Int32.Parse(TeacherAgeTxb.Text); }
            set
            {
                TeacherAgeTxb.Text = value.ToString();
            }
        }
        public string TeacherEmail
        {
            get { return TeacherEmailTxb.Text; }
            set { TeacherEmailTxb.Text = value; }
        }
        public decimal TeacherSalary
        {
            get { return Decimal.Parse(TeacherSalaryTxb.Text); }
            set { TeacherSalaryTxb.Text = value.ToString(); }
        }
        public string TeacherTelephone
        {
            get { return TeacherTelephoneTxb.Text; }
            set { TeacherTelephoneTxb.Text = value; }
        }

        public string SearchValue
        {
            get { return TchSearchValTxb.Text; }
            set { TchSearchValTxb.Text = value; }
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

        /* Definition Event Handler related to Teacher Entity */
        public event EventHandler SearchTeacherEvent;
        public event EventHandler AddNewTeacherEvent;
        public event EventHandler EditTeacherEvent;
        public event EventHandler DeleteTeacherEvent;
        public event EventHandler SaveTeacherEvent;
        public event EventHandler CancelTeacherEvent;
        /* End Definition Event Handler related to Teacher Entity */

        /* Start Definition Event Handler related to assign Subject To Teachers */
        public event EventHandler AssignSubjectTabPageEvent;
        /* End Definition Event Handler related to assign Subject To Teachers */

        public void SetTeacherListBindingSource(BindingSource teacherList)
        {
            TeacherDGView.DataSource = teacherList;
        }

        //Singleton pattern (Open a single form instance)
        private static TeacherView? instance;
        public static TeacherView GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new TeacherView();
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
