using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using EducationCenter.Views.Interfaces;
using DataLayer.Repositories.Interfaces;
using DataLayer.Repositories.Classes;

namespace EducationCenter.Presenters
{
    public class MainPresenter
    {
        private IMainView mainView;

        public MainPresenter(IMainView mainView)
        {
            this.mainView = mainView;
            this.mainView.ShowTeacherView += ShowTeachersView;
        }

        private void ShowTeachersView(object sender, EventArgs e)
        {
            ITeacherView view = TeacherView.GetInstance((MainView)mainView);
            ITeacherRepository repository = new TeacherRepository();
            new TeacherPresenter(view, repository);
        }
    }
}
