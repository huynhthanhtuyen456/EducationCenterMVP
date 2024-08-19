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
            AdminGenderComboBox.DataSource = Enum.GetValues(typeof(GenderEnum));
            AdminWorkingTypeComboBox.DataSource = Enum.GetValues(typeof(WorkingTypeEnum));
            CloseAdministratorViewBtn.Click += delegate { this.Close(); };
        }

        private void AssociateAndRaiseViewEvents()
        {
            /* Start Emitting Event Related to Teacher Record */
            //Search
            SearchAdminBtn.Click += delegate { SearchAdminEvent?.Invoke(this, EventArgs.Empty); };
            SearchAdminTxb.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                    SearchAdminEvent?.Invoke(this, EventArgs.Empty);
            };
            //Add new
            AddAdminBtn.Click += delegate
            {
                AdminTabControl.TabPages.Remove(AdminListTabPage);
                AdminTabControl.TabPages.Remove(AdminDetailTabPage);
                AdminTabControl.TabPages.Add(AdminDetailTabPage);
                AddNewAdminEvent?.Invoke(this, EventArgs.Empty);
                AdminDetailTabPage.Text = "Add new administrator";
            };
            ////Edit
            EditAdminBtn.Click += delegate
            {
                AdminTabControl.TabPages.Remove(AdminListTabPage);
                AdminTabControl.TabPages.Remove(AdminDetailTabPage);
                AdminTabControl.TabPages.Add(AdminDetailTabPage);
                EditAdminEvent?.Invoke(this, EventArgs.Empty);
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
                SaveAdminEvent?.Invoke(this, EventArgs.Empty);
                if (isSuccessfull)
                {
                    AdminTabControl.TabPages.Remove(AdminListTabPage);
                    AdminTabControl.TabPages.Remove(AdminDetailTabPage);
                    AdminTabControl.TabPages.Add(AdminListTabPage);
                }
                MessageBox.Show(Message);
            };
            //Cancel
            CancelAdminBtn.Click += delegate
            {
                CancelAdminEvent?.Invoke(this, EventArgs.Empty);
                AdminTabControl.TabPages.Remove(AdminListTabPage);
                AdminTabControl.TabPages.Remove(AdminDetailTabPage);
                AdminTabControl.TabPages.Add(AdminListTabPage);
            };
            //Delete
            DeleteAdminBtn.Click += delegate
            {
                var result = MessageBox.Show("Are you sure you want to delete the selected administrator?", "Warning",
                      MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    DeleteAdminEvent?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(Message);
                }
            };
            /* End Emitting Event Related to Teacher Record */

        }

        public int AdminId { get; set; }

        public string AdminFirstName
        {
            get { return AdminFirstNameTxb.Text; }
            set { AdminFirstNameTxb.Text = value; }
        }
        public string AdminLastName
        {
            get { return AdminLastNameTxb.Text; }
            set { AdminLastNameTxb.Text = value; }
        }
        public DateOnly AdminDateOfBirth
        {
            get { return DateOnly.FromDateTime(AdminDOBDatePicker.Value); }
            set
            {
                AdminDOBDatePicker.Value = new DateTime(value.Year, value.Month, value.Day);
            }
        }
        public GenderEnum AdminGender
        {
            get { return (GenderEnum)AdminGenderComboBox.SelectedItem; }
            set
            {
                AdminGenderComboBox.SelectedItem = (GenderEnum)value;
            }
        }
        public int AdminAge
        {
            get { return Int32.Parse(AdminAgeTxb.Text); }
            set
            {
                AdminAgeTxb.Text = value.ToString();
            }
        }
        public string AdminEmail
        {
            get { return AdminEmailTxb.Text; }
            set { AdminEmailTxb.Text = value; }
        }
        public string AdminTelephone
        {
            get { return AdminTelephoneTxb.Text; }
            set { AdminTelephoneTxb.Text = value; }
        }

        public WorkingTypeEnum AdminWorkingType
        {
            get { return (WorkingTypeEnum)AdminWorkingTypeComboBox.SelectedItem; }
            set
            {
                AdminWorkingTypeComboBox.SelectedItem = (WorkingTypeEnum)value;
            }
        }
        public int AdminWorkingScheduleId
        {
            get { return (int)AdminWorkingScheduleComboBox.SelectedValue; }
            set { AdminWorkingScheduleComboBox.SelectedValue = value; }
        }
        public float AdminWorkingHours
        {
            get { return float.Parse(AdminWorkingHoursTxb.Text); }
            set { AdminWorkingHoursTxb.Text = value.ToString("0.00"); }
        }
        public decimal AdminSalary
        {
            get { return decimal.Parse(AdminSalaryTxb.Text); }
            set { AdminSalaryTxb.Text = value.ToString(); }
        }

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
        public event EventHandler SearchAdminEvent;
        public event EventHandler AddNewAdminEvent;
        public event EventHandler EditAdminEvent;
        public event EventHandler DeleteAdminEvent;
        public event EventHandler SaveAdminEvent;
        public event EventHandler CancelAdminEvent;
        /* End Definition Event Handler related to Teacher Entity */

        public void SetAdminListBindingSource(BindingSource adminList)
        {
            AdminListDgv.DataSource = adminList;
        }

        public void SetWorkingScheduleListBindingSource(BindingSource workingScheduleList)
        {
            AdminWorkingScheduleComboBox.DisplayMember = "Name";
            AdminWorkingScheduleComboBox.ValueMember = "Id";
            AdminWorkingScheduleComboBox.DataSource = workingScheduleList;
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
