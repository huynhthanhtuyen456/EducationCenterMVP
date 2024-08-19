using DataLayer.Repositories.Classes;
using DataLayer.Repositories.Interfaces;
using EducationCenter.Views.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationCenter.Presenters
{
    public class LoginPresenter
    {
        private ILoginView loginView;
        private ILoginRepository repository;

        public LoginPresenter(ILoginView view)
        {
            this.loginView = view;
            this.repository = new LoginRepository();
            //Subscribe event handler methods to view events
            this.loginView.ClickLoginEvent += HandleLoginEvent;
        }

        private void CleanviewFields()
        {
            loginView.LoginEmail = "";
            loginView.LoginPassword = "";
        }

        public void HandleLoginEvent (object sender, EventArgs e)
        {
            try
            {
                bool isLogined = repository.GetAccount(loginView.LoginEmail, loginView.LoginPassword);
                loginView.IsSuccessfull = isLogined;
                if (isLogined) 
                {
                    this.loginView.Close();
                }
                CleanviewFields();
            }
            catch (Exception ex)
            {
                loginView.IsSuccessfull = false;
                loginView.Message = ex.Message;
            }
        }
    }
}
