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
            TeacherGenderCbox.DataSource = Enum.GetValues(typeof(GenderEnum));
            CloseTeacherFormBtn.Click += delegate { this.Close(); };
        }

        private void AssociateAndRaiseViewEvents()
        {
            //Search
            SearchTeacherBtn.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };
            TchSearchValTxb.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                    SearchEvent?.Invoke(this, EventArgs.Empty);
            };
            //Add new
            AddTeacherBtn.Click += delegate
            {
                TeacherTabControl.TabPages.Remove(TeacherListTabPage);
                TeacherTabControl.TabPages.Add(TeacherDetailTabPage);
                AddNewEvent?.Invoke(this, EventArgs.Empty);
                TeacherDetailTabPage.Text = "Add new teacher";
            };
            //Edit
            EditTeacherBtn.Click += delegate
            {
                TeacherTabControl.TabPages.Remove(TeacherListTabPage);
                TeacherTabControl.TabPages.Add(TeacherDetailTabPage);
                EditEvent?.Invoke(this, EventArgs.Empty);
                TeacherDetailTabPage.Text = "Edit Teacher";
            };
            //Save changes
            TchSaveBtn.Click += delegate
            {
                SaveEvent?.Invoke(this, EventArgs.Empty);
                if (isSuccessfull)
                {
                    TeacherTabControl.TabPages.Remove(TeacherDetailTabPage);
                    TeacherTabControl.TabPages.Add(TeacherListTabPage);
                }
                MessageBox.Show(Message);
            };
            //Cancel
            TchCancelBtn.Click += delegate
            {
                CancelEvent?.Invoke(this, EventArgs.Empty);
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
                    DeleteEvent?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(Message);
                }
            };
        }

        public int TeacherId { get; set; }

        public string TeacherFirstName
        {
            get { return TchFirstNameTxb.Text; }
            set { TchFirstNameTxb.Text = value; }
        }
        public string TeacherLastName
        {
            get { return TchLastNameTxb.Text; }
            set { TchLastNameTxb.Text = value; }
        }
        public DateOnly TeacherDateOfBirth
        {
            get { return DateOnly.FromDateTime(TchDOBDatePicker.Value); }
            set
            {
                TchDOBDatePicker.Value = new DateTime(value.Year, value.Month, value.Day);
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
            get { return Int32.Parse(TchAgeTxb.Text); }
            set
            {
                TchAgeTxb.Text = value.ToString();
            }
        }
        public string TeacherEmail
        {
            get { return TchEmailTxb.Text; }
            set { TchEmailTxb.Text = value; }
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

        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;

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
