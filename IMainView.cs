using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationCenter
{
    public interface IMainView
    {
        event EventHandler ShowAdministratorView;
        event EventHandler ShowTeacherView;
        event EventHandler ShowStudentView;
        event EventHandler ShowSubjectView;
        event EventHandler LogOutEvent;
        bool IsLoggedOut { get; set; }
        void Show();
        void Close();
    }
}
