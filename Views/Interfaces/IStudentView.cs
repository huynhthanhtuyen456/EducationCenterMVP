using Helper.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationCenter.Views.Interfaces
{
    public interface IStudentView
    {
        // Properties - Fields Related to DB Fields
        int StudentId { get; set; }
        string StudentFirstName { get; set; }
        string StudentLastName { get; set; }
        DateOnly StudentDateOfBirth { get; set; }
        GenderEnum StudentGender { get; set; }
        int StudentAge { get; set; }
        string StudentEmail { get; set; }
        string StudentTelephone { get; set; }

        // Properties - Related to Show Form Actions
        string SearchValue { get; set; }
        bool IsEdit { get; set; }
        bool IsSuccessfull { get; set; }
        string Message { get; set; }

        // Events
        event EventHandler SearchStudentEvent;
        event EventHandler AddNewStudentEvent;
        event EventHandler EditStudentEvent;
        event EventHandler DeleteStudentEvent;
        event EventHandler SaveStudentEvent;
        event EventHandler CancelStudentEvent;

        // Methods
        void SetStudentListBindingSource(BindingSource studentList);
        void Show();
    }
}
