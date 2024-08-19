using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using EducationCenter.Views.Interfaces;
using DataLayer.Repositories.Interfaces;
using DataLayer.Repositories.Classes;
using EducationCenter.Views.Classes;
using EducationCenter.Presenters.Classes;

namespace EducationCenter.Presenters
{
    public class MainPresenter
    {
        private IMainView mainView;

        public MainPresenter(IMainView mainView)
        {
            this.mainView = mainView;
            this.mainView.ShowTeacherView += ShowTeacherView;
            this.mainView.ShowSubjectView += ShowSubjectView;
            this.mainView.ShowStudentView += ShowStudentView;
        }

        private void ShowTeacherView(object sender, EventArgs e)
        {
            ITeacherView view = TeacherView.GetInstance((MainView)mainView);
            ITeacherRepository repository = new TeacherRepository();
            new TeacherPresenter(view, repository);
        }

        private void ShowSubjectView(object sender, EventArgs e)
        {
            ISubjectView view = SubjectView.GetInstance((MainView)mainView);
            ISubjectRepository repository = new SubjectRepository();
            new SubjectPresenter(view, repository);
        }

        private void ShowStudentView(object sender, EventArgs e)
        {
            IStudentView view = StudentView.GetInstance((MainView)mainView);
            IStudentRepository repository = new StudentRepository();
            new StudentPresenter(view, repository);
        }
    }
}
