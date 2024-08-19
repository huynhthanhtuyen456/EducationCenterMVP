using DataLayer.Entities.Administrators;
using DataLayer.Entities.Students;
using DataLayer.Repositories.Interfaces;
using EducationCenter.Views.Interfaces;
using Helper.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationCenter.Presenters.Classes
{
    public class AdministratorPresenter
    {
        private IAdminView view;
        private IAdministratorRepository repository;
        private BindingSource adminsBindingSource;
        private BindingSource workingSchedulesBindingSource;
        private IEnumerable<Administrator> adminList;
        private IEnumerable<WorkingSchedule> workingScheduleList;

        //Constructor
        public AdministratorPresenter(IAdminView view, IAdministratorRepository repository)
        {
            this.adminsBindingSource = new BindingSource();
            this.workingSchedulesBindingSource = new BindingSource();
            this.view = view;
            this.repository = repository;
            //Subscribe event handler methods to view events
            this.view.SearchAdminEvent += SearchAdmin;
            this.view.AddNewAdminEvent += AddNewAdmin;
            this.view.EditAdminEvent += LoadSelectedAdminToEdit;
            this.view.DeleteAdminEvent += DeleteSelectedAdmin;
            this.view.SaveAdminEvent += SaveAdmin;
            this.view.CancelAdminEvent += CancelAction;
            //Set teachers bindind source
            this.view.SetAdminListBindingSource(adminsBindingSource);
            //Load teacher list view
            LoadAllAdminList();
            LoadAllWorkingSchedules();
            //Show view
            this.view.Show();
        }

        //Methods
        private void LoadAllAdminList()
        {
            adminList = repository.GetAll();
            adminsBindingSource.DataSource = adminList;//Set data source.
        }
        private void LoadAllWorkingSchedules()
        {
            workingScheduleList = repository.GetAllWorkingSchedules();
            workingSchedulesBindingSource.DataSource = workingScheduleList;//Set data source.
        }
        private void SearchAdmin(object sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            if (emptyValue == false)
                adminList = repository.Search(this.view.SearchValue);
            else adminList = repository.GetAll();
            adminsBindingSource.DataSource = adminList;
        }
        private void AddNewAdmin(object sender, EventArgs e)
        {
            this.view.SetWorkingScheduleListBindingSource(workingSchedulesBindingSource);
            view.IsEdit = false;
        }
        private void LoadSelectedAdminToEdit(object sender, EventArgs e)
        {
            Administrator administrator = (Administrator)adminsBindingSource.Current;
            if (administrator == null)
            {
                view.IsEdit = false;
                return;
            }
            this.view.SetWorkingScheduleListBindingSource(workingSchedulesBindingSource);
            view.AdminId = administrator.Id;
            view.AdminFirstName = administrator.FirstName;
            view.AdminLastName = administrator.LastName;
            view.AdminEmail = administrator.Email;
            view.AdminGender = administrator.Gender;
            view.AdminDateOfBirth = administrator.DateOfBirth;
            view.AdminAge = administrator.Age;
            view.AdminTelephone = administrator.Telephone;
            view.AdminSalary = administrator.Salary;
            view.AdminWorkingHours = administrator.WorkingHours;
            view.AdminWorkingSchedule = administrator.WorkingSchedule;
            view.AdminWorkingType = (WorkingTypeEnum)administrator.WorkingType;
            view.IsEdit = true;
        }
        private void SaveAdmin(object sender, EventArgs e)
        {
            Administrator model = new Administrator()
            {
                Id = view.AdminId,
                FirstName = view.AdminFirstName,
                LastName = view.AdminLastName,
                DateOfBirth = view.AdminDateOfBirth,
                Email = view.AdminEmail,
                Gender = view.AdminGender,
                Telephone = view.AdminTelephone,
                Salary = view.AdminSalary,
                WorkingHours = view.AdminWorkingHours,
                WorkingSchedule = view.AdminWorkingSchedule,
                WorkingType = view.AdminWorkingType,
            };
            try
            {
                new Common.ModelDataValidation().Validate(model);
                if (view.IsEdit)//Edit model
                {
                    repository.Edit(model);
                    view.Message = "Administrator edited successfuly";
                }
                else //Add new model
                {
                    repository.Add(model);
                    view.Message = "Administrator added sucessfully";
                }
                view.IsSuccessfull = true;
                LoadAllAdminList();
                CleanviewFields();
            }
            catch (Exception ex)
            {
                view.IsSuccessfull = false;
                view.Message = ex.Message;
            }
        }

        private void CleanviewFields()
        {
            view.AdminId = 0;
            view.AdminFirstName = "";
            view.AdminLastName = "";
            view.AdminEmail = "";
            view.AdminDateOfBirth = DateOnly.FromDateTime(DateTime.Now);
            view.AdminAge = 0;
            view.AdminGender = 0;
            view.AdminSalary = 0;
            view.AdminTelephone = "";
            view.AdminWorkingHours = 0;
            view.AdminWorkingSchedule = null;
            view.AdminWorkingType = 0;
        }

        private void CancelAction(object sender, EventArgs e)
        {
            CleanviewFields();
        }
        private void DeleteSelectedAdmin(object sender, EventArgs e)
        {
            try
            {
                Administrator administrator = (Administrator)adminsBindingSource.Current;
                int id = repository.Delete(administrator);
                view.IsSuccessfull = true;
                view.Message = $"administrator with Id={id} deleted successfully";
                LoadAllAdminList();
            }
            catch (Exception)
            {
                view.IsSuccessfull = false;
                view.Message = "An error ocurred, could not delete administrator! Cannot find administrator.";
            }
        }
    }
}
