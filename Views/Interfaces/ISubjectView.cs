using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationCenter.Views.Interfaces
{
    public interface ISubjectView
    {
        // Properties - Fields
        int SubjectId { get; set; }
        string SubjectName { get; set; }
        string SubjectCode { get; set; }
        int SubjectCredits { get; set; }
        string SearchValue { get; set; }
        bool IsEdit { get; set; }
        bool IsSuccessfull { get; set; }
        string Message { get; set; }

        // Events
        event EventHandler SearchEvent;
        event EventHandler AddNewEvent;
        event EventHandler EditEvent;
        event EventHandler DeleteEvent;
        event EventHandler SaveEvent;
        event EventHandler CancelEvent;

        // Methods
        void SetSubjectListBindingSource(BindingSource subjectList);
        void Show();
    }
}
