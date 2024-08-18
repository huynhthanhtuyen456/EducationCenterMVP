using DataLayer.Entities.Subjects;
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
    public class SubjectPresenter
    {
        //Fields
        private ISubjectView view;
        private ISubjectRepository repository;
        private BindingSource subjectsBindingSource;
        private IEnumerable<Subject> subjectList;

        //Constructor
        public SubjectPresenter(ISubjectView view, ISubjectRepository repository)
        {
            this.subjectsBindingSource = new BindingSource();
            this.view = view;
            this.repository = repository;
            //Subscribe event handler methods to view events
            this.view.SearchEvent += SearchSubject;
            this.view.AddNewEvent += AddNewSubject;
            this.view.EditEvent += LoadSelectedSubjectToEdit;
            this.view.DeleteEvent += DeleteSelectedSubject;
            this.view.SaveEvent += SaveSubject;
            this.view.CancelEvent += CancelAction;
            //Set subjects bindind source
            this.view.SetSubjectListBindingSource(subjectsBindingSource);
            //Load subjects list view
            LoadAllSubjectList();
            //Show view
            this.view.Show();
        }

        //Methods
        private void LoadAllSubjectList()
        {
            subjectList = repository.GetAll();
            subjectsBindingSource.DataSource = subjectList;//Set data source.
        }
        private void SearchSubject(object sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            if (emptyValue == false)
                subjectList = repository.Search(this.view.SearchValue);
            else subjectList = repository.GetAll();
            subjectsBindingSource.DataSource = subjectList;
        }
        private void AddNewSubject(object sender, EventArgs e)
        {
            view.IsEdit = false;
        }
        private void LoadSelectedSubjectToEdit(object sender, EventArgs e)
        {
            var subject = (Subject)subjectsBindingSource.Current;
            view.SubjectId = subject.Id;
            view.SubjectName = subject.Name;
            view.SubjectCode = subject.Code;
            view.SubjectCredits = subject.Credits;
            view.IsEdit = true;
        }
        private void SaveSubject(object sender, EventArgs e)
        {
            Subject model = new Subject
            {
                Id = view.SubjectId,
                Name = view.SubjectName,
                Code = view.SubjectCode,
                Credits = view.SubjectCredits,
            };
            try
            {
                new Common.ModelDataValidation().Validate(model);
                if (view.IsEdit)//Edit model
                {
                    repository.Edit(model);
                    view.Message = "Subject edited successfuly";
                }
                else //Add new model
                {
                    repository.Add(model);
                    view.Message = "Subject added sucessfully";
                }
                view.IsSuccessfull = true;
                LoadAllSubjectList();
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
            view.SubjectId = 0;
            view.SubjectName = "";
            view.SubjectCode = "";
            view.SubjectCredits = 0;
        }

        private void CancelAction(object sender, EventArgs e)
        {
            CleanviewFields();
        }
        private void DeleteSelectedSubject(object sender, EventArgs e)
        {
            try
            {
                var subject = (Subject)subjectsBindingSource.Current;
                int id = repository.Delete(subject);
                view.IsSuccessfull = true;
                view.Message = $"Subject with Id={id} deleted successfully";
                LoadAllSubjectList();
            }
            catch (Exception ex)
            {
                view.IsSuccessfull = false;
                view.Message = "An error ocurred, could not delete subject";
            }
        }
    }
}
