using DataLayer.Entities.Subjects;
using Helper.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationCenter.Views.Interfaces
{
    /*
     * Expose interface to Presenter which can only use Properties and Methods defined in interface
     */
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

        // Properties - Related to Assign Subjects to Teacher
        int TeacherSubject1Id { get; set; }
        Subject Subject1 { get; set; }
        DateTime StartDateSubject1 { get; set; }
        DateTime EndDateSubject1 { get; set; }
        bool IsEditSubject1 { get; set; }
        bool IsFinishedSubject1 { get; set; }
        bool IsSuccessfullSub1 { get; set; }

        int TeacherSubject2Id { get; set; }
        Subject Subject2 { get; set; }
        DateTime StartDateSubject2 { get; set; }
        DateTime EndDateSubject2 { get; set; }
        bool IsEditSubject2 { get; set; }
        bool IsFinishedSubject2 { get; set; }
        bool IsSuccessfullSub2 { get; set; }

        // Events of Teacher Records
        event EventHandler SearchTeacherEvent;
        event EventHandler AddNewTeacherEvent;
        event EventHandler EditTeacherEvent;
        event EventHandler DeleteTeacherEvent;
        event EventHandler SaveTeacherEvent;
        event EventHandler CancelTeacherEvent;

        // Events of Assigning subjects to Teacher
        event EventHandler AssignSubjectTabPageEvent;
        event EventHandler SaveSubject1Event;
        event EventHandler CancelSubject1Event;
        event EventHandler SaveSubject2Event;
        event EventHandler CancelSubject2Event;

        /*
         * Assign Subjects to Teachers via event
         */
        /*
         * End definition Assign Subjects
         */

        // Methods
        void SetTeacherListBindingSource(BindingSource teacherList);
        void SetSubjectListCombox1BindingSource(BindingSource subjectList);
        void SetSubjectListCombox2BindingSource(BindingSource subjectList);
        void SetTeachingSubjectListBindingSource(BindingSource teachingSubjectList);
        void SetTaughtSubjectListBindingSource(BindingSource taughtSubjectList);
        void Show();
    }
}
