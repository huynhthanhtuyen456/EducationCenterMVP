using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLayer.Entities.Subjects;
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
        private bool isSuccessfullSub1;
        private bool isSuccessfullSub2;
        private bool isEdit;
        private bool isEditSub1;
        private bool isEditSub2;

        /*
         * Initialize Teacher Form and Delegate Event to Presenter
         */
        public TeacherView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
            TeacherTabControl.TabPages.Remove(TeacherDetailTabPage);
            TeacherTabControl.TabPages.Remove(AssignSubjectTabPage);
            TeacherGenderCbox.DataSource = Enum.GetValues(typeof(GenderEnum));
            CloseTeacherFormBtn.Click += delegate { this.Close(); };
        }

        /*
         * Associate events related to Form
         */
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
            };
            SaveSub1Btn.Click += delegate
            {

                SaveSubject1Event?.Invoke(this, EventArgs.Empty);
                if (isSuccessfull)
                {
                    TeacherTabControl.TabPages.Remove(TeacherListTabPage);
                    TeacherTabControl.TabPages.Remove(TeacherDetailTabPage);
                    TeacherTabControl.TabPages.Remove(AssignSubjectTabPage);
                    TeacherTabControl.TabPages.Add(TeacherDetailTabPage);
                    TeacherDetailTabPage.Text = "Edit Teacher";
                }
                MessageBox.Show(Message);
            };
            CancelSub1Btn.Click += delegate
            {
                CancelSubject1Event?.Invoke(this, EventArgs.Empty);
                TeacherTabControl.TabPages.Remove(TeacherListTabPage);
                TeacherTabControl.TabPages.Remove(TeacherDetailTabPage);
                TeacherTabControl.TabPages.Remove(AssignSubjectTabPage);
                TeacherTabControl.TabPages.Add(TeacherListTabPage);
            };
            SaveSub2Btn.Click += delegate
            {
                SaveSubject2Event?.Invoke(this, EventArgs.Empty);
                if (isSuccessfull)
                {
                    TeacherTabControl.TabPages.Remove(TeacherListTabPage);
                    TeacherTabControl.TabPages.Remove(TeacherDetailTabPage);
                    TeacherTabControl.TabPages.Remove(AssignSubjectTabPage);
                    TeacherTabControl.TabPages.Add(TeacherDetailTabPage);
                    TeacherDetailTabPage.Text = "Edit Teacher";
                }
                MessageBox.Show(Message);
            };
            CancelSub2Btn.Click += delegate
            {
                CancelSubject2Event?.Invoke(this, EventArgs.Empty);
                TeacherTabControl.TabPages.Remove(TeacherListTabPage);
                TeacherTabControl.TabPages.Remove(TeacherDetailTabPage);
                TeacherTabControl.TabPages.Remove(AssignSubjectTabPage);
                TeacherTabControl.TabPages.Add(TeacherListTabPage);
            };
            /* Start Emitting Event To Assign Subject To Teachers */

        }

        /*
         * Define Public Property View to Presenter
         */
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
        public bool IsEditSubject1
        {
            get { return isEditSub1; }
            set { isEditSub1 = value; }
        }
        public bool IsEditSubject2
        {
            get { return isEditSub2; }
            set { isEditSub2 = value; }
        }
        public bool IsSuccessfull
        {
            get { return isSuccessfull; }
            set { isSuccessfull = value; }
        }
        public bool IsSuccessfullSub1
        {
            get { return isSuccessfullSub1; }
            set { isSuccessfullSub1 = value; }
        }
        public bool IsSuccessfullSub2
        {
            get { return isSuccessfullSub2; }
            set { isSuccessfullSub2 = value; }
        }
        public string Message
        {
            get { return message; }
            set { message = value; }
        }

        /*
         * Start Define view for assign subject to teacher
         */
        public int TeacherSubject1Id { get; set; }
        public Subject Subject1
        { 
            get 
            {
                return (Subject)Subject1ComboBox.SelectedItem;
            }
            set 
            { 
                if (value != null)
                {
                    Subject1ComboBox.SelectedItem = value;
                }
                else
                {
                    Subject1ComboBox.SelectedIndex = 0;
                }
            }
        }
        public DateTime StartDateSubject1 
        { 
            get { return StartDateSubject1DtPck.Value; }
            set { StartDateSubject1DtPck.Value = value; }
        }
        public DateTime EndDateSubject1
        {
            get { return EndDateSubject1DtPck.Value; }
            set { EndDateSubject1DtPck.Value = value; }
        }
        public bool IsFinishedSubject1 
        { 
            get { return FinishedSubject1CheckBox.Checked; }
            set
            {
                FinishedSubject1CheckBox.Checked = value;
            }
        }

        public int TeacherSubject2Id { get; set; }
        public Subject Subject2
        {
            get
            {
                return (Subject)Subject2ComboBox.SelectedItem;
            }
            set 
            { 
                if (value != null)
                {
                    Subject2ComboBox.SelectedItem = value;
                }
                else
                {
                    Subject2ComboBox.SelectedIndex = 0;
                }
            }
        }
        public DateTime StartDateSubject2
        {
            get { return StartDateSub2DtPck.Value; }
            set { StartDateSub2DtPck.Value = value; }
        }
        public DateTime EndDateSubject2
        {
            get { return EndDateSub2DtPck.Value; }
            set { EndDateSub2DtPck.Value = value; }
        }
        public bool IsFinishedSubject2
        {
            get { return FinishedSub2CheckBox.Checked; }
            set
            {
                FinishedSub2CheckBox.Checked = value;
            }
        }
        /*
         * End Define view for assign subject to teacher
         */

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
        public event EventHandler SaveSubject1Event;
        public event EventHandler CancelSubject1Event;
        public event EventHandler SaveSubject2Event;
        public event EventHandler CancelSubject2Event;
        /* End Definition Event Handler related to assign Subject To Teachers */

        public void SetTeacherListBindingSource(BindingSource teacherList)
        {
            TeacherDGView.DataSource = teacherList;
        }

        public void SetTeachingSubjectListBindingSource(BindingSource teachingSubjectList)
        {
            TeachingSubjectsDataGridView.DataSource = teachingSubjectList;
        }

        public void SetTaughtSubjectListBindingSource(BindingSource taughtSubjectList)
        {
            TaughtSubjectsDataGridView.DataSource = taughtSubjectList;
        }

        public void SetSubjectListCombox1BindingSource(BindingSource subjectList)
        {
            Subject1ComboBox.DisplayMember = "Name";
            Subject1ComboBox.ValueMember = "Id";
            Subject1ComboBox.DataSource = subjectList;

            if (isEditSub1)
            {
                Subject1ComboBox.Enabled = false;
                if (!IsFinishedSubject1)
                {
                    TeachingSub1CheckedBox.Checked = true;
                }
                else
                {
                    TeachingSub1CheckedBox.Checked = false;
                }
            }
            else
            {
                Subject1ComboBox.Enabled = true;
            }
        }

        public void SetSubjectListCombox2BindingSource(BindingSource subjectList)
        {
            Subject2ComboBox.DisplayMember = "Name";
            Subject2ComboBox.ValueMember = "Id";
            Subject2ComboBox.DataSource = subjectList;

            if (isEditSub2)
            {
                Subject2ComboBox.Enabled = false;
                if (!IsFinishedSubject2)
                {
                    TeachingSub2CheckedBox.Checked = true;
                }
                else
                {
                    TeachingSub2CheckedBox.Checked = false;
                }
            }
            else
            {
                Subject2ComboBox.Enabled = true;
            }
        }

        //Singleton pattern (Open a single form instance)
        private static TeacherView? instance;
        public static TeacherView GetInstance(Form parentContainer)
        {
            foreach (Form c in parentContainer.MdiChildren)
            {
                c.Close();
            }
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
