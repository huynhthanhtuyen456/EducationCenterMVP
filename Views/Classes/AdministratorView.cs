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
            AssociateAndRaiseViewEvents();
            AdminTabControl.TabPages.Remove(AdminDetailTabPage);
            GenderComboBox.DataSource = Enum.GetValues(typeof(GenderEnum));
            WorkingTypeComboBox.DataSource = Enum.GetValues(typeof(WorkingTypeEnum));
            CloseAdministratorViewBtn.Click += delegate { this.Close(); };
        }

        private void AssociateAndRaiseViewEvents()
        {
            /* Start Emitting Event Related to Teacher Record */
            //Search
            SearchAdminBtn.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };
            SearchAdminTxb.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                    SearchEvent?.Invoke(this, EventArgs.Empty);
            };
            //Add new
            AddAdminBtn.Click += delegate
            {
                AdminTabControl.TabPages.Remove(AdminListTabPage);
                AdminTabControl.TabPages.Remove(AdminDetailTabPage);
                AdminTabControl.TabPages.Add(AdminDetailTabPage);
                AddNewEvent?.Invoke(this, EventArgs.Empty);
                AdminDetailTabPage.Text = "Add new administrator";
            };
            ////Edit
            EditAdminBtn.Click += delegate
            {
                AdminTabControl.TabPages.Remove(AdminListTabPage);
                AdminTabControl.TabPages.Remove(AdminDetailTabPage);
                AdminTabControl.TabPages.Add(AdminDetailTabPage);
                EditEvent?.Invoke(this, EventArgs.Empty);
                AdminDetailTabPage.Text = "Edit Administrator";
                if (!isEdit)
                {
                    AdminTabControl.TabPages.Remove(AdminListTabPage);
                    AdminTabControl.TabPages.Remove(AdminDetailTabPage);
                    AdminTabControl.TabPages.Add(AdminListTabPage);
                    MessageBox.Show("Does not have any records");
                }
            };
            //Save changes
            SaveAdminBtn.Click += delegate
            {
                SaveEvent?.Invoke(this, EventArgs.Empty);
                if (isSuccessfull)
                {
                    AdminTabControl.TabPages.Remove(AdminListTabPage);
                    AdminTabControl.TabPages.Remove(AdminDetailTabPage);
                    AdminTabControl.TabPages.Add(AdminDetailTabPage);
                }
                MessageBox.Show(Message);
            };
            //Cancel
            CancelAdminBtn.Click += delegate
            {
                CancelEvent?.Invoke(this, EventArgs.Empty);
                AdminTabControl.TabPages.Remove(AdminListTabPage);
                AdminTabControl.TabPages.Remove(AdminDetailTabPage);
                AdminTabControl.TabPages.Add(AdminDetailTabPage);
            };
            //Delete
            DeleteAdminBtn.Click += delegate
            {
                var result = MessageBox.Show("Are you sure you want to delete the selected administrator?", "Warning",
                      MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    DeleteEvent?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(Message);
                }
            };
            /* End Emitting Event Related to Teacher Record */

        }

        public int AdminId { get; set; }

        public string AdminFirstName
        {
            get { return FirstNameTxb.Text; }
            set { FirstNameTxb.Text = value; }
        }
        public string AdminLastName
        {
            get { return LastNameTxb.Text; }
            set { LastNameTxb.Text = value; }
        }
        public DateOnly AdminDateOfBirth
        {
            get { return DateOnly.FromDateTime(DOBDatePicker.Value); }
            set
            {
                DOBDatePicker.Value = new DateTime(value.Year, value.Month, value.Day);
            }
        }
        public GenderEnum AdminGender
        {
            get { return (GenderEnum)GenderComboBox.SelectedItem; }
            set
            {
                GenderComboBox.SelectedItem = (GenderEnum)value;
            }
        }
        public int AdminAge
        {
            get { return Int32.Parse(AgeTxb.Text); }
            set
            {
                AgeTxb.Text = value.ToString();
            }
        }
        public string AdminEmail
        {
            get { return EmailTxb.Text; }
            set { EmailTxb.Text = value; }
        }
        public string AdminTelephone
        {
            get { return TelephoneTxb.Text; }
            set { TelephoneTxb.Text = value; }
        }

        public WorkingTypeEnum AdminWorkingType 
        {
            get { return (WorkingTypeEnum)WorkingTypeComboBox.SelectedItem; }
            set
            {
                WorkingTypeComboBox.SelectedItem = (WorkingTypeEnum)value;
            }
        }
        public int AdminWorkingScheduleId 
        { 
            get { return (int)WorkingScheduleComboBox.SelectedValue; }
            set {  WorkingScheduleComboBox.SelectedValue = value;}
        }
        public float AdminWorkingHours { get; set; }

        public string SearchValue
        {
            get { return SearchAdminTxb.Text; }
            set { SearchAdminTxb.Text = value; }
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
        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;
        /* End Definition Event Handler related to Teacher Entity */

        public void SetAdminListBindingSource(BindingSource adminList)
        {
            AdminListDgv.DataSource = adminList;
        }

        public void SetWorkingScheduleListBindingSource(BindingSource workingScheduleList)
        {
            WorkingScheduleComboBox.DisplayMember = "Name";
            WorkingScheduleComboBox.ValueMember = "Id";
            WorkingScheduleComboBox.DataSource = workingScheduleList;
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
