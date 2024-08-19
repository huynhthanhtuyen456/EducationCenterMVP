using DataLayer.Entities.Teachers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EducationCenter.Views.Interfaces;
using DataLayer.Repositories.Interfaces;
using DataLayer.Repositories.Classes;

namespace EducationCenter.Presenters
{
    public class TeacherPresenter
    {
        //Fields
        private ITeacherView view;
        private ITeacherRepository repository;
        private BindingSource teachersBindingSource;
        private IEnumerable<Teacher> teacherList;

        //Constructor
        public TeacherPresenter(ITeacherView view, ITeacherRepository repository)
        {
            this.teachersBindingSource = new BindingSource();
            this.view = view;
            this.repository = repository;
            //Subscribe event handler methods to view events
            this.view.SearchEvent += SearchTeacher;
            this.view.AddNewEvent += AddNewTeacher;
            this.view.EditEvent += LoadSelectedTeacherToEdit;
            this.view.DeleteEvent += DeleteSelectedTeacher;
            this.view.SaveEvent += SaveTeacher;
            this.view.CancelEvent += CancelAction;
            //Set teachers bindind source
            this.view.SetTeacherListBindingSource(teachersBindingSource);
            //Load teacher list view
            LoadAllTeacherList();
            //Show view
            this.view.Show();
        }

        //Methods
        private void LoadAllTeacherList()
        {
            teacherList = repository.GetAll();
            teachersBindingSource.DataSource = teacherList;//Set data source.
        }
        private void SearchTeacher(object sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            if (emptyValue == false)
                teacherList = repository.Search(this.view.SearchValue);
            else teacherList = repository.GetAll();
            teachersBindingSource.DataSource = teacherList;
        }
        private void AddNewTeacher(object sender, EventArgs e)
        {
            view.IsEdit = false;
        }
        private void LoadSelectedTeacherToEdit(object sender, EventArgs e)
        {
            var teacher = (Teacher)teachersBindingSource.Current;
            view.TeacherId = teacher.Id;
            view.TeacherFirstName = teacher.FirstName;
            view.TeacherLastName = teacher.LastName;
            view.TeacherEmail = teacher.Email;
            view.TeacherGender = teacher.Gender;
            view.TeacherDateOfBirth = teacher.DateOfBirth;
            view.TeacherAge = teacher.Age;
            view.TeacherSalary = teacher.Salary;
            view.TeacherTelephone = teacher.Telephone;
            view.IsEdit = true;
        }
        private void SaveTeacher(object sender, EventArgs e)
        {
            Teacher model = new Teacher
            {
                Id = view.TeacherId,
                FirstName = view.TeacherFirstName,
                LastName = view.TeacherLastName,
                DateOfBirth = view.TeacherDateOfBirth,
                Email = view.TeacherEmail,
                Gender = view.TeacherGender,
                Telephone = view.TeacherTelephone,
                Salary = view.TeacherSalary,
            };
            try
            {
                new Common.ModelDataValidation().Validate(model);
                if (view.IsEdit)//Edit model
                {
                    repository.Edit(model);
                    view.Message = "Teacher edited successfuly";
                }
                else //Add new model
                {
                    repository.Add(model);
                    view.Message = "Teacher added sucessfully";
                }
                view.IsSuccessfull = true;
                LoadAllTeacherList();
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
            view.TeacherId = 0;
            view.TeacherFirstName = "";
            view.TeacherLastName = "";
            view.TeacherEmail = "";
            view.TeacherDateOfBirth = DateOnly.FromDateTime(DateTime.Now);
            view.TeacherAge = 0;
            view.TeacherSalary = 0;
            view.TeacherGender = 0;
        }

        private void CancelAction(object sender, EventArgs e)
        {
            CleanviewFields();
        }
        private void DeleteSelectedTeacher(object sender, EventArgs e)
        {
            try
            {
                var teacher = (Teacher)teachersBindingSource.Current;
                int id = repository.Delete(teacher);
                view.IsSuccessfull = true;
                view.Message = $"Teacher with Id={id} deleted successfully";
                LoadAllTeacherList();
            }
            catch (Exception ex)
            {   
                view.IsSuccessfull = false;
                view.Message = "An error ocurred, could not delete teacher";
            }
        }
    }
}
