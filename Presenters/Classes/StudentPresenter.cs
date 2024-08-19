using DataLayer.Entities.Students;
using DataLayer.Entities.Teachers;
using DataLayer.Repositories.Classes;
using DataLayer.Repositories.Interfaces;
using EducationCenter.Views.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationCenter.Presenters.Classes
{
    public class StudentPresenter
    {
        //Fields
        private IStudentView view;
        private IStudentRepository repository;
        private BindingSource studentsBindingSource;
        private IEnumerable<Student> studentList;

        //Constructor
        public StudentPresenter(IStudentView view, IStudentRepository repository)
        {
            this.studentsBindingSource = new BindingSource();
            this.view = view;
            this.repository = repository;
            //Subscribe event handler methods to view events
            this.view.SearchEvent += SearchStudent;
            this.view.AddNewEvent += AddNewStudent;
            this.view.EditEvent += LoadSelectedStudentToEdit;
            this.view.DeleteEvent += DeleteSelectedStudent;
            this.view.SaveEvent += SaveStudent;
            this.view.CancelEvent += CancelAction;
            //Set teachers bindind source
            this.view.SetStudentListBindingSource(studentsBindingSource);
            //Load teacher list view
            LoadAllStudentList();
            //Show view
            this.view.Show();
        }

        //Methods
        private void LoadAllStudentList()
        {
            studentList = repository.GetAll();
            studentsBindingSource.DataSource = studentList;//Set data source.
        }
        private void SearchStudent(object sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            if (emptyValue == false)
                studentList = repository.Search(this.view.SearchValue);
            else studentList = repository.GetAll();
            studentsBindingSource.DataSource = studentList;
        }
        private void AddNewStudent(object sender, EventArgs e)
        {
            view.IsEdit = false;
        }
        private void LoadSelectedStudentToEdit(object sender, EventArgs e)
        {
            var student = (Student)studentsBindingSource.Current;
            view.StudentId = student.Id;
            view.StudentFirstName = student.FirstName;
            view.StudentLastName = student.LastName;
            view.StudentEmail = student.Email;
            view.StudentGender = student.Gender;
            view.StudentDateOfBirth = student.DateOfBirth;
            view.StudentAge = student.Age;
            view.StudentTelephone = student.Telephone;
            view.IsEdit = true;
        }
        private void SaveStudent(object sender, EventArgs e)
        {
            Student model = new Student
            {
                Id = view.StudentId,
                FirstName = view.StudentFirstName,
                LastName = view.StudentLastName,
                DateOfBirth = view.StudentDateOfBirth,
                Email = view.StudentEmail,
                Gender = view.StudentGender,
                Telephone = view.StudentTelephone,
            };
            try
            {
                new Common.ModelDataValidation().Validate(model);
                if (view.IsEdit)//Edit model
                {
                    repository.Edit(model);
                    view.Message = "Student edited successfuly";
                }
                else //Add new model
                {
                    repository.Add(model);
                    view.Message = "Student added sucessfully";
                }
                view.IsSuccessfull = true;
                LoadAllStudentList();
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
            view.StudentId = 0;
            view.StudentFirstName = "";
            view.StudentLastName = "";
            view.StudentEmail = "";
            view.StudentDateOfBirth = DateOnly.FromDateTime(DateTime.Now);
            view.StudentAge = 0;
            view.StudentGender = 0;
        }

        private void CancelAction(object sender, EventArgs e)
        {
            CleanviewFields();
        }
        private void DeleteSelectedStudent(object sender, EventArgs e)
        {
            try
            {
                var student = (Student)studentsBindingSource.Current;
                int id = repository.Delete(student);
                view.IsSuccessfull = true;
                view.Message = $"Student with Id={id} deleted successfully";
                LoadAllStudentList();
            }
            catch (Exception ex)
            {
                view.IsSuccessfull = false;
                view.Message = "An error ocurred, could not delete student";
            }
        }
    }
}
