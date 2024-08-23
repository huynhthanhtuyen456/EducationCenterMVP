using DataLayer.Entities.Teachers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EducationCenter.Views.Interfaces;
using DataLayer.Repositories.Interfaces;
using DataLayer.Repositories.Classes;
using Helper.Objects;
using DataLayer.Entities.Subjects;

namespace EducationCenter.Presenters
{
    public class TeacherPresenter
    {
        //Fields
        private ITeacherView view;
        private ITeacherRepository repository;
        private BindingSource teachersBindingSource;
        private BindingSource teachingSubjectListBindingSource;
        private BindingSource taughtSubjectListBindingSource;
        private BindingSource subject1ListBindingSource;
        private BindingSource subject2ListBindingSource;
        private IEnumerable<Teacher> teacherList;
        private IEnumerable<Subject> subject1List;
        private IEnumerable<Subject> subject2List;
        private IEnumerable<TeachingSubject> teachingSubjectList;
        private IEnumerable<TaughtSubject> taughtSubjectList;

        //Constructor
        public TeacherPresenter(ITeacherView view, ITeacherRepository repository)
        {
            this.teachersBindingSource = new BindingSource();
            this.teachingSubjectListBindingSource = new BindingSource();
            this.taughtSubjectListBindingSource = new BindingSource();
            this.subject1ListBindingSource = new BindingSource();
            this.subject2ListBindingSource = new BindingSource();
            this.view = view;
            this.repository = repository;
            //Subscribe event handler methods to view events
            this.view.SearchTeacherEvent += SearchTeacher;
            this.view.AddNewTeacherEvent += AddNewTeacher;
            this.view.EditTeacherEvent += LoadSelectedTeacherToEdit;
            this.view.DeleteTeacherEvent += DeleteSelectedTeacher;
            this.view.SaveTeacherEvent += SaveTeacher;
            this.view.CancelTeacherEvent += CancelAction;
            // Assign subjects event handlers
            this.view.AssignSubjectTabPageEvent += AssignSubjectTabPageEvent;
            this.view.SaveSubject1Event += SaveSubject1;
            this.view.CancelSubject1Event += CancelSubject1;
            this.view.SaveSubject2Event += SaveSubject2;
            this.view.CancelSubject2Event += CancelSubject2;
            //Set teachers bindind source
            this.view.SetTeacherListBindingSource(teachersBindingSource);
            this.view.SetSubjectListCombox1BindingSource(subject1ListBindingSource);
            this.view.SetSubjectListCombox2BindingSource(subject2ListBindingSource);
            //Load teacher list view
            LoadAllTeacherList();
            LoadAllSubjectList();
            //Show view
            this.view.Show();
        }

        //Methods
        private void LoadAllTeacherList()
        {
            teacherList = repository.GetAll();
            teachersBindingSource.DataSource = teacherList;//Set data source.
        }
        private void LoadAllSubjectList()
        {
            subject1List = repository.GetAllSubject();
            subject1ListBindingSource.DataSource = subject1List;

            subject2List = subject1List;
            subject2ListBindingSource.DataSource = subject2List;
        }
        private void LoadTeachingSubjectList(int teacherId)
        {
            teachingSubjectList = repository.GetAllTeachingSubject(teacherId);
            teachingSubjectListBindingSource.DataSource = teachingSubjectList;//Set data source.
        }
        private void LoadTaughtSubjectList(int teacherId)
        {
            taughtSubjectList = repository.GetAllTaughtSubject(teacherId);
            taughtSubjectListBindingSource.DataSource = taughtSubjectList;//Set data source.
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

        private void AssignSubjectTabPageEvent(object sender, EventArgs e)
        {
            LoadSelectedTeacher();
            IEnumerable<TeacherSubject> teachingSubjects = repository.GetAllTeachingSubjectToEdit(this.view.TeacherId);
            var teachingSubjectArray = teachingSubjects.ToArray();
            if (teachingSubjectArray.Length < 0)
            {
                view.IsEditSubject1 = false;
                view.IsEditSubject2 = false;
            }
            for (int i = 0; i < teachingSubjectArray.Length; i++)
            {
                view.IsEditSubject1 = true;
                view.TeacherSubject1Id = teachingSubjectArray[i].Id;
                view.StartDateSubject1 = (DateTime)teachingSubjectArray[i].StartTime;
                view.EndDateSubject1 = (DateTime)teachingSubjectArray[i].EndTime;
                view.Subject1 = teachingSubjectArray[i].Subject;
                view.IsFinishedSubject1 = (bool)teachingSubjectArray[i].IsFinished;
                if (i + 1 < teachingSubjectArray.Length)
                {
                    view.IsEditSubject2 = true;
                    view.TeacherSubject2Id = teachingSubjectArray[i+1].Id;
                    view.StartDateSubject2 = (DateTime)teachingSubjectArray[i+1].StartTime;
                    view.EndDateSubject2 = (DateTime)teachingSubjectArray[i+1].EndTime;
                    view.Subject2 = teachingSubjectArray[i+1].Subject;
                    view.IsFinishedSubject2 = (bool)teachingSubjectArray[i+1].IsFinished;
                    break;
                }
            }
            LoadAllSubjectList();
            this.view.SetSubjectListCombox1BindingSource(subject1ListBindingSource);
            this.view.SetSubjectListCombox2BindingSource(subject2ListBindingSource);
        }

        private void LoadSelectedTeacher()
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
            LoadTeachingSubjectList(teacher.Id);
            LoadTaughtSubjectList(teacher.Id);
            this.view.SetTeachingSubjectListBindingSource(teachingSubjectListBindingSource);
            this.view.SetTaughtSubjectListBindingSource(taughtSubjectListBindingSource);
        }

        private void LoadSelectedTeacherToEdit(object sender, EventArgs e)
        {
            LoadSelectedTeacher();
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

        private void SaveSubject1(object sender, EventArgs e)
        {
            TeacherSubject model = new TeacherSubject
            {
                Id = view.TeacherSubject1Id,
                TeacherId = view.TeacherId,
                Subject = view.Subject1,
                StartTime = view.StartDateSubject1,
                EndTime = view.EndDateSubject1,
                IsFinished = view.IsFinishedSubject1,
            };
            try
            {
                new Common.ModelDataValidation().Validate(model);
                if (view.IsEditSubject1)//Edit model
                {
                    repository.EditSubject1(model);
                    view.Message = "Subject 1 assigned successfuly";
                }
                else //Add new model
                {
                    repository.AddSubject1(model);
                    view.Message = "Subject 1 edited successfuly";
                }
                view.IsSuccessfull = true;
                view.IsEdit = true;
                view.IsEditSubject1 = true;
                LoadSelectedTeacher();
                CleanviewAssignSubFields();
            }
            catch (Exception ex)
            {
                view.IsSuccessfull = false;
                view.Message = ex.Message;
            }
        }

        private void SaveSubject2(object sender, EventArgs e)
        {
            TeacherSubject model = new TeacherSubject
            {
                Id = view.TeacherSubject2Id,
                TeacherId = view.TeacherId,
                Subject = view.Subject2,
                StartTime = view.StartDateSubject2,
                EndTime = view.EndDateSubject2,
                IsFinished = view.IsFinishedSubject2,
            };
            try
            {
                new Common.ModelDataValidation().Validate(model);
                if (view.IsEditSubject2)//Edit model
                {
                    repository.EditSubject1(model);
                    view.Message = "Subject 2 assigned successfuly";
                }
                else //Add new model
                {
                    repository.AddSubject1(model);
                    view.Message = "Subject 2 edited successfuly";
                }
                view.IsSuccessfull = true;
                view.IsEdit = true;
                view.IsEditSubject2 = true;
                LoadSelectedTeacher();
                CleanviewAssignSubFields();
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
            view.TeacherTelephone = "";
            view.TeacherDateOfBirth = DateOnly.FromDateTime(DateTime.Now);
            view.TeacherAge = 0;
            view.TeacherSalary = 0;
            view.TeacherGender = 0;
            view.SetTeachingSubjectListBindingSource(new BindingSource());
            view.SetTaughtSubjectListBindingSource(new BindingSource());
        }

        private void CleanviewAssignSubFields()
        {
            view.Subject1 = null;
            view.TeacherSubject1Id = 0;
            view.StartDateSubject1 = DateTime.Now;
            view.EndDateSubject1 = DateTime.Now;
            view.IsFinishedSubject1 = false;

            view.Subject2 = null;
            view.TeacherSubject2Id = 0;
            view.StartDateSubject2 = DateTime.Now;
            view.EndDateSubject2 = DateTime.Now;
            view.IsFinishedSubject2 = false;

            view.IsEditSubject1 = false;
            view.IsEditSubject2 = false;
        }

        private void CancelAction(object sender, EventArgs e)
        {
            CleanviewFields();
        }

        private void CancelSubject1(object sender, EventArgs e)
        {
            CleanviewFields();
            CleanviewAssignSubFields();
        }

        private void CancelSubject2(object sender, EventArgs e)
        {
            CleanviewFields();
            CleanviewAssignSubFields();
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
            catch (Exception)
            {   
                view.IsSuccessfull = false;
                view.Message = "An error ocurred, could not delete teacher";
            }
        }
    }
}
