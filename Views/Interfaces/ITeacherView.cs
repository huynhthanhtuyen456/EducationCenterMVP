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
        // Properties - Fields Related to DB Fields
        int TeacherId { get; set; }
        string TeacherFirstName { get; set; }
        string TeacherLastName { get; set; }
        DateOnly TeacherDateOfBirth { get; set; }
        GenderEnum TeacherGender { get; set; }
        int TeacherAge { get; set; }
        string TeacherEmail { get; set; }
        decimal TeacherSalary { get; set; }
        string TeacherTelephone { get; set; }

        // Properties - Related to Show Form Actions
        string SearchValue { get; set; }
        bool IsEdit { get; set; }
        bool IsSuccessfull { get; set; }
        string Message { get; set; }

        // Events
        event EventHandler SearchTeacherEvent;
        event EventHandler AddNewTeacherEvent;
        event EventHandler EditTeacherEvent;
        event EventHandler DeleteTeacherEvent;
        event EventHandler SaveTeacherEvent;
        event EventHandler CancelTeacherEvent;

        // Methods
        void SetTeacherListBindingSource(BindingSource teacherList);
        void Show();
    }
}
