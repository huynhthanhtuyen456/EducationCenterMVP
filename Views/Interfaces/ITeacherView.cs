using Helper.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationCenter.Views.Interfaces
{
    public interface ITeacherView
    {
        // Properties - Fields
        int TeacherId { get; set; }
        string TeacherFirstName { get; set; }
        string TeacherLastName { get; set; }
        DateOnly TeacherDateOfBirth { get; set; }
        GenderEnum TeacherGender { get; set; }
        int TeacherAge { get; set; }
        string TeacherEmail { get; set; }
        decimal TeacherSalary { get; set; }
        string TeacherTelephone { get; set; }

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
        void SetTeacherListBindingSource(BindingSource teacherList);
        void Show();
    }
}
