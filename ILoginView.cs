using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationCenter
{
    public interface ILoginView
    {
        // Properties - Fields
        int LoginId { get; set; }
        string LoginEmail { get; set; }
        string LoginPassword { get; set; }
        bool IsSuccessfull { get; set; }
        string Message { get; set; }

        // Events
        event EventHandler ClickLoginEvent;

        // Methods
        void Show();
        void Close();
    }
}
