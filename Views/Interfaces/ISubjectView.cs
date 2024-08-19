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
        event EventHandler SearchSubjectEvent;
        event EventHandler AddNewSubjectEvent;
        event EventHandler EditSubjectEvent;
        event EventHandler DeleteSubjectEvent;
        event EventHandler SaveSubjectEvent;
        event EventHandler CancelSubjectEvent;

        // Methods
        void SetSubjectListBindingSource(BindingSource subjectList);
        void Show();
    }
}
