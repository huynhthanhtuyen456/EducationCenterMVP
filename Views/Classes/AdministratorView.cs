using EducationCenter.Views.Interfaces;
using Helper.Enums;
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
    public partial class AdministratorView : Form, IAdminView
    {
        // Private Properties
        private string message;
        private bool isSuccessfull;
        private bool isEdit;

        public AdministratorView()
        {
            InitializeComponent();
            //AssociateAndRaiseViewEvents();
            //StudentTabControl.TabPages.Remove(StudentDetailTabPage);
            ////StudentTabControl.TabPages.Remove(AssignSubjectTabPage);
            //GenderComboBox.DataSource = Enum.GetValues(typeof(GenderEnum));
            //CloseStudentViewBtn.Click += delegate { this.Close(); };
        }

        private void AssociateAndRaiseViewEvents()
        {
            /* Start Emitting Event Related to Teacher Record */
            //Search
            //SearchStudentBtn.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };
            //SearchStudentTxb.KeyDown += (s, e) =>
            //{
            //    if (e.KeyCode == Keys.Enter)
            //        SearchEvent?.Invoke(this, EventArgs.Empty);
            //};
            ////Add new
            //AddStudentBtn.Click += delegate
            //{
            //    StudentTabControl.TabPages.Remove(StudentListTabPage);
            //    StudentTabControl.TabPages.Remove(StudentDetailTabPage);
            //    StudentTabControl.TabPages.Add(StudentDetailTabPage);
            //    AddNewEvent?.Invoke(this, EventArgs.Empty);
            //    StudentDetailTabPage.Text = "Add new student";
            //};
            ////Edit
            //EditStudentBtn.Click += delegate
            //{
            //    StudentTabControl.TabPages.Remove(StudentListTabPage);
            //    StudentTabControl.TabPages.Remove(StudentDetailTabPage);
            //    StudentTabControl.TabPages.Add(StudentDetailTabPage);
            //    EditEvent?.Invoke(this, EventArgs.Empty);
            //    StudentDetailTabPage.Text = "Edit Student";
            //    if (!isEdit)
            //    {
            //        StudentTabControl.TabPages.Remove(StudentListTabPage);
            //        StudentTabControl.TabPages.Remove(StudentDetailTabPage);
            //        StudentTabControl.TabPages.Add(StudentListTabPage);
            //        MessageBox.Show("Does not have any records");
            //    }
            //};
            ////Save changes
            //SaveStudentBtn.Click += delegate
            //{
            //    SaveEvent?.Invoke(this, EventArgs.Empty);
            //    if (isSuccessfull)
            //    {
            //        StudentTabControl.TabPages.Remove(StudentListTabPage);
            //        StudentTabControl.TabPages.Remove(StudentDetailTabPage);
            //        StudentTabControl.TabPages.Add(StudentListTabPage);
            //    }
            //    MessageBox.Show(Message);
            //};
            ////Cancel
            //CancelStudentBtn.Click += delegate
            //{
            //    CancelEvent?.Invoke(this, EventArgs.Empty);
            //    StudentTabControl.TabPages.Remove(StudentListTabPage);
            //    StudentTabControl.TabPages.Remove(StudentDetailTabPage);
            //    StudentTabControl.TabPages.Add(StudentListTabPage);
            //};
            ////Delete
            //DeleteStudentBtn.Click += delegate
            //{
            //    var result = MessageBox.Show("Are you sure you want to delete the selected student?", "Warning",
            //          MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            //    if (result == DialogResult.Yes)
            //    {
            //        DeleteEvent?.Invoke(this, EventArgs.Empty);
            //        MessageBox.Show(Message);
            //    }
            //};
            /* End Emitting Event Related to Teacher Record */
            //EnrollStudentSubjectBtn.Click += delegate
            //{
            //    StudentTabControl.TabPages.Remove(StudentListTabPage);
            //    StudentTabControl.TabPages.Remove(StudentDetailTabPage);
            //    StudentTabControl.TabPages.Add(AssignSubjectTabPage);
            //    AssignSubjectTabPageEvent?.Invoke(this, EventArgs.Empty);
            //    TeacherDetailTabPage.Text = "Enroll new subject";
            //};
            /* Start Emitting Event To Assign Subject To Teachers */

        }

        public int AdminId { get; set; }

        public string AdminFirstName;
        //{
        //    get { return FirstNameTxb.Text; }
        //    set { FirstNameTxb.Text = value; }
        //}
        public string AdminLastName;
        //{
        //    get { return LastNameTxb.Text; }
        //    set { LastNameTxb.Text = value; }
        //}
        public DateOnly AdminDateOfBirth;
        //{
        //    get { return DateOnly.FromDateTime(DOBDatePicker.Value); }
        //    set
        //    {
        //        DOBDatePicker.Value = new DateTime(value.Year, value.Month, value.Day);
        //    }
        //}
        public GenderEnum AdminGender;
        //{
        //    get { return (GenderEnum)GenderComboBox.SelectedItem; }
        //    set
        //    {
        //        GenderComboBox.SelectedItem = (GenderEnum)value;
        //    }
        //}
        public int AdminAge;
        //{
        //    get { return Int32.Parse(AgeTxb.Text); }
        //    set
        //    {
        //        AgeTxb.Text = value.ToString();
        //    }
        //}
        public string AdminEmail;
        //{
        //    get { return EmailTxb.Text; }
        //    set { EmailTxb.Text = value; }
        //}
        public string AdminTelephone;
        //{
        //    get { return TelephoneTxb.Text; }
        //    set { TelephoneTxb.Text = value; }
        //}

        public string SearchValue;
        //{
        //    get { return SearchStudentTxb.Text; }
        //    set { SearchStudentTxb.Text = value; }
        //}
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
        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;
        /* End Definition Event Handler related to Teacher Entity */

        /* Start Definition Event Handler related to assign Subject To Teachers */
        public event EventHandler AssignSubjectTabPageEvent;
        /* End Definition Event Handler related to assign Subject To Teachers */

        public void SetAdminListBindingSource(BindingSource adminList)
        {
            //StudentListDgv.DataSource = studentList;
        }

        //Singleton pattern (Open a single form instance)
        private static AdministratorView? instance;
        public static AdministratorView GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new AdministratorView();
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
