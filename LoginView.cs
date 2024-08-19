using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EducationCenter
{
    public partial class LoginView : Form, ILoginView
    {
        // Private Properties
        private string message;
        private bool isSuccessfull;

        public LoginView()
        {
            InitializeComponent();
            LoginBtn.Click += delegate
            {
                LoginErrorMsgLbl.Text = string.Empty;
                ClickLoginEvent?.Invoke(this, EventArgs.Empty);
                if (!isSuccessfull)
                {
                    LoginErrorMsgLbl.Text = "Wrong email or password";
                }
            };
        }

        public int LoginId { get; set; }
        public string LoginEmail 
        { 
            get { return LoginEmailTxb.Text; }
            set {  LoginEmailTxb.Text = value; }
        }
        public string LoginPassword {
            get { return LoginPassTxb.Text; }
            set { LoginPassTxb.Text = value; }
        }
        public bool IsSuccessfull
        {
            get { return isSuccessfull; }
            set { isSuccessfull = value; }
        }
        public string Message
        {
            get { return message; }
            set { message = value; }
        }

        public event EventHandler ClickLoginEvent;
    }
}
